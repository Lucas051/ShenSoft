Public Class Clientes

    Private Property Buscar_clientes As Object

    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        MODIFCLIENTES.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Buscar_clientes.Show()
    End Sub

    Private Function MODIFCLIENTES() As Object
        Throw New NotImplementedException
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Inicio.Show()

    End Sub
End Class