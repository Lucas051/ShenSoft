Imports MySql.Data.MySqlClient

Public Class RealizarFactura
    Dim cantidadp, valor, descuentop, valorTotal As Integer

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridFacturas.CellContentClick
       
    End Sub

    Private Sub atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Facturacion.Show()
    End Sub

    Private Sub RealizarFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      


    End Sub



    Private Sub buscarb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarb.Click
        Me.Hide()
        buscarproductos.Show()
    End Sub

    Private Sub limpiarv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiarv.Click
        codigo.Text = ""
        desc.Text = ""
        cant.Text = ""
        descuent.Text = ""
        precioov.Text = ""
    End Sub
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

    Private Sub agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agregar.Click

        cantidadp = cant.Text
        valor = Val(cantidadp) * Val(precioov.Text) - descuentop
        descuentop = Val(valor) * Val(descuent.Text) / 100
        valorTotal = Val(cantidadp) * Val(precioov.Text) - descuentop



        'Agrega valores de textbox a datagrid
        DataGridFacturas.Rows.Add(codigo.Text, desc.Text, cantidadp, descuent.Text, precioov.Text, valorTotal)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Cobrar.Show()

    End Sub
=======

    Private Sub agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agregar.Click

        cantidadp = cant.Text
        valor = Val(cantidadp) * Val(precioov.Text) - descuentop
        descuentop = Val(valor) * Val(descuent.Text) / 100
        valorTotal = Val(cantidadp) * Val(precioov.Text) - descuentop



        'Agrega valores de textbox a datagrid
        DataGridFacturas.Rows.Add(codigo.Text, desc.Text, cantidadp, descuent.Text, precioov.Text, valorTotal)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Cobrar.Show()

    End Sub
>>>>>>> b9ac1fc0ad416c297c35c829e7c17ad9a49cbaf6
=======

    Private Sub agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agregar.Click

        cantidadp = cant.Text
        valor = Val(cantidadp) * Val(precioov.Text) - descuentop
        descuentop = Val(valor) * Val(descuent.Text) / 100
        valorTotal = Val(cantidadp) * Val(precioov.Text) - descuentop



        'Agrega valores de textbox a datagrid
        DataGridFacturas.Rows.Add(codigo.Text, desc.Text, cantidadp, descuent.Text, precioov.Text, valorTotal)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Cobrar.Show()

    End Sub
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
=======

    Private Sub agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agregar.Click

        cantidadp = cant.Text
        valor = Val(cantidadp) * Val(precioov.Text) - descuentop
        descuentop = Val(valor) * Val(descuent.Text) / 100
        valorTotal = Val(cantidadp) * Val(precioov.Text) - descuentop



        'Agrega valores de textbox a datagrid
        DataGridFacturas.Rows.Add(codigo.Text, desc.Text, cantidadp, descuent.Text, precioov.Text, valorTotal)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Cobrar.Show()

    End Sub
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
End Class