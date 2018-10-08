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
        Me.dgvbuscarStock = New System.Windows.Forms.DataGridView()
        Me.cod = New System.Windows.Forms.Label()
        Me.txtbuscarProductos = New System.Windows.Forms.TextBox()
        Me.btnatrasFacturacion = New System.Windows.Forms.Button()
        CType(Me.dgvbuscarStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvbuscarStock
        '
        Me.dgvbuscarStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbuscarStock.Location = New System.Drawing.Point(20, 84)
        Me.dgvbuscarStock.Name = "dgvbuscarStock"
        Me.dgvbuscarStock.Size = New System.Drawing.Size(667, 198)
        Me.dgvbuscarStock.TabIndex = 33
        '
        'cod
        '
        Me.cod.AutoSize = True
        Me.cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cod.Location = New System.Drawing.Point(17, 52)
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(128, 18)
        Me.cod.TabIndex = 35
        Me.cod.Text = "Buscar Productos"
        '
        'txtbuscarProductos
        '
        Me.txtbuscarProductos.Location = New System.Drawing.Point(151, 48)
        Me.txtbuscarProductos.Multiline = True
        Me.txtbuscarProductos.Name = "txtbuscarProductos"
        Me.txtbuscarProductos.Size = New System.Drawing.Size(123, 22)
        Me.txtbuscarProductos.TabIndex = 36
        '
        'btnatrasFacturacion
        '
        Me.btnatrasFacturacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnatrasFacturacion.FlatAppearance.BorderSize = 0
        Me.btnatrasFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnatrasFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnatrasFacturacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatrasFacturacion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnatrasFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnatrasFacturacion.Location = New System.Drawing.Point(607, 300)
        Me.btnatrasFacturacion.Name = "btnatrasFacturacion"
        Me.btnatrasFacturacion.Size = New System.Drawing.Size(80, 26)
        Me.btnatrasFacturacion.TabIndex = 47
        Me.btnatrasFacturacion.Text = "Atrás"
        Me.btnatrasFacturacion.UseVisualStyleBackColor = False
        '
        'buscarproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(720, 349)
        Me.Controls.Add(Me.btnatrasFacturacion)
        Me.Controls.Add(Me.txtbuscarProductos)
        Me.Controls.Add(Me.cod)
        Me.Controls.Add(Me.dgvbuscarStock)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "buscarproductos"
        Me.Text = "Buscar Productos"
        CType(Me.dgvbuscarStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvbuscarStock As System.Windows.Forms.DataGridView
    Friend WithEvents cod As System.Windows.Forms.Label
    Friend WithEvents txtbuscarProductos As System.Windows.Forms.TextBox
    Friend WithEvents btnatrasFacturacion As System.Windows.Forms.Button
End Class
