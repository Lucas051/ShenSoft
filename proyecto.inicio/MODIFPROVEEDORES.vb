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

        conexioon.Consulta = "SELECT * FROM proveedores"
        consultar()
        datafrancoxd.DataSource = resultado

        datafrancoxd.Columns(0).HeaderText = "ID"
        datafrancoxd.Columns(1).HeaderText = "Proveedor"
        datafrancoxd.Columns(2).HeaderText = "Teléfono"
        datafrancoxd.Columns(3).HeaderText = "Dirección"
        datafrancoxd.Columns(4).HeaderText = "Saldo"

    End Sub

    Private Sub limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles limpiar.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

    End Sub

    Private Sub volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volver.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub MODIFPROVEEDORES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        conexioon.Consulta = "SELECT * FROM proveedores;"
        consultar()
        datafrancoxd.DataSource = resultado

        datafrancoxd.Columns(0).HeaderText = "ID"
        datafrancoxd.Columns(1).HeaderText = "Proveedor"
        datafrancoxd.Columns(2).HeaderText = "Teléfono"
        datafrancoxd.Columns(3).HeaderText = "Dirección"
        datafrancoxd.Columns(4).HeaderText = "Saldo"

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub editar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editar.Click
        Me.Hide()
        Buscar_proveedores.Show()
    End Sub

    Private Sub btnmini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cerrarbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cerrarbtn.Click
        End
    End Sub

End Class