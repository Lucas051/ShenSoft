Imports MySql.Data.MySqlClient

Public Class Stock_de_Productos


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        'Dim sql As String
        Dim connect As New MySqlConnection
        Dim comando As MySqlCommand

        Try
            'connect = conn
            If (txtdescripcion.Text <> "" And txtprecio.Text <> "" And txtpreciostock.Text <> "") Then

                Consulta = "INSERT INTO stock (descripcion,precio_costo,precio_v_stock) VALUES ('" + txtdescripcion.Text + "' , '" + txtprecio.Text + "','" + txtpreciostock.Text + "' )"
                
                comando = New MySqlCommand(Consulta, connect)
                comando.ExecuteNonQuery()

                MessageBox.Show("Datos Guardados Correctamente.")
                MessageBox.Show("El ID producto se agrega automaticamente jaja salu2.")

            Else
                MessageBox.Show("Se deben rellenar todos los compos.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        txtdescripcion.Text = ""
        txtprecio.Text = ""
        txtpreciostock.Text = ""


    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        EliminarSotck.Show()

    End Sub

    Private Sub Stock_de_Productos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Codigo para insertar en un DataGridView creado datos de una tabla Mysql en este caso Stock
        Consulta = "select * from stock"
        consultar()
        DataGridView1.DataSource = resultado

        'Cambiar el nombre que tienen las columnas de Mysql esos "cod_producto" etc
        DataGridView1.Columns(0).HeaderText = "Código"
        DataGridView1.Columns(1).HeaderText = "Descripcion"
        DataGridView1.Columns(2).HeaderText = "Precio Costo"
        DataGridView1.Columns(3).HeaderText = "Precio Venta"
        DataGridView1.Columns(4).HeaderText = "Proveedor"
        'Proximamente Solo en Cines
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtdescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescripcion.TextChanged

    End Sub
End Class