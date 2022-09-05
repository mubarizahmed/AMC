Public Class frmExpenseLog


    Private Sub frmExpenseLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This line of code loads data from the 'AMCDataSet.ExpenseLog' table.
        Me.ExpenseLogTableAdapter.Fill(Me.AMCDataSet.ExpenseLog)
        'Gets the username and access level and restricts certain functions.
        lblUser.Text = GlobalVariables.LoggedUser
        If GlobalVariables.AccessLevel = 1 Then
            Me.cmdDelete.Enabled = False
            Me.chkApproved.Enabled = False
        End If
        'Hides reset button.
        cmdReset.Hide()
        'Optimizes display to make transitions smoother. 
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

    'Sub-routine used to Add New records.
    Private Sub cmdAddNew_Click(sender As Object, e As EventArgs) Handles cmdAddNew.Click
        ExpenseLogBindingSource.AddNew()
    End Sub

    'Sub-routine used to Save records.
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtAmount.Text >= 100 Then
            Me.Validate()
            ExpenseLogBindingSource.EndEdit()
            ExpenseLogTableAdapter.Update(AMCDataSet.ExpenseLog)
            TableAdapterManager1.UpdateAll(AMCDataSet)
            AMCDataSet.Tables("ExpenseLog").AcceptChanges()
        Else
            MsgBox("Invalid Amount! Amount must be greater than 0.", MsgBoxStyle.OkOnly)
        End If
    End Sub

    'Sub-routine that asks for confirmation and then deletes the current record.
    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim result As DialogResult
        result = MsgBox("Are you sure you want to delete this record? This action cannot be undone.", MsgBoxStyle.OkCancel, "Confirm Delete")
        If result = Windows.Forms.DialogResult.OK Then
            ExpenseLogBindingSource.RemoveCurrent()
        End If
    End Sub

    'Sub-routine that prints the current form view.
    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintForm1.DocumentName = "Expense Log"
        PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintForm1.Print()
    End Sub

    'Sub-routine that finds a record.
    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click
        'User inputs string to search for.
        Dim i As String
        i = InputBox("Enter Employee Name to search.", "Find", "")
        'Checks if string is empty.
        If i = "" Then
            End
        Else
            'Gets data from table using a search query.
            Me.ExpenseLogTableAdapter.SearchEmployeeName(Me.AMCDataSet.ExpenseLog, i)
            'Outputs error message if no records are found.
            If ExpenseLogBindingSource.Count = "0" Then
                Me.ExpenseLogTableAdapter.Fill(Me.AMCDataSet.ExpenseLog)
                MsgBox("Record Not found.", vbOKOnly)
            Else
                'Displays a reset button that can be used to reset the search query, if records are found.
                cmdReset.Show()
            End If
        End If
    End Sub

    'Sub-routine that closes current form and shows the MainMenu.
    Private Sub cmdHome_Click(sender As Object, e As EventArgs) Handles cmdHome.Click
        frmMainMenu.Show()
        Me.Close()
    End Sub

    'Sub-routine that re-loads all data from table and hides the reset button.
    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        Me.ExpenseLogTableAdapter.Fill(Me.AMCDataSet.ExpenseLog)
        cmdReset.Hide()
    End Sub

    'Sub-routine that loads a scanned image into the picturebox using an open-file dialog.
    Private Sub cmdAddScan_Click(sender As Object, e As EventArgs) Handles cmdAddScan.Click
        OpenFileDialog1.ShowDialog()
        picReciept.ImageLocation = OpenFileDialog1.FileName
    End Sub

    'Sub-routine that loads the displayed picture into a full-screen Image Viewer.
    Private Sub picReciept_Click(sender As Object, e As EventArgs) Handles picReciept.Click
        If picReciept.ImageLocation = "" Then
            MsgBox("No Image Selected!", MsgBoxStyle.OkOnly)
        Else
            MaximizePic.PictureBox1.ImageLocation = picReciept.ImageLocation
            MaximizePic.Show()
        End If
    End Sub

    'Sub-routine that gets Employee Name from the EmployeeID using a query in the EmployeeDetails table.
    Private Sub txtEmployeeID_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeID.TextChanged
        txtEmployeeName.Text = EmployeeDetailsTableAdapter1.EmployeeNameQuery(txtEmployeeID.Text)
        If txtEmployeeName.Text = "" Then
            MsgBox("No Such Employee!", MsgBoxStyle.OkOnly)
            txtEmployeeID.Text = ""
        End If
    End Sub



End Class