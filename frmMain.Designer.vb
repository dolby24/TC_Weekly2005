<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblusrLoggedIn = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblLastSent = New System.Windows.Forms.ToolStripStatusLabel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.dgvProjects = New System.Windows.Forms.DataGridView
        Me.fdgvID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fdgvInDirect = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fdgvCustomer = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fdgvProduct = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fdgvDescription = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fdgvRequestor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fdgvSalesGroup = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fdgvActivities = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fdgvSolutions = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fdgvWorked = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fdgvTravel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fdgvActArea = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fdgvCategory = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fdgvRegion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fdgvEnabled = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fdgvFeld1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fdgvFeld2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RAWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyProjectsDataSet = New TC4_2005.dsMyProjekts
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnZeroAll = New System.Windows.Forms.Button
        Me.lblPrjList = New System.Windows.Forms.Label
        Me.lblSFDCID = New System.Windows.Forms.Label
        Me.cmbSfdcID = New System.Windows.Forms.ComboBox
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblRTM = New System.Windows.Forms.Label
        Me.btnReset = New System.Windows.Forms.Button
        Me.btnFind = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.edtDescription = New System.Windows.Forms.RichTextBox
        Me.btnZero = New System.Windows.Forms.Button
        Me.cmbActivity = New System.Windows.Forms.ComboBox
        Me.cmbSalesGroup = New System.Windows.Forms.ComboBox
        Me.cmbStatus = New System.Windows.Forms.ComboBox
        Me.TypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsLists = New TC4_2005.ListsDataSet
        Me.edtRequestor = New System.Windows.Forms.TextBox
        Me.cmbTravel = New System.Windows.Forms.ComboBox
        Me.cmbWorked = New System.Windows.Forms.ComboBox
        Me.cmbProduct = New System.Windows.Forms.ComboBox
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblActivity = New System.Windows.Forms.Label
        Me.lblProduct = New System.Windows.Forms.Label
        Me.lblSalesGroup = New System.Windows.Forms.Label
        Me.lblStatus = New System.Windows.Forms.Label
        Me.lblRequestor = New System.Windows.Forms.Label
        Me.lblWorked_Travel = New System.Windows.Forms.Label
        Me.lblCustomer = New System.Windows.Forms.Label
        Me.lblNr = New System.Windows.Forms.Label
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.edtCustomer = New System.Windows.Forms.TextBox
        Me.edtNr = New System.Windows.Forms.TextBox
        Me.edtFeld1 = New System.Windows.Forms.TextBox
        Me.edtFeld2 = New System.Windows.Forms.TextBox
        Me.edtRTM = New System.Windows.Forms.TextBox
        Me.lblActArea = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.edtYearSend = New System.Windows.Forms.NumericUpDown
        Me.edtPeriodSend = New System.Windows.Forms.NumericUpDown
        Me.btnNowSend = New System.Windows.Forms.Button
        Me.btnSend = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnSetup = New System.Windows.Forms.Button
        Me.RAWTableAdapter = New TC4_2005.dsMyProjektsTableAdapters.RAWTableAdapter
        Me.TypeTableAdapter = New TC4_2005.ListsDataSetTableAdapters.TypeTableAdapter
        Me.TimeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimeTableAdapter = New TC4_2005.ListsDataSetTableAdapters.TimeTableAdapter
        Me.ProductsTableAdapter = New TC4_2005.ListsDataSetTableAdapters.ProductsTableAdapter
        Me.SalesGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesGroupTableAdapter = New TC4_2005.ListsDataSetTableAdapters.SalesGroupTableAdapter
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RAWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyProjectsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsLists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.edtYearSend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.edtPeriodSend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.lblusrLoggedIn, Me.ToolStripStatusLabel3, Me.lblLastSent})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 575)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1014, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(180, 17)
        Me.ToolStripStatusLabel1.Text = "(c) Johannes Dobler 2013-2015"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(96, 17)
        Me.ToolStripStatusLabel2.Text = "Logged in User: "
        '
        'lblusrLoggedIn
        '
        Me.lblusrLoggedIn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblusrLoggedIn.ForeColor = System.Drawing.Color.Blue
        Me.lblusrLoggedIn.Name = "lblusrLoggedIn"
        Me.lblusrLoggedIn.Size = New System.Drawing.Size(62, 17)
        Me.lblusrLoggedIn.Text = "<not set>"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(101, 17)
        Me.ToolStripStatusLabel3.Text = "Last sent Report:"
        '
        'lblLastSent
        '
        Me.lblLastSent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLastSent.ForeColor = System.Drawing.Color.Blue
        Me.lblLastSent.Name = "lblLastSent"
        Me.lblLastSent.Size = New System.Drawing.Size(90, 17)
        Me.lblLastSent.Text = "<not sent yet>"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1MinSize = 200
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblSFDCID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbSfdcID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblDescription)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblRTM)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnReset)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnFind)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnDelete)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSave)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnUpdate)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.edtDescription)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnZero)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbActivity)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbSalesGroup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbStatus)
        Me.SplitContainer1.Panel2.Controls.Add(Me.edtRequestor)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbTravel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbWorked)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmbProduct)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblActivity)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblProduct)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblSalesGroup)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblStatus)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblRequestor)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblWorked_Travel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblCustomer)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblNr)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtpStartDate)
        Me.SplitContainer1.Panel2.Controls.Add(Me.edtCustomer)
        Me.SplitContainer1.Panel2.Controls.Add(Me.edtNr)
        Me.SplitContainer1.Panel2.Controls.Add(Me.edtFeld1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.edtFeld2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.edtRTM)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblActArea)
        Me.SplitContainer1.Size = New System.Drawing.Size(1014, 537)
        Me.SplitContainer1.SplitterDistance = 507
        Me.SplitContainer1.SplitterIncrement = 5
        Me.SplitContainer1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvProjects)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(505, 503)
        Me.Panel2.TabIndex = 2
        '
        'dgvProjects
        '
        Me.dgvProjects.AllowUserToAddRows = False
        Me.dgvProjects.AllowUserToDeleteRows = False
        Me.dgvProjects.AllowUserToOrderColumns = True
        Me.dgvProjects.AllowUserToResizeRows = False
        Me.dgvProjects.AutoGenerateColumns = False
        Me.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjects.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fdgvID, Me.fdgvInDirect, Me.fdgvCustomer, Me.fdgvProduct, Me.fdgvDescription, Me.fdgvRequestor, Me.fdgvSalesGroup, Me.fdgvActivities, Me.fdgvSolutions, Me.fdgvWorked, Me.fdgvTravel, Me.fdgvActArea, Me.fdgvCategory, Me.fdgvRegion, Me.fdgvEnabled, Me.fdgvFeld1, Me.fdgvFeld2})
        Me.dgvProjects.DataSource = Me.RAWBindingSource
        Me.dgvProjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProjects.Location = New System.Drawing.Point(0, 0)
        Me.dgvProjects.MultiSelect = False
        Me.dgvProjects.Name = "dgvProjects"
        Me.dgvProjects.ReadOnly = True
        Me.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProjects.Size = New System.Drawing.Size(505, 503)
        Me.dgvProjects.TabIndex = 2
        '
        'fdgvID
        '
        Me.fdgvID.DataPropertyName = "ID"
        Me.fdgvID.HeaderText = "ID"
        Me.fdgvID.MinimumWidth = 30
        Me.fdgvID.Name = "fdgvID"
        Me.fdgvID.ReadOnly = True
        Me.fdgvID.Width = 30
        '
        'fdgvInDirect
        '
        Me.fdgvInDirect.DataPropertyName = "InDirect"
        Me.fdgvInDirect.HeaderText = "InDirect"
        Me.fdgvInDirect.Name = "fdgvInDirect"
        Me.fdgvInDirect.ReadOnly = True
        Me.fdgvInDirect.Visible = False
        '
        'fdgvCustomer
        '
        Me.fdgvCustomer.DataPropertyName = "Customer"
        Me.fdgvCustomer.HeaderText = "Customer"
        Me.fdgvCustomer.Name = "fdgvCustomer"
        Me.fdgvCustomer.ReadOnly = True
        '
        'fdgvProduct
        '
        Me.fdgvProduct.DataPropertyName = "Product"
        Me.fdgvProduct.HeaderText = "Product"
        Me.fdgvProduct.Name = "fdgvProduct"
        Me.fdgvProduct.ReadOnly = True
        '
        'fdgvDescription
        '
        Me.fdgvDescription.DataPropertyName = "Description"
        Me.fdgvDescription.HeaderText = "Description"
        Me.fdgvDescription.MinimumWidth = 150
        Me.fdgvDescription.Name = "fdgvDescription"
        Me.fdgvDescription.ReadOnly = True
        Me.fdgvDescription.Width = 250
        '
        'fdgvRequestor
        '
        Me.fdgvRequestor.DataPropertyName = "Requestor"
        Me.fdgvRequestor.HeaderText = "Requestor"
        Me.fdgvRequestor.Name = "fdgvRequestor"
        Me.fdgvRequestor.ReadOnly = True
        '
        'fdgvSalesGroup
        '
        Me.fdgvSalesGroup.DataPropertyName = "Sales Group"
        Me.fdgvSalesGroup.HeaderText = "Sales Group"
        Me.fdgvSalesGroup.Name = "fdgvSalesGroup"
        Me.fdgvSalesGroup.ReadOnly = True
        '
        'fdgvActivities
        '
        Me.fdgvActivities.DataPropertyName = "Activities"
        Me.fdgvActivities.HeaderText = "Activities"
        Me.fdgvActivities.Name = "fdgvActivities"
        Me.fdgvActivities.ReadOnly = True
        '
        'fdgvSolutions
        '
        Me.fdgvSolutions.DataPropertyName = "Solutions"
        Me.fdgvSolutions.HeaderText = "Solutions"
        Me.fdgvSolutions.Name = "fdgvSolutions"
        Me.fdgvSolutions.ReadOnly = True
        Me.fdgvSolutions.Visible = False
        '
        'fdgvWorked
        '
        Me.fdgvWorked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fdgvWorked.DataPropertyName = "Worked"
        Me.fdgvWorked.HeaderText = "Worked"
        Me.fdgvWorked.Name = "fdgvWorked"
        Me.fdgvWorked.ReadOnly = True
        Me.fdgvWorked.Width = 70
        '
        'fdgvTravel
        '
        Me.fdgvTravel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fdgvTravel.DataPropertyName = "Travel"
        Me.fdgvTravel.HeaderText = "Travel"
        Me.fdgvTravel.Name = "fdgvTravel"
        Me.fdgvTravel.ReadOnly = True
        Me.fdgvTravel.Width = 62
        '
        'fdgvActArea
        '
        Me.fdgvActArea.DataPropertyName = "ActArea"
        Me.fdgvActArea.HeaderText = "ActArea"
        Me.fdgvActArea.Name = "fdgvActArea"
        Me.fdgvActArea.ReadOnly = True
        Me.fdgvActArea.Visible = False
        '
        'fdgvCategory
        '
        Me.fdgvCategory.DataPropertyName = "Category"
        Me.fdgvCategory.HeaderText = "Category"
        Me.fdgvCategory.Name = "fdgvCategory"
        Me.fdgvCategory.ReadOnly = True
        '
        'fdgvRegion
        '
        Me.fdgvRegion.DataPropertyName = "Region"
        Me.fdgvRegion.HeaderText = "Region"
        Me.fdgvRegion.Name = "fdgvRegion"
        Me.fdgvRegion.ReadOnly = True
        Me.fdgvRegion.Visible = False
        '
        'fdgvEnabled
        '
        Me.fdgvEnabled.DataPropertyName = "Enabled"
        Me.fdgvEnabled.HeaderText = "Enabled"
        Me.fdgvEnabled.Name = "fdgvEnabled"
        Me.fdgvEnabled.ReadOnly = True
        Me.fdgvEnabled.Visible = False
        '
        'fdgvFeld1
        '
        Me.fdgvFeld1.DataPropertyName = "Feld1"
        Me.fdgvFeld1.HeaderText = "MDCP ID"
        Me.fdgvFeld1.Name = "fdgvFeld1"
        Me.fdgvFeld1.ReadOnly = True
        '
        'fdgvFeld2
        '
        Me.fdgvFeld2.DataPropertyName = "Feld2"
        Me.fdgvFeld2.HeaderText = "SFDC ID"
        Me.fdgvFeld2.Name = "fdgvFeld2"
        Me.fdgvFeld2.ReadOnly = True
        '
        'RAWBindingSource
        '
        Me.RAWBindingSource.DataMember = "RAW"
        Me.RAWBindingSource.DataSource = Me.MyProjectsDataSet
        '
        'MyProjectsDataSet
        '
        Me.MyProjectsDataSet.DataSetName = "dsMyProjekts"
        Me.MyProjectsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnZeroAll)
        Me.Panel1.Controls.Add(Me.lblPrjList)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(505, 32)
        Me.Panel1.TabIndex = 0
        '
        'btnZeroAll
        '
        Me.btnZeroAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnZeroAll.Location = New System.Drawing.Point(440, 6)
        Me.btnZeroAll.Name = "btnZeroAll"
        Me.btnZeroAll.Size = New System.Drawing.Size(62, 23)
        Me.btnZeroAll.TabIndex = 3
        Me.btnZeroAll.Text = "Zero All"
        Me.btnZeroAll.UseVisualStyleBackColor = True
        '
        'lblPrjList
        '
        Me.lblPrjList.AutoSize = True
        Me.lblPrjList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrjList.ForeColor = System.Drawing.Color.Maroon
        Me.lblPrjList.Location = New System.Drawing.Point(12, 9)
        Me.lblPrjList.Name = "lblPrjList"
        Me.lblPrjList.Size = New System.Drawing.Size(82, 13)
        Me.lblPrjList.TabIndex = 2
        Me.lblPrjList.Text = "You worked :"
        '
        'lblSFDCID
        '
        Me.lblSFDCID.AutoSize = True
        Me.lblSFDCID.Location = New System.Drawing.Point(76, 177)
        Me.lblSFDCID.Name = "lblSFDCID"
        Me.lblSFDCID.Size = New System.Drawing.Size(52, 13)
        Me.lblSFDCID.TabIndex = 72
        Me.lblSFDCID.Text = "SFDC  ID"
        Me.lblSFDCID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmbSfdcID
        '
        Me.cmbSfdcID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSfdcID.DisplayMember = "SfdcID"
        Me.cmbSfdcID.FormattingEnabled = True
        Me.cmbSfdcID.Items.AddRange(New Object() {"n/a (e.g. PreSales int.)"})
        Me.cmbSfdcID.Location = New System.Drawing.Point(266, 174)
        Me.cmbSfdcID.Name = "cmbSfdcID"
        Me.cmbSfdcID.Size = New System.Drawing.Size(130, 21)
        Me.cmbSfdcID.TabIndex = 11
        Me.cmbSfdcID.ValueMember = "SfdcID"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(72, 230)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(56, 13)
        Me.lblDescription.TabIndex = 70
        Me.lblDescription.Text = "What I did"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRTM
        '
        Me.lblRTM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRTM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRTM.Location = New System.Drawing.Point(356, 43)
        Me.lblRTM.Name = "lblRTM"
        Me.lblRTM.Size = New System.Drawing.Size(57, 14)
        Me.lblRTM.TabIndex = 62
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Location = New System.Drawing.Point(414, 64)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 4
        Me.btnReset.Text = "Reset Fields"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFind.Location = New System.Drawing.Point(414, 38)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "Se&arch"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(306, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "* mandatory fields"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(139, 504)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 56
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(399, 506)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 23)
        Me.btnSave.TabIndex = 58
        Me.btnSave.Text = "Save as &New..."
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(276, 504)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(73, 23)
        Me.btnUpdate.TabIndex = 57
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 327)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'edtDescription
        '
        Me.edtDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.edtDescription.Location = New System.Drawing.Point(140, 227)
        Me.edtDescription.Name = "edtDescription"
        Me.edtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.edtDescription.Size = New System.Drawing.Size(350, 274)
        Me.edtDescription.TabIndex = 13
        Me.edtDescription.Text = ""
        '
        'btnZero
        '
        Me.btnZero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnZero.Location = New System.Drawing.Point(411, 145)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(42, 23)
        Me.btnZero.TabIndex = 9
        Me.btnZero.Text = "&Zero"
        Me.btnZero.UseVisualStyleBackColor = True
        '
        'cmbActivity
        '
        Me.cmbActivity.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActivity.FormattingEnabled = True
        Me.cmbActivity.ItemHeight = 13
        Me.cmbActivity.Items.AddRange(New Object() {"<not set>"})
        Me.cmbActivity.Location = New System.Drawing.Point(138, 93)
        Me.cmbActivity.MaxDropDownItems = 20
        Me.cmbActivity.MinimumSize = New System.Drawing.Size(121, 0)
        Me.cmbActivity.Name = "cmbActivity"
        Me.cmbActivity.Size = New System.Drawing.Size(261, 21)
        Me.cmbActivity.TabIndex = 5
        '
        'cmbSalesGroup
        '
        Me.cmbSalesGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbSalesGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSalesGroup.FormattingEnabled = True
        Me.cmbSalesGroup.Items.AddRange(New Object() {"<not set>"})
        Me.cmbSalesGroup.Location = New System.Drawing.Point(138, 66)
        Me.cmbSalesGroup.MaxDropDownItems = 15
        Me.cmbSalesGroup.MinimumSize = New System.Drawing.Size(121, 0)
        Me.cmbSalesGroup.Name = "cmbSalesGroup"
        Me.cmbSalesGroup.Size = New System.Drawing.Size(261, 21)
        Me.cmbSalesGroup.TabIndex = 3
        '
        'cmbStatus
        '
        Me.cmbStatus.DataSource = Me.TypeBindingSource
        Me.cmbStatus.DisplayMember = "Type"
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(139, 174)
        Me.cmbStatus.MinimumSize = New System.Drawing.Size(121, 0)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(121, 21)
        Me.cmbStatus.TabIndex = 10
        Me.cmbStatus.ValueMember = "Type"
        '
        'TypeBindingSource
        '
        Me.TypeBindingSource.DataMember = "Type"
        Me.TypeBindingSource.DataSource = Me.dsLists
        Me.TypeBindingSource.Sort = "Type"
        '
        'dsLists
        '
        Me.dsLists.DataSetName = "ListsDataSet"
        Me.dsLists.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'edtRequestor
        '
        Me.edtRequestor.Location = New System.Drawing.Point(139, 201)
        Me.edtRequestor.MaxLength = 250
        Me.edtRequestor.MinimumSize = New System.Drawing.Size(121, 4)
        Me.edtRequestor.Name = "edtRequestor"
        Me.edtRequestor.Size = New System.Drawing.Size(121, 20)
        Me.edtRequestor.TabIndex = 12
        '
        'cmbTravel
        '
        Me.cmbTravel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTravel.FormattingEnabled = True
        Me.cmbTravel.Items.AddRange(New Object() {"0", "1", "2", "4 (half day)", "8 (full day)"})
        Me.cmbTravel.Location = New System.Drawing.Point(266, 147)
        Me.cmbTravel.Name = "cmbTravel"
        Me.cmbTravel.Size = New System.Drawing.Size(130, 21)
        Me.cmbTravel.TabIndex = 8
        '
        'cmbWorked
        '
        Me.cmbWorked.FormattingEnabled = True
        Me.cmbWorked.Items.AddRange(New Object() {"0", "1", "2", "4 (half day)", "8 (full day)", "16 (two days)", "40 (one week)", "80 (two weeks)"})
        Me.cmbWorked.Location = New System.Drawing.Point(139, 147)
        Me.cmbWorked.Name = "cmbWorked"
        Me.cmbWorked.Size = New System.Drawing.Size(121, 21)
        Me.cmbWorked.TabIndex = 7
        '
        'cmbProduct
        '
        Me.cmbProduct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbProduct.DataSource = Me.ProductsBindingSource
        Me.cmbProduct.DisplayMember = "Products"
        Me.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(139, 120)
        Me.cmbProduct.MaxDropDownItems = 20
        Me.cmbProduct.MinimumSize = New System.Drawing.Size(121, 0)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(260, 21)
        Me.cmbProduct.TabIndex = 6
        Me.cmbProduct.ValueMember = "Products"
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.dsLists
        Me.ProductsBindingSource.Sort = "Products"
        '
        'lblActivity
        '
        Me.lblActivity.AutoSize = True
        Me.lblActivity.ForeColor = System.Drawing.Color.Red
        Me.lblActivity.Location = New System.Drawing.Point(56, 96)
        Me.lblActivity.Name = "lblActivity"
        Me.lblActivity.Size = New System.Drawing.Size(72, 13)
        Me.lblActivity.TabIndex = 44
        Me.lblActivity.Text = "Activity Type*"
        Me.lblActivity.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.ForeColor = System.Drawing.Color.Red
        Me.lblProduct.Location = New System.Drawing.Point(80, 123)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(48, 13)
        Me.lblProduct.TabIndex = 43
        Me.lblProduct.Text = "Product*"
        Me.lblProduct.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSalesGroup
        '
        Me.lblSalesGroup.AutoSize = True
        Me.lblSalesGroup.ForeColor = System.Drawing.Color.Red
        Me.lblSalesGroup.Location = New System.Drawing.Point(59, 69)
        Me.lblSalesGroup.Name = "lblSalesGroup"
        Me.lblSalesGroup.Size = New System.Drawing.Size(69, 13)
        Me.lblSalesGroup.TabIndex = 42
        Me.lblSalesGroup.Text = "Sales Group*"
        Me.lblSalesGroup.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(35, 177)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(48, 13)
        Me.lblStatus.TabIndex = 40
        Me.lblStatus.Text = "Status / "
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblRequestor
        '
        Me.lblRequestor.AutoSize = True
        Me.lblRequestor.Location = New System.Drawing.Point(16, 204)
        Me.lblRequestor.Name = "lblRequestor"
        Me.lblRequestor.Size = New System.Drawing.Size(112, 13)
        Me.lblRequestor.TabIndex = 39
        Me.lblRequestor.Text = "Requestor / MDCP ID"
        Me.lblRequestor.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblWorked_Travel
        '
        Me.lblWorked_Travel.AutoSize = True
        Me.lblWorked_Travel.ForeColor = System.Drawing.Color.Red
        Me.lblWorked_Travel.Location = New System.Drawing.Point(2, 150)
        Me.lblWorked_Travel.Name = "lblWorked_Travel"
        Me.lblWorked_Travel.Size = New System.Drawing.Size(126, 13)
        Me.lblWorked_Travel.TabIndex = 38
        Me.lblWorked_Travel.Text = "Time Worked*/Traveled*"
        Me.lblWorked_Travel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.ForeColor = System.Drawing.Color.Red
        Me.lblCustomer.Location = New System.Drawing.Point(73, 43)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(55, 13)
        Me.lblCustomer.TabIndex = 37
        Me.lblCustomer.Text = "Customer*"
        Me.lblCustomer.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNr
        '
        Me.lblNr.AutoSize = True
        Me.lblNr.Location = New System.Drawing.Point(84, 15)
        Me.lblNr.Name = "lblNr"
        Me.lblNr.Size = New System.Drawing.Size(44, 13)
        Me.lblNr.TabIndex = 36
        Me.lblNr.Text = "Number"
        Me.lblNr.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStartDate.Location = New System.Drawing.Point(139, 201)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpStartDate.TabIndex = 8
        Me.dtpStartDate.Value = New Date(2011, 1, 23, 15, 43, 21, 0)
        '
        'edtCustomer
        '
        Me.edtCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.edtCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtCustomer.Location = New System.Drawing.Point(138, 40)
        Me.edtCustomer.Name = "edtCustomer"
        Me.edtCustomer.Size = New System.Drawing.Size(209, 20)
        Me.edtCustomer.TabIndex = 1
        Me.edtCustomer.Text = "<no customer involved>"
        '
        'edtNr
        '
        Me.edtNr.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.RAWBindingSource, "ID", True))
        Me.edtNr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RAWBindingSource, "ID", True))
        Me.edtNr.Enabled = False
        Me.edtNr.Location = New System.Drawing.Point(138, 12)
        Me.edtNr.Name = "edtNr"
        Me.edtNr.Size = New System.Drawing.Size(50, 20)
        Me.edtNr.TabIndex = 0
        Me.edtNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'edtFeld1
        '
        Me.edtFeld1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.edtFeld1.Location = New System.Drawing.Point(266, 201)
        Me.edtFeld1.Name = "edtFeld1"
        Me.edtFeld1.ReadOnly = True
        Me.edtFeld1.Size = New System.Drawing.Size(130, 20)
        Me.edtFeld1.TabIndex = 65
        Me.edtFeld1.TabStop = False
        '
        'edtFeld2
        '
        Me.edtFeld2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.edtFeld2.Location = New System.Drawing.Point(297, 365)
        Me.edtFeld2.Name = "edtFeld2"
        Me.edtFeld2.Size = New System.Drawing.Size(39, 20)
        Me.edtFeld2.TabIndex = 64
        Me.edtFeld2.TabStop = False
        '
        'edtRTM
        '
        Me.edtRTM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.edtRTM.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.edtRTM.Enabled = False
        Me.edtRTM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtRTM.Location = New System.Drawing.Point(249, 313)
        Me.edtRTM.Name = "edtRTM"
        Me.edtRTM.ShortcutsEnabled = False
        Me.edtRTM.Size = New System.Drawing.Size(87, 20)
        Me.edtRTM.TabIndex = 63
        Me.edtRTM.TabStop = False
        Me.edtRTM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.edtRTM.Visible = False
        Me.edtRTM.WordWrap = False
        '
        'lblActArea
        '
        Me.lblActArea.AutoSize = True
        Me.lblActArea.Location = New System.Drawing.Point(356, 372)
        Me.lblActArea.Name = "lblActArea"
        Me.lblActArea.Size = New System.Drawing.Size(13, 13)
        Me.lblActArea.TabIndex = 66
        Me.lblActArea.Text = "0"
        Me.lblActArea.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.edtYearSend)
        Me.Panel3.Controls.Add(Me.edtPeriodSend)
        Me.Panel3.Controls.Add(Me.btnNowSend)
        Me.Panel3.Controls.Add(Me.btnSend)
        Me.Panel3.Controls.Add(Me.btnRefresh)
        Me.Panel3.Controls.Add(Me.btnSetup)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 537)
        Me.Panel3.MinimumSize = New System.Drawing.Size(400, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1014, 38)
        Me.Panel3.TabIndex = 2
        '
        'edtYearSend
        '
        Me.edtYearSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.edtYearSend.Location = New System.Drawing.Point(870, 10)
        Me.edtYearSend.Maximum = New Decimal(New Integer() {2030, 0, 0, 0})
        Me.edtYearSend.Minimum = New Decimal(New Integer() {2008, 0, 0, 0})
        Me.edtYearSend.Name = "edtYearSend"
        Me.edtYearSend.Size = New System.Drawing.Size(50, 20)
        Me.edtYearSend.TabIndex = 10
        Me.edtYearSend.Value = New Decimal(New Integer() {2012, 0, 0, 0})
        '
        'edtPeriodSend
        '
        Me.edtPeriodSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.edtPeriodSend.Location = New System.Drawing.Point(823, 10)
        Me.edtPeriodSend.Maximum = New Decimal(New Integer() {53, 0, 0, 0})
        Me.edtPeriodSend.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.edtPeriodSend.Name = "edtPeriodSend"
        Me.edtPeriodSend.Size = New System.Drawing.Size(40, 20)
        Me.edtPeriodSend.TabIndex = 9
        Me.edtPeriodSend.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnNowSend
        '
        Me.btnNowSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNowSend.BackColor = System.Drawing.SystemColors.Control
        Me.btnNowSend.Location = New System.Drawing.Point(771, 7)
        Me.btnNowSend.Name = "btnNowSend"
        Me.btnNowSend.Size = New System.Drawing.Size(46, 22)
        Me.btnNowSend.TabIndex = 8
        Me.btnNowSend.Text = "Now"
        Me.btnNowSend.UseVisualStyleBackColor = False
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSend.BackColor = System.Drawing.SystemColors.Control
        Me.btnSend.Location = New System.Drawing.Point(927, 7)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(75, 21)
        Me.btnSend.TabIndex = 11
        Me.btnSend.Text = "&Send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.btnRefresh.Location = New System.Drawing.Point(93, 6)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnSetup
        '
        Me.btnSetup.BackColor = System.Drawing.SystemColors.Control
        Me.btnSetup.Location = New System.Drawing.Point(12, 6)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(75, 23)
        Me.btnSetup.TabIndex = 6
        Me.btnSetup.Text = "S&etup"
        Me.btnSetup.UseVisualStyleBackColor = False
        '
        'RAWTableAdapter
        '
        Me.RAWTableAdapter.ClearBeforeFill = True
        '
        'TypeTableAdapter
        '
        Me.TypeTableAdapter.ClearBeforeFill = True
        '
        'TimeBindingSource
        '
        Me.TimeBindingSource.DataMember = "Time"
        Me.TimeBindingSource.DataSource = Me.dsLists
        Me.TimeBindingSource.Sort = "Time"
        '
        'TimeTableAdapter
        '
        Me.TimeTableAdapter.ClearBeforeFill = True
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'SalesGroupBindingSource
        '
        Me.SalesGroupBindingSource.DataMember = "SalesGroup"
        Me.SalesGroupBindingSource.DataSource = Me.dsLists
        '
        'SalesGroupTableAdapter
        '
        Me.SalesGroupTableAdapter.ClearBeforeFill = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 597)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TC Weekly 4.1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RAWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyProjectsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsLists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.edtYearSend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.edtPeriodSend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MyProjectsDataSet As TC4_2005.dsMyProjekts
    Friend WithEvents RAWBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RAWTableAdapter As TC4_2005.dsMyProjektsTableAdapters.RAWTableAdapter
    Friend WithEvents edtNr As System.Windows.Forms.TextBox
    Friend WithEvents edtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents edtDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents btnZero As System.Windows.Forms.Button
    Friend WithEvents cmbActivity As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSalesGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents edtRequestor As System.Windows.Forms.TextBox
    Friend WithEvents cmbTravel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbWorked As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProduct As System.Windows.Forms.ComboBox
    Friend WithEvents lblActivity As System.Windows.Forms.Label
    Friend WithEvents lblProduct As System.Windows.Forms.Label
    Friend WithEvents lblSalesGroup As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblRequestor As System.Windows.Forms.Label
    Friend WithEvents lblWorked_Travel As System.Windows.Forms.Label
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblNr As System.Windows.Forms.Label
    Friend WithEvents lblRTM As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblPrjList As System.Windows.Forms.Label
    Friend WithEvents edtYearSend As System.Windows.Forms.NumericUpDown
    Friend WithEvents edtPeriodSend As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnNowSend As System.Windows.Forms.Button
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents edtFeld1 As System.Windows.Forms.TextBox
    Friend WithEvents edtFeld2 As System.Windows.Forms.TextBox
    Friend WithEvents edtRTM As System.Windows.Forms.TextBox
    Friend WithEvents lblActArea As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents dsLists As TC4_2005.ListsDataSet
    Friend WithEvents TypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TypeTableAdapter As TC4_2005.ListsDataSetTableAdapters.TypeTableAdapter
    Friend WithEvents TimeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TimeTableAdapter As TC4_2005.ListsDataSetTableAdapters.TimeTableAdapter
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As TC4_2005.ListsDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgvProjects As System.Windows.Forms.DataGridView
    Friend WithEvents SalesGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesGroupTableAdapter As TC4_2005.ListsDataSetTableAdapters.SalesGroupTableAdapter
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblusrLoggedIn As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblLastSent As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnZeroAll As System.Windows.Forms.Button
    Friend WithEvents cmbSfdcID As System.Windows.Forms.ComboBox
    Friend WithEvents lblSFDCID As System.Windows.Forms.Label
    Friend WithEvents fdgvID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fdgvInDirect As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fdgvCustomer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fdgvProduct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fdgvDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fdgvRequestor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fdgvSalesGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fdgvActivities As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fdgvSolutions As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fdgvWorked As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fdgvTravel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fdgvActArea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fdgvCategory As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fdgvRegion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fdgvEnabled As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fdgvFeld1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fdgvFeld2 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
