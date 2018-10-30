Imports MySql.Data.MySqlClient
Public Class EliminarProv


    Private Sub EliminarProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            conexioon.Consulta = "SELECT * FROM proveedores;"
            consultar()
            dgvproveedores.DataSource = resultado

            dgvproveedores.Columns(0).HeaderText = "ID"
            dgvproveedores.Columns(1).HeaderText = "Proveedor"
            dgvproveedores.Columns(2).HeaderText = "Teléfono"
            dgvproveedores.Columns(3).HeaderText = "Dirección"
            dgvproveedores.Columns(4).HeaderText = "Saldo"
        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
        'ancho de columnas dgv
        dgvproveedores.Columns(0).Width = 100
        dgvproveedores.Columns(1).Width = 200
        dgvproveedores.Columns(2).Width = 200
        dgvproveedores.Columns(3).Width = 200
        dgvproveedores.Columns(4).Width = 100
    End Sub
    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click

        'envia columnas de linea seleccionada para editar
        If (dgvproveedores.SelectedRows.Count > 0) Then
            lblNumProv.Text = dgvproveedores.CurrentRow.Cells(0).Value.ToString
            txtproveedor.Text = dgvproveedores.CurrentRow.Cells(1).Value.ToString

        Else
            'usamos los parametros para msgbox 
            Dim opcion As DialogResult
            opcion = MessageBox.Show("Seleccione una linea!", "DATOS NO SELECCIONADOS")
        End If

    End Sub

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

    Private Sub btnEliminarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProv.Click
        'usamos los parametros para msgbox y confirmar si quiere eliminar
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Realmente desea eliminar a '" + txtproveedor.Text + "' ?", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = DialogResult.Yes) Then
            Try

                conexioon.Consulta = "DELETE FROM `proveedores` WHERE `proveedores`.`num_prov` = " + lblNumProv.Text + ""
                consultar()
                dgvproveedores.DataSource = resultado

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            lblNumProv.ResetText()
            txtproveedor.Clear()
            txtBuscarP.Clear()

            Try
                conexioon.Consulta = "SELECT * FROM proveedores;"
                consultar()
                dgvproveedores.DataSource = resultado

                dgvproveedores.Columns(0).HeaderText = "ID"
                dgvproveedores.Columns(1).HeaderText = "Proveedor"
                dgvproveedores.Columns(2).HeaderText = "Teléfono"
                dgvproveedores.Columns(3).HeaderText = "Dirección"
                dgvproveedores.Columns(4).HeaderText = "Saldo"
            Catch ex As Exception

                MessageBox.Show(ex.ToString)
            End Try
            'ancho de columnas dgv
            dgvproveedores.Columns(0).Width = 100
            dgvproveedores.Columns(1).Width = 200
            dgvproveedores.Columns(2).Width = 200
            dgvproveedores.Columns(3).Width = 200
            dgvproveedores.Columns(4).Width = 100
        End If

    End Sub

End Class