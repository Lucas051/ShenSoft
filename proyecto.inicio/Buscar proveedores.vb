Imports MySql.Data.MySqlClient
Public Class Buscar_proveedores
    Dim resultado As DataTable
    Dim conexion As MySqlDataAdapter
    'Dim mysqlconexion As MySqlConnection = New MySqlConnection(ubicacion)

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID.Click

    End Sub

    'fail n°1 de eliminar :v
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
            'eliminar = "DELETE FROM proveedores WHERE num_prov= '" & TextBox1.Text & "'"
            consultar()
        conexioon.Consulta = "DELETE FROM proveedores WHERE num_prov= '" & TextBox1.Text & "'"
        consultar()
        dgvfran.DataSource = resultado



        MessageBox.Show("Dato Eliminado Correctamente.")

        conexioon.Consulta = "SELECT * FROM stock"
        consultar()
        dgvfran.DataSource = resultado

        dgvfran.Columns(0).HeaderText = "Codigo"
        dgvfran.Columns(1).HeaderText = "Proveedor"
        dgvfran.Columns(2).HeaderText = "Teléfono"
        dgvfran.Columns(3).HeaderText = "Dirección"
        dgvfran.Columns(4).HeaderText = "Saldo"


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim consulta As String
        ' Dim lista As Byte
        ' If TextBox1.Text <> "" Then
        ' consulta = "SELECT * FROM proveedores WHERE num_prov= '" & TextBox1.Text & "'"
        'conexion = New MySqlDataAdapter(consulta, ubicacion)
        'resultado = DataTable


        'aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa
    End Sub


    'intento visualizar datos en dgv. este anda cuando quiere xd

    Private Sub Buscar_proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        conexioon.Consulta = "SELECT * FROM proveedores;"
        consultar()
        dgvfran.DataSource = resultado

        dgvfran.Columns(0).HeaderText = "ID"
        dgvfran.Columns(1).HeaderText = "Proveedor"
        dgvfran.Columns(2).HeaderText = "Teléfono"
        dgvfran.Columns(3).HeaderText = "Dirección"
        dgvfran.Columns(4).HeaderText = "Saldo"

    End Sub
End Class