Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class Inicio

    'Variables para mover form en none
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer


    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TimerHora.Start()
        DTPickerFecha.Visible = False

        'Localiza por defecto lo botones en la posición inicial y oculta panels en caso de ser visibles
        btnfacturacion.Location = New Point(0, 167)
        btnstock.Location = New Point(0, 235)
        btnclientes.Location = New Point(0, 303)
        btnprov.Location = New Point(0, 371)
        PanelFact.Hide()
        panelstock.Hide()
        Panelclientes.Hide()
        Panelproveedores.Hide()
        panelOpciones.Width = 59

    End Sub

    Private Sub cerrarbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cerrarbtn.Click
        End
    End Sub

    Private Sub btnSalir1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir1.Click
        End
    End Sub

    Private Sub btnCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        Me.Hide()
        Verificacion.Show()
    End Sub

    Private Sub PictureBoxsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxsalir.Click
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


    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'Configuraciones para el movimiento de desplazar los botones menu izquierdo
    Private Sub btnfacturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfacturacion.Click
        If PanelFact.Visible = True Then
            PanelFact.Visible = False
        Else
            PanelFact.Visible = True
        End If

        btnfacturacion.Location = New Point(0, 167)
        PanelFact.Location = New Point(1, 201)
        btnstock.Location = New Point(0, 270)
        btnclientes.Location = New Point(0, 338)
        btnprov.Location = New Point(0, 404)
        panelstock.Hide()
        Panelclientes.Hide()
        Panelproveedores.Hide()


        If PanelFact.Visible = False Then
            btnfacturacion.Location = New Point(0, 167)
            btnstock.Location = New Point(0, 235)
            btnclientes.Location = New Point(0, 303)
            btnprov.Location = New Point(0, 371)
        End If


    End Sub


    Private Sub btnstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstock.Click
        If panelstock.Visible = True Then
            panelstock.Visible = False
        Else
            panelstock.Visible = True
        End If

        btnfacturacion.Location = New Point(0, 167)
        btnstock.Location = New Point(0, 235)
        panelstock.Location = New Point(0, 269)
        btnclientes.Location = New Point(0, 338)
        btnprov.Location = New Point(0, 406)
        PanelFact.Hide()
        Panelclientes.Hide()
        Panelproveedores.Hide()

        If panelstock.Visible = False Then
            btnfacturacion.Location = New Point(0, 167)
            btnstock.Location = New Point(0, 235)
            btnclientes.Location = New Point(0, 303)
            btnprov.Location = New Point(0, 371)

        End If

    End Sub


    Private Sub btnclientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclientes.Click
        If Panelclientes.Visible = True Then
            Panelclientes.Visible = False
        Else
            Panelclientes.Visible = True
        End If

        btnfacturacion.Location = New Point(0, 167)
        btnstock.Location = New Point(0, 235)
        btnclientes.Location = New Point(0, 303)
        Panelclientes.Location = New Point(0, 337)
        btnprov.Location = New Point(0, 406)
        PanelFact.Hide()
        panelstock.Hide()
        Panelproveedores.Hide()

        If Panelclientes.Visible = False Then
            btnfacturacion.Location = New Point(0, 167)
            btnstock.Location = New Point(0, 235)
            btnclientes.Location = New Point(0, 303)
            btnprov.Location = New Point(0, 371)

        End If
    End Sub


    Private Sub btnprov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprov.Click
        If Panelproveedores.Visible = True Then
            Panelproveedores.Visible = False
        Else
            Panelproveedores.Visible = True
        End If

        btnfacturacion.Location = New Point(0, 167)
        btnstock.Location = New Point(0, 235)
        btnclientes.Location = New Point(0, 303)
        btnprov.Location = New Point(0, 371)
        Panelproveedores.Location = New Point(0, 405)
        PanelFact.Hide()
        Panelclientes.Hide()
        panelstock.Hide()

        If Panelproveedores.Visible = False Then
            btnfacturacion.Location = New Point(0, 167)
            btnstock.Location = New Point(0, 235)
            btnclientes.Location = New Point(0, 303)
            btnprov.Location = New Point(0, 371)

        End If

    End Sub
  
    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Private Sub btnrealizarfact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrealizarfact.Click
        Dim llamar As New RealizarFactura
        panelmedio.Controls.Clear()
        llamar.TopLevel = False
        llamar.Parent = panelmedio
        llamar.Show()
        llamar.Dock = DockStyle.Fill
        panelmedio.Visible = True



    End Sub

    Private Sub btnconslfact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconslfact.Click
        Dim llamar1 As New ConsultaFactura
        panelmedio.Controls.Clear()
        llamar1.TopLevel = False
        llamar1.Parent = panelmedio
        llamar1.Show()
        llamar1.Dock = DockStyle.Fill
        panelmedio.Visible = True

    End Sub

    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


    Private Sub btnconsultclient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultclient.Click
        Dim llamar3 As New MODIFICARCLIENTES
        panelmedio.Controls.Clear()
        llamar3.TopLevel = False
        llamar3.Parent = panelmedio
        llamar3.Show()
        llamar3.Dock = DockStyle.Fill


        panelmedio.Visible = True

    End Sub

    Private Sub btndeudores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeudores.Click
        Dim llamar6 As New BuscarClientes
        panelmedio.Controls.Clear()
        llamar6.TopLevel = False
        llamar6.Parent = panelmedio
        llamar6.Show()
        llamar6.Dock = DockStyle.Fill
        panelmedio.Visible = True

    End Sub


    Private Sub btnmodprov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodprov.Click
        Dim llamar2 As New Gestionproveedores
        panelmedio.Controls.Clear()
        llamar2.TopLevel = False
        llamar2.Parent = panelmedio
        llamar2.Show()
        llamar2.Dock = DockStyle.Fill
        panelmedio.Visible = True

    End Sub


    Private Sub btnaddstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddstock.Click
        Dim llamar4 As New Stock_de_Productos
        panelmedio.Controls.Clear()
        llamar4.TopLevel = False
        llamar4.Parent = panelmedio
        llamar4.Show()
        llamar4.Dock = DockStyle.Fill
        panelmedio.Visible = True

    End Sub



    Private Sub btnmodistock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodistock.Click
        Dim llamar5 As New SuspenderStock
        panelmedio.Controls.Clear()
        llamar5.TopLevel = False
        llamar5.Parent = panelmedio
        llamar5.Show()
        llamar5.Dock = DockStyle.Fill
        panelmedio.Visible = True


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

    Private Sub PanelDeTodos_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        panelmedio.Visible = False

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaura.Click
        'maximiza ventana
        Me.WindowState = FormWindowState.Maximized
        'esconde boton, aparece restaurar
        btnmaxi.Visible = True
        btnrestaurar.Visible = False
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaximizar.Click
        'maximiza ventana
        Me.WindowState = FormWindowState.Maximized
        'esconde boton, aparece restaurar
        btnmaxi.Visible = False
        btnrestaurar.Visible = True
    End Sub


    Private Sub TimerHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerHora.Tick
        Dim fecha As String
        fecha = DTPickerFecha.Text
        lblFecha.Text = fecha

        lblHora.Text = TimeOfDay.TimeOfDay.ToString
        TimerHora.Enabled = True
        '////////////////////////////////////////////
    End Sub



    Private Sub PTBabrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PTBabrir.Click
        PTBabrir.Hide()
        While (panelOpciones.Width < 168)
            panelOpciones.Width = panelOpciones.Width + 1
        End While
        PTBocultar.Show()
    End Sub

    Private Sub PTBocultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PTBocultar.Click
        PTBocultar.Hide()
        While (panelOpciones.Width > 59)
            panelOpciones.Width -= 1
        End While
        PTBabrir.Show()
    End Sub


    Private Sub btnOcultar_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOcultar.MouseLeave
        btnOcultar.ForeColor = Color.Blue

    End Sub

    Private Sub btnOcultar_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnOcultar.MouseMove
        btnOcultar.ForeColor = Color.LightGray

    End Sub

    Private Sub btncalculadora_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalculadora.MouseLeave
        btnOcultar.ForeColor = Color.Blue
    End Sub

    Private Sub btncalculadora_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btncalculadora.MouseMove
        btnOcultar.ForeColor = Color.LightGray
    End Sub

    Private Sub btncalendario_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalendario.MouseLeave
        btnOcultar.ForeColor = Color.Blue
    End Sub

    Private Sub btncalendario_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btncalendario.MouseMove
        btnOcultar.ForeColor = Color.LightGray
    End Sub

    Private Sub btncharts_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncharts.MouseLeave
        btnOcultar.ForeColor = Color.Blue
    End Sub

    Private Sub btncharts_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btncharts.MouseMove
        btnOcultar.ForeColor = Color.LightGray
    End Sub
    Private Sub PTBcalendario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PTBcalendario.Click
        If MonthCalendar1.Visible = False Then
            MonthCalendar1.Visible = True
        Else
            MonthCalendar1.Visible = False
        End If
    End Sub


End Class