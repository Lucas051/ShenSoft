Public Class BuscarClientes


    Private Sub BuscarClientesFact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            conexioon.Consulta = "SELECT * FROM clientes;"
            consultar()
            dcvclientes.DataSource = resultado

            dcvclientes.Columns(0).HeaderText = "Código"
            dcvclientes.Columns(1).HeaderText = "Cédula"
            dcvclientes.Columns(2).HeaderText = "Nombre"
            dcvclientes.Columns(3).HeaderText = "Saldo"
            dcvclientes.Columns(4).HeaderText = "Direccion"
            dcvclientes.Columns(5).HeaderText = "Teléfono"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtbuscarc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscarc.TextChanged

        Try
            conexioon.Consulta = "SELECT * FROM clientes WHERE nombre_cliente LIKE '%" & txtbuscarc.Text & "%';"
            consultar()
            dcvclientes.DataSource = resultado


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Hide()
        Inicio.Show()

    End Sub

End Class