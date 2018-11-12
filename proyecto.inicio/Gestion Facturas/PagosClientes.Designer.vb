<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagosClientes
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PagosClientes))
        Me.btnBuscarProv = New System.Windows.Forms.Button()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.dgvclientes = New System.Windows.Forms.DataGridView()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.prdDocumento = New System.Drawing.Printing.PrintDocument()
        Me.ppdvistaprevia = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgvclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscarProv
        '
        Me.btnBuscarProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBuscarProv.FlatAppearance.BorderSize = 0
        Me.btnBuscarProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnBuscarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProv.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBuscarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarProv.Location = New System.Drawing.Point(549, 38)
        Me.btnBuscarProv.Name = "btnBuscarProv"
        Me.btnBuscarProv.Size = New System.Drawing.Size(94, 29)
        Me.btnBuscarProv.TabIndex = 80
        Me.btnBuscarProv.Text = "Buscar"
        Me.btnBuscarProv.UseVisualStyleBackColor = False
        '
        'txtcliente
        '
        Me.txtcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcliente.Location = New System.Drawing.Point(389, 41)
        Me.txtcliente.Multiline = True
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(142, 25)
        Me.txtcliente.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(282, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 22)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "N° Cliente"
        '
        'txtImporte
        '
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(109, 39)
        Me.txtImporte.Multiline = True
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(142, 25)
        Me.txtImporte.TabIndex = 77
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(15, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 22)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Importe"
        '
        'btnPagar
        '
        Me.btnPagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPagar.FlatAppearance.BorderSize = 0
        Me.btnPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagar.Location = New System.Drawing.Point(389, 81)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(142, 34)
        Me.btnPagar.TabIndex = 73
        Me.btnPagar.Text = "Cobrar Pago"
        Me.btnPagar.UseVisualStyleBackColor = False
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
        Me.btnatras.Location = New System.Drawing.Point(690, 525)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(118, 32)
        Me.btnatras.TabIndex = 70
        Me.btnatras.Text = "Atrás"
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'dgvclientes
        '
        Me.dgvclientes.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvclientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvclientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvclientes.ColumnHeadersHeight = 42
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvclientes.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvclientes.EnableHeadersVisualStyles = False
        Me.dgvclientes.GridColor = System.Drawing.Color.White
        Me.dgvclientes.Location = New System.Drawing.Point(25, 134)
        Me.dgvclientes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgvclientes.Name = "dgvclientes"
        Me.dgvclientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvclientes.RowHeadersWidth = 50
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dgvclientes.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvclientes.Size = New System.Drawing.Size(783, 348)
        Me.dgvclientes.TabIndex = 69
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Bahnschrift Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(239, 81)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(144, 34)
        Me.btnImprimir.TabIndex = 81
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'prdDocumento
        '
        '
        'ppdvistaprevia
        '
        Me.ppdvistaprevia.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ppdvistaprevia.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ppdvistaprevia.ClientSize = New System.Drawing.Size(400, 300)
        Me.ppdvistaprevia.Enabled = True
        Me.ppdvistaprevia.Icon = CType(resources.GetObject("ppdvistaprevia.Icon"), System.Drawing.Icon)
        Me.ppdvistaprevia.Name = "ppdvistaprevia"
        Me.ppdvistaprevia.Visible = False
        '
        'PagosClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(891, 582)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnBuscarProv)
        Me.Controls.Add(Me.txtcliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.dgvclientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PagosClientes"
        Me.Text = "PagosClientes"
        CType(Me.dgvclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscarProv As System.Windows.Forms.Button
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents dgvclientes As System.Windows.Forms.DataGridView
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents prdDocumento As System.Drawing.Printing.PrintDocument
    Friend WithEvents ppdvistaprevia As System.Windows.Forms.PrintPreviewDialog
End Class
