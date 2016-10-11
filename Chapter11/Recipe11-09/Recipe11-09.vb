Imports System
Imports System.Reflection
Imports System.Collections
Imports System.Security.Policy
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_09

        Public Shared Sub Main(ByVal args As String())

            '  Load the specified assembly.
            Dim a As Assembly = Assembly.LoadFrom(args(0))

            '  Get the evidence collection from the
            '  loaded assembly.
            Dim e As Evidence = a.Evidence

            '  Display the Host Evidence.
            Dim x As IEnumerator = e.GetHostEnumerator

            Console.Write("HOST EVIDENCE COLLECTION:")

            While x.MoveNext
                Console.Write(x.Current.ToString)
                Console.Write("Press Enter to see next evidence.")
                Console.ReadLine()
            End While

            '  Display the Assembly evidence.
            x = e.GetAssemblyEnumerator()

            Console.Write("ASSEMBLY EVIDENCE COLLECTION:")

            While x.MoveNext
                Console.Write(x.Current.ToString)
                Console.Write("Press Enter to see next evidence.")
                Console.ReadLine()
            End While

            '  Wait to continue.
            Console.Write("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace