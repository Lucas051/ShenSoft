Imports MySql.Data.MySqlClient
Public Class EditarProv

    Private Sub EditarProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
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
        dgvproveedores.Columns(0).Width = 60
        dgvproveedores.Columns(1).Width = 200
        dgvproveedores.Columns(4).Width = 65
    End Sub

    Private Sub btnSelecProv_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelecProv.Click
        'envia columnas de linea seleccionada para editar
        If (dgvproveedores.SelectedRows.Count > 0) Then
            txtproveedor.Text = dgvproveedores.CurrentRow.Cells(1).Value.ToString
            txttelefono.Text = dgvproveedores.CurrentRow.Cells(2).Value.ToString
            txtdireccion.Text = dgvproveedores.CurrentRow.Cells(3).Value.ToString

        Else
            'usamos los parametros para msgbox 
            Dim opcion As DialogResult
            opcion = MessageBox.Show("Seleccione una linea!", "DATOS NO SELECCIONADOS")
        End If
    End Sub

    Private Sub btnEditarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditarProv.Click
        ' Fila actualmente seleccionada en el control DataGridView
        '
        Dim row As DataGridViewRow = dgvproveedores.CurrentRow

        ' Si no hay ninguna fila seleccionada, abandonamos el procedimiento
        '
        If (row Is Nothing) Then Return

        'mandamos los valores modificados de los txtbox hacia la currentRow
        row.Cells(1).Value = txtproveedor.Text
        row.Cells(2).Value = txttelefono.Text
        row.Cells(3).Value = txtdireccion.Text

        txtproveedor.Clear()
        txttelefono.Clear()
        txtdireccion.Clear()


        Try
            conexioon.Consulta = "UPDATE proveedores SET nombre_prov = '" & row.Cells(1).Value.ToString & "', tel_p = '" & row.Cells(2).Value.ToString & "', direccion_p = '" & row.Cells(3).Value.ToString & "'  WHERE num_prov = " & row.Cells(0).Value & ";"
            consultar()
            dgvproveedores.DataSource = resultado

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
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
        dgvproveedores.Columns(0).Width = 60
        dgvproveedores.Columns(1).Width = 200
        dgvproveedores.Columns(4).Width = 65
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
End Class