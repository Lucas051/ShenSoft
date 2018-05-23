Imports MySql.Data.MySqlClient
Public Class BuscarProducto

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        RealizarFactura.Show()
    End Sub

    Private Sub BuscarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conexion As New MySqlConnection
        Dim comando As MySqlCommand
        Dim sql As String

        conexion = conn
        sql = "SELECT * FROM stock" 'mira esto nacho
        conexion.Open()

        comando = New MySqlCommand(sql, conexion)
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(comando)
        da.Fill(dt)
        DataGridbuscar.DataSource = dt
        conexion.Clone()
    End Sub

    Private Sub ingdatos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ingdatos.TextChanged
        If Filtro(ingdatos.Text).Rows.Count > 0 Then
            DataGridbuscar.DataSource = Filtro(ingdatos.Text)

        End If

    End Sub

    Function Filtro(ByVal busqueda As String) As DataTable
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter("SELECT * FROM stock WHERE descripcion LIKE '%'" + ingdatos.Text + "'%'", conn)
        da.Fill(dt)
        Return dt
    End Function

End Class
