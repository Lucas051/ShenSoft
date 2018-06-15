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
        Me.agregar = New System.Windows.Forms.Button()
        Me.limpiarv = New System.Windows.Forms.Button()
        Me.cod = New System.Windows.Forms.Label()
        Me.descripcion = New System.Windows.Forms.Label()
        Me.cantidad = New System.Windows.Forms.Label()
        Me.preciov = New System.Windows.Forms.Label()
        Me.descuento = New System.Windows.Forms.Label()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.cant = New System.Windows.Forms.TextBox()
        Me.descuent = New System.Windows.Forms.TextBox()
        Me.precioov = New System.Windows.Forms.TextBox()
        Me.desc = New System.Windows.Forms.TextBox()
        Me.buscarb = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.borrar = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.atras = New System.Windows.Forms.Button()
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridFacturas
        '
        Me.DataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridFacturas.Location = New System.Drawing.Point(223, 63)
        Me.DataGridFacturas.Name = "DataGridFacturas"
        Me.DataGridFacturas.Size = New System.Drawing.Size(676, 192)
        Me.DataGridFacturas.TabIndex = 0
        '
        'agregar
        '
        Me.agregar.Location = New System.Drawing.Point(114, 229)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(75, 26)
        Me.agregar.TabIndex = 20
        Me.agregar.Text = "Agregar"
        Me.agregar.UseVisualStyleBackColor = True
        '
        'limpiarv
        '
        Me.limpiarv.Location = New System.Drawing.Point(28, 229)
        Me.limpiarv.Name = "limpiarv"
        Me.limpiarv.Size = New System.Drawing.Size(75, 26)
        Me.limpiarv.TabIndex = 21
        Me.limpiarv.Text = "Limpiar"
        Me.limpiarv.UseVisualStyleBackColor = True
        '
        'cod
        '
        Me.cod.AutoSize = True
        Me.cod.Location = New System.Drawing.Point(34, 66)
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(40, 13)
        Me.cod.TabIndex = 22
        Me.cod.Text = "Código"
        '
        'descripcion
        '
        Me.descripcion.AutoSize = True
        Me.descripcion.Location = New System.Drawing.Point(11, 97)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(63, 13)
        Me.descripcion.TabIndex = 23
        Me.descripcion.Text = "Descripción"
        '
        'cantidad
        '
        Me.cantidad.AutoSize = True
        Me.cantidad.Location = New System.Drawing.Point(25, 129)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(49, 13)
        Me.cantidad.TabIndex = 24
        Me.cantidad.Text = "Cantidad"
        '
        'preciov
        '
        Me.preciov.AutoSize = True
        Me.preciov.Location = New System.Drawing.Point(6, 193)
        Me.preciov.Name = "preciov"
        Me.preciov.Size = New System.Drawing.Size(68, 13)
        Me.preciov.TabIndex = 25
        Me.preciov.Text = "Precio Venta"
        '
        'descuento
        '
        Me.descuento.AutoSize = True
        Me.descuento.Location = New System.Drawing.Point(15, 161)
        Me.descuento.Name = "descuento"
        Me.descuento.Size = New System.Drawing.Size(59, 13)
        Me.descuento.TabIndex = 26
        Me.descuento.Text = "Descuento"
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(89, 63)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(100, 20)
        Me.codigo.TabIndex = 27
        '
        'cant
        '
        Me.cant.Location = New System.Drawing.Point(89, 126)
        Me.cant.Name = "cant"
        Me.cant.Size = New System.Drawing.Size(100, 20)
        Me.cant.TabIndex = 28
        '
        'descuent
        '
        Me.descuent.Location = New System.Drawing.Point(89, 158)
        Me.descuent.Name = "descuent"
        Me.descuent.Size = New System.Drawing.Size(100, 20)
        Me.descuent.TabIndex = 29
        '
        'precioov
        '
        Me.precioov.Location = New System.Drawing.Point(89, 190)
        Me.precioov.Name = "precioov"
        Me.precioov.Size = New System.Drawing.Size(100, 20)
        Me.precioov.TabIndex = 30
        '
        'desc
        '
        Me.desc.Location = New System.Drawing.Point(89, 94)
        Me.desc.Name = "desc"
        Me.desc.Size = New System.Drawing.Size(100, 20)
        Me.desc.TabIndex = 31
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(727, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Buscar Productos"
        '
        'borrar
        '
        Me.borrar.Location = New System.Drawing.Point(361, 260)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(83, 36)
        Me.borrar.TabIndex = 33
        Me.borrar.Text = "Borrar Linea "
        Me.borrar.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Descripción"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Descuento (%)"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Precio Unitario"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Precio Total"
        Me.Column6.Name = "Column6"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(223, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 36)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Guardar e Imprimir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'atras
        '
        Me.atras.Location = New System.Drawing.Point(824, 276)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(75, 23)
        Me.atras.TabIndex = 35
        Me.atras.Text = "Atras"
        Me.atras.UseVisualStyleBackColor = True
        '
        'RealizarFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 318)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.borrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.desc)
        Me.Controls.Add(Me.precioov)
        Me.Controls.Add(Me.descuent)
        Me.Controls.Add(Me.cant)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.descuento)
        Me.Controls.Add(Me.preciov)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.cod)
        Me.Controls.Add(Me.limpiarv)
        Me.Controls.Add(Me.agregar)
        Me.Controls.Add(Me.DataGridFacturas)
        Me.Controls.Add(Me.buscarb)
        Me.Name = "RealizarFactura"
        Me.Text = "RealizarFactura"
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents agregar As System.Windows.Forms.Button
    Friend WithEvents limpiarv As System.Windows.Forms.Button
    Friend WithEvents cod As System.Windows.Forms.Label
    Friend WithEvents descripcion As System.Windows.Forms.Label
    Friend WithEvents cantidad As System.Windows.Forms.Label
    Friend WithEvents preciov As System.Windows.Forms.Label
    Friend WithEvents descuento As System.Windows.Forms.Label
    Public WithEvents codigo As System.Windows.Forms.TextBox
    Public WithEvents cant As System.Windows.Forms.TextBox
    Public WithEvents descuent As System.Windows.Forms.TextBox
    Public WithEvents precioov As System.Windows.Forms.TextBox
    Public WithEvents desc As System.Windows.Forms.TextBox
    Friend WithEvents buscarb As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents borrar As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents atras As System.Windows.Forms.Button
End Class
