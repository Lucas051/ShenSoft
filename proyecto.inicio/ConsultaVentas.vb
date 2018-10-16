Public Class ConsultaVentas


    Private Sub ConsultaFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Consulta = "SELECT * FROM facturas"
            consultar()
            dgvConsultaFacturas.DataSource = resultado


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        'Nombramos los encabezados del datagrid buscar

        dgvConsultaFacturas.Columns(0).HeaderText = "N° Factura"
        dgvConsultaFacturas.Columns(1).HeaderText = "Fecha"
        dgvConsultaFacturas.Columns(2).HeaderText = "Monto"
        dgvConsultaFacturas.Columns(3).HeaderText = "Cliente"
        dgvConsultaFacturas.Columns(4).HeaderText = "Forma de Pago"
    End Sub

    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click

    End Sub
End Class