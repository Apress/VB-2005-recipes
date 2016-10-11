Imports System
Imports System.Linq
Public Class Recipe15_10

    Public Shared employees As List(Of SampleData.Employee) = SampleData.HelperMethods.GetEmployees
    Private Shared Sub ShowMaxWage()

        '  Create a query that executes immediately and returns
        '  the maximum hourly wage.
        Dim wageMax = (From emp In employees _
                    Select emp.HourlyWage).Max

        Console.WriteLine("Maximum Hourly Wage:  {0}", wageMax.ToString("$###.#0"))

    End Sub
    Private Shared Sub ShowMinWage()

        '  Create a query that executes immediately and returns
        '  the minimum hourly wage.
        Dim wageMin = (From emp In employees _
                       Select emp.HourlyWage).Min

        Console.WriteLine("Minimum Hourly Wage:  {0}", wageMin.ToString("$###.#0"))

    End Sub
    Private Shared Sub ShowWageSum()

        '  Create a query that executes immediately and returns
        '  the sum of all wages.
        Dim wageSum = (From emp In employees _
                       Select emp.HourlyWage).Sum

        Console.WriteLine("Total Wage:  {0}", wageSum.ToString("$###.#0"))

    End Sub
    Private Shared Sub ShowAvgWage()

        '  Create a query that executes immediately and returns
        '  the average hourly wage.
        Dim wageAvg = (From emp In employees _
                       Select emp.HourlyWage).Average

        Console.WriteLine("Average Wage:  {0}", wageAvg.ToString("$###.#0"))

    End Sub
    Private Shared Sub HiredThisYear()

        '  Create a query that executes immediately and returns
        '  the number of employees that were hired in the current
        '  year.
        Dim cnt = (From emp In employees _
                   Where emp.HireDate.Year = DateTime.Now.Year _
                   Select emp).Count

        Console.WriteLine("{0} employees were hired this year.", cnt.ToString)

    End Sub
    Public Shared Sub Main()

        Call ShowMaxWage()
        Call ShowMinWage()
        Call ShowWageSum()
        Call ShowAvgWage()
        Call HiredThisYear()

        Console.WriteLine(Environment.NewLine)
        Console.WriteLine("End of samples reached.  Press Enter.")
        Console.ReadLine()

    End Sub

End Class
