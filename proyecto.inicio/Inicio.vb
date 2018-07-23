<<<<<<< HEAD
﻿Public Class Inicio

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Stock_de_Productos.Show()



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Facturacion.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Consulta_proveedor.Show()
    End Sub
    'De aqui hacia abajo se usa mouse hover para agrandar el icono cuando se pasa el mouse por arriba y vuelve al estado anterior con leave
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    '_________________________________________________________________________________________________________________
    Private Sub Panel2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.MouseHover
        Panel2.Size = New Size(98, 64)

    End Sub

    Private Sub Panel2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.MouseLeave
        Panel2.Size = New Size(95, 61)
    End Sub
    '_________________________________________________________________________________________________________________
    Private Sub Panel3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.MouseHover
        Panel3.Size = New Size(68, 65)
    End Sub

    Private Sub Panel3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.MouseLeave
        Panel3.Size = New Size(65, 61)
    End Sub
    '_________________________________________________________________________________________________________________

    Private Sub Panel4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.MouseHover
        Panel4.Size = New Size(76, 73)
    End Sub

    Private Sub Panel4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.MouseLeave
        Panel4.Size = New Size(73, 70)
    End Sub
    '_________________________________________________________________________________________________________________

    Private Sub Panel5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.MouseHover
        Panel5.Size = New Size(76, 73)
    End Sub

    Private Sub Panel5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.MouseLeave
        Panel5.Size = New Size(73, 70)
    End Sub
    '_________________________________________________________________________________________________________________

    Private Sub Panel6_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.MouseHover
        Panel6.Size = New Size(65, 57)
    End Sub

    Private Sub Panel6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.MouseLeave
        Panel6.Size = New Size(62, 54)
    End Sub
    '_________________________________________________________________________________________________________________

    'dirigimos los botones
    Private Sub Panel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.Click
        Me.Hide()
        Facturacion.Show()
    End Sub

    Private Sub Panel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.Click
        Me.Hide()
        Stock_de_Productos.Show()

    End Sub

    Private Sub Panel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.Click
        Me.Hide()
        Consulta_proveedor.Show()
    End Sub

    Private Sub Panel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.Click
        Me.Hide()
        Clientes.Show()

    End Sub

    Private Sub Panel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.Click
        End
    End Sub
    'Mostramos fecha y hora
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        hora.Text = TimeOfDay.TimeOfDay.ToString
        fecha.Text = DateString
    End Sub

  
 
    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
=======
    '_________________________________________________________________________________________________________________
    Private Sub Panel2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.MouseHover
        Panel2.Size = New Size(98, 64)

    End Sub

    Private Sub Panel2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.MouseLeave
        Panel2.Size = New Size(95, 61)
    End Sub
    '_________________________________________________________________________________________________________________
    Private Sub Panel3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.MouseHover
        Panel3.Size = New Size(68, 65)
    End Sub

    Private Sub Panel3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.MouseLeave
        Panel3.Size = New Size(65, 61)
    End Sub
    '_________________________________________________________________________________________________________________

    Private Sub Panel4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.MouseHover
        Panel4.Size = New Size(76, 73)
    End Sub

    Private Sub Panel4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.MouseLeave
        Panel4.Size = New Size(73, 70)
    End Sub
    '_________________________________________________________________________________________________________________

    Private Sub Panel5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.MouseHover
        Panel5.Size = New Size(76, 73)
    End Sub

    Private Sub Panel5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.MouseLeave
        Panel5.Size = New Size(73, 70)
    End Sub
    '_________________________________________________________________________________________________________________

    Private Sub Panel6_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.MouseHover
        Panel6.Size = New Size(65, 57)
    End Sub

    Private Sub Panel6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.MouseLeave
        Panel6.Size = New Size(62, 54)
    End Sub
    '_________________________________________________________________________________________________________________

    'dirigimos los botones
    Private Sub Panel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.Click
        Me.Hide()
        Facturacion.Show()
    End Sub

    Private Sub Panel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.Click
        Me.Hide()
        Stock_de_Productos.Show()

    End Sub

    Private Sub Panel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.Click
        Me.Hide()
        Consulta_proveedor.Show()
    End Sub

    Private Sub Panel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.Click
        Me.Hide()
        Clientes.Show()

    End Sub

    Private Sub Panel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.Click
        End
    End Sub
    'Mostramos fecha y hora
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        hora.Text = TimeOfDay.TimeOfDay.ToString
        fecha.Text = DateString
    End Sub

  
 
    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
