Imports MySql.Data.MySqlClient

Public Class RealizarFactura

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridFacturas.CellContentClick

    End Sub

    Private Sub atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atras.Click
        Me.Hide()
        Facturacion.Show()
    End Sub

    Private Sub RealizarFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub buscarb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarb.Click
        Me.Hide()
        BuscarProducto.Show()
    End Sub
End Class