Public Class MODIFICARCLIENTES

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver.Click
        Me.Hide()
        Inicio.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
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

            Else
                MessageBox.Show("Debes rellenar todos los campos")

            End If




    End Sub

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
End Class