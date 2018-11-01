<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cobrar
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
        Me.barratitulo = New System.Windows.Forms.Panel()
        Me.btnmini = New System.Windows.Forms.PictureBox()
        Me.cod = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.buscarClientebtn = New System.Windows.Forms.Button()
        Me.atrasbtn = New System.Windows.Forms.Button()
        Me.btncobrar = New System.Windows.Forms.Button()
        Me.lblTotalPagar = New System.Windows.Forms.Label()
        Me.lblDevolver = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtvendedor = New System.Windows.Forms.TextBox()
        Me.txtclientes = New System.Windows.Forms.TextBox()
        Me.txtpagocon = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CBformadepago = New System.Windows.Forms.ComboBox()
        Me.lblnumCliente = New System.Windows.Forms.Label()
        Me.lblNumVendedor = New System.Windows.Forms.Label()
        Me.barratitulo.SuspendLayout()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barratitulo
        '
        Me.barratitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.barratitulo.Controls.Add(Me.btnmini)
        Me.barratitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.barratitulo.Location = New System.Drawing.Point(0, 0)
        Me.barratitulo.Name = "barratitulo"
        Me.barratitulo.Size = New System.Drawing.Size(466, 35)
        Me.barratitulo.TabIndex = 36
        '
        'btnmini
        '
        Me.btnmini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmini.Image = Global.proyecto.inicio.My.Resources.Resources.minimazar
        Me.btnmini.Location = New System.Drawing.Point(426, 5)
        Me.btnmini.Name = "btnmini"
        Me.btnmini.Size = New System.Drawing.Size(25, 25)
        Me.btnmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmini.TabIndex = 1
        Me.btnmini.TabStop = False
        '
        'cod
        '
        Me.cod.AutoSize = True
        Me.cod.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod.ForeColor = System.Drawing.Color.White
        Me.cod.Location = New System.Drawing.Point(59, 228)
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(70, 18)
        Me.cod.TabIndex = 37
        Me.cod.Text = "Vendedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(75, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 18)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(36, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 18)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Total a Pagar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(59, 403)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 18)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Pagó con"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(58, 466)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 18)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Devolver"
        '
        'buscarClientebtn
        '
        Me.buscarClientebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.buscarClientebtn.FlatAppearance.BorderSize = 0
        Me.buscarClientebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.buscarClientebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscarClientebtn.Font = New System.Drawing.Font("Bahnschrift Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscarClientebtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.buscarClientebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buscarClientebtn.Location = New System.Drawing.Point(266, 288)
        Me.buscarClientebtn.Name = "buscarClientebtn"
        Me.buscarClientebtn.Size = New System.Drawing.Size(133, 26)
        Me.buscarClientebtn.TabIndex = 47
        Me.buscarClientebtn.Text = "Buscar Cliente"
        Me.buscarClientebtn.UseVisualStyleBackColor = False
        '
        'atrasbtn
        '
        Me.atrasbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.atrasbtn.FlatAppearance.BorderSize = 0
        Me.atrasbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.atrasbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.atrasbtn.Font = New System.Drawing.Font("Bahnschrift Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atrasbtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.atrasbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.atrasbtn.Location = New System.Drawing.Point(371, 561)
        Me.atrasbtn.Name = "atrasbtn"
        Me.atrasbtn.Size = New System.Drawing.Size(80, 26)
        Me.atrasbtn.TabIndex = 52
        Me.atrasbtn.Text = "Atrás"
        Me.atrasbtn.UseVisualStyleBackColor = False
        '
        'btncobrar
        '
        Me.btncobrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btncobrar.FlatAppearance.BorderSize = 0
        Me.btncobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btncobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncobrar.Font = New System.Drawing.Font("Bahnschrift Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncobrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btncobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btncobrar.Location = New System.Drawing.Point(68, 526)
        Me.btncobrar.Name = "btncobrar"
        Me.btncobrar.Size = New System.Drawing.Size(196, 26)
        Me.btncobrar.TabIndex = 53
        Me.btncobrar.Text = "Cobrar Monto e Imprimir"
        Me.btncobrar.UseVisualStyleBackColor = False
        '
        'lblTotalPagar
        '
        Me.lblTotalPagar.AutoSize = True
        Me.lblTotalPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPagar.ForeColor = System.Drawing.Color.White
        Me.lblTotalPagar.Location = New System.Drawing.Point(138, 348)
        Me.lblTotalPagar.Name = "lblTotalPagar"
        Me.lblTotalPagar.Size = New System.Drawing.Size(96, 18)
        Me.lblTotalPagar.TabIndex = 54
        Me.lblTotalPagar.Text = "Total a Pagar"
        '
        'lblDevolver
        '
        Me.lblDevolver.AutoSize = True
        Me.lblDevolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevolver.ForeColor = System.Drawing.Color.White
        Me.lblDevolver.Location = New System.Drawing.Point(138, 466)
        Me.lblDevolver.Name = "lblDevolver"
        Me.lblDevolver.Size = New System.Drawing.Size(17, 18)
        Me.lblDevolver.TabIndex = 55
        Me.lblDevolver.Text = "0"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(266, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 26)
        Me.Button1.TabIndex = 57
        Me.Button1.Text = "Buscar Vendedor"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtvendedor
        '
        Me.txtvendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvendedor.Location = New System.Drawing.Point(131, 227)
        Me.txtvendedor.Multiline = True
        Me.txtvendedor.Name = "txtvendedor"
        Me.txtvendedor.Size = New System.Drawing.Size(129, 23)
        Me.txtvendedor.TabIndex = 58
        '
        'txtclientes
        '
        Me.txtclientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclientes.Location = New System.Drawing.Point(131, 288)
        Me.txtclientes.Multiline = True
        Me.txtclientes.Name = "txtclientes"
        Me.txtclientes.Size = New System.Drawing.Size(129, 23)
        Me.txtclientes.TabIndex = 59
        '
        'txtpagocon
        '
        Me.txtpagocon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpagocon.Location = New System.Drawing.Point(131, 402)
        Me.txtpagocon.Multiline = True
        Me.txtpagocon.Name = "txtpagocon"
        Me.txtpagocon.Size = New System.Drawing.Size(129, 23)
        Me.txtpagocon.TabIndex = 60
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.proyecto.inicio.My.Resources.Resources.logoencamino1
        Me.PictureBox1.Location = New System.Drawing.Point(15, -16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(375, 238)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'CBformadepago
        '
        Me.CBformadepago.FormattingEnabled = True
        Me.CBformadepago.Location = New System.Drawing.Point(276, 403)
        Me.CBformadepago.Name = "CBformadepago"
        Me.CBformadepago.Size = New System.Drawing.Size(148, 21)
        Me.CBformadepago.TabIndex = 61
        '
        'lblnumCliente
        '
        Me.lblnumCliente.AutoSize = True
        Me.lblnumCliente.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumCliente.ForeColor = System.Drawing.Color.White
        Me.lblnumCliente.Location = New System.Drawing.Point(94, 308)
        Me.lblnumCliente.Name = "lblnumCliente"
        Me.lblnumCliente.Size = New System.Drawing.Size(16, 18)
        Me.lblnumCliente.TabIndex = 62
        Me.lblnumCliente.Text = "0"
        Me.lblnumCliente.Visible = False
        '
        'lblNumVendedor
        '
        Me.lblNumVendedor.AutoSize = True
        Me.lblNumVendedor.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumVendedor.ForeColor = System.Drawing.Color.White
        Me.lblNumVendedor.Location = New System.Drawing.Point(94, 256)
        Me.lblNumVendedor.Name = "lblNumVendedor"
        Me.lblNumVendedor.Size = New System.Drawing.Size(16, 18)
        Me.lblNumVendedor.TabIndex = 63
        Me.lblNumVendedor.Text = "0"
        Me.lblNumVendedor.Visible = False
        '
        'Cobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(466, 599)
        Me.Controls.Add(Me.lblNumVendedor)
        Me.Controls.Add(Me.lblnumCliente)
        Me.Controls.Add(Me.CBformadepago)
        Me.Controls.Add(Me.txtpagocon)
        Me.Controls.Add(Me.txtclientes)
        Me.Controls.Add(Me.txtvendedor)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblDevolver)
        Me.Controls.Add(Me.lblTotalPagar)
        Me.Controls.Add(Me.btncobrar)
        Me.Controls.Add(Me.atrasbtn)
        Me.Controls.Add(Me.buscarClientebtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cod)
        Me.Controls.Add(Me.barratitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cobrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cobrar"
        Me.barratitulo.ResumeLayout(False)
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents barratitulo As System.Windows.Forms.Panel
    Friend WithEvents btnmini As System.Windows.Forms.PictureBox
    Friend WithEvents cod As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents buscarClientebtn As System.Windows.Forms.Button
    Friend WithEvents atrasbtn As System.Windows.Forms.Button
    Friend WithEvents btncobrar As System.Windows.Forms.Button
    Friend WithEvents lblTotalPagar As System.Windows.Forms.Label
    Friend WithEvents lblDevolver As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtvendedor As System.Windows.Forms.TextBox
    Friend WithEvents txtclientes As System.Windows.Forms.TextBox
    Friend WithEvents txtpagocon As System.Windows.Forms.TextBox
    Friend WithEvents CBformadepago As System.Windows.Forms.ComboBox
    Friend WithEvents lblnumCliente As System.Windows.Forms.Label
    Friend WithEvents lblNumVendedor As System.Windows.Forms.Label
End Class
