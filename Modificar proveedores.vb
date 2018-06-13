Imports MySql.Data.MySqlClient
Public Class proveedores


    Private Sub añadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles añadir.Click
        'Dim sql As String
        Dim connect As New MySqlConnection
        Dim comando As MySqlCommand

        Try
            connect.Open()
            'If (TextBox3.Text <> "" And TextBox2.Text <> "" And TextBox1.Text <> "") Then

            'sql = "INSERT INTO proveedores (nombre_prov,tel_p,direccion_p,) VALUES ('" + proveedor.Text + "' , '" + telefono.Text + "','" + direccion.Text + "' )"

            comando = New MySqlCommand("INSERT into proveedores (nombre_prov,tel_p,direccion_p)" & Chr(13) &
                                       "VALUES(@nombre_prov,tel_p,direccion_p)", connect)
            comando.Parameters.AddWithValue("@nombre_prov", TextBox3.Text)
            comando.Parameters.AddWithValue("@tel_p", TextBox2.Text)
            comando.Parameters.AddWithValue("@direccion_p", TextBox1.Text)
            comando.ExecuteNonQuery()

            MessageBox.Show("Datos Guardados Satisfactoriamente.")
            MessageBox.Show("El ID proveedores se agrega automaticamente.")

            ' Else
            MessageBox.Show("Campos sin completar.")
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub


    Private Sub proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volver.Click
        Me.Hide()
        Consulta_proveedor.Show()
    End Sub

    Private Sub limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiar.Click

        proveedor.Text = ""
        telefono.Text = ""
        direccion.Text = ""

    End Sub
End Class