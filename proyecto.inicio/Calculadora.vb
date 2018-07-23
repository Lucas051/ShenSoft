Public Class Calculadora
    Dim operacion As String
    'va a aceptar valores nulos y comenzará con nada
    Dim valorResultado As Nullable(Of Double) = Nothing
    Dim valor2 As Nullable(Of Double) = Nothing
    Dim presiona As Boolean

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        restriccionesPARAconcatenar()
        TxtCaja.Text &= "1"
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        restriccionesPARAconcatenar()
        TxtCaja.Text &= "2"
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        restriccionesPARAconcatenar()
        TxtCaja.Text &= "3"
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        restriccionesPARAconcatenar()
        TxtCaja.Text &= "4"
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        restriccionesPARAconcatenar()
        TxtCaja.Text &= "5"
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        restriccionesPARAconcatenar()
        TxtCaja.Text &= "6"
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        restriccionesPARAconcatenar()
        TxtCaja.Text &= "7"
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        restriccionesPARAconcatenar()
        TxtCaja.Text &= "8"
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        restriccionesPARAconcatenar()
        TxtCaja.Text &= "9"
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        restriccionesPARAconcatenar()
        TxtCaja.Text &= "0"
    End Sub

    Private Sub btncoma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncoma.Click
        restriccionesPARAconcatenar()
        'InStr nos dejara poner punto si no encuentra uno, si ya existe no se repite, de esta manera no se acumulan los puntos en textbox
        If InStr(TxtCaja.Text, ",", CompareMethod.Text) = 0 Then
            TxtCaja.Text &= ","
        End If
    End Sub

    Public Sub evaluaoperacion()
        'funcion para los botones de calculo, asi ahorramos en hacer esto en todos los eventos click
        presiona = True
        valor2 = Val(TxtCaja.Text)
        If valorResultado IsNot Nothing Then
            Select Case operacion
                Case "+"
                    valorResultado = valorResultado + valor2
                Case "-"
                    valorResultado -= valor2
                Case "/"
                    valorResultado /= valor2
                Case "*"
                    valorResultado *= valor2
            End Select
            TxtCaja.Text = valorResultado
        Else
            valorResultado = valor2
        End If
    End Sub

    Private Sub btnmas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmas.Click
        evaluaoperacion()
        operacion = "+"
    End Sub

    Private Sub btnmenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenos.Click
        evaluaoperacion()
        operacion = "-"
    End Sub

    Private Sub btnDivid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivid.Click
        evaluaoperacion()
        operacion = "/"
    End Sub

    Private Sub btnPor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPor.Click
        evaluaoperacion()
        operacion = "*"
    End Sub

    Private Sub btnigual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnigual.Click
        evaluaoperacion()
        operacion = ""
    End Sub

    Public Sub restriccionesPARAconcatenar()
        If presiona = True Then
            TxtCaja.Text = ""
            presiona = False
            'si en la caja hay un 0 lo eliminamos
        ElseIf TxtCaja.Text = "0" Then
            TxtCaja.Text = ""
        End If
    End Sub

    Private Sub btnborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborrar.Click
        TxtCaja.Text = "0"
        valor2 = Nothing
        valorResultado = Nothing
    End Sub

    Private Sub Calculadora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class