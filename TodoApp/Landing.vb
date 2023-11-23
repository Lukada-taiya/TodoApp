Imports Microsoft.VisualBasic.ApplicationServices

Public Class Landing

    Private ReadOnly _userId As String

    Public Sub New(ByVal id As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        _userId = id
    End Sub
    Private Sub ManageTasks_Click(sender As Object, e As EventArgs) Handles Label2.Click, picTask.Click
        Dim mainWindow As New MainWindow(_userId)
        mainWindow.Show()
        Me.Hide()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click, picLogout.Click
        If MessageBox.Show("Are you sure you want logout of the system", "Logout", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
            Login.switchPanel(LoginForm)
            Login.Show()
        End If
    End Sub
End Class