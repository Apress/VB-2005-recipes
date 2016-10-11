Imports System
Imports System.Xml
Imports System.Data
Imports System.Data.SqlClient
Namespace Apress.VisualBasicRecipes.Chapter09

    Public Class Recipe09_08

        Public Shared Sub ConnectedExample()

            '  Create a new SqlConnection object.
            Using con As New SqlConnection

                '  Configure the SqlConnection object's connection string.
                con.ConnectionString = "Data Source=.\sqlexpress;Database=AdventureWorks;Integrated Security=SSPI;"

                '  Create and configure a new command that includes the
                '  FOR XML AUTO clause.
                Using com As SqlCommand = con.CreateCommand

                    com.CommandType = CommandType.Text
                    com.CommandText = "SELECT DepartmentID, [Name], GroupName FROM HumanResources.Department FOR XML AUTO"

                    '  Open the database connection.
                    con.Open()

                    '  Execute the command and retrieve and XmlReader to access
                    '  the results.
                    Using reader As XmlReader = com.ExecuteXmlReader
                        While reader.Read
                            Console.WriteLine("Element: " & reader.Name)

                            If reader.HasAttributes Then
                                For i As Integer = 0 To reader.AttributeCount - 1
                                    reader.MoveToAttribute(i)
                                    Console.Write("  {0}: {1}", reader.Name, reader.Value)
                                Next

                                '  Move the XmlReader back to the element node.
                                reader.MoveToElement()
                                Console.WriteLine(Environment.NewLine)
                            End If
                        End While
                    End Using

                    '  Close the database connection.
                    con.Close()

                End Using
            End Using

        End Sub
        Public Shared Sub DisconnectedExample()

            Dim doc As New XmlDocument

            '  Create a new SqlConnection object.
            Using con As New SqlConnection

                '  Configure the SqlConnection object's connection string.
                con.ConnectionString = "Data Source=.\sqlexpress;Database=AdventureWorks;Integrated Security=SSPI;"

                '  Create and configure a new command that includes the
                '  FOR XML AUTO clause.
                Using com As SqlCommand = con.CreateCommand

                    com.CommandType = CommandType.Text
                    com.CommandText = "SELECT DepartmentID, [Name], GroupName FROM HumanResources.Department FOR XML AUTO;"

                    '  Open the database connection.
                    con.Open()

                    '  Load the XML data into the XmlDocument.  Must first create a 
                    '  root element into which to place each result row element.
                    Dim reader As XmlReader = com.ExecuteXmlReader
                    doc.LoadXml("<results></results>")

                    '  Create an XmlNode from the next XML element read from the
                    '  reader.
                    Dim newNode As XmlNode = doc.ReadNode(reader)

                    While newNode IsNot Nothing
                        doc.DocumentElement.AppendChild(newNode)
                        newNode = doc.ReadNode(reader)
                    End While

                    '  Close the database connection.
                    con.Close()

                End Using
            End Using

            '  Process the disconnected XmlDocument.
            Console.WriteLine(doc.OuterXml)

        End Sub
        Public Shared Sub Main()

            ConnectedExample()
            Console.WriteLine(Environment.NewLine)

            DisconnectedExample()
            Console.WriteLine(Environment.NewLine)

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace