Imports MySql.Data.MySqlClient

Public Class EliminarSotck

   Private Sub EliminarStock_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim conexion As MySqlConnection
        Dim comando As MySqlCommand
        Dim sql As String

        conexion = conn
        sql = "SELECT * FROM stock"
        
        comando = New MySqlCommand(sql, conexion)
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(comando)
        da.Fill(dt)
        dgvEliminar.DataSource = dt
        conexion.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Stock_de_Productos.Show()

    End Sub

    Private Sub dgvEliminar_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEliminar.CellContentClick






    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

    End Sub
End Class
