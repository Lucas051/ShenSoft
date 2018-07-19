Public Class Facturacion

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        RealizarFactura.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        ConsultaFactura.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub Facturacion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class