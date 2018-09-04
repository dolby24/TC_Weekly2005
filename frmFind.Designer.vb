<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFind
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFind))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.QryCustomerToolStrip = New System.Windows.Forms.ToolStrip
        Me.CustomerToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.CustomerToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.QryCustomerToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.btnResetFilter = New System.Windows.Forms.ToolStripButton
        Me.dgvCustomer = New System.Windows.Forms.DataGridView
        Me.CustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RTMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Feld1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Feld2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsCustomer = New TC4_2005.ListsDataSet
        Me.CustomerTableAdapter = New TC4_2005.ListsDataSetTableAdapters.CustomerTableAdapter
        Me.btnClose = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.StatusStrip1.SuspendLayout()
        Me.QryCustomerToolStrip.SuspendLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 365)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(653, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(347, 17)
        Me.ToolStripStatusLabel1.Text = "Doubleclick entry to accept changes.  Hit red X to close Window."
        '
        'QryCustomerToolStrip
        '
        Me.QryCustomerToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripLabel, Me.CustomerToolStripTextBox, Me.QryCustomerToolStripButton, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.btnResetFilter, Me.ToolStripSeparator2, Me.btnClose})
        Me.QryCustomerToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.QryCustomerToolStrip.Name = "QryCustomerToolStrip"
        Me.QryCustomerToolStrip.Size = New System.Drawing.Size(653, 25)
        Me.QryCustomerToolStrip.TabIndex = 1
        Me.QryCustomerToolStrip.Text = "ToolStrip1"
        '
        'CustomerToolStripLabel
        '
        Me.CustomerToolStripLabel.Name = "CustomerToolStripLabel"
        Me.CustomerToolStripLabel.Size = New System.Drawing.Size(62, 22)
        Me.CustomerToolStripLabel.Text = "Customer:"
        '
        'CustomerToolStripTextBox
        '
        Me.CustomerToolStripTextBox.Name = "CustomerToolStripTextBox"
        Me.CustomerToolStripTextBox.Size = New System.Drawing.Size(250, 25)
        Me.CustomerToolStripTextBox.ToolTipText = "Example:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """%hewlett%"" will find ""A Hewlett Packard Company""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """hewlett% will find " & _
            "only ""Hewlett Packard...."""
        '
        'QryCustomerToolStripButton
        '
        Me.QryCustomerToolStripButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.QryCustomerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.QryCustomerToolStripButton.Image = CType(resources.GetObject("QryCustomerToolStripButton.Image"), System.Drawing.Image)
        Me.QryCustomerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.QryCustomerToolStripButton.Name = "QryCustomerToolStripButton"
        Me.QryCustomerToolStripButton.Padding = New System.Windows.Forms.Padding(1)
        Me.QryCustomerToolStripButton.Size = New System.Drawing.Size(36, 22)
        Me.QryCustomerToolStripButton.Text = "&Find"
        Me.QryCustomerToolStripButton.ToolTipText = "Find the customer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripLabel1.Text = "(Use % as wildcard.)"
        '
        'btnResetFilter
        '
        Me.btnResetFilter.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnResetFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnResetFilter.Image = CType(resources.GetObject("btnResetFilter.Image"), System.Drawing.Image)
        Me.btnResetFilter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnResetFilter.Name = "btnResetFilter"
        Me.btnResetFilter.Size = New System.Drawing.Size(68, 22)
        Me.btnResetFilter.Text = "Reset Filter"
        '
        'dgvCustomer
        '
        Me.dgvCustomer.AllowUserToAddRows = False
        Me.dgvCustomer.AllowUserToDeleteRows = False
        Me.dgvCustomer.AllowUserToOrderColumns = True
        Me.dgvCustomer.AutoGenerateColumns = False
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerDataGridViewTextBoxColumn, Me.RTMDataGridViewTextBoxColumn, Me.Feld1DataGridViewTextBoxColumn, Me.Feld2DataGridViewTextBoxColumn})
        Me.dgvCustomer.DataSource = Me.CustomerBindingSource
        Me.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCustomer.Location = New System.Drawing.Point(0, 25)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.ReadOnly = True
        Me.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomer.Size = New System.Drawing.Size(653, 340)
        Me.dgvCustomer.TabIndex = 2
        '
        'CustomerDataGridViewTextBoxColumn
        '
        Me.CustomerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CustomerDataGridViewTextBoxColumn.DataPropertyName = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.HeaderText = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.Name = "CustomerDataGridViewTextBoxColumn"
        Me.CustomerDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerDataGridViewTextBoxColumn.Width = 76
        '
        'RTMDataGridViewTextBoxColumn
        '
        Me.RTMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RTMDataGridViewTextBoxColumn.DataPropertyName = "RTM"
        Me.RTMDataGridViewTextBoxColumn.HeaderText = "RTM"
        Me.RTMDataGridViewTextBoxColumn.Name = "RTMDataGridViewTextBoxColumn"
        Me.RTMDataGridViewTextBoxColumn.ReadOnly = True
        Me.RTMDataGridViewTextBoxColumn.Width = 56
        '
        'Feld1DataGridViewTextBoxColumn
        '
        Me.Feld1DataGridViewTextBoxColumn.DataPropertyName = "Feld1"
        Me.Feld1DataGridViewTextBoxColumn.HeaderText = "Feld1"
        Me.Feld1DataGridViewTextBoxColumn.Name = "Feld1DataGridViewTextBoxColumn"
        Me.Feld1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Feld2DataGridViewTextBoxColumn
        '
        Me.Feld2DataGridViewTextBoxColumn.DataPropertyName = "Feld2"
        Me.Feld2DataGridViewTextBoxColumn.HeaderText = "Feld2"
        Me.Feld2DataGridViewTextBoxColumn.Name = "Feld2DataGridViewTextBoxColumn"
        Me.Feld2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.dsCustomer
        Me.CustomerBindingSource.Sort = "Customer"
        '
        'dsCustomer
        '
        Me.dsCustomer.DataSetName = "dsCustomer"
        Me.dsCustomer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 22)
        Me.btnClose.Text = "&Close"
        Me.btnClose.ToolTipText = "Close Window"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'frmFind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 387)
        Me.Controls.Add(Me.dgvCustomer)
        Me.Controls.Add(Me.QryCustomerToolStrip)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "frmFind"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Customer"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.QryCustomerToolStrip.ResumeLayout(False)
        Me.QryCustomerToolStrip.PerformLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents QryCustomerToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CustomerToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CustomerToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents QryCustomerToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents btnResetFilter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dgvCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As TC4_2005.ListsDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents dsCustomer As TC4_2005.ListsDataSet
    Friend WithEvents CustomerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RTMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Feld2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
End Class
