'Imports Microsoft.Office.Interop
Imports System.Net.Mail

Public Class frmMain
    Public notFind As Boolean = True
    Public MyTest As Boolean = False
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim myError As Boolean
        'TODO: This line of code loads data into the 'dsLists.SalesGroup' table. You can move, or remove it, as needed.
        Me.SalesGroupTableAdapter.Fill(Me.dsLists.SalesGroup)
        'TODO: This line of code loads data into the 'dsLists.Customer' table. You can move, or remove it, as needed.
        'Me.CustomerTableAdapter.Fill(Me.dsLists.Customer)
        'TODO: This line of code loads data into the 'dsLists.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.dsLists.Products)
        'TODO: This line of code loads data into the 'dsLists.Time' table. You can move, or remove it, as needed.
        Me.TimeTableAdapter.Fill(Me.dsLists.Time)
        'TODO: This line of code loads data into the 'dsLists.Type' table. You can move, or remove it, as needed.
        Me.TypeTableAdapter.Fill(Me.dsLists.Type)
        'TODO: This line of code loads data into the 'DsMyProjekts.RAW' table. You can move, or remove it, as needed.
        Me.RAWTableAdapter.Fill(Me.MyProjectsDataSet.RAW)
        'TODO: This line of code loads data into the 'ListsDataSet.SalesGroup' table. You can move, or remove it, as needed.
        Me.SalesGroupTableAdapter.Fill(Me.dsLists.SalesGroup)
        'TODO: This line of code loads data into the 'ListsDataSet.Type' table. You can move, or remove it, as needed.
        Me.TypeTableAdapter.Fill(Me.dsLists.Type)
        'TODO: This line of code loads data into the 'ListsDataSet.Time' table. You can move, or remove it, as needed.
        Me.TimeTableAdapter.Fill(Me.dsLists.Time)
        'TODO: This line of code loads data into the 'ListsDataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me.dsLists.Products)
        'TODO: This line of code loads data into the 'ListsDataSet.Solution' table. You can move, or remove it, as needed.
        'Me.SolutionTableAdapter.Fill(Me.dsLists.Solution)
        'dataSet1.Tables["Customers"].DefaultView.Sort = "Country DESC, City ASC";
        Call LoadSFDCID()
        Me.dgvProjects.Sort(dgvProjects.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        Me.RefreshDGV(0)
        MyProcedures.FillFields4Edit(e)
        Me.lblNr.Visible = False
        Me.edtNr.Visible = False
        MyProcedures.GetUserSettings()
        If frmSetup.edtLoginToken.Text = "" Then
            ' No User Setup so far.
            frmSetup.ShowDialog()
        Else
            myError = MyProcedures.LoadMatrixArray()
            If Not myError Then
                Me.cmbSalesGroup.SelectedIndex = 0
                Me.cmbActivity.SelectedIndex = 0
                Me.cmbProduct.SelectedIndex = 0
                Me.cmbStatus.SelectedIndex = 0
                Me.cmbTravel.SelectedIndex = 0
                Me.cmbWorked.SelectedIndex = 0
                If My.Settings.WeeklyReporting = True Then
                    Me.edtPeriodSend.Maximum = 53
                Else
                    Me.edtPeriodSend.Maximum = 12
                End If
                'If frmSetup.lblRegion.Text = "Germany" Then
                Me.edtDescription.Text = "briefly describe the project status/next steps"
                'End If
                Me.lblLastSent.Text = frmSetup.stplblLastSentDate.Text
                Me.lblusrLoggedIn.Text = frmSetup.edtLoginToken.Text
                Call CheckUpdateList()
            Else
                frmSetup.ShowDialog()
        End If
        Call btnNowSend_Click(sender, e)
        End If
    End Sub
    Private Sub CheckUpdateList()
        Dim LocalFileDate As Date
        Dim NetFileDate As Date
        If frmSetup.edtFilename.Text = "" Then
            MsgBox("The fieldname to be compared with is empty, correct and try again", MsgBoxStyle.Exclamation + vbOKOnly, "No Filename!")
        Else
            LocalFileDate = System.IO.File.GetLastWriteTime("./LISTS.MDB")
            If System.IO.File.Exists(frmSetup.edtFilename.Text) Then
                NetFileDate = System.IO.File.GetLastWriteTime(frmSetup.edtFilename.Text)
                If NetFileDate > LocalFileDate Then
                    MsgBox("The file on " & frmSetup.edtFilename.Text & " is newer than that one you have.  You should update your settings.", MsgBoxStyle.Exclamation + vbOKOnly, "Update required")
                End If
            Else
                MsgBox("Cannot find file: " & frmSetup.edtFilename.Text & "." & Chr(13) & _
                "Either you are not connected to the network or the file has been renamed or deleted.", vbInformation + vbOKOnly, "Update problem")
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        frmAbout.ShowDialog()
    End Sub
    Public Sub RefreshDGV(ByVal tmpRow As Integer)
        Me.MyProjectsDataSet.Clear()
        Me.RAWTableAdapter.Fill(Me.MyProjectsDataSet.RAW)
        If tmpRow < 0 Then tmpRow = 0
        If Me.dgvProjects.RowCount > 0 Then
            lblPrjList.Text = "You worked : " & Str(Me.RAWTableAdapter.qryTotalWorked) & " h and traveled: " & _
               Str(Me.RAWTableAdapter.qryTotalTravel) & " h on " & Str(Me.RAWTableAdapter.qryTotalProjects) & _
              " Projects."
            Me.dgvProjects.Rows(tmpRow).Selected = True
            'Me.dgvProjects.Rows.Item(tmpRow).Selected = True
            'Me.dgvProjects.FirstDisplayedScrollingRowIndex = tmpRow
            Me.dgvProjects.CurrentCell = Me.dgvProjects.Rows(tmpRow).Cells(0)
            Me.lblLastSent.Text = frmSetup.stplblLastSentDate.Text
            Me.lblusrLoggedIn.Text = frmSetup.edtLoginToken.Text
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Dim tmpRow As Integer
        tmpRow = Me.dgvProjects.CurrentRow.Index
        RefreshDGV(tmpRow)
    End Sub

    Private Sub btnNowSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNowSend.Click
        edtYearSend.Text = Year(Today)
        If weekly Then
            edtPeriodSend.Text = Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(Today, Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
        Else
            edtPeriodSend.Text = Month(Today)
        End If
    End Sub

    Private Sub dgvProjects_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If dgvProjects.RowCount > 0 Then
            Me.edtNr.Visible = True
            Me.lblNr.Visible = True
            Call MyProcedures.FillFields4Edit(e)
            Me.btnUpdate.Enabled = True
        End If
    End Sub

    Private Sub btnSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetup.Click
        frmSetup.ShowDialog()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Call MyProcedures.ResetFields()
        Call btnNowSend_Click(sender, e)
        Me.btnUpdate.Enabled = False
    End Sub

    Private Sub cmbSalesGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSalesGroup.SelectedIndexChanged
        FillActivity()
        Me.cmbActivity.Text = MyProcedures.notset ' "<not set>"
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        frmFind.CustomerToolStripTextBox.Text = ""
        FirstSearch = True
        frmFind.ShowDialog()
        MyProcedures.ColorStatus()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim tmpRow As Integer
        tmpRow = dgvProjects.CurrentRow.Index
        If Check4Save() Then
            Try
                'Me.RAWTableAdapter.Update(edtDescription.Text, edtCustomer.Text, cmbProduct.Text, edtRequestor.Text, cmbSalesGroup.Text, cmbActivity.Text, _
                '                          "<not set>", Val(cmbTravel.Text), lblActArea.Text, cmbStatus.Text, frmSetup.lblRegion.Text, 0, edtFeld1.Text, _
                '                          edtFeld2.Text, Val(cmbWorked.Text), edtRTM.Text, edtYear.Value, edtPeriod.Value, edtNr.Text)

                Me.RAWTableAdapter.Update( _
                        Me.edtDescription.Text, _
                        Me.edtCustomer.Text, _
                        Me.cmbProduct.Text, _
                        Val(Me.cmbWorked.Text), _
                        Val(Me.cmbTravel.Text), _
                        Me.edtRequestor.Text, _
                        Me.cmbSalesGroup.Text, _
                        Me.cmbActivity.Text, _
                        "<not set>", _
                        Val(Me.lblActArea.Text), _
                        Me.cmbStatus.Text, _
                        frmSetup.lblRegion.Text, _
                        0, _
                        Me.edtFeld1.Text, _
                        Me.cmbSfdcID.Text, _
                        Me.edtRTM.Text, _
                        0, 0, _
                        Me.edtNr.Text)
            Catch
                MsgBox("There was an error while updateing the project. Try again!", MsgBoxStyle.Critical + vbOKOnly, "Error")
            End Try
            RefreshDGV(tmpRow)
            MyProcedures.FillFields4Edit(e)
            Me.dgvProjects.Select()
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim tmpRow As Integer
        If Me.dgvProjects.RowCount > 0 Then
            tmpRow = dgvProjects.CurrentRow.Index
            If Me.edtNr.Text > "" Then
                If MsgBox("Really delete Project:" & vbCrLf & vbCrLf & "ID: " & Me.edtNr.Text & vbCrLf & vbCrLf & _
                    "Customer: " & Me.edtCustomer.Text & vbCrLf & vbCrLf & _
                    "Description: " & Me.edtDescription.Text, _
                    vbQuestion + vbOKCancel, "Delete Project") = MsgBoxResult.Ok Then
                    Try
                        Me.RAWTableAdapter.Delete(Me.edtNr.Text)
                    Catch
                        MsgBox("There was an error while inserting the new project. Try again!", MsgBoxStyle.Critical + vbOKOnly, "Error")
                    End Try
                End If
                Select Case Me.dgvProjects.RowCount
                    Case 0
                        Me.btnUpdate.Enabled = False
                    Case 1
                        RefreshDGV(0)
                        ResetFields()
                        Me.btnUpdate.Enabled = False
                    Case Else
                        If tmpRow >= Me.dgvProjects.RowCount - 1 Then
                            tmpRow = Me.dgvProjects.RowCount - 2
                        End If
                        RefreshDGV(tmpRow)
                        MyProcedures.FillFields4Edit(e)
                End Select
            Else
                MsgBox("Select a project to be delete first.", vbInformation + vbOKOnly, "Error Deleting")
            End If
        Else
            MsgBox("Nothing to delete.", vbInformation + vbOKOnly, "No Projects")
        End If
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        If Me.edtPeriodSend.Text = "" Or Me.edtYearSend.Text = "" Then
            MsgBox("Missing information for sending this projects (Period/Year)", MsgBoxStyle.Exclamation + vbOKOnly, "Error")
        Else
            If (Val(Me.RAWTableAdapter.qryTotalWorked) = 0) Then
                MsgBox("Sorry, but there are no projects with worked time." & ChrW(13) & _
                "Sending process was aborted.", vbExclamation + vbOKOnly, "Error")
            Else
                ' Send the mail with the content to receipiant.
                If MsgBox("Really send the data for " & Trim(Str(edtPeriodSend.Value)) & " / " & _
                       Trim(Str(edtYearSend.Value)) & " to: " & frmSetup.edtMailTo.Text & vbCrLf & vbCrLf & _
                       "Click ok to send and cancel to abort send process.", _
                       MsgBoxStyle.Information + vbOKCancel, "Really Send the Projects...") = MsgBoxResult.Ok Then
                    frmSetup.stplblLastSentDate.Text = Today
                    Me.lblLastSent.Text = frmSetup.stplblLastSentDate.Text
                    My.Settings.LastSent = CDate(frmSetup.stplblLastSentDate.Text)
                    My.Settings.Save()
                    SendeMail2()
                Else
                    MsgBox("Send process was aborted.", MsgBoxStyle.Information + vbOKOnly, "Sending aborted")
                End If
            End If
        End If
    End Sub
    Public Sub SendeMail2()
        Dim MSO As New Microsoft.Office.Interop.Outlook.Application
        Dim msg As Microsoft.Office.Interop.Outlook.MailItem
        Dim isWeekly As String
        If weekly Then
            isWeekly = "Week "
        Else
            isWeekly = "Month "
        End If
        Try
            'Compose the Message
            msg = MSO.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)
            msg.Subject = "~4Weekly~~ " & isWeekly & Me.edtPeriodSend.Value & "/" & Me.edtYearSend.Value & " (" & _
                        frmSetup.lblCountry.Text & ") " & frmSetup.edtLoginToken.Text
            msg.To = frmSetup.edtMailTo.Text
            msg.CC = frmSetup.edtMailToCC.Text
            '*******************************
            'If you have SendOnBehalf permissions, you can specify a SOB user
            'msg.SentOnBehalfOfName = "Some Other User"
            'Create an HTML formatted body
            Dim body As String
            body = MyProcedures.CollectBody
            'Set the body format and contents
            msg.BodyFormat = Microsoft.Office.Interop.Outlook.OlBodyFormat.olFormatHTML
            msg.HTMLBody = body
            'display the message for the user to hit send on OR....
            'msg.Display()
            'send the message
            msg.Send()
            MsgBox("Mail for " & Me.edtPeriodSend.Value & "/" & Me.edtYearSend.Value & " was successfully send to : " & _
                   frmSetup.edtMailTo.Text & ".", vbInformation + vbOKOnly, "Mail Sent")
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("Error sending the mail: " + vbCrLf + ex.Message, "Error")

        End Try
    End Sub
    ''' <summary>
    ''' Will send the weekly to the receipiants
    ''' They are set in the Settings, which are filled automatically.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SendeMail()
        Dim olApp As Object
        Dim oItem As Object
        Dim isWeekly As String
        If weekly Then
            isWeekly = "Week "
        Else
            isWeekly = "Month "
        End If
        'On Error GoTo NoOutlook
        Try
            'olApp = CreateObject("Outlook.Application")
            'On Error GoTo 0
            'Try
            '    olApp = CType(GetObject(, "Outlook.Application"), Microsoft.Office.Interop.Outlook.Application)
            'Catch ex As Exception
            '    olApp = CType(CreateObject("Outlook.Application"), Microsoft.Office.Interop.Outlook.Application)
            'End Try
            Try
                olApp = GetObject(, "Outlook.Application")
            Catch
                olApp = CreateObject("Outlook.Application")
                'olApp = GetObject(, "Outlook.Application")
            End Try
            oItem = olApp.CreateItem(0)
            With oItem
                .Subject = "~4Weekly~~ " & isWeekly & Me.edtPeriodSend.Value & "/" & Me.edtYearSend.Value & " (" & _
                    frmSetup.lblCountry.Text & ") " & frmSetup.edtLoginToken.Text
                .To = frmSetup.edtMailTo.Text
                .CC = frmSetup.edtMailToCC.Text
                .Body = MyProcedures.CollectBody()
                If MyTest Then
                    .display()
                Else
                    .Send()
                End If
            End With
            MsgBox("Mail for " & Me.edtPeriodSend.Value & "/" & Me.edtYearSend.Value & " was successfully send to : " & _
                   frmSetup.edtMailTo.Text & ".", vbInformation + vbOKOnly, "Mail Sent")
            'Catch ex As Exception
            '   System.Windows.Forms.MessageBox.Show("Error sending the mail: " + vbCrLf + ex.Message, "Error")
            'NoOutlook:
            '            MsgBox("Outlook seems not to be started on your machine." & Chr(13) & _
            '                    "Process stopped.", vbExclamation + vbOKOnly, "Error")
            '            Return
        Finally
        End Try
            olApp = Nothing
            oItem = Nothing
            Return
    End Sub
    Public Sub SendMyeMail()
        Dim olApp As Object
        Dim oItem As Object
        Dim isWeekly As String
        If weekly Then
            isWeekly = "Week "
        Else
            isWeekly = "Month "
        End If
        On Error GoTo NoOutlook
        'olApp = GetObject(, "Outlook.Application")
        On Error GoTo 0
        olApp = CreateObject("Outlook.Application")
        oItem = olApp.CreateItem(0)
        With oItem
            'Mail Subject:  "~aWeekly~~ Week 35/2007 (EU) jdo"
            .Subject = "~4Weekly~~ " & isWeekly & Me.edtPeriodSend.Value & "/" & Me.edtYearSend.Value & " (" & _
                frmSetup.lblCountry.Text & ") " & frmSetup.edtLoginToken.Text
            .To = frmSetup.edtMailTo.Text
            .CC = frmSetup.edtMailToCC.Text
            .Body = CollectBody()
            '.Send()
            .Display()
        End With
        MsgBox("Mail for " & Me.edtPeriodSend.Value & "/" & Me.edtYearSend.Value & " was successfully send to : " & _
               frmSetup.edtMailTo.Text & ".", vbInformation + vbOKOnly, "Mail Sent")
        Return
NoOutlook:
        MsgBox("Outlook seems not to be started on your machine." & Chr(13) & _
                "Process stopped.", vbExclamation + vbOKOnly, "Error")
        Return
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Check4Save() Then
            Try
                Me.RAWTableAdapter.Insert( _
                Me.edtDescription.Text, _
                Me.edtCustomer.Text, _
                Me.cmbProduct.Text, _
                Me.edtRequestor.Text, _
                Me.cmbSalesGroup.Text, _
                Me.cmbActivity.Text, _
                "<not set>", _
                Val(Me.cmbTravel.Text), _
                Me.cmbStatus.Text, _
                frmSetup.lblRegion.Text, _
                0, _
                Me.edtFeld1.Text, _
                Me.cmbSfdcID.Text, _
                Val(Me.cmbWorked.Text), _
                Me.edtRTM.Text, _
                0, _
                0, _
                Val(Me.lblActArea.Text))
            Catch
                MsgBox("There was an error while inserting the new project. Try again!", MsgBoxStyle.Critical + vbOKOnly, "Error")
            End Try
            RefreshDGV(Me.dgvProjects.RowCount)
            MyProcedures.FillFields4Edit(e)
            Me.dgvProjects.Select()
        End If
    End Sub

    Private Sub cmbTravel_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTravel.Leave
        If Val(Me.cmbTravel.Text) > Val(Me.cmbWorked.Text) Then
            MsgBox("You traveled more than you worked for this project." & ChrW(13) & _
            "Please check your input.", vbInformation + vbOKOnly, "Hint")
        End If
    End Sub

    Private Sub cmbWorked_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbWorked.Leave
        If Val(Me.cmbTravel.Text) > Val(Me.cmbWorked.Text) Then
            MsgBox("You traveled more than you worked for this project." & ChrW(13) & _
            "Please check your input.", vbInformation + vbOKOnly, "Hint")
        End If
        '        If InStr(cmbWorked.Text, ",") > 0 Then
        ' cmbWorked.Text.Replace(",", ".")
        'End If
    End Sub

    Private Sub SplitContainer1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles SplitContainer1.DoubleClick
        Me.SplitContainer1.SplitterDistance = Me.Width \ 2
    End Sub
    Private Sub dgvProjects_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvProjects.Click
        If dgvProjects.RowCount > 0 Then
            Me.lblNr.Visible = True
            Me.edtNr.Visible = True
            Call MyProcedures.FillFields4Edit(e)
            Me.btnUpdate.Enabled = True
        End If
    End Sub

    Private Sub btnZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZero.Click
        Me.cmbTravel.Text = 0
        Me.cmbWorked.Text = 0
    End Sub
    Private Sub FindCustomer()
        Dim tmpCustomer As String
        Dim tmpField1 As String
        Dim tmpField2 As String
        Dim tmpRTM As String
        tmpCustomer = frmFind.CustomerTableAdapter.GetCustomerName(edtCustomer.Text)
        tmpField1 = frmFind.CustomerTableAdapter.GetCustomerFeld1(edtCustomer.Text)
        tmpField2 = frmFind.CustomerTableAdapter.GetCustomerFeld2(edtCustomer.Text)
        tmpRTM = frmFind.CustomerTableAdapter.GetCustomerRTM(edtCustomer.Text)

        If Not IsNothing(tmpCustomer) Then
            edtCustomer.Text = tmpCustomer
        Else
            edtCustomer.Text = "not clearly identified customer !!!"
        End If

        If Not IsNothing(tmpField1) Then
            edtFeld1.Text = tmpField1
        Else
            edtFeld1.Text = ""
        End If

        If Not IsNothing(tmpField2) Then
            edtFeld2.Text = tmpField2
        Else
            edtFeld2.Text = ""
        End If

        If Not IsNothing(tmpRTM) Then
            edtRTM.Text = tmpRTM
        Else
            edtRTM.Text = "undefined"
        End If
        lblRTM.Text = edtRTM.Text
    End Sub
    Private Sub edtCustomer_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles edtCustomer.Leave
        frmFind.CustomerToolStripTextBox.Text = Me.edtCustomer.Text
        frmFind.SearchCustomer()
        Select Case frmFind.dsCustomer.Customer.Count
            Case 0
                notFind = True
                MsgBox("No customer found with that name." & Chr(13) & "Will switch to manual entered customer.", vbInformation + vbOKOnly, "Customer Search")
            Case 1
                notFind = False
                FindCustomer()
            Case Else
                notFind = True
                MsgBox("There were more customers found with the entered string." & Chr(13) & _
                        "Search again or accept as manual entered customer.", vbInformation + vbOKOnly, "Problem...")
        End Select
        'MsgBox(frmFind.DsCustomer.Customer.Count)
        'frmFind.Show()
        If notFind Then
            Me.edtRTM.Text = MyProcedures.txtManual ' "manual"
            Me.lblRTM.Text = MyProcedures.txtManual
        End If
        Call MyProcedures.ColorStatus()
    End Sub

    Private Sub btnZeroAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZeroAll.Click
        Dim answer As Integer
        answer = MsgBox("Set all projects to zero time?", vbQuestion + vbYesNo, "Confirm")
        If answer = vbYes Then
            Try
                Me.RAWTableAdapter.ZeroAll()
            Catch ex As Exception
                MsgBox("Error resetting all projects to zero.", vbExclamation + vbOKOnly, "Error")
            End Try
            RefreshDGV(0)
        End If
    End Sub

    Private Sub dgvProjects_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvProjects.SelectionChanged
        If dgvProjects.RowCount > 0 Then
            Me.lblNr.Visible = True
            Me.edtNr.Visible = True
            Call MyProcedures.FillFields4Edit(e)
            Me.btnUpdate.Enabled = True
        End If
    End Sub

    Private Sub cmbTravel_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbTravel.Validating
        If InStr(cmbTravel.Text, ",") > 0 Then
            cmbTravel.Text = cmbTravel.Text.Replace(",", ".")
        End If
    End Sub

    Private Sub cmbWorked_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbWorked.Validating
        If InStr(cmbWorked.Text, ",") > 0 Then
            cmbWorked.Text = cmbWorked.Text.Replace(",", ".")
        End If
    End Sub


    Private Sub edtCustomer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edtCustomer.TextChanged
        Me.edtFeld1.Text = ""
    End Sub

End Class
