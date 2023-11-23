Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class MainWindow

    Private ReadOnly _userId As String

    Public Sub New(ByVal id As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        _userId = id
    End Sub

    Dim connectionString As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TodoDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;"
    Dim con As New SqlConnection(connectionString)
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtTitle.Text = "" Then
            MessageBox.Show("Title is required")
            txtTitle.Focus()
            Exit Sub
        End If
        If txtPriority.Text = "" Then
            MessageBox.Show("Priority is required")
            txtPriority.Focus()
            Exit Sub
        End If
        If dtpDueDate.Text = "" Then
            MessageBox.Show("Due date is required")
            dtpDueDate.Focus()
            Exit Sub
        End If


        Dim textTitle As String = txtTitle.Text
        Dim textDescription As String = txtDescription.Text
        Dim textPriority As String = txtPriority.Text
        Dim dateDueDate As DateTime = dtpDueDate.Text
        Dim dateCreationDate As DateTime = DateTime.Now()
        Dim dateCompletionDate As String = ""
        Dim status As String = ""
        If radNotStarted.Checked = True Then
            status = "Not Started"
        ElseIf radPending.Checked = True Then
            status = "Pending"
        ElseIf radCompleted.Checked = True Then
            status = "Completed"
            dateCompletionDate = DateTime.Now()
        End If

        con.Open()
        Dim query As String
        If dateCompletionDate <> "" Then
            query = "INSERT INTO Tasks(Title,Description,Due_Date,Priority_Level, Status,Creation_Date, Completion_Date, UserIdfk) VALUES('" & textTitle & "','" & textDescription & "','" & dateDueDate & "','" & textPriority & "','" & status & "','" & dateCreationDate & "','" & dateCompletionDate & "', '" & _userId & "')"
        Else
            query = "INSERT INTO Tasks(Title,Description,Due_Date,Priority_Level, Status,Creation_Date, UserIdfk) VALUES('" & textTitle & "','" & textDescription & "','" & dateDueDate & "','" & textPriority & "','" & status & "','" & dateCreationDate & "', '" & _userId & "')"
        End If
        Dim command As New SqlCommand(query, con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Task Added Successfully")
        LoadDataInGrid()
    End Sub

    Private Sub LoadDataInGrid()
        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Dim Command As New SqlCommand("SELECT TaskIdpk As 'Task Id', Title, Description, Due_Date As 'Due On', Priority_Level AS Priority, Status, Creation_Date AS 'Created On', Completion_Date AS 'Completed On' FROM Tasks WHERE UserIdfk = '" & _userId & "' ORDER BY Due_Date, Priority_Level DESC", con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        dataGridView.DataSource = dt
    End Sub

    Private Sub TodoWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInGrid()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtTitle.Text = "" Then
            MessageBox.Show("Title is required")
            txtTitle.Focus()
            Exit Sub
        End If
        If txtPriority.Text = "" Then
            MessageBox.Show("Priority is required")
            txtPriority.Focus()
            Exit Sub
        End If
        If dtpDueDate.Text = "" Then
            MessageBox.Show("Due date is required")
            dtpDueDate.Focus()
            Exit Sub
        End If

        Dim textTaskId As String = txtTaskId.Text
        Dim textTitle As String = txtTitle.Text
        Dim textDescription As String = txtDescription.Text
        Dim textPriority As String = txtPriority.Text
        Dim dateDueDate As DateTime = dtpDueDate.Text
        Dim dateCreationDate As DateTime = dtpCreationDate.Text
        Dim dateCompletionDate As DateTime = DateTime.Now()
        Dim status As String = ""
        If radNotStarted.Checked = True Then
            status = "Not Started"
        ElseIf radPending.Checked = True Then
            status = "Pending"
        ElseIf radCompleted.Checked = True Then
            status = "Completed"
        End If

        con.Open()
        Dim command As New SqlCommand("UPDATE Tasks SET Title = '" & textTitle & "',Description = '" & textDescription & "',Due_Date= '" & dateDueDate & "',Priority_Level='" & textPriority & "', Status= '" & status & "',Creation_Date='" & dateCreationDate & "' WHERE TaskIdpk = '" & textTaskId & "' AND UserIdfk = '" & _userId & "'", con)
        Dim updateDateCompletedCommand As New SqlCommand("UPDATE Tasks SET Completion_Date='" & dateCompletionDate & "' WHERE Completion_Date IS NULL AND TaskIdpk = '" & textTaskId & "' AND UserIdfk = '" & _userId & "'", con)
        command.ExecuteNonQuery()
        updateDateCompletedCommand.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Task Updated Successfully")
        LoadDataInGrid()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim textTaskId As String = txtTaskId.Text
        If MessageBox.Show("Are you sure you want to delete this task?", "Delete Task", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            con.Open()
            Dim command As New SqlCommand("DELETE FROM Tasks WHERE TaskIdpk = '" & textTaskId & "' AND UserIdfk = '" & _userId & "'", con)
            command.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Task Deleted Successfully")
            LoadDataInGrid()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTaskId.Text = ""
        txtDescription.Text = ""
        txtTitle.Text = ""
        dtpDueDate.Text = ""
        txtPriority.Text = ""
        radNotStarted.Select()
        dtpCreationDate.Text = ""
        dtpCompletionDate.Text = ""
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim textTaskId As String = txtTaskId.Text
        Dim textTitle As String = txtTitle.Text
        Dim textDescription As String = txtDescription.Text
        Dim textPriority As String = txtPriority.Text
        Dim dateDueDate As DateTime = dtpDueDate.Text
        Dim dateCreationDate As DateTime = dtpCreationDate.Text
        Dim dateCompletionDate As DateTime = dtpCompletionDate.Text
        Dim status As String = ""
        If radNotStarted.Checked = True Then
            status = "Not Started"
        ElseIf radPending.Checked = True Then
            status = "Pending"
        ElseIf radCompleted.Checked = True Then
            status = "Completed"
        End If

        con.Open()
        Dim command As New SqlCommand("SELECT TaskIdpk As 'Task Id', Title, Description, Due_Date As 'Due On', Priority_Level AS Priority, Status, Creation_Date AS 'Created On', Completion_Date AS 'Completed On' FROM Tasks WHERE UserIdfk = '" & _userId & "' AND TaskIdpk = '" & textTaskId & "' OR Title = '" & textTitle & "' OR Description = '" & textDescription & "' OR Due_Date = '" & dateDueDate &
                                      "' OR Priority_Level = '" & textPriority & "' OR Status = '" & status & "' OR Creation_Date = '" & dateCreationDate & "' OR Completion_Date = '" & dateCompletionDate & "'", con)

        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        dataGridView.DataSource = dt
        con.Close()
    End Sub

    Private Sub dataGridViewItemOnSelect(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim taskIdpk As String = dataGridView.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim title As String = dataGridView.Rows(e.RowIndex).Cells(1).Value.ToString()
            Dim description As String = dataGridView.Rows(e.RowIndex).Cells(2).Value.ToString()
            Dim dueDate As String = dataGridView.Rows(e.RowIndex).Cells(3).Value.ToString()
            Dim priorityLevel As String = dataGridView.Rows(e.RowIndex).Cells(4).Value.ToString()
            Dim status As String = dataGridView.Rows(e.RowIndex).Cells(5).Value.ToString()
            Dim creationDate As String = dataGridView.Rows(e.RowIndex).Cells(6).Value.ToString()
            Dim completionDate As String = dataGridView.Rows(e.RowIndex).Cells(7).Value.ToString()

            PopulateForm(taskIdpk, title, description, dueDate, priorityLevel, status, creationDate, completionDate)
        End If
    End Sub

    Private Sub PopulateForm(id As String, title As String, desc As String, dueDate As String, priority As String, status As String, creationDate As String, completionDate As String)
        txtTaskId.Text = id
        txtDescription.Text = desc
        txtTitle.Text = title
        dtpDueDate.Text = dueDate
        txtPriority.Text = priority
        If status = "Not Started" Then
            radNotStarted.Select()
        ElseIf status = "Pending" Then
            radPending.Select()
        ElseIf status = "Completed" Then
            radCompleted.Select()
        End If
        dtpCreationDate.Text = creationDate
        dtpCompletionDate.Text = completionDate
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Login.Close()
    End Sub

    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles picLogout.Click, lblLogout.Click
        If MessageBox.Show("Are you sure you want logout of the system", "Logout", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Me.Close()
            Login.switchPanel(LoginForm)
            Login.Show()
        End If
    End Sub
End Class
