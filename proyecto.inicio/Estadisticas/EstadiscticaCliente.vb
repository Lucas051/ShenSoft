Public Class EstadiscticaCliente

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If (CBConsultas.Text = "Cliente con mayor deuda y sus compras realizadas") Then
            Try
                Consulta = "SELECT nombre_cliente as 'Nombre del Cliente',max(saldo_c) as 'Dueda', count(F.num_cliente) as 'Numero de Compras' from clientes C inner join facturas F on C.num_cliente=F.num_cliente;"
                consultar()
                dgvconsultas.DataSource = resultado


            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        End If
    End Sub

    Private Sub EstadiscticaCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CBConsultas.Items.Add("Cliente con mayor deuda y sus compras realizadas")

    End Sub
End Class