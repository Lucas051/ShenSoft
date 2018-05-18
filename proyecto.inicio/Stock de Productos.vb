Imports MySql.Data.MySqlClient

Public Class Stock_de_Productos


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim sql As String
        Dim connect As New MySqlConnection
        Dim comando As MySqlCommand
        Try
            connect = conn
            If (txtdescripcion.Text <> "" And txtprecio.Text <> "" And txtpreciostock.Text <> "") Then

                sql = "INSERT INTO stock (descripcion,precio_costo,precio_v_stock) VALUES ('" + txtdescripcion.Text + "' , '" + txtprecio.Text + "','" + txtpreciostock.Text + "' )"
                connect.Open()
                comando = New MySqlCommand(sql, connect)
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
        Dim conexion As New MySqlConnection
        Dim comando As MySqlCommand
        Dim sql As String

        conexion = conn
        sql = "SELECT * FROM stock"
        conexion.Open()

        comando = New MySqlCommand(sql, conexion)
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(comando)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conexion.Clone()
    End Sub
End Class