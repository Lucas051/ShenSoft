<<<<<<< HEAD
<<<<<<< HEAD
﻿Imports MySql.Data.MySqlClient
Public Class BuscarClientesCobrar

    Private Sub BuscarClientesCobrarvb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexioon.Consulta = "SELECT * FROM clientes"
        consultar()
        DGVbuscarClientes.DataSource = resultado

        'Nombramos los encabezados del datagrid buscarClientes

        DGVbuscarClientes.Columns(0).HeaderText = "Num. Cliente"
        DGVbuscarClientes.Columns(1).HeaderText = "CI"
        DGVbuscarClientes.Columns(2).HeaderText = "Nombre"
        DGVbuscarClientes.Columns(3).HeaderText = "Dirección"
        DGVbuscarClientes.Columns(4).HeaderText = "Telefono"
        DGVbuscarClientes.Columns(5).HeaderText = "Saldo"
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

    Private Sub btnmaxi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmaxi.Click
        'maximiza ventana
        Me.WindowState = FormWindowState.Maximized
        'esconde boton, aparece restaurar
        btnmaxi.Visible = False
        btnrestaurar.Visible = True
    End Sub

    Private Sub cerrarbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cerrarbtn.Click
        'cerrar
        End
    End Sub


    Private Sub DGVbuscar_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVbuscarClientes.CellContentClick
        'Mediante el evento indicamos hacia donde van los valores seleccionados
        Cobrar.TXTcliente.Text = DGVbuscarClientes.CurrentRow.Cells(1).Value.ToString


        'close para cerrar el form
        Close()
        Cobrar.Show()

    End Sub


    Private Sub btnatras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnatras.Click
        Me.Hide()
        Cobrar.Show()
    End Sub
End Class
=======
﻿Module BuscarClientesCobrar

End Module
>>>>>>> 36a69774f74956436592eb9930255f31328ed644
=======
﻿Module BuscarClientesCobrar

End Module
>>>>>>> 36a69774f74956436592eb9930255f31328ed644
