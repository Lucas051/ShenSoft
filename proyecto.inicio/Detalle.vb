Public Class Detalle

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Detalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Try

            Consulta = "SELECT cod_producto, descripcion, cantidad, precio_v FROM genera where n_factura='" + lblseleccionada.Text + "';"
            consultar()
            dgvdetalle.DataSource = resultado

            'Nombramos los encabezados del datagrid buscar

            dgvdetalle.Columns(0).HeaderText = "Código Producto"
            dgvdetalle.Columns(1).HeaderText = "Descripción"
            dgvdetalle.Columns(2).HeaderText = "Cantidad"
            dgvdetalle.Columns(3).HeaderText = "Precio Venta"

            'ancho de columnas dgv
            dgvdetalle.Columns(0).Width = 150
            dgvdetalle.Columns(1).Width = 200
            dgvdetalle.Columns(2).Width = 100
            dgvdetalle.Columns(3).Width = 200

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class