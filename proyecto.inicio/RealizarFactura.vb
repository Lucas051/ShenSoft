Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class RealizarFactura
    Dim cantidadp, valor, descuentop, valorTotal As Integer
<<<<<<< HEAD

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
=======

    Private Sub guardarImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guardarImprimir.Click
        Me.Hide()
        Cobrar.Show()
    End Sub

    Private Sub atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atras.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub cerrarbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cerrarbtn.Click
        End

    End Sub

    Private Sub btnmaxi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmaxi.Click
        'maximiza ventana
        Me.WindowState = FormWindowState.Maximized
        'esconde boton, aparece restaurar
        btnmaxi.Visible = False
        btnrestaurar.Visible = True
    End Sub

    Private Sub btnmini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmini.Click
        'minimiza ventana
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnrestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrestaurar.Click
        'restaura ventana
        Me.WindowState = FormWindowState.Normal
        'esconde boton, aparece maximizar
        btnrestaurar.Visible = False
        btnmaxi.Visible = True
    End Sub

   
    Private Sub buscarb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarb.Click
        Me.Hide()
        buscarproductos.Show()
    End Sub

    Private Sub agregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles agregar.Click
        If cant.Text = " " And precioov.Text = " " Then
            MsgBox("Debe ingresar una cantidad y precio de venta")

        Else

            cantidadp = cant.Text
            valor = Val(cantidadp) * Val(precioov.Text) - descuentop
            descuentop = Val(valor) * Val(descuent.Text) / 100
            valorTotal = Val(cantidadp) * Val(precioov.Text) - descuentop

            'Agrega valores de textbox a datagrid
            DataGridFacturas.Rows.Add(codigo.Text, desc.Text, cantidadp, descuent.Text, precioov.Text, valorTotal)
        End If
    End Sub

    Private Sub limpiarv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiarv.Click
>>>>>>> d19429f7d8081b4cb9859b313d55c7febe1d6b68
        codigo.Text = ""
        desc.Text = ""
        cant.Text = ""
        descuent.Text = ""
<<<<<<< HEAD
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
=======
        precioov.Text = ""
    End Sub

>>>>>>> d19429f7d8081b4cb9859b313d55c7febe1d6b68
End Class