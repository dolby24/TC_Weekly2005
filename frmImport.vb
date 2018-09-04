
Public Class frmImport

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If edtXLSFile.Text > "" Then
            ViewImport()
        Else
            MsgBox("You need to enter a filename to import.", vbExclamation + vbOKOnly, "Error")
        End If
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        If edtXLSFile.Text > "" Then
            RXLSLine()
        Else
            MsgBox("You need to enter a filename to import.", vbExclamation + vbOKOnly, "Error")
        End If
    End Sub
    Private Sub ReadExcelLine()
        Dim strConnection As System.Data.OleDb.OleDbConnection
        Dim myPath As String = edtXLSFile.Text

        Try
            Dim objDataSet As System.Data.DataSet
            Dim objAdapter As System.Data.OleDb.OleDbDataAdapter

            strConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source='" & _
                                                                  myPath & " '; " & "Extended Properties=Excel 12.0;")
            objAdapter = New System.Data.OleDb.OleDbDataAdapter("select * from [RAW$]", strConnection)
            objDataSet = New System.Data.DataSet
            objAdapter.Fill(objDataSet, "Customers")
            DataGridView1.DataSource = objDataSet.Tables(0).DefaultView
            strConnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Importing")
        End Try
    End Sub
    Private Sub ViewImport()
        Dim pathname As String = edtXLSFile.Text
        Dim dsdaun As System.Data.DataSet
        Dim connect As System.Data.OleDb.OleDbConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & pathname & ";Extended Properties=""Excel 12.0;HDR=Yes"";")
        Dim adapter As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter("SELECT * FROM [RAW$]", connect)
        connect.Open()
        dsdaun = New System.Data.DataSet
        dsdaun.Clear()
        adapter.Fill(dsdaun, "DTdaun")
        DataGridView1.DataSource = dsdaun.Tables("DTdaun").DefaultView
        connect.Close()
        connect = Nothing
    End Sub
    Private Sub RXLSLine()
        Dim iRow, maxRows, newRows As Integer
        Dim newInDirect As String
        Dim ReplCustomer As String
        newInDirect = ""
        ' Now Transfer from this datagrid to the frmMain.datagriedview
        maxRows = frmMain.dgvProjects.RowCount
        newRows = Me.DataGridView1.Rows.Count
        If newRows = 0 Then
            MsgBox("Nothing to import!" & Chr(13) & "Click the View Button first!", vbExclamation + vbOKOnly, "Error")
            Return
        End If
        Try
            For iRow = 0 To newRows - 1
                Select Case CheckNull(Me.DataGridView1.Rows(iRow).Cells(10).Value, False)
                    Case 0
                        newInDirect = MyProcedures.txtDirect    ' "Direct"
                    Case 1
                        newInDirect = MyProcedures.txtIndirect  ' "Indirect"
                    Case 2
                        newInDirect = "undefined"
                    Case 99
                        newInDirect = MyProcedures.txtManual    ' "Manual"
                End Select
                '00 - Me.edtDescription.Text, _
                '01 - Me.edtCustomer.Text, _
                '03 - Me.cmbProduct.Text, _
                '05 - Me.edtRequestor.Text, _
                '06 - Me.cmbSalesGroup.Text, _
                '07 - Me.cmbActivity.Text, _
                '08 - "<not set>", _
                '09 - Val(Me.cmbTravel.Text), _
                '11 - Me.cmbStatus.Text, _
                '12 - frmSetup.lblRegion.Text, _
                '15 - 0, _
                '16 - Me.edtFeld1.Text, _
                '17 - Me.edtFeld2.Text, _
                '04 - Val(Me.cmbWorked.Text), _
                '14 - Me.edtRTM.Text, _
                'xx - Me.edtYear.Value, _
                'xx - Me.edtPeriod.Value, _
                '13 - Val(Me.lblActArea.Text)
                'CheckNull(Val(Me.DataGridView1.Rows(iRow).Cells(9).Value) , True), _
                '                                    CheckNull(Me.DataGridView1.Rows(iRow).Cells(16).Value, False), _
                '                        CheckNull(Me.DataGridView1.Rows(iRow).Cells(17).Value, False), _
                ReplCustomer = CheckNull(Me.DataGridView1.Rows(iRow).Cells(1).Value, False)
                ReplCustomer = ReplCustomer.Replace("[", "{")
                ReplCustomer = ReplCustomer.Replace("]", "}")
                frmMain.RAWTableAdapter.Insert( _
                        CheckNull(Me.DataGridView1.Rows(iRow).Cells(0).Value, False), _
                        ReplCustomer, _
                        CheckNull(Me.DataGridView1.Rows(iRow).Cells(3).Value, False), _
                        CheckNull(Me.DataGridView1.Rows(iRow).Cells(5).Value, False), _
                        CheckNull(Me.DataGridView1.Rows(iRow).Cells(6).Value, False), _
                        CheckNull(Me.DataGridView1.Rows(iRow).Cells(7).Value, False), _
                        "<not set>", _
                        CDbl(CheckNull(Me.DataGridView1.Rows(iRow).Cells(9).Value, True)), _
                        CheckNull(Me.DataGridView1.Rows(iRow).Cells(11).Value, False), _
                        CheckNull(Me.DataGridView1.Rows(iRow).Cells(12).Value, False), _
                        0, _
                        CheckNull(Me.DataGridView1.Rows(iRow).Cells(16).Value, False), _
                        CheckNull(Me.DataGridView1.Rows(iRow).Cells(17).Value, False), _
                        CDbl(CheckNull(Me.DataGridView1.Rows(iRow).Cells(4).Value, True)), _
                        newInDirect, _
                        2011, _
                        1, _
                        CInt(CheckNull(Me.DataGridView1.Rows(iRow).Cells(13).Value, True)))
            Next
        Catch ex As Exception When (iRow < newRows)
            MsgBox("There was an error while importing your old projects. Try again!" & ChrW(13) & ChrW(13) & _
                ex.Message.ToString, MsgBoxStyle.Critical + vbOKOnly, "Error")
        Catch ex As Exception When (iRow = newRows - 1)
            MsgBox("Import was done successfully.", vbInformation + vbOKOnly, "Import")
        Finally
            Beep()
        End Try
        frmMain.RefreshDGV(iRow - 1)
    End Sub
    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        If dlgSearchXLS.ShowDialog() = vbOK Then
            edtXLSFile.Text = dlgSearchXLS.FileName
        End If
    End Sub
End Class