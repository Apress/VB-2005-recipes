Imports System
Imports System.Threading
Imports Recipe10_15.MyWebService
Namespace Apress.VisualBasicRecipes.Chapter10

    Public Class Recipe10_15

        Public Shared Sub Main()

            '  Create a proxy through which to execute the methods of
            '  the Web Service.
            Dim proxy As New MyWebService.MyWebService

            '  Add an event handler to the EchoCompleted event.
            AddHandler proxy.EchoCompleted, AddressOf EchoCompletedHandler

            '  Call the Echo three times asynchronously.
            proxy.EchoAsync("Echo String 1", 7000, 10000, "Test1")
            proxy.EchoAsync("Echo String 2", 5000, 10000, "Test2")
            proxy.EchoAsync("Echo String 3", 1000, 10000, "Test3")

            '  Quickly cancel the second asynchronous operation.
            proxy.CancelAsync("Test2")

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

        End Sub
        '  A method to handle asynchronous Echo completion events.
        Private Shared Sub EchoCompletedHandler(ByVal sender As Object, ByVal args As EchoCompletedEventArgs)

            If args.Error IsNot Nothing Then
                Console.WriteLine("{0}: {1}", args.UserState, args.Error.Message)
            ElseIf args.Cancelled Then
                Console.WriteLine("{0}: operation cancelled before completion.", args.UserState)
            Else
                Console.WriteLine("{0}: Succeeded, echoed string = {1}.", args.UserState, args.Result)
            End If

        End Sub

    End Class

End Namespace