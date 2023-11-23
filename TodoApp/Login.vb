Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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