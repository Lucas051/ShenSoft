Imports MySql.Data.MySqlClient
Public Class BuscarClientesCobrar

    Private Sub BuscarClientesCobrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexioon.Consulta = "SELECT * FROM clientes"
        consultar()
        DGVbuscarclientes.DataSource = resultado

        'Nombramos los encabezados del datagrid buscar

        DGVbuscarclientes.Columns(0).HeaderText = "Num. Cliente"
        DGVbuscarclientes.Columns(1).HeaderText = "CI"
        DGVbuscarclientes.Columns(2).HeaderText = "Nombre"
        DGVbuscarclientes.Columns(3).HeaderText = "Dirección"
        DGVbuscarclientes.Columns(4).HeaderText = "Telefono"
        DGVbuscarclientes.Columns(5).HeaderText = "Saldo"
    End Sub
    Private Sub btnmini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmini.Click
        'minimiza ventana
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnmaxi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmaxi.Click
        'maximiza ventana
        Me.WindowState = FormWindowState.Maximized
        'esconde boton, aparece restaurar
        btnmaxi.Visible = False
        btnrestaurar.Visible = True
    End Sub

    Private Sub btnrestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrestaurar.Click
        'restaura ventana
        Me.WindowState = FormWindowState.Normal
        'esconde boton, aparece maximizar
        btnrestaurar.Visible = False
        btnmaxi.Visible = True
    End Sub

    Private Sub cerrarbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cerrarbtn.Click
        End
    End Sub

    Private Sub DGVbuscarclientes_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVbuscarclientes.CellClick
        'Mediante el evento indicamos hacia donde van los valores seleccionados
        Cobrar.txtclientes.Text = DGVbuscarclientes.CurrentRow.Cells(2).Value.ToString

        'close para cerrar el form
        Me.Hide()
        Cobrar.Show()
    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        Me.Hide()
        Cobrar.Show()

    End Sub
End Class