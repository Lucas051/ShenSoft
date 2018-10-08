Imports MySql.Data.MySqlClient
Public Class buscarproductos
    'variables para mover form en none
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitializeComponent()
        Try
            conexioon.Consulta = "SELECT * FROM stock"
            consultar()
            dgvbuscarStock.DataSource = resultado
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Nombramos los encabezados del datagrid buscar

        dgvbuscarStock.Columns(0).HeaderText = "Código"
        dgvbuscarStock.Columns(1).HeaderText = "Descrip."
        dgvbuscarStock.Columns(2).HeaderText = "Cantidad"
        dgvbuscarStock.Columns(3).HeaderText = "Precio Costo"
        dgvbuscarStock.Columns(4).HeaderText = "Precio Venta"
        dgvbuscarStock.Columns(5).HeaderText = "Proveedor"
    End Sub

    Private Sub DataGridbuscar_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvbuscarStock.CellClick
        'Mediante el evento indicamos hacia donde van los valores seleccionados
        RealizarFactura.txtcodigo.Text = dgvbuscarStock.CurrentRow.Cells(0).Value.ToString
        RealizarFactura.txtdesc.Text = dgvbuscarStock.CurrentRow.Cells(1).Value.ToString
        RealizarFactura.txtprecioov.Text = dgvbuscarStock.CurrentRow.Cells(4).Value.ToString
        'close para cerrar el form
        Close()
        RealizarFactura.Show()

    End Sub

    Private Sub btnatrasFacturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatrasFacturacion.Click
        '  Dim llamar As New RealizarFactura
        '   llamar.TopLevel = False
        '  llamar.Parent = Inicio.panelmedio
        '  llamar.Show()
        '  llamar.Dock = DockStyle.Fill
        ' Inicio.panelmedio.Visible = True
        End
    End Sub


    Private Sub txtbuscarProductos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscarProductos.TextChanged
        Try
            'BUSQUEDA DINAMICA EN DATAGRIDVIEW
            conexioon.Consulta = "SELECT * FROM stock WHERE cod_producto LIKE '%" & txtbuscarProductos.Text & "%' and descripcion LIKE '%" & txtbuscarProductos.Text & "%';"
            consultar()
            dgvbuscarStock.DataSource = resultado

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'Para mover FORM en NONE


    Private Sub buscarproductos_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then

            IsFormBeingDragged = True

            MouseDownX = e.X

            MouseDownY = e.Y

        End If

    End Sub

    Private Sub buscarproductos_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp


        If e.Button = MouseButtons.Left Then

            IsFormBeingDragged = False

        End If

    End Sub

    Private Sub buscarproductos_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)

            Me.Location = temp

            temp = Nothing

        End If

    End Sub
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


End Class