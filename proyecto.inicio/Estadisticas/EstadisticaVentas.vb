Public Class EstadisticaVentas

    Dim xa As Integer = 1

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Select Case xa
            Case 0
                ChartVentas.Series("Grafica").ChartType = DataVisualization.Charting.SeriesChartType.Pie
                Button2.Text = "Circular"
                xa = 1
            Case 1

                ChartVentas.Series("Grafica").ChartType = DataVisualization.Charting.SeriesChartType.Doughnut
                Button2.Text = "Dona"
                xa = 2
            Case 2
                ChartVentas.Series("Grafica").ChartType = DataVisualization.Charting.SeriesChartType.Bar

                Button2.Text = "Barras"
                xa = 3
            Case 3
                ChartVentas.Series("Grafica").ChartType = DataVisualization.Charting.SeriesChartType.Column
                Button2.Text = "Columna"
                xa = 4
            Case 4
                ChartVentas.Series("Grafica").ChartType = DataVisualization.Charting.SeriesChartType.Funnel
                Button2.Text = "Funnel"
                xa = 5
            Case 5
                ChartVentas.Series("Grafica").ChartType = DataVisualization.Charting.SeriesChartType.Range
                Button2.Text = "Rango"
                xa = 6
            Case 6
                ChartVentas.Series("Grafica").ChartType = DataVisualization.Charting.SeriesChartType.Pyramid
                Button2.Text = "Piramide"
                xa = 0
        End Select

    End Sub

    Private Sub EstadisticaVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChartVentas.Series.Clear()



        Consulta = "SELECT * FROM stock WHERE cod_producto not in(SELECT cod_producto from genera);"
        consultar()

        ChartVentas.Series.Add("Grafica")
        ChartVentas.Series.Add("Grafica1")

        ChartVentas.Series(0).Palette = DataVisualization.Charting.ChartColorPalette.SemiTransparent
        ChartVentas.Series(1).Palette = DataVisualization.Charting.ChartColorPalette.SemiTransparent

        Dim contador = 0
        For Each row As DataRow In resultado.Rows
            ChartVentas.Series("Grafica").Points.AddXY("#PERCENT", row("cod_producto"))
            ChartVentas.Series("Grafica").Points.Item(contador).LegendText = row("cod_producto") & " años"

            ChartVentas.Series("Grafica1").Points.AddXY("#PERCENT", row("cod_producto"))
            ChartVentas.Series("Grafica1").Points.Item(contador).LegendText = row("cod_producto") & " años"

            contador = contador + 1
        Next
        contador = 0
        ChartVentas.Series("Grafica").ChartType = DataVisualization.Charting.SeriesChartType.Column

        CBConsultas.Items.Add("Productos más vendido")
        CBConsultas.Items.Add("Productos menos vendido")
        CBConsultas.Items.Add("Productos que aún no se han vendido")
    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        If (CBConsultas.Text = "Productos que aún no se han vendido") Then
            Try
                Consulta = "SELECT * FROM stock WHERE cod_producto not in(SELECT cod_producto from genera);"
                consultar()
                dgvconsultas.DataSource = resultado


            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        ElseIf (CBConsultas.Text = "Productos más vendido") Then
            Try
                Consulta = "select *, sum(cantidad) as 'Cantidad Total' from genera group by cod_producto;"
                consultar()
                dgvconsultas.DataSource = resultado

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub
End Class