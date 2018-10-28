Public Class MODIFICARCLIENTES


    Private Sub MODIFICARCLIENTES_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        conexioon.Consulta = "SELECT * FROM clientes"
        consultar()
        DgvClientes.DataSource = resultado

        'Cambiar el nombre que tienen las columnas de Mysql esos "cod_producto" etc
        DgvClientes.Columns(0).HeaderText = "Código"
        DgvClientes.Columns(1).HeaderText = "Cédula"
        DgvClientes.Columns(2).HeaderText = "Nombre"
        DgvClientes.Columns(3).HeaderText = "Saldo"
        DgvClientes.Columns(4).HeaderText = "Direccion"
        DgvClientes.Columns(5).HeaderText = "Telefono"
    End Sub

    Private Sub btnañadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnañadir.Click

        Try

            If (txtcedula.Text <> "" And txtdireccion.Text <> "" And txtnombre.Text <> "" And txttelefono.Text <> "") Then
                conexioon.Consulta = "INSERT INTO clientes (CI,nombre_cliente,direccion_c,tel_c) VALUES ('" + txtcedula.Text + "','" + txtnombre.Text + "','" + txtdireccion.Text + "','" + txttelefono.Text + "');"
                consultar()
                DgvClientes.DataSource = resultado

                Consulta = "SELECT * FROM clientes"
                consultar()
                DgvClientes.DataSource = resultado

                'Cambiar el nombre que tienen las columnas de Mysql esos "cod_producto" etc
                DgvClientes.Columns(0).HeaderText = "Código"
                DgvClientes.Columns(1).HeaderText = "Cédula"
                DgvClientes.Columns(2).HeaderText = "Nombre"
                DgvClientes.Columns(3).HeaderText = "Direccion"
                DgvClientes.Columns(4).HeaderText = "Telefono"
                DgvClientes.Columns(5).HeaderText = "Saldo"
                txtcedula.Text = ""
                txtdireccion.Text = ""
                txtnombre.Text = ""
                txtsaldo.Text = ""
                txttelefono.Text = ""

            Else
                MessageBox.Show("Debes rellenar todos los campos")

            End If

        Catch ex As Exception

            MessageBox.Show(ex.ToString)

        End Try

    End Sub

    Private Sub btnborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborrar.Click

        txtcedula.Text = ""
        txtdireccion.Text = ""
        txtnombre.Text = ""
        txtsaldo.Text = ""
        txttelefono.Text = ""

    End Sub
End Class