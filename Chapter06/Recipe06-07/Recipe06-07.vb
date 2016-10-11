Imports System
Imports System.Xml
Imports System.IO
Imports System.Text
Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_07

        Public Shared Sub Main()

            '  Create the file and writer.
            Dim fs As New FileStream("products.xml", FileMode.Create)

            '  If you want to configure additional details (like indenting,
            '  encoding, and new line handling), use the overload of the Create
            '  method that accepts an XmlWriterSettings object instead.
            Dim w As XmlWriter = XmlWriter.Create(fs)

            '  Start the document and create the parent Products node.
            w.WriteStartDocument()
            w.WriteStartElement("Products")

            '  Write a product.
            w.WriteStartElement("Product")
            w.WriteAttributeString("id", "1001")
            w.WriteElementString("ProductName", "Gourmet Coffee")
            w.WriteElementString("ProductPrice", "0.99")
            w.WriteEndElement()

            '  Write another product.
            w.WriteStartElement("Product")
            w.WriteAttributeString("id", "1002")
            w.WriteElementString("ProductName", "Blue China Tea Pot")
            w.WriteElementString("ProductPrice", "102.99")
            w.WriteEndElement()

            '  End the Products node and the document.
            w.WriteEndElement()
            w.WriteEndDocument()

            '  Flush and close the document.
            w.Flush()
            fs.Close()

            Console.WriteLine("Document created. Press Enter to read the it.")
            Console.ReadLine()

            fs = New FileStream("Products.xml", FileMode.Open)

            '  If you want to configure additional details (like comments, 
            '  whitespace handling, or validation), use the overload of the
            '  Create method that accepts an XmlReaderSettings object instead.
            Dim r As XmlReader = XmlReader.Create(fs)

            '  Read all nodes.
            While r.Read

                If r.NodeType = XmlNodeType.Element Then
                    Console.WriteLine()
                    Console.WriteLine("<{0}>", r.Name)

                    If r.HasAttributes Then
                        For i As Integer = 0 To r.AttributeCount - 1
                            Console.WriteLine("{0}ATTRIBUTE: {1}", ControlChars.Tab, r.GetAttribute(i))
                        Next
                    End If
                ElseIf r.NodeType = XmlNodeType.Text Then
                    Console.WriteLine("{0}VALUE: {1}", ControlChars.Tab, r.Value)
                End If

            End While
            Console.ReadLine()

        End Sub

    End Class

End Namespace