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
        Me.seleccionar = New System.Windows.Forms.Button()
        Me.agregar = New System.Windows.Forms.Button()
        Me.limpiarv = New System.Windows.Forms.Button()
        Me.cod = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.Label()
        Me.cantidad = New System.Windows.Forms.Label()
        Me.preciov = New System.Windows.Forms.Label()
        Me.descuento = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridFacturas
        '
        Me.DataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridFacturas.Location = New System.Drawing.Point(223, 63)
        Me.DataGridFacturas.Name = "DataGridFacturas"
        Me.DataGridFacturas.Size = New System.Drawing.Size(676, 192)
        Me.DataGridFacturas.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(277, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pagó con"
        '
        'pagocon
        '
        Me.pagocon.Location = New System.Drawing.Point(346, 279)
        Me.pagocon.Name = "pagocon"
        Me.pagocon.Size = New System.Drawing.Size(100, 20)
        Me.pagocon.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Devolver"
        '
        'devolver
        '
        Me.devolver.Location = New System.Drawing.Point(346, 328)
        Me.devolver.Name = "devolver"
        Me.devolver.Size = New System.Drawing.Size(100, 20)
        Me.devolver.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(685, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total a pagar"
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(764, 303)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 6
        '
        'atras
        '
        Me.atras.Location = New System.Drawing.Point(824, 377)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(75, 23)
        Me.atras.TabIndex = 7
        Me.atras.Text = "Atras"
        Me.atras.UseVisualStyleBackColor = True
        '
        'cobrar
        '
        Me.cobrar.Location = New System.Drawing.Point(280, 377)
        Me.cobrar.Name = "cobrar"
        Me.cobrar.Size = New System.Drawing.Size(96, 23)
        Me.cobrar.TabIndex = 8
        Me.cobrar.Text = "Cobrar Monto"
        Me.cobrar.UseVisualStyleBackColor = True
        '
        'imprimir
        '
        Me.imprimir.Location = New System.Drawing.Point(392, 377)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(75, 23)
        Me.imprimir.TabIndex = 9
        Me.imprimir.Text = "Imprimir"
        Me.imprimir.UseVisualStyleBackColor = True
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(483, 377)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(100, 23)
        Me.limpiar.TabIndex = 10
        Me.limpiar.Text = "Limpiar Campos"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Location = New System.Drawing.Point(35, 66)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Cliente.TabIndex = 11
        Me.Cliente.Text = "Cliente"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(89, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 12
        '
        'formadepago
        '
        Me.formadepago.AutoSize = True
        Me.formadepago.Location = New System.Drawing.Point(465, 282)
        Me.formadepago.Name = "formadepago"
        Me.formadepago.Size = New System.Drawing.Size(78, 13)
        Me.formadepago.TabIndex = 13
        Me.formadepago.Text = "Forma de pago"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(549, 279)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 14
        '
        'Vendedor
        '
        Me.Vendedor.AutoSize = True
        Me.Vendedor.Location = New System.Drawing.Point(465, 331)
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.Size = New System.Drawing.Size(53, 13)
        Me.Vendedor.TabIndex = 15
        Me.Vendedor.Text = "Vendedor"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(549, 328)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 16
        '
        'buscarb
        '
        Me.buscarb.Location = New System.Drawing.Point(824, 34)
        Me.buscarb.Name = "buscarb"
        Me.buscarb.Size = New System.Drawing.Size(75, 23)
        Me.buscarb.TabIndex = 18
        Me.buscarb.Text = "Buscar"
        Me.buscarb.UseVisualStyleBackColor = True
        '
        'seleccionar
        '
        Me.seleccionar.Location = New System.Drawing.Point(737, 34)
        Me.seleccionar.Name = "seleccionar"
        Me.seleccionar.Size = New System.Drawing.Size(75, 23)
        Me.seleccionar.TabIndex = 19
        Me.seleccionar.Text = "Seleccionar"
        Me.seleccionar.UseVisualStyleBackColor = True
        '
        'agregar
        '
        Me.agregar.Location = New System.Drawing.Point(114, 273)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(75, 23)
        Me.agregar.TabIndex = 20
        Me.agregar.Text = "Agregar"
        Me.agregar.UseVisualStyleBackColor = True
        '
        'limpiarv
        '
        Me.limpiarv.Location = New System.Drawing.Point(28, 273)
        Me.limpiarv.Name = "limpiarv"
        Me.limpiarv.Size = New System.Drawing.Size(75, 23)
        Me.limpiarv.TabIndex = 21
        Me.limpiarv.Text = "Limpiar"
        Me.limpiarv.UseVisualStyleBackColor = True
        '
        'cod
        '
        Me.cod.AutoSize = True
        Me.cod.Location = New System.Drawing.Point(34, 100)
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(40, 13)
        Me.cod.TabIndex = 22
        Me.cod.Text = "Código"
        '
        'descripcion
        '
        Me.descripcion.AutoSize = True
        Me.descripcion.Location = New System.Drawing.Point(11, 131)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(63, 13)
        Me.descripcion.TabIndex = 23
        Me.descripcion.Text = "Descripción"
        '
        'cantidad
        '
        Me.cantidad.AutoSize = True
        Me.cantidad.Location = New System.Drawing.Point(25, 163)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(49, 13)
        Me.cantidad.TabIndex = 24
        Me.cantidad.Text = "Cantidad"
        '
        'preciov
        '
        Me.preciov.AutoSize = True
        Me.preciov.Location = New System.Drawing.Point(6, 227)
        Me.preciov.Name = "preciov"
        Me.preciov.Size = New System.Drawing.Size(68, 13)
        Me.preciov.TabIndex = 25
        Me.preciov.Text = "Precio Venta"
        '
        'descuento
        '
        Me.descuento.AutoSize = True
        Me.descuento.Location = New System.Drawing.Point(15, 195)
        Me.descuento.Name = "descuento"
        Me.descuento.Size = New System.Drawing.Size(59, 13)
        Me.descuento.TabIndex = 26
        Me.descuento.Text = "Descuento"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(89, 97)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 27
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(89, 160)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 28
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(89, 192)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 29
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(89, 224)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 30
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(89, 128)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 31
        '
        'RealizarFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 413)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.descuento)
        Me.Controls.Add(Me.preciov)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.cod)
        Me.Controls.Add(Me.limpiarv)
        Me.Controls.Add(Me.agregar)
        Me.Controls.Add(Me.seleccionar)
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
    Friend WithEvents seleccionar As System.Windows.Forms.Button
    Friend WithEvents agregar As System.Windows.Forms.Button
    Friend WithEvents limpiarv As System.Windows.Forms.Button
    Friend WithEvents cod As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.Label
    Friend WithEvents cantidad As System.Windows.Forms.Label
    Friend WithEvents preciov As System.Windows.Forms.Label
    Friend WithEvents descuento As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
End Class
