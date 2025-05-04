Imports MySql.Data.MySqlClient  ' Mengimpor library MySQL untuk koneksi ke database

Public Class Form2

    ' Saat Form2 dimuat
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilData()  ' Menampilkan data pemesanan ke DataGridView saat form dibuka

        ' Isi ComboBox Lapangan (Lapangan 1 hingga 6)
        cmbLapangan.Items.Clear()  ' Menghapus semua item lama dari ComboBox
        For i As Integer = 1 To 6
            cmbLapangan.Items.Add(i)  ' Menambahkan nomor lapangan 1-6 ke ComboBox
        Next

        ' Isi ComboBox Status dengan pilihan 'Belum Bayar', 'Sudah Bayar', 'Dibatalkan'
        cmbStatus.Items.Clear()  ' Menghapus semua item lama dari ComboBox
        cmbStatus.Items.Add("Belum Bayar")  ' Menambahkan pilihan status 'Belum Bayar'
        cmbStatus.Items.Add("Sudah Bayar")  ' Menambahkan pilihan status 'Sudah Bayar'
        cmbStatus.Items.Add("Dibatalkan")  ' Menambahkan pilihan status 'Dibatalkan'

        ' Isi ComboBox Lama Sewa (1 Jam hingga 6 Jam, dan 24 Jam)
        cmbLamaSewa.Items.Clear()  ' Menghapus semua item lama dari ComboBox
        For i As Integer = 1 To 6
            cmbLamaSewa.Items.Add(i & " Jam")  ' Menambahkan pilihan lama sewa (1 jam sampai 6 jam)
        Next
        cmbLamaSewa.Items.Add("24 Jam")  ' Menambahkan pilihan untuk sewa 24 jam

        dtpTanggal.MinDate = DateTime.Today  ' Mengatur tanggal minimum di DateTimePicker menjadi hari ini
    End Sub

    ' Menampilkan data pemesanan ke DataGridView
    Sub TampilData()
        Call Koneksi()  ' Memanggil koneksi ke database
        da = New MySqlDataAdapter("SELECT * FROM pemesanan", conn)  ' Query untuk mengambil seluruh data dari tabel 'pemesanan'
        ds = New DataSet  ' Membuat objek DataSet untuk menampung data
        da.Fill(ds, "pemesanan")  ' Mengisi dataset dengan hasil query
        DataGridView1.DataSource = ds.Tables("pemesanan")  ' Menampilkan data ke DataGridView
    End Sub

    ' Mengosongkan input form
    Sub Kosongkan()
        txtNama.Clear()  ' Mengosongkan TextBox Nama
        TxtNomorTelepon.Clear()  ' Mengosongkan TextBox Nomor Telepon
        txtJamMulai.Clear()  ' Mengosongkan TextBox Jam Mulai
        cmbLamaSewa.SelectedIndex = -1  ' Mengatur ComboBox Lama Sewa ke posisi tidak ada yang dipilih
        cmbLapangan.SelectedIndex = -1  ' Mengatur ComboBox Lapangan ke posisi tidak ada yang dipilih
        cmbStatus.SelectedIndex = -1  ' Mengatur ComboBox Status ke posisi tidak ada yang dipilih
        txtCari.Clear()  ' Mengosongkan TextBox Cari
    End Sub

    ' Fungsi untuk menyimpan data pemesanan
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call Koneksi()  ' Membuka koneksi ke database

        ' Validasi format waktu jam mulai
        Dim jamMulai As String = txtJamMulai.Text
        If Not IsValidTimeFormat(jamMulai) Then
            MessageBox.Show("Jam Mulai harus dalam format HH:mm (misalnya 08:00).")  ' Menampilkan pesan jika format jam mulai salah
            Exit Sub  ' Keluar dari prosedur jika format jam salah
        End If

        ' Validasi apakah lama sewa sudah dipilih
        If cmbLamaSewa.SelectedIndex = -1 Then
            MessageBox.Show("Pilih lama sewa lapangan.")  ' Menampilkan pesan jika lama sewa belum dipilih
            Exit Sub
        End If

        ' Menghitung waktu selesai berdasarkan lama sewa
        Dim lamaSewa As Integer = Integer.Parse(cmbLamaSewa.SelectedItem.ToString().Split(" ")(0))  ' Mengambil nilai lama sewa dari ComboBox
        Dim jamMulaiDateTime As DateTime = DateTime.ParseExact(jamMulai, "HH:mm", Nothing)  ' Mengonversi jam mulai menjadi DateTime
        Dim jamSelesai As DateTime = jamMulaiDateTime.AddHours(lamaSewa)  ' Menambahkan jam sewa ke jam mulai untuk menghitung jam selesai
        Dim jamSelesaiFormatted As String = jamSelesai.ToString("HH:mm")  ' Mengubah format jam selesai menjadi HH:mm

        ' Menghitung harga total berdasarkan lama sewa
        Dim totalHarga As Integer
        If lamaSewa = 24 Then
            totalHarga = 1200000  ' Harga untuk sewa 24 jam
        Else
            totalHarga = lamaSewa * 120000  ' Harga per jam untuk lama sewa 1-6 jam
        End If

        Try
            ' Mengecek apakah lapangan sudah dipesan pada tanggal dan jam yang sama
            Dim cekPemesanan As String = "SELECT COUNT(*) FROM pemesanan WHERE tanggal = @tanggal AND lapangan = @lapangan AND ((jam_mulai <= @jam_selesai AND jam_selesai >= @jam_mulai))"
            cmd = New MySqlCommand(cekPemesanan, conn)
            cmd.Parameters.AddWithValue("@tanggal", Format(dtpTanggal.Value, "yyyy-MM-dd"))  ' Menambahkan parameter tanggal
            cmd.Parameters.AddWithValue("@lapangan", Convert.ToInt32(cmbLapangan.Text))  ' Menambahkan parameter lapangan
            cmd.Parameters.AddWithValue("@jam_mulai", jamMulai)  ' Menambahkan parameter jam mulai
            cmd.Parameters.AddWithValue("@jam_selesai", jamSelesaiFormatted)  ' Menambahkan parameter jam selesai

            ' Mengeksekusi query dan mengecek apakah ada pemesanan yang bentrok
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())  ' Menghitung jumlah pemesanan yang bentrok
            If count > 0 Then
                MessageBox.Show("Lapangan sudah dipesan pada waktu yang sama.")  ' Menampilkan pesan jika lapangan sudah dipesan
            Else
                ' Menyimpan data pemesanan jika lapangan belum dipesan
                Dim simpan As String = "INSERT INTO pemesanan (nama, no_telepon, tanggal, jam_mulai, jam_selesai, lapangan, total_harga, status) " & _
                                       "VALUES (@nama, @no_telp, @tanggal, @jam_mulai, @jam_selesai, @lapangan, @total_harga, @status)"
                cmd = New MySqlCommand(simpan, conn)
                cmd.Parameters.AddWithValue("@nama", txtNama.Text)  ' Menambahkan parameter nama
                cmd.Parameters.AddWithValue("@no_telp", TxtNomorTelepon.Text)  ' Menambahkan parameter nomor telepon
                cmd.Parameters.AddWithValue("@tanggal", Format(dtpTanggal.Value, "yyyy-MM-dd"))  ' Menambahkan parameter tanggal
                cmd.Parameters.AddWithValue("@jam_mulai", jamMulai)  ' Menambahkan parameter jam mulai
                cmd.Parameters.AddWithValue("@jam_selesai", jamSelesaiFormatted)  ' Menambahkan parameter jam selesai
                cmd.Parameters.AddWithValue("@lapangan", Convert.ToInt32(cmbLapangan.Text))  ' Menambahkan parameter lapangan
                cmd.Parameters.AddWithValue("@total_harga", totalHarga)  ' Menambahkan parameter harga total
                cmd.Parameters.AddWithValue("@status", cmbStatus.Text)  ' Menambahkan parameter status pembayaran
                cmd.ExecuteNonQuery()  ' Menjalankan query untuk menyimpan data
                MessageBox.Show("Data berhasil disimpan.")  ' Menampilkan pesan bahwa data berhasil disimpan
                Call TampilData()  ' Memanggil kembali fungsi TampilData untuk memperbarui DataGridView
                Call Kosongkan()  ' Mengosongkan form input
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message)  ' Menampilkan pesan jika ada kesalahan saat menyimpan data
        End Try
    End Sub

    ' Fungsi untuk validasi format waktu (HH:mm)
    Private Function IsValidTimeFormat(time As String) As Boolean
        Dim format As String = "HH:mm"
        Dim tempDate As DateTime
        Return DateTime.TryParseExact(time, format, Nothing, Globalization.DateTimeStyles.None, tempDate)  ' Memastikan format waktu sesuai dengan HH:mm
    End Function

    ' Fungsi untuk mencari pemesanan berdasarkan nama
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Call Koneksi()  ' Membuka koneksi ke database
        Try
            ' Mencari data pemesanan yang nama-nya mengandung teks dari txtCari
            da = New MySqlDataAdapter("SELECT * FROM pemesanan WHERE nama LIKE '%" & txtCari.Text & "%'", conn)
            ds = New DataSet  ' Membuat objek DataSet
            da.Fill(ds, "pemesanan")  ' Mengisi dataset dengan hasil query
            DataGridView1.DataSource = ds.Tables("pemesanan")  ' Menampilkan data hasil pencarian ke DataGridView
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message)  ' Menampilkan pesan jika terjadi kesalahan saat mencari data
        End Try
    End Sub

    ' Fungsi untuk mengubah data pemesanan
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Form3.Show()  ' Menampilkan Form3 untuk mengubah data pemesanan
        Me.Hide()  ' Menyembunyikan Form2
    End Sub

    ' Fungsi untuk menghapus data pemesanan
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        ' Menampilkan pesan konfirmasi sebelum menghapus data
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus pemesanan ini?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Call Koneksi()  ' Membuka koneksi ke database
            Try
                ' Menghapus data pemesanan berdasarkan ID pemesanan yang dipilih di DataGridView
                Dim idPemesanan As Integer = Convert.ToInt32(DataGridView1.CurrentRow.Cells("id_pemesanan").Value)
                Dim hapus As String = "DELETE FROM pemesanan WHERE id_pemesanan = @id_pemesanan"
                cmd = New MySqlCommand(hapus, conn)
                cmd.Parameters.AddWithValue("@id_pemesanan", idPemesanan)  ' Menambahkan parameter ID pemesanan
                cmd.ExecuteNonQuery()  ' Menjalankan query untuk menghapus data
                MessageBox.Show("Data berhasil dihapus.")  ' Menampilkan pesan bahwa data berhasil dihapus
                Call TampilData()  ' Memperbarui DataGridView dengan data terbaru
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus data: " & ex.Message)  ' Menampilkan pesan jika terjadi kesalahan saat menghapus data
            End Try
        End If
    End Sub

End Class
