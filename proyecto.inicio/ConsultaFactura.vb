Imports MySql.Data.MySqlClient
Public Class ConsultaFactura
    Private Sub Atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Atras.Click
        Me.Hide()
        Facturacion.Show()

    End Sub

    Private Sub ConsultaFactura_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sql As String
        Dim connect As New MySqlConnection
        Dim comando As MySqlCommand

        'connect = conn
        sql = "SELECT * FROM facturas"
        connect.Open()
        comando = New MySqlCommand(sql, connect)
        comando.ExecuteNonQuery()

        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(comando)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        connect.Close()
    End Sub
End Class