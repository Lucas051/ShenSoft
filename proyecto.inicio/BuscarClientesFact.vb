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
End Class