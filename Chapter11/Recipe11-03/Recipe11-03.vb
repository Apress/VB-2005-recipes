Imports System.Security
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_03

        '  A method to turn on execution permission checking
        '  and persist the change.
        Public Sub ExecutionCheckOn()
            '  Turn on CAS checks.
            SecurityManager.CheckExecutionRights = True

            '  Persist the configuration change.
            SecurityManager.SavePolicy()

        End Sub
        '  A method to turn off execution permission checking
        '  and persist the change.
        Public Sub ExecutionCheckOff()
            '  Turn on CAS checks.
            SecurityManager.CheckExecutionRights = False

            '  Persist the configuration change.
            SecurityManager.SavePolicy()

        End Sub

    End Class
End Namespace