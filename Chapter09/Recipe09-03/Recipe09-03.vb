Imports System
Imports System.Data.SqlClient
Namespace Apress.VisualBasicRecipes.Chapter09

    Public Class Recipe09_03

        Public Shared Sub Main()

            '  Configure the SqlConnection object's connection string.
            Dim conString As String = "Data Source=.\sqlexpress;Database=AdventureWorks;Integrated Security=SSPI;Min Pool Size=5;Max Pool Size=15;Connection Reset=True;Connection Lifetime=600;"

            '  Parse the SQL Server connection string and display the component
            '  configuration parameters.
            Dim sb1 As New SqlConnectionStringBuilder(conString)

            Console.WriteLine("Parsed SQL Connection String Parameters:")
            Console.WriteLine("  Database Source = " & sb1.DataSource)
            Console.WriteLine("  Database = " & sb1.InitialCatalog)
            Console.WriteLine("  Use Integrated Security = " & sb1.IntegratedSecurity)
            Console.WriteLine("  Min Pool Size = " & sb1.MinPoolSize)
            Console.WriteLine("  Max Pool Size = " & sb1.MaxPoolSize)
            Console.WriteLine("  Lifetime = " & sb1.LoadBalanceTimeout)
            Console.WriteLine("  Connection Reset = " & sb1.ConnectionReset)

            '  Build a connection string from component parameters and display it.
            Dim sb2 As New SqlConnectionStringBuilder(conString)

            sb2.DataSource = ".\sqlexpress"
            sb2.InitialCatalog = "AdventureWorks"
            sb2.IntegratedSecurity = True
            sb2.MinPoolSize = 5
            sb2.MaxPoolSize = 15
            sb2.LoadBalanceTimeout = 600
            sb2.ConnectionReset = True

            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Constructed connection string:")
            Console.WriteLine(" " & sb2.ConnectionString)

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace