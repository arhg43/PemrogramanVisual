Imports MySql.Data.MySqlClient

Public Class Form5

    Private newUsername As String = ""
    Private newPassword As String = ""

    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        newUsername = txtNewUser.Text
        newPassword = txtNewPass.Text

        If newUsername = "" Or newPassword = "" Then
            MessageBox.Show("Username dan Password tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Koneksi()
            Dim query As String = "INSERT INTO user_login (username, password) VALUES (@username, @password)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", newUsername)
            cmd.Parameters.AddWithValue("@password", newPassword)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Registrasi berhasil. Silakan login.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Public Function GetUsername() As String
        Return newUsername
    End Function

    Public Function GetPassword() As String
        Return newPassword
    End Function

End Class
