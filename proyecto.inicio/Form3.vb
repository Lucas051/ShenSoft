Imports MySql.Data.MySqlClient
Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


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
        'Nombramos los encabezados del datagrid buscar
        DataGridbuscar.Columns(0).HeaderText = "Código"
        DataGridbuscar.Columns(1).HeaderText = "Descrip."
        DataGridbuscar.Columns(2).HeaderText = "Cantidad"
        DataGridbuscar.Columns(3).HeaderText = "Precio Costo"
        DataGridbuscar.Columns(4).HeaderText = "Precio Venta"
        DataGridbuscar.Columns(5).HeaderText = "Proveedor"
    End Sub

    Private Sub atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atras.Click
        Me.Hide()
        RealizarFactura.Show()
    End Sub
End Class