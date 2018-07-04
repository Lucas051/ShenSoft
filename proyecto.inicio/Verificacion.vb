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
        If txtpass.Text = "CONTRASEÑA" Then
            txtpass.Text = ""
            txtpass.ForeColor = Color.LightGray
            'oculta contraseña
            txtpass.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub txtpass_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpass.Leave
        'si no hay nada escrito vuelve a usuario con fuente original
        If txtpass.Text = "" Then
            txtpass.Text = "CONTRASEÑA"
            txtpass.ForeColor = Color.DimGray
            txtpass.UseSystemPasswordChar = False

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

    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
        Me.Hide()
        Inicio.Show()
        'por el momento dejamos la seguridad como segundo plano, para poder seguir con otras funciones mas importantes del programa
    End Sub
End Class