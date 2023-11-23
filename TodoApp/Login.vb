Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login


    'Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    '    Me.Close()
    'End Sub

    'Private Sub lblSignUp_MouseEnter(sender As Object, e As EventArgs) Handles lblSignUp.MouseEnter
    '    'MsgBox(lblSignUp.Font.ToString)
    '    lblSignUp.Font = New Font("Arial", 10.2, FontStyle.Italic)
    'End Sub

    'Private Sub lblSignUp_MouseLeave(sender As Object, e As EventArgs) Handles lblSignUp.MouseLeave
    '    lblSignUp.Font = New Font("Arial", 10.2)
    'End Sub

    'Private Sub lblSignUp_Click(sender As Object, e As EventArgs) Handles lblSignUp.Click


    'End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'panelFormContainer.Controls.Add(lblUsername)
        'panelFormContainer.Controls.Add(txtUsername)
        'panelFormContainer.Controls.Add(lblPassword)
        'panelFormContainer.Controls.Add(txtPassword)
        'panelFormContainer.Controls.Add(lblLoginQuestion)
        'panelFormContainer.Controls.Add(lblSignUp)
        'panelFormContainer.Controls.Add(btnLogin)
        'panelFormContainer.Controls.Add(btnExit) 
        LoginForm.Login = Me
        switchPanel(LoginForm)
    End Sub

    Public Sub switchPanel(ByVal panel As Form)
        panelFormContainer.Controls.Clear()
        panel.TopLevel = False
        panelFormContainer.Controls.Add(panel)
        panel.Show()
    End Sub
End Class