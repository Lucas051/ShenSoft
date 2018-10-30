Module ModuloVariables
    Public MontoTotal As String

    Public precioeliminado As Double

    Public numeroprov As Integer

    'Suponiendo que tienes una propiedad publica que se llama
    Public Property NivelAcceso As Integer

    Public Sub Validaciones()
        Select Case NivelAcceso
            Case 1
                'Reglas para el Administrador

            Case 2
                'Reglas para el Miembro

            Case 3
                'Reglas para el Invitado
        End Select
    End Sub
End Module
