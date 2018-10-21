Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Public Class SearchProducts

    'Variables para mover form en none
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer


    Private Sub SearchProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
   
            Consulta = "SELECT * FROM stock"
            consultar()
            dgvbuscarStock.DataSource = resultado
           

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        'Nombramos los encabezados del datagrid buscar

        dgvbuscarstock.Columns(0).HeaderText = "Código"
        dgvbuscarstock.Columns(1).HeaderText = "Descrip."
        dgvbuscarstock.Columns(2).HeaderText = "Cantidad"
        dgvbuscarstock.Columns(3).HeaderText = "Precio Costo"
        dgvbuscarstock.Columns(4).HeaderText = "Precio Venta"
        dgvbuscarstock.Columns(5).HeaderText = "Proveedor"
    End Sub

    Private Sub dgvbuscarstock_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvbuscarstock.CellClick
        Dim llamar As New RealizarFactura
        'Mediante el evento indicamos hacia donde van los valores seleccionados
        RealizarFactura.txtcodigo.Text = dgvbuscarstock.CurrentRow.Cells(0).Value.ToString
        RealizarFactura.txtdesc.Text = dgvbuscarstock.CurrentRow.Cells(1).Value.ToString
        RealizarFactura.txtprecioov.Text = dgvbuscarstock.CurrentRow.Cells(4).Value.ToString
        'close para cerrar el form
        Close()
    End Sub

    Private Sub txtbuscarstock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscarstock.TextChanged
        Try
            'BUSQUEDA DINAMICA EN DATAGRIDVIEW
            conexioon.Consulta = "SELECT * FROM stock WHERE cod_producto LIKE '%" & txtbuscarstock.Text & "%' and descripcion LIKE '%" & txtbuscarstock.Text & "%' and cantidad LIKE '%" & txtbuscarstock.Text & "%' and precio_costo LIKE '%" & txtbuscarstock.Text & "%' and precio_v_stock LIKE '%" & txtbuscarstock.Text & "%' and num_prov LIKE '%" & txtbuscarstock.Text & "%';"
            consultar()
            dgvbuscarstock.DataSource = resultado

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnMinimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaximizar.Click
        'maximiza ventana
        Me.WindowState = FormWindowState.Maximized
        'esconde boton, aparece restaurar
        btnmaxi.Visible = False
        btnrestaurar.Visible = True
    End Sub

    Private Sub btnRestaura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaura.Click
        'maximiza ventana
        Me.WindowState = FormWindowState.Normal
        'esconde boton, aparece restaurar
        btnmaxi.Visible = True
        btnrestaurar.Visible = False
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Hide()
        Inicio.Show()

    End Sub


    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'MOVER FORM EN NONE
    Private Sub barratituloInicio_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles barratituloInicio.MouseDown
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