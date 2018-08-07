Public Class MODIFICARCLIENTES

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Inicio.Show()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            If (txtcedula.Text <> "" And txtdireccion.Text <> "" And txtnombre.Text <> "" And txtsaldo.Text <> "" And txttelefono.Text <> "") Then
                conexioon.Consulta = "INSERT INTO clientes (CI,nombre_cliente,saldo_c,direccion_c,tel_c)VALUES(" + txtcedula.Text + "," + txtnombre.Text + "" + txtsaldo.Text + "," + txtdireccion.Text + "" + txtdireccion.Text + "," + txttelefono.Text + ")"
                consultar()
                DgvClientes.DataSource = resultado


            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        DgvClientes.DataSource = resultado

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