Public Class PagosClientes

    'Variable de clase para recordar en que punto, o fila, ha quedado el muestréo.
    Dim i As Integer = 0

    Private Sub btnBuscarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarProv.Click
        BuscarClientesCobrar.Show()

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

    Private Sub PagosClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            conexioon.Consulta = "SELECT PC.num_recibo_c, PC.fecha, PC.num_cliente, C.nombre_cliente, PC.importe FROM pagos_clientes PC inner join clientes C on PC.num_cliente=C.num_cliente;"
            consultar()
            dgvclientes.DataSource = resultado


            dgvclientes.Columns(0).HeaderText = "N° Recibo"
            dgvclientes.Columns(1).HeaderText = "Fecha"
            dgvclientes.Columns(2).HeaderText = "N° Cliente"
            dgvclientes.Columns(3).HeaderText = "Nombre Cliente"
            dgvclientes.Columns(4).HeaderText = "Importe"

            'ancho de columnas dgv
            dgvclientes.Columns(0).Width = 120
            dgvclientes.Columns(1).Width = 140
            dgvclientes.Columns(2).Width = 140
            dgvclientes.Columns(3).Width = 220
            dgvclientes.Columns(4).Width = 120

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        Try
            conexioon.Consulta = "INSERT INTO pagos_clientes (num_cliente, importe) VALUES ('" + txtcliente.Text + "','" + txtImporte.Text + "');"
            consultar()

            'usamos los parametros para msgbox 
            Dim opcion As DialogResult
            opcion = MessageBox.Show("Cobrado con éxito!", "INGRESO COMPLETADO")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            conexioon.Consulta = "UPDATE clientes SET saldo_c = saldo_c - " + txtImporte.Text + " WHERE num_cliente=" + txtcliente.Text + ";"
            consultar()

            'usamos los parametros para msgbox 
            Dim opcion As DialogResult
            opcion = MessageBox.Show("Saldo restado!", "INGRESO COMPLETADO")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            conexioon.Consulta = "SELECT PC.num_recibo_c, PC.fecha, PC.num_cliente, C.nombre_cliente, PC.importe FROM pagos_clientes PC inner join clientes C on PC.num_cliente=C.num_cliente;"
            consultar()
            dgvclientes.DataSource = resultado


            dgvclientes.Columns(0).HeaderText = "N° Recibo"
            dgvclientes.Columns(1).HeaderText = "Fecha"
            dgvclientes.Columns(2).HeaderText = "N° Cliente"
            dgvclientes.Columns(3).HeaderText = "Nombre Cliente"
            dgvclientes.Columns(4).HeaderText = "Importe"

            'ancho de columnas dgv
            dgvclientes.Columns(0).Width = 120
            dgvclientes.Columns(1).Width = 140
            dgvclientes.Columns(2).Width = 140
            dgvclientes.Columns(3).Width = 220
            dgvclientes.Columns(4).Width = 120

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
      

        DirectCast(ppdvistaprevia, Form).WindowState = FormWindowState.Maximized


        ppdvistaprevia.Document = prdDocumento
        ppdvistaprevia.ShowDialog()

        'Imprimir directamente sin vista previa
        ' Me.prdDocumento.Print()
    End Sub

    Private Sub prdDocumento_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prdDocumento.PrintPage
        'Se define la fuente que vamos a usar para imprimir. En este caso Arial de 10.
        Dim fuenteImpresion As System.Drawing.Font = New Font("Arial", 10)
        Dim fuentetitulos As System.Drawing.Font = New Font("Arial Black", 10)

        Dim fecha As String
        fecha = DateTime.Now.ToString("dd/MM/yyyy")

        e.Graphics.DrawString("RECIBO", Cobrar.lblTotalPagar.Font, Brushes.Black, 10, 10)

        e.Graphics.DrawString("EMITE: ", fuentetitulos, Brushes.Black, 200, 10)
        e.Graphics.DrawString("La Pollería", Cobrar.lblTotalPagar.Font, Brushes.Black, 265, 10)

        e.Graphics.DrawString("$", fuentetitulos, Brushes.Black, 500, 10)
        e.Graphics.DrawString(txtImporte.Text, Cobrar.lblTotalPagar.Font, Brushes.Black, 530, 10)

        e.Graphics.DrawString("Recibí de cliente: N°", fuentetitulos, Brushes.Black, 200, 80)
        e.Graphics.DrawString(txtcliente.Text, Cobrar.lblTotalPagar.Font, Brushes.Black, 265, 80)
        
        e.Graphics.DrawString("Firma: ", fuentetitulos, Brushes.Black, 500, 200)

        e.Graphics.DrawString(fecha, Cobrar.lblTotalPagar.Font, Brushes.Black, 665, 10)
      
    End Sub

    Private Sub txtImporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcliente_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcliente.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class