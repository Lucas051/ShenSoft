<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturasProveedores
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
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtmonto = New System.Windows.Forms.TextBox()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvFacturasProv = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBformadepago = New System.Windows.Forms.ComboBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSuspender = New System.Windows.Forms.Button()
        Me.btnSeleccionarLinea = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNfactura = New System.Windows.Forms.Label()
        Me.btnatras = New System.Windows.Forms.Button()
        CType(Me.dgvFacturasProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(578, 16)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(149, 35)
        Me.btnAgregar.TabIndex = 55
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'txtmonto
        '
        Me.txtmonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmonto.Location = New System.Drawing.Point(412, 24)
        Me.txtmonto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtmonto.Multiline = True
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(129, 23)
        Me.txtmonto.TabIndex = 53
        '
        'txtproveedor
        '
        Me.txtproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproveedor.Location = New System.Drawing.Point(129, 24)
        Me.txtproveedor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtproveedor.Multiline = True
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(129, 23)
        Me.txtproveedor.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(307, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Monto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 24)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 19)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Núm. Proveedor"
        '
        'dgvFacturasProv
        '
        Me.dgvFacturasProv.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvFacturasProv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFacturasProv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFacturasProv.ColumnHeadersHeight = 42
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFacturasProv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFacturasProv.EnableHeadersVisualStyles = False
        Me.dgvFacturasProv.GridColor = System.Drawing.Color.White
        Me.dgvFacturasProv.Location = New System.Drawing.Point(32, 102)
        Me.dgvFacturasProv.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgvFacturasProv.Name = "dgvFacturasProv"
        Me.dgvFacturasProv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvFacturasProv.RowHeadersWidth = 50
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dgvFacturasProv.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFacturasProv.Size = New System.Drawing.Size(788, 410)
        Me.dgvFacturasProv.TabIndex = 56
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(129, 53)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(128, 26)
        Me.btnBuscar.TabIndex = 57
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(307, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 19)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Forma de Pago"
        '
        'CBformadepago
        '
        Me.CBformadepago.FormattingEnabled = True
        Me.CBformadepago.Location = New System.Drawing.Point(412, 59)
        Me.CBformadepago.Name = "CBformadepago"
        Me.CBformadepago.Size = New System.Drawing.Size(129, 21)
        Me.CBformadepago.TabIndex = 60
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(578, 61)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(149, 35)
        Me.btnEditar.TabIndex = 61
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnSuspender
        '
        Me.btnSuspender.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSuspender.FlatAppearance.BorderSize = 0
        Me.btnSuspender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnSuspender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuspender.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuspender.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSuspender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSuspender.Location = New System.Drawing.Point(734, 40)
        Me.btnSuspender.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSuspender.Name = "btnSuspender"
        Me.btnSuspender.Size = New System.Drawing.Size(149, 35)
        Me.btnSuspender.TabIndex = 62
        Me.btnSuspender.Text = "Suspender"
        Me.btnSuspender.UseVisualStyleBackColor = False
        '
        'btnSeleccionarLinea
        '
        Me.btnSeleccionarLinea.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSeleccionarLinea.FlatAppearance.BorderSize = 0
        Me.btnSeleccionarLinea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnSeleccionarLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionarLinea.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarLinea.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSeleccionarLinea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeleccionarLinea.Location = New System.Drawing.Point(643, 518)
        Me.btnSeleccionarLinea.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSeleccionarLinea.Name = "btnSeleccionarLinea"
        Me.btnSeleccionarLinea.Size = New System.Drawing.Size(177, 35)
        Me.btnSeleccionarLinea.TabIndex = 63
        Me.btnSeleccionarLinea.Text = "Seleccionar Línea"
        Me.btnSeleccionarLinea.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(496, 526)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 19)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "(Suspender - Editar)"
        '
        'lblNfactura
        '
        Me.lblNfactura.AutoSize = True
        Me.lblNfactura.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNfactura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lblNfactura.Location = New System.Drawing.Point(28, 57)
        Me.lblNfactura.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNfactura.Name = "lblNfactura"
        Me.lblNfactura.Size = New System.Drawing.Size(17, 19)
        Me.lblNfactura.TabIndex = 65
        Me.lblNfactura.Text = "0"
        Me.lblNfactura.Visible = False
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
        Me.btnatras.Location = New System.Drawing.Point(32, 526)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(118, 32)
        Me.btnatras.TabIndex = 66
        Me.btnatras.Text = "Atrás"
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'FacturasProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(890, 600)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.lblNfactura)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSeleccionarLinea)
        Me.Controls.Add(Me.btnSuspender)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.CBformadepago)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.dgvFacturasProv)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtmonto)
        Me.Controls.Add(Me.txtproveedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FacturasProveedores"
        Me.Text = "FacturasProveedores"
        CType(Me.dgvFacturasProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents txtproveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvFacturasProv As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBformadepago As System.Windows.Forms.ComboBox
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnSuspender As System.Windows.Forms.Button
    Friend WithEvents btnSeleccionarLinea As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblNfactura As System.Windows.Forms.Label
    Friend WithEvents btnatras As System.Windows.Forms.Button
End Class
