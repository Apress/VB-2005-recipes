Imports System
Imports System.Net
Imports Recipe10_14.MyWebService
Imports System.Security.Cryptography.X509Certificates
Namespace Apress.VisualBasicRecipes.Chapter10

    Public Class Recipe10_14

        Public Shared Sub Main()

            '  Create a Web service proxy.  For the purpose of the example, set
            '  the ConnectionGroupName to a unique value to stop the
            '  ServicePointManager reusing the connection in future requests.
            Dim proxy1 As New MyWebService.MyWebService
            proxy1.ConnectionGroupName = "Test1"

            '  Configure the proxy with a set of credentials for use over basic
            '  authentication.
            Dim cache As New CredentialCache
            cache.Add(New Uri(proxy1.Url), "Basic", New NetworkCredential("user", "password"))
            proxy1.Credentials = cache

            '  Try to call the GetIISUser Web method.
            Try
                Console.WriteLine("Authenticated user = {0}", proxy1.GetIISUser)
            Catch ex As WebException
                Console.WriteLine("Basic authentication failed")
            End Try

            '  Create a proxy that authenticates the current user
            '  with Windows integrated authentication.
            Dim proxy2 As New MyWebService.MyWebService
            proxy2.ConnectionGroupName = "Test2"
            proxy2.Credentials = Nothing
            proxy2.UseDefaultCredentials = True

            Try
                Console.WriteLine("Authenticated user = {0}", proxy2.GetIISUser)
            Catch ex As WebException
                Console.WriteLine("Integrated Windows authentication failed")
            End Try

            '  Create a proxy that authenticates the user with a client
            '  certificate loaded form a file.
            Dim proxy3 As New MyWebService.MyWebService
            proxy3.ConnectionGroupName = "Test3"
            Dim cert1 As X509Certificate = X509Certificate.CreateFromCertFile("..\..\TestCertificate.cer")
            proxy3.ClientCertificates.Add(cert1)

            Try
                Console.WriteLine("Authenticated user = {0}", proxy3.GetIISUser)
            Catch ex As WebException
                Console.WriteLine("Certificate authentication failed")
            End Try

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter")
            Console.ReadLine()

        End Sub

    End Class
End Namespace