Public Class EstadisticaVentas

    Private Sub EstadisticaVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

        CBConsultas.Items.Add("Productos más vendido")
        CBConsultas.Items.Add("Productos menos vendido")
        CBConsultas.Items.Add("Productos que aún no se han vendido")
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If (CBConsultas.Text = "Productos que aún no se han vendido") Then
            Try
                Consulta = "SELECT * FROM stock WHERE cod_producto not in(SELECT cod_producto from genera);"
                consultar()
                dgvconsultas.DataSource = resultado


            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        ElseIf (CBConsultas.Text = "Productos más vendido") Then
            Try
                Consulta = "select *, sum(cantidad) as 'Cantidad Total' from genera group by cod_producto;"
                consultar()
                dgvconsultas.DataSource = resultado

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub
End Class