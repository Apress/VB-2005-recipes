Imports system
Imports System.Drawing
Imports System.Windows.Forms
'  All designed code is stored in the autogenerated partial
'  class called Recipe07-12.Designer.vb.  You can see this
'  file by selecting "Show All Files" in solution explorer.
Partial Public Class Recipe07_12

    '  As the main form loads, clone the required section of the main
    '  menu and assign it to the ContextMenu propety of the TextBox.
    Private Sub Recipe07_12_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim mnuContext As New ContextMenu

        '  Copy the menu items from the File menu into a context menu.
        For Each mnuItem As MenuItem In mnuFile.MenuItems
            mnuContext.MenuItems.Add(mnuItem.CloneMenu)
        Next
        '  Attach the cloned menu to the TextBox.
        TextBox1.ContextMenu = mnuContext

    End Sub
    '  Event handler to display the ContextMenu for the ListBox.
    Private Sub TextBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then
            TextBox1.ContextMenu.Show(TextBox1, New Point(e.X, e.Y))
        End If

    End Sub
    '  Event handler to process clicks on File/Open menu item.
    '  For the purpose of the example, simply show a message box.
    Private Sub mnuOpen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        MessageBox.Show("This is the event handler for Open.", "Recipe07-12")
    End Sub
    Private Sub mnuSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSave.Click
        MessageBox.Show("This is the event handler for Save.", "Recipe07-12")
    End Sub
    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        MessageBox.Show("This is the event handler for Exit.", "Recipe07-12")
    End Sub

End Class
