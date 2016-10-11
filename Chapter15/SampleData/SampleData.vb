Option Infer On

Imports System
'  A class that represents an Employee.
Public Class Employee

    Private m_EmployeeID As Integer = 0
    Private m_FirstName As String = String.Empty
    Private m_LastName As String = String.Empty
    Private m_WorkGroup As String = String.Empty
    Private m_HireDate As DateTime = DateTime.MinValue
    Private m_HourlyWage As Decimal = 0
    Public Property EmployeeID() As Integer
        Get
            Return m_EmployeeID
        End Get
        Set(ByVal value As Integer)
            m_EmployeeID = value
        End Set
    End Property
    Public Property FirstName() As String
        Get
            Return m_FirstName
        End Get
        Set(ByVal value As String)
            m_FirstName = value
        End Set
    End Property
    Public Property LastName() As String
        Get
            Return m_LastName
        End Get
        Set(ByVal value As String)
            m_LastName = value
        End Set
    End Property
    Public Property WorkGroup() As String
        Get
            Return m_WorkGroup
        End Get
        Set(ByVal value As String)
            m_WorkGroup = value
        End Set
    End Property
    Public Property HireDate() As DateTime
        Get
            Return m_HireDate
        End Get
        Set(ByVal value As DateTime)
            m_HireDate = value
        End Set
    End Property
    Public Property HourlyWage() As Decimal
        Get
            Return m_HourlyWage
        End Get
        Set(ByVal value As Decimal)
            m_HourlyWage = value
        End Set
    End Property
End Class
Public Class Task

    Public Enum TaskStatus
        Open = 0
        Closed = 1
    End Enum
    Private m_TaskID As Integer = 0
    Private m_Title As String = String.Empty
    Private m_Status As TaskStatus = 0
    Private m_EmployeeID As Integer = 0
    Public Property TaskID() As Integer
        Get
            Return m_TaskID
        End Get
        Set(ByVal value As Integer)
            m_TaskID = value
        End Set
    End Property
    Public Property Title() As String
        Get
            Return m_Title
        End Get
        Set(ByVal value As String)
            m_Title = value
        End Set
    End Property
    Public Property Status() As TaskStatus
        Get
            Return m_Status
        End Get
        Set(ByVal value As TaskStatus)
            m_Status = value
        End Set
    End Property
    Public Property EmployeeID() As Integer
        Get
            Return m_EmployeeID
        End Get
        Set(ByVal value As Integer)
            m_EmployeeID = value
        End Set
    End Property
