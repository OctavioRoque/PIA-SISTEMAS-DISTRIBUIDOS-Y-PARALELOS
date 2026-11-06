Imports System.EnterpriseServices
Imports System.Reflection

'Nombre de la aplicación COM+
<Assembly: ApplicationName("ComPlusExample")>

'Ensamblado de nombre seguro
<Assembly: AssemblyKeyFile("bin/ComPlusExample.snk")>

<Transaction(TransactionOption.Required)>
Public Class COMPlusServices
    Inherits ServicedComponent

    Public Sub New()
        MyBase.New()
    End Sub

    <AutoComplete()>
    Public Function DoTransaction() As String
        Return "COM+ funciona correctamente"
    End Function
End Class