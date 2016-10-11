Imports System
Imports System.Xml
Imports system.xml.schema
Namespace Apress.VisualBasicRecipes.Chapter06

    Public Class Recipe06_08

        Public Shared Sub Main()

            Dim xmlValidator As New ConsoleValidator
            Console.WriteLine("Validating ProductCatalog.xml")

            Dim success As Boolean = xmlValidator.ValidateXML("..\..\ProductCatalog.xml", "..\..\ProductCatalog.xsd")

            If Not success Then
                Console.WriteLine("Validation failed.")
            Else
                Console.WriteLine("Validation succeeded.")
            End If
            Console.ReadLine()

        End Sub

    End Class
    Public Class ConsoleValidator

        '  Set to true if at least one error exists.
        Private m_Failed As Boolean
        Public ReadOnly Property Failed() As Boolean
            Get
                Return m_Failed
            End Get
        End Property
        Public Function ValidateXML(ByVal xmlFileName As String, ByVal schemaFileName As String)

            '  Set the type of validation.
            Dim settings As New XmlReaderSettings
            settings.ValidationType = ValidationType.Schema

            '  Load the schema file.
            Dim schemas As New XmlSchemaSet
            settings.Schemas = schemas

            '  When loading the schema, specify the namespace it validates
            '  and the location of the file.  Use nothing to use the
            '  target Namespace specified in the schema.
            schemas.Add(Nothing, schemaFileName)

            '  Specify an event handler for validation errors.
            AddHandler settings.ValidationEventHandler, AddressOf HandleValidationEvents

            '  Create the validating reader.
            Dim validator As XmlReader = XmlReader.Create(xmlFileName, settings)

            m_Failed = False
            Try
                '  Read all XML data.
                While validator.Read()
                End While
            Catch ex As Exception
                '  This happens if the XML documnet includes illegal characters
                '  or tags that aren't properly nested or closed.
                Console.WriteLine("A critical XML error has occurred.")
                Console.WriteLine(ex.Message)
                m_Failed = True
            Finally
                validator.Close()
            End Try
            Return Not Failed

        End Function
        Private Sub HandleValidationEvents(ByVal sender As Object, ByVal args As ValidationEventArgs)

            m_Failed = True

            '  Display the validation error.
            Console.WriteLine("Validation error: " & args.Message)
            Console.WriteLine()

        End Sub

    End Class

End Namespace

