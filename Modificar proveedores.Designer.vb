<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proveedores
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
        Me.añadir = New System.Windows.Forms.Button()
        Me.editar = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.proveedor = New System.Windows.Forms.Label()
        Me.telefono = New System.Windows.Forms.Label()
        Me.direccion = New System.Windows.Forms.Label()
        Me.volver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'añadir
        '
        Me.añadir.Location = New System.Drawing.Point(476, 60)
        Me.añadir.Name = "añadir"
        Me.añadir.Size = New System.Drawing.Size(75, 37)
        Me.añadir.TabIndex = 0
        Me.añadir.Text = "Añadir"
        Me.añadir.UseVisualStyleBackColor = True
        '
        'editar
        '
        Me.editar.Location = New System.Drawing.Point(476, 103)
        Me.editar.Name = "editar"
        Me.editar.Size = New System.Drawing.Size(75, 37)
        Me.editar.TabIndex = 1
        Me.editar.Text = "Editar"
        Me.editar.UseVisualStyleBackColor = True
        '
        'limpiar
        '
        Me.limpiar.Location = New System.Drawing.Point(476, 145)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(75, 41)
        Me.limpiar.TabIndex = 2
        Me.limpiar.Text = "Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'guardar
        '
        Me.guardar.Location = New System.Drawing.Point(476, 192)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(75, 41)
        Me.guardar.TabIndex = 3
        Me.guardar.Text = "Guardar"
        Me.guardar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.prov, Me.Column1, Me.column})
        Me.DataGridView1.Location = New System.Drawing.Point(-3, 283)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 182)
        Me.DataGridView1.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(119, 198)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(119, 129)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(119, 60)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 7
        '
        'proveedor
        '
        Me.proveedor.AutoSize = True
        Me.proveedor.Location = New System.Drawing.Point(51, 60)
        Me.proveedor.Name = "proveedor"
        Me.proveedor.Size = New System.Drawing.Size(56, 13)
        Me.proveedor.TabIndex = 10
        Me.proveedor.Text = "Proveedor"
        '
        'telefono
        '
        Me.telefono.AutoSize = True
        Me.telefono.Location = New System.Drawing.Point(51, 129)
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(49, 13)
        Me.telefono.TabIndex = 11
        Me.telefono.Text = "Teléfono"
        '
        'direccion
        '
        Me.direccion.AutoSize = True
        Me.direccion.Location = New System.Drawing.Point(51, 198)
        Me.direccion.Name = "direccion"
        Me.direccion.Size = New System.Drawing.Size(52, 13)
        Me.direccion.TabIndex = 12
        Me.direccion.Text = "Dirección"
        '
        'volver
        '
        Me.volver.Location = New System.Drawing.Point(569, 145)
        Me.volver.Name = "volver"
        Me.volver.Size = New System.Drawing.Size(60, 88)
        Me.volver.TabIndex = 14
        Me.volver.Text = "Volver"
        Me.volver.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.proyecto.inicio.My.Resources.Resources.logoencamino1
        Me.PictureBox1.Location = New System.Drawing.Point(160, -44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(344, 321)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'no
        '
        Me.no.HeaderText = "ID"
        Me.no.Name = "no"
        '
        'prov
        '
        Me.prov.HeaderText = "Provedor"
        Me.prov.Name = "prov"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Teléfono"
        Me.Column1.Name = "Column1"
        '
        'column
        '
        Me.column.HeaderText = "Dirección"
        Me.column.Name = "column"
        Me.column.Width = 200
        '
        'proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 467)
        Me.Controls.Add(Me.volver)
        Me.Controls.Add(Me.direccion)
        Me.Controls.Add(Me.telefono)
        Me.Controls.Add(Me.proveedor)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.guardar)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.editar)
        Me.Controls.Add(Me.añadir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "proveedores"
        Me.Text = "proveedores"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents añadir As System.Windows.Forms.Button
    Friend WithEvents editar As System.Windows.Forms.Button
    Friend WithEvents limpiar As System.Windows.Forms.Button
    Friend WithEvents guardar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents proveedor As System.Windows.Forms.Label
    Friend WithEvents telefono As System.Windows.Forms.Label
    Friend WithEvents direccion As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents volver As System.Windows.Forms.Button
    Friend WithEvents no As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prov As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents column As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
