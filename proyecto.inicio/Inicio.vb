Public Class Inicio

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

  
 
End Class
