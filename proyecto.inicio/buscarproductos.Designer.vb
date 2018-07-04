<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buscarproductos
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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        Me.DataGridbuscar = New System.Windows.Forms.DataGridView()
        Me.atras = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridbuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridbuscar
        '
        Me.DataGridbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridbuscar.Location = New System.Drawing.Point(9, 26)
        Me.DataGridbuscar.Name = "DataGridbuscar"
        Me.DataGridbuscar.Size = New System.Drawing.Size(630, 211)
        Me.DataGridbuscar.TabIndex = 33
        '
        'atras
        '
        Me.atras.Location = New System.Drawing.Point(579, 258)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(75, 23)
        Me.atras.TabIndex = 34
        Me.atras.Text = "Volver"
        Me.atras.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(188, 288)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 35
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'buscarproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 335)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.DataGridbuscar)
        Me.Name = "buscarproductos"
        Me.Text = "Buscar Productos"
        CType(Me.DataGridbuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridbuscar As System.Windows.Forms.DataGridView
    Friend WithEvents atras As System.Windows.Forms.Button
=======
        Me.DataGridbuscar = New System.Windows.Forms.DataGridView()
        Me.atras = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridbuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridbuscar
        '
        Me.DataGridbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridbuscar.Location = New System.Drawing.Point(9, 26)
        Me.DataGridbuscar.Name = "DataGridbuscar"
        Me.DataGridbuscar.Size = New System.Drawing.Size(630, 211)
        Me.DataGridbuscar.TabIndex = 33
        '
        'atras
        '
        Me.atras.Location = New System.Drawing.Point(579, 258)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(75, 23)
        Me.atras.TabIndex = 34
        Me.atras.Text = "Volver"
        Me.atras.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(188, 288)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 35
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'buscarproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 335)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.DataGridbuscar)
        Me.Name = "buscarproductos"
        Me.Text = "Buscar Productos"
        CType(Me.DataGridbuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridbuscar As System.Windows.Forms.DataGridView
    Friend WithEvents atras As System.Windows.Forms.Button
>>>>>>> b9ac1fc0ad416c297c35c829e7c17ad9a49cbaf6
=======
        Me.DataGridbuscar = New System.Windows.Forms.DataGridView()
        Me.atras = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridbuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridbuscar
        '
        Me.DataGridbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridbuscar.Location = New System.Drawing.Point(9, 26)
        Me.DataGridbuscar.Name = "DataGridbuscar"
        Me.DataGridbuscar.Size = New System.Drawing.Size(630, 211)
        Me.DataGridbuscar.TabIndex = 33
        '
        'atras
        '
        Me.atras.Location = New System.Drawing.Point(579, 258)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(75, 23)
        Me.atras.TabIndex = 34
        Me.atras.Text = "Volver"
        Me.atras.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(188, 288)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 35
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'buscarproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 335)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.DataGridbuscar)
        Me.Name = "buscarproductos"
        Me.Text = "Buscar Productos"
        CType(Me.DataGridbuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridbuscar As System.Windows.Forms.DataGridView
    Friend WithEvents atras As System.Windows.Forms.Button
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
=======
        Me.DataGridbuscar = New System.Windows.Forms.DataGridView()
        Me.atras = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridbuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridbuscar
        '
        Me.DataGridbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridbuscar.Location = New System.Drawing.Point(9, 26)
        Me.DataGridbuscar.Name = "DataGridbuscar"
        Me.DataGridbuscar.Size = New System.Drawing.Size(630, 211)
        Me.DataGridbuscar.TabIndex = 33
        '
        'atras
        '
        Me.atras.Location = New System.Drawing.Point(579, 258)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(75, 23)
        Me.atras.TabIndex = 34
        Me.atras.Text = "Volver"
        Me.atras.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(188, 288)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 35
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'buscarproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 335)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.DataGridbuscar)
        Me.Name = "buscarproductos"
        Me.Text = "Buscar Productos"
        CType(Me.DataGridbuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridbuscar As System.Windows.Forms.DataGridView
    Friend WithEvents atras As System.Windows.Forms.Button
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
