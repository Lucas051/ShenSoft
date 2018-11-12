Public Class PagosProv
    'Variable de clase para recordar en que punto, o fila, ha quedado el muestréo.
    Dim i As Integer = 0

    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        Dim llamar1 As New GestionFacturacion
        Inicio.panelmedio.Controls.Clear()
        llamar1.TopLevel = False
        llamar1.Parent = Inicio.panelmedio
        llamar1.Show()
        llamar1.Dock = DockStyle.Fill
        Inicio.panelmedio.Visible = True
    End Sub

    Private Sub PagosProv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conexioon.Consulta = "SELECT PP.num_recibo_p, PP.fecha, PP.importe, PP.num_prov, P.nombre_prov, PP.numero_recibo_fisico_p FROM pagos_prov PP inner join proveedores P on PP.num_prov=P.num_prov;"
            consultar()
            dgvproveedores.DataSource = resultado

            dgvproveedores.Columns(0).HeaderText = "ID"
            dgvproveedores.Columns(1).HeaderText = "Fecha"
            dgvproveedores.Columns(2).HeaderText = "Importe"
            dgvproveedores.Columns(3).HeaderText = "N° Proveedor"
            dgvproveedores.Columns(4).HeaderText = "Nom. Proveedor"
            dgvproveedores.Columns(5).HeaderText = "N° Recibo"

            'ancho de columnas dgv
            dgvproveedores.Columns(0).Width = 60
            dgvproveedores.Columns(1).Width = 100
            dgvproveedores.Columns(3).Width = 100
            dgvproveedores.Columns(4).Width = 150

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
    End Sub

   
 
    Private Sub btnBuscarProv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarProv.Click
        BuscarProv.Show()

    End Sub


    Private Sub btnPagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagar.Click
        Try
            conexioon.Consulta = "INSERT INTO pagos_prov (importe, num_prov, numero_recibo_fisico_p) VALUES ('" + txtImporte.Text + "','" + txtProveedor.Text + "','" + TXTnrecibofisico.Text + "');"
            consultar()

            'usamos los parametros para msgbox 
            Dim opcion As DialogResult
            opcion = MessageBox.Show("Pago ingresado!", "INGRESO COMPLETADO")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            conexioon.Consulta = "UPDATE proveedores SET saldo_p = saldo_p - " + txtImporte.Text + " WHERE num_prov=" + txtProveedor.Text + ";"
            consultar()

            'usamos los parametros para msgbox 
            Dim opcion As DialogResult
            opcion = MessageBox.Show("Saldo restado!", "INGRESO COMPLETADO")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            conexioon.Consulta = "SELECT * FROM pagos_prov;"
            consultar()
            dgvproveedores.DataSource = resultado


            dgvproveedores.Columns(0).HeaderText = "ID"
            dgvproveedores.Columns(1).HeaderText = "Fecha"
            dgvproveedores.Columns(2).HeaderText = "Importe"
            dgvproveedores.Columns(3).HeaderText = "N° Proveedor"
            dgvproveedores.Columns(4).HeaderText = "Nom. Proveedor"
            dgvproveedores.Columns(5).HeaderText = "N° Recibo"

            'ancho de columnas dgv
            dgvproveedores.Columns(0).Width = 60
            dgvproveedores.Columns(1).Width = 200
            dgvproveedores.Columns(3).Width = 150
            dgvproveedores.Columns(4).Width = 70

        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        DirectCast(ppdvistaprevia, Form).WindowState = FormWindowState.Maximized

        ppdvistaprevia.Show()

        'Imprimir directamente sin vista previa
        Me.prdDocumento.Print()
    End Sub
    Private Sub prdDocumento_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prdDocumento.PrintPage
        'Se define la fuente que vamos a usar para imprimir. En este caso Arial de 10.
        Dim fuenteImpresion As System.Drawing.Font = New Font("Arial", 10)
        Dim margenSuperior As Double = e.MarginBounds.Top
        Dim posicionY As Double = 0
        Dim lineasPorPagina As Double = 0
        Dim contador As Integer = 0
        Dim texto As String = ""
        Dim fila As System.Windows.Forms.DataGridViewRow

        'Se calcula el número de líneas que caben en cada página.
        lineasPorPagina = e.MarginBounds.Height / fuenteImpresion.GetHeight(e.Graphics)

        'Se imprimen las cabeceras.
        Dim encabezado As DataGridViewHeaderCell
        For Each column As DataGridViewColumn In dgvproveedores.Columns
            encabezado = column.HeaderCell
            texto += vbTab + vbTab + encabezado.FormattedValue.ToString()
        Next

        posicionY = margenSuperior + (contador * fuenteImpresion.GetHeight(e.Graphics))
        e.Graphics.DrawString(texto, fuenteImpresion, System.Drawing.Brushes.Black, 10, posicionY)
        'Se deja una línea de separación.
        contador += 2

        'Se recorren las filas del DataGridView hasta llegar a las líneas que nos caben en cada página o al final del DataGridView.
        While contador < lineasPorPagina AndAlso i < dgvproveedores.Rows.Count
            fila = dgvproveedores.Rows(i)
            texto = ""
            For Each celda As System.Windows.Forms.DataGridViewCell In fila.Cells
                'Se comprueba que la celda tenga algún valor, en caso de permitir añadir filas esto es necesario.
                If celda.Value IsNot Nothing Then
                    texto += vbTab + vbTab + celda.Value.ToString()
                End If
            Next

            'Se calcula la posición en la que se escribe la línea.
            posicionY = margenSuperior + (contador * fuenteImpresion.GetHeight(e.Graphics))

            'Se escribe la línea con el objeto Graphics.
            e.Graphics.DrawString(texto, fuenteImpresion, System.Drawing.Brushes.Black, 10, posicionY)
            'Se incrementan los contadores.
            contador += 1
            i += 1
        End While

        'Una vez fuera del bucle, se comprueba si quedan más filas por imprimir, si quedan saldrán en la siguente página
        If i < dgvproveedores.Rows.Count Then
            e.HasMorePages = True
        Else
            'Si se llega al final, se establece HasMorePages a false para que se acabe la impresión.
            e.HasMorePages = False
            'Es necesario poner el contador i a 0 porque, por ejemplo si se hace una impresión desde PrintPreviewDialog, se vuelve a
            'disparar este evento como si fuese la primera vez, y si i está con el valor de la última fila del grid no se imprime nada.
            i = 0
        End If
    End Sub
End Class