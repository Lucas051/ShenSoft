Public Class Calculadora
    Dim Dato As Double
    Dim Dato2 As Double
    Dim Resultado As Double
    Dim Ope As Double
    Dim Btn As Double

   
    Private Sub btnborrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborrar.Click
        TxtCaja.Clear()
        btncoma.Enabled = True

    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        TxtCaja.Text = TxtCaja.Text & "0"
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        TxtCaja.Text = TxtCaja.Text & "1"
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        TxtCaja.Text = TxtCaja.Text & "2"
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        TxtCaja.Text = TxtCaja.Text & "3"
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        TxtCaja.Text = TxtCaja.Text & "4"
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        TxtCaja.Text = TxtCaja.Text & "5"
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        TxtCaja.Text = TxtCaja.Text & "6"
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        TxtCaja.Text = TxtCaja.Text & "7"
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        TxtCaja.Text = TxtCaja.Text & "8"
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        TxtCaja.Text = TxtCaja.Text & "9"
    End Sub

    Private Sub btncoma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncoma.Click
        TxtCaja.Text = TxtCaja.Text & "."
        Btn = 1
        If Btn = 1 Then
            btncoma.Enabled = False

        End If
    End Sub

    Private Sub btnPorcent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtCaja.Text = TxtCaja.Text & "%"
    End Sub

    Private Sub btnPor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPor.Click
        Ope = 4
        Dato = Val(TxtCaja.Text)
        TxtCaja.Clear()
        btncoma.Enabled = True
    End Sub

    Private Sub btnDivid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDivid.Click
        Ope = 3
        Dato = Val(TxtCaja.Text)
        TxtCaja.Clear()
        btncoma.Enabled = True
    End Sub

    Private Sub btnmas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmas.Click
        Ope = 1
        Dato = Val(TxtCaja.Text)
        TxtCaja.Clear()
        btncoma.Enabled = True

    End Sub

    Private Sub btnmenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmenos.Click
        Ope = 2
        Dato = Val(TxtCaja.Text)
        TxtCaja.Clear()
        btncoma.Enabled = True
    End Sub

    Private Sub btnigual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnigual.Click
        Dato2 = Val(TxtCaja.Text)
        btncoma.Enabled = True
        If Ope = 1 Then
            Resultado = Dato + Dato2
            TxtCaja.Text = Resultado
        Else

        End If
        If Ope = 2 Then
            Resultado = Dato - Dato2
            TxtCaja.Text = Resultado
        Else

        End If
        If Ope = 3 Then
            Resultado = Dato / Dato2
            TxtCaja.Text = Resultado
        Else

        End If
        If Ope = 4 Then
            Resultado = Dato * Dato2
            TxtCaja.Text = Resultado

        End If
    End Sub
End Class