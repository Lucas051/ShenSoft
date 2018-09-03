Public Class formnuevo

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim var As New Stock_de_Productos
        Panel1.Controls.Clear()
        var.TopLevel = False
        var.Parent = Panel1
        var.Show()
        var.Dock = DockStyle.Fill

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim var1 As New Buscar_proveedores
        Panel1.Controls.Clear()
        var1.TopLevel = False
        var1.Parent = Panel1
        var1.Show()
        var1.Dock = DockStyle.Fill


    End Sub
End Class