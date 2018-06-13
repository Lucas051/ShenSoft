Imports MySql.Data.MySqlClient

Public Class RealizarFactura
    Dim cantidadp, valor, descuentop As Integer

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridFacturas.CellContentClick

    End Sub

    Private Sub atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atras.Click
        Me.Hide()
        Facturacion.Show()
    End Sub



    Private Sub buscarb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarb.Click
        Me.Hide()
        buscarfactura.Show()
    End Sub

    Private Sub limpiarv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiarv.Click
        codigo.Text = ""
        desc.Text = ""
        cant.Text = ""
        descuent.Text = ""
        precioov.Text = ""
    End Sub

    Private Sub agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agregar.Click
        'No toquen esto, tiene un error we ahi lo soluciono, ahora voy a estudiar para filosofia y form empresarial xdxdxd lol
        cantidadp = Val(cantidad.Text)
        descuentop = Val(desc.Text)

        valor = Val(precioov.Text) * Val(cantidadp)
        descuentop = Val(precioov) * Val(desc) / 100
        valor = (Val(precioov.Text) * Val(cantidadp)) - Val(descuentop)



        DataGridFacturas.Rows.Add(codigo.Text, desc.Text, cantidadp, descuento, valor)
    End Sub
End Class