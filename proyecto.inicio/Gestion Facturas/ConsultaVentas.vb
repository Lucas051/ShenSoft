Public Class ConsultaVentas

    Private Sub ConsultaVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Consulta = "SELECT * FROM facturas where monto <> 0"
            consultar()
            dgvConsultaFacturas.DataSource = resultado


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        ' Nombramos los encabezados del datagrid buscar

        dgvConsultaFacturas.Columns(0).HeaderText = "N° Factura"
        dgvConsultaFacturas.Columns(1).HeaderText = "Fecha"
        dgvConsultaFacturas.Columns(2).HeaderText = "Monto"
        dgvConsultaFacturas.Columns(3).HeaderText = "Forma de Pago"
        dgvConsultaFacturas.Columns(4).HeaderText = "Cliente"

        'ancho de columnas dgv
        dgvConsultaFacturas.Columns(0).Width = 120
        dgvConsultaFacturas.Columns(1).Width = 150
        dgvConsultaFacturas.Columns(2).Width = 120
        dgvConsultaFacturas.Columns(3).Width = 100
        dgvConsultaFacturas.Columns(4).Width = 200
    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        Dim llamar1 As New GestionFacturacion
        Inicio.panelmedio.Controls.Clear()
        llamar1.TopLevel = False
        llamar1.Parent = Inicio.panelmedio
        llamar1.Show()
        llamar1.Dock = DockStyle.Fill
        Inicio.panelmedio.Visible = True

    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click

        Try
            dgvConsultaFacturas.Rows.Remove(dgvConsultaFacturas.CurrentRow)

            Consulta = "UPDATE facturas set monto=0 WHERE n_factura='" + txtposicion.Text + "';"
            consultar()
            MessageBox.Show("Factura Anulada!", "Proceso Completado")


        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try

        Try

            Consulta = "SELECT * FROM facturas where monto <> 0"
            consultar()
            dgvConsultaFacturas.DataSource = resultado


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        ' Nombramos los encabezados del datagrid buscar

        dgvConsultaFacturas.Columns(0).HeaderText = "N° Factura"
        dgvConsultaFacturas.Columns(1).HeaderText = "Fecha"
        dgvConsultaFacturas.Columns(2).HeaderText = "Monto"
        dgvConsultaFacturas.Columns(3).HeaderText = "Forma de Pago"
        dgvConsultaFacturas.Columns(4).HeaderText = "Cliente"

        'ancho de columnas dgv
        dgvConsultaFacturas.Columns(0).Width = 120
        dgvConsultaFacturas.Columns(1).Width = 150
        dgvConsultaFacturas.Columns(2).Width = 120
        dgvConsultaFacturas.Columns(3).Width = 100
        dgvConsultaFacturas.Columns(4).Width = 200
    End Sub

    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        Detalle.Show()
    End Sub
End Class