Public Class PagosProv

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        Dim llamar1 As New GestionFacturacion
        Inicio.panelmedio.Controls.Clear()
        llamar1.TopLevel = False
        llamar1.Parent = Inicio.panelmedio
        llamar1.Show()
        llamar1.Dock = DockStyle.Fill
        Inicio.panelmedio.Visible = True
    End Sub

    Private Sub PagosProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conexioon.Consulta = "SELECT PP.num_recibo_p, PP.fecha, PP.importe, PP.num_prov, P.nombre_prov, PP.numero_recibo_fisico_p FROM pagos_prov PP inner join proveedores P on PP.num_prov=P.num_prov;"
            consultar()
            dgvproveedores.DataSource = resultado

            dgvproveedores.Columns(0).HeaderText = "ID"
            dgvproveedores.Columns(1).HeaderText = "Fecha"
            dgvproveedores.Columns(2).HeaderText = "Importe"
            dgvproveedores.Columns(3).HeaderText = "N° Proveedor"
            dgvproveedores.Columns(4).HeaderText = "Nom. Proveedor"
            dgvproveedores.Columns(5).HeaderText = "N° Recibo"

            'ancho de columnas dgv
            dgvproveedores.Columns(0).Width = 60
            dgvproveedores.Columns(1).Width = 100
            dgvproveedores.Columns(3).Width = 100
            dgvproveedores.Columns(4).Width = 150

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txtBuscarP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarP.TextChanged
        Try
            'BUSQUEDA DINAMICA EN DATAGRIDVIEW
            conexioon.Consulta = "SELECT * FROM proveedores WHERE nombre_prov LIKE '%" & txtBuscarP.Text & "%';"
            consultar()
            dgvproveedores.DataSource = resultado

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

 
    Private Sub btnBuscarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarProv.Click
        BuscarProv.Show()

    End Sub


    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        Try
            conexioon.Consulta = "INSERT INTO pagos_prov (importe, num_prov, numero_recibo_fisico_p) VALUES ('" + txtImporte.Text + "','" + txtProveedor.Text + "','" + TXTnrecibofisico.Text + "');"
            consultar()

            'usamos los parametros para msgbox 
            Dim opcion As DialogResult
            opcion = MessageBox.Show("Pago ingresado!", "INGRESO COMPLETADO")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            conexioon.Consulta = "UPDATE proveedores SET saldo_p = saldo_p - " + txtImporte.Text + " WHERE num_prov=" + txtProveedor.Text + ";"
            consultar()

            'usamos los parametros para msgbox 
            Dim opcion As DialogResult
            opcion = MessageBox.Show("Saldo restado!", "INGRESO COMPLETADO")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            conexioon.Consulta = "SELECT * FROM pagos_prov;"
            consultar()
            dgvproveedores.DataSource = resultado


            dgvproveedores.Columns(0).HeaderText = "ID"
            dgvproveedores.Columns(1).HeaderText = "Fecha"
            dgvproveedores.Columns(2).HeaderText = "Importe"
            dgvproveedores.Columns(3).HeaderText = "N° Proveedor"
            dgvproveedores.Columns(4).HeaderText = "Nom. Proveedor"
            dgvproveedores.Columns(5).HeaderText = "N° Recibo"

            'ancho de columnas dgv
            dgvproveedores.Columns(0).Width = 60
            dgvproveedores.Columns(1).Width = 200
            dgvproveedores.Columns(3).Width = 150
            dgvproveedores.Columns(4).Width = 70

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class