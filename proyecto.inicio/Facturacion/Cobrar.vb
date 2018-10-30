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

    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=lapolleriabd")

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

                Dim command As New MySqlCommand("INSERT INTO facturas (monto, forma_de_pago, num_cliente, id_vendedor) VALUES((@monto, @forma_de_pago, @num_cliente,  @id_vendedor)", connection)
                '  command = New MySqlCommand(Query, MysqlConn)

                command.Parameters.Add("@monto", MySqlDbType.VarChar).Value = lblTotalPagar.Text
                command.Parameters.Add("@forma_de_pago", MySqlDbType.VarChar).Value = CBformadepago.Text
                command.Parameters.Add("@num_cliente", MySqlDbType.VarChar).Value = txtclientes.Text
                command.Parameters.Add("@id_vendedor", MySqlDbType.VarChar).Value = txtvendedor.Text.ToString


                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()

                adapter.Fill(table)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        'guardo valor de la row 0 del insert factura en variable global

        ' despues la inserto en genera

        If RealizarFactura.DGVVentas.Rows.Count = 0 Then
            Return
        End If

        Try

            For Each row As DataGridViewRow In RealizarFactura.DGVVentas.Rows

                Dim command As New MySqlCommand("INSERT INTO genera (n_factura, precio_v, cantidad, descripcion, cod_producto) VALUES (@n_factura, @precio_v, @cantidad,  @descripcion,  @cod_producto)", connection)

                command.Parameters.Clear()

                command.Parameters.Add("@n_factura", MySqlDbType.VarChar).Value = 3
                command.Parameters.AddWithValue("@precio_v", CStr(row.Cells("precioventa").Value))
                command.Parameters.AddWithValue("@cantidad", CInt(row.Cells("cantidad").Value))
                command.Parameters.AddWithValue("@descripcion", CStr(row.Cells("descripcion").Value))
                command.Parameters.AddWithValue("@cod_producto", CStr(row.Cells("codigo").Value))

                command.ExecuteNonQuery()

                Dim adapter As New MySqlDataAdapter(command)
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

End Class