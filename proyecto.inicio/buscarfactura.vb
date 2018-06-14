Imports MySql.Data.MySqlClient
Public Class buscarfactura

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'realizamos conexion a stock
        Dim conexion As New MySqlConnection
        Dim comando As MySqlCommand
        Dim sql As String

        'conexion = conn
        sql = "SELECT * FROM stock"
        conexion.Open()

        comando = New MySqlCommand(sql, conexion)
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(comando)
        da.Fill(dt)
        DataGridbuscar.DataSource = dt
        conexion.Close()
        'Nombramos los encabezados del datagrid buscar
        'Te Arregle una fallita que tenias habias puesto hasta 5 columnas y eran 4 te borre cantidad que eso no tengo yo pasa el sql -Nacho
        DataGridbuscar.Columns(0).HeaderText = "Código"
        DataGridbuscar.Columns(1).HeaderText = "Descrip."
        DataGridbuscar.Columns(2).HeaderText = "Precio Costo"
        DataGridbuscar.Columns(3).HeaderText = "Precio Venta"
        DataGridbuscar.Columns(4).HeaderText = "Proveedor"
    End Sub

    Private Sub atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atras.Click
        Me.Hide()
        RealizarFactura.Show()
    End Sub

    Private Sub DataGridbuscar_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridbuscar.CellClick
        'Mediante el evento indicamos hacia donde van los valores seleccionados
        RealizarFactura.codigo.Text = DataGridbuscar.CurrentRow.Cells(0).Value.ToString
        RealizarFactura.desc.Text = DataGridbuscar.CurrentRow.Cells(1).Value.ToString
        RealizarFactura.cant.Text = DataGridbuscar.CurrentRow.Cells(2).Value.ToString
        RealizarFactura.precioov.Text = DataGridbuscar.CurrentRow.Cells(4).Value.ToString
        'close para cerrar el form
        Close()
        RealizarFactura.Show()

    End Sub
End Class