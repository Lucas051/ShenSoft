Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class RealizarFactura
    Dim cantidadp, valor, descuentop, valorTotal As Integer

    Private Sub guardarImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardarImprimir.Click
        Me.Hide()
        Cobrar.Show()
    End Sub

    Private Sub atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        Me.Hide()
        Inicio.Show()
        Dim llamarInicio As New PlantillaInicio
        Inicio.panelmedio.Controls.Clear()
        llamarInicio.TopLevel = False
        llamarInicio.Parent = Inicio.panelmedio
        llamarInicio.Show()
        llamarInicio.Dock = DockStyle.Fill


        Inicio.panelmedio.Visible = True
    End Sub

    Private Sub cerrarbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End

    End Sub

    Private Sub buscarproductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarproductos.Click
        SearchProducts.Show()

    End Sub

    Private Sub agregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click

        cantidadp = txtcant.Text
        valor = Val(cantidadp) * Val(txtprecioov.Text) - descuentop
        descuentop = Val(valor) * Val(txtdescuent.Text) / 100
        valorTotal = Val(cantidadp) * Val(txtprecioov.Text) - descuentop



        'Agrega valores de textbox a datagrid
        DataGridFacturas.Rows.Add(txtcodigo.Text, txtdesc.Text, cantidadp, txtdescuent.Text, txtprecioov.Text, valorTotal)

        txtcodigo.Clear()
        txtdesc.Clear()
        txtcant.Clear()
        txtdescuent.Clear()
        txtprecioov.Clear()

    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaximizar.Click
        'maximiza ventana
        Me.WindowState = FormWindowState.Maximized
        'esconde boton, aparece restaurar
        btnMaximizar.Visible = False
        btnRestaura.Visible = True
    End Sub


    Private Sub btnRestaura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaura.Click
        'Normaliza  ventana
        Me.WindowState = FormWindowState.Normal
        'esconde boton, aparece restaurar
        btnMaximizar.Visible = True
        btnRestaura.Visible = False
    End Sub
End Class