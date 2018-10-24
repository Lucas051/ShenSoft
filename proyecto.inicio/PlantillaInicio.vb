Public Class PlantillaInicio

    Private Sub PlantillaInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TimerHora.Start()
        DTPickerFecha.Visible = False
    End Sub
    Private Sub TimerHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerHora.Tick
        Dim fecha As String
        fecha = DTPickerFecha.Text
        lblFecha.Text = fecha

        lblHora.Text = TimeOfDay.TimeOfDay.ToString
        TimerHora.Enabled = True
        '////////////////////////////////////////////
        lblHora.Text = Format(DateAndTime.TimeOfDay, "hh") & ":"
        lblMinuto.Text = Format(DateAndTime.TimeOfDay, "mm")
    End Sub

End Class