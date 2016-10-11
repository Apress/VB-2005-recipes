'  All designed code is stored in the autogenerated partial
'  class called MainForm.Designer.vb.  You can see this
'  file by selecting "Show All Files" in solution explorer.
Partial Public Class MainForm

    Private Sub mnuOpen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuOpen.Click

        Dim dlg As New OpenFileDialog

        dlg.Filter = "Rich Text Files (*.rtf)|*.RTF|All Files (*.*)|*.*"
        dlg.CheckFileExists = True
        dlg.InitialDirectory = Application.StartupPath

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            rtDoc.LoadFile(dlg.FileName)
            rtDoc.Enabled = True
        End If

    End Sub
    Private Sub mnuSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSave.Click

        Dim dlg As New SaveFileDialog

        dlg.Filter = "Rich Text Files (*.rtf)|*.RTF|Text Files (*.txt)|*.TXT|All Files (*.*)|*.*"
        dlg.InitialDirectory = Application.StartupPath

        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            rtDoc.SaveFile(dlg.FileName)
        End If

    End Sub
    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExit.Click

        Me.Close()

    End Sub

End Class