End Class
Public Class HelperMethods

    '  Return a strongly typed collection of Employee objects.
    Public Shared Function GetEmployees() As List(Of Employee)

        '  Create a List to hold employees
        Dim employeeList As New List(Of Employee)

        '  Create several employee objects (using object initializers) that
        '  will be the basis of our sample Employee data.
        employeeList.Add(New Employee With {.EmployeeID = 1, .FirstName = "Todd", .LastName = "Herman", .WorkGroup = "Developer", .HireDate = DateTime.Now.AddDays(-25), .HourlyWage = 55.0})
        employeeList.Add(New Employee With {.EmployeeID = 2, .FirstName = "Robb", .LastName = "Smith", .WorkGroup = "Developer", .HireDate = DateTime.Now.AddMonths(-10), .HourlyWage = 100.75})
        employeeList.Add(New Employee With {.EmployeeID = 3, .FirstName = "Dick", .LastName = "Edwards", .WorkGroup = "Manager", .HireDate = DateTime.Now.AddYears(-6), .HourlyWage = 100.1})
        employeeList.Add(New Employee With {.EmployeeID = 4, .FirstName = "Kevin", .LastName = "Jones", .WorkGroup = "Technical Support Engineer", .HireDate = DateTime.Now.AddDays(-25), .HourlyWage = 85.35})
        employeeList.Add(New Employee With {.EmployeeID = 5, .FirstName = "Mike", .LastName = "Newtron", .WorkGroup = "Developer", .HireDate = DateTime.Now.AddMonths(-17), .HourlyWage = 19.99})
        employeeList.Add(New Employee With {.EmployeeID = 6, .FirstName = "Harry", .LastName = "Dresden", .WorkGroup = "Technical Support Engineer", .HireDate = DateTime.Now.AddDays(-65), .HourlyWage = 75.85})
        employeeList.Add(New Employee With {.EmployeeID = 7, .FirstName = "Jason", .LastName = "Holmes", .WorkGroup = "Supervisor", .HireDate = DateTime.Now.AddDays(-1), .HourlyWage = 65.5})
        employeeList.Add(New Employee With {.EmployeeID = 8, .FirstName = "Dave", .LastName = "Turner", .WorkGroup = "Engineer", .HireDate = DateTime.Now.AddMonths(-55), .HourlyWage = 10.75})
        employeeList.Add(New Employee With {.EmployeeID = 9, .FirstName = "Alex", .LastName = "Simpson", .WorkGroup = "Engineer", .HireDate = DateTime.Now.AddDays(-5), .HourlyWage = 40.15})
        employeeList.Add(New Employee With {.EmployeeID = 10, .FirstName = "Vicky", .LastName = "Bobby", .WorkGroup = "Technical Support Engineer", .HireDate = DateTime.Now.AddDays(-300), .HourlyWage = 200.0})
        employeeList.Add(New Employee With {.EmployeeID = 11, .FirstName = "Ardy", .LastName = "Reznor", .WorkGroup = "Technical Support Engineer", .HireDate = DateTime.Now.AddYears(-15), .HourlyWage = 25.5})

        '  Return the List
        Return employeeList

    End Function
    '  Return a strongly typed collection of Employee objects.
    Public Shared Function GetEmployees2() As ArrayList

        '  Create a List to hold employees
        Dim employeeList As New ArrayList

        '  Create several employee objects (using object initializers) that
        '  will be the basis of our sample Employee data.
        employeeList.Add(New Employee With {.EmployeeID = 1, .FirstName = "Todd", .LastName = "Herman", .WorkGroup = "Developer", .HireDate = DateTime.Now.AddDays(-25), .HourlyWage = 55.0})
        employeeList.Add(New Employee With {.EmployeeID = 2, .FirstName = "Robb", .LastName = "Smith", .WorkGroup = "Developer", .HireDate = DateTime.Now.AddMonths(-10), .HourlyWage = 100.75})
        employeeList.Add(New Employee With {.EmployeeID = 3, .FirstName = "Dick", .LastName = "Edwards", .WorkGroup = "Manager", .HireDate = DateTime.Now.AddYears(-6), .HourlyWage = 100.1})
        employeeList.Add(New Employee With {.EmployeeID = 4, .FirstName = "Kevin", .LastName = "Jones", .WorkGroup = "Technical Support Engineer", .HireDate = DateTime.Now.AddDays(-25), .HourlyWage = 85.35})
        employeeList.Add(New Employee With {.EmployeeID = 5, .FirstName = "Mike", .LastName = "Newtron", .WorkGroup = "Developer", .HireDate = DateTime.Now.AddMonths(-17), .HourlyWage = 19.99})
        employeeList.Add(New Employee With {.EmployeeID = 6, .FirstName = "Harry", .LastName = "Dresden", .WorkGroup = "Technical Support Engineer", .HireDate = DateTime.Now.AddDays(-65), .HourlyWage = 75.85})
        employeeList.Add(New Employee With {.EmployeeID = 7, .FirstName = "Jason", .LastName = "Holmes", .WorkGroup = "Supervisor", .HireDate = DateTime.Now.AddDays(-1), .HourlyWage = 65.5})
        employeeList.Add(New Employee With {.EmployeeID = 8, .FirstName = "Dave", .LastName = "Turner", .WorkGroup = "Engineer", .HireDate = DateTime.Now.AddMonths(-55), .HourlyWage = 10.75})
        employeeList.Add(New Employee With {.EmployeeID = 9, .FirstName = "Alex", .LastName = "Simpson", .WorkGroup = "Engineer", .HireDate = DateTime.Now.AddDays(-5), .HourlyWage = 40.15})
        employeeList.Add(New Employee With {.EmployeeID = 10, .FirstName = "Vicky", .LastName = "Bobby", .WorkGroup = "Technical Support Engineer", .HireDate = DateTime.Now.AddDays(-300), .HourlyWage = 200.0})
        employeeList.Add(New Employee With {.EmployeeID = 11, .FirstName = "Ardy", .LastName = "Reznor", .WorkGroup = "Technical Support Engineer", .HireDate = DateTime.Now.AddYears(-15), .HourlyWage = 25.5})

        '  Return the List
        Return employeeList

    End Function
    '  Return a strongly typed collection of Task objects.
    Public Shared Function GetTasks() As List(Of Task)

        '  Create a List to hold taasks
        Dim taskList As New List(Of Task)

        '  Create several task objects (using object initializers) that
        '  will be the basis of our sample Task data.
        taskList.Add(New Task With {.TaskID = 1, .EmployeeID = 1, .Status = Task.TaskStatus.Open, .Title = "Sample Task 1"})
        taskList.Add(New Task With {.TaskID = 2, .EmployeeID = 3, .Status = Task.TaskStatus.Open, .Title = "Sample Task 2"})
        taskList.Add(New Task With {.TaskID = 3, .EmployeeID = 1, .Status = Task.TaskStatus.Closed, .Title = "Sample Task 3"})
        taskList.Add(New Task With {.TaskID = 4, .EmployeeID = 5, .Status = Task.TaskStatus.Open, .Title = "Sample Task 4"})
        taskList.Add(New Task With {.TaskID = 5, .EmployeeID = 4, .Status = Task.TaskStatus.Closed, .Title = "Sample Task 5"})
        taskList.Add(New Task With {.TaskID = 6, .EmployeeID = 1, .Status = Task.TaskStatus.Open, .Title = "Sample Task 6"})
        taskList.Add(New Task With {.TaskID = 7, .EmployeeID = 11, .Status = Task.TaskStatus.Closed, .Title = "Sample Task 7"})
        taskList.Add(New Task With {.TaskID = 8, .EmployeeID = 2, .Status = Task.TaskStatus.Open, .Title = "Sample Task 8"})
        taskList.Add(New Task With {.TaskID = 9, .EmployeeID = 8, .Status = Task.TaskStatus.Open, .Title = "Sample Task 9"})
        taskList.Add(New Task With {.TaskID = 10, .EmployeeID = 2, .Status = Task.TaskStatus.Closed, .Title = "Sample Task 10"})
        taskList.Add(New Task With {.TaskID = 11, .EmployeeID = 9, .Status = Task.TaskStatus.Open, .Title = "Sample Task 11"})
        taskList.Add(New Task With {.TaskID = 12, .EmployeeID = 1, .Status = Task.TaskStatus.Open, .Title = "Sample Task 12"})
        taskList.Add(New Task With {.TaskID = 13, .EmployeeID = 5, .Status = Task.TaskStatus.Closed, .Title = "Sample Task 13"})
        taskList.Add(New Task With {.TaskID = 14, .EmployeeID = 10, .Status = Task.TaskStatus.Closed, .Title = "Sample Task 14"})
        taskList.Add(New Task With {.TaskID = 15, .EmployeeID = 6, .Status = Task.TaskStatus.Open, .Title = "Sample Task 15"})

        '  Return the List
        Return taskList

    End Function

End Class