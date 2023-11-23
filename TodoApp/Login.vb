Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Then
            MessageBox.Show("Username field is required")
            txtUsername.Focus()
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            MessageBox.Show("Password field is required")
            txtUsername.Focus()
            Exit Sub
        End If

        Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TodoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;"
        Dim con As New SqlConnection(connectionString)
        con.Open()
        Dim command As New SqlCommand("SELECT UserIdpk FROM Users WHERE Name ='" & txtUsername.Text & "' AND Password = '" & txtPassword.Text & "'", con)
        Dim record As SqlDataReader = command.ExecuteReader()
        If record.HasRows() Then
            Dim userId As Integer
            While record.Read()
                userId = record("UserIdpk").ToString()
            End While
            Dim mainWindow As New MainWindow(userId)
            mainWindow.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid Name or Password")
            txtPassword.Text = ""
            txtUsername.Text = ""
        End If
        con.Close()

    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class