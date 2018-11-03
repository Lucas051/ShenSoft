Public Class EstadisticasProv

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If (CBConsultas.Text = "Proveedor al que le debemos más y nuestras compras realizadas a él") Then
            Try
                Consulta = "SELECT nombre_prov as 'Nombre del Proveedor',max(saldo_p) as 'Dueda', count(F.num_prov) as 'Numero de Compras' from proveedores P inner join factura_prov F on P.num_prov=F.num_prov;"
                consultar()
                dgvconsultas.DataSource = resultado


            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        End If
    End Sub

    Private Sub EstadisticasProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CBConsultas.Items.Add("Proveedor al que le debemos más y nuestras compras realizadas a él")

    End Sub
End Class