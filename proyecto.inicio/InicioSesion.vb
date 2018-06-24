Public Class InicioSesion

   
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        'verificacion
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            Me.Hide()
            Inicio.Show()
        Else
            MsgBox("Incorrecto, intente de nuevo")
        End If

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'sale del sistema
        End
    End Sub


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub InicioSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'muestra contraseña --nose porque no se esconde xd
        If CheckBox1.Checked Then

            TextBox2.UseSystemPasswordChar = False

        Else

            TextBox2.UseSystemPasswordChar = True

        End If
    End Sub
End Class