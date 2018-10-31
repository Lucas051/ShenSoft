Public Class Deudores


    Private Sub Deudores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            conexioon.Consulta = "SELECT * FROM clientes WHERE saldo_c <> 0"
            consultar()
            DgvClientes.DataSource = resultado

            'Cambiar el nombre que tienen las columnas de Mysql esos "cod_producto" etc
            DgvClientes.Columns(0).HeaderText = "Código"
            DgvClientes.Columns(1).HeaderText = "Cédula"
            DgvClientes.Columns(2).HeaderText = "Nombre"
            DgvClientes.Columns(3).HeaderText = "Teléfono"
            DgvClientes.Columns(4).HeaderText = "Dirección"
            DgvClientes.Columns(5).HeaderText = "Saldo"

            'ancho de columnas dgv
            DgvClientes.Columns(0).Width = 60
            DgvClientes.Columns(1).Width = 130
            DgvClientes.Columns(2).Width = 200
            DgvClientes.Columns(3).Width = 100
            DgvClientes.Columns(4).Width = 200
            DgvClientes.Columns(5).Width = 125


        Catch ex As Exception

            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub txtBuscarP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarP.TextChanged
        Try
            'BUSQUEDA DINAMICA EN DATAGRIDVIEW
            conexioon.Consulta = "SELECT * FROM clientes WHERE saldo_c <> 0 and nombre_cliente LIKE '%" & txtBuscarP.Text & "%';"
            consultar()
            DgvClientes.DataSource = resultado



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class