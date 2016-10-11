Imports System
Imports System.Linq
Public Class Recipe15_05

    '  Load sample data to be used for this recipe.
    Private Shared employees As List(Of SampleData.Employee) = SampleData.HelperMethods.GetEmployees
    '  Show a list of employees.
    Private Shared Sub EmployeeList()

        Console.WriteLine("List of employees:")

        '  Create a query that will simply return all
        '  employee objects.  In this case, query is
        '  inferred as IEnumerable(Of SampleData.Employee).
        Dim query = From emp In employees _
                    Select emp

        '  Execute the query and iterate through each
        '  employee object returned and display the 
        '  information.
        For Each emp In query
            Console.WriteLine("  [{0}] {1} {2} {3} {4}", emp.EmployeeID, emp.FirstName, emp.LastName, emp.WorkGroup, emp.HireDate.ToString("MM/dd/yyy"))
        Next

        Console.WriteLine(Environment.NewLine)

    End Sub
    '  Show a list of employee names.
    Private Shared Sub EmployeeNames()

        Console.WriteLine("List of employee's first names:")

        '  Create a query that will return just the name
        '  for the employe object.  In this case, query 
        '  is inferred as IEnumerable(Of String).
        Dim query = From emp In employees _
                    Select emp.FirstName

        '  Execute the query and iterate through each
        '  employee name returned and display the 
        '  information.
        For Each name In query
            Console.WriteLine(name)
        Next

        Console.WriteLine(Environment.NewLine)

    End Sub
    '  Show a list of employees full names (first and
    '  last) and how long (in days) since each was
    '  hired.
    Private Shared Sub EmployeeInfo()

        Console.WriteLine("List of employees full names and how long since they were hired:")

        '  Create a query that will return the full name and
        '  number of days since hired for each employee.  In
        '  this case, query is inferred as IEnumerable(Of 
        '  <anonymous type>).
        Dim query = From emp In employees _
                    Select DaysSinceHired = DateTime.Now.Subtract(emp.HireDate).Days, _
                    FullName = emp.LastName & ", " & emp.FirstName

        '  Execute the query and iterate through each
        '  object returned and display the information.
        For Each emp In query
            Console.WriteLine("  {0} was hired {1} day(s) ago.", emp.FullName, emp.DaysSinceHired)
        Next
        Console.WriteLine(Environment.NewLine)

    End Sub
    Public Shared Sub Main()

        '  Call each sample method that demonstrates basic
        '  LINQ query expressions.
        Call EmployeeList()
        Call EmployeeNames()
        Call EmployeeInfo()

        Console.WriteLine("End of samples reached.  Press Enter.")
        Console.ReadLine()

    End Sub

End Class