Public Class frmFind
    Private Sub CustomerToolStripTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerToolStripTextBox.Leave
        If frmSetup.chkAutoPercent.Checked And FirstSearch Then
            If Microsoft.VisualBasic.Left(Me.CustomerToolStripTextBox.Text, 1) <> "%" Then
                Me.CustomerToolStripTextBox.Text = "%" & Me.CustomerToolStripTextBox.Text
            End If
            If Microsoft.VisualBasic.Right(Me.CustomerToolStripTextBox.Text, 1) <> "%" Then
                Me.CustomerToolStripTextBox.Text = Me.CustomerToolStripTextBox.Text & "%"
            End If
            FirstSearch = False
        End If
        'Me.CustomerToolStripTextBox.Text = "%" & Me.CustomerToolStripTextBox.Text & "%"
        SearchCustomer()
    End Sub
    Public Sub SearchCustomer()
        Try
            Me.CustomerTableAdapter.qryCustomer(Me.dsCustomer.Customer, CustomerToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvCustomer_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustomer.CellContentDoubleClick
        If (e.ColumnIndex >= 0 And e.RowIndex >= 0) Then
            frmMain.edtCustomer.Text = Me.dgvCustomer.Item(0, e.RowIndex).Value
            If IsDBNull(Me.dgvCustomer.Item(1, e.RowIndex).Value) Then
                Me.dgvCustomer.Item(1, e.RowIndex).Value = ""
            Else
                frmMain.edtRTM.Text = Me.dgvCustomer.Item(1, e.RowIndex).Value
                frmMain.lblRTM.Text = frmMain.edtRTM.Text
            End If

            If IsDBNull(Me.dgvCustomer.Item(2, e.RowIndex).Value) Then
                frmMain.edtFeld1.Text = ""
            Else
                frmMain.edtFeld1.Text = Me.dgvCustomer.Item(2, e.RowIndex).Value
            End If
            If IsDBNull(Me.dgvCustomer.Item(3, e.RowIndex).Value) Then
                frmMain.edtFeld2.Text = ""
            Else
                frmMain.edtFeld2.Text = Me.dgvCustomer.Item(3, e.RowIndex).Value
            End If
            frmMain.notFind = False
            Me.Hide()
        End If
    End Sub

    Private Sub dgvCustomer_DoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCustomer.CellContentDoubleClick
        If (e.ColumnIndex >= 0 And e.RowIndex >= 0) Then
            frmMain.edtCustomer.Text = Me.dgvCustomer.Item(0, e.RowIndex).Value
            If IsDBNull(Me.dgvCustomer.Item(1, e.RowIndex).Value) Then
                Me.dgvCustomer.Item(1, e.RowIndex).Value = ""
            Else
                frmMain.edtRTM.Text = Me.dgvCustomer.Item(1, e.RowIndex).Value
                frmMain.lblRTM.Text = frmMain.edtRTM.Text
            End If

            If IsDBNull(Me.dgvCustomer.Item(2, e.RowIndex).Value) Then
                frmMain.edtFeld1.Text = ""
            Else
                frmMain.edtFeld1.Text = Me.dgvCustomer.Item(2, e.RowIndex).Value
            End If
            If IsDBNull(Me.dgvCustomer.Item(3, e.RowIndex).Value) Then
                frmMain.edtFeld2.Text = ""
            Else
                frmMain.edtFeld2.Text = Me.dgvCustomer.Item(3, e.RowIndex).Value
            End If
            frmMain.notFind = False
            MyProcedures.ColorStatus()
            Me.Hide()
        End If
    End Sub

    Private Sub frmFind_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'ListsDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.dsCustomer.Customer, "{%")
        'Me.CustomerTableAdapter.Fill(Me.dsCustomer.Customer)
    End Sub

    Private Sub QryCustomerToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QryCustomerToolStripButton.Click
        SearchCustomer()
    End Sub

    Private Sub btnResetFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetFilter.Click
        Me.CustomerTableAdapter.qryCustomer(Me.dsCustomer.Customer, "%")
        FirstSearch = True
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Hide()
        Me.Close()
    End Sub
End Class