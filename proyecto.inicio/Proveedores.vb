Imports MySql.Data.MySqlClient

Public Class Proveedores

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conexion As New MySqlConnection
        Dim comando As MySqlCommand
        Dim sql As String

        conexion = conn
        sql = "SELECT * FROM proveedores"
        conexion.Open()

        comando = New MySqlCommand(sql, conexion)
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(comando)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conexion.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        Dim connect As New MySqlConnection
        Dim comando As MySqlCommand
        Try
            connect = conn

            If (proveedor.Text <> "" And telefono.Text <> "" And direccion.Text <> "") Then

                sql = "insert into proveedores (nombre_prov,tel_p,direccion_p) values ('" + proveedor.Text + " , '" + telefono.Text + "','" + direccion.Text(+"' )")
                connect.Open()
                comando = New MySqlCommand(sql, connect)
                comando.ExecuteNonQuery()

                MessageBox.Show("Datos Guardados Satisfactoriamente")
                MessageBox.Show("El numero de prov se agrega automaticamente")
            Else
                MessageBox.Show("Se deben completar todos los compos.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Public Sub consulta(ByVal sql As String, ByVal tabla As String)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        proveedor.Text = ""
        telefono = ""  ''que pasa aqui chavales
        direccion.Text = ""
    End Sub

    Private Sub volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volver.Click

        volver.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'proveedor.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        'direccion.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        'telefono.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value

    End Sub
End Class
