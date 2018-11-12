Public Class MODIFICARCLIENTES


    Private Sub MODIFICARCLIENTES_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    
        Try
            conexioon.Consulta = "SELECT * FROM clientes WHERE saldo_c=0"
            consultar()
            DgvClientes.DataSource = resultado

            'Cambiar el nombre que tienen las columnas de Mysql esos "cod_producto" etc
            DgvClientes.Columns(0).HeaderText = "Código"
            DgvClientes.Columns(1).HeaderText = "Cédula"
            DgvClientes.Columns(2).HeaderText = "Nombre"
            DgvClientes.Columns(3).HeaderText = "Teléfono"
            DgvClientes.Columns(4).HeaderText = "Dirección"
            DgvClientes.Columns(5).HeaderText = "Saldo"

            'ancho de columnas dgv
            DgvClientes.Columns(0).Width = 60
            DgvClientes.Columns(1).Width = 130
            DgvClientes.Columns(2).Width = 200
            DgvClientes.Columns(3).Width = 100
            DgvClientes.Columns(4).Width = 200
            DgvClientes.Columns(5).Width = 125


            If (user = "Gerentes" And pass = "963") Then
                'oculta btn a los que el usuario no tiene permiso de ingresar
                btnEliminarCliente.Enabled = False
                btnEliminarCliente.Visible = False
                Label1.Visible = False
                btnEditar.Visible = False
                btnEditar.Enabled = False
                btnGuardar.Enabled = False
                btnGuardar.Visible = False

            ElseIf (user = "Empleado" And pass = "123") Then

                'oculta btn a los que el usuario no tiene permiso de ingresar
                btnEliminarCliente.Enabled = False
                btnEliminarCliente.Visible = False
                Label1.Visible = False
                btnEditar.Visible = False
                btnEditar.Enabled = False
                btnGuardar.Enabled = False
                btnGuardar.Visible = False
                btnagregarC.Visible = False
                btnagregarC.Enabled = False
                txtnombre.Enabled = False
                txtnombre.Visible = False
                txtcedula.Enabled = False
                txtcedula.Visible = False
                txtdireccion.Enabled = False
                txtdireccion.Visible = False
                txttelefono.Enabled = False
                txttelefono.Visible = False
                Label4.Visible = False
                Label7.Visible = False
                Label9.Visible = False
                Label10.Visible = False
            End If

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnagregarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregarC.Click
        If IsNumeric(txtcedula.Text) Then
            Dim cedula As String
            Dim num(7) As Char
            Dim suma As Integer
            Dim suma1 As Integer
            Dim calculo() As Integer = {2, 9, 8, 7, 6, 3, 4}

            cedula = txtcedula.Text
            num = txtcedula.Text.ToCharArray()

            For i = 0 To 6
                Dim num1 As Integer = Val(num(i))
                suma = (num1 * calculo(i)) + suma
            Next

            num = suma.ToString.ToCharArray

            ReDim Preserve num(1)
            suma1 = Convert.ToInt32(num) + 1
            num = suma1.ToString.ToCharArray
            ReDim Preserve num(2)
            num(2) = "0"

            suma1 = Convert.ToInt32(num)
            suma = suma1 - suma
            num = cedula.ToCharArray()

            If Str(suma) = Val(num(7)) Then
                MessageBox.Show("Cédula Válida", "Datos Incorrectos")
           

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
                DgvClientes.Columns(3).HeaderText = "Teléfono"
                DgvClientes.Columns(4).HeaderText = "Dirección"
                DgvClientes.Columns(5).HeaderText = "Saldo"

                'ancho de columnas dgv
                DgvClientes.Columns(0).Width = 60
                DgvClientes.Columns(1).Width = 130
                DgvClientes.Columns(2).Width = 200
                DgvClientes.Columns(3).Width = 100
                DgvClientes.Columns(4).Width = 200
                DgvClientes.Columns(5).Width = 125

                txtcedula.Clear()
                txtdireccion.Clear()
                txtnombre.Clear()
                txttelefono.Clear()

            Else
                'usamos los parametros para msgbox 
                Dim opcion As DialogResult
                opcion = MessageBox.Show("Complete todos los campos!", "DATOS NO COMPLETADOS")

            End If

        Catch ex As Exception

            MessageBox.Show(ex.ToString)

        End Try

            Else
                MessageBox.Show("Cédula Inválida", "Datos Incorrectos")
            End If
        Else
            MessageBox.Show("Ingrese sólo números", "Datos Incorrectos")
        End If
    End Sub


    Private Sub txtBuscarP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarP.TextChanged
        Try
            'BUSQUEDA DINAMICA EN DATAGRIDVIEW
            conexioon.Consulta = "SELECT * FROM clientes WHERE saldo_c=0 and nombre_cliente LIKE '%" & txtBuscarP.Text & "%';"
            consultar()
            DgvClientes.DataSource = resultado



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        'envia columnas de linea seleccionada para editar
        If (DgvClientes.SelectedRows.Count > 0) Then
            lblCodigoCliente.Text = DgvClientes.CurrentRow.Cells(0).Value.ToString
            txtcedula.Text = DgvClientes.CurrentRow.Cells(1).Value.ToString
            txtnombre.Text = DgvClientes.CurrentRow.Cells(2).Value.ToString
            txtdireccion.Text = DgvClientes.CurrentRow.Cells(3).Value.ToString
            txttelefono.Text = DgvClientes.CurrentRow.Cells(4).Value.ToString

        Else
            'usamos los parametros para msgbox 
            Dim opcion As DialogResult
            opcion = MessageBox.Show("Seleccione una linea!", "DATOS NO SELECCIONADOS")
        End If
    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        ' Fila actualmente seleccionada en el control DataGridView
        '
        Dim row As DataGridViewRow = DgvClientes.CurrentRow

        ' Si no hay ninguna fila seleccionada, abandonamos el procedimiento
        '
        If (row Is Nothing) Then Return

        'mandamos los valores modificados de los txtbox hacia la currentRow
        row.Cells(1).Value = txtcedula.Text
        row.Cells(2).Value = txtnombre.Text
        row.Cells(3).Value = txtdireccion.Text
        row.Cells(4).Value = txttelefono.Text

        txtcedula.Clear()
        txtnombre.Clear()
        txtdireccion.Clear()
        txttelefono.Clear()


        Try

            conexioon.Consulta = "UPDATE clientes SET CI = '" & row.Cells(1).Value.ToString & "', nombre_cliente = '" & row.Cells(2).Value.ToString & "', direccion_c = '" & row.Cells(3).Value.ToString & "', tel_c = '" & row.Cells(4).Value.ToString & "'  WHERE num_cliente = " & row.Cells(0).Value & ";"
            consultar()
            DgvClientes.DataSource = resultado

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try

        Try
            conexioon.Consulta = "SELECT * FROM clientes WHERE saldo_c=0"
            consultar()
            DgvClientes.DataSource = resultado

            'Cambiar el nombre que tienen las columnas de Mysql esos "cod_producto" etc
            DgvClientes.Columns(0).HeaderText = "Código"
            DgvClientes.Columns(1).HeaderText = "Cédula"
            DgvClientes.Columns(2).HeaderText = "Nombre"
            DgvClientes.Columns(3).HeaderText = "Teléfono"
            DgvClientes.Columns(4).HeaderText = "Direccion"
            DgvClientes.Columns(5).HeaderText = "Saldo"

            'ancho de columnas dgv
            DgvClientes.Columns(0).Width = 60
            DgvClientes.Columns(1).Width = 130
            DgvClientes.Columns(2).Width = 200
            DgvClientes.Columns(3).Width = 100
            DgvClientes.Columns(4).Width = 200
            DgvClientes.Columns(5).Width = 125
        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub btnEliminarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarCliente.Click
        Dim row As DataGridViewRow = DgvClientes.CurrentRow


        'usamos los parametros para msgbox y confirmar si quiere eliminar
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Realmente desea eliminar a '" + txtnombre.Text + "' ?", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = DialogResult.Yes) Then
            Try

                conexioon.Consulta = "DELETE FROM `clientes` WHERE `clientes`.`num_cliente` = " + lblCodigoCliente.Text + ""
                consultar()
                DgvClientes.DataSource = resultado

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            txtBuscarP.Clear()
            txtnombre.Clear()
            txtcedula.Clear()
            txtdireccion.Clear()
            txttelefono.Clear()

            Try
                conexioon.Consulta = "SELECT * FROM clientes WHERE saldo_c=0"
                consultar()
                DgvClientes.DataSource = resultado

                'Cambiar el nombre que tienen las columnas de Mysql esos "cod_producto" etc
                DgvClientes.Columns(0).HeaderText = "Código"
                DgvClientes.Columns(1).HeaderText = "Cédula"
                DgvClientes.Columns(2).HeaderText = "Nombre"
                DgvClientes.Columns(3).HeaderText = "Teléfono"
                DgvClientes.Columns(4).HeaderText = "Direccion"
                DgvClientes.Columns(5).HeaderText = "Saldo"

                'ancho de columnas dgv
                DgvClientes.Columns(0).Width = 60
                DgvClientes.Columns(1).Width = 130
                DgvClientes.Columns(2).Width = 200
                DgvClientes.Columns(3).Width = 100
                DgvClientes.Columns(4).Width = 200
                DgvClientes.Columns(5).Width = 125
            Catch ex As Exception

                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub txtcedula_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcedula.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class