Imports MySql.Data.MySqlClient
Public Class ConsultaFactura

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim sql As String
        Dim connect As New MySqlConnection
        Dim comando As MySqlCommand
        Try
            connect = conn
            sql = "SELECT * FROM 'facturas'"
            connect.Open()
            comando = New MySqlCommand(sql, connect)
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub Atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Atras.Click
        Me.Hide()
        Facturacion.Show()

    End Sub

    Private Sub ConsultaFactura_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class