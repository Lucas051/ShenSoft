Public Class MODIFICARCLIENTES

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver.Click
        Me.Hide()
        Inicio.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
        Try

            If (txtcedula.Text <> "" And txtdireccion.Text <> "" And txtnombre.Text <> "" And txtsaldo.Text <> "" And txttelefono.Text <> "") Then
                conexioon.Consulta = "INSERT INTO clientes (`num_cliente`,`CI`,`nombre_cliente `,`saldo_c`,`direccion_c`,`tel_c`) VALUES ('" + txtcedula.Text + "','" + txtnombre.Text + "','" + txtsaldo.Text + "','" + txtdireccion.Text + "','" + txttelefono.Text + "');"
                consultar()
                DgvClientes.DataSource = resultado
            Else
                MessageBox.Show("Debes rellenar todos los campos")

            End If
            If IsNumeric(txtcedula.Text) And txtcedula.Text.Length = 8 Then
                Dim calc() As Integer = {2, 9, 8, 7, 6, 3, 4}
                Dim ci As String = txtcedula.Text
                Dim suma As Integer = 0
                For i = 0 To 6
                    suma += calc(i) * Val(ci(i))

                Next
                If (10 - (suma Mod 10)) = Val(ci(7)) Then
                    DgvClientes.Rows.Add(ci, txtnombre.Text, txtsaldo.Text, txtdireccion.Text, txttelefono.Text)
                End If
            Else
                MessageBox.Show("Ingrese un documento válido")
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