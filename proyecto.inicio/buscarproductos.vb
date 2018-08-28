Imports MySql.Data.MySqlClient
Public Class buscarproductos

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conexioon.Consulta = "SELECT * FROM stock"
            consultar()
            dgvbuscarStock.DataSource = resultado
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Nombramos los encabezados del datagrid buscar

        dgvbuscarStock.Columns(0).HeaderText = "Código"
        dgvbuscarStock.Columns(1).HeaderText = "Descrip."
        dgvbuscarStock.Columns(2).HeaderText = "Cantidad"
        dgvbuscarStock.Columns(3).HeaderText = "Precio Costo"
        dgvbuscarStock.Columns(4).HeaderText = "Precio Venta"
        dgvbuscarStock.Columns(5).HeaderText = "Proveedor"
    End Sub

    Private Sub DataGridbuscar_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvbuscarStock.CellClick
        'Mediante el evento indicamos hacia donde van los valores seleccionados
        RealizarFactura.txtcodigo.Text = dgvbuscarStock.CurrentRow.Cells(0).Value.ToString
        RealizarFactura.txtdesc.Text = dgvbuscarStock.CurrentRow.Cells(1).Value.ToString
        RealizarFactura.txtprecioov.Text = dgvbuscarStock.CurrentRow.Cells(4).Value.ToString
        'close para cerrar el form
        Close()
        RealizarFactura.Show()

    End Sub

    Private Sub DataGridbuscar_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvbuscarStock.CellContentClick

    End Sub

    Private Sub atras_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub btnmini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmini.Click
        'minimiza ventana
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnmaxi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmaxi.Click
        'maximiza ventana
        Me.WindowState = FormWindowState.Maximized
        'esconde boton, aparece restaurar
        btnmaxi.Visible = False
        btnrestaurar.Visible = True
    End Sub

    Private Sub btnrestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrestaurar.Click
        'restaura ventana
        Me.WindowState = FormWindowState.Normal
        'esconde boton, aparece maximizar
        btnrestaurar.Visible = False
        btnmaxi.Visible = True
    End Sub

    Private Sub cerrarbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cerrarbtn.Click
        End
    End Sub

    Private Sub txtbuscarFac_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscarFac.TextChanged
        Try
            'BUSQUEDA DINAMICA EN DATAGRIDVIEW
            conexioon.Consulta = "SELECT * FROM stock WHERE cod_producto LIKE '%" & txtbuscarFac.Text & "%' and descripcion LIKE '%" & txtbuscarFac.Text & "%';"
            consultar()
            dgvbuscarStock.DataSource = resultado

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class