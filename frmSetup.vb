Imports System.IO
Public Class frmSetup

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If edtFilename.Text = "" Or edtMailTo.Text = "" Then
            MsgBox("List Location and/or MailTo cannot be empty!", MsgBoxStyle.Exclamation + vbOKOnly, "Error")
        Else
            My.Settings.LoginName = edtLoginToken.Text
            My.Settings.ListLocation = edtFilename.Text
            My.Settings.MailTo = edtMailTo.Text
            My.Settings.MailToCC = edtMailToCC.Text
            My.Settings.Username = lblUserName.Text
            If lblReporting.Text = "weekly" Then
                My.Settings.WeeklyReporting = True
            Else
                My.Settings.WeeklyReporting = False
            End If
            MyProcedures.weekly = My.Settings.WeeklyReporting
            My.Settings.Region = lblRegion.Text
            My.Settings.Country = lblCountry.Text
            If Me.stplblLastSentDate.Text <> "01.01.2011" Then
                My.Settings.LastSent = CDate(stplblLastSentDate.Text)
            End If
            My.Settings.AutoPercent = chkAutoPercent.Checked
            My.Settings.LastSent = stplblLastSentDate.Text
            My.Settings.Save()
            Me.Hide()
        End If
    End Sub

    Private Sub btnLocateList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocateList.Click
        Me.openDLGFindMDB.Filter = "Alle Dateien (*.*)|*.*"
        Me.openDLGFindMDB.FilterIndex = 1
        If openDLGFindMDB.ShowDialog() = Windows.Forms.DialogResult.OK Then
            edtFilename.Text = openDLGFindMDB.FileName
        End If
    End Sub

    Public Sub btnGetUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetUser.Click
        Dim rName As String = My.User.Name
        Dim lSlash As Integer = rName.LastIndexOf("\")
        Dim fName As String = rName.Substring(lSlash + 1)
        edtLoginToken.Text = fName
        ' Username picked, now get the settings
        'Call GetUserSettings()
        MyProcedures.FillDatafromGrid()
    End Sub

    Private Sub btnCopyList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopyList.Click
        Dim ProgPath As String
        ProgPath = Application.StartupPath & "\LISTS.MDB"
        If UCase(edtFilename.Text) = UCase(ProgPath) Then
            MsgBox("Setup is wrong!" & Chr(13) & Chr(13) & _
                "The program path and the location of the update LIST.MDB is the same." & Chr(13) & _
                "You need to correct the path for the location and get the new settings again.", vbCritical + vbOKOnly, "Critical Error")
        Else
            If System.IO.File.Exists(edtFilename.Text) = True Then
                frmUpdate.Show()
            Else
                ' File does not exist.
                MsgBox("Sorry, file " & edtFilename.Text & " not found.", MsgBoxStyle.Exclamation + vbOKOnly, "Error")
            End If
        End If
    End Sub

    Private Sub btnCheckSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckSetting.Click
        Dim LocalFileDate As Date
        Dim NetFileDate As Date
        If Me.edtFilename.Text = "" Then
            MsgBox("The fieldname to be compared with is empty, correct and try again", MsgBoxStyle.Exclamation + vbOKOnly, "No Filename!")
        Else
            If System.IO.File.Exists(Me.edtFilename.Text) Then
                LocalFileDate = System.IO.File.GetLastWriteTime("./LISTS.MDB")
                NetFileDate = System.IO.File.GetLastWriteTime(Me.edtFilename.Text)
                If NetFileDate > LocalFileDate Then
                    MsgBox("The file on " & Me.edtFilename.Text & " is newer than that one you have.  You should update your settings.", MsgBoxStyle.Exclamation + vbOKOnly, "Update required")
                Else
                    MsgBox("Your local file for the settings is up to date.", MsgBoxStyle.Information + vbOKOnly, "No Update Action required")
                End If
            Else
                MsgBox("Cannot find file: " & Me.edtFilename.Text & "." & Chr(13) & _
                "Either you are not connected to the network or the file has been renamed or deleted.", vbInformation + vbOKOnly, "Update problem")

            End If
        End If
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        frmImport.ShowDialog()
    End Sub
    '
    ' Gets the logged in user from the system
    '
    Private Sub GetUserSettings()
        Try
            'Me.TC_GEOTableAdapter.FillBy(Me.DsTC_Geo.TC_GEO, edtUsername.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub PropertyGrid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim userAttr As New System.Configuration.UserScopedSettingAttribute
        Dim attrs As New System.ComponentModel.AttributeCollection(userAttr)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Settings.Reset()
        My.Settings.Save()
    End Sub
End Class