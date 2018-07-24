Public Class BuscarClientesFact

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Cobrar.Show()

    End Sub

    Private Sub BuscarClientesFact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexioon.Consulta = "SELECT * FROM clientes"
        consultar()
        DGClientesFac.DataSource = resultado
        'eliminar = "DELETE FROM proveedores WHERE num_prov= '" & TextBox1.Text & "'"
        consultar()
        conexioon.Consulta = "DELETE FROM proveedores WHERE num_prov= '" & TextBox1.Text & "'"
        consultar()
        dgvfran.DataSource = resultado



        MessageBox.Show("Dato Eliminado Correctamente.")

        conexioon.Consulta = "SELECT * FROM stock"
        consultar()
        dgvfran.DataSource = resultado

        DGClientesFac.Columns(0).HeaderText = "Número Cliente"
        DGClientesFac.Columns(1).HeaderText = "CI"
        DGClientesFac.Columns(2).HeaderText = "Nombre"
        DGClientesFac.Columns(3).HeaderText = "Saldo"
        DGClientesFac.Columns(4).HeaderText = "Direccion"
        DGClientesFac.Columns(5).HeaderText = "Telefono"
    End Sub

    Private Sub DGClientesFac_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGClientesFac.CellClick
        'Mediante el evento indicamos hacia donde van los valores seleccionados
        Cobrar.TextBoxcliente.Text = DGClientesFac.CurrentRow.Cells(0).Value.ToString
        'close para cerrar el form
        Close()
        Cobrar.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim consulta As String
        ' Dim lista As Byte
        ' If TextBox1.Text <> "" Then
        ' consulta = "SELECT * FROM clientes WHERE num_prov= '" & TextBox1.Text & "'"
        'conexion = New MySqlDataAdapter(consulta, ubicacion)
        'resultado = DataTable


        'aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    End Sub

    Private Function dgvfran() As Object
        Throw New NotImplementedException
    End Function

End Class