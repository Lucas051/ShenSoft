Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Module ModuloVariables
    Public MontoTotal As String

    Public precioeliminado As Double

    Public numeroprov As Integer

    'Suponiendo que tienes una propiedad publica que se llama
    Public Property NivelAcceso As String

    Public Sub Validaciones()
        Select Case NivelAcceso
            Case "Dueños"
                If NivelAcceso = "Dueños" Then
                    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=Dueños;password=456;database=lapolleriabd")
                    ' .TabUsuarios.Enabled = False
                    'Resto de acciones permitidas
                End If


            Case "Gerentes"
                If NivelAcceso = "Gerentes" Then
                    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=Gerentes;password=963;database=lapolleriabd")
                    ' .TabUsuarios.Enabled = False
                    'Resto de acciones permitidas
                End If

            Case "Empleado"
                If NivelAcceso = "Empleado" Then
                    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=Empleado;password=123;database=lapolleriabd")
                    ' .TabUsuarios.Enabled = False
                    'Resto de acciones permitidas
                End If
        End Select
    End Sub
End Module
