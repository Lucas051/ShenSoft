Imports MySql.Data.MySqlClient

Public Class EliminarSotck

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim sql As String
        Dim conexion As New MySqlConnection
        Dim comando As MySqlCommand

        conexion = conn
        sql = "SELECT * FROM stock"
        conexion.Open()
        comando = New MySqlCommand(sql, conexion)
        DataGridView1 = comando.ToString












    End Sub
End Class