>>>>>>> b9ac1fc0ad416c297c35c829e7c17ad9a49cbaf6
=======
    '_________________________________________________________________________________________________________________
    Private Sub Panel2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.MouseHover
        Panel2.Size = New Size(98, 64)

    End Sub

    Private Sub Panel2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.MouseLeave
        Panel2.Size = New Size(95, 61)
    End Sub
    '_________________________________________________________________________________________________________________
    Private Sub Panel3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.MouseHover
        Panel3.Size = New Size(68, 65)
    End Sub

    Private Sub Panel3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.MouseLeave
        Panel3.Size = New Size(65, 61)
    End Sub
    '_________________________________________________________________________________________________________________

    Private Sub Panel4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.MouseHover
        Panel4.Size = New Size(76, 73)
    End Sub

    Private Sub Panel4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.MouseLeave
        Panel4.Size = New Size(73, 70)
    End Sub
    '_________________________________________________________________________________________________________________

    Private Sub Panel5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.MouseHover
        Panel5.Size = New Size(76, 73)
    End Sub

    Private Sub Panel5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.MouseLeave
        Panel5.Size = New Size(73, 70)
    End Sub
    '_________________________________________________________________________________________________________________

    Private Sub Panel6_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.MouseHover
        Panel6.Size = New Size(65, 57)
    End Sub

    Private Sub Panel6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.MouseLeave
        Panel6.Size = New Size(62, 54)
    End Sub
    '_________________________________________________________________________________________________________________

    'dirigimos los botones
    Private Sub Panel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.Click
        Me.Hide()
        Facturacion.Show()
    End Sub

    Private Sub Panel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.Click
        Me.Hide()
        Stock_de_Productos.Show()

    End Sub

    Private Sub Panel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.Click
        Me.Hide()
        Consulta_proveedor.Show()
    End Sub

    Private Sub Panel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.Click
        Me.Hide()
        Clientes.Show()

    End Sub

    Private Sub Panel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.Click
        End
    End Sub
    'Mostramos fecha y hora
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        hora.Text = TimeOfDay.TimeOfDay.ToString
        fecha.Text = DateString
    End Sub

  
 
    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
=======
    '_________________________________________________________________________________________________________________
    Private Sub Panel2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.MouseHover
        Panel2.Size = New Size(98, 64)

    End Sub

    Private Sub Panel2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.MouseLeave
        Panel2.Size = New Size(95, 61)
    End Sub
    '_________________________________________________________________________________________________________________
    Private Sub Panel3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.MouseHover
        Panel3.Size = New Size(68, 65)
    End Sub

    Private Sub Panel3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.MouseLeave
        Panel3.Size = New Size(65, 61)
    End Sub
    '_________________________________________________________________________________________________________________

    Private Sub Panel4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.MouseHover
        Panel4.Size = New Size(76, 73)
    End Sub

    Private Sub Panel4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.MouseLeave
        Panel4.Size = New Size(73, 70)
    End Sub
    '_________________________________________________________________________________________________________________

    Private Sub Panel5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.MouseHover
        Panel5.Size = New Size(76, 73)
    End Sub

    Private Sub Panel5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.MouseLeave
        Panel5.Size = New Size(73, 70)
    End Sub
    '_________________________________________________________________________________________________________________

    Private Sub Panel6_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.MouseHover
        Panel6.Size = New Size(65, 57)
    End Sub

    Private Sub Panel6_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.MouseLeave
        Panel6.Size = New Size(62, 54)
    End Sub
    '_________________________________________________________________________________________________________________

    'dirigimos los botones
    Private Sub Panel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel2.Click
        Me.Hide()
        Facturacion.Show()
    End Sub

    Private Sub Panel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel3.Click
        Me.Hide()
        Stock_de_Productos.Show()

    End Sub

    Private Sub Panel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel4.Click
        Me.Hide()
        Consulta_proveedor.Show()
    End Sub

    Private Sub Panel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.Click
        Me.Hide()
        Clientes.Show()

    End Sub

    Private Sub Panel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel6.Click
        End
    End Sub
    'Mostramos fecha y hora
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        hora.Text = TimeOfDay.TimeOfDay.ToString
        fecha.Text = DateString
    End Sub

  
 
    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
End Class
=======
﻿Imports System.Windows.Forms
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
        panetlstock.Visible = False
        Panelproveedores.Visible = False
        Panelclientes.Visible = False
        'true and false para que si haces click de nuevo desaparezca
        PanelFact.Visible = True And PanelFact.Visible = False


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
        panetlstock.Visible = False
        Panelproveedores.Visible = False
        PanelFact.Visible = False
        'true and false para que si haces click de nuevo desaparezca
        Panelclientes.Visible = True And Panelclientes.Visible = False

    End Sub

    Private Sub btnconsultclient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultclient.Click
        Panelclientes.Visible = False
    End Sub

    Private Sub btndeudores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeudores.Click
        Panelclientes.Visible = False
    End Sub
    '____________________________________________________________________________________________________________________________________________

    Private Sub btnstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstock.Click
        'Abro el panel pero hago que se oculten los demás si están abiertos ,para no entreverarse

        Panelclientes.Visible = False
        PanelFact.Visible = False
        Panelproveedores.Visible = False
        'true and false para que si haces click de nuevo desaparezca
        panetlstock.Visible = True And panetlstock.Visible = False


    End Sub
    '___________________________________________________________________________________________________________________________________________

    Private Sub btnprov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprov.Click
        'ocultamos pestaña en pantalla y aparece proveedores
        panetlstock.Visible = False
        Panelclientes.Visible = False
        PanelFact.Visible = False
        'true and false para que si haces click de nuevo desaparezca
        Panelproveedores.Visible = True And Panelproveedores.Visible = False

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
        End
    End Sub

    Private Sub PictureBoxsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBoxsalir.Click
        End
    End Sub

    Private Sub btnaddstock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddstock.Click
        Me.Hide()
        Stock_de_Productos.Show()

    End Sub



    Private Sub btnmodistock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodistock.Click
        Me.Hide()
        EliminarSotck.Show()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        hora.Text = TimeOfDay.TimeOfDay.ToString
        Fecha.Text = DateString
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        MonthCalendar1.Visible = True And MonthCalendar1.Visible = False

    End Sub


    Private Sub calculadora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculadoraImg.Click
        Calculadora.Show()

    End Sub

 
End Class
>>>>>>> d19429f7d8081b4cb9859b313d55c7febe1d6b68
