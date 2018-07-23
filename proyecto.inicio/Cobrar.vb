<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿Public Class Cobrar

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        RealizarFactura.Show()
    End Sub

    Private Sub buscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarCliente.Click
        Me.Hide()
        BuscarClientesFact.Show()

    End Sub
=======
﻿Public Class Cobrar

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        RealizarFactura.Show()
    End Sub

    Private Sub buscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarCliente.Click
        Me.Hide()
        BuscarClientesFact.Show()

    End Sub
>>>>>>> b9ac1fc0ad416c297c35c829e7c17ad9a49cbaf6
=======
﻿Public Class Cobrar

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        RealizarFactura.Show()
    End Sub

    Private Sub buscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarCliente.Click
        Me.Hide()
        BuscarClientesFact.Show()

    End Sub
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
=======
﻿Public Class Cobrar

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        RealizarFactura.Show()
    End Sub

    Private Sub buscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarCliente.Click
        Me.Hide()
        BuscarClientesFact.Show()

    End Sub
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
=======
﻿Public Class Cobrar

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

    Private Sub btnrestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrestaurar.Click
        'restaura ventana
        Me.WindowState = FormWindowState.Normal
        'esconde boton, aparece maximizar
        btnrestaurar.Visible = False
        btnmaxi.Visible = True
    End Sub

    Private Sub btnmini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmini.Click
        'minimiza
        Me.WindowState = FormWindowState.Minimized
    End Sub
  
    Private Sub atras_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atras.Click
        Me.Hide()
        RealizarFactura.Show()
    End Sub

    Private Sub buscarCliente_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarCliente.Click
        Me.Hide()
        BuscarClientesFact.Show()
    End Sub
>>>>>>> d19429f7d8081b4cb9859b313d55c7febe1d6b68
End Class