Imports MySql.Data.MySqlClient

Public Class Stock_de_Productos


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvolver.Click
        Me.Hide()
        Inicio.Show()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btningresar.Click
        Try
            Dim Codigo As String
            For Each row As DataGridViewRow In Me.DgvStock.Rows

                Codigo = row.Cells(1).Value
                If txtdescripcion.Text = Codigo Then
                    Consulta = "UPDATE stock set cantidad=cantidad +('" + txtcantidad.Text + "') WHERE descripcion = ('" + txtdescripcion.Text + "') "
                End If

            Next



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Try

            If (txtdescripcion.Text <> "" And txtprecio.Text <> "" And txtpreciostock.Text <> "") Then
                'nacho puse nombre_prov en vez de num aca porque es mas facil reconocerlo por el nombre
                'aca hay que hacer un join para conectar la foranea de nombre_prov de proveedores con stock en el mismo insert, hay sintaxis en internet
                conexioon.Consulta = "INSERT INTO `stock` (`descripcion`, `cantidad`, `precio_costo`, `precio_v_stock`, `num_prov`) VALUES ('" + txtdescripcion.Text + "','" + txtcantidad.Text + "','" + txtprecio.Text + "','" + txtpreciostock.Text + "','" + txtproveedor.Text + "');"

                consultar()
                DgvStock.DataSource = resultado

                Consulta = "SELECT * FROM stock WHERE cantidad <> 0"
                consultar()
                DgvStock.DataSource = resultado

                'Cambiar el nombre que tienen las columnas de Mysql esos "cod_producto" etc
                DgvStock.Columns(0).HeaderText = "Código"
                DgvStock.Columns(1).HeaderText = "Descripcion"
                DgvStock.Columns(2).HeaderText = "Cantidad"
                DgvStock.Columns(3).HeaderText = "Precio Costo"
                DgvStock.Columns(4).HeaderText = "Precio Venta"
                DgvStock.Columns(5).HeaderText = "Proveedor"

                MessageBox.Show("Datos Guardados Correctamente.")


            Else
                MessageBox.Show("Se deben rellenar todos los campos.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpiar.Click

        txtdescripcion.Text = ""
        txtprecio.Text = ""
        txtcantidad.Text = ""
        txtproveedor.Text = ""
        txtpreciostock.Text = ""


    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
        SuspenderStock.Show()

    End Sub

    Private Sub Stock_de_Productos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Codigo para insertar en un DataGridView creado datos de una tabla Mysql en este caso Stock
        conexioon.Consulta = "SELECT * FROM stock WHERE cantidad <> 0"
        consultar()
        DgvStock.DataSource = resultado

        'Cambiar el nombre que tienen las columnas de Mysql esos "cod_producto" etc
        DgvStock.Columns(0).HeaderText = "Código"
        DgvStock.Columns(1).HeaderText = "Descripcion"
        DgvStock.Columns(2).HeaderText = "Cantidad"
        DgvStock.Columns(3).HeaderText = "Precio Costo"
        DgvStock.Columns(4).HeaderText = "Precio Venta"
        DgvStock.Columns(5).HeaderText = "Proveedor"
        'Proximamente Solo en Cines
    End Sub



    Private Sub txtdescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescripcion.TextChanged

    End Sub

End Class