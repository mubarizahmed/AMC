Imports Microsoft.Office.Interop

Public Class frmMemberDetails


    Private Sub frmMemberDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This line of code loads data from the 'AMCDataSet.MemberDetails' table.
        Me.MemberDetailsTableAdapter.Fill(Me.AMCDataSet.MemberDetails)
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
        MemberDetailsBindingSource.AddNew()
    End Sub

    'Sub-routine used to Save records.
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        If txtTotalContribution.Text >= 0 Then
            Me.Validate()
            MemberDetailsBindingSource.EndEdit()
            MemberDetailsTableAdapter.Update(AMCDataSet.MemberDetails)
            TableAdapterManager1.UpdateAll(AMCDataSet)
            AMCDataSet.Tables("MemberDetails").AcceptChanges()
        Else
            MsgBox("Invalid Total Contribution! Total Contribution must be greater than 0.", MsgBoxStyle.OkOnly)
        End If
    End Sub

    'Sub-routine that asks for confirmation and then deletes the current record.
    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim result As DialogResult
        result = MsgBox("Are you sure you want to delete this record? This action cannot be undone.", MsgBoxStyle.OkCancel, "Confirm Delete")
        If result = Windows.Forms.DialogResult.OK Then
            MemberDetailsBindingSource.RemoveCurrent()
        End If
    End Sub

    'Sub-routine that prints the current form view.
    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        PrintForm1.DocumentName = "Member Details"
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
            End
        Else
            'Gets data from table using a search query.
            Me.MemberDetailsTableAdapter.SearchMemberName(Me.AMCDataSet.MemberDetails, i)
            'Outputs error message if no records are found.
            If MemberDetailsBindingSource.Count = "0" Then
                Me.MemberDetailsTableAdapter.Fill(Me.AMCDataSet.MemberDetails)
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
        Me.MemberDetailsTableAdapter.Fill(Me.AMCDataSet.MemberDetails)
        cmdReset.Hide()
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

    'Sub-routine that automatically calculates Age if DOB is changed
    Private Sub dateDOB_ValueChanged(sender As Object, e As EventArgs) Handles dateDOB.ValueChanged
        txtAge.Text = Year(Now) - Year(dateDOB.Value)
    End Sub

    'Sub-routine that sends an automated email to members regarding their yearly balances.
    Private Sub cmdEmail_Click(sender As Object, e As EventArgs) Handles cmdEmail.Click
        Dim ol As New Outlook.Application()
        Dim ns As Outlook.NameSpace
        Dim fdMail As Outlook.MAPIFolder
        Dim Body As String

        ns = ol.GetNamespace("MAPI")
        ns.Logon("Outlook", , True, True)

        'creating a new MailItem object
        Dim newMail As Outlook.MailItem

        'gets defaultfolder for my Outlook Outbox
        fdMail = ns.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderOutbox)

        Body = "Dear " & txtMemberName.Text & "," & vbCrLf & "Assalamu Aleikum" & vbCrLf & vbCrLf & "I hope you are in best of health. Your balances for the year are:" & vbCrLf & vbCrLf & "Wassiyat Balance: " & txtWassiyatBal.Text & vbCrLf & "Chanda Aam Balance: " & txtChandaAamBal.Text & vbCrLf & "Tehrik-e-Jadid Balance: " & txtTJBal.Text & vbCrLf & "Waqf-e-Jadid Balance: " & txtWJBal.Text & vbCrLf & vbCrLf & "Wassalaam," & vbCrLf & "Secretary Maal."

        'assign values to the newMail MailItem
        newMail = fdMail.Items.Add(Outlook.OlItemType.olMailItem)
        newMail.Subject = "Balances"
        newMail.Body = Body
        newMail.To = txtEmail.Text
        newMail.SaveSentMessageFolder = fdMail

        newMail.Send()
    End Sub


End Class