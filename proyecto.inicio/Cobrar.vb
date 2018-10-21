Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class Cobrar
    'Variables para mover form en none
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'MOVER FORM EN NONE
    Private Sub barratitulo_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles barratitulo.MouseDown
        If e.Button = MouseButtons.Left Then

            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y

        End If

    End Sub


    Private Sub barratitulo_MouseMove_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles barratitulo.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)

            Me.Location = temp

            temp = Nothing

        End If
    End Sub

    Private Sub barratitulo_MouseUp_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles barratitulo.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub buscarClientebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarClientebtn.Click
        Me.Hide()
        BuscarClientesCobrar.Show()
    End Sub

    Private Sub atrasbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atrasbtn.Click
        Me.Hide()
        RealizarFactura.Show()

    End Sub

    Private Sub btnmini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class