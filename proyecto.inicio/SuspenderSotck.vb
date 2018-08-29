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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver.Click
        Me.Hide()
        Inicio.Show()

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
        dgvEliminar.Columns(4).HeaderText = "Precio Venta"""
        dgvEliminar.Columns(5).HeaderText = "Proveedor"
    End Sub

    Private Sub dgvEliminar_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEliminar.CellContentClick

    End Sub

    Private Sub btnmini_Click(sender As System.Object, e As System.EventArgs) Handles btnmini.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnrestaurar_Click(sender As System.Object, e As System.EventArgs) Handles btnrestaurar.Click
        'restaura ventana
        Me.WindowState = FormWindowState.Normal
        'esconde boton, aparece maximizar
        btnrestaurar.Visible = False
        btnmaxi.Visible = True
    End Sub

    Private Sub btnmaxi_Click(sender As System.Object, e As System.EventArgs) Handles btnmaxi.Click
        Me.WindowState = FormWindowState.Maximized

        btnmaxi.Visible = False
        btnrestaurar.Visible = True
    End Sub

    Private Sub cerrarbtn_Click(sender As System.Object, e As System.EventArgs) Handles cerrarbtn.Click
        End
    End Sub

    Private Sub barratitulo_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles barratitulo.Paint

    End Sub
End Class
