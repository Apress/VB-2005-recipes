Imports System.Security
Namespace Apress.VisualBasicRecipes.Chapter11

    Public Class Recipe11_02
        '  A method to turn on CAS and persis the change.
        Public Sub CasOn()
            '  Turn on CAS checks.
            SecurityManager.SecurityEnabled = True

            '  Persist the configuration change.
            SecurityManager.SavePolicy()

        End Sub
        '  A method to turn off CAS and persis the change.
        Public Sub CasOff()
            '  Turn off CAS checks.
            SecurityManager.SecurityEnabled = False

            '  Persist the configuration change.
            SecurityManager.SavePolicy()

        End Sub

    End Class
End Namespace