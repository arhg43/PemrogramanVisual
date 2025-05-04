Imports MySql.Data.MySqlClient  ' Mengimpor pustaka MySQL untuk koneksi ke database

Public Class Form3
    ' Membuat objek dictionary untuk menyimpan data lama pemesanan
    Dim oldData As New Dictionary(Of String, String)

    ' Event handler yang dijalankan ketika Form3 dimuat
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mengisi ComboBox untuk memilih lapangan (1 hingga 6)
        cmbLapangan.Items.Clear()  ' Menghapus item lama di combo box
        For i As Integer = 1 To 6  ' Menambahkan lapangan 1 hingga 6
            cmbLapangan.Items.Add(i)
        Next

        ' Mengisi ComboBox untuk status pemesanan
        cmbStatus.Items.Clear()  ' Menghapus item lama di combo box
        cmbStatus.Items.Add("Belum Bayar")  ' Menambahkan status "Belum Bayar"
        cmbStatus.Items.Add("Sudah Bayar")  ' Menambahkan status "Sudah Bayar"
        cmbStatus.Items.Add("Dibatalkan")  ' Menambahkan status "Dibatalkan"

        ' Mengisi ComboBox untuk lama sewa lapangan
        cmbLamaSewa.Items.Clear()  ' Menghapus item lama di combo box
        For i As Integer = 1 To 6  ' Menambahkan pilihan lama sewa dari 1 hingga 6 jam
            cmbLamaSewa.Items.Add(i & " Jam")
        Next
        cmbLamaSewa.Items.Add("24 Jam")  ' Menambahkan pilihan "24 Jam"
    End Sub

    ' Fungsi untuk menyimpan data lama berdasarkan nama pemesan
    Private Sub SimpanDataLama(nama As String)
        Call Koneksi()  ' Membuka koneksi ke database
        Dim query As String = "SELECT * FROM pemesanan WHERE nama = @nama LIMIT 1"  ' Query untuk mengambil data pemesanan berdasarkan nama
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@nama", nama)  ' Menambahkan parameter nama ke query

        Dim reader As MySqlDataReader = cmd.ExecuteReader()  ' Menjalankan query dan membaca hasilnya
        If reader.Read() Then  ' Jika data ditemukan
            ' Menyimpan data lama ke dictionary
            oldData("no_telepon") = reader("no_telepon").ToString()
            oldData("tanggal") = reader("tanggal").ToString()
            oldData("jam_mulai") = reader("jam_mulai").ToString()
            oldData("jam_selesai") = reader("jam_selesai").ToString()
            oldData("lapangan") = reader("lapangan").ToString()
            oldData("status") = reader("status").ToString()
            oldData("total_harga") = reader("total_harga").ToString()
        End If
        reader.Close()  ' Menutup reader setelah selesai mengambil data
    End Sub

    ' Event handler untuk tombol "Ubah" (ubah data pemesanan)
    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If txtNama.Text = "" Then  ' Jika nama kosong, tampilkan pesan kesalahan
            MessageBox.Show("Masukkan nama untuk mengubah data.")
            Exit Sub
        End If

        Dim nama As String = txtNama.Text  ' Mengambil nama pemesan
        Call SimpanDataLama(nama)  ' Memanggil fungsi untuk menyimpan data lama pemesanan

        ' Mengambil input dari form dan jika kosong, menggunakan data lama
        Dim noTelp As String = If(TxtNomorTelepon.Text = "", oldData("no_telepon"), TxtNomorTelepon.Text)
        Dim tanggal As String = If(dtpTanggal.Text = "", oldData("tanggal"), Format(dtpTanggal.Value, "yyyy-MM-dd"))
        Dim jamMulai As String = If(txtJamMulai.Text = "", oldData("jam_mulai"), txtJamMulai.Text)
        Dim lamaSewaText As String = If(cmbLamaSewa.Text = "", "", cmbLamaSewa.Text)
        Dim lapangan As String = If(cmbLapangan.Text = "", oldData("lapangan"), cmbLapangan.Text)
        Dim status As String = If(cmbStatus.Text = "", oldData("status"), cmbStatus.Text)

        ' Menentukan lama sewa dalam jam berdasarkan input pengguna atau data lama
        Dim lamaSewa As Integer = 0
        If lamaSewaText = "" Then
            ' Menghitung lama sewa berdasarkan perbedaan jam mulai dan jam selesai
            lamaSewa = Val(oldData("jam_selesai").Split(":"c)(0)) - Val(oldData("jam_mulai").Split(":"c)(0))
        Else
            ' Jika lama sewa "24 Jam"
            If lamaSewaText = "24 Jam" Then
                lamaSewa = 24
            Else
                lamaSewa = Val(lamaSewaText.Split(" "c)(0))  ' Menyimpan lama sewa dalam jam
            End If
        End If

        ' Validasi format jam mulai (HH:mm)
        Dim jamMulaiDate As DateTime
        If Not DateTime.TryParseExact(jamMulai, "HH:mm", Nothing, Globalization.DateTimeStyles.None, jamMulaiDate) Then
            MessageBox.Show("Format jam mulai salah (gunakan HH:mm)")
            Exit Sub
        End If

        ' Menentukan jam selesai berdasarkan jam mulai dan lama sewa
        Dim jamSelesai As String = jamMulaiDate.AddHours(lamaSewa).ToString("HH:mm")

        ' Menghitung total harga berdasarkan lama sewa
        Dim totalHarga As Integer = If(lamaSewa = 24, 1200000, lamaSewa * 120000)

        Try
            Call Koneksi()  ' Membuka koneksi ke database
            ' Query untuk mengubah data pemesanan
            Dim update As String = "UPDATE pemesanan SET no_telepon = @noTelp, tanggal = @tanggal, jam_mulai = @jamMulai, jam_selesai = @jamSelesai, lapangan = @lapangan, total_harga = @totalHarga, status = @status WHERE nama = @nama"
            cmd = New MySqlCommand(update, conn)
            ' Menambahkan parameter ke query update
            cmd.Parameters.AddWithValue("@noTelp", noTelp)
            cmd.Parameters.AddWithValue("@tanggal", tanggal)
            cmd.Parameters.AddWithValue("@jamMulai", jamMulai)
            cmd.Parameters.AddWithValue("@jamSelesai", jamSelesai)
            cmd.Parameters.AddWithValue("@lapangan", lapangan)
            cmd.Parameters.AddWithValue("@totalHarga", totalHarga)
            cmd.Parameters.AddWithValue("@status", status)
            cmd.Parameters.AddWithValue("@nama", nama)
            cmd.ExecuteNonQuery()  ' Menjalankan query untuk mengubah data

            MessageBox.Show("Data berhasil diubah.")  ' Menampilkan pesan sukses
            Me.Close()  ' Menutup Form3
            Form2.Show()  ' Menampilkan Form2 setelah data diubah
        Catch ex As Exception
            ' Menampilkan pesan jika terjadi kesalahan saat mengubah data
            MessageBox.Show("Gagal mengubah data: " & ex.Message)
        End Try
    End Sub

    ' Event handler untuk tombol "Kembali" (kembali ke Form2)
    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()  ' Menutup Form3
        Form2.Show()  ' Menampilkan Form2
    End Sub
End Class
