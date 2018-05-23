Imports MySql.Data.MySqlClient

Public Class EliminarSotck

   Private Sub EliminarStock_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        DataGridView1.DataSource = dt
        conexion.Clone()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Stock_de_Productos.Show()

    End Sub
End Class
