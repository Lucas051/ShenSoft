Public Class EstadisticaStock

    Private Sub EstadisticaStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CBConsultas.Items.Add("Productos que no han ingresado en Enero")
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If (CBConsultas.Text = "Productos que no han ingresado en Enero") Then
            Try
                Consulta = "SELECT * from stock where cod_producto not in(SELECT cod_producto from stock S inner join factura_prov F on S.n_factura_prov=F.n_factura_prov where month(fecha_p)=01);"
                consultar()
                dgvconsultas.DataSource = resultado


            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub
End Class