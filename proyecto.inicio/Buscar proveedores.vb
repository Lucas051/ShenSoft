
Public Class Buscar_proveedores
  
    Private Sub Buscar_proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'CARGAR EL DGV
        Try
            conexioon.Consulta = "SELECT * FROM proveedores;"
            consultar()
            dgvfran.DataSource = resultado

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub txtbuscarprov_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscarprov.TextChanged
        Try
            'BUSQUEDA EN DATAGRIDVIEW
            conexioon.Consulta = "SELECT * FROM proveedores WHERE nombre_prov LIKE '%" & txtbuscarprov.Text & "%';"
            consultar()
            dgvfran.DataSource = resultado

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnvolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver.Click
        Me.Hide()
        Inicio.Show()
    End Sub
End Class