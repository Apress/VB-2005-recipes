Imports System
Imports System.Linq
Public Class Recipe15_06

    '  Load sample data to be used for this recipe.
    Public Shared employees As ArrayList = SampleData.HelperMethods.GetEmployees2
    Public Shared Sub EmployeeNames()

        Console.WriteLine("List of employee names:")

        '  Create a query that will simply return all
        '  employee objects.  In this case, query is
        '  inferred as IEnumerable(Of String).
        '  For LINQ to work with an ArrayList, youd need to
        '  ensure you strongly type the iterator.
        Dim query = From emp As SampleData.Employee In employees _
                    Select FullName = emp.LastName & ", " & emp.FirstName


        '  Execute the query and iterate through each
        '  employee object returned and display the 
        '  information.
        For Each name In query
            Console.WriteLine("  {0}", name)
        Next

        Console.WriteLine(Environment.NewLine)

    End Sub
    Public Shared Sub Main()

        '  Call the method that demonstrates using basic
        '  LINQ query expressions over non-generic IEnumerbale
        '  collections.
        Call EmployeeNames()

        Console.WriteLine("End of samples reached.  Press Enter.")
        Console.ReadLine()

    End Sub

End Class
