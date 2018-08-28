Imports MySql.Data.MySqlClient
Public Class ConsultaFactura
    Private Sub Atras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtras.Click
        Me.Hide()
        Inicio.Show()

    End Sub

    Private Sub ConsultaFactura_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
       
        conexioon.Consulta = "SELECT * FROM facturas"
        consultar()
        datagridconsulta.DataSource = resultado
    End Sub
End Class