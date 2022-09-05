Public Class frmEmployeeDetails
    Private Sub frmEmployeeDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This line of code loads data from the 'AMCDataSet.ExpenseLog' table.
        Me.EmployeeDetailsTableAdapter.Fill(Me.AMCDataSet.EmployeeDetails)
        'Gets the username and access level and restricts certain functions.
        lblUser.Text = GlobalVariables.LoggedUser
        If GlobalVariables.AccessLevel = 1 Then
            Me.cmdDelete.Enabled = False
        End If
        'Hides reset button.
        cmdReset.Hide()
        'Optimizes display to make transitions smoother. 
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

    'Sub-routine used to Add New records.
    Private Sub cmdAddNew_Click(sender As Object, e As EventArgs) Handles cmdAddNew.Click
        EmployeeDetailsBindingSource.AddNew()
    End Sub

    'Sub-routine used to Save records.
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Me.Validate()
        EmployeeDetailsBindingSource.EndEdit()
        EmployeeDetailsTableAdapter.Update(AMCDataSet.EmployeeDetails)
        TableAdapterManager1.UpdateAll(AMCDataSet)
        AMCDataSet.Tables("EmployeeDetails").AcceptChanges()
    End Sub

    'Sub-routine that asks for confirmation and then deletes the current record.
    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim result As DialogResult
        result = MsgBox("Are you sure you want to delete this record? This action cannot be undone.", MsgBoxStyle.OkCancel, "Confirm Delete")
        If result = Windows.Forms.DialogResult.OK Then
            EmployeeDetailsBindingSource.RemoveCurrent()
        End If
    End Sub

    'Sub-routine that prints the current form view.
    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintForm1.DocumentName = "Employee Details"
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
            Me.EmployeeDetailsTableAdapter.SearchName(Me.AMCDataSet.EmployeeDetails, i)
            'Outputs error message if no records are found.
            If EmployeeDetailsBindingSource.Count = "0" Then
                Me.EmployeeDetailsTableAdapter.Fill(Me.AMCDataSet.EmployeeDetails)
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

    'Sub-routine that loads a photo into the picturebox using an open-file dialog.
    Private Sub cmdAddPhoto_Click(sender As Object, e As EventArgs) Handles cmdAddPhoto.Click
        OpenFileDialog1.ShowDialog()
        picPhoto.ImageLocation = OpenFileDialog1.FileName
    End Sub

    'Sub-routine that loads the displayed picture into a full-screen Image Viewer.
    Private Sub picPhoto_Click(sender As Object, e As EventArgs) Handles picPhoto.Click
        If picPhoto.ImageLocation = "" Then
            MsgBox("No Image Selected!", MsgBoxStyle.OkOnly)
        Else
            MaximizePic.PictureBox1.ImageLocation = picPhoto.ImageLocation
            MaximizePic.Show()
        End If
    End Sub

    'Sub-routine that re-loads all data from table and hides the reset button.
    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        Me.EmployeeDetailsTableAdapter.Fill(Me.AMCDataSet.EmployeeDetails)
        cmdReset.Hide()
    End Sub

    'Sub-routine that automatically calculates Age if DOB is changed
    Private Sub dateBirth_ValueChanged(sender As Object, e As EventArgs) Handles dateBirth.ValueChanged
        txtAge.Text = Year(Today) - Year(dateBirth.Value)
    End Sub
End Class