Imports MySql.Data.MySqlClient
Public Class Gestionproveedores

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnañadir.Click

        Try

            If (txtproveedor.Text <> "" And txttelefono.Text <> "" And txtdireccion.Text <> "" And txtsaldo.Text <> "") Then

                conexioon.Consulta = "INSERT INTO proveedores (nombre_prov,tel_p,direccion_p,saldo_p) VALUES ('" + txtproveedor.Text + "' , '" + txttelefono.Text + "','" + txtdireccion.Text + "','" + txtsaldo.Text + "' )"
                consultar()

                dgvproveedores.DataSource = resultado
                Consulta = "Select * from Proveedores"
                consultar()
                dgvproveedores.DataSource = resultado

                MessageBox.Show("Datos Guardados.")

            Else
                MessageBox.Show("Se deben completar todos los campos.")
            End If

        Catch ex As Exception

            MessageBox.Show(ex.ToString)

        End Try

    End Sub

    Private Sub limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpiar.Click
        txtproveedor.Text = ""
        txttelefono.Text = ""
        txtdireccion.Text = ""
        txtsaldo.Text = ""
    End Sub

    Private Sub volver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub MODIFPROVEEDORES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        conexioon.Consulta = "SELECT * FROM proveedores;"
        consultar()
        dgvproveedores.DataSource = resultado

        dgvproveedores.Columns(0).HeaderText = "ID"
        dgvproveedores.Columns(1).HeaderText = "Proveedor"
        dgvproveedores.Columns(2).HeaderText = "Teléfono"
        dgvproveedores.Columns(3).HeaderText = "Dirección"
        dgvproveedores.Columns(4).HeaderText = "Saldo"

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscarprov.Click
        Dim llamar As New Buscar_proveedores
        Inicio.panelmedio.Controls.Clear()
        llamar.TopLevel = False
        llamar.Parent = Inicio.panelmedio
        llamar.Show()
        llamar.Dock = DockStyle.Fill
        Inicio.panelmedio.Visible = True
    End Sub
End Class