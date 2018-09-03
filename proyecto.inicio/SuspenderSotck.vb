Imports MySql.Data.MySqlClient

Public Class SuspenderStock

    Private Sub EliminarStock_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        conexioon.Consulta = "SELECT * FROM stock WHERE cantidad <> 0"
        consultar()
        dgvEliminar.DataSource = resultado

        dgvEliminar.Columns(0).HeaderText = "Código"
        dgvEliminar.Columns(1).HeaderText = "Descripcion"
        dgvEliminar.Columns(2).HeaderText = "Cantidad"
        dgvEliminar.Columns(3).HeaderText = "Precio Costo"
        dgvEliminar.Columns(4).HeaderText = "Precio Venta"""
        dgvEliminar.Columns(5).HeaderText = "Proveedor"

    End Sub

   





    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsuspender.Click
        Try

            conexioon.Consulta = " UPDATE stock SET cantidad = 0 WHERE cod_producto ='" + Str(txtcodigo.Text) + "'"
            consultar()

            MessageBox.Show("Dato Suspendido Correctamente.")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        conexioon.Consulta = "SELECT * FROM stock WHERE cantidad <> 0"
        consultar()
        dgvEliminar.DataSource = resultado

        dgvEliminar.Columns(0).HeaderText = "Código"
        dgvEliminar.Columns(1).HeaderText = "Descripcion"
        dgvEliminar.Columns(2).HeaderText = "Cantidad"
        dgvEliminar.Columns(3).HeaderText = "Precio Costo"
        dgvEliminar.Columns(4).HeaderText = "Precio Venta"
        dgvEliminar.Columns(5).HeaderText = "Proveedor"
    End Sub

    
    

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        conexioon.Consulta = "SELECT * FROM stock WHERE cantidad = 0"
        consultar()
        dgvEliminar.DataSource = resultado
        dgvEliminar.Columns(0).HeaderText = "Código"
        dgvEliminar.Columns(1).HeaderText = "Descripcion"
        dgvEliminar.Columns(2).HeaderText = "Cantidad"
        dgvEliminar.Columns(3).HeaderText = "Precio Costo"
        dgvEliminar.Columns(4).HeaderText = "Precio Venta"
        dgvEliminar.Columns(5).HeaderText = "Proveedor"
    End Sub

    
End Class
