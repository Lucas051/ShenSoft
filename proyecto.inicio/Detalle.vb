Public Class Detalle

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Detalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' posicion = ConsultaVentas.txtposicion.Text

        Try

            Consulta = "SELECT * FROM genera where n_factura='" + ConsultaVentas.txtposicion.Text + "'"
            consultar()
            dgvdetalle.DataSource = resultado

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class