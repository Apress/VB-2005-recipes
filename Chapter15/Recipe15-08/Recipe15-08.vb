Imports System
Imports System.Linq
Public Class Recipe15_08

    '  Load sample data to be used for this recipe.
    Public Shared employees As List(Of SampleData.Employee) = SampleData.HelperMethods.GetEmployees
    '  Show a list of employees that belong to the
    '  "Manager" workgroup.
    Private Shared Sub ListManagers()

        Console.WriteLine("List of Managers:")

        '  Create a query that will return employee objects
        '  that have a WorkGroup value of "Manager".  In this
        '  case, query is inferred as IEnumerable(Of 
        '  SampleData.Employee).
        Dim query = From emp In employees _
                    Where emp.WorkGroup = "Manager" _
                    Select emp

        '  Execute the query and iterate through each
        '  employee name returned and display the 
        '  information.
        For Each emp In query
            Console.WriteLine("  [{0}] {1} {2}", emp.EmployeeID, emp.FirstName, emp.LastName)
        Next

        Console.WriteLine(Environment.NewLine)

    End Sub
    '  Show a list of employees that belong to the
    '  "Technical Support Engineer" workgroup and 
    '  were hired this year.
    Private Shared Sub ListTechEngineers()

        Console.WriteLine("List of Technical Support Engineers hired in {0}:", DateTime.Now.Year.ToString)

        '  Create a query that will return employee objects that
        '  have a WorkGroup value of "Technical Support Engineer"
        '  and were hired sometime this year.    In this case,
        '  query is inferred as IEnumerable(Of SampleData.Employee).
        Dim query = From emp In employees _
                    Where emp.WorkGroup = "Technical Support Engineer" _
                    And emp.HireDate.Year = DateTime.Now.Year _
                    Select emp

        '  Execute the query and iterate through each
        '  employee name returned and display the 
        '  information.
        For Each emp In query
            Console.WriteLine("  [{0}] {1} {2} - Hired on {3}", emp.EmployeeID, emp.FirstName, emp.LastName, emp.HireDate.ToString("MM/dd/yyyy"))
        Next

        Console.WriteLine(Environment.NewLine)

    End Sub
    Public Shared Sub Main()

        '  Call each sample method that demonstrates sorting
        '  with LINQ expressions.
        Call ListManagers()
        Call ListTechEngineers()

        Console.WriteLine("End of samples reached.  Press Enter.")
        Console.ReadLine()

    End Sub

End Class
