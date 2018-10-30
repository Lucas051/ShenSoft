Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Public Class BuscarProv

    'Variables para mover form en none
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub BuscarProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            conexioon.Consulta = "SELECT * FROM proveedores;"
            consultar()
            dgvbuscarprov.DataSource = resultado

            dgvbuscarprov.Columns(0).HeaderText = "ID"
            dgvbuscarprov.Columns(1).HeaderText = "Proveedor"
            dgvbuscarprov.Columns(2).HeaderText = "Teléfono"
            dgvbuscarprov.Columns(3).HeaderText = "Dirección"
            dgvbuscarprov.Columns(4).HeaderText = "Saldo"

            'ancho de columnas dgv
            dgvbuscarprov.Columns(0).Width = 100
            dgvbuscarprov.Columns(1).Width = 200
            dgvbuscarprov.Columns(2).Width = 200
            dgvbuscarprov.Columns(3).Width = 200
            dgvbuscarprov.Columns(4).Width = 100


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub txtbuscarstock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscarprov.TextChanged
        Try
            'BUSQUEDA DINAMICA EN DATAGRIDVIEW
            conexioon.Consulta = "SELECT * FROM proveedores WHERE  nombre_prov LIKE '%" & txtbuscarprov.Text & "%';"
            consultar()
            dgvbuscarprov.DataSource = resultado


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvbuscarprov_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvbuscarprov.CellClick
        Dim llamarConsultaProv As New FacturasProveedores
        'Mediante el evento indicamos hacia donde van los valores seleccionados
        ModuloVariables.numeroprov = dgvbuscarprov.CurrentRow.Cells(0).Value.ToString
        FacturasProveedores.txtproveedor.Text = ModuloVariables.numeroprov

        'close para cerrar el form
        Dim llamarBuscarProv As New BuscarProv
        llamarBuscarProv.TopLevel = False
        llamarBuscarProv.Parent = Inicio.panelmedio
        llamarBuscarProv.Show()
        Inicio.panelmedio.Visible = True
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
        'maximiza ventana
        Me.WindowState = FormWindowState.Normal
        'esconde boton, aparece restaurar
        btnMaximizar.Visible = True
        btnRestaura.Visible = False
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()

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

    Private Sub lblbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblbuscar.Click

    End Sub
End Class