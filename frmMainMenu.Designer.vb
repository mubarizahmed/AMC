<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdIncomeLog = New System.Windows.Forms.Button()
        Me.cmdExpenseLog = New System.Windows.Forms.Button()
        Me.cmdMemberDetails = New System.Windows.Forms.Button()
        Me.cmdEmployeeDetails = New System.Windows.Forms.Button()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.Basic = New System.Windows.Forms.TabPage()
        Me.TabEndMonth = New System.Windows.Forms.TabPage()
        Me.cmdViewReports = New System.Windows.Forms.Button()
        Me.cmdBalanceEmail = New System.Windows.Forms.Button()
        Me.cmdUpdateMemberBalances = New System.Windows.Forms.Button()
        Me.AMCDataSet = New AMC.AMCDataSet()
        Me.EmployeeDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeDetailsTableAdapter = New AMC.AMCDataSetTableAdapters.EmployeeDetailsTableAdapter()
        Me.MemberDetailsTableAdapter1 = New AMC.AMCDataSetTableAdapters.MemberDetailsTableAdapter()
        Me.MemberDetailsTableAdapter = New AMC.AMCDataSetTableAdapters.MemberDetailsTableAdapter()
        Me.MemberDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.Basic.SuspendLayout()
        Me.TabEndMonth.SuspendLayout()
        CType(Me.AMCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1354, 709)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackColor = System.Drawing.Color.White
        Me.RectangleShape3.BorderWidth = 2
        Me.RectangleShape3.FillColor = System.Drawing.Color.White
        Me.RectangleShape3.FillGradientColor = System.Drawing.Color.White
        Me.RectangleShape3.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central
        Me.RectangleShape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RectangleShape3.Location = New System.Drawing.Point(30, 124)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(1300, 536)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.White
        Me.RectangleShape2.BorderWidth = 3
        Me.RectangleShape2.FillColor = System.Drawing.Color.White
        Me.RectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Weave
        Me.RectangleShape2.Location = New System.Drawing.Point(-5, 126)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(1388, 585)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(31, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(158, 122)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tele-Marines", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label1.Location = New System.Drawing.Point(451, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 44)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MAIN MENU"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdIncomeLog
        '
        Me.cmdIncomeLog.Font = New System.Drawing.Font("Discognate", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIncomeLog.ForeColor = System.Drawing.Color.Black
        Me.cmdIncomeLog.Location = New System.Drawing.Point(36, 32)
        Me.cmdIncomeLog.Name = "cmdIncomeLog"
        Me.cmdIncomeLog.Size = New System.Drawing.Size(363, 146)
        Me.cmdIncomeLog.TabIndex = 4
        Me.cmdIncomeLog.Text = "Income Log Form"
        Me.cmdIncomeLog.UseVisualStyleBackColor = True
        '
        'cmdExpenseLog
        '
        Me.cmdExpenseLog.Font = New System.Drawing.Font("Discognate", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExpenseLog.Location = New System.Drawing.Point(658, 32)
        Me.cmdExpenseLog.Name = "cmdExpenseLog"
        Me.cmdExpenseLog.Size = New System.Drawing.Size(363, 146)
        Me.cmdExpenseLog.TabIndex = 5
        Me.cmdExpenseLog.Text = "Expense Log Form"
        Me.cmdExpenseLog.UseVisualStyleBackColor = True
        '
        'cmdMemberDetails
        '
        Me.cmdMemberDetails.Font = New System.Drawing.Font("Discognate", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMemberDetails.Location = New System.Drawing.Point(36, 227)
        Me.cmdMemberDetails.Name = "cmdMemberDetails"
        Me.cmdMemberDetails.Size = New System.Drawing.Size(363, 146)
        Me.cmdMemberDetails.TabIndex = 6
        Me.cmdMemberDetails.Text = "Member Details Form"
        Me.cmdMemberDetails.UseVisualStyleBackColor = True
        '
        'cmdEmployeeDetails
        '
        Me.cmdEmployeeDetails.Font = New System.Drawing.Font("Discognate", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmployeeDetails.Location = New System.Drawing.Point(658, 227)
        Me.cmdEmployeeDetails.Name = "cmdEmployeeDetails"
        Me.cmdEmployeeDetails.Size = New System.Drawing.Size(363, 146)
        Me.cmdEmployeeDetails.TabIndex = 7
        Me.cmdEmployeeDetails.Text = "Employee Details Form"
        Me.cmdEmployeeDetails.UseVisualStyleBackColor = True
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Danube", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Gray
        Me.lblUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblUser.Location = New System.Drawing.Point(1180, 99)
        Me.lblUser.MinimumSize = New System.Drawing.Size(142, 20)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(142, 20)
        Me.lblUser.TabIndex = 40
        Me.lblUser.Text = "Secretary Maal"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label18.Font = New System.Drawing.Font("Discognate Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label18.Image = CType(resources.GetObject("Label18.Image"), System.Drawing.Image)
        Me.Label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label18.Location = New System.Drawing.Point(1319, 93)
        Me.Label18.MinimumSize = New System.Drawing.Size(35, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 30)
        Me.Label18.TabIndex = 39
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.Basic)
        Me.TabControl.Controls.Add(Me.TabEndMonth)
        Me.TabControl.Font = New System.Drawing.Font("Good Times", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(143, 173)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1061, 446)
        Me.TabControl.TabIndex = 41
        '
        'Basic
        '
        Me.Basic.Controls.Add(Me.cmdIncomeLog)
        Me.Basic.Controls.Add(Me.cmdMemberDetails)
        Me.Basic.Controls.Add(Me.cmdExpenseLog)
        Me.Basic.Controls.Add(Me.cmdEmployeeDetails)
        Me.Basic.Font = New System.Drawing.Font("Good Times", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Basic.Location = New System.Drawing.Point(4, 30)
        Me.Basic.Name = "Basic"
        Me.Basic.Padding = New System.Windows.Forms.Padding(3)
        Me.Basic.Size = New System.Drawing.Size(1053, 412)
        Me.Basic.TabIndex = 0
        Me.Basic.Text = "Basic"
        Me.Basic.UseVisualStyleBackColor = True
        '
        'TabEndMonth
        '
        Me.TabEndMonth.Controls.Add(Me.cmdViewReports)
        Me.TabEndMonth.Controls.Add(Me.cmdBalanceEmail)
        Me.TabEndMonth.Controls.Add(Me.cmdUpdateMemberBalances)
        Me.TabEndMonth.Font = New System.Drawing.Font("Good Times", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabEndMonth.Location = New System.Drawing.Point(4, 30)
        Me.TabEndMonth.Name = "TabEndMonth"
        Me.TabEndMonth.Padding = New System.Windows.Forms.Padding(3)
        Me.TabEndMonth.Size = New System.Drawing.Size(1053, 412)
        Me.TabEndMonth.TabIndex = 1
        Me.TabEndMonth.Text = "End Month Processing"
        Me.TabEndMonth.UseVisualStyleBackColor = True
        '
        'cmdViewReports
        '
        Me.cmdViewReports.Font = New System.Drawing.Font("Discognate", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewReports.ForeColor = System.Drawing.Color.Black
        Me.cmdViewReports.Location = New System.Drawing.Point(70, 212)
        Me.cmdViewReports.Name = "cmdViewReports"
        Me.cmdViewReports.Size = New System.Drawing.Size(891, 76)
        Me.cmdViewReports.TabIndex = 7
        Me.cmdViewReports.Text = "View Reports"
        Me.cmdViewReports.UseVisualStyleBackColor = True
        '
        'cmdBalanceEmail
        '
        Me.cmdBalanceEmail.Font = New System.Drawing.Font("Discognate", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBalanceEmail.ForeColor = System.Drawing.Color.Black
        Me.cmdBalanceEmail.Location = New System.Drawing.Point(70, 121)
        Me.cmdBalanceEmail.Name = "cmdBalanceEmail"
        Me.cmdBalanceEmail.Size = New System.Drawing.Size(891, 76)
        Me.cmdBalanceEmail.TabIndex = 6
        Me.cmdBalanceEmail.Text = "Send Member Balances Email"
        Me.cmdBalanceEmail.UseVisualStyleBackColor = True
        '
        'cmdUpdateMemberBalances
        '
        Me.cmdUpdateMemberBalances.Font = New System.Drawing.Font("Discognate", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdateMemberBalances.ForeColor = System.Drawing.Color.Black
        Me.cmdUpdateMemberBalances.Location = New System.Drawing.Point(70, 18)
        Me.cmdUpdateMemberBalances.Name = "cmdUpdateMemberBalances"
        Me.cmdUpdateMemberBalances.Size = New System.Drawing.Size(891, 76)
        Me.cmdUpdateMemberBalances.TabIndex = 5
        Me.cmdUpdateMemberBalances.Text = "Update Member Balances"
        Me.cmdUpdateMemberBalances.UseVisualStyleBackColor = True
        '
        'AMCDataSet
        '
        Me.AMCDataSet.DataSetName = "AMCDataSet"
        Me.AMCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeDetailsBindingSource
        '
        Me.EmployeeDetailsBindingSource.DataMember = "EmployeeDetails"
        Me.EmployeeDetailsBindingSource.DataSource = Me.AMCDataSet
        '
        'EmployeeDetailsTableAdapter
        '
        Me.EmployeeDetailsTableAdapter.ClearBeforeFill = True
        '
        'MemberDetailsTableAdapter1
        '
        Me.MemberDetailsTableAdapter1.ClearBeforeFill = True
        '
        'MemberDetailsTableAdapter
        '
        Me.MemberDetailsTableAdapter.ClearBeforeFill = True
        '
        'MemberDetailsBindingSource
        '
        Me.MemberDetailsBindingSource.DataMember = "MemberDetails"
        Me.MemberDetailsBindingSource.DataSource = Me.AMCDataSet
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1354, 709)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMainMenu"
        Me.Text = "Main Menu - [AMC]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.Basic.ResumeLayout(False)
        Me.TabEndMonth.ResumeLayout(False)
        CType(Me.AMCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click

    End Sub
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdIncomeLog As System.Windows.Forms.Button
    Friend WithEvents cmdExpenseLog As System.Windows.Forms.Button
    Friend WithEvents cmdMemberDetails As System.Windows.Forms.Button
    Friend WithEvents cmdEmployeeDetails As System.Windows.Forms.Button
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents Basic As System.Windows.Forms.TabPage
    Friend WithEvents TabEndMonth As System.Windows.Forms.TabPage
    Friend WithEvents cmdUpdateMemberBalances As System.Windows.Forms.Button
    Friend WithEvents cmdBalanceEmail As System.Windows.Forms.Button
    Friend WithEvents cmdViewReports As System.Windows.Forms.Button
    Friend WithEvents EmployeeDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AMCDataSet As AMC.AMCDataSet
    Friend WithEvents EmployeeDetailsTableAdapter As AMC.AMCDataSetTableAdapters.EmployeeDetailsTableAdapter
    Friend WithEvents MemberDetailsTableAdapter1 As AMC.AMCDataSetTableAdapters.MemberDetailsTableAdapter
    Friend WithEvents MemberDetailsTableAdapter As AMC.AMCDataSetTableAdapters.MemberDetailsTableAdapter
    Friend WithEvents MemberDetailsBindingSource As System.Windows.Forms.BindingSource
End Class
