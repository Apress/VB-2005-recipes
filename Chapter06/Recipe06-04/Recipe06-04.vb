Imports System
Imports System.Xml
Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_04

        Public Shared Sub Main()

            '  Load the document.
            Dim doc As New XmlDocument
            doc.Load("..\..\ProductCatalog.xml")

            '  Retrieve all prices.
            Dim totalPrice As Decimal = 0
            Dim prices As XmlNodeList = doc.GetElementsByTagName("productPrice")
            For Each price As XmlNode In prices
                '  Get the inner text of each matching element.
                totalPrice += Decimal.Parse(price.ChildNodes(0).Value)
            Next

            Console.WriteLine("Total catalog value: " & totalPrice.ToString)
            Console.ReadLine()

        End Sub
    End Class

End Namespace