Imports System
Imports System.Linq
Public Class Recipe15_07

    '  Load sample data to be used for this recipe.
    Public Shared employees As List(Of SampleData.Employee) = SampleData.HelperMethods.GetEmployees
    '  Show a list of employees orderd by their last
    '  names.
    Private Shared Sub SortByLastName()


        Console.WriteLine("List of employees:")
        Console.WriteLine("  -  Ordered by LastName (Ascending)")
        Console.WriteLine(Environment.NewLine)

        '  Create a query that will simply return all
        '  employee objects and sort them by the
        '  LastName property.  In this case, query is
        '  inferred as IEnumerable(Of SampleData.Employee).
        Dim query = From emp In employees _
                    Order By emp.LastName, emp.FirstName Descending _
                    Select emp

            '  Execute the query and iterate through each
            '  employee name returned and display the 
            '  information.
        For Each emp In query
            Console.WriteLine("  [{0}] {1} {2} {3} {4}", emp.EmployeeID, emp.FirstName, emp.LastName, emp.WorkGroup, emp.HireDate.ToString("MM/dd/yyy"))
        Next

        Console.WriteLine(Environment.NewLine)

    End Sub
    '  Show a list of employees full names (first and
    '  last) and how long (in days) since each was
    '  hired.
    Private Shared Sub SortByFullName()

        Console.WriteLine("List of employees full names and how long since they were hired:")
        Console.WriteLine("  - Ordered by DaysSinceHired (Descending)")
        Console.WriteLine(Environment.NewLine)

        '  Create a query that will return the full name and
        '  number of days since hired for each employee and sort
        '  them by the DaysSinceHired property.  In this case,
        '  query is inferred as IEnumerable(Of <anonymous type>).
        Dim query = From emp In employees _
                    Select DaysSinceHired = DateTime.Now.Subtract(emp.HireDate).Days, _
                    FullName = emp.LastName & ", " & emp.FirstName _
                    Order By DaysSinceHired Descending

        '  Execute the query and iterate through each
        '  object returned and display the information.
        For Each emp In query
            Console.WriteLine("  {0} was hired {1} day(s) ago.", emp.FullName, emp.DaysSinceHired)
        Next

        Console.WriteLine(Environment.NewLine)

    End Sub
    Public Shared Sub Main()

        '  Call each sample method that demonstrates sorting
        '  with LINQ expressions.
        Call SortByLastName()
        Call SortByFullName()

        Console.WriteLine("End of samples reached.  Press Enter.")
        Console.ReadLine()

    End Sub

End Class