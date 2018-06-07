Imports MySql.Data.MySqlClient

Public Class RealizarFactura

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridFacturas.CellContentClick

    End Sub

    Private Sub atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atras.Click
        Me.Hide()
        Facturacion.Show()
    End Sub

    Private Sub RealizarFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ocultamos botones y datagrid de busqueda
        DataGridbuscar.Visible = False
        seleccionar.Visible = False
        cancelar.Visible = False

        'realizamos conexion a stock
        Dim conexion As New MySqlConnection
        Dim comando As MySqlCommand
        Dim sql As String

        conexion = conn
        sql = "SELECT * FROM stock"
        conexion.Open()

        comando = New MySqlCommand(sql, conexion)
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(comando)
        da.Fill(dt)
        DataGridbuscar.DataSource = dt
        conexion.Close()
    End Sub

    Private Sub buscarb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarb.Click
        buscarb.Visible = False
        DataGridbuscar.Visible = True
        DataGridFacturas.Visible = False
        seleccionar.Visible = True
        cancelar.Visible = True
        'Nombramos los encabezados del datagrid buscar
        DataGridbuscar.Columns(0).HeaderText = "Código"
        DataGridbuscar.Columns(1).HeaderText = "Descrip."
        DataGridbuscar.Columns(2).HeaderText = "Cantidad"
        DataGridbuscar.Columns(3).HeaderText = "Precio Costo"
        DataGridbuscar.Columns(4).HeaderText = "Precio Venta"
        DataGridbuscar.Columns(5).HeaderText = "Proveedor"
    End Sub

    Private Sub cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelar.Click
        buscarb.Visible = True
        DataGridbuscar.Visible = False
        DataGridFacturas.Visible = True
        seleccionar.Visible = False
        cancelar.Visible = False
    End Sub
End Class