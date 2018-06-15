Imports MySql.Data.MySqlClient

Public Class EliminarSotck

   Private Sub EliminarStock_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
  

        conexioon.Consulta = "SELECT * FROM stock"
        consultar()
        dgvEliminar.DataSource = resultado

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Stock_de_Productos.Show()

    End Sub





    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim elemento As String
     
        Try
            'Intento de eliminar stock v 0.0.1
        
        elemento = InputBox("Ingrese el Codigo del Producto", "Codigo del producto")
            conexioon.Consulta = "DELETE FROM stock (cod_producto) VALUES ('" + elemento + "')"
            consultar()
            dgvEliminar.DataSource = resultado
            'comando = New MySqlCommand(sql, conn)


            MessageBox.Show("Dato Eliminado Correctamente.")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub dgvEliminar_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEliminar.CellContentClick

    End Sub
End Class
