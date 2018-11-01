Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb

Public Class Cobrar
    'Variables para mover form en none
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    'Variable de clase para recordar en que punto, o fila, ha quedado el muestréo.
    Dim i As Integer = 0

    Dim devolver As Integer

    Private Sub Cobrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTotalPagar.Text = ModuloVariables.MontoTotal

        CBformadepago.Items.Add("Contado")
        CBformadepago.Items.Add("Cuenta")
    End Sub



    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'MOVER FORM EN NONE
    Private Sub barratitulo_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles barratitulo.MouseDown
        If e.Button = MouseButtons.Left Then

            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y

        End If

    End Sub


    Private Sub barratitulo_MouseMove_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles barratitulo.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)

            Me.Location = temp

            temp = Nothing

        End If
    End Sub

    Private Sub barratitulo_MouseUp_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles barratitulo.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Private Sub buscarClientebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarClientebtn.Click
        BuscarClientesCobrar.Show()
    End Sub

    Private Sub atrasbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atrasbtn.Click
        Me.Hide()
        RealizarFactura.Show()

    End Sub

    Private Sub btnmini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



    Private Sub btncobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncobrar.Click
        'Dim TotalPagar As Integer = Convert.ToInt32(lblTotalPagar.Text)
        '  Dim PagoCon As Integer = Convert.ToInt32(txtpagocon.Text)
        ' Dim devolver As Integer = 0

        ' devolver = TotalPagar - PagoCon

        ' devolver = lblDevolver.Text

        'usamos los parametros para msgbox y confirmar si quiere eliminar
        Dim opcion As DialogResult
        opcion = MessageBox.Show("La venta se concretará, realmente desea continuar?", "Cobrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = DialogResult.Yes) Then
            Try

                Dim command As New MySqlCommand("INSERT INTO facturas (monto, forma_de_pago, num_cliente, id_vendedor) VALUES(@monto, @forma_de_pago, @num_cliente,  @id_vendedor)")

                command.Parameters.Add("@monto", MySqlDbType.VarChar).Value = lblTotalPagar.Text
                command.Parameters.Add("@forma_de_pago", MySqlDbType.VarChar).Value = CBformadepago.Text
                command.Parameters.Add("@num_cliente", MySqlDbType.VarChar).Value = lblnumCliente.Text
                command.Parameters.Add("@id_vendedor", MySqlDbType.VarChar).Value = lblNumVendedor.Text.ToString


                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()

                adapter.Fill(table)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If


        If RealizarFactura.DGVVentas.Rows.Count = 0 Then
            Return
        End If

        Try

            For Each row As DataGridViewRow In RealizarFactura.DGVVentas.Rows

                Dim command1 As New MySqlCommand("INSERT INTO genera (n_factura, precio_v, cantidad, descripcion, cod_producto) VALUES (last_insert_id(), @precio_v, @cantidad,  @descripcion,  @cod_producto)")

                command1.Parameters.Clear()

                command1.Parameters.AddWithValue("@precio_v", CStr(row.Cells("precioventa").Value))
                command1.Parameters.AddWithValue("@cantidad", CInt(row.Cells("cantidad").Value))
                command1.Parameters.AddWithValue("@descripcion", CStr(row.Cells("descripcion").Value))
                command1.Parameters.AddWithValue("@cod_producto", CStr(row.Cells("codigo").Value))

                command1.ExecuteNonQuery()

                Dim adapter As New MySqlDataAdapter(command1)
                Dim table As New DataTable()

                adapter.Fill(table)

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Vendedores.Show()

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'Imprimir directamente sin vista previa
        'Me.prdDocumento.Print()

        'Usar tamaño y posición específica
        'ppdVistaPrevia.SetBounds(0, 0, 1920, 1080)

        'Maximizar formulario de vista previa
        DirectCast(ppdVistaPrevia, Form).WindowState = FormWindowState.Maximized

        ppdVistaPrevia.Show()
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
        For Each column As DataGridViewColumn In RealizarFactura.DGVVentas.Columns
            encabezado = column.HeaderCell
            texto += vbTab + vbTab + encabezado.FormattedValue.ToString()
        Next

        posicionY = margenSuperior + (contador * fuenteImpresion.GetHeight(e.Graphics))
        e.Graphics.DrawString(texto, fuenteImpresion, System.Drawing.Brushes.Black, 10, posicionY)
        'Se deja una línea de separación.
        contador += 2

        'Se recorren las filas del DataGridView hasta llegar a las líneas que nos caben en cada página o al final del DataGridView.
        While contador < lineasPorPagina AndAlso i < RealizarFactura.DGVVentas.Rows.Count
            fila = RealizarFactura.DGVVentas.Rows(i)
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
        If i < RealizarFactura.DGVVentas.Rows.Count Then
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