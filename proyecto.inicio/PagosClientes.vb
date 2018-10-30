Public Class PagosClientes

    Private Sub btnBuscarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarProv.Click
        BuscarClientesCobrar.Show()

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

    Private Sub PagosClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            conexioon.Consulta = "SELECT PC.num_recibo_c, PC.fecha, PC.num_cliente, C.nombre_cliente, PC.importe FROM pagos_clientes PC inner join clientes C on PC.num_cliente=C.num_cliente;"
            consultar()
            dgvproveedores.DataSource = resultado


            dgvproveedores.Columns(0).HeaderText = "N° Recibo"
            dgvproveedores.Columns(1).HeaderText = "Fecha"
            dgvproveedores.Columns(2).HeaderText = "N° Cliente"
            dgvproveedores.Columns(3).HeaderText = "Nombre Cliente"
            dgvproveedores.Columns(4).HeaderText = "Importe"

            'ancho de columnas dgv
            dgvproveedores.Columns(0).Width = 120
            dgvproveedores.Columns(1).Width = 140
            dgvproveedores.Columns(2).Width = 140
            dgvproveedores.Columns(3).Width = 220
            dgvproveedores.Columns(4).Width = 120

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        Try
            conexioon.Consulta = "INSERT INTO pagos_clientes (num_cliente, importe) VALUES ('" + txtcliente.Text + "','" + txtImporte.Text + "');"
            consultar()

            'usamos los parametros para msgbox 
            Dim opcion As DialogResult
            opcion = MessageBox.Show("Cobrado con éxito!", "INGRESO COMPLETADO")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            conexioon.Consulta = "UPDATE clientes SET saldo_c = saldo_c - " + txtImporte.Text + " WHERE num_cliente=" + txtcliente.Text + ";"
            consultar()

            'usamos los parametros para msgbox 
            Dim opcion As DialogResult
            opcion = MessageBox.Show("Saldo restado!", "INGRESO COMPLETADO")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            conexioon.Consulta = "SELECT PC.num_recibo_c, PC.fecha, PC.num_cliente, C.nombre_cliente, PC.importe FROM pagos_clientes PC inner join clientes C on PC.num_cliente=C.num_cliente;"
            consultar()
            dgvproveedores.DataSource = resultado


            dgvproveedores.Columns(0).HeaderText = "N° Recibo"
            dgvproveedores.Columns(1).HeaderText = "Fecha"
            dgvproveedores.Columns(2).HeaderText = "N° Cliente"
            dgvproveedores.Columns(3).HeaderText = "Nombre Cliente"
            dgvproveedores.Columns(4).HeaderText = "Importe"

            'ancho de columnas dgv
            dgvproveedores.Columns(0).Width = 120
            dgvproveedores.Columns(1).Width = 140
            dgvproveedores.Columns(2).Width = 140
            dgvproveedores.Columns(3).Width = 220
            dgvproveedores.Columns(4).Width = 120

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
    End Sub

  
End Class