Imports System
Imports System.Xml
Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_03

        Public Shared Sub Main()

            '  Create the basic document.
            Dim doc As New XmlDocument
            Dim docNode As XmlNode = doc.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
            doc.AppendChild(docNode)
            Dim products = doc.CreateElement("Products")
            doc.AppendChild(products)

            '  Add two products.
            Dim product As XmlNode = XmlHelper.AddElment("Product", Nothing, products)
            XmlHelper.AddAttributes("id", "1001", product)
            XmlHelper.AddElment("ProductName", "Gourmet COffee", product)
            XmlHelper.AddElment("ProductPrice", "0.99", product)

            product = XmlHelper.AddElment("Product", Nothing, products)
            XmlHelper.AddAttributes("id", "1003", product)
            XmlHelper.AddElment("ProductName", "Blue China Tea Pot", product)
            XmlHelper.AddElment("ProductPrice", "102.99", product)

            '  Save the document (to the console window rather than a file)/
            doc.Save(Console.Out)
            Console.ReadLine()

        End Sub
    End Class
    Public Class XmlHelper

        Public Shared Function AddElment(ByVal tagName As String, ByVal textContent As String, ByVal parent As XmlNode) As XmlElement

            Dim element As XmlElement = parent.OwnerDocument.CreateElement(tagName)

            parent.AppendChild(element)

            If textContent IsNot Nothing Then
                Dim content As XmlNode
                content = parent.OwnerDocument.CreateTextNode(textContent)
                element.AppendChild(content)
            End If
            Return element

        End Function
        Public Shared Function AddAttributes(ByVal attributeName As String, ByVal textContent As String, ByVal parent As XmlNode) As XmlAttribute

            Dim attribute As XmlAttribute

            attribute = parent.OwnerDocument.CreateAttribute(attributeName)
            attribute.Value = textContent
            parent.Attributes.Append(attribute)

            Return attribute

        End Function

    End Class
End Namespace
