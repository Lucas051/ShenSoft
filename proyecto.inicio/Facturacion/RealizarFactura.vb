Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class RealizarFactura
    Dim cantidadp, valor, descuentop, valorTotal As Integer
    Dim montototal As Double = 0
    Dim cuenta As Integer

    'Variables para mover form en none
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Public KeyAscii As Short

    Private Sub RealizarFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblMontoTotal.Text = 0
        txtdescuent.Text = 0
        lblCodigo.ResetText()
        lblescondido.Visible = False
    End Sub


    Private Sub guardarImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardarImprimir.Click

        ModuloVariables.MontoTotal = lblMontoTotal.Text
        Cobrar.Show()
    End Sub

    Private Sub btnborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborrar.Click


        Try
            DGVVentas.Rows.Remove(DGVVentas.CurrentRow)

            

            For Each Fila In DGVVentas.Rows.Cast(Of DataGridViewRow)()
                montototal = Fila.Cells("preciototal").Value.ToString()
            Next
            lblMontoTotal.Text = montototal

            If DGVVentas.RowCount = 0 Then

                MessageBox.Show("Grilla Vacia!", "Datos Totalmente Borrados")
                lblMontoTotal.Text = 0
                montototal = Nothing
            End If

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try


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

    Private Sub btnlineaAgregada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlineaAgregada.Click
        ' Fila actualmente seleccionada en el control DataGridView
        '
        Dim row As DataGridViewRow = DGVVentas.CurrentRow

        ' Si no hay ninguna fila seleccionada, abandonamos el procedimiento
        '
        If (row Is Nothing) Then Return

        'mandamos los valores modificados de los txtbox hacia la currentRow
        row.Cells(1).Value = txtdescripcion.Text
        row.Cells(2).Value = txtcant.Text
        row.Cells(3).Value = txtdescuent.Text
        row.Cells(4).Value = txtprecioov.Text


        'calculo de valor total del producto agregado al DGV, en caso de realizar descuento también se realizará una operación
        cantidadp = txtcant.Text
        valor = Val(cantidadp) * Val(txtprecioov.Text) - descuentop
        descuentop = Val(valor) * Val(txtdescuent.Text) / 100
        valorTotal = Val(cantidadp) * Val(txtprecioov.Text) - descuentop


        row.Cells(5).Value = valorTotal

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

        txtdescuent.Text = 0
        montototal += valorTotal
        lblMontoTotal.Text = montototal

       

    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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



  
    Private Sub txtcant_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcant.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtdescuent_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescuent.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtprecioov_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprecioov.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

End Class