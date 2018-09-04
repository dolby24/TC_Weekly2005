<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImport
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
        Me.btnView = New System.Windows.Forms.Button
        Me.dlgSearchXLS = New System.Windows.Forms.OpenFileDialog
        Me.btnClose = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.btnImport = New System.Windows.Forms.Button
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.edtXLSFile = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnView.Location = New System.Drawing.Point(386, 37)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 14
        Me.btnView.Text = "&1. View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'dlgSearchXLS
        '
        Me.dlgSearchXLS.DefaultExt = "xls"
        Me.dlgSearchXLS.FileName = "TC Weekly Access"
        Me.dlgSearchXLS.Filter = "Excel files (*.xls*)|*.xls*|All files (*.*)|*.*"
        Me.dlgSearchXLS.InitialDirectory = "."
        Me.dlgSearchXLS.Title = "Search for the TC Excel File"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnClose.Location = New System.Drawing.Point(548, 37)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "&3. Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(611, 242)
        Me.DataGridView1.TabIndex = 12
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImport.Location = New System.Drawing.Point(467, 37)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 11
        Me.btnImport.Text = "&2. Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBrowse.Location = New System.Drawing.Point(595, 9)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(28, 23)
        Me.btnBrowse.TabIndex = 9
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'edtXLSFile
        '
        Me.edtXLSFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.edtXLSFile.Location = New System.Drawing.Point(12, 12)
        Me.edtXLSFile.Name = "edtXLSFile"
        Me.edtXLSFile.Size = New System.Drawing.Size(577, 20)
        Me.edtXLSFile.TabIndex = 8
        '
        'frmImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(639, 320)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.edtXLSFile)
        Me.MinimizeBox = False
        Me.Name = "frmImport"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import old Data from Excel Sheet"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents dlgSearchXLS As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents edtXLSFile As System.Windows.Forms.TextBox
End Class
