Imports MySql.Data.MySqlClient
Public Class Gestionproveedores

    Private Sub txtBuscarP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarP.TextChanged
        Try
            'BUSQUEDA DINAMICA EN DATAGRIDVIEW
            conexioon.Consulta = "SELECT * FROM proveedores WHERE nombre_prov LIKE '%" & txtBuscarP.Text & "%';"
            consultar()
            dgvproveedores.DataSource = resultado

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btnagregarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregarProv.Click
        Try

            If (txtproveedor.Text <> "" And txttelefono.Text <> "" And txtdireccion.Text <> "") Then

                conexioon.Consulta = "INSERT INTO proveedores (nombre_prov,tel_p,direccion_p) VALUES ('" + txtproveedor.Text + "' , '" + txttelefono.Text + "','" + txtdireccion.Text + "' )"
                consultar()

                dgvproveedores.DataSource = resultado

                Consulta = "Select * from Proveedores"
                consultar()
                dgvproveedores.DataSource = resultado

                dgvproveedores.Columns(0).HeaderText = "ID"
                dgvproveedores.Columns(1).HeaderText = "Proveedor"
                dgvproveedores.Columns(2).HeaderText = "Teléfono"
                dgvproveedores.Columns(3).HeaderText = "Dirección"
                dgvproveedores.Columns(4).HeaderText = "Saldo"

                'ancho de columnas dgv
                dgvproveedores.Columns(0).Width = 60
                dgvproveedores.Columns(1).Width = 200
                dgvproveedores.Columns(3).Width = 150
                dgvproveedores.Columns(4).Width = 70

                'usamos los parametros para msgbox 
                Dim opcion As DialogResult
                opcion = MessageBox.Show("Datos Guardados Correctamente", "AÑADIDO CON EXITO")

            Else
                'usamos los parametros para msgbox 
                Dim opcion As DialogResult
                opcion = MessageBox.Show("Complete todos los campos!", "DATOS NO COMPLETADOS")
            End If

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try

        txtproveedor.Clear()
        txttelefono.Clear()
        txtdireccion.Clear()

    End Sub

    Private Sub Gestionproveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conexioon.Consulta = "SELECT * FROM proveedores;"
            consultar()
            dgvproveedores.DataSource = resultado

            dgvproveedores.Columns(0).HeaderText = "ID"
            dgvproveedores.Columns(1).HeaderText = "Proveedor"
            dgvproveedores.Columns(2).HeaderText = "Teléfono"
            dgvproveedores.Columns(3).HeaderText = "Dirección"
            dgvproveedores.Columns(4).HeaderText = "Saldo"

            'ancho de columnas dgv
            dgvproveedores.Columns(0).Width = 60
            dgvproveedores.Columns(1).Width = 200
            dgvproveedores.Columns(3).Width = 150
            dgvproveedores.Columns(4).Width = 70

            If (user = "Empleado" And pass = "123") Then
                'oculta btn a los que el usuario no tiene permiso de ingresar
                Label2.Visible = False
                Label3.Visible = False
                Label4.Visible = False

                txtproveedor.Visible = False
                txtproveedor.Enabled = False
                txttelefono.Visible = False
                txttelefono.Enabled = False
                txtdireccion.Visible = False
                txtdireccion.Enabled = False

                btnagregarProv.Enabled = False
                btnagregarProv.Visible = False


            End If

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try

    End Sub



End Class