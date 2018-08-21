Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class Inicio

    Private Sub cerrarbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cerrarbtn.Click
        End
    End Sub

    Private Sub btnmaxi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmaxi.Click
        'maximiza ventana
        Me.WindowState = FormWindowState.Maximized
        'esconde boton, aparece restaurar
        btnmaxi.Visible = False
        btnrestaurar.visible = True
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

    '[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    '   private extern static void ReleaseCapture()
    ' [DllImport("user32.DLL", EntryPoint = "SendMessage")]

    '  private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam)

    Private Sub barratitulo_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles barratitulo.MouseDown
        ' ReleaseCapture();
        ' SendMessage(this.Handle, 0x112, 0xf012, 0);
    End Sub


    Private Sub btnfacturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfacturacion.Click
        'ocultamos pestaña en pantalla y aparece facturacion
        Panelproveedores.Visible = False
        Panelclientes.Visible = False
        PanelFact.Visible = True And PanelFact.Visible = False
        panetlstock.Visible = False
    End Sub

    Private Sub btnrealizarfact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrealizarfact.Click
        PanelFact.Visible = False
        Me.Hide()
        RealizarFactura.Show()

    End Sub

    Private Sub btnconslfact_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconslfact.Click
        PanelFact.Visible = False
        Me.Hide()
        ConsultaFactura.Show()

    End Sub

    '___________________________________________________________________________________________________________________________________________


    Private Sub btnclientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclientes.Click
        'ocultamos pestaña en pantalla y aparece clientes
        Panelproveedores.Visible = False
        PanelFact.Visible = False

        panetlstock.Visible = False
        Panelclientes.Visible = True And Panelclientes.Visible = False

    End Sub

    Private Sub btnconsultclient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultclient.Click
        Panelclientes.Visible = False
        MODIFICARCLIENTES.Show()
        Me.Hide()


    End Sub

    Private Sub btndeudores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeudores.Click
        Panelclientes.Visible = False
        Me.Hide()
        BuscarClientes.Show()

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
        Me.Hide()
        MODIFPROVEEDORES.Show()

    End Sub

    Private Sub btnbuscarprov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarprov.Click
        Me.Hide()
        Buscar_proveedores.Show()

    End Sub

    
    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Hide()
        Verificacion.Show()
    End Sub

    Private Sub PictureBoxsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxsalir.Click
        End
    End Sub

    Private Sub btnaddstock_Click(sender As System.Object, e As System.EventArgs) Handles btnaddstock.Click
        Me.Hide()
        Stock_de_Productos.Show()

    End Sub


    
    Private Sub btnmodistock_Click(sender As System.Object, e As System.EventArgs) Handles btnmodistock.Click
        Me.Hide()
        SuspenderStock.Show()

    End Sub

    Private Sub barratitulo_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles barratitulo.Paint

    End Sub
End Class