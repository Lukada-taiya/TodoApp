<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Title = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtTitle = New TextBox()
        txtPriority = New TextBox()
        NotifyIcon1 = New NotifyIcon(components)
        txtDescription = New RichTextBox()
        radPending = New RadioButton()
        radCompleted = New RadioButton()
        radNotStarted = New RadioButton()
        dataGridView = New DataGridView()
        btnAdd = New Button()
        dtpDueDate = New DateTimePicker()
        dtpCreationDate = New DateTimePicker()
        Label5 = New Label()
        dtpCompletionDate = New DateTimePicker()
        Label6 = New Label()
        btnUpdate = New Button()
        txtTaskId = New TextBox()
        btnDelete = New Button()
        Label7 = New Label()
        btnSearch = New Button()
        btnClear = New Button()
        picClose = New PictureBox()
        picLogout = New PictureBox()
        lblLogout = New Label()
        btnReturn = New Button()
        CType(dataGridView, ComponentModel.ISupportInitialize).BeginInit()
        CType(picClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(picLogout, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Title.ForeColor = Color.Transparent
        Title.Location = New Point(105, 112)
        Title.Name = "Title"
        Title.Size = New Size(51, 24)
        Title.TabIndex = 0
        Title.Text = "Title"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(529, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(118, 24)
        Label1.TabIndex = 1
        Label1.Text = "Description"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(64, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 24)
        Label2.TabIndex = 2
        Label2.Text = "Due Date"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(80, 210)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 24)
        Label3.TabIndex = 3
        Label3.Text = "Priority"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(87, 259)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 24)
        Label4.TabIndex = 4
        Label4.Text = "Status"
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(182, 109)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(258, 30)
        txtTitle.TabIndex = 5
        ' 
        ' txtPriority
        ' 
        txtPriority.Location = New Point(182, 207)
        txtPriority.Name = "txtPriority"
        txtPriority.Size = New Size(258, 30)
        txtPriority.TabIndex = 7
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Text = "NotifyIcon1"
        NotifyIcon1.Visible = True
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(653, 64)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(252, 90)
        txtDescription.TabIndex = 9
        txtDescription.Text = ""
        ' 
        ' radPending
        ' 
        radPending.AutoSize = True
        radPending.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        radPending.ForeColor = Color.Transparent
        radPending.Location = New Point(182, 284)
        radPending.Name = "radPending"
        radPending.Size = New Size(101, 27)
        radPending.TabIndex = 10
        radPending.Text = "Pending"
        radPending.UseVisualStyleBackColor = True
        ' 
        ' radCompleted
        ' 
        radCompleted.AutoSize = True
        radCompleted.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        radCompleted.ForeColor = Color.Transparent
        radCompleted.Location = New Point(182, 316)
        radCompleted.Name = "radCompleted"
        radCompleted.Size = New Size(126, 27)
        radCompleted.TabIndex = 11
        radCompleted.Text = "Completed"
        radCompleted.UseVisualStyleBackColor = True
        ' 
        ' radNotStarted
        ' 
        radNotStarted.AutoSize = True
        radNotStarted.Checked = True
        radNotStarted.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        radNotStarted.ForeColor = Color.Transparent
        radNotStarted.Location = New Point(182, 256)
        radNotStarted.Name = "radNotStarted"
        radNotStarted.Size = New Size(132, 27)
        radNotStarted.TabIndex = 12
        radNotStarted.TabStop = True
        radNotStarted.Text = "Not Started"
        radNotStarted.UseVisualStyleBackColor = True
        ' 
        ' dataGridView
        ' 
        dataGridView.BackgroundColor = Color.White
        dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridView.GridColor = SystemColors.Window
        dataGridView.Location = New Point(27, 455)
        dataGridView.Name = "dataGridView"
        dataGridView.RowHeadersWidth = 51
        dataGridView.RowTemplate.Height = 29
        dataGridView.Size = New Size(1048, 180)
        dataGridView.TabIndex = 13
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.OrangeRed
        btnAdd.Cursor = Cursors.Hand
        btnAdd.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnAdd.ForeColor = Color.Transparent
        btnAdd.Location = New Point(181, 389)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(167, 38)
        btnAdd.TabIndex = 14
        btnAdd.Text = "Add Task"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' dtpDueDate
        ' 
        dtpDueDate.Location = New Point(182, 162)
        dtpDueDate.Name = "dtpDueDate"
        dtpDueDate.Size = New Size(258, 30)
        dtpDueDate.TabIndex = 15
        ' 
        ' dtpCreationDate
        ' 
        dtpCreationDate.Enabled = False
        dtpCreationDate.Location = New Point(647, 185)
        dtpCreationDate.Name = "dtpCreationDate"
        dtpCreationDate.Size = New Size(258, 30)
        dtpCreationDate.TabIndex = 17
        dtpCreationDate.Value = New Date(2023, 11, 22, 11, 2, 17, 0)
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Transparent
        Label5.Location = New Point(510, 190)
        Label5.Name = "Label5"
        Label5.Size = New Size(139, 24)
        Label5.TabIndex = 16
        Label5.Text = "Creation Date"
        ' 
        ' dtpCompletionDate
        ' 
        dtpCompletionDate.Enabled = False
        dtpCompletionDate.Location = New Point(647, 245)
        dtpCompletionDate.Name = "dtpCompletionDate"
        dtpCompletionDate.Size = New Size(258, 30)
        dtpCompletionDate.TabIndex = 19
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Transparent
        Label6.Location = New Point(485, 251)
        Label6.Name = "Label6"
        Label6.Size = New Size(166, 24)
        Label6.TabIndex = 18
        Label6.Text = "Completion Date"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.OrangeRed
        btnUpdate.Cursor = Cursors.Hand
        btnUpdate.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnUpdate.ForeColor = Color.Transparent
        btnUpdate.Location = New Point(381, 389)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(167, 38)
        btnUpdate.TabIndex = 20
        btnUpdate.Text = "Update Task"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' txtTaskId
        ' 
        txtTaskId.ForeColor = SystemColors.WindowText
        txtTaskId.Location = New Point(182, 58)
        txtTaskId.Name = "txtTaskId"
        txtTaskId.Size = New Size(121, 30)
        txtTaskId.TabIndex = 22
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.OrangeRed
        btnDelete.Cursor = Cursors.Hand
        btnDelete.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelete.ForeColor = Color.Transparent
        btnDelete.Location = New Point(576, 389)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(167, 38)
        btnDelete.TabIndex = 23
        btnDelete.Text = "Delete Task"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Transparent
        Label7.Location = New Point(78, 64)
        Label7.Name = "Label7"
        Label7.Size = New Size(78, 24)
        Label7.TabIndex = 24
        Label7.Text = "Task Id"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.OrangeRed
        btnSearch.Cursor = Cursors.Hand
        btnSearch.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.ForeColor = Color.Transparent
        btnSearch.Location = New Point(309, 58)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(131, 30)
        btnSearch.TabIndex = 25
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.OrangeRed
        btnClear.Cursor = Cursors.Hand
        btnClear.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnClear.ForeColor = Color.Transparent
        btnClear.Location = New Point(771, 389)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(167, 38)
        btnClear.TabIndex = 26
        btnClear.Text = "Clear All"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' picClose
        ' 
        picClose.Cursor = Cursors.Hand
        picClose.Image = CType(resources.GetObject("picClose.Image"), Image)
        picClose.Location = New Point(1066, 7)
        picClose.Name = "picClose"
        picClose.Size = New Size(22, 20)
        picClose.SizeMode = PictureBoxSizeMode.StretchImage
        picClose.TabIndex = 27
        picClose.TabStop = False
        ' 
        ' picLogout
        ' 
        picLogout.Image = CType(resources.GetObject("picLogout.Image"), Image)
        picLogout.Location = New Point(34, 668)
        picLogout.Name = "picLogout"
        picLogout.Size = New Size(31, 30)
        picLogout.SizeMode = PictureBoxSizeMode.StretchImage
        picLogout.TabIndex = 28
        picLogout.TabStop = False
        ' 
        ' lblLogout
        ' 
        lblLogout.AutoSize = True
        lblLogout.Cursor = Cursors.Hand
        lblLogout.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblLogout.ForeColor = Color.Transparent
        lblLogout.Location = New Point(64, 672)
        lblLogout.Name = "lblLogout"
        lblLogout.Size = New Size(77, 24)
        lblLogout.TabIndex = 29
        lblLogout.Text = "Logout"
        ' 
        ' btnReturn
        ' 
        btnReturn.BackColor = Color.White
        btnReturn.Cursor = Cursors.Hand
        btnReturn.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnReturn.ForeColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        btnReturn.Location = New Point(480, 658)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(167, 38)
        btnReturn.TabIndex = 30
        btnReturn.Text = "Return"
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' MainWindow
        ' 
        AutoScaleDimensions = New SizeF(11F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        ClientSize = New Size(1100, 710)
        Controls.Add(btnReturn)
        Controls.Add(lblLogout)
        Controls.Add(picLogout)
        Controls.Add(picClose)
        Controls.Add(btnClear)
        Controls.Add(btnSearch)
        Controls.Add(Label7)
        Controls.Add(btnDelete)
        Controls.Add(txtTaskId)
        Controls.Add(btnUpdate)
        Controls.Add(dtpCompletionDate)
        Controls.Add(Label6)
        Controls.Add(dtpCreationDate)
        Controls.Add(Label5)
        Controls.Add(dtpDueDate)
        Controls.Add(btnAdd)
        Controls.Add(dataGridView)
        Controls.Add(radNotStarted)
        Controls.Add(radCompleted)
        Controls.Add(radPending)
        Controls.Add(txtDescription)
        Controls.Add(txtPriority)
        Controls.Add(txtTitle)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Title)
        Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "MainWindow"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Todo App"
        CType(dataGridView, ComponentModel.ISupportInitialize).EndInit()
        CType(picClose, ComponentModel.ISupportInitialize).EndInit()
        CType(picLogout, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtPriority As TextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents txtDescription As RichTextBox
    Friend WithEvents radPending As RadioButton
    Friend WithEvents radCompleted As RadioButton
    Friend WithEvents radNotStarted As RadioButton
    Friend WithEvents dataGridView As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents dtpDueDate As DateTimePicker
    Friend WithEvents dtpCreationDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpCompletionDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtTaskId As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents picClose As PictureBox
    Friend WithEvents picLogout As PictureBox
    Friend WithEvents lblLogout As Label
    Friend WithEvents btnReturn As Button
End Class
