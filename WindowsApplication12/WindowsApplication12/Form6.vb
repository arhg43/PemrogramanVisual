Imports MySql.Data.MySqlClient

Public Class Form6
    ' Saat form dimuat
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilData() ' Tampilkan data pemesanan

        ' Isi pilihan lapangan ke ComboBox
        cmbLapangan.Items.Clear()
        For i As Integer = 1 To 6
            cmbLapangan.Items.Add("Lapangan " & i)
        Next

        ' Batasi tanggal hanya mulai hari ini
        dtpTanggal.MinDate = DateTime.Today
    End Sub

    ' Tampilkan data dari hari ini ke depan
    Sub TampilData()
        Call Koneksi()
        Dim hariIni As String = Format(DateTime.Today, "yyyy-MM-dd")
        da = New MySqlDataAdapter("SELECT * FROM pemesanan WHERE tanggal >= '" & hariIni & "'", conn)
        ds = New DataSet
        da.Fill(ds, "pemesanan")
        DataGridView1.DataSource = ds.Tables("pemesanan")
    End Sub

    ' Kosongkan input
    Sub Kosongkan()
        txtNama.Clear()
        TxtNomorTelepon.Clear()
        txtJamMulai.Clear()
        txtJamSelesai.Clear()
        cmbLapangan.SelectedIndex = -1
        txtTotalHarga.Clear()
        txtCari.Clear()
    End Sub

    ' Simpan data baru
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim jamMulai As TimeSpan
        Dim jamSelesai As TimeSpan

        ' Validasi format jam dan pastikan jam selesai > jam mulai
        If TimeSpan.TryParse(txtJamMulai.Text, jamMulai) AndAlso TimeSpan.TryParse(txtJamSelesai.Text, jamSelesai) Then
            If jamSelesai <= jamMulai Then
                MessageBox.Show("Jam selesai harus lebih besar dari jam mulai.")
                Exit Sub
            End If
        Else
            MessageBox.Show("Format jam tidak valid. Gunakan format HH:mm.")
            Exit Sub
        End If

        Call Koneksi()
        Try
            Dim tanggalBooking As String = Format(dtpTanggal.Value, "yyyy-MM-dd")

            ' Cek apakah jadwal sudah ada
            Dim cekQuery As String = "SELECT COUNT(*) FROM pemesanan WHERE tanggal = @tanggal AND jam_mulai = @jam_mulai AND lapangan = @lapangan"
            cmd = New MySqlCommand(cekQuery, conn)
            cmd.Parameters.AddWithValue("@tanggal", tanggalBooking)
            cmd.Parameters.AddWithValue("@jam_mulai", txtJamMulai.Text)
            cmd.Parameters.AddWithValue("@lapangan", cmbLapangan.Text)

            Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            If jumlah > 0 Then
                MessageBox.Show("Lapangan sudah dipesan pada waktu tersebut.")
                Exit Sub
            End If

            ' Simpan data ke database
            Dim simpan As String = "INSERT INTO pemesanan (nama, no_telepon, tanggal, jam_mulai, jam_selesai, lapangan, total_harga, status) " &
                                   "VALUES (@nama, @no_telp, @tanggal, @jam_mulai, @jam_selesai, @lapangan, @total_harga, )"
            cmd = New MySqlCommand(simpan, conn)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@no_telp", TxtNomorTelepon.Text)
            cmd.Parameters.AddWithValue("@tanggal", tanggalBooking)
            cmd.Parameters.AddWithValue("@jam_mulai", txtJamMulai.Text)
            cmd.Parameters.AddWithValue("@jam_selesai", txtJamSelesai.Text)
            cmd.Parameters.AddWithValue("@lapangan", cmbLapangan.Text)
            cmd.Parameters.AddWithValue("@total_harga", txtTotalHarga.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data berhasil disimpan.")
            Call TampilData()
            Call Kosongkan()
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message)
        End Try
    End Sub

    ' Tombol Cari ditekan
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Call Koneksi()
        Try
            Dim hariIni As String = Format(DateTime.Today, "yyyy-MM-dd")
            da = New MySqlDataAdapter("SELECT * FROM pemesanan WHERE nama LIKE '%" & txtCari.Text & "%' AND tanggal >= '" & hariIni & "'", conn)
            ds = New DataSet
            da.Fill(ds, "pemesanan")
            DataGridView1.DataSource = ds.Tables("pemesanan")
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message)
        End Try
    End Sub

End Class
