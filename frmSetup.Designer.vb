<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetup
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
        Me.lblWrongUser = New System.Windows.Forms.GroupBox
        Me.btnCheckSetting = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblReporting0 = New System.Windows.Forms.Label
        Me.lblReporting = New System.Windows.Forms.Label
        Me.lblCountry0 = New System.Windows.Forms.Label
        Me.lblCountry = New System.Windows.Forms.Label
        Me.lblRegion = New System.Windows.Forms.Label
        Me.lblRegion0 = New System.Windows.Forms.Label
        Me.lblUserName = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.btnCopyList = New System.Windows.Forms.Button
        Me.edtFilename = New System.Windows.Forms.TextBox
        Me.btnGetUser = New System.Windows.Forms.Button
        Me.lblLogin = New System.Windows.Forms.Label
        Me.btnLocateList = New System.Windows.Forms.Button
        Me.edtLoginToken = New System.Windows.Forms.TextBox
        Me.lblListLocation = New System.Windows.Forms.Label
        Me.lblMailCC = New System.Windows.Forms.Label
        Me.StpfrmSetup = New System.Windows.Forms.StatusStrip
        Me.stplblLastSent = New System.Windows.Forms.ToolStripStatusLabel
        Me.stplblLastSentDate = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblMailTo = New System.Windows.Forms.Label
        Me.chkAutoPercent = New System.Windows.Forms.CheckBox
        Me.edtMailTo = New System.Windows.Forms.TextBox
        Me.edtMailToCC = New System.Windows.Forms.TextBox
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnImport = New System.Windows.Forms.Button
        Me.grpMailBox = New System.Windows.Forms.GroupBox
        Me.openDLGFindMDB = New System.Windows.Forms.OpenFileDialog
        Me.TCGEOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblWrongUser.SuspendLayout()
        Me.StpfrmSetup.SuspendLayout()
        Me.grpMailBox.SuspendLayout()
        CType(Me.TCGEOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWrongUser
        '
        Me.lblWrongUser.Controls.Add(Me.btnCheckSetting)
        Me.lblWrongUser.Controls.Add(Me.Label1)
        Me.lblWrongUser.Controls.Add(Me.lblReporting0)
        Me.lblWrongUser.Controls.Add(Me.lblReporting)
        Me.lblWrongUser.Controls.Add(Me.lblCountry0)
        Me.lblWrongUser.Controls.Add(Me.lblCountry)
        Me.lblWrongUser.Controls.Add(Me.lblRegion)
        Me.lblWrongUser.Controls.Add(Me.lblRegion0)
        Me.lblWrongUser.Controls.Add(Me.lblUserName)
        Me.lblWrongUser.Controls.Add(Me.lblUser)
        Me.lblWrongUser.Controls.Add(Me.btnCopyList)
        Me.lblWrongUser.Controls.Add(Me.edtFilename)
        Me.lblWrongUser.Controls.Add(Me.btnGetUser)
        Me.lblWrongUser.Controls.Add(Me.lblLogin)
        Me.lblWrongUser.Controls.Add(Me.btnLocateList)
        Me.lblWrongUser.Controls.Add(Me.edtLoginToken)
        Me.lblWrongUser.Controls.Add(Me.lblListLocation)
        Me.lblWrongUser.Location = New System.Drawing.Point(15, 7)
        Me.lblWrongUser.Name = "lblWrongUser"
        Me.lblWrongUser.Size = New System.Drawing.Size(572, 152)
        Me.lblWrongUser.TabIndex = 16
        Me.lblWrongUser.TabStop = False
        Me.lblWrongUser.Text = " User Settings "
        '
        'btnCheckSetting
        '
        Me.btnCheckSetting.Location = New System.Drawing.Point(327, 24)
        Me.btnCheckSetting.Name = "btnCheckSetting"
        Me.btnCheckSetting.Size = New System.Drawing.Size(108, 23)
        Me.btnCheckSetting.TabIndex = 19
        Me.btnCheckSetting.Text = "&2. Check Settings"
        Me.btnCheckSetting.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(286, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 39)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "If any data is not correct please contact Thomas Wichert."
        '
        'lblReporting0
        '
        Me.lblReporting0.AutoSize = True
        Me.lblReporting0.Location = New System.Drawing.Point(6, 124)
        Me.lblReporting0.Name = "lblReporting0"
        Me.lblReporting0.Size = New System.Drawing.Size(53, 13)
        Me.lblReporting0.TabIndex = 17
        Me.lblReporting0.Text = "Reporting"
        '
        'lblReporting
        '
        Me.lblReporting.AutoSize = True
        Me.lblReporting.Location = New System.Drawing.Point(78, 124)
        Me.lblReporting.Name = "lblReporting"
        Me.lblReporting.Size = New System.Drawing.Size(48, 13)
        Me.lblReporting.TabIndex = 16
        Me.lblReporting.Text = "<period>"
        '
        'lblCountry0
        '
        Me.lblCountry0.Location = New System.Drawing.Point(6, 111)
        Me.lblCountry0.Name = "lblCountry0"
        Me.lblCountry0.Size = New System.Drawing.Size(46, 13)
        Me.lblCountry0.TabIndex = 15
        Me.lblCountry0.Text = "Country:"
        '
        'lblCountry
        '
        Me.lblCountry.Location = New System.Drawing.Point(78, 111)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(86, 13)
        Me.lblCountry.TabIndex = 14
        Me.lblCountry.Text = "<country>"
        '
        'lblRegion
        '
        Me.lblRegion.AutoSize = True
        Me.lblRegion.Location = New System.Drawing.Point(78, 98)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(48, 13)
        Me.lblRegion.TabIndex = 13
        Me.lblRegion.Text = "<region>"
        '
        'lblRegion0
        '
        Me.lblRegion0.AutoSize = True
        Me.lblRegion0.Location = New System.Drawing.Point(6, 98)
        Me.lblRegion0.Name = "lblRegion0"
        Me.lblRegion0.Size = New System.Drawing.Size(44, 13)
        Me.lblRegion0.TabIndex = 12
        Me.lblRegion0.Text = "Region:"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(78, 85)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(65, 13)
        Me.lblUserName.TabIndex = 11
        Me.lblUserName.Text = "<username>"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(6, 85)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(61, 13)
        Me.lblUser.TabIndex = 10
        Me.lblUser.Text = "User name:"
        '
        'btnCopyList
        '
        Me.btnCopyList.Location = New System.Drawing.Point(441, 24)
        Me.btnCopyList.Name = "btnCopyList"
        Me.btnCopyList.Size = New System.Drawing.Size(116, 23)
        Me.btnCopyList.TabIndex = 9
        Me.btnCopyList.Text = "&3. Get new Settings"
        Me.btnCopyList.UseVisualStyleBackColor = True
        '
        'edtFilename
        '
        Me.edtFilename.Location = New System.Drawing.Point(81, 52)
        Me.edtFilename.Name = "edtFilename"
        Me.edtFilename.Size = New System.Drawing.Size(442, 20)
        Me.edtFilename.TabIndex = 2
        '
        'btnGetUser
        '
        Me.btnGetUser.Location = New System.Drawing.Point(162, 24)
        Me.btnGetUser.Name = "btnGetUser"
        Me.btnGetUser.Size = New System.Drawing.Size(119, 23)
        Me.btnGetUser.TabIndex = 7
        Me.btnGetUser.Text = "&1. Update Settings"
        Me.btnGetUser.UseVisualStyleBackColor = True
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Location = New System.Drawing.Point(8, 29)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(67, 13)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Login Token"
        '
        'btnLocateList
        '
        Me.btnLocateList.Location = New System.Drawing.Point(529, 50)
        Me.btnLocateList.Name = "btnLocateList"
        Me.btnLocateList.Size = New System.Drawing.Size(28, 23)
        Me.btnLocateList.TabIndex = 6
        Me.btnLocateList.Text = "..."
        Me.btnLocateList.UseVisualStyleBackColor = True
        '
        'edtLoginToken
        '
        Me.edtLoginToken.Enabled = False
        Me.edtLoginToken.Location = New System.Drawing.Point(81, 26)
        Me.edtLoginToken.Name = "edtLoginToken"
        Me.edtLoginToken.Size = New System.Drawing.Size(75, 20)
        Me.edtLoginToken.TabIndex = 1
        '
        'lblListLocation
        '
        Me.lblListLocation.AutoSize = True
        Me.lblListLocation.Location = New System.Drawing.Point(8, 55)
        Me.lblListLocation.Name = "lblListLocation"
        Me.lblListLocation.Size = New System.Drawing.Size(67, 13)
        Me.lblListLocation.TabIndex = 3
        Me.lblListLocation.Text = "List Location"
        '
        'lblMailCC
        '
        Me.lblMailCC.AutoSize = True
        Me.lblMailCC.Location = New System.Drawing.Point(19, 55)
        Me.lblMailCC.Name = "lblMailCC"
        Me.lblMailCC.Size = New System.Drawing.Size(45, 13)
        Me.lblMailCC.TabIndex = 1
        Me.lblMailCC.Text = "mail CC:"
        '
        'StpfrmSetup
        '
        Me.StpfrmSetup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stplblLastSent, Me.stplblLastSentDate})
        Me.StpfrmSetup.Location = New System.Drawing.Point(0, 283)
        Me.StpfrmSetup.Name = "StpfrmSetup"
        Me.StpfrmSetup.Size = New System.Drawing.Size(604, 22)
        Me.StpfrmSetup.SizingGrip = False
        Me.StpfrmSetup.Stretch = False
        Me.StpfrmSetup.TabIndex = 17
        Me.StpfrmSetup.Text = "StatusStrip1"
        '
        'stplblLastSent
        '
        Me.stplblLastSent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.stplblLastSent.Name = "stplblLastSent"
        Me.stplblLastSent.Size = New System.Drawing.Size(145, 17)
        Me.stplblLastSent.Text = "Last Weekly was sent on:"
        '
        'stplblLastSentDate
        '
        Me.stplblLastSentDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.stplblLastSentDate.ForeColor = System.Drawing.Color.Blue
        Me.stplblLastSentDate.Name = "stplblLastSentDate"
        Me.stplblLastSentDate.Size = New System.Drawing.Size(69, 17)
        Me.stplblLastSentDate.Text = "01.01.2011"
        '
        'lblMailTo
        '
        Me.lblMailTo.AutoSize = True
        Me.lblMailTo.Location = New System.Drawing.Point(25, 29)
        Me.lblMailTo.Name = "lblMailTo"
        Me.lblMailTo.Size = New System.Drawing.Size(40, 13)
        Me.lblMailTo.TabIndex = 0
        Me.lblMailTo.Text = "mail to:"
        '
        'chkAutoPercent
        '
        Me.chkAutoPercent.AutoSize = True
        Me.chkAutoPercent.Location = New System.Drawing.Point(15, 165)
        Me.chkAutoPercent.Name = "chkAutoPercent"
        Me.chkAutoPercent.Size = New System.Drawing.Size(223, 17)
        Me.chkAutoPercent.TabIndex = 18
        Me.chkAutoPercent.Text = "Add %-sign automatically when searching."
        Me.chkAutoPercent.UseVisualStyleBackColor = True
        '
        'edtMailTo
        '
        Me.edtMailTo.Location = New System.Drawing.Point(70, 26)
        Me.edtMailTo.Name = "edtMailTo"
        Me.edtMailTo.Size = New System.Drawing.Size(415, 20)
        Me.edtMailTo.TabIndex = 2
        '
        'edtMailToCC
        '
        Me.edtMailToCC.Location = New System.Drawing.Point(70, 52)
        Me.edtMailToCC.Name = "edtMailToCC"
        Me.edtMailToCC.Size = New System.Drawing.Size(415, 20)
        Me.edtMailToCC.TabIndex = 3
        '
        'btnOk
        '
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOk.Location = New System.Drawing.Point(515, 240)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 14
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(515, 214)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 13
        Me.btnImport.Text = "&Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'grpMailBox
        '
        Me.grpMailBox.Controls.Add(Me.edtMailToCC)
        Me.grpMailBox.Controls.Add(Me.edtMailTo)
        Me.grpMailBox.Controls.Add(Me.lblMailCC)
        Me.grpMailBox.Controls.Add(Me.lblMailTo)
        Me.grpMailBox.Location = New System.Drawing.Point(15, 190)
        Me.grpMailBox.Name = "grpMailBox"
        Me.grpMailBox.Size = New System.Drawing.Size(491, 84)
        Me.grpMailBox.TabIndex = 15
        Me.grpMailBox.TabStop = False
        Me.grpMailBox.Text = " Mail Settings "
        '
        'openDLGFindMDB
        '
        Me.openDLGFindMDB.DefaultExt = "MDB"
        Me.openDLGFindMDB.FileName = "*"
        Me.openDLGFindMDB.Filter = "Access-Dateien (*.mdb)|*.mdb"
        Me.openDLGFindMDB.InitialDirectory = "."
        Me.openDLGFindMDB.Title = "Locate LIST.MDB"
        '
        'TCGEOBindingSource
        '
        Me.TCGEOBindingSource.DataMember = "TC_GEO"
        '
        'frmSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnOk
        Me.ClientSize = New System.Drawing.Size(604, 305)
        Me.Controls.Add(Me.lblWrongUser)
        Me.Controls.Add(Me.StpfrmSetup)
        Me.Controls.Add(Me.chkAutoPercent)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.grpMailBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetup"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TC Weekly Setup"
        Me.lblWrongUser.ResumeLayout(False)
        Me.lblWrongUser.PerformLayout()
        Me.StpfrmSetup.ResumeLayout(False)
        Me.StpfrmSetup.PerformLayout()
        Me.grpMailBox.ResumeLayout(False)
        Me.grpMailBox.PerformLayout()
        CType(Me.TCGEOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWrongUser As System.Windows.Forms.GroupBox
    Friend WithEvents btnCheckSetting As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblReporting0 As System.Windows.Forms.Label
    Friend WithEvents lblReporting As System.Windows.Forms.Label
    Friend WithEvents lblCountry0 As System.Windows.Forms.Label
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents lblRegion As System.Windows.Forms.Label
    Friend WithEvents lblRegion0 As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents btnCopyList As System.Windows.Forms.Button
    Friend WithEvents edtFilename As System.Windows.Forms.TextBox
    Friend WithEvents btnGetUser As System.Windows.Forms.Button
    Friend WithEvents lblLogin As System.Windows.Forms.Label
    Friend WithEvents btnLocateList As System.Windows.Forms.Button
    Friend WithEvents edtLoginToken As System.Windows.Forms.TextBox
    Friend WithEvents lblListLocation As System.Windows.Forms.Label
    Friend WithEvents lblMailCC As System.Windows.Forms.Label
    Friend WithEvents StpfrmSetup As System.Windows.Forms.StatusStrip
    Friend WithEvents stplblLastSent As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stplblLastSentDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblMailTo As System.Windows.Forms.Label
    Friend WithEvents TCGEOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents chkAutoPercent As System.Windows.Forms.CheckBox
    Friend WithEvents edtMailTo As System.Windows.Forms.TextBox
    Friend WithEvents edtMailToCC As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents grpMailBox As System.Windows.Forms.GroupBox
    Friend WithEvents openDLGFindMDB As System.Windows.Forms.OpenFileDialog
End Class
