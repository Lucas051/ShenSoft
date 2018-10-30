Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient

Public Class Cobrar
    'Variables para mover form en none
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

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

                conexioon.Consulta = "INSERT INTO facturas (monto, forma_de_pago, num_cliente, id_vendedor) VALUES('" + lblTotalPagar.Text + "','" + CBformadepago.Text + "','" + txtclientes.Text + "','" + txtvendedor.Text + ");"
                consultar()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If


        If RealizarFactura.DGVVentas.Rows.Count = 0 Then
            Return
        End If
        Try
            conexioon.Consulta = "INSERT INTO genera (n_factura, precio_v, cantidad, descripcion, cod_producto) VALUES (@n_factura, @precio_v, @cantidad,  @descripcion,  @cod_producto)"
            consultar()
            ' Dim cmd As New SqlCommand(Consulta, ubicacion)

            For Each row As DataGridViewRow In RealizarFactura.DGVVentas.Rows

                cmd.Parameters.Clear()

                cmd.Parameters.AddWithValue("@precio_v", CStr(row.Cells("precioventa").Value))
                cmd.Parameters.AddWithValue("@cantidad", CInt(row.Cells("cantidad").Value))
                cmd.Parameters.AddWithValue("@descripcion", CStr(row.Cells("descripcion").Value))
                cmd.Parameters.AddWithValue("@cod_producto", CStr(row.Cells("codigo").Value))

                cmd.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Vendedores.Show()

    End Sub

End Class