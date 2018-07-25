﻿Imports MySql.Data.MySqlClient

Public Class Stock_de_Productos


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Inicio.Show()

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click


        Try

            If (txtdescripcion.Text <> "" And txtprecio.Text <> "" And txtpreciostock.Text <> "") Then
                'nacho puse nombre_prov en vez de num aca porque es mas facil reconocerlo por el nombre
                'aca hay que hacer un join para conectar la foranea de nombre_prov de proveedores con stock en el mismo insert, hay sintaxis en internet
                conexioon.Consulta = "INSERT INTO `stock` (`descripcion`, `cantidad`, `precio_costo`, `precio_v_stock`, `num_prov`) VALUES ('" + txtdescripcion.Text + "','" + txtcantidad.Text + "','" + txtprecio.Text + "','" + txtpreciostock.Text + "','" + txtproveedor.Text + "');"

                consultar()
                DataGridView1.DataSource = resultado


                MessageBox.Show("Datos Guardados Correctamente.")
                MessageBox.Show("El ID producto se agregará automáticamente.")

            Else
                MessageBox.Show("Se deben rellenar todos los campos.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        'Acaaaaaaaaaaa Actualizooooooooooooooo El DGV de mierdaaaaaaaaaaaaaaaaaaaa repitiendo el comando creo que se puede mejorar...
        conexioon.Consulta = "SELECT * FROM stock"
        consultar()
        DataGridView1.DataSource = resultado

        'Cambiar el nombre que tienen las columnas de Mysql esos "cod_producto" etc
        DataGridView1.Columns(0).HeaderText = "Código"
        DataGridView1.Columns(1).HeaderText = "Descripcion"
        DataGridView1.Columns(2).HeaderText = "Cantidad"
        DataGridView1.Columns(3).HeaderText = "Precio Costo"
        DataGridView1.Columns(4).HeaderText = "Precio Venta"
        DataGridView1.Columns(5).HeaderText = "Proveedor"
        'Proximamente Solo en Cines

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        txtdescripcion.Text = ""
        txtprecio.Text = ""
        txtcantidad.Text = ""
        txtproveedor.Text = ""
        txtpreciostock.Text = ""


    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
        EliminarSotck.Show()

    End Sub

    Private Sub Stock_de_Productos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Codigo para insertar en un DataGridView creado datos de una tabla Mysql en este caso Stock
        conexioon.Consulta = "SELECT * FROM stock"
        consultar()
        DataGridView1.DataSource = resultado

        'Cambiar el nombre que tienen las columnas de Mysql esos "cod_producto" etc
        DataGridView1.Columns(0).HeaderText = "Código"
        DataGridView1.Columns(1).HeaderText = "Descripcion"
        DataGridView1.Columns(2).HeaderText = "Cantidad"
        DataGridView1.Columns(3).HeaderText = "Precio Costo"
        DataGridView1.Columns(4).HeaderText = "Precio Venta"
        DataGridView1.Columns(5).HeaderText = "Proveedor"
        'Proximamente Solo en Cines
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtdescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdescripcion.TextChanged

    End Sub

    Private Sub btnmini_Click(sender As System.Object, e As System.EventArgs) Handles btnmini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnmaxi_Click(sender As System.Object, e As System.EventArgs) Handles btnmaxi.Click
        Me.WindowState = FormWindowState.Maximized

        btnmaxi.Visible = False
        btnrestaurar.Visible = True
    End Sub

    Private Sub cerrarbtn_Click(sender As System.Object, e As System.EventArgs) Handles cerrarbtn.Click
        End
    End Sub

    Private Sub btnrestaurar_Click(sender As System.Object, e As System.EventArgs) Handles btnrestaurar.Click
        'restaura ventana
        Me.WindowState = FormWindowState.Normal
        'esconde boton, aparece maximizar
        btnrestaurar.Visible = False
        btnmaxi.Visible = True
    End Sub

<<<<<<< HEAD
=======
    Private Sub barratitulo_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles barratitulo.Paint

    End Sub
>>>>>>> 055dfdfd142acc6d8bc35f6c36a57adf3994943f
End Class