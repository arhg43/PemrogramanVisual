Imports MySql.Data.MySqlClient

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilData()
    End Sub

    Sub TampilData()
        Call Koneksi()
        da = New MySqlDataAdapter("SELECT * FROM pemesanan", conn)
        ds = New DataSet
        da.Fill(ds, "pemesanan")
        DataGridView1.DataSource = ds.Tables("pemesanan")
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

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call Koneksi()
        Try
            If DataGridView1.CurrentRow IsNot Nothing Then
                Dim namaDipilih As String = DataGridView1.CurrentRow.Cells("nama").Value.ToString()
                Dim konfirmasi As DialogResult = MessageBox.Show("Yakin ingin menghapus data dengan nama '" & namaDipilih & "'?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If konfirmasi = DialogResult.Yes Then
                    Dim hapus As String = "DELETE FROM pemesanan WHERE nama = @nama"
                    cmd = New MySqlCommand(hapus, conn)
                    cmd.Parameters.AddWithValue("@nama", namaDipilih)
                    Dim result As Integer = cmd.ExecuteNonQuery()
                    If result > 0 Then
                        MessageBox.Show("Data berhasil dihapus.")
                        Call TampilData()
                        txtCari.Clear()
                    Else
                        MessageBox.Show("Data tidak ditemukan atau gagal dihapus.")
                    End If
                End If
            Else
                MessageBox.Show("Pilih dulu data yang ingin dihapus di tabel.")
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menghapus data: " & ex.Message)
        End Try
    End Sub


    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
