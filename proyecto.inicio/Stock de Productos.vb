Imports MySql.Data.MySqlClient

Public Class Stock_de_Productos


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Inicio.Show()

    End Sub

    Private Sub Stock_de_Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        dgvstock.Columns(5).HeaderText = "N° Factura"

        'ancho de columnas dgv
        dgvstock.Columns(0).Width = 60
        dgvstock.Columns(1).Width = 200
        dgvstock.Columns(2).Width = 100
        dgvstock.Columns(3).Width = 150
        dgvstock.Columns(4).Width = 150
        dgvstock.Columns(5).Width = 158

    End Sub

    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        Try
            Dim Codigo As String
            For Each row As DataGridViewRow In Me.dgvstock.Rows

                Codigo = row.Cells(1).Value
                If txtdescripcion.Text = Codigo Then
                    Consulta = "UPDATE stock set cantidad=cantidad +('" + txtcantidad.Text + "'), precio_costo= '" + txtpreciocosto.Text + "', precio_v_stock= '" + txtpreciostock.Text + "', n_factura_prov= '" + txtproveedor.Text + "' WHERE descripcion = ('" + txtdescripcion.Text + "') "
                End If

            Next
            txtdescripcion.Clear()
            txtcantidad.Clear()
            txtpreciocosto.Clear()
            txtpreciostock.Clear()
            txtproveedor.Clear()



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Try

            If (txtdescripcion.Text <> "" And txtcantidad.Text <> "" And txtpreciocosto.Text <> "" And txtpreciostock.Text <> "" And txtproveedor.Text <> "") Then

                conexioon.Consulta = "INSERT INTO `stock` (`descripcion`, `cantidad`, `precio_costo`, `precio_v_stock`, `n_factura_prov`) VALUES ('" + txtdescripcion.Text + "','" + txtcantidad.Text + "','" + txtpreciocosto.Text + "','" + txtpreciostock.Text + "','" + txtproveedor.Text + "');"

                consultar()
                dgvstock.DataSource = resultado

                Consulta = "SELECT * FROM stock WHERE cantidad <> 0"
                consultar()
                dgvstock.DataSource = resultado

                'Cambiar el nombre que tienen las columnas de Mysql esos "cod_producto" etc
                dgvstock.Columns(0).HeaderText = "Código"
                dgvstock.Columns(1).HeaderText = "Descripcion"
                dgvstock.Columns(2).HeaderText = "Cantidad"
                dgvstock.Columns(3).HeaderText = "Precio Costo"
                dgvstock.Columns(4).HeaderText = "Precio Venta"
                dgvstock.Columns(5).HeaderText = "N° Factura"

                'ancho de columnas dgv
                dgvstock.Columns(0).Width = 60
                dgvstock.Columns(1).Width = 200
                dgvstock.Columns(2).Width = 100
                dgvstock.Columns(3).Width = 150
                dgvstock.Columns(4).Width = 150
                dgvstock.Columns(5).Width = 158

                'usamos los parametros para msgbox 
                Dim opcion As DialogResult
                opcion = MessageBox.Show("Datos ingresados con éxito!", "Registro Exitoso")

                txtdescripcion.Clear()
                txtcantidad.Clear()
                txtpreciocosto.Clear()
                txtpreciostock.Clear()
                txtproveedor.Clear()


            Else
                'usamos los parametros para msgbox 
                Dim opcion As DialogResult
                opcion = MessageBox.Show("Complete todos los campos!", "DATOS NO COMPLETADOS")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try



    End Sub



End Class