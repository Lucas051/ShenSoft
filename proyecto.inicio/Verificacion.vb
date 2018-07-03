Imports System.Runtime.InteropServices

Public Class Verificacion

    Private Sub txtuser_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuser.Enter
        'Desaparece nombre de textbox
        If txtuser.Text = "USUARIO" Then
            txtuser.Text = ""
            txtuser.ForeColor = Color.LightGray

        End If
    End Sub

    Private Sub txtuser_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuser.Leave
        'si no hay nada escrito vuelve a usuario con fuente original
        If txtuser.Text = "" Then
            txtuser.Text = "USUARIO"
            txtuser.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub txtpass_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.Enter
        'Desaparece nombre de textbox
        If txtuser.Text = "CONTRASEÑA" Then
            txtuser.Text = ""
            txtuser.ForeColor = Color.LightGray
            'txtuser.UseSystemPasswordChar = True

            'CHE, NOSE PORQUE CUANDO USO EL PASSCHAR ME ANULA TODA LA ACCION Y NO ME OCULTA LA CONTRASEÑA, A USTEDES LE ANDA?
        End If
    End Sub

    Private Sub txtpass_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.Leave
        'si no hay nada escrito vuelve a usuario con fuente original
        If txtuser.Text = "" Then
            txtuser.Text = "CONTRASEÑA"
            txtuser.ForeColor = Color.DimGray
            'txtuser.UseSystemPasswordChar = False

        End If
    End Sub

    Private Sub cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cerrar.Click
        End
    End Sub

    Private Sub minimizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Verificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'agregar para que se pueda mover la ventana
    End Sub
End Class