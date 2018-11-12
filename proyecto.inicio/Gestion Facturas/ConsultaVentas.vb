Public Class ConsultaVentas

    Private Sub ConsultaVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Consulta = "SELECT F.n_factura, F.fecha, F.monto, F.forma_de_pago, C.nombre_cliente, V.nombre_vendedor FROM facturas F inner join clientes C on F.num_cliente=C.num_cliente inner join vendedores V on F.id_vendedor=V.id_vendedor where monto <> 0"
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
        dgvConsultaFacturas.Columns(5).HeaderText = "Vendedor"

        'ancho de columnas dgv
        dgvConsultaFacturas.Columns(0).Width = 100
        dgvConsultaFacturas.Columns(1).Width = 150
        dgvConsultaFacturas.Columns(2).Width = 120
        dgvConsultaFacturas.Columns(3).Width = 100
        dgvConsultaFacturas.Columns(4).Width = 100
        dgvConsultaFacturas.Columns(5).Width = 100
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
        If Not String.IsNullOrEmpty(txtposicion.Text) Then

            posicion = CDbl(txtposicion.Text)

        End If
        Detalle.lblseleccionada.Text = posicion
        Detalle.Show()
    End Sub

    Private Sub txtposicion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtposicion.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class