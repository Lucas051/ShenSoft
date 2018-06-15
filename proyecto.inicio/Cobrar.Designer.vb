<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cobrar
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Vendedor = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.formadepago = New System.Windows.Forms.Label()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.imprimir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.devolver = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pagocon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(308, 85)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 30
        '
        'Vendedor
        '
        Me.Vendedor.AutoSize = True
        Me.Vendedor.Location = New System.Drawing.Point(224, 88)
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.Size = New System.Drawing.Size(53, 13)
        Me.Vendedor.TabIndex = 29
        Me.Vendedor.Text = "Vendedor"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(308, 36)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 28
        '
        'formadepago
        '
        Me.formadepago.AutoSize = True
        Me.formadepago.Location = New System.Drawing.Point(224, 39)
        Me.formadepago.Name = "formadepago"
        Me.formadepago.Size = New System.Drawing.Size(78, 13)
        Me.formadepago.TabIndex = 27
        Me.formadepago.Text = "Forma de pago"
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(227, 344)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(100, 23)
        Me.limpiar.TabIndex = 26
        Me.limpiar.Text = "Limpiar Campos"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'imprimir
        '
        Me.imprimir.Location = New System.Drawing.Point(136, 344)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(75, 23)
        Me.imprimir.TabIndex = 25
        Me.imprimir.Text = "Imprimir"
        Me.imprimir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Cobrar Monto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(523, 60)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(444, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Total a pagar"
        '
        'devolver
        '
        Me.devolver.Location = New System.Drawing.Point(105, 85)
        Me.devolver.Name = "devolver"
        Me.devolver.Size = New System.Drawing.Size(100, 20)
        Me.devolver.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Devolver"
        '
        'pagocon
        '
        Me.pagocon.Location = New System.Drawing.Point(105, 36)
        Me.pagocon.Name = "pagocon"
        Me.pagocon.Size = New System.Drawing.Size(100, 20)
        Me.pagocon.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Pagó con"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(678, 359)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(105, 140)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 33
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Location = New System.Drawing.Point(51, 143)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Cliente.TabIndex = 32
        Me.Cliente.Text = "Cliente"
        '
        'Cobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 394)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Vendedor)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.formadepago)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.imprimir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.devolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pagocon)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Cobrar"
        Me.Text = "Cobrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Vendedor As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents formadepago As System.Windows.Forms.Label
    Friend WithEvents limpiar As System.Windows.Forms.Button
    Friend WithEvents imprimir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents devolver As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pagocon As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Cliente As System.Windows.Forms.Label
End Class
