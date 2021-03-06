Imports System
Imports System.Net
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
'  All designed code is stored in the autogenerated partial
'  class called Recipe10-04.Designer.vb.  You can see this
'  file by selecting "Show All Files" in solution explorer.
Public Class Recipe10_04

    Private Sub Recipe10_04_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim picUri As String = "http://www.apress.com/img/img05/Hex_RGB4.jpg"
        Dim htmlUri As String = "http://www.apress.com"

        '  Create the requests.
        Dim requestPic As WebRequest = WebRequest.Create(picUri)
        Dim requestHtml As WebRequest = WebRequest.Create(htmlUri)

        '  Get the responses.  This takes the most significant amount of
        '  time, particularly if the file is large, because the whole
        '  response is retrieved.
        Dim responsePic As WebResponse = requestPic.GetResponse
        Dim responseHtml As WebResponse = requestHtml.GetResponse

        '  Read the image from the response stream.
        picturebox1.image = Image.FromStream(responsePic.GetResponseStream)

        '  Read the text from the response stream.
        Using r As New StreamReader(responseHtml.GetResponseStream)
            textbox1.text = r.ReadToEnd
        End Using

    End Sub

End Class
