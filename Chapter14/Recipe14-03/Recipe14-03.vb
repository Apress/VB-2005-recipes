Imports System
Imports System.Diagnostics
Namespace Apress.VisualBasicRecipes.Chapter14

    Public Class Recipe14_03

        Public Shared Sub Main()

            '  If it does not exist, register an event source for this
            '  application against the Application log of the local machine.
            '  Trying to register an event source that already exists on the
            '  specified machine will throw a System.ArgumentException.
            If Not EventLog.SourceExists("Visual Basic 2005 Recipes") Then
                EventLog.CreateEventSource("Visual Basic 2005 Recipes", "Application")
            End If

            '  Write an event to the event log.
            EventLog.WriteEntry("Visual Basic 2005 Recipes", "A simple test event.", EventLogEntryType.Information, 1, 0, New Byte() {10, 55, 200})

            '  Wait to continue.
            Console.WriteLine(Environment.NewLine)
            Console.WriteLine("Main method complete.  Press Enter.")
            Console.ReadLine()

            '  Remove the event source.
            EventLog.DeleteEventSource("Visual Basic 2005 Recipes")

        End Sub

    End Class
End Namespace
