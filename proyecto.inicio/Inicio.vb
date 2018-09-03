Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class Inicio

    'Variables para mover form en none
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer


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



    Private Sub btnfacturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfacturacion.Click
        Panelproveedores.Visible = False
        Panelclientes.Visible = False
        PanelFact.Visible = True And PanelFact.Visible = False
        panetlstock.Visible = False
    End Sub

    Private Sub btnrealizarfact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrealizarfact.Click
        Dim llamar As New RealizarFactura
        PanelDeTodos.Controls.Clear()
        llamar.TopLevel = False
        llamar.Parent = PanelDeTodos
        llamar.Show()
        llamar.Dock = DockStyle.Fill
        PanelDeTodos.Visible = True



    End Sub

    Private Sub btnconslfact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconslfact.Click
        Dim llamar1 As New ConsultaFactura
        PanelDeTodos.Controls.Clear()
        llamar1.TopLevel = False
        llamar1.Parent = PanelDeTodos
        llamar1.Show()
        llamar1.Dock = DockStyle.Fill
        PanelDeTodos.Visible = True

    End Sub

    '___________________________________________________________________________________________________________________________________________


    Private Sub btnclientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclientes.Click
        Panelclientes.Visible = True And Panelclientes.Visible = False
        panetlstock.Visible = False
        PanelFact.Visible = False
        Panelproveedores.Visible = False

    End Sub

    Private Sub btnconsultclient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultclient.Click
        Dim llamar3 As New MODIFICARCLIENTES
        PanelDeTodos.Controls.Clear()
        llamar3.TopLevel = False
        llamar3.Parent = PanelDeTodos
        llamar3.Show()
        llamar3.Dock = DockStyle.Fill


        PanelDeTodos.Visible = True

    End Sub

    Private Sub btndeudores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeudores.Click
        Dim llamar6 As New BuscarClientes
        PanelDeTodos.Controls.Clear()
        llamar6.TopLevel = False
        llamar6.Parent = PanelDeTodos
        llamar6.Show()
        llamar6.Dock = DockStyle.Fill
        PanelDeTodos.Visible = True

    End Sub
    '____________________________________________________________________________________________________________________________________________

    Private Sub btnstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstock.Click
        'Abro el panel pero hago que se oculten los demás si están abiertos ,para no entreverarse
        panetlstock.Visible = True And panetlstock.Visible = False
        Panelclientes.Visible = False
        PanelFact.Visible = False
        Panelproveedores.Visible = False


    End Sub
    '___________________________________________________________________________________________________________________________________________

    Private Sub btnprov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprov.Click
        'ocultamos pestaña en pantalla y aparece proveedores
        Panelclientes.Visible = False
        PanelFact.Visible = False
        Panelproveedores.Visible = True And Panelproveedores.Visible = False
        panetlstock.Visible = False
    End Sub

    Private Sub btnmodprov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodprov.Click
        Dim llamar2 As New MODIFPROVEEDORES
        PanelDeTodos.Controls.Clear()
        llamar2.TopLevel = False
        llamar2.Parent = PanelDeTodos
        llamar2.Show()
        llamar2.Dock = DockStyle.Fill
        PanelDeTodos.Visible = True

    End Sub

    Private Sub btnbuscarprov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarprov.Click
        Dim llamar As New Buscar_proveedores 
        PanelDeTodos.Controls.Clear()
        llamar.TopLevel = False
        llamar.Parent = PanelDeTodos
        llamar.Show()
        llamar.Dock = DockStyle.Fill
        PanelDeTodos.Visible = True
    End Sub


    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Hide()
        Verificacion.Show()
    End Sub

    Private Sub PictureBoxsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxsalir.Click
        End
    End Sub

    Private Sub btnaddstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddstock.Click
        Dim llamar4 As New Stock_de_Productos
        PanelDeTodos.Controls.Clear()
        llamar4.TopLevel = False
        llamar4.Parent = PanelDeTodos
        llamar4.Show()
        llamar4.Dock = DockStyle.Fill
        PanelDeTodos.Visible = True

    End Sub



    Private Sub btnmodistock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodistock.Click
        Dim llamar5 As New SuspenderStock
        PanelDeTodos.Controls.Clear()
        llamar5.TopLevel = False
        llamar5.Parent = PanelDeTodos
        llamar5.Show()
        llamar5.Dock = DockStyle.Fill
        PanelDeTodos.Visible = True


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

    Private Sub PanelDeTodos_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles PanelDeTodos.Paint
        PanelDeTodos.Visible = False

    End Sub

    Private Sub barratituloInicio_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles barratituloInicio.Paint

    End Sub
End Class