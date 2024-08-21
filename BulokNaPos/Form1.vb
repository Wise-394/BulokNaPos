Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class Form1
    Dim connectionString As String = "Server=localhost;Database=bulok_na_pos;Uid=root" 'omsim
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbUname.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lbPword.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connection As New MySqlConnection(connectionString)
        Dim uname As String = tbUname.Text
        Dim pword As String = tbPword.Text
        Try
            connection.Open()
            Dim query As String = "SELECT COUNT(*) FROM adminTable WHERE USERNAME = '" & uname & "' AND PASSWORD = '" & pword & "'"
            Dim command As New MySqlCommand(query, connection)
            Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

            If result > 0 Then
                MessageBox.Show("Login successful!")
            Else
                MessageBox.Show("Invalid username or password.")
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class
