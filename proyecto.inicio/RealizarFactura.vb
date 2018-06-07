Imports MySql.Data.MySqlClient

Public Class RealizarFactura

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridFacturas.CellContentClick

    End Sub

    Private Sub atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles atras.Click
        Me.Hide()
        Facturacion.Show()
    End Sub

    Private Sub RealizarFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub



    Private Sub buscarb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buscarb.Click
        '   buscarb.Visible = False
        '  DataGridbuscar.Visible = True
        ' DataGridFacturas.Visible = False
        'seleccionar.Visible = True
        'cancelar.Visible = True
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelar.Click
        buscarb.Visible = True
        ' DataGridbuscar.Visible = False
        DataGridFacturas.Visible = True
        seleccionar.Visible = False
        cancelar.Visible = False
    End Sub

    Private Sub DataGridbuscar_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
End Class