Imports System.Windows.Forms
Public Class BuscarClientesFact

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Cobrar.Show()

    End Sub

    Private Sub BuscarClientesFact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexioon.Consulta = "SELECT * FROM clientes"
        consultar()
        DGClientesFac.DataSource = resultado

        'Nombramos los encabezados del datagrid buscar

        DGClientesFac.Columns(0).HeaderText = "Número Cliente"
        DGClientesFac.Columns(1).HeaderText = "CI"
        DGClientesFac.Columns(2).HeaderText = "Nombre"
        DGClientesFac.Columns(3).HeaderText = "Dirección"
        DGClientesFac.Columns(4).HeaderText = "Telefono"
        DGClientesFac.Columns(5).HeaderText = "Saldo"
    End Sub

    Private Sub DGClientesFac_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGClientesFac.CellClick
        'Mediante el evento indicamos hacia donde van los valores seleccionados
        Cobrar.TextBoxCliente.Text = DGClientesFac.CurrentRow.Cells(2).Value.ToString 'enviamos nombre de cliente
        'close para cerrar el form
        Close()
        Cobrar.Show()
    End Sub

    Private Sub atrasbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atrasbtn.Click
        Me.Hide()
        Cobrar.Show()

    End Sub

    Private Sub btnmini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmini.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub barratitulo_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles barratitulo.Paint

    End Sub

    Private Sub btnmaxi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmaxi.Click
        Me.WindowState = FormWindowState.Maximized
        'esconde boton, aparece restaurar
        btnmaxi.Visible = False
        btnrestaurar.Visible = True

    End Sub

    Private Sub cerrarbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cerrarbtn.Click
        End
    End Sub

    Private Sub btnrestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrestaurar.Click
        Me.WindowState = FormWindowState.Normal
        'esconde boton, aparece restaurar
        btnmaxi.Visible = True
        btnrestaurar.Visible = False
    End Sub
End Class