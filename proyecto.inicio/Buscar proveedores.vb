Public Class Buscar_proveedores
    Private Sub Buscar_proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            conexioon.Consulta = "SELECT * FROM proveedores;"
            consultar()
            dgvfran.DataSource = resultado

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try

            conexioon.Consulta = "SELECT * FROM proveedores WHERE nombre_prov LIKE '%" & TextBox1.Text & "%';"
            consultar()
            dgvfran.DataSource = resultado

        Catch ex As Exception

        End Try
    End Sub
End Class