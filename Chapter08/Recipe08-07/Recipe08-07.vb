Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
'  All designed code is stored in the autogenerated partial
'  class called Recipe08-07.Designer.vb.  You can see this
'  file by selecting "Show All Files" in solution explorer.
Partial Public Class Recipe08_07

    '  Track the image size and the type of animation
    '  (expanding or shrinking).
    Private isShrinking As Boolean = False
    Private imageSize As Integer = 0

    '  Store the logo that will be painted on the form.
    Private img As Image
    Private Sub Recipe08_07_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '  Load the logo image from the file.
        img = Image.FromFile("test.jpg")

        '  Start the time that invalidates the form.
        tmrRefresh.Start()

    End Sub
    Private Sub tmrRefresh_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrRefresh.Tick

        '  Change the desired image size according to the animation mode.
        If isShrinking Then
            imageSize -= 1
        Else
            imageSize += 1
        End If

        '  Change the sizing direction if it nears the form border.
        If imageSize > (Me.Width - 150) Then
            isShrinking = True
        ElseIf imageSize < 1 Then
            isShrinking = False
        End If

        Me.Invalidate()

    End Sub
    Private Sub Recipe08_07_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Dim g As Graphics

        g = e.Graphics
        g.SmoothingMode = SmoothingMode.HighQuality

        '  Draw the backgroun.
        g.FillRectangle(Brushes.Yellow, New Rectangle(New Point(0, 0), Me.ClientSize))

        '  Draw the logo image.
        g.DrawImage(img, 50, 50, 50 + imageSize, 50 + imageSize)

    End Sub
    Private Sub chkUseDoubleBuffering_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkUseDoubleBuffering.CheckedChanged
        Me.DoubleBuffered = chkUseDoubleBuffering.Checked
    End Sub

End Class