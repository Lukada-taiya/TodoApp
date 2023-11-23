Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SignUpForm

    Public Property Login As Login
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Login.Close()
    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        LoginForm.Login = Login
        Login.switchPanel(LoginForm)
    End Sub

    Private Sub lblLogin_MouseEnter(sender As Object, e As EventArgs) Handles lblLogin.MouseEnter
        lblLogin.Font = New Font("Arial", 10.2, FontStyle.Italic)
    End Sub

    Private Sub lblLogin_MouseLeave(sender As Object, e As EventArgs) Handles lblLogin.MouseLeave
        lblLogin.Font = New Font("Arial", 10.2)
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        If txtUsername.Text = "" Then
            MessageBox.Show("Username field is required")
            txtUsername.Focus()
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            MessageBox.Show("Password field is required")
            txtPassword.Focus()
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            MessageBox.Show("Password field is required")
            txtConfirmPassword.Focus()
            Exit Sub
        End If

        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Password fields does not match")
            Exit Sub
        End If

        Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TodoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;"
        Dim con As New SqlConnection(connectionString)
        con.Open()
        Dim command As New SqlCommand("INSERT INTO Users(Name,Password) VALUES('" & txtUsername.Text & "','" & txtPassword.Text & "')", con)
        command.ExecuteNonQuery()

        Dim select_command As New SqlCommand("SELECT UserIdpk FROM Users WHERE Name ='" & txtUsername.Text & "' AND Password = '" & txtPassword.Text & "'", con)
        Dim record As SqlDataReader = select_command.ExecuteReader()
        If record.HasRows() Then
            Dim userId As Integer
            While record.Read()
                userId = record("UserIdpk").ToString()
            End While
            Dim mainWindow As New MainWindow(userId)
            mainWindow.Show()
            Me.Hide()
        End If
        con.Close()
    End Sub
End Class