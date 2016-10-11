Imports System
Imports System.Xml
Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_02

        Public Shared Sub Main()

            '  Create a new, empty document.
            Dim doc As New XmlDocument
            Dim docNode As XmlNode = doc.CreateXmlDeclaration("1.0", "UTF-8", Nothing)

            doc.AppendChild(docNode)

            '  Create and insert a new element.
            Dim productsNode As XmlNode = doc.CreateElement("Products")
            doc.AppendChild(productsNode)

            '  Create a nested element (with an attribute).
            Dim productNode As XmlNode = doc.CreateElement("Product")
            Dim productAttribute As XmlAttribute = doc.CreateAttribute("id")
            productAttribute.Value = "1001"
            productNode.Attributes.Append(productAttribute)
            productsNode.AppendChild(productNode)

            '  Create and add the subelements for this product node
            '  (with contained text data).
            Dim nameNode As XmlNode = doc.CreateElement("ProductName")
            nameNode.AppendChild(doc.CreateTextNode("Gourmet Coffee"))
            productNode.AppendChild(nameNode)
            Dim priceNode As XmlNode = doc.CreateElement("ProductPrice")
            priceNode.AppendChild(doc.CreateTextNode("0.99"))
            productNode.AppendChild(priceNode)

            '  Create and add another product node.
            productNode = doc.CreateElement("Product")
            productAttribute = doc.CreateAttribute("id")
            productAttribute.Value = "1002"
            productNode.Attributes.Append(productAttribute)
            productsNode.AppendChild(productNode)
            nameNode = doc.CreateElement("ProductName")
            nameNode.AppendChild(doc.CreateTextNode("Blue China Tea Pot"))
            productNode.AppendChild(nameNode)
            priceNode = doc.CreateElement("ProductPrice")
            priceNode.AppendChild(doc.CreateTextNode("102.99"))
            productNode.AppendChild(priceNode)

            '  Save the document (to the console window rather
            '  than a file).
            doc.Save(Console.Out)
            Console.ReadLine()

        End Sub

    End Class
End Namespace