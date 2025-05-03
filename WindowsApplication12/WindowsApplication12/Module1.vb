Imports MySql.Data.MySqlClient

Module Module1
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public ds As DataSet

    Sub Koneksi()
        conn = New MySqlConnection("server=localhost;userid=root;password=;database=db_futsal")
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal koneksi: " & ex.Message)
        End Try
    End Sub
End Module
