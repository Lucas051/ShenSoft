<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarClientesCobrar
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
        Me.DGVbuscarclientes = New System.Windows.Forms.DataGridView()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.btnbuscarf = New System.Windows.Forms.TextBox()
        Me.cod = New System.Windows.Forms.Label()
        CType(Me.DGVbuscarclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVbuscarclientes
        '
        Me.DGVbuscarclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVbuscarclientes.Location = New System.Drawing.Point(46, 88)
        Me.DGVbuscarclientes.Name = "DGVbuscarclientes"
        Me.DGVbuscarclientes.Size = New System.Drawing.Size(682, 241)
        Me.DGVbuscarclientes.TabIndex = 36
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnatras.FlatAppearance.BorderSize = 0
        Me.btnatras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnatras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnatras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnatras.Location = New System.Drawing.Point(648, 358)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(80, 26)
        Me.btnatras.TabIndex = 48
        Me.btnatras.Text = "Atrás"
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'btnbuscarf
        '
        Me.btnbuscarf.Location = New System.Drawing.Point(157, 60)
        Me.btnbuscarf.Multiline = True
        Me.btnbuscarf.Name = "btnbuscarf"
        Me.btnbuscarf.Size = New System.Drawing.Size(107, 22)
        Me.btnbuscarf.TabIndex = 50
        '
        'cod
        '
        Me.cod.AutoSize = True
        Me.cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cod.Location = New System.Drawing.Point(42, 60)
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(109, 18)
        Me.cod.TabIndex = 49
        Me.cod.Text = "Buscar Factura"
        '
        'BuscarClientesCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 396)
        Me.Controls.Add(Me.btnbuscarf)
        Me.Controls.Add(Me.cod)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.DGVbuscarclientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BuscarClientesCobrar"
        Me.Text = "BuscarClientesCobrar"
        CType(Me.DGVbuscarclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVbuscarclientes As System.Windows.Forms.DataGridView
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents btnbuscarf As System.Windows.Forms.TextBox
    Friend WithEvents cod As System.Windows.Forms.Label
End Class
