Imports MySql.Data.MySqlClient
Public Class MODIFPROVEEDORES

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles añadir.Click

        Try

            If (TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "") Then

                conexioon.Consulta = "INSERT INTO proveedores (nombre_prov,tel_p,direccion_p,saldo_p) VALUES ('" + TextBox2.Text + "' , '" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox1.Text + "' )"
                consultar()
                datafrancoxd.DataSource = resultado

                MessageBox.Show("Datos Guardados.")

            Else
                MessageBox.Show("Se deben completar todos los campos.")
            End If

        Catch ex As Exception

            MessageBox.Show(ex.ToString)

        End Try
        
    End Sub

    Private Sub limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiar.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volver.Click
        Me.Hide()
        Consulta_proveedor.Show()
    End Sub

    Private Sub MODIFPROVEEDORES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        conexioon.Consulta = "SELECT * FROM proveedores;"
        consultar()
        datafrancoxd.DataSource = resultado

        datafrancoxd.Columns(0).HeaderText = "ID"
        datafrancoxd.Columns(1).HeaderText = "Proveedor"
        datafrancoxd.Columns(2).HeaderText = "Teléfono"
        datafrancoxd.Columns(3).HeaderText = "Dirección"

    End Sub
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
=======

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
>>>>>>> b9ac1fc0ad416c297c35c829e7c17ad9a49cbaf6
=======

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
=======

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
End Class