Public Class frmUpdate

    Private Sub frmUpdate_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ' Copy file to standard location
        If System.IO.File.Exists("./LISTS.MDB") Then
            System.IO.File.Delete("./LISTS.MDB")
        End If
        System.IO.File.Copy(frmSetup.edtFilename.Text, "./Lists.mdb")
        frmSetup.btnGetUser_Click(sender, e)
        MsgBox("Your Settings are updated.  You need to restart the application.", MsgBoxStyle.Exclamation + vbOKOnly, "Restart required")
        Me.Hide()
    End Sub
End Class