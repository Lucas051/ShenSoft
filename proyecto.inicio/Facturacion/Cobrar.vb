Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Drawing.Printing
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

    Private ultimoid As Integer

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=lapolleriabd")

    Private cadenaConexion As String = ("datasource=localhost;port=3306;username=root;password=;database=lapolleriabd")


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

    Private Sub CBformadepago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBformadepago.SelectedIndexChanged
        If CBformadepago.Text = "Contado" Then
            lblDevolver.Text = Val(txtpagocon.Text) - Val(lblTotalPagar.Text)
        ElseIf CBformadepago.Text = "Cuenta" Then
            lblDevolver.Text = 0
        End If
    End Sub

    Private Sub btncobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncobrar.Click
       
        Dim opcion As DialogResult
        opcion = MessageBox.Show("La venta se concretará, realmente desea continuar?", "Cobrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = DialogResult.Yes) Then
            Try

                conexioon.Consulta = "INSERT INTO facturas (monto, forma_de_pago, num_cliente, id_vendedor) VALUES('" + lblTotalPagar.Text + "','" + CBformadepago.Text + "','" + lblnumCliente.Text + "','" + lblNumVendedor.Text + "');"
                consultar()

                Try

                    ' Creamos el comando
                    Dim cmd As MySqlCommand = connection.CreateCommand()

                    ' Construimos la consulta T-SQL que deseamos ejecutar
                    '
                    cmd.CommandText = "SELECT max(n_factura) from facturas;"

                    ' Abrimos la conexión
                    connection.Open()

                    ' Ejecutamos la consulta
                    Dim value As Object = cmd.ExecuteScalar()

                    ' Pasamos el valor a la variable
                    ultimoid = Convert.ToString(value)

                    connection.Close()
                Catch ex As Exception
                    ' Se ha producido un error.
                    MessageBox.Show(ex.Message)

                End Try

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

        

        If RealizarFactura.DGVVentas.Rows.Count = 0 Then
            Return
        End If

        If (CBformadepago.Text = "Cuenta") Then
            Try
                conexioon.Consulta = "UPDATE clientes SET saldo_c = saldo_c + " + lblTotalPagar.Text + " WHERE num_cliente=" + lblnumCliente.Text + ";"
                consultar()

                'usamos los parametros para msgbox 

                MessageBox.Show("Saldo agregado a cuenta del cliente!", "INGRESO COMPLETADO")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        

        Try
            ' connection.Open()





            Dim query As String

            query = "INSERT INTO genera (n_factura, precio_v, cantidad, descripcion, cod_producto) VALUES (?n_factura, ?precio_v, ?cantidad, ?descripcion, ?cod_producto)"

            Dim cmd As New MySqlCommand(query, connection)

            cmd.Connection = connection

            Dim i As Integer = 0

            For i = 0 To RealizarFactura.DGVVentas.Rows.Count - 1

                cmd.Parameters.Clear()

                cmd.Connection.Open()

                cmd.Parameters.AddWithValue("?n_factura", MySqlDbType.Int32).Value = ultimoid
                cmd.Parameters.AddWithValue("?precio_v", RealizarFactura.DGVVentas.Rows.Item(i).Cells(5).Value)
                cmd.Parameters.AddWithValue("?cantidad", RealizarFactura.DGVVentas.Rows.Item(i).Cells(2).Value)
                cmd.Parameters.AddWithValue("?descripcion", RealizarFactura.DGVVentas.Rows.Item(i).Cells(1).Value)
                cmd.Parameters.AddWithValue("?cod_producto", RealizarFactura.DGVVentas.Rows.Item(i).Cells(0).Value)

                cmd.ExecuteNonQuery()
                cmd.Connection.Close()

            Next
           


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        MessageBox.Show("Venta Guardada con éxito", "Venta Concretada")

        Dim i1 As Integer = 0
        RealizarFactura.lblMontoTotal.Text = 0
        For i1 = 0 To RealizarFactura.DGVVentas.Rows.Count - 1

            RealizarFactura.DGVVentas.Rows.Remove(RealizarFactura.DGVVentas.CurrentRow)
        Next

        Me.Hide()
        Inicio.Show()

        Dim llamarInicio As New PlantillaInicio
        Inicio.panelmedio.Controls.Clear()
        llamarInicio.TopLevel = False
        llamarInicio.Parent = Inicio.panelmedio
        llamarInicio.Show()
        llamarInicio.Dock = DockStyle.Fill


        Inicio.panelmedio.Visible = True



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Vendedores.Show()

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
            texto += vbTab + " || " + encabezado.FormattedValue.ToString() + " || "
        Next

        posicionY = margenSuperior + (contador * fuenteImpresion.GetHeight(e.Graphics))
        e.Graphics.DrawString(texto, fuenteImpresion, System.Drawing.Brushes.Black, -10, posicionY)
        'Se deja una línea de separación.
        contador += 2

        'Se recorren las filas del DataGridView hasta llegar a las líneas que nos caben en cada página o al final del DataGridView.
        While contador < lineasPorPagina AndAlso i < RealizarFactura.DGVVentas.Rows.Count
            fila = RealizarFactura.DGVVentas.Rows(i)
            texto = ""
            For Each celda As System.Windows.Forms.DataGridViewCell In fila.Cells
                'Se comprueba que la celda tenga algún valor, en caso de permitir añadir filas esto es necesario.
                If celda.Value IsNot Nothing Then
                    texto += vbTab + " ||     " + celda.Value.ToString() + " ||     "
                End If
            Next

            'Se calcula la posición en la que se escribe la línea.
            posicionY = margenSuperior + (contador * fuenteImpresion.GetHeight(e.Graphics))

            'Se escribe la línea con el objeto Graphics.
            e.Graphics.DrawString(texto, fuenteImpresion, System.Drawing.Brushes.Black, 20, posicionY)
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

        Dim fecha As String
        Dim iva As Integer
        Dim subtotal As Integer

        iva = (Val(lblTotalPagar.Text) * 22) / 100

        subtotal = Val(lblTotalPagar.Text) - iva

        fecha = DateTime.Now.ToString("dd/MM/yyyy")

        e.Graphics.DrawString("E-Ticket Contado", lblTotalPagar.Font, Brushes.Black, 10, 10)

        e.Graphics.DrawString("EMITE: ", fuentetitulos, Brushes.Black, 200, 10)
        e.Graphics.DrawString("La Pollería", lblTotalPagar.Font, Brushes.Black, 265, 10)

        e.Graphics.DrawString("PARA: ", fuentetitulos, Brushes.Black, 400, 10)
        e.Graphics.DrawString(txtclientes.Text, lblTotalPagar.Font, Brushes.Black, 465, 10)

        e.Graphics.DrawString("VENDEDOR: ", fuentetitulos, Brushes.Black, 360, 30)
        e.Graphics.DrawString(txtvendedor.Text, lblTotalPagar.Font, Brushes.Black, 470, 30)

        e.Graphics.DrawString(fecha, lblTotalPagar.Font, Brushes.Black, 665, 10)

        e.Graphics.DrawString("SUBTOTAL:", fuentetitulos, Brushes.Black, 650, 400)
        e.Graphics.DrawString(subtotal, lblTotalPagar.Font, Brushes.Black, 800, 400)

        e.Graphics.DrawString("IVA(22%):", fuentetitulos, Brushes.Black, 650, 450)
        e.Graphics.DrawString(iva, lblTotalPagar.Font, Brushes.Black, 800, 450)

        e.Graphics.DrawString("TOTAL PAGADO:", fuentetitulos, Brushes.Black, 650, 500)
        e.Graphics.DrawString(lblTotalPagar.Text, lblTotalPagar.Font, Brushes.Black, 800, 500)
    End Sub

  
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'Se define la fuente que vamos a usar para imprimir. En este caso Arial de 10.
        Dim fuenteImpresion As System.Drawing.Font = New Font("Arial", 10)
        Dim margenSuperior As Double = e.MarginBounds.Top
        Dim posicionY As Double = 0
        Dim lineasPorPagina As Double = 0
        Dim contador As Integer = 0
        Dim texto As String = ""
        prdDocumento.DefaultPageSettings.Landscape = True

        Dim bm As New Bitmap(RealizarFactura.DGVVentas.Width, RealizarFactura.DGVVentas.Height)
        RealizarFactura.DGVVentas.DrawToBitmap(bm, New Rectangle(0, 0, RealizarFactura.DGVVentas.Width, RealizarFactura.DGVVentas.Height))
        e.Graphics.DrawImage(bm, 0, 0)

        e.Graphics.DrawString(lblTotalPagar.Text, fuenteImpresion, System.Drawing.Brushes.Black, -50, posicionY)


    End Sub
End Class