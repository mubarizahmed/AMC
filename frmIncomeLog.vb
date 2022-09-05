Imports System.Data.OleDb

Partial Class frmIncomeLog

    Private Sub frmIncomeLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This line of code loads data from the 'AMCDataSet.IncomeLog' table.
        Me.IncomeLogTableAdapter.Fill(Me.AMCDataSet.IncomeLog)
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
        IncomeLogBindingSource.AddNew()
    End Sub

    'Sub-routine used to Save records.
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtTotal.Text >= 50 Then
            Me.Validate()
            IncomeLogBindingSource.EndEdit()
            IncomeLogTableAdapter.Update(AMCDataSet.IncomeLog)
            TableAdapterManager1.UpdateAll(AMCDataSet)
            AMCDataSet.Tables("IncomeLog").AcceptChanges()
        Else
            MsgBox("Invalid Total! Total should be greater than 0.", MsgBoxStyle.OkOnly)
        End If


    End Sub

    'Sub-routine that asks for confirmation and then deletes the current record.
    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim result As DialogResult
        result = MsgBox("Are you sure you want to delete this record? This action cannot be undone.", MsgBoxStyle.OkCancel, "Confirm Delete")
        If result = Windows.Forms.DialogResult.OK Then
            IncomeLogBindingSource.RemoveCurrent()
        End If
    End Sub

    'Sub-routine that prints the current form view.
    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintForm1.DocumentName = "Income Reciept"
        PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        PrintForm1.Print()
    End Sub

    'Sub-routine that finds a record.
    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click
        'User inputs string to search for.
        Dim i As String
        i = InputBox("Enter MemberName to search.", "Find", "")
        'Checks if string is empty.
        If i = "" Then

        Else
            'Gets data from table using a search query.
            Me.IncomeLogTableAdapter.SearchMemberName(Me.AMCDataSet.IncomeLog, i)
            'Outputs error message if no records are found.
            If IncomeLogBindingSource.Count = "0" Then
                Me.IncomeLogTableAdapter.Fill(Me.AMCDataSet.IncomeLog)
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
        Me.IncomeLogTableAdapter.Fill(Me.AMCDataSet.IncomeLog)
        Me.cmdReset.Hide()
    End Sub

    'Sub-routine that gets Member Name from the MemberID using a query in the EmployeeDetails table.
    Private Sub txtMemberID_TextChanged(sender As Object, e As EventArgs) Handles txtMemberID.TextChanged
        If txtMemberID.Text = "" Then
        Else
            txtMemberName.Text = MemberDetailsTableAdapter1.GetMemberName(txtMemberID.Text)
            If txtMemberName.Text = "" Then
                MsgBox("No Such Member!", MsgBoxStyle.OkOnly)
                txtMemberID.Text = ""
            End If
        End If
    End Sub

    'Sub-routine that updates the Total field.
    Private Sub totalUpdate()

        txtTotal.Text = Val(txtAnsar.Text) + Val(txtBookPurchase.Text) + Val(txtChandaAam.Text) + Val(txtEidFund.Text) + Val(txtFitrana.Text) + Val(txtJalsaSalana.Text) + Val(txtKhuddam.Text) + Val(txtLajna.Text) + Val(txtSadaqah.Text) + Val(txtTJ.Text) + Val(txtWJ.Text) + Val(txtWasiyyat.Text) + Val(txtZakat.Text)

    End Sub

    'Sub-routine that runs the totalUpdate() procedure when a field is changed.
    Private Sub txtWasiyyat_TextChanged(sender As Object, e As EventArgs) Handles txtWasiyyat.TextChanged
        totalUpdate()
    End Sub

    'Sub-routine that runs the totalUpdate() procedure when a field is changed.
    Private Sub txtChandaAam_TextChanged(sender As Object, e As EventArgs) Handles txtChandaAam.TextChanged
        totalUpdate()
    End Sub

    'Sub-routine that runs the totalUpdate() procedure when a field is changed.
    Private Sub txtJalsaSalana_TextChanged(sender As Object, e As EventArgs) Handles txtJalsaSalana.TextChanged
        totalUpdate()
    End Sub

    'Sub-routine that runs the totalUpdate() procedure when a field is changed.
    Private Sub txtWJ_TextChanged(sender As Object, e As EventArgs) Handles txtWJ.TextChanged
        totalUpdate()
    End Sub

    'Sub-routine that runs the totalUpdate() procedure when a field is changed.
    Private Sub txtTJ_TextChanged(sender As Object, e As EventArgs) Handles txtTJ.TextChanged
        totalUpdate()
    End Sub

    'Sub-routine that runs the totalUpdate() procedure when a field is changed.
    Private Sub txtSadaqah_TextChanged(sender As Object, e As EventArgs) Handles txtSadaqah.TextChanged
        totalUpdate()
    End Sub

    'Sub-routine that runs the totalUpdate() procedure when a field is changed.
    Private Sub txtEidFund_TextChanged(sender As Object, e As EventArgs) Handles txtEidFund.TextChanged
        totalUpdate()
    End Sub

    'Sub-routine that runs the totalUpdate() procedure when a field is changed.
    Private Sub txtFitrana_TextChanged(sender As Object, e As EventArgs) Handles txtFitrana.TextChanged
        totalUpdate()
    End Sub

    'Sub-routine that runs the totalUpdate() procedure when a field is changed.
    Private Sub txtZakat_TextChanged(sender As Object, e As EventArgs) Handles txtZakat.TextChanged
        totalUpdate()
    End Sub

    'Sub-routine that runs the totalUpdate() procedure when a field is changed.
    Private Sub txtBookPurchase_TextChanged(sender As Object, e As EventArgs) Handles txtBookPurchase.TextChanged
        totalUpdate()
    End Sub

    'Sub-routine that runs the totalUpdate() procedure when a field is changed.
    Private Sub txtLajna_TextChanged(sender As Object, e As EventArgs) Handles txtLajna.TextChanged
        totalUpdate()
    End Sub

    'Sub-routine that runs the totalUpdate() procedure when a field is changed.
    Private Sub txtKhuddam_TextChanged(sender As Object, e As EventArgs) Handles txtKhuddam.TextChanged
        totalUpdate()
    End Sub

    'Sub-routine that runs the totalUpdate() procedure when a field is changed.
    Private Sub txtAnsar_TextChanged(sender As Object, e As EventArgs) Handles txtAnsar.TextChanged
        totalUpdate()
    End Sub

End Class