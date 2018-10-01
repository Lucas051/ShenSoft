
Public Class Buscar_proveedores
  
    Private Sub Buscar_proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'CARGAR EL DGV
        Try
            conexioon.Consulta = "SELECT * FROM proveedores;"
            consultar()
            dgvbuscarprov.DataSource = resultado

            dgvbuscarprov.Columns(0).HeaderText = "ID"
            dgvbuscarprov.Columns(1).HeaderText = "Proveedor"
            dgvbuscarprov.Columns(2).HeaderText = "Teléfono"
            dgvbuscarprov.Columns(3).HeaderText = "Dirección"
            dgvbuscarprov.Columns(4).HeaderText = "Saldo"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscarprov.TextChanged
        Try
            'BUSQUEDA EN DATAGRIDVIEW
            conexioon.Consulta = "SELECT * FROM proveedores WHERE nombre_prov LIKE '%" & txtbuscarprov.Text & "%';"
            consultar()
            dgvbuscarprov.DataSource = resultado

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnvolver_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim llamar As New MODIFPROVEEDORES
        Inicio.panelmedio.Controls.Clear()
        llamar.TopLevel = False
        llamar.Parent = Inicio.panelmedio
        llamar.Show()
        llamar.Dock = DockStyle.Fill
        Inicio.panelmedio.Visible = True

    End Sub
End Class