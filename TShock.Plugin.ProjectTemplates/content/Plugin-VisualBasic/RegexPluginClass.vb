Imports Terraria
Imports TerrariaApi.Server

<ApiVersion(2, 1)>
Public Class Plugin.ClassName 
    Inherits TerrariaPlugin
    Public Overrides ReadOnly Property Name As String = "Plugin.Namespace"
    Public Overrides ReadOnly Property Author As String = MyBase.Author
    Public Overrides ReadOnly Property Description As String = MyBase.Description
    Public Overrides ReadOnly Property Version As Version = New Version(1, 0)

    Public Sub New(game As Main)
        MyBase.New(game)
    End Sub

    Public Overrides Sub Initialize()

    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then

        End If
    End Sub
End Class
