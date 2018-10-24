﻿Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class RealizarFactura
    Dim cantidadp, valor, descuentop, valorTotal As Integer
    Dim montototal As Double = 0
    Dim precioeliminado As Double

    'Variables para mover form en none
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer


    Private Sub RealizarFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtdescuent.Text = 0
        lblCodigo.ResetText()
    End Sub

    Private Sub guardarImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardarImprimir.Click

        ModuloVariables.MontoTotal = lblMontoTotal.Text
        Cobrar.Show()
    End Sub

    Private Sub btnborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborrar.Click

        DGVVentas.Rows.Remove(DGVVentas.CurrentRow)

        precioeliminado = DGVVentas.CurrentRow.Cells("preciototal").Value

        montototal = montototal - precioeliminado
        lblMontoTotal.Text = Convert.ToString(montototal)

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

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        DGVVentas.Rows.Add(lblCodigo.Text, txtdescripcion.Text, cantidadp, txtdescuent.Text, txtprecioov.Text, valorTotal)
        DGVVentas.Rows.Remove(DGVVentas.CurrentRow)
        If (DGVVentas.SelectedRows.Count > 0) Then
            txtdescripcion.Text = DGVVentas.CurrentRow.Cells("descripcion").Value.ToString
            txtcant.Text = DGVVentas.CurrentRow.Cells("cantidad").Value.ToString
            txtdescuent.Text = DGVVentas.CurrentRow.Cells("descuento").Value.ToString
            txtprecioov.Text = DGVVentas.CurrentRow.Cells("precioventa").Value.ToString
        Else
            MessageBox.Show("Seleccione una línea!")
        End If
    End Sub

    Private Sub buscarproductos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarproductos.Click
        SearchProducts.Show()

    End Sub

    Private Sub agregar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        Dim fila As DataGridViewRow = New DataGridViewRow()

        Try

            If (txtdescripcion.Text <> "" And txtcant.Text <> "" And txtdescuent.Text <> "" And txtprecioov.Text <> "") Then
                'calculo de valor total del producto agregado al DGV, en caso de realizar descuento también se realizará una operación
                cantidadp = txtcant.Text
                valor = Val(cantidadp) * Val(txtprecioov.Text) - descuentop
                descuentop = Val(valor) * Val(txtdescuent.Text) / 100
                valorTotal = Val(cantidadp) * Val(txtprecioov.Text) - descuentop



                'Agrega valores de textbox a datagrid
                DGVVentas.Rows.Add(lblCodigo.Text, txtdescripcion.Text, cantidadp, txtdescuent.Text, txtprecioov.Text, valorTotal)

                lblCodigo.ResetText()
                txtdescripcion.Clear()
                txtcant.Clear()
                txtdescuent.Clear()
                txtprecioov.Clear()
            Else
                MessageBox.Show("Se deben completar todos los campos!")

            End If
        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try

        montototal += valorTotal
        lblMontoTotal.Text = montototal
        

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

    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'MOVER FORM EN NONE
    Private Sub barratitulo_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles barratituloInicio.MouseDown
        If e.Button = MouseButtons.Left Then

            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y

        End If

    End Sub


    Private Sub barratituloInicio_MouseMove_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles barratituloInicio.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)

            Me.Location = temp

            temp = Nothing

        End If
    End Sub

    Private Sub barratituloInicio_MouseUp_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles barratituloInicio.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
End Class