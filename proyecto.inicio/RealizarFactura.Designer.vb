<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealizarFactura
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
        Me.DataGridFacturas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod = New System.Windows.Forms.Label()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.cant = New System.Windows.Forms.TextBox()
        Me.descuent = New System.Windows.Forms.TextBox()
        Me.precioov = New System.Windows.Forms.TextBox()
        Me.desc = New System.Windows.Forms.TextBox()
        Me.btnmini = New System.Windows.Forms.PictureBox()
        Me.barratitulo = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cerrarbtn = New System.Windows.Forms.PictureBox()
        Me.btnmaxi = New System.Windows.Forms.PictureBox()
        Me.btnrestaurar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.agregar = New System.Windows.Forms.Button()
        Me.limpiarv = New System.Windows.Forms.Button()
        Me.guardarImprimir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.atras = New System.Windows.Forms.Button()
        Me.buscarb = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barratitulo.SuspendLayout()
        CType(Me.cerrarbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmaxi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridFacturas
        '
        Me.DataGridFacturas.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridFacturas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridFacturas.EnableHeadersVisualStyles = False
        Me.DataGridFacturas.GridColor = System.Drawing.Color.SteelBlue
        Me.DataGridFacturas.Location = New System.Drawing.Point(238, 86)
        Me.DataGridFacturas.Name = "DataGridFacturas"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridFacturas.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridFacturas.Size = New System.Drawing.Size(744, 285)
        Me.DataGridFacturas.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Descripción"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Descuento (%)"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Precio Unitario"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Precio Total"
        Me.Column6.Name = "Column6"
        '
        'cod
        '
        Me.cod.AutoSize = True
        Me.cod.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.cod.Location = New System.Drawing.Point(48, 85)
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(53, 18)
        Me.cod.TabIndex = 22
        Me.cod.Text = "Código"
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(112, 86)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(100, 20)
        Me.codigo.TabIndex = 27
        '
        'cant
        '
        Me.cant.Location = New System.Drawing.Point(112, 149)
        Me.cant.Name = "cant"
        Me.cant.Size = New System.Drawing.Size(100, 20)
        Me.cant.TabIndex = 28
        '
        'descuent
        '
        Me.descuent.Location = New System.Drawing.Point(112, 181)
        Me.descuent.Name = "descuent"
        Me.descuent.Size = New System.Drawing.Size(100, 20)
        Me.descuent.TabIndex = 29
        '
        'precioov
        '
        Me.precioov.Location = New System.Drawing.Point(112, 213)
        Me.precioov.Name = "precioov"
        Me.precioov.Size = New System.Drawing.Size(100, 20)
        Me.precioov.TabIndex = 30
        '
        'desc
        '
        Me.desc.Location = New System.Drawing.Point(112, 117)
        Me.desc.Name = "desc"
        Me.desc.Size = New System.Drawing.Size(100, 20)
        Me.desc.TabIndex = 31
        '
        'btnmini
        '
        Me.btnmini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmini.Image = Global.proyecto.inicio.My.Resources.Resources.minimazar
        Me.btnmini.Location = New System.Drawing.Point(956, 5)
        Me.btnmini.Name = "btnmini"
        Me.btnmini.Size = New System.Drawing.Size(25, 25)
        Me.btnmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmini.TabIndex = 1
        Me.btnmini.TabStop = False
        '
        'barratitulo
        '
        Me.barratitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.barratitulo.Controls.Add(Me.Label4)
        Me.barratitulo.Controls.Add(Me.btnmini)
        Me.barratitulo.Controls.Add(Me.cerrarbtn)
        Me.barratitulo.Controls.Add(Me.btnmaxi)
        Me.barratitulo.Controls.Add(Me.btnrestaurar)
        Me.barratitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.barratitulo.Location = New System.Drawing.Point(0, 0)
        Me.barratitulo.Name = "barratitulo"
        Me.barratitulo.Size = New System.Drawing.Size(1049, 35)
        Me.barratitulo.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(10, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 19)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "La Pollería - Realizar Factura"
        '
        'cerrarbtn
        '
        Me.cerrarbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrarbtn.Image = Global.proyecto.inicio.My.Resources.Resources.cerrar
        Me.cerrarbtn.Location = New System.Drawing.Point(1018, 5)
        Me.cerrarbtn.Name = "cerrarbtn"
        Me.cerrarbtn.Size = New System.Drawing.Size(25, 25)
        Me.cerrarbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cerrarbtn.TabIndex = 0
        Me.cerrarbtn.TabStop = False
        '
        'btnmaxi
        '
        Me.btnmaxi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmaxi.Image = Global.proyecto.inicio.My.Resources.Resources.maxi
        Me.btnmaxi.Location = New System.Drawing.Point(987, 5)
        Me.btnmaxi.Name = "btnmaxi"
        Me.btnmaxi.Size = New System.Drawing.Size(25, 25)
        Me.btnmaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmaxi.TabIndex = 2
        Me.btnmaxi.TabStop = False
        '
        'btnrestaurar
        '
        Me.btnrestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnrestaurar.Image = Global.proyecto.inicio.My.Resources.Resources.res
        Me.btnrestaurar.Location = New System.Drawing.Point(987, 5)
        Me.btnrestaurar.Name = "btnrestaurar"
        Me.btnrestaurar.Size = New System.Drawing.Size(25, 25)
        Me.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnrestaurar.TabIndex = 3
        Me.btnrestaurar.TabStop = False
        Me.btnrestaurar.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 18)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Descripción"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(35, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(24, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Descuento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(10, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 18)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Precio Venta"
        '
        'agregar
        '
        Me.agregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.agregar.FlatAppearance.BorderSize = 0
        Me.agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agregar.Font = New System.Drawing.Font("Bahnschrift Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.agregar.Location = New System.Drawing.Point(132, 252)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(80, 26)
        Me.agregar.TabIndex = 42
        Me.agregar.Text = "Agregar"
        Me.agregar.UseVisualStyleBackColor = False
        '
        'limpiarv
        '
        Me.limpiarv.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.limpiarv.FlatAppearance.BorderSize = 0
        Me.limpiarv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.limpiarv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.limpiarv.Font = New System.Drawing.Font("Bahnschrift Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpiarv.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.limpiarv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.limpiarv.Location = New System.Drawing.Point(38, 252)
        Me.limpiarv.Name = "limpiarv"
        Me.limpiarv.Size = New System.Drawing.Size(80, 26)
        Me.limpiarv.TabIndex = 43
        Me.limpiarv.Text = "Limpiar Campos"
        Me.limpiarv.UseVisualStyleBackColor = False
        '
        'guardarImprimir
        '
        Me.guardarImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.guardarImprimir.FlatAppearance.BorderSize = 0
        Me.guardarImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.guardarImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.guardarImprimir.Font = New System.Drawing.Font("Bahnschrift Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardarImprimir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.guardarImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.guardarImprimir.Location = New System.Drawing.Point(248, 429)
        Me.guardarImprimir.Name = "guardarImprimir"
        Me.guardarImprimir.Size = New System.Drawing.Size(145, 26)
        Me.guardarImprimir.TabIndex = 44
        Me.guardarImprimir.Text = "Guardar e Imprimir"
        Me.guardarImprimir.UseVisualStyleBackColor = False
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
        Me.Button1.Location = New System.Drawing.Point(409, 429)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 26)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Borrar Línea"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'atras
        '
        Me.atras.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.atras.FlatAppearance.BorderSize = 0
        Me.atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.atras.Font = New System.Drawing.Font("Bahnschrift Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atras.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.atras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.atras.Location = New System.Drawing.Point(827, 445)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(80, 26)
        Me.atras.TabIndex = 46
        Me.atras.Text = "Atrás"
        Me.atras.UseVisualStyleBackColor = False
        '
        'buscarb
        '
        Me.buscarb.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.buscarb.FlatAppearance.BorderSize = 0
        Me.buscarb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.buscarb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscarb.Font = New System.Drawing.Font("Bahnschrift Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscarb.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.buscarb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buscarb.Location = New System.Drawing.Point(811, 53)
        Me.buscarb.Name = "buscarb"
        Me.buscarb.Size = New System.Drawing.Size(79, 26)
        Me.buscarb.TabIndex = 47
        Me.buscarb.Text = "Buscar"
        Me.buscarb.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(682, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 18)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Buscar Productos"
        '
        'RealizarFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1049, 528)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.buscarb)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.guardarImprimir)
        Me.Controls.Add(Me.limpiarv)
        Me.Controls.Add(Me.agregar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.barratitulo)
        Me.Controls.Add(Me.desc)
        Me.Controls.Add(Me.precioov)
        Me.Controls.Add(Me.descuent)
        Me.Controls.Add(Me.cant)
        Me.Controls.Add(Me.codigo)
        Me.Controls.Add(Me.cod)
        Me.Controls.Add(Me.DataGridFacturas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RealizarFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RealizarFactura"
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barratitulo.ResumeLayout(False)
        Me.barratitulo.PerformLayout()
        CType(Me.cerrarbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmaxi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents cod As System.Windows.Forms.Label
    Public WithEvents codigo As System.Windows.Forms.TextBox
    Public WithEvents cant As System.Windows.Forms.TextBox
    Public WithEvents descuent As System.Windows.Forms.TextBox
    Public WithEvents precioov As System.Windows.Forms.TextBox
    Public WithEvents desc As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnmini As System.Windows.Forms.PictureBox
    Friend WithEvents barratitulo As System.Windows.Forms.Panel
    Friend WithEvents btnmaxi As System.Windows.Forms.PictureBox
    Friend WithEvents cerrarbtn As System.Windows.Forms.PictureBox
    Friend WithEvents btnrestaurar As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents agregar As System.Windows.Forms.Button
    Friend WithEvents limpiarv As System.Windows.Forms.Button
    Friend WithEvents guardarImprimir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents atras As System.Windows.Forms.Button
    Friend WithEvents buscarb As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
