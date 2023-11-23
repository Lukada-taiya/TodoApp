<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblSignUp = New Label()
        lblLoginQuestion = New Label()
        btnLogin = New Button()
        btnExit = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        lblPassword = New Label()
        lblUsername = New Label()
        SuspendLayout()
        ' 
        ' lblSignUp
        ' 
        lblSignUp.AutoSize = True
        lblSignUp.Cursor = Cursors.Hand
        lblSignUp.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblSignUp.ForeColor = Color.Transparent
        lblSignUp.Location = New Point(281, 161)
        lblSignUp.Name = "lblSignUp"
        lblSignUp.Size = New Size(67, 19)
        lblSignUp.TabIndex = 56
        lblSignUp.Text = "Sign Up"
        ' 
        ' lblLoginQuestion
        ' 
        lblLoginQuestion.AutoSize = True
        lblLoginQuestion.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLoginQuestion.ForeColor = Color.Transparent
        lblLoginQuestion.Location = New Point(100, 161)
        lblLoginQuestion.Name = "lblLoginQuestion"
        lblLoginQuestion.Size = New Size(180, 19)
        lblLoginQuestion.TabIndex = 55
        lblLoginQuestion.Text = "Don't have an account?"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.OrangeRed
        btnLogin.Cursor = Cursors.Hand
        btnLogin.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.Transparent
        btnLogin.Location = New Point(87, 205)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(125, 38)
        btnLogin.TabIndex = 54
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.OrangeRed
        btnExit.Cursor = Cursors.Hand
        btnExit.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.ForeColor = Color.Transparent
        btnExit.Location = New Point(234, 205)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(122, 38)
        btnExit.TabIndex = 53
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(148, 100)
        txtPassword.Margin = New Padding(4, 3, 4, 3)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(302, 30)
        txtPassword.TabIndex = 52
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(148, 35)
        txtUsername.Margin = New Padding(4, 3, 4, 3)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(302, 30)
        txtUsername.TabIndex = 51
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblPassword.ForeColor = Color.Transparent
        lblPassword.Location = New Point(16, 106)
        lblPassword.Margin = New Padding(4, 0, 4, 0)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(103, 24)
        lblPassword.TabIndex = 50
        lblPassword.Text = "Password"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblUsername.ForeColor = Color.Transparent
        lblUsername.Location = New Point(14, 41)
        lblUsername.Margin = New Padding(4, 0, 4, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(105, 24)
        lblUsername.TabIndex = 49
        lblUsername.Text = "Username"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(11F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        ClientSize = New Size(464, 278)
        Controls.Add(lblSignUp)
        Controls.Add(lblLoginQuestion)
        Controls.Add(btnLogin)
        Controls.Add(btnExit)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "LoginForm"
        Text = "LoginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSignUp As Label
    Friend WithEvents lblLoginQuestion As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
End Class
