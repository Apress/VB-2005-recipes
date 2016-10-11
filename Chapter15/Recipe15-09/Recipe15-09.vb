Imports System
Imports System.Linq
Public Class Recipe15_09

    Public Shared employees As List(Of SampleData.Employee) = SampleData.HelperMethods.GetEmployees
    Public Shared tasks As List(Of SampleData.Task) = SampleData.HelperMethods.GetTasks
    Private Shared Sub EmployeeTasks()

        Console.WriteLine("List of employees and their tasks:")
        Console.WriteLine(Environment.NewLine)

        '  Create a query that will join employee and task data,
        '  returning the first name and task title for each employee.
        Dim query = From emp In employees, task In tasks _
                    Where emp.EmployeeID = task.EmployeeID _
                    Select emp.FirstName, task.Title _
                    Order By FirstName

        For Each rec In query
            Console.WriteLine("  {0} - {1}", rec.FirstName, rec.Title)
        Next

        Console.WriteLine(Environment.NewLine)

    End Sub
    Private Shared Sub OpenTasksForThisYear()

        Console.WriteLine("List of employees hired this year with open tasks:")
        Console.WriteLine(Environment.NewLine)

        '  Create a query that will join employee and task data,
        '  returning the first name and task title for each employee.
        Dim query = From emp In employees, task In tasks _
                    Where emp.EmployeeID = task.EmployeeID And _
                          emp.HireDate.Year = DateTime.Now.Year And _
                          task.Status = SampleData.Task.TaskStatus.Open _
                    Select FullName = emp.LastName & ", " & emp.FirstName, task.Title _
                    Order By FullName

        For Each rec In query
            Console.WriteLine("  {0} - {1}", rec.FullName, rec.Title)
        Next

        Console.WriteLine(Environment.NewLine)

    End Sub
    Public Shared Sub Main()

        Call EmployeeTasks()
        Call OpenTasksForThisYear()

        Console.WriteLine("End of samples reached.  Press Enter.")
        Console.ReadLine()

    End Sub

End Class
