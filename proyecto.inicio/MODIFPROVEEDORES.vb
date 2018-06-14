Imports MySql.Data.MySqlClient
Public Class MODIFPROVEEDORES

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles añadir.Click

        Try
            'connect = conn
            If (TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "") Then

                Consulta = "INSERT INTO proveedores (nombre_prov,tel_p,direccion_p) VALUES ('" + TextBox2.Text + "' , '" + TextBox3.Text + "','" + TextBox4.Text + "' )"
                consultar()

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

        conexioon.Consulta = "SELECT * FROM proveedores;" 'saben porque me da error?
        consultar()
        datafrancoxd.DataSource = resultado

        datafrancoxd.Columns(0).HeaderText = "ID"
        datafrancoxd.Columns(1).HeaderText = "Proveedor"
        datafrancoxd.Columns(2).HeaderText = "Teléfono"
        datafrancoxd.Columns(3).HeaderText = "Dirección"

    End Sub
End Class