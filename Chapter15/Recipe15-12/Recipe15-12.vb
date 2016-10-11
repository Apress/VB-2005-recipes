Imports System
Imports System.Linq
Imports System.Diagnostics
Public Class Recipe15_12

    '  This field holds the size of our pages.
    Private Shared pageSize As Integer = 10
    Private Const FIVE_MB = 5 * (1024 * 1024)
    Public Shared Sub Main()

        '  Use LINQ to retrieve a IEnumerable(Of Process) List of
        '  processes that are using more then 5 MB of memory.  The
        '  ToList method is used to force the query to execute immediately.
        Dim procs = (From proc In Process.GetProcesses.ToList _
                    Where proc.WorkingSet64 > FIVE_MB _
                    Order By proc.ProcessName _
                    Select proc).ToList

        '  Calculate the total number of pages by dividing the count of
        '  processes by the page size.
        Dim totalPages As Integer = procs.Count / pageSize

        Console.WriteLine("LIST OF PROCESSES WITH MEMORY USAGE OVER 5 MB:")
        Console.WriteLine("")

        '  Loop and display each page of data.
        For i = 0 To totalPages - 1
            Console.WriteLine("PAGE {0} OF {1}", i + 1.ToString(), totalPages.ToString())

            '  Loop through all of the process records for this page.
            '  A combination of the Skip and Take methods is used to
            '  accomplish paging on our data.
            For Each proc In procs.Skip(i * pageSize).Take(pageSize)
                Console.WriteLine("{0,-20} - {1,5} MB", proc.ProcessName, (proc.WorkingSet64 / 1048576).ToString("##.##"))
            Next

            '  Check if there are any more pages.
            If Not i = totalPages - 1 Then
                Console.WriteLine("Press Enter for the next page.")
                Console.ReadLine()
            End If
        Next

        Console.WriteLine("No more data available.  Press Enter to end.")
        Console.ReadLine()

    End Sub

End Class

