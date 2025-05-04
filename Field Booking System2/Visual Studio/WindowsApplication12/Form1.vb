Imports MySql.Data.MySqlClient

Public Class Form1

    ' Variabel untuk menyimpan username dan password yang terdaftar
    Private regUsername As String = ""
    Private regPassword As String = ""

    ' Ganti dengan koneksi dari Module1
    Dim connString As String = "server=localhost;userid=root;password=;database=db_futsal"
    Dim conn As MySqlConnection

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' Cek login sebagai admin
        If username = "admin" And password = "admin" Then
            MessageBox.Show("Login sebagai Admin berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim formAdmin As New Form2() ' ⬅️ Ubah ke Form2 untuk Admin
            formAdmin.Show()
            Me.Hide()

        Else
            ' Cek login dengan username dan password yang terdaftar di database
            Try
                ' Buat koneksi ke database
                conn = New MySqlConnection(connString)
                conn.Open()

                ' Query untuk mengecek username dan password
                Dim query As String = "SELECT COUNT(*) FROM user_login WHERE username = @username AND password = @password"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                ' Execute query
                Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' Jika hasilnya lebih dari 0, login berhasil
                If result > 0 Then
                    MessageBox.Show("Login sebagai User berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim formUser As New Form6()
                    formUser.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Username atau Password salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Pastikan koneksi ditutup
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub lblRegis_Click(sender As Object, e As EventArgs) Handles lblRegis.Click
        ' Tampilkan form registrasi dan ambil username/password yang terdaftar
        Dim formRegis As New Form5()
        formRegis.Show()
    End Sub
End Class
