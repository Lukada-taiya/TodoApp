<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpForm
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
        lblLogin = New Label()
        lblLoginQuestion = New Label()
        txtConfirmPassword = New TextBox()
        lblConfirmPassword = New Label()
        btnSignUp = New Button()
        btnExit = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        lblPassword = New Label()
        lblUsername = New Label()
        SuspendLayout()
        ' 
        ' lblLogin
        ' 
        lblLogin.AccessibleRole = AccessibleRole.Cursor
        lblLogin.AutoSize = True
        lblLogin.Cursor = Cursors.Hand
        lblLogin.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLogin.ForeColor = Color.Transparent
        lblLogin.Location = New Point(289, 190)
        lblLogin.Name = "lblLogin"
        lblLogin.Size = New Size(49, 19)
        lblLogin.TabIndex = 48
        lblLogin.Text = "Login"
        ' 
        ' lblLoginQuestion
        ' 
        lblLoginQuestion.AutoSize = True
        lblLoginQuestion.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLoginQuestion.ForeColor = Color.Transparent
        lblLoginQuestion.Location = New Point(90, 190)
        lblLoginQuestion.Name = "lblLoginQuestion"
        lblLoginQuestion.Size = New Size(199, 19)
        lblLoginQuestion.TabIndex = 47
        lblLoginQuestion.Text = "Already have an account?"
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(148, 135)
        txtConfirmPassword.Margin = New Padding(4, 3, 4, 3)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.PasswordChar = "*"c
        txtConfirmPassword.Size = New Size(302, 30)
        txtConfirmPassword.TabIndex = 46
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblConfirmPassword.ForeColor = Color.Transparent
        lblConfirmPassword.Location = New Point(16, 117)
        lblConfirmPassword.Margin = New Padding(4, 0, 4, 0)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(103, 48)
        lblConfirmPassword.TabIndex = 45
        lblConfirmPassword.Text = "Confirm " & vbCrLf & "Password"
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BackColor = Color.OrangeRed
        btnSignUp.Cursor = Cursors.Hand
        btnSignUp.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnSignUp.ForeColor = Color.Transparent
        btnSignUp.Location = New Point(77, 234)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(125, 38)
        btnSignUp.TabIndex = 44
        btnSignUp.Text = "Sign Up"
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.OrangeRed
        btnExit.Cursor = Cursors.Hand
        btnExit.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.ForeColor = Color.Transparent
        btnExit.Location = New Point(224, 234)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(122, 38)
        btnExit.TabIndex = 43
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(148, 72)
        txtPassword.Margin = New Padding(4, 3, 4, 3)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(302, 30)
        txtPassword.TabIndex = 42
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(148, 7)
        txtUsername.Margin = New Padding(4, 3, 4, 3)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(302, 30)
        txtUsername.TabIndex = 41
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblPassword.ForeColor = Color.Transparent
        lblPassword.Location = New Point(16, 78)
        lblPassword.Margin = New Padding(4, 0, 4, 0)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(103, 24)
        lblPassword.TabIndex = 40
        lblPassword.Text = "Password"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblUsername.ForeColor = Color.Transparent
        lblUsername.Location = New Point(14, 13)
        lblUsername.Margin = New Padding(4, 0, 4, 0)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(105, 24)
        lblUsername.TabIndex = 39
        lblUsername.Text = "Username"
        ' 
        ' SignUpForm
        ' 
        AutoScaleDimensions = New SizeF(11F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        ClientSize = New Size(464, 278)
        Controls.Add(lblLogin)
        Controls.Add(lblLoginQuestion)
        Controls.Add(txtConfirmPassword)
        Controls.Add(lblConfirmPassword)
        Controls.Add(btnSignUp)
        Controls.Add(btnExit)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(lblPassword)
        Controls.Add(lblUsername)
        Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "SignUpForm"
        Text = "SignUpForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLogin As Label
    Friend WithEvents lblLoginQuestion As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
End Class
