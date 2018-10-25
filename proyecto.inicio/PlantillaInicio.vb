Public Class PlantillaInicio

    Private Sub PlantillaInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DTPickerFecha.Visible = False
        TimerHora.Start()
        TimerAMPM.Start()
        TimerFecha.Start()
        DTPickerFecha.Visible = False
    End Sub
    Private Sub TimerHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerHora.Tick

        lblHora.Text = Format(DateAndTime.TimeOfDay, "hh") & ":"
        lblMinuto.Text = Format(DateAndTime.TimeOfDay, "mm")
        lblSegundos.Text = Format(DateAndTime.TimeOfDay, "ss")
    End Sub

    Private Sub TimerAMPM_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerAMPM.Tick
        If Val(lblHora.Text) > 12 Then
            lblAMPM.Text = "AM"
        Else
            lblAMPM.Text = "PM"
        End If
    End Sub

    Private Sub TimerFecha_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerFecha.Tick
        Dim fecha As String
        fecha = DTPickerFecha.Text
        lblFecha.Text = fecha
    End Sub

    Private Sub lblTelefonos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTelefonos.Click

    End Sub
End Class