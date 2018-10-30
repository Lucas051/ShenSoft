Imports System.Runtime.InteropServices
Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Public Class Verificacion

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=lapolleriabd")

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

        Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=lapolleriabd")

    End Sub

    Private Sub btningresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click


        Dim command As New MySqlCommand("SELECT `user`, `pass` FROM `usuarios` WHERE `user` = @username AND `pass` = @password", connection)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = txtuser.Text
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtpass.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Contraseña o Usuario Incorrecto", "Error al Ingresar")

        Else

            MessageBox.Show("Ingreso exitoso!", "Datos Verificados")

            NivelAcceso = txtuser.Text

            If NivelAcceso = "Dueños" Then
                Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=Dueños;password=456;database=lapolleriabd")
                ' .TabUsuarios.Enabled = False
                'Resto de acciones permitidas




            ElseIf NivelAcceso = "Gerentes" Then
                Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=Gerentes;password=963;database=lapolleriabd")
                ' .TabUsuarios.Enabled = False
                'Resto de acciones permitidas



            ElseIf NivelAcceso = "Empleado" Then
                Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=Empleado;password=123;database=lapolleriabd")
                ' .TabUsuarios.Enabled = False
                'Resto de acciones permitidas
            End If
            Me.Hide()
            Inicio.Show()
            txtuser.Clear()
            txtpass.Clear()
        End If
    End Sub


End Class