Public Class GestionFacturacion


    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultaVentas.Click
        Dim llamarConsultaV As New ConsultaVentas
        Inicio.panelmedio.Controls.Clear()
        llamarConsultaV.TopLevel = False
        llamarConsultaV.Parent = Inicio.panelmedio
        llamarConsultaV.Show()
        llamarConsultaV.Dock = DockStyle.Fill
        Inicio.panelmedio.Visible = True
    End Sub

    Private Sub btnFactProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactProv.Click
        Dim llamarConsultaProv As New FacturasProveedores
        Inicio.panelmedio.Controls.Clear()
        llamarConsultaProv.TopLevel = False
        llamarConsultaProv.Parent = Inicio.panelmedio
        llamarConsultaProv.Show()
        llamarConsultaProv.Dock = DockStyle.Fill
        Inicio.panelmedio.Visible = True
    End Sub

    Private Sub btnPagosProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagosProv.Click
        Dim llamarPagosProv As New PagosProv
        Inicio.panelmedio.Controls.Clear()
        llamarPagosProv.TopLevel = False
        llamarPagosProv.Parent = Inicio.panelmedio
        llamarPagosProv.Show()
        llamarPagosProv.Dock = DockStyle.Fill
        Inicio.panelmedio.Visible = True
    End Sub

    Private Sub btnPagosClie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagosClie.Click
        Dim llamarPagosCli As New PagosClientes
        Inicio.panelmedio.Controls.Clear()
        llamarPagosCli.TopLevel = False
        llamarPagosCli.Parent = Inicio.panelmedio
        llamarPagosCli.Show()
        llamarPagosCli.Dock = DockStyle.Fill
        Inicio.panelmedio.Visible = True
    End Sub

    Private Sub GestionFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (user = "Gerentes" And pass = "963") Then
            'oculta btn a los que el usuario no tiene permiso de ingresar
            btnPagosProv.Enabled = False
            btnFactProv.Enabled = False

        ElseIf (user = "Empleado" And pass = "123") Then
            'oculta btn a los que el usuario no tiene permiso de ingresar
            btnPagosProv.Enabled = False
            btnFactProv.Enabled = False

        End If
    End Sub
End Class


