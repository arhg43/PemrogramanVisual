Imports MySql.Data.MySqlClient

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbLapangan.Items.Clear()
        For i As Integer = 1 To 6
            cmbLapangan.Items.Add("Lapangan " & i)
        Next

        cmbStatus.Items.Clear()
        cmbStatus.Items.Add("Belum Lunas")
        cmbStatus.Items.Add("Lunas")
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Silakan masukkan nama untuk diubah.")
            Exit Sub
        End If

        Call Koneksi()
        Try
            Dim cmdCek As New MySqlCommand("SELECT * FROM pemesanan WHERE nama = @nama", conn)
            cmdCek.Parameters.AddWithValue("@nama", txtNama.Text)
            Dim rd As MySqlDataReader = cmdCek.ExecuteReader()

            If rd.Read() Then
                Dim teleponLama As String = rd("no_telepon").ToString()
                Dim emailLama As String = rd("email").ToString()
                Dim tanggalLama As String = rd("tanggal").ToString()
                Dim jamMulaiLama As String = rd("jam_mulai").ToString()
                Dim jamSelesaiLama As String = rd("jam_selesai").ToString()
                Dim lapanganLama As String = rd("lapangan").ToString()
                Dim totalHargaLama As String = rd("total_harga").ToString()
                Dim statusLama As String = rd("status").ToString()
                rd.Close()

                Dim teleponBaru As String = If(TxtNomorTelepon.Text.Trim() = "", teleponLama, TxtNomorTelepon.Text)
                Dim emailBaru As String = If(txtGmail.Text.Trim() = "", emailLama, txtGmail.Text)
                Dim tanggalBaru As String = Format(dtpTanggal.Value, "yyyy-MM-dd")
                Dim jamMulaiBaru As String = If(txtJamMulai.Text.Trim() = "", jamMulaiLama, txtJamMulai.Text)
                Dim jamSelesaiBaru As String = If(txtJamSelesai.Text.Trim() = "", jamSelesaiLama, txtJamSelesai.Text)
                Dim lapanganBaru As String = If(cmbLapangan.Text.Trim() = "", lapanganLama, cmbLapangan.Text)
                Dim totalHargaBaru As String = If(txtTotalHarga.Text.Trim() = "", totalHargaLama, txtTotalHarga.Text)
                Dim statusBaru As String = If(cmbStatus.Text.Trim() = "", statusLama, cmbStatus.Text)

                Dim ubah As String = "UPDATE pemesanan SET no_telepon = @telepon, email = @email, tanggal = @tanggal, " &
                    "jam_mulai = @jam_mulai, jam_selesai = @jam_selesai, lapangan = @id_lapangan, total_harga = @total_harga, " &
                    "status = @status WHERE nama = @nama"

                Dim cmdUbah As New MySqlCommand(ubah, conn)
                cmdUbah.Parameters.AddWithValue("@telepon", teleponBaru)
                cmdUbah.Parameters.AddWithValue("@email", emailBaru)
                cmdUbah.Parameters.AddWithValue("@tanggal", tanggalBaru)
                cmdUbah.Parameters.AddWithValue("@jam_mulai", jamMulaiBaru)
                cmdUbah.Parameters.AddWithValue("@jam_selesai", jamSelesaiBaru)
                cmdUbah.Parameters.AddWithValue("@id_lapangan", lapanganBaru)
                cmdUbah.Parameters.AddWithValue("@total_harga", totalHargaBaru)
                cmdUbah.Parameters.AddWithValue("@status", statusBaru)
                cmdUbah.Parameters.AddWithValue("@nama", txtNama.Text)

                Dim result As Integer = cmdUbah.ExecuteNonQuery()

                If result > 0 Then
                    MessageBox.Show("Data berhasil diubah!")
                    KosongkanForm()
                    Form2.TampilData()
                Else
                    MessageBox.Show("Data gagal diubah.")
                End If
            Else
                rd.Close()
                MessageBox.Show("Nama tidak ditemukan!")
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat mengubah data: " & ex.Message)
        End Try
    End Sub

    Sub KosongkanForm()
        txtNama.Clear()
        TxtNomorTelepon.Clear()
        txtGmail.Clear()
        txtJamMulai.Clear()
        txtJamSelesai.Clear()
        cmbLapangan.SelectedIndex = -1
        txtTotalHarga.Clear()
        cmbStatus.SelectedIndex = -1
    End Sub
End Class
