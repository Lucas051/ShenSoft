Imports MySql.Data.MySqlClient

Public Class SuspenderStock

    Private Sub EliminarStock_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Try
            conexioon.Consulta = "SELECT * FROM stock WHERE cantidad <> 0"
            consultar()
            dgvEliminar.DataSource = resultado

            dgvEliminar.Columns(0).HeaderText = "Código"
            dgvEliminar.Columns(1).HeaderText = "Descripcion"
            dgvEliminar.Columns(2).HeaderText = "Cantidad"
            dgvEliminar.Columns(3).HeaderText = "Precio Costo"
            dgvEliminar.Columns(4).HeaderText = "Precio Venta"
            dgvEliminar.Columns(5).HeaderText = "N° Factura Perteneciente"

            'ancho de columnas dgv
            dgvEliminar.Columns(0).Width = 60
            dgvEliminar.Columns(1).Width = 200
            dgvEliminar.Columns(2).Width = 100
            dgvEliminar.Columns(3).Width = 150
            dgvEliminar.Columns(4).Width = 150
            dgvEliminar.Columns(5).Width = 158


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub


    Private Sub btnsuspender_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsuspender.Click
        Try

            conexioon.Consulta = " UPDATE stock SET cantidad = 0 WHERE cod_producto ='" + Str(txtcodigo.Text) + "'"
            consultar()

            MessageBox.Show("Dato Suspendido Correctamente.")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Try
            conexioon.Consulta = "SELECT * FROM stock WHERE cantidad <> 0"
            consultar()
            dgvEliminar.DataSource = resultado

            dgvEliminar.Columns(0).HeaderText = "Código"
            dgvEliminar.Columns(1).HeaderText = "Descripcion"
            dgvEliminar.Columns(2).HeaderText = "Cantidad"
            dgvEliminar.Columns(3).HeaderText = "Precio Costo"
            dgvEliminar.Columns(4).HeaderText = "Precio Venta"
            dgvEliminar.Columns(5).HeaderText = "N° Factura Perteneciente"


            'ancho de columnas dgv
            dgvEliminar.Columns(0).Width = 60
            dgvEliminar.Columns(1).Width = 200
            dgvEliminar.Columns(2).Width = 100
            dgvEliminar.Columns(3).Width = 150
            dgvEliminar.Columns(4).Width = 150
            dgvEliminar.Columns(5).Width = 158
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub




    Private Sub btnMostrarStock_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarStock.Click

        Try
            conexioon.Consulta = "SELECT * FROM stock WHERE cantidad = 0"
            consultar()
            dgvEliminar.DataSource = resultado
            dgvEliminar.Columns(0).HeaderText = "Código"
            dgvEliminar.Columns(1).HeaderText = "Descripcion"
            dgvEliminar.Columns(2).HeaderText = "Cantidad"
            dgvEliminar.Columns(3).HeaderText = "Precio Costo"
            dgvEliminar.Columns(4).HeaderText = "Precio Venta"
            dgvEliminar.Columns(5).HeaderText = "N° Factura Perteneciente"


            'ancho de columnas dgv
            dgvEliminar.Columns(0).Width = 60
            dgvEliminar.Columns(1).Width = 200
            dgvEliminar.Columns(2).Width = 100
            dgvEliminar.Columns(3).Width = 150
            dgvEliminar.Columns(4).Width = 150
            dgvEliminar.Columns(5).Width = 158

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancelarSusp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarSusp.Click
        Try

            conexioon.Consulta = " UPDATE stock SET cantidad = 1 WHERE cod_producto ='" + Str(txtcodigo.Text) + "'"
            consultar()

            MessageBox.Show("Se ha cancelado Suspención del artículo.")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Try
            conexioon.Consulta = "SELECT * FROM stock WHERE cantidad <> 0"
            consultar()
            dgvEliminar.DataSource = resultado

            dgvEliminar.Columns(0).HeaderText = "Código"
            dgvEliminar.Columns(1).HeaderText = "Descripcion"
            dgvEliminar.Columns(2).HeaderText = "Cantidad"
            dgvEliminar.Columns(3).HeaderText = "Precio Costo"
            dgvEliminar.Columns(4).HeaderText = "Precio Venta"
            dgvEliminar.Columns(5).HeaderText = "N° Factura Perteneciente"


            'ancho de columnas dgv
            dgvEliminar.Columns(0).Width = 60
            dgvEliminar.Columns(1).Width = 200
            dgvEliminar.Columns(2).Width = 100
            dgvEliminar.Columns(3).Width = 150
            dgvEliminar.Columns(4).Width = 150
            dgvEliminar.Columns(5).Width = 158
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
