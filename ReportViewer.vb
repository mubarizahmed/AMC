Public Class ReportViewer
    'Sub-routine that runs when the form loads.
    Private Sub Report_Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AMCDataSet.IncomeLog' table. You can move, or remove it, as needed.
        Me.IncomeLogTableAdapter.Fill(Me.AMCDataSet.IncomeLog)
        'TODO: This line of code loads data into the 'AMCDataSet.MonthlyExpenses' table. You can move, or remove it, as needed.
        Me.MonthlyExpensesTableAdapter.Fill(Me.AMCDataSet.MonthlyExpenses)
        'TODO: This line of code loads data into the 'AMCDataSet.YearlyExpenses' table. You can move, or remove it, as needed.
        Me.YearlyExpensesTableAdapter.Fill(Me.AMCDataSet.YearlyExpenses)
        'TODO: This line of code loads data into the 'AMCDataSet.MemberDetails' table. You can move, or remove it, as needed.
        Me.MemberDetailsTableAdapter.Fill(Me.AMCDataSet.MemberDetails)
        'TODO: This line of code loads data into the 'AMCDataSet.EmployeeDetails' table. You can move, or remove it, as needed.
        Me.EmployeeDetailsTableAdapter.Fill(Me.AMCDataSet.EmployeeDetails)

    End Sub

    'Sub-routine that loads specific report depending on the report selected in the combo-box
    Private Sub comboReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboReport.SelectedIndexChanged
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        'Shows the necessry controls and hides the unneccesary controls.
        Label1.Show()
        Report.Show()
        Label3.Visible = False
        Label4.Visible = False
        PictureBox1.Visible = False
        DataGridView1.Visible = False
        'Selection statement that checks the content of the combo box.
        If comboReport.Text = "" Then
            'Shows a messagebox if no report is selected.
            MsgBox("Please Select Report!", vbOKOnly)
        ElseIf comboReport.Text = "Employee Details Report" Then
            'Hides label that says "No report Selected", loads all the neccessary settings for the report and refreshes the report viewer.
            Label1.Hide()
            ReportDataSource1.Name = "EmployeeDetails"
            ReportDataSource1.Value = Me.EmployeeDetailsBindingSource
            Me.Report.LocalReport.DataSources.Add(ReportDataSource1)
            Me.Report.LocalReport.ReportEmbeddedResource = "AMC.EmployeeDetails.rdlc"
            Report.RefreshReport()

        ElseIf comboReport.Text = "Member Details Report" Then
            'Hides label that says "No report Selected", loads all the neccessary settings for the report and refreshes the report viewer.
            Label1.Hide()
            ReportDataSource1.Name = "MemberDetails"
            ReportDataSource1.Value = Me.MemberDetailsBindingSource
            Me.Report.LocalReport.DataSources.Add(ReportDataSource1)
            Me.Report.LocalReport.ReportEmbeddedResource = "AMC.MemberDetails.rdlc"
            Report.RefreshReport()
        ElseIf comboReport.Text = "Statement Of Income" Then
            'Hides label that says "No report Selected", loads all the neccessary settings for the report and refreshes the report viewer.
            Label1.Hide()
            ReportDataSource1.Name = "Dataset1"
            ReportDataSource1.Value = Me.IncomeLogBindingSource
            Me.Report.LocalReport.DataSources.Add(ReportDataSource1)
            Me.Report.LocalReport.ReportEmbeddedResource = "AMC.StatementofIncome.rdlc"
            Report.RefreshReport()
        ElseIf comboReport.Text = "Statement of Expenditure" Then
            'Hides label that says "No report Selected", loads all the neccessary settings for the datagridview and loads the report onto the datagridview.
            Label1.Hide()
            Report.Hide()
            Label3.Visible = True
            Label4.Visible = True
            PictureBox1.Visible = True
            DataGridView1.Visible = True
            DataGridView1.AutoGenerateColumns = True
            DataGridView1.Update()
            DataGridView1.DataSource = MonthlyExpensesTableAdapter.GetData()
            DataGridView1.Refresh()

        End If
    End Sub
    'Sub-routine that closes current form and shows the MainMenu.
    Private Sub cmdHome_Click(sender As Object, e As EventArgs) Handles cmdHome.Click
        frmMainMenu.Show()
        Me.Close()
    End Sub
End Class