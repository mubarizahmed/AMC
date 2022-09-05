<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncomeLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIncomeLog))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRecieptNo = New System.Windows.Forms.TextBox()
        Me.IncomeLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AMCDataSet = New AMC.AMCDataSet()
        Me.txtMemberID = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.txtMemberName = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dateReciept = New System.Windows.Forms.DateTimePicker()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmdHome = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdAddNew = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.IncomeLogTableAdapter = New AMC.AMCDataSetTableAdapters.IncomeLogTableAdapter()
        Me.MemberDetailsTableAdapter1 = New AMC.AMCDataSetTableAdapters.MemberDetailsTableAdapter()
        Me.TableAdapterManager1 = New AMC.AMCDataSetTableAdapters.TableAdapterManager()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtAnsar = New System.Windows.Forms.TextBox()
        Me.txtKhuddam = New System.Windows.Forms.TextBox()
        Me.txtLajna = New System.Windows.Forms.TextBox()
        Me.txtBookPurchase = New System.Windows.Forms.TextBox()
        Me.txtZakat = New System.Windows.Forms.TextBox()
        Me.txtFitrana = New System.Windows.Forms.TextBox()
        Me.txtEidFund = New System.Windows.Forms.TextBox()
        Me.txtSadaqah = New System.Windows.Forms.TextBox()
        Me.txtTJ = New System.Windows.Forms.TextBox()
        Me.txtWJ = New System.Windows.Forms.TextBox()
        Me.txtJalsaSalana = New System.Windows.Forms.TextBox()
        Me.txtChandaAam = New System.Windows.Forms.TextBox()
        Me.txtWasiyyat = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncomeLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AMCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1354, 726)
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
        Me.Label1.Location = New System.Drawing.Point(195, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(488, 44)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Income Log"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Discognate", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label2.Location = New System.Drawing.Point(113, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Reciept No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Discognate", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label3.Location = New System.Drawing.Point(113, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Member ID:"
        '
        'txtRecieptNo
        '
        Me.txtRecieptNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeLogBindingSource, "RecieptNo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.txtRecieptNo.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecieptNo.Location = New System.Drawing.Point(217, 144)
        Me.txtRecieptNo.Name = "txtRecieptNo"
        Me.txtRecieptNo.Size = New System.Drawing.Size(68, 33)
        Me.txtRecieptNo.TabIndex = 20
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
        'txtMemberID
        '
        Me.txtMemberID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeLogBindingSource, "MemberID", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N0"))
        Me.txtMemberID.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberID.Location = New System.Drawing.Point(217, 184)
        Me.txtMemberID.Name = "txtMemberID"
        Me.txtMemberID.Size = New System.Drawing.Size(68, 33)
        Me.txtMemberID.TabIndex = 21
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 23)
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 23)
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(100, 23)
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(23, 23)
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 23)
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 23)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 23)
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 23)
        '
        'txtMemberName
        '
        Me.txtMemberName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeLogBindingSource, "MemberName", True))
        Me.txtMemberName.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberName.Location = New System.Drawing.Point(473, 186)
        Me.txtMemberName.Name = "txtMemberName"
        Me.txtMemberName.ReadOnly = True
        Me.txtMemberName.Size = New System.Drawing.Size(244, 33)
        Me.txtMemberName.TabIndex = 42
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Discognate", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label18.Location = New System.Drawing.Point(351, 195)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(118, 24)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "Member Name:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Discognate", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label19.Location = New System.Drawing.Point(416, 153)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 24)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "Date:"
        '
        'dateReciept
        '
        Me.dateReciept.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeLogBindingSource, "RecieptDate", True))
        Me.dateReciept.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateReciept.Location = New System.Drawing.Point(473, 144)
        Me.dateReciept.Name = "dateReciept"
        Me.dateReciept.Size = New System.Drawing.Size(244, 33)
        Me.dateReciept.TabIndex = 50
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.IncomeLogBindingSource
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel1
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.BindingNavigator1.Location = New System.Drawing.Point(453, 619)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton1
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton4
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton3
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton2
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox1
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BindingNavigator1.Size = New System.Drawing.Size(255, 39)
        Me.BindingNavigator1.TabIndex = 51
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 36)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "Move first"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton2.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton3.Text = "Move next"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton4.Text = "Move last"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Danube", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Gray
        Me.lblUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblUser.Location = New System.Drawing.Point(1172, 100)
        Me.lblUser.MinimumSize = New System.Drawing.Size(142, 20)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(142, 20)
        Me.lblUser.TabIndex = 59
        Me.lblUser.Text = "Secretary Maal"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label21.Font = New System.Drawing.Font("Discognate Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label21.Image = CType(resources.GetObject("Label21.Image"), System.Drawing.Image)
        Me.Label21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label21.Location = New System.Drawing.Point(1311, 94)
        Me.Label21.MinimumSize = New System.Drawing.Size(35, 30)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 30)
        Me.Label21.TabIndex = 58
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdHome
        '
        Me.cmdHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHome.Font = New System.Drawing.Font("HURTMOLD_", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHome.ForeColor = System.Drawing.Color.White
        Me.cmdHome.Image = CType(resources.GetObject("cmdHome.Image"), System.Drawing.Image)
        Me.cmdHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdHome.Location = New System.Drawing.Point(1213, 12)
        Me.cmdHome.Name = "cmdHome"
        Me.cmdHome.Size = New System.Drawing.Size(129, 60)
        Me.cmdHome.TabIndex = 57
        Me.cmdHome.Text = "Home"
        Me.cmdHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdHome.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrint.Font = New System.Drawing.Font("HURTMOLD_", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(869, 328)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(133, 57)
        Me.cmdPrint.TabIndex = 56
        Me.cmdPrint.Text = "Print Record"
        Me.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdFind
        '
        Me.cmdFind.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFind.Font = New System.Drawing.Font("HURTMOLD_", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.ForeColor = System.Drawing.Color.White
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFind.Location = New System.Drawing.Point(869, 391)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(133, 57)
        Me.cmdFind.TabIndex = 55
        Me.cmdFind.Text = "Find Record"
        Me.cmdFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("HURTMOLD_", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(869, 203)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(133, 57)
        Me.cmdSave.TabIndex = 54
        Me.cmdSave.Text = "Save Record"
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Font = New System.Drawing.Font("HURTMOLD_", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.ForeColor = System.Drawing.Color.White
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.Location = New System.Drawing.Point(869, 265)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(133, 57)
        Me.cmdDelete.TabIndex = 53
        Me.cmdDelete.Text = "Delete Record"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdAddNew
        '
        Me.cmdAddNew.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.cmdAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAddNew.Font = New System.Drawing.Font("HURTMOLD_", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddNew.ForeColor = System.Drawing.Color.White
        Me.cmdAddNew.Image = CType(resources.GetObject("cmdAddNew.Image"), System.Drawing.Image)
        Me.cmdAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAddNew.Location = New System.Drawing.Point(869, 140)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(133, 57)
        Me.cmdAddNew.TabIndex = 52
        Me.cmdAddNew.Text = "Add Record"
        Me.cmdAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAddNew.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'IncomeLogTableAdapter
        '
        Me.IncomeLogTableAdapter.ClearBeforeFill = True
        '
        'MemberDetailsTableAdapter1
        '
        Me.MemberDetailsTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.EmployeeDetailsTableAdapter = Nothing
        Me.TableAdapterManager1.ExpenseLogTableAdapter = Nothing
        Me.TableAdapterManager1.IncomeLogTableAdapter = Me.IncomeLogTableAdapter
        Me.TableAdapterManager1.MemberDetailsTableAdapter = Me.MemberDetailsTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = AMC.AMCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cmdReset
        '
        Me.cmdReset.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.cmdReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReset.Font = New System.Drawing.Font("HURTMOLD_", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.ForeColor = System.Drawing.Color.White
        Me.cmdReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdReset.Location = New System.Drawing.Point(907, 454)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(70, 24)
        Me.cmdReset.TabIndex = 70
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.txtAnsar)
        Me.Panel1.Controls.Add(Me.txtKhuddam)
        Me.Panel1.Controls.Add(Me.txtLajna)
        Me.Panel1.Controls.Add(Me.txtBookPurchase)
        Me.Panel1.Controls.Add(Me.txtZakat)
        Me.Panel1.Controls.Add(Me.txtFitrana)
        Me.Panel1.Controls.Add(Me.txtEidFund)
        Me.Panel1.Controls.Add(Me.txtSadaqah)
        Me.Panel1.Controls.Add(Me.txtTJ)
        Me.Panel1.Controls.Add(Me.txtWJ)
        Me.Panel1.Controls.Add(Me.txtJalsaSalana)
        Me.Panel1.Controls.Add(Me.txtChandaAam)
        Me.Panel1.Controls.Add(Me.txtWasiyyat)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(110, 220)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(610, 396)
        Me.Panel1.TabIndex = 71
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeLogBindingSource, "Total", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(364, 367)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(244, 27)
        Me.txtTotal.TabIndex = 126
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAnsar
        '
        Me.txtAnsar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeLogBindingSource, "Ansar", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.txtAnsar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnsar.Location = New System.Drawing.Point(364, 339)
        Me.txtAnsar.Name = "txtAnsar"
        Me.txtAnsar.Size = New System.Drawing.Size(244, 27)
        Me.txtAnsar.TabIndex = 125
        Me.txtAnsar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKhuddam
        '
        Me.txtKhuddam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeLogBindingSource, "Khuddam", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.txtKhuddam.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKhuddam.Location = New System.Drawing.Point(364, 311)
        Me.txtKhuddam.Name = "txtKhuddam"
        Me.txtKhuddam.Size = New System.Drawing.Size(244, 27)
        Me.txtKhuddam.TabIndex = 124
        Me.txtKhuddam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLajna
        '
        Me.txtLajna.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeLogBindingSource, "Lajna", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.txtLajna.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLajna.Location = New System.Drawing.Point(364, 283)
        Me.txtLajna.Name = "txtLajna"
        Me.txtLajna.Size = New System.Drawing.Size(244, 27)
        Me.txtLajna.TabIndex = 123
        Me.txtLajna.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBookPurchase
        '
        Me.txtBookPurchase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeLogBindingSource, "Zakat", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.txtBookPurchase.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookPurchase.Location = New System.Drawing.Point(364, 255)
        Me.txtBookPurchase.Name = "txtBookPurchase"
        Me.txtBookPurchase.Size = New System.Drawing.Size(244, 27)
        Me.txtBookPurchase.TabIndex = 122
        Me.txtBookPurchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtZakat
        '
        Me.txtZakat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeLogBindingSource, "Zakat", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.txtZakat.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZakat.Location = New System.Drawing.Point(364, 227)
        Me.txtZakat.Name = "txtZakat"
        Me.txtZakat.Size = New System.Drawing.Size(244, 27)
        Me.txtZakat.TabIndex = 121
        Me.txtZakat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFitrana
        '
        Me.txtFitrana.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeLogBindingSource, "Fitrana", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.txtFitrana.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFitrana.Location = New System.Drawing.Point(364, 199)
        Me.txtFitrana.Name = "txtFitrana"
        Me.txtFitrana.Size = New System.Drawing.Size(244, 27)
        Me.txtFitrana.TabIndex = 120
        Me.txtFitrana.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEidFund
        '
        Me.txtEidFund.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeLogBindingSource, "EidFund", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.txtEidFund.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEidFund.Location = New System.Drawing.Point(364, 171)
        Me.txtEidFund.Name = "txtEidFund"
        Me.txtEidFund.Size = New System.Drawing.Size(244, 27)
        Me.txtEidFund.TabIndex = 119
        Me.txtEidFund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSadaqah
        '
        Me.txtSadaqah.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeLogBindingSource, "Sadaqah", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.txtSadaqah.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSadaqah.Location = New System.Drawing.Point(364, 143)
        Me.txtSadaqah.Name = "txtSadaqah"
        Me.txtSadaqah.Size = New System.Drawing.Size(244, 27)
        Me.txtSadaqah.TabIndex = 118
        Me.txtSadaqah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTJ
        '
        Me.txtTJ.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeLogBindingSource, "TJ", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.txtTJ.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTJ.Location = New System.Drawing.Point(364, 115)
        Me.txtTJ.Name = "txtTJ"
        Me.txtTJ.Size = New System.Drawing.Size(244, 27)
        Me.txtTJ.TabIndex = 117
        Me.txtTJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWJ
        '
        Me.txtWJ.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeLogBindingSource, "WJ", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.txtWJ.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWJ.Location = New System.Drawing.Point(364, 87)
        Me.txtWJ.Name = "txtWJ"
        Me.txtWJ.Size = New System.Drawing.Size(244, 27)
        Me.txtWJ.TabIndex = 116
        Me.txtWJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtJalsaSalana
        '
        Me.txtJalsaSalana.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeLogBindingSource, "JalsaSalana", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.txtJalsaSalana.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJalsaSalana.Location = New System.Drawing.Point(364, 59)
        Me.txtJalsaSalana.Name = "txtJalsaSalana"
        Me.txtJalsaSalana.Size = New System.Drawing.Size(244, 27)
        Me.txtJalsaSalana.TabIndex = 115
        Me.txtJalsaSalana.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtChandaAam
        '
        Me.txtChandaAam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeLogBindingSource, "ChandaAam", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.txtChandaAam.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChandaAam.Location = New System.Drawing.Point(364, 31)
        Me.txtChandaAam.Name = "txtChandaAam"
        Me.txtChandaAam.Size = New System.Drawing.Size(244, 27)
        Me.txtChandaAam.TabIndex = 114
        Me.txtChandaAam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtWasiyyat
        '
        Me.txtWasiyyat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IncomeLogBindingSource, "Wasiyyat", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "0"))
        Me.txtWasiyyat.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWasiyyat.Location = New System.Drawing.Point(364, 3)
        Me.txtWasiyyat.Name = "txtWasiyyat"
        Me.txtWasiyyat.Size = New System.Drawing.Size(244, 27)
        Me.txtWasiyyat.TabIndex = 113
        Me.txtWasiyyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Discognate", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label17.Location = New System.Drawing.Point(4, 370)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 24)
        Me.Label17.TabIndex = 112
        Me.Label17.Text = "TOTAL:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Discognate", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label16.Location = New System.Drawing.Point(3, 342)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 24)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "Ansar:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Discognate", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label15.Location = New System.Drawing.Point(3, 314)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 24)
        Me.Label15.TabIndex = 110
        Me.Label15.Text = "Khuddam:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Discognate", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label14.Location = New System.Drawing.Point(4, 286)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 24)
        Me.Label14.TabIndex = 109
        Me.Label14.Text = "Lajna:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Discognate", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label13.Location = New System.Drawing.Point(4, 258)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 24)
        Me.Label13.TabIndex = 108
        Me.Label13.Text = "Book Purchase:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Discognate", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label12.Location = New System.Drawing.Point(3, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 24)
        Me.Label12.TabIndex = 107
        Me.Label12.Text = "Zakat:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Discognate", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label11.Location = New System.Drawing.Point(3, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 24)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "Fitrana:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Discognate", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label10.Location = New System.Drawing.Point(3, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 24)
        Me.Label10.TabIndex = 105
        Me.Label10.Text = "Eid Fund:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Discognate", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label9.Location = New System.Drawing.Point(4, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 24)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "Sadaqah:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Discognate", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label8.Location = New System.Drawing.Point(4, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 24)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "Tehrike Jadid:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Discognate", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label7.Location = New System.Drawing.Point(4, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 24)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Waqfe Jadid:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Discognate", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label6.Location = New System.Drawing.Point(4, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 24)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Jalsa Salana:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Discognate", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label5.Location = New System.Drawing.Point(4, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 24)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Chanda Aam:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Discognate", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label4.Location = New System.Drawing.Point(4, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 24)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Wasiyyat:"
        '
        'frmIncomeLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1354, 726)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cmdHome)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdAddNew)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.dateReciept)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtMemberName)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtMemberID)
        Me.Controls.Add(Me.txtRecieptNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmIncomeLog"
        Me.Text = "Income Log Form - [AMC]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncomeLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AMCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRecieptNo As System.Windows.Forms.TextBox
    Friend WithEvents txtMemberID As System.Windows.Forms.TextBox
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IncomeLogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IncomeLogTableAdapter As AMC.AMCDataSetTableAdapters.IncomeLogTableAdapter
    Friend WithEvents txtMemberName As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents AMCDataSet As AMC.AMCDataSet
    Friend WithEvents MemberDetailsTableAdapter1 As AMC.AMCDataSetTableAdapters.MemberDetailsTableAdapter
    Friend WithEvents dateReciept As System.Windows.Forms.DateTimePicker
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmdHome As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdAddNew As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableAdapterManager1 As AMC.AMCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtAnsar As System.Windows.Forms.TextBox
    Friend WithEvents txtKhuddam As System.Windows.Forms.TextBox
    Friend WithEvents txtLajna As System.Windows.Forms.TextBox
    Friend WithEvents txtBookPurchase As System.Windows.Forms.TextBox
    Friend WithEvents txtZakat As System.Windows.Forms.TextBox
    Friend WithEvents txtFitrana As System.Windows.Forms.TextBox
    Friend WithEvents txtEidFund As System.Windows.Forms.TextBox
    Friend WithEvents txtSadaqah As System.Windows.Forms.TextBox
    Friend WithEvents txtTJ As System.Windows.Forms.TextBox
    Friend WithEvents txtWJ As System.Windows.Forms.TextBox
    Friend WithEvents txtJalsaSalana As System.Windows.Forms.TextBox
    Friend WithEvents txtChandaAam As System.Windows.Forms.TextBox
    Friend WithEvents txtWasiyyat As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
