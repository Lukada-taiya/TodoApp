<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Landing
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Landing))
        Panel1 = New Panel()
        Logout = New Label()
        picLogout = New PictureBox()
        Panel2 = New Panel()
        Label1 = New Label()
        picTask = New PictureBox()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(picLogout, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(picTask, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Logout)
        Panel1.Controls.Add(picLogout)
        Panel1.Location = New Point(-7, 351)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(732, 68)
        Panel1.TabIndex = 0
        ' 
        ' Logout
        ' 
        Logout.AutoSize = True
        Logout.Cursor = Cursors.Hand
        Logout.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Logout.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Logout.Location = New Point(69, 18)
        Logout.Name = "Logout"
        Logout.Size = New Size(77, 24)
        Logout.TabIndex = 1
        Logout.Text = "Logout"
        ' 
        ' picLogout
        ' 
        picLogout.Cursor = Cursors.Hand
        picLogout.Image = CType(resources.GetObject("picLogout.Image"), Image)
        picLogout.Location = New Point(19, 8)
        picLogout.Name = "picLogout"
        picLogout.Size = New Size(41, 39)
        picLogout.SizeMode = PictureBoxSizeMode.StretchImage
        picLogout.TabIndex = 0
        picLogout.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(-7, -5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(732, 68)
        Panel2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Label1.Location = New Point(232, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(241, 38)
        Label1.TabIndex = 0
        Label1.Text = "Welcome to TMS"
        ' 
        ' picTask
        ' 
        picTask.Cursor = Cursors.Hand
        picTask.Image = CType(resources.GetObject("picTask.Image"), Image)
        picTask.Location = New Point(296, 132)
        picTask.Name = "picTask"
        picTask.Size = New Size(80, 114)
        picTask.SizeMode = PictureBoxSizeMode.StretchImage
        picTask.TabIndex = 2
        picTask.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Cursor = Cursors.Hand
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(268, 261)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 24)
        Label2.TabIndex = 3
        Label2.Text = "Manage Tasks"
        ' 
        ' Landing
        ' 
        AutoScaleDimensions = New SizeF(11F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        ClientSize = New Size(716, 410)
        Controls.Add(Label2)
        Controls.Add(picTask)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "Landing"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Landing"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(picLogout, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(picTask, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents picTask As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Logout As Label
    Friend WithEvents picLogout As PictureBox
End Class
