Imports System.Data.OleDb

Module MyProcedures
    Const noCustomer = "<no customer involved>"
    Const repWeekly = "weekly"
    Const repMonthly = "monthly"

    Public weekly As Boolean
    Public MakeSFDCIDMandatory As Boolean
    Public aMatrix(150, 150) As String 'holds the matrix itself
    Public sMatrix(150) As String ' holds the fieldname of the matrix
    Public txtDirect As String = "Direct"
    Public txtIndirect As String = "Indirect"
    Public txtManual As String = "Manual"
    Public notset As String = "<not set>"
    Public FirstSearch As Boolean = True
    Public MyUserID As String = "Admin"
    Public MyPassword As String = "lupo"

    ' ------ tmpVariables ---
    Public myID As Integer
    Public myDescription As String
    Public myCustomer As String
    Public myProduct As String
    Public myWorked As Integer
    Public myTravel As Integer
    Public myRequestor As String
    Public mySalesGroup As String
    Public myActivities As String
    Public mySolutions As String
    Public myActArea As Integer
    Public myCategory As String
    Public myRegion As String
    Public myEnabled As Boolean
    Public myFeld1 As String
    Public myFeld2 As String
    Public myInDirect As String
    Public myforYear As Integer
    Public myforPeriod As Integer

    ''' <summary>
    ''' Get the Settings stored in MY Area
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub GetUserSettings()
        'frmSetup.lblusrname.Text = frmSetup.dgvTCUser.Item(0, 0).Value
        frmSetup.edtFilename.Text = My.Settings.ListLocation
        frmSetup.edtLoginToken.Text = My.Settings.LoginName
        frmSetup.lblUserName.Text = My.Settings.Username
        frmSetup.edtMailTo.Text = My.Settings.MailTo
        frmSetup.edtMailToCC.Text = My.Settings.MailToCC
        frmSetup.lblRegion.Text = My.Settings.Region
        frmSetup.lblCountry.Text = My.Settings.Country
        frmSetup.stplblLastSentDate.Text = My.Settings.LastSent
        weekly = My.Settings.WeeklyReporting
        If weekly Then
            frmSetup.lblReporting.Text = repWeekly
        Else
            frmSetup.lblReporting.Text = repMonthly
        End If
        frmSetup.chkAutoPercent.Checked = My.Settings.AutoPercent
    End Sub
    ''' <summary>
    ''' Set the variables in MY Area
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SetUserSettings()
        'frmSetup.lblusrname.Text = frmSetup.dgvTCUser.Item(1, 1).Value
        'My.Settings.ListLocation = frmSetup.edtFilename.Text
        'My.Settings.Username = frmSetup.edtUsername.Text
        'My.Settings.MailTo = frmSetup.dgvTCUser.Item(1, 6).Value
        'My.Settings.MailToCC = frmSetup.dgvTCUser.Item(1, 7).Value
        'My.Settings.WeeklyReporting = frmSetup.dgvTCUser.Item(1, 3).Value
    End Sub
    Public Sub LoadSFDCID()
        Dim myConn As New System.Data.OleDb.OleDbConnection
        Dim myCommand As New System.Data.OleDb.OleDbCommand
        Dim myDataAdapter As New System.Data.OleDb.OleDbDataAdapter
        Dim myDataSet As New System.Data.DataSet
        Dim maxRows As Integer
        Dim counter As Integer
        Try
            myConn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\LISTS.MDB;User ID=Admin;Jet OLEDB:Database Password=" & MyPassword & ";Mode=Read;Persist Security Info=True;"
            'myConn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Ole DB Services=-4; Data Source=.\LISTS.MDB;User ID=Admin;Password=lupo;"
            myCommand.CommandText = "SELECT * FROM SFDCID"
            myCommand.Connection = myConn
            myDataAdapter.SelectCommand = myCommand
            Dim myDataRow As System.Data.DataRow
            myDataAdapter.Fill(myDataSet)
            myDataRow = myDataSet.Tables(0).Rows(0)     ' Initialize Rows

            maxRows = myDataRow.Table.Rows.Count
            If maxRows > 1 Then
                frmMain.lblSFDCID.ForeColor = Color.Red
                MakeSFDCIDMandatory = True
                frmMain.cmbSfdcID.Items.Clear()
                For counter = 0 To maxRows - 1
                    myDataRow = myDataSet.Tables(0).Rows(counter)
                    frmMain.cmbSfdcID.Items.Add(myDataRow("SFDCID").ToString)
                Next
            Else
                frmMain.lblSFDCID.ForeColor = Color.Black
                MakeSFDCIDMandatory = False
                frmMain.cmbSfdcID.Items.Clear()
                frmMain.cmbSfdcID.Items.Add("n/a (e.g. Presales int.)")
            End If
            'MsgBox("Filled aMatrix and sMatrix")
            'frmMain.cmbActivity.Items.Add(myDataSet.Tables(0).Rows(Counter))
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("Error getting data from Query [SFDCID]: " + ex.Message, "Error")
            frmMain.cmbSalesGroup.Items.Add("<not set>")
        End Try
        FillSalesGroup(maxRows)
    End Sub
    ''' <summary>
    ''' Load the Matrix and fill the DropDown with the Activities
    ''' </summary>
    ''' <remarks></remarks>
    Public Function LoadMatrixArray()
        Dim myConn As New System.Data.OleDb.OleDbConnection
        Dim myCommand As New System.Data.OleDb.OleDbCommand
        Dim myDataAdapter As New System.Data.OleDb.OleDbDataAdapter
        Dim myDataSet As New System.Data.DataSet
        Dim myDataRow As System.Data.DataRow
        Dim myDataCol As DataColumn 'System.Data.DataColumn
        Dim maxFields As Integer
        Dim maxRows As Integer
        Dim rowCounter As Integer
        Dim fieldCounter As Integer
        If frmSetup.edtLoginToken.Text > "" Then
            Try
                myConn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\LISTS.MDB;User ID=Admin;Jet OLEDB:Database Password=" & MyPassword & ";Mode=Read;Persist Security Info=True;"
                'myConn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Ole DB Services=-4; Data Source=.\LISTS.MDB;User ID=Admin;Password=lupo;"
                myCommand.CommandText = "SELECT * FROM MATRIX WHERE [Valid for Region]='" & frmSetup.lblRegion.Text & "'"
                myCommand.Connection = myConn
                myDataAdapter.SelectCommand = myCommand
                myDataAdapter.Fill(myDataSet)

                myDataRow = myDataSet.Tables(0).Rows(0)     ' Initialize Rows
                myDataCol = myDataSet.Tables(0).Columns(0)  ' Initalize Columns

                maxFields = myDataRow.Table.Columns.Count
                maxRows = myDataRow.Table.Rows.Count
                ReDim aMatrix(maxRows + 1, maxFields + 1)
                ReDim sMatrix(maxFields + 1)
                fieldCounter = 0
                For Each myDataCol In myDataSet.Tables(0).Columns
                    ' fill sMatrix with the columnames
                    sMatrix(fieldCounter) = myDataCol.ColumnName 'myDataCol(fieldCounter).Caption.ToString
                    fieldCounter += 1
                Next
                For rowCounter = 0 To maxRows - 1
                    myDataRow = myDataSet.Tables(0).Rows(rowCounter)
                    For fieldCounter = 0 To maxFields - 1
                        If IsDBNull(myDataRow(fieldCounter).ToString) Then
                            aMatrix(rowCounter, fieldCounter) = ""
                        Else
                            aMatrix(rowCounter, fieldCounter) = myDataRow(fieldCounter).ToString
                        End If
                    Next
                Next
                'MsgBox("Filled aMatrix and sMatrix")
                'frmMain.cmbActivity.Items.Add(myDataSet.Tables(0).Rows(Counter))
            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show("Error getting data from Query [MATRIX]: " + ex.Message, "Error")
                frmMain.cmbSalesGroup.Items.Add("<not set>")
                Return (True)
            End Try
            FillSalesGroup(maxRows)
            Return (False)
        End If
        Return (True)
    End Function
    ''' <summary>
    ''' Fills the SalesGroup dropdown with the correct value
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub FillSalesGroup(ByVal maxCounter As Integer)
        Dim counter As Integer
        If frmSetup.edtLoginToken.Text > "" Then
            frmMain.cmbSalesGroup.Items.Clear()
            For counter = 0 To maxCounter - 1
                frmMain.cmbSalesGroup.Items.Add(aMatrix(counter, 2))
            Next
            FillActivity()
        End If
    End Sub

    ''' <summary>
    ''' Fills the Activity drop down with the allowed values depending on the values of the Sales Group
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub FillActivity()
        Dim counter As Integer
        Dim index As Integer
        frmMain.cmbActivity.Items.Clear()
        index = frmMain.cmbSalesGroup.SelectedIndex
        If index < 0 Then index = 0
        For counter = 3 To sMatrix.Length - 1
            If aMatrix(index, counter) = "x" Then
                frmMain.cmbActivity.Items.Add(sMatrix(counter))
            End If
        Next
        counter = frmMain.cmbSalesGroup.SelectedIndex
        If (counter < 0) Or (counter > aMatrix.GetLength(0)) Then
            counter = 0
        End If
        frmMain.lblActArea.Text = aMatrix(counter, 1)
    End Sub

    ''' <summary>
    ''' Get's the data from LISTS.mdb and fills the data in the Settings
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub FillDatafromGrid()
        Dim myConn As New System.Data.OleDb.OleDbConnection
        Dim myCommand As New System.Data.OleDb.OleDbCommand
        Dim myDataAdapter As New System.Data.OleDb.OleDbDataAdapter
        Dim myDataSet As New System.Data.DataSet
        Dim myDataRow As System.Data.DataRow
        Try
            myConn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\LISTS.MDB;User ID=Admin;Jet OLEDB:Database Password=" + MyPassword + ";Mode=Read;Persist Security Info=True;"
            'myConn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Ole DB Services=-4;Data Source=.\LISTS.MDB;User ID=Admin;Password=lupo;"
            myCommand.CommandText = "SELECT * FROM TC_GEO WHERE alias = '" & frmSetup.edtLoginToken.Text & "';"
            myCommand.Connection = myConn
            myDataAdapter.SelectCommand = myCommand
            myDataAdapter.Fill(myDataSet)
            myDataRow = myDataSet.Tables(0).Rows(0)
            'System.Windows.Forms.MessageBox.Show(myDataRow("alias").ToString)
            frmSetup.lblUserName.Text = myDataRow("Name").ToString
            frmSetup.lblRegion.Text = myDataRow("Region").ToString
            frmSetup.lblCountry.Text = myDataRow("Country").ToString
            frmSetup.edtMailTo.Text = myDataRow("Reporting To").ToString
            frmSetup.edtMailToCC.Text = myDataRow("ReportingCC").ToString
            frmSetup.lblReporting.Text = myDataRow("Periode").ToString
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("Error getting data from Query [TC_GEO]: " + ex.Message, "Error")
        End Try

    End Sub
    ''' <summary>
    ''' Colors the flag of InDirect
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ColorStatus()
        Select Case UCase(frmMain.edtRTM.Text)
            Case UCase(txtDirect)      ' "direct"
                frmMain.edtRTM.ForeColor = Color.Blue
                frmMain.lblRTM.ForeColor = Color.Blue
            Case UCase(txtIndirect)    ' "indirect"
                frmMain.edtRTM.ForeColor = Color.Black
                frmMain.lblRTM.ForeColor = Color.Black
            Case Else
                frmMain.edtRTM.ForeColor = Color.Red
                frmMain.lblRTM.ForeColor = Color.Red
        End Select
    End Sub
    Public Function CollectBody() As String
        Dim strBody As String
        Dim iRow As Integer
        Dim vbKeyF16 As Char = Chr(127)
        Dim vbTmpF12 As Char = Chr(15)
        Dim testStr As String
        strBody = ""
        For iRow = 0 To frmMain.dgvProjects.Rows.Count - 1
            'For Each DataRow In frmMain.dgvProjects.Rows
            If CheckNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvWorked").Value, False) > 0 Then
                strBody += CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvDescription").Value, True) & vbKeyF16 '1
                strBody += CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvCustomer").Value, True) & vbKeyF16  '2
                strBody += CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvID").Value, True) & vbKeyF16    '3
                strBody += CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvProduct").Value, True) & vbKeyF16   '4
                strBody += CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvWorked").Value, False) & vbKeyF16   '5
                strBody += CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvRequestor").Value, True) & vbKeyF16 '6
                strBody += CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvSalesGroup").Value, True) & vbKeyF16    '7
                strBody += CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvActivities").Value, True) & vbKeyF16    '8
                'strBody += CheckNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvSolutions").Value, True) & vbKeyF16
                strBody += "<not set>" & vbKeyF16 ' instead of the solution, which is not used anymore '9
                strBody += CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvTravel").Value, False) & vbKeyF16   '10
                Select Case UCase(CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvInDirect").Value, True))
                    Case "DIRECT"
                        strBody += "0" & vbKeyF16   '11
                    Case "INDIRECT"
                        strBody += "1" & vbKeyF16   '11
                    Case "UNDEFINED"
                        strBody += "2" & vbKeyF16   '11
                    Case "MANUAL"
                        strBody += "99" & vbKeyF16  '11
                    Case Else
                        strBody += "2" & vbKeyF16   '11
                End Select
                strBody += CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvCategory").Value, True) & vbKeyF16  '12
                strBody += frmSetup.lblRegion.Text & vbKeyF16 ' 13
                'strBody += CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvRegion").Value, True) & vbKeyF16    '13
                strBody += CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvActArea").Value, False) & vbKeyF16  '14
                testStr = CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvInDirect").Value, True) '15
                Select Case UCase(testStr)
                    Case "DIRECT"
                        strBody += "1" & vbKeyF16
                    Case "INDIRECT"
                        strBody += "0" & vbKeyF16
                    Case "UNDEFINED"
                        strBody += "99" & vbKeyF16
                    Case "MANUAL"
                        strBody += "0" & vbKeyF16
                    Case Else
                        strBody += "99" & vbKeyF16
                End Select
                'strBody += CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvInDirect").Value, True) & vbKeyF16  '15
                strBody += " 0" & vbKeyF16  ' 16
                strBody += CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvFeld1").Value, True) & vbKeyF16 '17
                strBody += CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("fdgvFeld2").Value, True) & vbKeyF16 '18
                'strBody += CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("").Value, True) & vbKeyF16
                'strBody += CheckSNull(frmMain.dgvProjects.Rows(iRow).Cells("").Value, True) & vbKeyF16
                strBody += LCase(frmSetup.edtLoginToken.Text) & vbKeyF16 & frmSetup.lblCountry.Text & vbTmpF12 & vbTmpF12
            End If
        Next
        strBody = strBody.Replace(ChrW(13), " ") ' No character is allowed in the bodytext
        strBody = strBody.Replace(ChrW(10), " ")
        strBody = strBody.Replace(vbTmpF12, "</p>") ' Replace tmp Character with Return as delimiter
        Return (strBody)
        ' Order of export:
        ' Description, Customer, Nr, Product, Time, Requestor, Sales(Group), Activities
        ' Solutions, Travel, Money, Category, Region, ActArea, Direct, Enabled, Feld1, Feld2
        ' Add: LCase(loginUser) & Chr(vbKeyF16) & frmConfig.txtCountry & Chr(vbKeyReturn) ' User from Settings
    End Function

    Public Function Check4Save() As Boolean
        Dim Ready2Save As Boolean
        Ready2Save = False
        Ready2Save = (frmMain.cmbActivity.SelectedIndex > 0) _
            And (frmMain.cmbProduct.SelectedIndex > 0) _
            And (frmMain.cmbSalesGroup.SelectedIndex > 0) _
            And (frmMain.edtCustomer.TextLength > 0)
        If MakeSFDCIDMandatory Then
            Ready2Save = Ready2Save And (frmMain.cmbSfdcID.Text > "")
        End If
        If Not Ready2Save Then
            MsgBox("There are some mandatory field not filles correctly.  Redo your input and try again.", MsgBoxStyle.Exclamation + vbOKOnly, "Save/Update aborted")
        End If
        Return (Ready2Save)
    End Function

    Public Sub FillFields4Edit(ByVal e As System.EventArgs)
        Dim test As Integer
        'frmMain.edtNr.Text = CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvID").Value, False)
        frmMain.edtDescription.Text = CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvDescription").Value, True)
        frmMain.edtCustomer.Text = CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvCustomer").Value, True)
        frmMain.cmbProduct.Text = CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvProduct").Value, True)
        frmMain.cmbWorked.Text = ChangeTime(CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvWorked").Value, False))
        frmMain.cmbTravel.Text = ChangeTime(CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvTravel").Value, False))
        frmMain.edtRequestor.Text = CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvRequestor").Value, True)
        frmMain.cmbSalesGroup.Text = CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvSalesGroup").Value, True)
        frmMain.cmbActivity.Text = CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvActivities").Value, True)
        frmMain.lblActArea.Text = Str(CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvActArea").Value, False))
        'mySolutions = frmMain.dgvProjects.CurrentRow.Cells("fdgvSolution").Value
        myActArea = Str(CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvActArea").Value, False))
        test = frmMain.lblActArea.Text
        test = CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvActArea").Value, False)
        myCategory = CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvCategory").Value, True)
        frmMain.cmbStatus.Text = CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvCategory").Value, True)
        myRegion = CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvRegion").Value, True)
        myEnabled = CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvEnabled").Value, False)

        frmMain.edtFeld1.Text = CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvFeld1").Value, True)
        'frmMain.edtFeld2.Text = CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvFeld2").Value, True)
        frmMain.edtRTM.Text = CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvInDirect").Value, True)
        frmMain.lblRTM.Text = frmMain.edtRTM.Text
        frmMain.cmbSfdcID.Text = CheckNull(frmMain.dgvProjects.CurrentRow.Cells("fdgvFeld2").Value, True)
        ColorStatus()
    End Sub
    Public Function ChangeTime(ByVal Value As Double) As String
        Select Case Value
            Case 0
                Return ("0")
            Case 1
                Return ("1")
            Case 2
                Return ("2")
            Case 4
                Return ("4 (half day)")
            Case 8
                Return ("8 (full day)")
            Case 16
                Return ("16 (two days)")
            Case 40
                Return ("40 (1 week)")
            Case 80
                Return ("80 (2 week)")
            Case Else
                Return (Str(Value))
        End Select
    End Function
    Public Function CheckNull(ByVal value As Object, ByVal isString As Boolean)
        If IsDBNull(value) Then
            If isString Then
                Return ("")
            Else
                Return (0)
            End If
        Else
            Return (value)
        End If
    End Function
    Public Function CheckSNull(ByVal value As Object, ByVal isString As Boolean) As String
        If Not isString Then
            Return (Str(CheckNull(value, isString)))
        Else
            Return (CheckNull(value, isString))
        End If
    End Function
    Public Sub ResetFields()
        'frmMain.edtNr.Text = ""                 ' [ID]
        'If frmSetup.lblRegion.Text = "Germany" Then
        frmMain.edtDescription.Text = "briefly describe the project status/next steps"
        'Else
        'frmMain.edtDescription.Text = ""        ' [Description]
        'End If
        frmMain.edtCustomer.Text = noCustomer   ' [Customer]
        'frmMain.cmbProduct.Text = "<not set>"   ' [Product]
        frmMain.cmbProduct.SelectedIndex = 0    ' [Product]
        frmMain.cmbWorked.Text = 0              ' [Worked]
        frmMain.cmbTravel.Text = 0              ' [Travel]
        frmMain.edtRequestor.Text = ""          ' [Requestor]
        frmMain.cmbSalesGroup.SelectedIndex = 0 ' [Sales Group]
        frmMain.cmbActivity.SelectedIndex = 0   ' [Activities]
        ' [Solutions]
        frmMain.lblActArea.Text = 0             ' [ActArea]
        frmMain.cmbStatus.Text = "<not specified>"    ' [Category]
        ' [Region]
        ' [Enabled]
        frmMain.edtFeld1.Text = ""              ' [Feld1]
        'frmMain.edtFeld2.Text = ""              ' [Feld2]
        frmMain.cmbSfdcID.Text = ""             ' [SFDCID] formerly Feld2
        frmMain.edtRTM.Text = ""                ' [InDirect]
        frmMain.lblRTM.Text = ""
        frmMain.lblActArea.Text = "0"
        frmMain.lblNr.Visible = False
        frmMain.edtNr.Visible = False
    End Sub

    Public Sub UpdateProjects()
        'Dim myConn As New System.Data.OleDb.OleDbConnection
        Dim myCommand As New System.Data.OleDb.OleDbCommand
        Dim myDataAdapter As New System.Data.OleDb.OleDbDataAdapter
        Dim myDataSet As New System.Data.DataSet
        'Dim myDataRow As System.Data.DataRow
        Dim myConn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Ole DB Services=-4; Data Source=.\MyProjects.MDB")
        Try
            myConn.Open()
            myCommand = New OleDb.OleDbCommand()
            myCommand.Connection = myConn

            'myCommand.CommandType = CommandType.Text
            'myConn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Ole DB Services=-4; Data Source=./MyProjects.MDB"
            'myConn.Open()
            'myDataSet.Clear()

            myDataAdapter.SelectCommand.Parameters("ID").Value = frmMain.edtNr.Text
            myDataAdapter.SelectCommand.Parameters("Description").Value = frmMain.edtDescription.Text
            myDataAdapter.SelectCommand.Parameters("Customer").Value = frmMain.edtCustomer.Text
            myDataAdapter.SelectCommand.Parameters("Product").Value = frmMain.cmbProduct.Text
            myDataAdapter.SelectCommand.Parameters("Worked").Value = Val(Left(frmMain.cmbWorked.Text, 2))
            myDataAdapter.SelectCommand.Parameters("Travel").Value = Val(Left(frmMain.cmbTravel.Text, 2))
            myDataAdapter.SelectCommand.Parameters("Requestor").Value = frmMain.edtRequestor.Text
            myDataAdapter.SelectCommand.Parameters("SalesGroup").Value = frmMain.cmbSalesGroup.Text
            myDataAdapter.SelectCommand.Parameters("Activities").Value = frmMain.cmbActivity.Text
            myDataAdapter.SelectCommand.Parameters("Solutions").Value = notset
            myDataAdapter.SelectCommand.Parameters("ActArea").Value = Val(frmMain.lblActArea.Text)
            myDataAdapter.SelectCommand.Parameters("Category").Value = frmMain.cmbStatus.Text
            myDataAdapter.SelectCommand.Parameters("Region").Value = frmSetup.lblRegion.Text
            myDataAdapter.SelectCommand.Parameters("Enabled").Value = 0
            myDataAdapter.SelectCommand.Parameters("Feld1").Value = frmMain.edtFeld1.Text
            myDataAdapter.SelectCommand.Parameters("Feld2").Value = frmMain.cmbSfdcID.Text
            myDataAdapter.SelectCommand.Parameters("InDirect").Value = frmMain.edtRTM.Text
            myCommand.CommandText = "UPDATE (RAW) SET " & vbCrLf & _
                "Decription=@description, " & vbCrLf & _
                "Customer=@customer, " & vbCrLf & _
                "Product=@product, " & vbCrLf & _
                "Worked=@worked, " & vbCrLf & _
                "Travel=@Travel, " & vbCrLf & _
                "Requestor=@Requestor, " & vbCrLf & _
                "[Sales Group]=@Salesgroup, " & vbCrLf & _
                "[Activities]=@Activities, " & vbCrLf & _
                "[Solutions]=@Solutions, " & vbCrLf & _
                "[ActArea]=@ActArea, " & vbCrLf & _
                "[Category]=@Category, " & vbCrLf & _
                "[Region]=@Region, " & vbCrLf & _
                "[Enabled]=@enabled, " & vbCrLf & _
                "[Feld1]=@Feld1, " & vbCrLf & _
                "[Feld2]=@Feld2, " & vbCrLf & _
                "[InDirect]=@InDirect, " & vbCrLf & _
                "[forYear]=@forYear" & vbCrLf & _
                "[forPeriod]=@forPeriod, " & vbCrLf & _
                "WHERE (ID = @ID)"

            '"ID =" & Val(frmMain.edtNr.Text) & ", " & _

            myCommand.Connection = myConn

            myDataAdapter.SelectCommand = myCommand
            'myDataAdapter.UpdateCommand = myCommand
            myDataAdapter.Fill(myDataSet)
            'myDataAdapter.Update(myDataSet)
            myConn.Close()
            'myDataRow = myDataSet.Tables(0).Rows(0)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("Error updating your project: " + Chr(13) + ex.Message, "Error")
        Finally
            myConn.Close()
        End Try

    End Sub

    Public Function newLeft(ByVal sText As String, ByVal nLen As Integer) As String
        If nLen > sText.Length Then nLen = sText.Length
        Return (sText.Substring(0, nLen))
    End Function
    Public Function newRight(ByVal sText As String, ByVal nLen As Integer) As String
        If nLen > sText.Length Then nLen = sText.Length
        Return (sText.Substring(sText.Length - nLen))
    End Function
End Module
