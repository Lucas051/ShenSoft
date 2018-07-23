<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> d19429f7d8081b4cb9859b313d55c7febe1d6b68
﻿Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Public Class InicioP

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
<<<<<<< HEAD
=======
﻿Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Public Class InicioP

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
>>>>>>> b9ac1fc0ad416c297c35c829e7c17ad9a49cbaf6
=======
﻿Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Public Class InicioP

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

   
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
=======
﻿Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Public Class InicioP

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

   
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
=======


    Private Sub btnfacturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfacturacion.Click
        'ocultamos pestaña en pantalla y aparece facturacion
        Panelproveedores.Visible = False
        Panelclientes.Visible = False
        PanelFact.Visible = True
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
        Panelclientes.Visible = True
    End Sub

    Private Sub btnconsultclient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultclient.Click
        Panelclientes.Visible = False
    End Sub

    Private Sub btndeudores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeudores.Click
        Panelclientes.Visible = False
    End Sub
    '____________________________________________________________________________________________________________________________________________

    Private Sub btnstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstock.Click
        '  abrimos stock
        Me.Hide()
        Stock_de_Productos.Show()

    End Sub
    '___________________________________________________________________________________________________________________________________________
   
    Private Sub btnprov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprov.Click
        'ocultamos pestaña en pantalla y aparece proveedores
        Panelclientes.Visible = False
        PanelFact.Visible = False
        Me.Hide()
        prove.Show()
    End Sub


    Private Sub panelmedio_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panelmedio.Paint

    End Sub
>>>>>>> d19429f7d8081b4cb9859b313d55c7febe1d6b68
End Class