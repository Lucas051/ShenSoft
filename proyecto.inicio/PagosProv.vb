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
            conexioon.Consulta = "SELECT * FROM proveedores;"
            consultar()
            dgvproveedores.DataSource = resultado

            dgvproveedores.Columns(0).HeaderText = "ID"
            dgvproveedores.Columns(1).HeaderText = "Proveedor"
            dgvproveedores.Columns(2).HeaderText = "Teléfono"
            dgvproveedores.Columns(3).HeaderText = "Dirección"
            dgvproveedores.Columns(4).HeaderText = "Saldo"

            'ancho de columnas dgv
            dgvproveedores.Columns(0).Width = 60
            dgvproveedores.Columns(1).Width = 200
            dgvproveedores.Columns(3).Width = 150
            dgvproveedores.Columns(4).Width = 70

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
End Class