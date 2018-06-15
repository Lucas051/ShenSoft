Imports MySql.Data.MySqlClient
Public Class buscarfactura

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        conexioon.Consulta = "SELECT * FROM stock"
        consultar()
        DataGridbuscar.DataSource = resultado

        'Nombramos los encabezados del datagrid buscar

        DataGridbuscar.Columns(0).HeaderText = "Código"
        DataGridbuscar.Columns(1).HeaderText = "Descrip."
        DataGridbuscar.Columns(2).HeaderText = "Cantidad"
        DataGridbuscar.Columns(3).HeaderText = "Precio Costo"
        DataGridbuscar.Columns(4).HeaderText = "Precio Venta"
        DataGridbuscar.Columns(5).HeaderText = "Proveedor"
    End Sub

    Private Sub atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atras.Click
        Me.Hide()
        RealizarFactura.Show()
    End Sub

    Private Sub DataGridbuscar_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridbuscar.CellClick
        'Mediante el evento indicamos hacia donde van los valores seleccionados
        RealizarFactura.codigo.Text = DataGridbuscar.CurrentRow.Cells(0).Value.ToString
        RealizarFactura.desc.Text = DataGridbuscar.CurrentRow.Cells(1).Value.ToString
        RealizarFactura.cant.Text = DataGridbuscar.CurrentRow.Cells(2).Value.ToString
        RealizarFactura.precioov.Text = DataGridbuscar.CurrentRow.Cells(4).Value.ToString
        'close para cerrar el form
        Close()
        RealizarFactura.Show()

    End Sub

    Private Sub DataGridbuscar_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridbuscar.CellContentClick

    End Sub
End Class