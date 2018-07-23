Public Class Cobrar

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        RealizarFactura.Show()
    End Sub

    Private Sub buscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarCliente.Click
        Me.Hide()
        BuscarClientesFact.Show()

    End Sub
End Class