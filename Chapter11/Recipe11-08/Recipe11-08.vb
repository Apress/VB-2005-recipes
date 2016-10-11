Imports System.Security.Permissions
Namespace Apress.VisualBasicRecipes.Chapter11

    <PublisherIdentityPermission(SecurityAction.InheritanceDemand, CertFile:="pubcert.cer")> _
    Public Class Recipe11_08

        <PermissionSet(SecurityAction.InheritanceDemand, Name:="FullTrust")> _
        Public Sub SomeProtectedMethod()
            '  Method implementation...
        End Sub

    End Class
End Namespace
