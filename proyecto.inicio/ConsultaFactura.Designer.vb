<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaFactura
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
        Me.lblbuscar = New System.Windows.Forms.Label()
        Me.txtbuscarfacturas = New System.Windows.Forms.TextBox()
        Me.dgvConsultaFacturas = New System.Windows.Forms.DataGridView()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.btnAnularFactura = New System.Windows.Forms.Button()
        CType(Me.dgvConsultaFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblbuscar
        '
        Me.lblbuscar.AutoSize = True
        Me.lblbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbuscar.Location = New System.Drawing.Point(13, 22)
        Me.lblbuscar.Name = "lblbuscar"
        Me.lblbuscar.Size = New System.Drawing.Size(56, 17)
        Me.lblbuscar.TabIndex = 0
        Me.lblbuscar.Text = "Buscar:"
        '
        'txtbuscarfacturas
        '
        Me.txtbuscarfacturas.Location = New System.Drawing.Point(75, 22)
        Me.txtbuscarfacturas.Name = "txtbuscarfacturas"
        Me.txtbuscarfacturas.Size = New System.Drawing.Size(100, 20)
        Me.txtbuscarfacturas.TabIndex = 1
        '
        'dgvConsultaFacturas
        '
        Me.dgvConsultaFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaFacturas.Location = New System.Drawing.Point(12, 60)
        Me.dgvConsultaFacturas.Name = "dgvConsultaFacturas"
        Me.dgvConsultaFacturas.Size = New System.Drawing.Size(850, 372)
        Me.dgvConsultaFacturas.TabIndex = 2
        '
        'btnDetalle
        '
        Me.btnDetalle.Location = New System.Drawing.Point(16, 457)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(181, 29)
        Me.btnDetalle.TabIndex = 3
        Me.btnDetalle.Text = "Detalle de Factura"
        Me.btnDetalle.UseVisualStyleBackColor = True
        '
        'btnAnularFactura
        '
        Me.btnAnularFactura.Location = New System.Drawing.Point(223, 457)
        Me.btnAnularFactura.Name = "btnAnularFactura"
        Me.btnAnularFactura.Size = New System.Drawing.Size(170, 29)
        Me.btnAnularFactura.TabIndex = 4
        Me.btnAnularFactura.Text = "Anular"
        Me.btnAnularFactura.UseVisualStyleBackColor = True
        '
        'ConsultaFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 564)
        Me.Controls.Add(Me.btnAnularFactura)
        Me.Controls.Add(Me.btnDetalle)
        Me.Controls.Add(Me.dgvConsultaFacturas)
        Me.Controls.Add(Me.txtbuscarfacturas)
        Me.Controls.Add(Me.lblbuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConsultaFactura"
        Me.Text = "ConsultaFactura"
        CType(Me.dgvConsultaFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblbuscar As System.Windows.Forms.Label
    Friend WithEvents txtbuscarfacturas As System.Windows.Forms.TextBox
    Friend WithEvents dgvConsultaFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents btnDetalle As System.Windows.Forms.Button
    Friend WithEvents btnAnularFactura As System.Windows.Forms.Button
End Class
