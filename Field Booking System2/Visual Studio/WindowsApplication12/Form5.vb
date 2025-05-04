Imports MySql.Data.MySqlClient

Public Class Form5

    ' Variabel untuk menyimpan username dan password yang terdaftar
    Private newUsername As String = ""
    Private newPassword As String = ""

    ' Ganti dengan detail koneksi yang ada pada Module1
    ' Dim connString As String = "Server=localhost;Database=db_futsal;Uid=root;Pwd="

    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        ' Ambil input dari TextBox
        newUsername = txtNewUser.Text
        newPassword = txtNewPass.Text

        ' Validasi input
        If newUsername = "" Or newPassword = "" Then
            MessageBox.Show("Username dan Password tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Gunakan koneksi dari Module1
        Try
            Koneksi() ' Panggil fungsi Koneksi dari Module1

            ' Query untuk menyimpan data
            Dim query As String = "INSERT INTO user_login (username, password) VALUES (@username, @password)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", newUsername)
            cmd.Parameters.AddWithValue("@password", newPassword)

            ' Eksekusi query untuk menyimpan data
            cmd.ExecuteNonQuery()

            ' Notifikasi sukses
            MessageBox.Show("Registrasi berhasil. Silakan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Tutup form registrasi
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Pastikan koneksi ditutup
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    ' Method untuk mendapatkan username dan password yang terdaftar
    Public Function GetUsername() As String
        Return newUsername
    End Function

    Public Function GetPassword() As String
        Return newPassword
    End Function

End Class
