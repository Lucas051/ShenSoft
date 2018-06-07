<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealizarFactura
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
        Me.DataGridFacturas = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pagocon = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.devolver = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.TextBox()
        Me.atras = New System.Windows.Forms.Button()
        Me.cobrar = New System.Windows.Forms.Button()
        Me.imprimir = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.formadepago = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Vendedor = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.buscarb = New System.Windows.Forms.Button()
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridFacturas
        '
        Me.DataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridFacturas.Location = New System.Drawing.Point(278, 63)
        Me.DataGridFacturas.Name = "DataGridFacturas"
        Me.DataGridFacturas.Size = New System.Drawing.Size(643, 174)
        Me.DataGridFacturas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pagó con"
        '
        'pagocon
        '
        Me.pagocon.Location = New System.Drawing.Point(75, 261)
        Me.pagocon.Name = "pagocon"
        Me.pagocon.Size = New System.Drawing.Size(100, 20)
        Me.pagocon.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Devolver"
        '
        'devolver
        '
        Me.devolver.Location = New System.Drawing.Point(75, 310)
        Me.devolver.Name = "devolver"
        Me.devolver.Size = New System.Drawing.Size(100, 20)
        Me.devolver.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(414, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total a pagar"
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(493, 285)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 6
        '
        'atras
        '
        Me.atras.Location = New System.Drawing.Point(602, 358)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(75, 23)
        Me.atras.TabIndex = 7
        Me.atras.Text = "Atras"
        Me.atras.UseVisualStyleBackColor = True
        '
        'cobrar
        '
        Me.cobrar.Location = New System.Drawing.Point(9, 359)
        Me.cobrar.Name = "cobrar"
        Me.cobrar.Size = New System.Drawing.Size(96, 23)
        Me.cobrar.TabIndex = 8
        Me.cobrar.Text = "Cobrar Monto"
        Me.cobrar.UseVisualStyleBackColor = True
        '
        'imprimir
        '
        Me.imprimir.Location = New System.Drawing.Point(121, 359)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(75, 23)
        Me.imprimir.TabIndex = 9
        Me.imprimir.Text = "Imprimir"
        Me.imprimir.UseVisualStyleBackColor = True
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(212, 359)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(100, 23)
        Me.limpiar.TabIndex = 10
        Me.limpiar.Text = "Limpiar Campos"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Location = New System.Drawing.Point(9, 25)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Cliente.TabIndex = 11
        Me.Cliente.Text = "Cliente"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(54, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 12
        '
        'formadepago
        '
        Me.formadepago.AutoSize = True
        Me.formadepago.Location = New System.Drawing.Point(194, 264)
        Me.formadepago.Name = "formadepago"
        Me.formadepago.Size = New System.Drawing.Size(78, 13)
        Me.formadepago.TabIndex = 13
        Me.formadepago.Text = "Forma de pago"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(278, 261)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 14
        '
        'Vendedor
        '
        Me.Vendedor.AutoSize = True
        Me.Vendedor.Location = New System.Drawing.Point(194, 313)
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.Size = New System.Drawing.Size(53, 13)
        Me.Vendedor.TabIndex = 15
        Me.Vendedor.Text = "Vendedor"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(278, 310)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 16
        '
        'buscarb
        '
        Me.buscarb.Location = New System.Drawing.Point(846, 34)
        Me.buscarb.Name = "buscarb"
        Me.buscarb.Size = New System.Drawing.Size(75, 23)
        Me.buscarb.TabIndex = 18
        Me.buscarb.Text = "Buscar"
        Me.buscarb.UseVisualStyleBackColor = True
        '
        'RealizarFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 476)
        Me.Controls.Add(Me.buscarb)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Vendedor)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.formadepago)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.imprimir)
        Me.Controls.Add(Me.cobrar)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.devolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pagocon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridFacturas)
        Me.Name = "RealizarFactura"
        Me.Text = "RealizarFactura"
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridFacturas As System.Windows.Forms.DataGridView
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pagocon As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents devolver As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents atras As System.Windows.Forms.Button
    Friend WithEvents cobrar As System.Windows.Forms.Button
    Friend WithEvents imprimir As System.Windows.Forms.Button
    Friend WithEvents limpiar As System.Windows.Forms.Button
    Friend WithEvents Cliente As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents formadepago As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Vendedor As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents buscarb As System.Windows.Forms.Button
End Class
