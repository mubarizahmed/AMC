Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Access
Imports Microsoft.Office.Interop.Outlook
Imports Access = Microsoft.Office.Interop.Access
Imports Microsoft.Office.Interop
Imports Microsoft.Reporting.WinForms

Partial Class frmMainMenu
    Dim i As String
    'Sub-routine that runs when the form loads
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets the userlabel as the currently logged user
        lblUser.Text = GlobalVariables.LoggedUser
        'Restricts some users acces to the End-Month Processing tab.
        If GlobalVariables.AccessLevel = "1" Then
            TabControl.TabPages.Remove(TabEndMonth)
        End If
        'Optimizes display to make transitions smoother.
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

    'Shows Income log form when Income Log button is pressed.
    Private Sub cmdIncomeLog_Click(sender As Object, e As EventArgs) Handles cmdIncomeLog.Click
        frmIncomeLog.Show()
        Me.Close()
    End Sub

    'Shows Expense log form when Expense Log button is pressed.
    Private Sub cmdExpenseLog_Click(sender As Object, e As EventArgs) Handles cmdExpenseLog.Click
        frmExpenseLog.Show()
        Me.Close()
    End Sub

    'Shows Member Details form when Member Details button is pressed.
    Private Sub cmdMemberDetails_Click(sender As Object, e As EventArgs) Handles cmdMemberDetails.Click
        frmMemberDetails.Show()
        Me.Close()
    End Sub

    'Shows Employee Details form when Employee Details button is pressed.
    Private Sub cmdEmployeeDetails_Click(sender As Object, e As EventArgs) Handles cmdEmployeeDetails.Click
        frmEmployeeDetails.Show()
        Me.Close()
    End Sub

    'Sub-routine that launches the database so that the user can run the updateMemberBalances query. 
    Private Sub cmdUpdateMemberBalances_Click(sender As Object, e As EventArgs) Handles cmdUpdateMemberBalances.Click
        Dim oAccess As Access.ApplicationClass
        MsgBox("The Database is now being opened. Please run the 'UpdateBalances' query once.", MsgBoxStyle.OkOnly)
        'Start Access and open the database.
        oAccess = CreateObject("Access.Application")
        oAccess.Visible = True
        oAccess.OpenCurrentDatabase("C:\AMC Build\Application Files\AMC_1_0_0_17\AMC.mdb", True, "mubariz")

    End Sub

    'Sub-routine that sends balance emails in batch to all members.
    Private Sub cmdBalanceEmail_Click(sender As Object, e As EventArgs) Handles cmdBalanceEmail.Click
        frmMemberDetails.Show()
        frmMemberDetails.SendToBack()
        Do

            frmMemberDetails.cmdEmail.PerformClick()
            frmMemberDetails.BindingNavigatorMoveNextItem.PerformClick()

        Loop Until frmMemberDetails.BindingNavigatorMoveNextItem.Enabled = False
        frmMemberDetails.cmdEmail.PerformClick()

        frmMemberDetails.Close()
    End Sub

    'Shows Report Viewer form when Report Viewer button is pressed.
    Private Sub cmdViewReports_Click(sender As Object, e As EventArgs) Handles cmdViewReports.Click
        ReportViewer.Show()
        Me.Close()
    End Sub

End Class