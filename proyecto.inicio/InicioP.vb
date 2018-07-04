<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
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
End Class