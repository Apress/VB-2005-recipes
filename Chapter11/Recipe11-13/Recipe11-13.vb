Imports System
Imports System.Security.Cryptography
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_13

        Public Shared Sub Main()

            '  Create a byte array to hold the random data.
            Dim number As Byte() = New Byte(32) {}

            '  Instantiate the default random number generator.
            Dim rng As RandomNumberGenerator = RandomNumberGenerator.Create

            '  Generate 32 bytes of random data.
            rng.GetBytes(number)

            '  Display the random number.
            Console.WriteLine(BitConverter.ToString(number))

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method compelte.  Press Enter.")
            Console.ReadLine()

        End Sub

    End Class

End Namespace