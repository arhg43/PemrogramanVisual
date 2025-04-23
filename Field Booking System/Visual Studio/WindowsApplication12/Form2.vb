Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilData()

        ' Isi ComboBox Lapangan dengan pilihan Lapangan 1 sampai 6
        cmbLapangan.Items.Clear()
        For i As Integer = 1 To 6
            cmbLapangan.Items.Add("Lapangan " & i)
        Next
    End Sub

    Sub TampilData()
        Call Koneksi()
        da = New MySqlDataAdapter("SELECT * FROM pemesanan", conn)
        ds = New DataSet
        da.Fill(ds, "pemesanan")
        DataGridView1.DataSource = ds.Tables("pemesanan")
    End Sub

    Sub Kosongkan()
        txtNama.Clear()
        TxtNomorTelepon.Clear()
        txtGmail.Clear()
        txtJamMulai.Clear()
        txtJamSelesai.Clear()
        cmbLapangan.SelectedIndex = -1
        txtTotalHarga.Clear()
        txtCari.Clear()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call Koneksi()
        Try
            Dim simpan As String = "INSERT INTO pemesanan (nama, no_telepon, email, tanggal, jam_mulai, jam_selesai, lapangan, total_harga) " &
                                   "VALUES (@nama, @no_telp, @email, @tanggal, @jam_mulai, @jam_selesai, @lapangan, @total_harga)"
            cmd = New MySqlCommand(simpan, conn)
            cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            cmd.Parameters.AddWithValue("@no_telp", TxtNomorTelepon.Text)
            cmd.Parameters.AddWithValue("@email", txtGmail.Text)
            cmd.Parameters.AddWithValue("@tanggal", Format(dtpTanggal.Value, "yyyy-MM-dd"))
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

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnLihat_Click(sender As Object, e As EventArgs) Handles btnLihat.Click
        Form4.Show()
        Me.Hide()
    End Sub
End Class
