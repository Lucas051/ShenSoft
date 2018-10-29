<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionFacturacion
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
        Me.btnConsultaVentas = New System.Windows.Forms.Button()
        Me.btnFactProv = New System.Windows.Forms.Button()
        Me.btnPagosClie = New System.Windows.Forms.Button()
        Me.btnPagosProv = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConsultaVentas
        '
        Me.btnConsultaVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnConsultaVentas.FlatAppearance.BorderSize = 2
        Me.btnConsultaVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnConsultaVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultaVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultaVentas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnConsultaVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultaVentas.Location = New System.Drawing.Point(133, 111)
        Me.btnConsultaVentas.Name = "btnConsultaVentas"
        Me.btnConsultaVentas.Size = New System.Drawing.Size(276, 42)
        Me.btnConsultaVentas.TabIndex = 44
        Me.btnConsultaVentas.Text = "Consulta Facturación Ventas"
        Me.btnConsultaVentas.UseVisualStyleBackColor = False
        '
        'btnFactProv
        '
        Me.btnFactProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnFactProv.FlatAppearance.BorderSize = 2
        Me.btnFactProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnFactProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFactProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFactProv.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnFactProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFactProv.Location = New System.Drawing.Point(133, 196)
        Me.btnFactProv.Name = "btnFactProv"
        Me.btnFactProv.Size = New System.Drawing.Size(276, 42)
        Me.btnFactProv.TabIndex = 45
        Me.btnFactProv.Text = "Facturas Proveedores"
        Me.btnFactProv.UseVisualStyleBackColor = False
        '
        'btnPagosClie
        '
        Me.btnPagosClie.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPagosClie.FlatAppearance.BorderSize = 2
        Me.btnPagosClie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnPagosClie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagosClie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagosClie.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPagosClie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagosClie.Location = New System.Drawing.Point(133, 379)
        Me.btnPagosClie.Name = "btnPagosClie"
        Me.btnPagosClie.Size = New System.Drawing.Size(276, 42)
        Me.btnPagosClie.TabIndex = 46
        Me.btnPagosClie.Text = "Pagos de Clientes"
        Me.btnPagosClie.UseVisualStyleBackColor = False
        '
        'btnPagosProv
        '
        Me.btnPagosProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPagosProv.FlatAppearance.BorderSize = 2
        Me.btnPagosProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnPagosProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagosProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagosProv.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnPagosProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPagosProv.Location = New System.Drawing.Point(133, 288)
        Me.btnPagosProv.Name = "btnPagosProv"
        Me.btnPagosProv.Size = New System.Drawing.Size(276, 42)
        Me.btnPagosProv.TabIndex = 47
        Me.btnPagosProv.Text = "Pagos a Proveedores"
        Me.btnPagosProv.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.proyecto.inicio.My.Resources.Resources.logoencamino1
        Me.PictureBox1.Location = New System.Drawing.Point(382, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(555, 425)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'GestionFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(897, 564)
        Me.Controls.Add(Me.btnPagosProv)
        Me.Controls.Add(Me.btnPagosClie)
        Me.Controls.Add(Me.btnFactProv)
        Me.Controls.Add(Me.btnConsultaVentas)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionFacturacion"
        Me.Text = "ConsultaFactura"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConsultaVentas As System.Windows.Forms.Button
    Friend WithEvents btnFactProv As System.Windows.Forms.Button
    Friend WithEvents btnPagosClie As System.Windows.Forms.Button
    Friend WithEvents btnPagosProv As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
