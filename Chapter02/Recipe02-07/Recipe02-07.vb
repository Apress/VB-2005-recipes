Imports System

Namespace Apress.VisualBasicRecipes.Chapter02

    Public Class Recipe02_07

        Public Shared Sub Main(ByVal args As String())

            '  1st January 1975 00:00:00
            Dim dt1 As DateTime = DateTime.Parse("Jan 1975")

            '  12th January 1975 18:19:00
            Dim dt2 As DateTime = DateTime.Parse("Sunday 12 January 1975 18:19:00")

            '  12th January 1975 00:00:00
            Dim dt3 As DateTime = DateTime.Parse("1,12,1975")

            '  12th January 1975 18:19:00
            Dim dt4 As DateTime = DateTime.Parse("1/12/1971 18:19:00")

            '  Current Date 18:19
            Dim dt5 As DateTime = DateTime.Parse("6:19 PM")

            '  Display the converted DateTime objects.
            Console.WriteLine(dt1)
            Console.WriteLine(dt2)
            Console.WriteLine(dt3)
            Console.WriteLine(dt4)
            Console.WriteLine(dt5)

            '  Parse only strings containing LongTimePattern.
            Dim dt6 As DateTime = DateTime.ParseExact("6:19:00 PM", "h:mm:ss tt", Nothing)

            '  Parse only strings containing RFC1123Pattern.
            Dim dt7 As DateTime = DateTime.ParseExact("Sun, 12 Jan 1975 18:19:00 GMT", "ddd, dd MMM yyyy HH':'mm':'ss 'GMT'", Nothing)

            '  Parse only strings containing MonthDayPattern.
            Dim dt8 As DateTime = DateTime.ParseExact("January 12", "MMMM dd", Nothing)

            '  Display the converted DateTime objects.
            Console.WriteLine(dt6)
            Console.WriteLine(dt7)
            Console.WriteLine(dt8)

            '  Wait to continue.
            Console.WriteLine(vbCrLf & "Main method complete.  Press Enter")
            Console.ReadLine()

        End Sub

    End Class

End Namespace
