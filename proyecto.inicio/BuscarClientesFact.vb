<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿Public Class BuscarClientesFact

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
        DGClientesFac.Columns(3).HeaderText = "Saldo"
        DGClientesFac.Columns(4).HeaderText = "Direccion"
        DGClientesFac.Columns(5).HeaderText = "Telefono"
    End Sub

    Private Sub DGClientesFac_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGClientesFac.CellClick
        'Mediante el evento indicamos hacia donde van los valores seleccionados
        Cobrar.TextBoxcliente.Text = DGClientesFac.CurrentRow.Cells(0).Value.ToString
        'close para cerrar el form
        Close()
        Cobrar.Show()
    End Sub
=======
﻿Public Class BuscarClientesFact

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
        DGClientesFac.Columns(3).HeaderText = "Saldo"
        DGClientesFac.Columns(4).HeaderText = "Direccion"
        DGClientesFac.Columns(5).HeaderText = "Telefono"
    End Sub

    Private Sub DGClientesFac_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGClientesFac.CellClick
        'Mediante el evento indicamos hacia donde van los valores seleccionados
        Cobrar.TextBoxcliente.Text = DGClientesFac.CurrentRow.Cells(0).Value.ToString
        'close para cerrar el form
        Close()
        Cobrar.Show()
    End Sub
>>>>>>> b9ac1fc0ad416c297c35c829e7c17ad9a49cbaf6
=======
﻿Public Class BuscarClientesFact

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
        DGClientesFac.Columns(3).HeaderText = "Saldo"
        DGClientesFac.Columns(4).HeaderText = "Direccion"
        DGClientesFac.Columns(5).HeaderText = "Telefono"
    End Sub

    Private Sub DGClientesFac_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGClientesFac.CellClick
        'Mediante el evento indicamos hacia donde van los valores seleccionados
        Cobrar.TextBoxcliente.Text = DGClientesFac.CurrentRow.Cells(0).Value.ToString
        'close para cerrar el form
        Close()
        Cobrar.Show()
    End Sub
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
=======
﻿Public Class BuscarClientesFact

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
        DGClientesFac.Columns(3).HeaderText = "Saldo"
        DGClientesFac.Columns(4).HeaderText = "Direccion"
        DGClientesFac.Columns(5).HeaderText = "Telefono"
    End Sub

    Private Sub DGClientesFac_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGClientesFac.CellClick
        'Mediante el evento indicamos hacia donde van los valores seleccionados
        Cobrar.TextBoxcliente.Text = DGClientesFac.CurrentRow.Cells(0).Value.ToString
        'close para cerrar el form
        Close()
        Cobrar.Show()
    End Sub
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
=======
﻿Public Class BuscarClientesFact

    Private Sub BuscarClientesFact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexioon.Consulta = "SELECT * from clientes"
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
        Cobrar.TextBoxcliente.Text = DGClientesFac.CurrentRow.Cells(0).Value.ToString
        'close para cerrar el form
        Close()
        Cobrar.Show()
    End Sub

    Private Sub atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atras.Click
        Me.Hide()
        Cobrar.Show()

    End Sub

    Private Sub cerrarbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cerrarbtn.Click
        End
    End Sub

    Private Sub btnmaxi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmaxi.Click
        'maximiza ventana
        Me.WindowState = FormWindowState.Maximized
        'esconde boton, aparece restaurar
        btnmaxi.Visible = False
        btnrestaurar.Visible = True
    End Sub

    Private Sub btnmini_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmini.Click
        'minimiza ventana
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnrestaurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrestaurar.Click
        'restaura ventana
        Me.WindowState = FormWindowState.Normal
        'esconde boton, aparece maximizar
        btnrestaurar.Visible = False
        btnmaxi.Visible = True
    End Sub
>>>>>>> d19429f7d8081b4cb9859b313d55c7febe1d6b68
End Class