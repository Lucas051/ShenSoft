Public Class FacturasProveedores

    Private Sub FacturasProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conexioon.Consulta = "SELECT FP.n_factura_prov, FP.fecha_p, FP.num_prov, P.nombre_prov, FP.monto, FP.forma_de_pago FROM factura_prov FP inner join proveedores P on FP.num_prov=P.Num_prov WHERE monto <> 0;"
            consultar()
            dgvFacturasProv.DataSource = resultado

            dgvFacturasProv.Columns(0).HeaderText = "N° Factura"
            dgvFacturasProv.Columns(1).HeaderText = "Fecha"
            dgvFacturasProv.Columns(2).HeaderText = "N° Proveedor"
            dgvFacturasProv.Columns(3).HeaderText = "Nombre Proveedor"
            dgvFacturasProv.Columns(4).HeaderText = "Monto"
            dgvFacturasProv.Columns(5).HeaderText = "Forma de Pago"

            'ancho de columnas dgv
            dgvFacturasProv.Columns(0).Width = 60
            dgvFacturasProv.Columns(1).Width = 150
            dgvFacturasProv.Columns(2).Width = 80
            dgvFacturasProv.Columns(3).Width = 200
            dgvFacturasProv.Columns(4).Width = 100
            dgvFacturasProv.Columns(5).Width = 150
        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try

        CBformadepago.Items.Add("Contado")
        CBformadepago.Items.Add("Crédito")

        'si es credito se agrega al saldo del proveedor
        If (CBformadepago.Text = "Crédito") Then
            Try
                conexioon.Consulta = "UPDATE proveedores SET saldo_p = saldo_p + " + txtmonto.Text + " WHERE num_prov=" + txtproveedor.Text + ";"
                consultar()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        If (txtproveedor.Text <> "" And txtmonto.Text <> "" And CBformadepago.Text <> "") Then
            Try
                conexioon.Consulta = "INSERT INTO factura_prov(num_prov, monto, forma_de_pago) VALUES ('" + txtproveedor.Text + "','" + txtmonto.Text + "','" + CBformadepago.Text + "');"
                consultar()
                dgvFacturasProv.DataSource = resultado

            Catch ex As Exception

                MessageBox.Show(ex.ToString)
            End Try

            Try
                conexioon.Consulta = "SELECT FP.n_factura_prov, FP.fecha_p, FP.num_prov, P.nombre_prov, FP.monto, FP.forma_de_pago FROM factura_prov FP inner join proveedores P on FP.num_prov=P.Num_prov WHERE monto <> 0;"
                consultar()
                dgvFacturasProv.DataSource = resultado

                dgvFacturasProv.Columns(0).HeaderText = "N° Factura"
                dgvFacturasProv.Columns(1).HeaderText = "Fecha"
                dgvFacturasProv.Columns(2).HeaderText = "N° Proveedor"
                dgvFacturasProv.Columns(3).HeaderText = "Nombre Proveedor"
                dgvFacturasProv.Columns(4).HeaderText = "Monto"
                dgvFacturasProv.Columns(5).HeaderText = "Forma de Pago"

                'ancho de columnas dgv
                dgvFacturasProv.Columns(0).Width = 60
                dgvFacturasProv.Columns(1).Width = 150
                dgvFacturasProv.Columns(2).Width = 80
                dgvFacturasProv.Columns(3).Width = 200
                dgvFacturasProv.Columns(4).Width = 100
                dgvFacturasProv.Columns(5).Width = 150

                txtproveedor.Clear()
                txtmonto.Clear()

            Catch ex As Exception

                MessageBox.Show(ex.ToString)
            End Try
        Else
            'usamos los parametros para msgbox 
            Dim opcion As DialogResult
            opcion = MessageBox.Show("Complete Campos!", "DATOS INCOMPLETOS")
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        BuscarProv.Show()

    End Sub

    Private Sub btnSeleccionarLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionarLinea.Click
        'envia columnas de linea seleccionada para editar
        If (dgvFacturasProv.SelectedRows.Count > 0) Then
            lblNfactura.Text = dgvFacturasProv.CurrentRow.Cells(0).Value.ToString
            txtproveedor.Text = dgvFacturasProv.CurrentRow.Cells(2).Value.ToString
            txtmonto.Text = dgvFacturasProv.CurrentRow.Cells(4).Value.ToString

        Else
            'usamos los parametros para msgbox 
            Dim opcion As DialogResult
            opcion = MessageBox.Show("Seleccione una linea!", "DATOS NO SELECCIONADOS")
        End If
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If (lblNfactura.Text <> "" And txtproveedor.Text <> "" And txtmonto.Text <> "") Then



            ' Fila actualmente seleccionada en el control DataGridView
            '
            Dim row As DataGridViewRow = dgvFacturasProv.CurrentRow

            ' Si no hay ninguna fila seleccionada, abandonamos el procedimiento
            '
            If (row Is Nothing) Then Return

            'mandamos los valores modificados de los txtbox hacia la currentRow
            row.Cells(2).Value = txtproveedor.Text
            row.Cells(4).Value = txtmonto.Text
            row.Cells(5).Value = CBformadepago.Text

            lblNfactura.ResetText()
            txtproveedor.Clear()
            txtmonto.Clear()


            Try
                conexioon.Consulta = "UPDATE factura_prov SET num_prov = '" & row.Cells(2).Value.ToString & "', monto = '" & row.Cells(4).Value.ToString & "', forma_de_pago = '" & row.Cells(5).Value.ToString & "'  WHERE n_factura_prov = " & row.Cells(0).Value & ";"
                consultar()
                dgvFacturasProv.DataSource = resultado

            Catch ex As Exception

                MessageBox.Show(ex.ToString)
            End Try

            Try
                conexioon.Consulta = "SELECT FP.n_factura_prov, FP.fecha_p, FP.num_prov, P.nombre_prov, FP.monto, FP.forma_de_pago FROM factura_prov FP inner join proveedores P on FP.num_prov=P.Num_prov WHERE monto <> 0;"
                consultar()
                dgvFacturasProv.DataSource = resultado

                dgvFacturasProv.Columns(0).HeaderText = "N° Factura"
                dgvFacturasProv.Columns(1).HeaderText = "Fecha"
                dgvFacturasProv.Columns(2).HeaderText = "N° Proveedor"
                dgvFacturasProv.Columns(3).HeaderText = "Nombre Proveedor"
                dgvFacturasProv.Columns(4).HeaderText = "Monto"
                dgvFacturasProv.Columns(5).HeaderText = "Forma de Pago"

                'ancho de columnas dgv
                dgvFacturasProv.Columns(0).Width = 60
                dgvFacturasProv.Columns(1).Width = 150
                dgvFacturasProv.Columns(2).Width = 80
                dgvFacturasProv.Columns(3).Width = 200
                dgvFacturasProv.Columns(4).Width = 100
                dgvFacturasProv.Columns(5).Width = 150
            Catch ex As Exception

                MessageBox.Show(ex.ToString)
            End Try
        Else
            'usamos los parametros para msgbox 
            Dim opcion As DialogResult
            opcion = MessageBox.Show("Seleccione una linea!", "DATOS NO SELECCIONADOS")
        End If
    End Sub

    Private Sub btnSuspender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuspender.Click
        If (lblNfactura.Text <> "" And txtproveedor.Text <> "" And txtmonto.Text <> "") Then
            'usamos los parametros para msgbox y confirmar si quiere eliminar
            Dim opcion As DialogResult
            opcion = MessageBox.Show("Realmente desea Suspender Factura?", "Suspender Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If (opcion = DialogResult.Yes) Then
                Try

                    conexioon.Consulta = " UPDATE factura_prov SET monto = 0 WHERE n_factura_prov ='" + lblNfactura.Text + "'"
                    consultar()

                    'usamos los parametros para msgbox 
                    Dim opcion1 As DialogResult
                    opcion1 = MessageBox.Show("Suspendida con éxito!", "FACTURA SUSPENDIDA")

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

                Try
                    conexioon.Consulta = "SELECT FP.n_factura_prov, FP.fecha_p, FP.num_prov, P.nombre_prov, FP.monto, FP.forma_de_pago FROM factura_prov FP inner join proveedores P on FP.num_prov=P.Num_prov WHERE monto <> 0;"
                    consultar()
                    dgvFacturasProv.DataSource = resultado

                    dgvFacturasProv.Columns(0).HeaderText = "N° Factura"
                    dgvFacturasProv.Columns(1).HeaderText = "Fecha"
                    dgvFacturasProv.Columns(2).HeaderText = "N° Proveedor"
                    dgvFacturasProv.Columns(3).HeaderText = "Nombre Proveedor"
                    dgvFacturasProv.Columns(4).HeaderText = "Monto"
                    dgvFacturasProv.Columns(5).HeaderText = "Forma de Pago"

                    'ancho de columnas dgv
                    dgvFacturasProv.Columns(0).Width = 60
                    dgvFacturasProv.Columns(1).Width = 150
                    dgvFacturasProv.Columns(2).Width = 80
                    dgvFacturasProv.Columns(3).Width = 200
                    dgvFacturasProv.Columns(4).Width = 100
                    dgvFacturasProv.Columns(5).Width = 150

                    lblNfactura.ResetText()
                    txtproveedor.Clear()
                    txtmonto.Clear()

                Catch ex As Exception

                    MessageBox.Show(ex.ToString)
                End Try

            End If
        Else
            'usamos los parametros para msgbox 
            Dim opcion As DialogResult
            opcion = MessageBox.Show("Seleccione una linea!", "DATOS NO SELECCIONADOS")
        End If
    End Sub

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        Dim llamar1 As New GestionFacturacion
        Inicio.panelmedio.Controls.Clear()
        llamar1.TopLevel = False
        llamar1.Parent = Inicio.panelmedio
        llamar1.Show()
        llamar1.Dock = DockStyle.Fill
        Inicio.panelmedio.Visible = True
    End Sub

    Private Sub CBformadepago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBformadepago.SelectedIndexChanged
        If (CBformadepago.Text = "Crédito") Then
            conexioon.Consulta = "UPDATE proveedores SET saldo_p = saldo_p + " + txtmonto.Text + " WHERE num_prov=" + txtproveedor.Text + ";"
            consultar()
        End If
    End Sub
End Class