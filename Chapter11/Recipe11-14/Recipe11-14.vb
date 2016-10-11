Imports system
imports System.Text
imports System.Security.Cryptography
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_14

        Public Shared Sub Main(ByVal args As String())

            '  Create a HashAlgorithm of the type specified by the first
            '  command-line argument.
            Dim hashAlg As HashAlgorithm = Nothing

            '  The SHA1Managed algorithm cannot be implemented using the
            '  factory approach. It must be instantiated directly.
            If args(0).CompareTo("SHA1Managed") = 0 Then
                hashAlg = New SHA1Managed
            Else
                hashAlg = HashAlgorithm.Create(args(0))
            End If

            Using hashAlg
                    
                '  Convert the password string, provided as the second
                '  command-line argument, to an array of bytes.
                Dim pwordData As Byte() = Encoding.Default.GetBytes(args(1))

                '  Generate the hash code of the password.
                Dim hash As Byte() = hashAlg.ComputeHash(pwordData)

                '  Display the hash code of the password to the console.
                Console.WriteLine(BitConverter.ToString(hash))

                '  Wait to continue.
                Console.WriteLine(Environment.NewLine)
                Console.WriteLine("Main method complete.  Press Enter.")
                Console.ReadLine()

            End Using

        End Sub

    End Class

End Namespace