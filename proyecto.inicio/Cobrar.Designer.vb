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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.barratitulo = New System.Windows.Forms.Panel()
        Me.btnmini = New System.Windows.Forms.PictureBox()
        Me.cod = New System.Windows.Forms.Label()
        Me.txtclientes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.buscarClientebtn = New System.Windows.Forms.Button()
        Me.txtvendedor = New System.Windows.Forms.TextBox()
        Me.txtpagocon = New System.Windows.Forms.TextBox()
        Me.atrasbtn = New System.Windows.Forms.Button()
        Me.btncobrar = New System.Windows.Forms.Button()
        Me.lblTotalPagar = New System.Windows.Forms.Label()
        Me.lblDevolver = New System.Windows.Forms.Label()
        Me.lblVendedor = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barratitulo.SuspendLayout()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'txtclientes
        '
        Me.txtclientes.Location = New System.Drawing.Point(132, 288)
        Me.txtclientes.Multiline = True
        Me.txtclientes.Name = "txtclientes"
        Me.txtclientes.Size = New System.Drawing.Size(121, 26)
        Me.txtclientes.TabIndex = 40
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
        Me.buscarClientebtn.Size = New System.Drawing.Size(113, 26)
        Me.buscarClientebtn.TabIndex = 47
        Me.buscarClientebtn.Text = "Buscar Cliente"
        Me.buscarClientebtn.UseVisualStyleBackColor = False
        '
        'txtvendedor
        '
        Me.txtvendedor.Location = New System.Drawing.Point(132, 228)
        Me.txtvendedor.Multiline = True
        Me.txtvendedor.Name = "txtvendedor"
        Me.txtvendedor.Size = New System.Drawing.Size(121, 26)
        Me.txtvendedor.TabIndex = 48
        '
        'txtpagocon
        '
        Me.txtpagocon.Location = New System.Drawing.Point(132, 403)
        Me.txtpagocon.Multiline = True
        Me.txtpagocon.Name = "txtpagocon"
        Me.txtpagocon.Size = New System.Drawing.Size(121, 26)
        Me.txtpagocon.TabIndex = 50
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
        Me.lblTotalPagar.Location = New System.Drawing.Point(138, 348)
        Me.lblTotalPagar.Name = "lblTotalPagar"
        Me.lblTotalPagar.Size = New System.Drawing.Size(96, 18)
        Me.lblTotalPagar.TabIndex = 54
        Me.lblTotalPagar.Text = "Total a Pagar"
        '
        'lblDevolver
        '
        Me.lblDevolver.AutoSize = True
        Me.lblDevolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevolver.Location = New System.Drawing.Point(138, 466)
        Me.lblDevolver.Name = "lblDevolver"
        Me.lblDevolver.Size = New System.Drawing.Size(126, 18)
        Me.lblDevolver.TabIndex = 55
        Me.lblDevolver.Text = "Dinero a Devolver"
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendedor.Location = New System.Drawing.Point(263, 232)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(71, 18)
        Me.lblVendedor.TabIndex = 56
        Me.lblVendedor.Text = "Vendedor"
        '
        'Cobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(466, 599)
        Me.Controls.Add(Me.lblVendedor)
        Me.Controls.Add(Me.lblDevolver)
        Me.Controls.Add(Me.lblTotalPagar)
        Me.Controls.Add(Me.btncobrar)
        Me.Controls.Add(Me.atrasbtn)
        Me.Controls.Add(Me.txtpagocon)
        Me.Controls.Add(Me.txtvendedor)
        Me.Controls.Add(Me.buscarClientebtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtclientes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cod)
        Me.Controls.Add(Me.barratitulo)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cobrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cobrar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barratitulo.ResumeLayout(False)
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents barratitulo As System.Windows.Forms.Panel
    Friend WithEvents btnmini As System.Windows.Forms.PictureBox
    Friend WithEvents cod As System.Windows.Forms.Label
    Public WithEvents txtclientes As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents buscarClientebtn As System.Windows.Forms.Button
    Public WithEvents txtvendedor As System.Windows.Forms.TextBox
    Public WithEvents txtpagocon As System.Windows.Forms.TextBox
    Friend WithEvents atrasbtn As System.Windows.Forms.Button
    Friend WithEvents btncobrar As System.Windows.Forms.Button
    Friend WithEvents lblTotalPagar As System.Windows.Forms.Label
    Friend WithEvents lblDevolver As System.Windows.Forms.Label
    Friend WithEvents lblVendedor As System.Windows.Forms.Label
End Class
