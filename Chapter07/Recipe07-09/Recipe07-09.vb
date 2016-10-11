Imports System
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
'  All designed code is stored in the autogenerated partial
'  class called Recipe07-09.Designer.vb.  You can see this
'  file by selecting "Show All Files" in solution explorer.
Partial Public Class Recipe07_09

    Private Sub Recipe07_09_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '  Add the AutoCompleteComboBox to the form.
        Dim combo As New AutoCompleteCombobox

        combo.Location = New Point(10, 10)
        Me.Controls.Add(combo)

        '  Read the list of words from the file words.txt and add them
        '  to the AutoCompleteComboBox.
        Using fs As New FileStream("..\..\Words.txt", FileMode.Open)
            Using r As New StreamReader(fs)
                While r.Peek > -1
                    Dim word As String = r.ReadLine
                    combo.Items.Add(word)
                End While
            End Using
        End Using

    End Sub

End Class
Public Class AutoCompleteCombobox
    Inherits ComboBox

    '  A private member to track if a special key is pressed, in
    '  which case, any text replacement operation will be skipped.
    Private controlKey As Boolean = False
    '  Determine whether a special key was pressed.
    Protected Overrides Sub OnKeyPress(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        '  First call the overridden base class method.
        MyBase.OnKeyPress(e)

        '  Clear the text if the Escape key is pressed.
        If e.KeyChar = ChrW(Keys.Escape) Then
            '  Clear the text.
            Me.SelectedIndex = -1
            Me.Text = ""
            controlKey = True
        ElseIf Char.IsControl(e.KeyChar) Then
            '  Don't try to automcomplete when control key is pressed.
            controlKey = True
        Else
            '  Noncontrol keys should trigger autocompelte.
            controlKey = False
        End If

    End Sub
    '  Perform the text substitution.
    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)

        '  First call the overridden base class method.
        MyBase.OnTextChanged(e)

        If Not Me.Text = "" And Not controlKey Then
            '  Search the current contents of the combo box for a 
            '  matching entry.
            Dim matchText As String = Me.Text
            Dim match As Integer = Me.FindString(matchText)

            '  If a matching entry is gound, insert it now.
            If Not match = -1 Then
                Me.SelectedIndex = match

                '  Select the added text so it can be replaced
                '  if the user keeps trying.
                Me.SelectionStart = matchText.Length
                Me.SelectionLength = Me.Text.Length - Me.SelectionStart
            End If
        End If

    End Sub

End Class
