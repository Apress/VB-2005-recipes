Imports System
Imports System.Xml
Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_05

        Public Shared Sub Main()

            '  Load the document.
            Dim doc As New XmlDocument
            doc.Load("..\..\Order.xml")

            '  Retrieve all order tags.
            Dim matches As XmlNodeList = doc.GetElementsByTagName("*", "http://mycompany/OrderML")

            '  Display all the information.
            Console.WriteLine("Element {0}Attributes", ControlChars.Tab)
            Console.WriteLine("******* {0}**********", ControlChars.Tab)

            For Each node As XmlNode In matches
                Console.Write("{0}{1}", node.Name, ControlChars.Tab)
                For Each attribute As XmlAttribute In node.Attributes
                    Console.Write(attribute.Value & " ")
                Next
                Console.WriteLine()
            Next
            Console.ReadLine()

        End Sub

    End Class

End Namespace