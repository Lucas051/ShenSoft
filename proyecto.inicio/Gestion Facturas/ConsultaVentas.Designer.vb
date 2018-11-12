<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaVentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvConsultaFacturas = New System.Windows.Forms.DataGridView()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.cod = New System.Windows.Forms.Label()
        Me.txtposicion = New System.Windows.Forms.TextBox()
        CType(Me.dgvConsultaFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvConsultaFacturas
        '
        Me.dgvConsultaFacturas.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvConsultaFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConsultaFacturas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvConsultaFacturas.ColumnHeadersHeight = 42
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvConsultaFacturas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvConsultaFacturas.EnableHeadersVisualStyles = False
        Me.dgvConsultaFacturas.GridColor = System.Drawing.Color.White
        Me.dgvConsultaFacturas.Location = New System.Drawing.Point(63, 47)
        Me.dgvConsultaFacturas.Name = "dgvConsultaFacturas"
        Me.dgvConsultaFacturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvConsultaFacturas.RowHeadersWidth = 50
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dgvConsultaFacturas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvConsultaFacturas.Size = New System.Drawing.Size(723, 410)
        Me.dgvConsultaFacturas.TabIndex = 36
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnatras.FlatAppearance.BorderSize = 0
        Me.btnatras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnatras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnatras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnatras.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnatras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnatras.Location = New System.Drawing.Point(761, 504)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(118, 32)
        Me.btnatras.TabIndex = 49
        Me.btnatras.Text = "Atrás"
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'btnAnular
        '
        Me.btnAnular.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAnular.FlatAppearance.BorderSize = 0
        Me.btnAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnular.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnular.Location = New System.Drawing.Point(337, 523)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(169, 32)
        Me.btnAnular.TabIndex = 50
        Me.btnAnular.Text = "Anular "
        Me.btnAnular.UseVisualStyleBackColor = False
        '
        'btnDetalle
        '
        Me.btnDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDetalle.FlatAppearance.BorderSize = 0
        Me.btnDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetalle.Location = New System.Drawing.Point(337, 477)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(169, 32)
        Me.btnDetalle.TabIndex = 51
        Me.btnDetalle.Text = "Ver Detalle"
        Me.btnDetalle.UseVisualStyleBackColor = False
        '
        'cod
        '
        Me.cod.AutoSize = True
        Me.cod.BackColor = System.Drawing.Color.Transparent
        Me.cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.cod.Location = New System.Drawing.Point(1, 477)
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(164, 20)
        Me.cod.TabIndex = 52
        Me.cod.Text = "Ingrese N° de Factura"
        '
        'txtposicion
        '
        Me.txtposicion.Location = New System.Drawing.Point(171, 477)
        Me.txtposicion.Multiline = True
        Me.txtposicion.Name = "txtposicion"
        Me.txtposicion.Size = New System.Drawing.Size(138, 22)
        Me.txtposicion.TabIndex = 53
        '
        'ConsultaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 561)
        Me.Controls.Add(Me.txtposicion)
        Me.Controls.Add(Me.cod)
        Me.Controls.Add(Me.btnDetalle)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.dgvConsultaFacturas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConsultaVentas"
        Me.Text = "ConsultaVentas"
        CType(Me.dgvConsultaFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvConsultaFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents btnDetalle As System.Windows.Forms.Button
    Friend WithEvents cod As System.Windows.Forms.Label
    Public WithEvents txtposicion As System.Windows.Forms.TextBox
End Class
