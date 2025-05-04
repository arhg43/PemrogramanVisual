Imports MySql.Data.MySqlClient  ' Mengimpor library MySQL Connector untuk koneksi ke database MySQL

Public Class Form6
    ' Saat Form6 dimuat
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilData()  ' Menampilkan data dari tabel "pemesanan" saat form dibuka

        ' Mengisi ComboBox cmbLapangan dengan pilihan Lapangan 1 sampai Lapangan 6
        cmbLapangan.Items.Clear()
        For i As Integer = 1 To 6
            cmbLapangan.Items.Add("Lapangan " & i)
        Next

        ' Mengisi ComboBox cmbLamaSewa dengan 1-6 Jam dan 24 Jam
        cmbLamaSewa.Items.Clear()
        For i As Integer = 1 To 6
            cmbLamaSewa.Items.Add(i & " Jam")
        Next
        cmbLamaSewa.Items.Add("24 Jam")

        ' Mencegah pemilihan tanggal sebelum hari ini
        dtpTanggal.MinDate = DateTime.Today
    End Sub

    ' Menampilkan data pemesanan ke DataGridView
    Sub TampilData()
        Call Koneksi()  ' Memanggil prosedur koneksi ke database
        da = New MySqlDataAdapter("SELECT * FROM pemesanan", conn)  ' Query untuk mengambil seluruh data
        ds = New DataSet
        da.Fill(ds, "pemesanan")  ' Mengisi dataset
        DataGridView1.DataSource = ds.Tables("pemesanan")  ' Menampilkan dataset ke DataGridView
    End Sub

    ' Mengosongkan form input
    Sub Kosongkan()
        txtNama.Clear()
        TxtNomorTelepon.Clear()
        txtJamMulai.Clear()
        cmbLapangan.SelectedIndex = -1
        cmbLamaSewa.SelectedIndex = -1
        txtCari.Clear()
    End Sub

    ' Saat tombol Simpan ditekan
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call Koneksi()  ' Membuka koneksi ke database

        Try
            ' Validasi apakah user sudah memilih lama sewa
            If cmbLamaSewa.SelectedIndex = -1 Then
                MessageBox.Show("Pilih lama sewa terlebih dahulu.")
                Exit Sub
            End If

            ' Validasi format jam mulai (HH:mm)
            Dim jamMulai As String = txtJamMulai.Text
            If Not IsValidTimeFormat(jamMulai) Then
                MessageBox.Show("Jam Mulai harus dalam format HH:mm.")
                Exit Sub
            End If

            ' Hitung jam selesai berdasarkan lama sewa
            Dim lamaSewa As Integer = Integer.Parse(cmbLamaSewa.SelectedItem.ToString().Split(" ")(0))
            Dim jamMulaiDateTime As DateTime = DateTime.ParseExact(jamMulai, "HH:mm", Nothing)
            Dim jamSelesaiDateTime As DateTime = jamMulaiDateTime.AddHours(lamaSewa)
            Dim jamSelesaiFormatted As String = jamSelesaiDateTime.ToString("HH:mm")

            ' Ambil nomor lapangan dari ComboBox
            Dim lapanganNomor As Integer = Convert.ToInt32(cmbLapangan.Text.Replace("Lapangan ", ""))

            ' Cek apakah jadwal lapangan bentrok (jam mulai <= jam selesai existing AND jam selesai >= jam mulai existing)
            Dim cekPemesanan As String = "SELECT COUNT(*) FROM pemesanan WHERE tanggal = @tanggal AND lapangan = @lapangan AND ((jam_mulai <= @jam_selesai AND jam_selesai >= @jam_mulai))"
            cmd = New MySqlCommand(cekPemesanan, conn)
            cmd.Parameters.AddWithValue("@tanggal", Format(dtpTanggal.Value, "yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@lapangan", lapanganNomor)
            cmd.Parameters.AddWithValue("@jam_mulai", jamMulai)
            cmd.Parameters.AddWithValue("@jam_selesai", jamSelesaiFormatted)

            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("Lapangan sudah dipesan pada waktu tersebut.")
                Exit Sub
            End If

            ' Hitung total harga
            Dim totalHarga As Integer
            If lamaSewa = 24 Then
                totalHarga = 1200000 ' Harga khusus untuk sewa 24 jam
            Else
                totalHarga = lamaSewa * 120000 ' Harga normal per jam
            End If

            ' Simpan data ke database
            Dim simpan As String = "INSERT INTO pemesanan (nama, no_telepon, tanggal, jam_mulai, jam_selesai, lapangan, total_harga) " & _
                                   "VALUES (@nama, @no_telp, @tanggal, @jam_mulai, @jam_selesai, @lapangan, @total_harga)"
            cmd = New MySqlCommand(simpan, conn)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@no_telp", TxtNomorTelepon.Text)
            cmd.Parameters.AddWithValue("@tanggal", Format(dtpTanggal.Value, "yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@jam_mulai", jamMulai)
            cmd.Parameters.AddWithValue("@jam_selesai", jamSelesaiFormatted)
            cmd.Parameters.AddWithValue("@lapangan", lapanganNomor)
            cmd.Parameters.AddWithValue("@total_harga", totalHarga)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil disimpan.")
            Call TampilData()
            Call Kosongkan()

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message)
        End Try
    End Sub

    ' Fungsi untuk validasi format waktu (HH:mm)
    Private Function IsValidTimeFormat(time As String) As Boolean
        Dim format As String = "HH:mm"
        Dim tempDate As DateTime
        Return DateTime.TryParseExact(time, format, Nothing, Globalization.DateTimeStyles.None, tempDate)
    End Function

    ' Saat tombol Cari ditekan
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Call Koneksi()
        Try
            da = New MySqlDataAdapter("SELECT * FROM pemesanan WHERE nama LIKE '%" & txtCari.Text & "%'", conn)
            ds = New DataSet
            da.Fill(ds, "pemesanan")
            DataGridView1.DataSource = ds.Tables("pemesanan")
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message)
        End Try
    End Sub

    ' Format tampilan kolom total_harga dengan pemisah ribuan (contoh: 120,000)
    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.RowIndex >= 0 Then
            ' Format kolom total_harga
            If DataGridView1.Columns(e.ColumnIndex).Name = "total_harga" Then
                If e.Value IsNot Nothing Then
                    e.Value = Convert.ToInt32(e.Value).ToString("N0")
                End If
            End If
        End If
    End Sub
End Class
