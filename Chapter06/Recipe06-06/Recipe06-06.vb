Imports System
Imports System.Xml
Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_06

        Public Shared Sub Main()

            '  Load the document.
            Dim doc As New XmlDocument
            doc.Load("..\..\Orders.xml")

            '  Retrieve the name of every item.
            '  This could not be accomplished as easily with the
            '  GetElementsByTagName method, because the Name elements are
            '  used in Iem elements and CLient elements, and so
            '  both types would be returned.
            Dim nodes As XmlNodeList = doc.SelectNodes("/Order/Items/Item/Name")

            For Each node As XmlNode In nodes
                Console.WriteLine(node.InnerText)
            Next
            Console.ReadLine()

        End Sub

    End Class

End Namespace
