Public Class FacturasProveedores

    Private Sub FacturasProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conexioon.Consulta = "SELECT * FROM factura_prov;"
            consultar()
            dgvFacturasProv.DataSource = resultado

            dgvFacturasProv.Columns(0).HeaderText = "N° Factura"
            dgvFacturasProv.Columns(1).HeaderText = "Fecha"
            dgvFacturasProv.Columns(2).HeaderText = "N° Proveedor"
            dgvFacturasProv.Columns(3).HeaderText = "Monto"

            'ancho de columnas dgv
            dgvFacturasProv.Columns(0).Width = 100
            dgvFacturasProv.Columns(1).Width = 200
            dgvFacturasProv.Columns(2).Width = 200
            dgvFacturasProv.Columns(3).Width = 200
        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
      
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Try
            conexioon.Consulta = "INSERT INTO factura_prov(num_prov, monto) VALUES ('" + txtproveedor.Text + "','" + txtmonto.Text + "');"
            consultar()
            dgvFacturasProv.DataSource = resultado

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try

        Try
            conexioon.Consulta = "SELECT * FROM factura_prov;"
            consultar()
            dgvFacturasProv.DataSource = resultado

            dgvFacturasProv.Columns(0).HeaderText = "N° Factura"
            dgvFacturasProv.Columns(1).HeaderText = "Fecha"
            dgvFacturasProv.Columns(2).HeaderText = "N° Proveedor"
            dgvFacturasProv.Columns(3).HeaderText = "Monto"

            'ancho de columnas dgv
            dgvFacturasProv.Columns(0).Width = 100
            dgvFacturasProv.Columns(1).Width = 200
            dgvFacturasProv.Columns(2).Width = 200
            dgvFacturasProv.Columns(3).Width = 200
        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        BuscarProv.Show()

    End Sub
End Class