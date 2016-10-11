Imports System
Imports System.Xml
Imports System.Xml.Serialization
Imports System.IO
Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_09

        Public Shared Sub Main()

            '  Create the product catalog.
            Dim catalog = New ProductCatalog("New Catalog", DateTime.Now.AddYears(1))
            Dim products As Product() = New Product(1) {}

            products(0) = New Product("Product 1", CDec(42.99))
            products(1) = New Product("Product 2", CDec(202.99))

            catalog.products = products

            '  Serialize the order to a file.
            Dim serializer As New XmlSerializer(GetType(ProductCatalog))
            Dim fs As New FileStream("ProductCatalog.xml", FileMode.Create)

            serializer.Serialize(fs, catalog)
            fs.Close()

            catalog = Nothing

            '  Deserialize the order from the file.
            fs = New FileStream("ProductCatalog.xml", FileMode.Open)
            catalog = DirectCast(serializer.Deserialize(fs), ProductCatalog)

            '  Serialize the order to the console window.
            serializer.Serialize(Console.Out, catalog)
            Console.ReadLine()

        End Sub

    End Class
    <XmlRoot("productCatalog")> _
    Public Class ProductCatalog

        <XmlElement("catalogName")> _
        Public CatalogName As String

        '  Use the date data type (and ignore the time portion
        '  in the serialized XML).
        <XmlElement(ElementName:="expiryDate", datatype:="date")> _
        Public ExpiryDate As DateTime

        '  Configure the name of the tag that holds all products
        '  and the name of the product tag itself.
        <XmlArray("products"), XmlArrayItem("product")> _
        Public products As Product()
        Public Sub New()
        End Sub
        Public Sub New(ByVal catalogName As String, ByVal expiryDate As DateTime)

            Me.CatalogName = catalogName
            Me.ExpiryDate = expiryDate

        End Sub

    End Class
    Public Class Product

        <XmlElement("productName")> _
        Public ProductName As String = String.Empty

        <XmlElement("productPrice")> _
        Public ProductPrice As Decimal = 0

        <XmlElement("inStock")> _
        Public InStock As Boolean = False

        <XmlAttribute(AttributeName:="id", DataType:="integer")> _
        Public Id As String = String.Empty
        Public Sub New()
        End Sub
        Public Sub New(ByVal productName As String, ByVal productPrice As Decimal)

            Me.ProductName = productName
            Me.ProductPrice = productPrice

        End Sub

    End Class

End Namespace