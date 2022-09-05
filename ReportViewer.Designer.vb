<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportViewer
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportViewer))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.IncomeLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AMCDataSet = New AMC.AMCDataSet()
        Me.Report = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboReport = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdHome = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MonthlyExpensesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemberDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YearlyExpensesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeDetailsTableAdapter = New AMC.AMCDataSetTableAdapters.EmployeeDetailsTableAdapter()
        Me.MemberDetailsTableAdapter = New AMC.AMCDataSetTableAdapters.MemberDetailsTableAdapter()
        Me.YearlyExpensesTableAdapter = New AMC.AMCDataSetTableAdapters.YearlyExpensesTableAdapter()
        Me.MonthlyExpensesTableAdapter = New AMC.AMCDataSetTableAdapters.MonthlyExpensesTableAdapter()
        Me.IncomeLogTableAdapter = New AMC.AMCDataSetTableAdapters.IncomeLogTableAdapter()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeOfExpenseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecieptDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ApprovedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.IncomeLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AMCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonthlyExpensesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YearlyExpensesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IncomeLogBindingSource
        '
        Me.IncomeLogBindingSource.DataMember = "IncomeLog"
        Me.IncomeLogBindingSource.DataSource = Me.AMCDataSet
        '
        'AMCDataSet
        '
        Me.AMCDataSet.DataSetName = "AMCDataSet"
        Me.AMCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Report
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.IncomeLogBindingSource
        Me.Report.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Report.LocalReport.ReportEmbeddedResource = "AMC.StatementofIncome.rdlc"
        Me.Report.Location = New System.Drawing.Point(-1, 52)
        Me.Report.Name = "Report"
        Me.Report.Size = New System.Drawing.Size(1361, 652)
        Me.Report.TabIndex = 0
        Me.Report.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("BN Dragon", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select Report:"
        '
        'comboReport
        '
        Me.comboReport.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboReport.FormattingEnabled = True
        Me.comboReport.Items.AddRange(New Object() {"Employee Details Report", "Member Details Report", "Statement Of Income", "Statement of Expenditure"})
        Me.comboReport.Location = New System.Drawing.Point(172, 6)
        Me.comboReport.Name = "comboReport"
        Me.comboReport.Size = New System.Drawing.Size(338, 32)
        Me.comboReport.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(548, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "No Report Selected!"
        '
        'cmdHome
        '
        Me.cmdHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHome.Font = New System.Drawing.Font("HURTMOLD_", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHome.ForeColor = System.Drawing.Color.White
        Me.cmdHome.Image = CType(resources.GetObject("cmdHome.Image"), System.Drawing.Image)
        Me.cmdHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdHome.Location = New System.Drawing.Point(1241, 3)
        Me.cmdHome.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdHome.Name = "cmdHome"
        Me.cmdHome.Size = New System.Drawing.Size(103, 46)
        Me.cmdHome.TabIndex = 58
        Me.cmdHome.Text = "Home"
        Me.cmdHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdHome.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 115)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tele-Marines", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(169, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(813, 25)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "STATEMENT OF EXPENDITURE REPORT"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(844, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 13)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "22/12/2015 10:57:44 AM"
        Me.Label4.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(112, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("BN Dragon", 11.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(112, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIDDataGridViewTextBoxColumn, Me.EmployeeNameDataGridViewTextBoxColumn, Me.TransactionDateDataGridViewTextBoxColumn, Me.TypeOfExpenseDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.RecieptDataGridViewImageColumn, Me.ApprovedDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.MonthlyExpensesBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 11.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(4, 167)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.DataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.Size = New System.Drawing.Size(1356, 537)
        Me.DataGridView1.TabIndex = 62
        Me.DataGridView1.Visible = False
        '
        'MonthlyExpensesBindingSource
        '
        Me.MonthlyExpensesBindingSource.DataMember = "MonthlyExpenses"
        Me.MonthlyExpensesBindingSource.DataSource = Me.AMCDataSet
        '
        'MemberDetailsBindingSource
        '
        Me.MemberDetailsBindingSource.DataMember = "MemberDetails"
        Me.MemberDetailsBindingSource.DataSource = Me.AMCDataSet
        '
        'EmployeeDetailsBindingSource
        '
        Me.EmployeeDetailsBindingSource.DataMember = "EmployeeDetails"
        Me.EmployeeDetailsBindingSource.DataSource = Me.AMCDataSet
        '
        'YearlyExpensesBindingSource
        '
        Me.YearlyExpensesBindingSource.DataMember = "YearlyExpenses"
        Me.YearlyExpensesBindingSource.DataSource = Me.AMCDataSet
        '
        'EmployeeDetailsTableAdapter
        '
        Me.EmployeeDetailsTableAdapter.ClearBeforeFill = True
        '
        'MemberDetailsTableAdapter
        '
        Me.MemberDetailsTableAdapter.ClearBeforeFill = True
        '
        'YearlyExpensesTableAdapter
        '
        Me.YearlyExpensesTableAdapter.ClearBeforeFill = True
        '
        'MonthlyExpensesTableAdapter
        '
        Me.MonthlyExpensesTableAdapter.ClearBeforeFill = True
        '
        'IncomeLogTableAdapter
        '
        Me.IncomeLogTableAdapter.ClearBeforeFill = True
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        Me.EmployeeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmployeeNameDataGridViewTextBoxColumn
        '
        Me.EmployeeNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeName"
        Me.EmployeeNameDataGridViewTextBoxColumn.HeaderText = "EmployeeName"
        Me.EmployeeNameDataGridViewTextBoxColumn.Name = "EmployeeNameDataGridViewTextBoxColumn"
        Me.EmployeeNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TransactionDateDataGridViewTextBoxColumn
        '
        Me.TransactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate"
        Me.TransactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate"
        Me.TransactionDateDataGridViewTextBoxColumn.Name = "TransactionDateDataGridViewTextBoxColumn"
        Me.TransactionDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeOfExpenseDataGridViewTextBoxColumn
        '
        Me.TypeOfExpenseDataGridViewTextBoxColumn.DataPropertyName = "TypeOfExpense"
        Me.TypeOfExpenseDataGridViewTextBoxColumn.HeaderText = "TypeOfExpense"
        Me.TypeOfExpenseDataGridViewTextBoxColumn.Name = "TypeOfExpenseDataGridViewTextBoxColumn"
        Me.TypeOfExpenseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RecieptDataGridViewImageColumn
        '
        Me.RecieptDataGridViewImageColumn.DataPropertyName = "Reciept"
        Me.RecieptDataGridViewImageColumn.HeaderText = "Reciept"
        Me.RecieptDataGridViewImageColumn.Name = "RecieptDataGridViewImageColumn"
        Me.RecieptDataGridViewImageColumn.ReadOnly = True
        '
        'ApprovedDataGridViewCheckBoxColumn
        '
        Me.ApprovedDataGridViewCheckBoxColumn.DataPropertyName = "Approved"
        Me.ApprovedDataGridViewCheckBoxColumn.HeaderText = "Approved"
        Me.ApprovedDataGridViewCheckBoxColumn.Name = "ApprovedDataGridViewCheckBoxColumn"
        Me.ApprovedDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1354, 750)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdHome)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.comboReport)
        Me.Controls.Add(Me.Report)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportViewer"
        Me.Text = "Report Viewer - [AMC]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.IncomeLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AMCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonthlyExpensesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YearlyExpensesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmployeeDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AMCDataSet As AMC.AMCDataSet
    Friend WithEvents EmployeeDetailsTableAdapter As AMC.AMCDataSetTableAdapters.EmployeeDetailsTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents comboReport As System.Windows.Forms.ComboBox
    Friend WithEvents MemberDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MemberDetailsTableAdapter As AMC.AMCDataSetTableAdapters.MemberDetailsTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents YearlyExpensesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents YearlyExpensesTableAdapter As AMC.AMCDataSetTableAdapters.YearlyExpensesTableAdapter
    Friend WithEvents Report As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents cmdHome As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MonthlyExpensesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MonthlyExpensesTableAdapter As AMC.AMCDataSetTableAdapters.MonthlyExpensesTableAdapter
    Friend WithEvents IncomeLogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IncomeLogTableAdapter As AMC.AMCDataSetTableAdapters.IncomeLogTableAdapter
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransactionDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeOfExpenseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecieptDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ApprovedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class
