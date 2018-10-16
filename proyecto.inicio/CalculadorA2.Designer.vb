<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculadorA2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtCaja = New System.Windows.Forms.TextBox()
        Me.btncoma = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnigual = New System.Windows.Forms.Button()
        Me.btnmenos = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btnmas = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btnDivid = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btnPor = New System.Windows.Forms.Button()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtCaja
        '
        Me.TxtCaja.Location = New System.Drawing.Point(12, 13)
        Me.TxtCaja.Multiline = True
        Me.TxtCaja.Name = "TxtCaja"
        Me.TxtCaja.Size = New System.Drawing.Size(235, 46)
        Me.TxtCaja.TabIndex = 0
        '
        'btncoma
        '
        Me.btncoma.Location = New System.Drawing.Point(12, 221)
        Me.btncoma.Name = "btncoma"
        Me.btncoma.Size = New System.Drawing.Size(55, 46)
        Me.btncoma.TabIndex = 1
        Me.btncoma.Text = ","
        Me.btncoma.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(73, 221)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(55, 46)
        Me.btn0.TabIndex = 2
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnigual
        '
        Me.btnigual.Location = New System.Drawing.Point(134, 273)
        Me.btnigual.Name = "btnigual"
        Me.btnigual.Size = New System.Drawing.Size(116, 46)
        Me.btnigual.TabIndex = 3
        Me.btnigual.Text = "="
        Me.btnigual.UseVisualStyleBackColor = True
        '
        'btnmenos
        '
        Me.btnmenos.Location = New System.Drawing.Point(195, 117)
        Me.btnmenos.Name = "btnmenos"
        Me.btnmenos.Size = New System.Drawing.Size(55, 46)
        Me.btnmenos.TabIndex = 4
        Me.btnmenos.Text = "-"
        Me.btnmenos.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(12, 65)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(55, 46)
        Me.btn7.TabIndex = 5
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(73, 65)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(55, 46)
        Me.btn8.TabIndex = 6
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(134, 65)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(55, 46)
        Me.btn9.TabIndex = 7
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btnmas
        '
        Me.btnmas.Location = New System.Drawing.Point(195, 169)
        Me.btnmas.Name = "btnmas"
        Me.btnmas.Size = New System.Drawing.Size(55, 46)
        Me.btnmas.TabIndex = 8
        Me.btnmas.Text = "+"
        Me.btnmas.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(12, 117)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(55, 46)
        Me.btn4.TabIndex = 9
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(73, 117)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(55, 46)
        Me.btn5.TabIndex = 10
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(134, 117)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(55, 46)
        Me.btn6.TabIndex = 11
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btnDivid
        '
        Me.btnDivid.Location = New System.Drawing.Point(195, 221)
        Me.btnDivid.Name = "btnDivid"
        Me.btnDivid.Size = New System.Drawing.Size(55, 46)
        Me.btnDivid.TabIndex = 12
        Me.btnDivid.Text = "/"
        Me.btnDivid.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(12, 169)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(55, 46)
        Me.btn1.TabIndex = 13
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(73, 169)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(55, 46)
        Me.btn2.TabIndex = 14
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(134, 169)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(55, 46)
        Me.btn3.TabIndex = 15
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btnPor
        '
        Me.btnPor.Location = New System.Drawing.Point(134, 221)
        Me.btnPor.Name = "btnPor"
        Me.btnPor.Size = New System.Drawing.Size(55, 46)
        Me.btnPor.TabIndex = 16
        Me.btnPor.Text = "*"
        Me.btnPor.UseVisualStyleBackColor = True
        '
        'btnborrar
        '
        Me.btnborrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrar.Location = New System.Drawing.Point(195, 65)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(55, 46)
        Me.btnborrar.TabIndex = 17
        Me.btnborrar.Text = "←"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'CalculadorA2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 329)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.btnPor)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btnDivid)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btnmas)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btnmenos)
        Me.Controls.Add(Me.btnigual)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btncoma)
        Me.Controls.Add(Me.TxtCaja)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CalculadorA2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCaja As System.Windows.Forms.TextBox
    Friend WithEvents btncoma As System.Windows.Forms.Button
    Friend WithEvents btn0 As System.Windows.Forms.Button
    Friend WithEvents btnigual As System.Windows.Forms.Button
    Friend WithEvents btnmenos As System.Windows.Forms.Button
    Friend WithEvents btn7 As System.Windows.Forms.Button
    Friend WithEvents btn8 As System.Windows.Forms.Button
    Friend WithEvents btn9 As System.Windows.Forms.Button
    Friend WithEvents btnmas As System.Windows.Forms.Button
    Friend WithEvents btn4 As System.Windows.Forms.Button
    Friend WithEvents btn5 As System.Windows.Forms.Button
    Friend WithEvents btn6 As System.Windows.Forms.Button
    Friend WithEvents btnDivid As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btnPor As System.Windows.Forms.Button
    Friend WithEvents btnborrar As System.Windows.Forms.Button
End Class
