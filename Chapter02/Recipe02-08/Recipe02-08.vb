Imports System

Namespace Apress.VisualBasicRecipes.Chapter02

    Public Class Recipe02_08

        Public Shared Sub Main()

            '  Create a TimeSpan representing 2.5 days.
            Dim timespan1 As New TimeSpan(2, 12, 0, 0)

            '  Create a TimeSpan representing 4.5 days.
            Dim timespan2 As New TimeSpan(4, 12, 0, 0)

            '  Create a TimeSpan representing 1 week.
            Dim oneweek As TimeSpan = timespan1 + timespan2

            '  Create a DateTime with the current date and time.
            Dim now As DateTime = DateTime.Now

            '  Creae a DateTime representing 1 week ago.
            Dim past As DateTime = now - oneweek

            '  Create a DateTime representing 1 week in the future.
            Dim future As DateTime = now + oneweek

            ' Create a DateTime representing the next day using
            '  the AddDays method.
            Dim tomorrow As DateTime = now.AddDays(1)

            '  Display the DateTime instances.
            Console.WriteLine("Now      : {0}", now)
            Console.WriteLine("Past     : {0}", past)
            Console.WriteLine("Future   : {0}", future)
            Console.WriteLine("Tomorrow : {0}", tomorrow)

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
