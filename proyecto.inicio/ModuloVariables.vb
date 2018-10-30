Module ModuloVariables
    Public MontoTotal As String

    Public precioeliminado As Double

    Public numeroprov As Integer

    'Suponiendo que tienes una propiedad publica que se llama
    Public Property NivelAcceso As Integer

    Public Sub Validaciones()
        Select Case NivelAcceso
            Case "Dueños"
                If NivelAcceso = "Dueños" Then
                    ' .TabUsuarios.Enabled = False
                    'Resto de acciones permitidas
                End If


            Case "Gerentes"
                'Reglas para el Miembro

            Case "Empleado"
                'Reglas para el Invitado
        End Select
    End Sub
End Module
