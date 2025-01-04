Imports Terraria
Imports TerrariaApi.Server

<ApiVersion(2, 1)>
Public Class Plugin 
    Inherits TerrariaPlugin
    Public Overrides ReadOnly Property Name As String = "Plugin.Namespace"
    Public Overrides ReadOnly Property Author As String = "Plugin.Author"
    Public Overrides ReadOnly Property Description As String = "Plugin.Description"
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
