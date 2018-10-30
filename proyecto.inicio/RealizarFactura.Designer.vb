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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RealizarFactura))
        Me.DGVVentas = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precioventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.preciototal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod = New System.Windows.Forms.Label()
        Me.txtcant = New System.Windows.Forms.TextBox()
        Me.txtdescuent = New System.Windows.Forms.TextBox()
        Me.txtprecioov = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.btnguardarImprimir = New System.Windows.Forms.Button()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.btnbuscarproductos = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.barratituloInicio = New System.Windows.Forms.Panel()
        Me.LabelInicio = New System.Windows.Forms.Label()
        Me.btnmini = New System.Windows.Forms.PictureBox()
        Me.cerrarbtn = New System.Windows.Forms.PictureBox()
        Me.btnmaxi = New System.Windows.Forms.PictureBox()
        Me.btnrestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnRestaura = New System.Windows.Forms.PictureBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblMontoTotal = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnlineaAgregada = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        CType(Me.DGVVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barratituloInicio.SuspendLayout()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cerrarbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmaxi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestaura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVVentas
        '
        Me.DGVVentas.BackgroundColor = System.Drawing.Color.Silver
        Me.DGVVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVVentas.ColumnHeadersHeight = 42
        Me.DGVVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.descripcion, Me.cantidad, Me.descuento, Me.precioventa, Me.preciototal})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVVentas.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVVentas.EnableHeadersVisualStyles = False
        Me.DGVVentas.GridColor = System.Drawing.Color.White
        Me.DGVVentas.Location = New System.Drawing.Point(318, 84)
        Me.DGVVentas.Name = "DGVVentas"
        Me.DGVVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVVentas.RowHeadersWidth = 50
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.DGVVentas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVVentas.Size = New System.Drawing.Size(840, 369)
        Me.DGVVentas.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.codigo.Width = 120
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.descripcion.Width = 200
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cantidad.Width = 110
        '
        'descuento
        '
        Me.descuento.HeaderText = "Descuento (%)"
        Me.descuento.Name = "descuento"
        Me.descuento.ReadOnly = True
        Me.descuento.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.descuento.Width = 120
        '
        'precioventa
        '
        Me.precioventa.HeaderText = "Precio Unitario"
        Me.precioventa.Name = "precioventa"
        Me.precioventa.ReadOnly = True
        Me.precioventa.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.precioventa.Width = 120
        '
        'preciototal
        '
        Me.preciototal.HeaderText = "Precio Total"
        Me.preciototal.Name = "preciototal"
        Me.preciototal.ReadOnly = True
        Me.preciototal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.preciototal.Width = 120
        '
        'cod
        '
        Me.cod.AutoSize = True
        Me.cod.BackColor = System.Drawing.Color.Transparent
        Me.cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.cod.Location = New System.Drawing.Point(44, 67)
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(59, 20)
        Me.cod.TabIndex = 22
        Me.cod.Text = "Código"
        '
        'txtcant
        '
        Me.txtcant.Location = New System.Drawing.Point(109, 192)
        Me.txtcant.Name = "txtcant"
        Me.txtcant.Size = New System.Drawing.Size(138, 20)
        Me.txtcant.TabIndex = 28
        '
        'txtdescuent
        '
        Me.txtdescuent.Location = New System.Drawing.Point(109, 252)
        Me.txtdescuent.Name = "txtdescuent"
        Me.txtdescuent.Size = New System.Drawing.Size(138, 20)
        Me.txtdescuent.TabIndex = 29
        '
        'txtprecioov
        '
        Me.txtprecioov.Location = New System.Drawing.Point(109, 308)
        Me.txtprecioov.Name = "txtprecioov"
        Me.txtprecioov.Size = New System.Drawing.Size(138, 20)
        Me.txtprecioov.TabIndex = 30
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(109, 129)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(138, 22)
        Me.txtdescripcion.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Descripción"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(30, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Descuento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 308)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Precio Venta"
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnagregar.FlatAppearance.BorderSize = 0
        Me.btnagregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnagregar.Location = New System.Drawing.Point(20, 361)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(227, 26)
        Me.btnagregar.TabIndex = 42
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'btnguardarImprimir
        '
        Me.btnguardarImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnguardarImprimir.FlatAppearance.BorderSize = 0
        Me.btnguardarImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnguardarImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnguardarImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardarImprimir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnguardarImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnguardarImprimir.Location = New System.Drawing.Point(318, 552)
        Me.btnguardarImprimir.Name = "btnguardarImprimir"
        Me.btnguardarImprimir.Size = New System.Drawing.Size(145, 26)
        Me.btnguardarImprimir.TabIndex = 44
        Me.btnguardarImprimir.Text = "Cobrar Venta"
        Me.btnguardarImprimir.UseVisualStyleBackColor = False
        '
        'btnborrar
        '
        Me.btnborrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnborrar.FlatAppearance.BorderSize = 0
        Me.btnborrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnborrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnborrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnborrar.Location = New System.Drawing.Point(318, 472)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(145, 26)
        Me.btnborrar.TabIndex = 45
        Me.btnborrar.Text = "Borrar Línea"
        Me.btnborrar.UseVisualStyleBackColor = False
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
        Me.btnatras.Location = New System.Drawing.Point(1088, 569)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(80, 26)
        Me.btnatras.TabIndex = 46
        Me.btnatras.Text = "Atrás"
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'btnbuscarproductos
        '
        Me.btnbuscarproductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnbuscarproductos.FlatAppearance.BorderSize = 0
        Me.btnbuscarproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnbuscarproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarproductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarproductos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnbuscarproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscarproductos.Location = New System.Drawing.Point(1079, 52)
        Me.btnbuscarproductos.Name = "btnbuscarproductos"
        Me.btnbuscarproductos.Size = New System.Drawing.Size(79, 26)
        Me.btnbuscarproductos.TabIndex = 47
        Me.btnbuscarproductos.Text = "Buscar"
        Me.btnbuscarproductos.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(950, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 18)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Buscar Productos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(969, 467)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 24)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Monto Total:"
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Image = Global.proyecto.inicio.My.Resources.Resources.minimazar
        Me.btnMinimizar.Location = New System.Drawing.Point(1104, 7)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(25, 25)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 16
        Me.btnMinimizar.TabStop = False
        '
        'barratituloInicio
        '
        Me.barratituloInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.barratituloInicio.Controls.Add(Me.LabelInicio)
        Me.barratituloInicio.Controls.Add(Me.btnMinimizar)
        Me.barratituloInicio.Controls.Add(Me.btnmini)
        Me.barratituloInicio.Controls.Add(Me.cerrarbtn)
        Me.barratituloInicio.Controls.Add(Me.btnmaxi)
        Me.barratituloInicio.Controls.Add(Me.btnrestaurar)
        Me.barratituloInicio.Controls.Add(Me.btnMaximizar)
        Me.barratituloInicio.Controls.Add(Me.btnRestaura)
        Me.barratituloInicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.barratituloInicio.Location = New System.Drawing.Point(0, 0)
        Me.barratituloInicio.Name = "barratituloInicio"
        Me.barratituloInicio.Size = New System.Drawing.Size(1179, 35)
        Me.barratituloInicio.TabIndex = 50
        '
        'LabelInicio
        '
        Me.LabelInicio.AutoSize = True
        Me.LabelInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelInicio.Location = New System.Drawing.Point(5, 9)
        Me.LabelInicio.Name = "LabelInicio"
        Me.LabelInicio.Size = New System.Drawing.Size(104, 20)
        Me.LabelInicio.TabIndex = 19
        Me.LabelInicio.Text = "Facturación"
        '
        'btnmini
        '
        Me.btnmini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmini.Image = CType(resources.GetObject("btnmini.Image"), System.Drawing.Image)
        Me.btnmini.Location = New System.Drawing.Point(1229, 5)
        Me.btnmini.Name = "btnmini"
        Me.btnmini.Size = New System.Drawing.Size(25, 25)
        Me.btnmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmini.TabIndex = 1
        Me.btnmini.TabStop = False
        '
        'cerrarbtn
        '
        Me.cerrarbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrarbtn.Image = CType(resources.GetObject("cerrarbtn.Image"), System.Drawing.Image)
        Me.cerrarbtn.Location = New System.Drawing.Point(1291, 5)
        Me.cerrarbtn.Name = "cerrarbtn"
        Me.cerrarbtn.Size = New System.Drawing.Size(25, 25)
        Me.cerrarbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cerrarbtn.TabIndex = 0
        Me.cerrarbtn.TabStop = False
        '
        'btnmaxi
        '
        Me.btnmaxi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmaxi.Image = CType(resources.GetObject("btnmaxi.Image"), System.Drawing.Image)
        Me.btnmaxi.Location = New System.Drawing.Point(1260, 5)
        Me.btnmaxi.Name = "btnmaxi"
        Me.btnmaxi.Size = New System.Drawing.Size(25, 25)
        Me.btnmaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmaxi.TabIndex = 2
        Me.btnmaxi.TabStop = False
        '
        'btnrestaurar
        '
        Me.btnrestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnrestaurar.Image = CType(resources.GetObject("btnrestaurar.Image"), System.Drawing.Image)
        Me.btnrestaurar.Location = New System.Drawing.Point(1260, 5)
        Me.btnrestaurar.Name = "btnrestaurar"
        Me.btnrestaurar.Size = New System.Drawing.Size(25, 25)
        Me.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnrestaurar.TabIndex = 3
        Me.btnrestaurar.TabStop = False
        Me.btnrestaurar.Visible = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Image = Global.proyecto.inicio.My.Resources.Resources.maxi
        Me.btnMaximizar.Location = New System.Drawing.Point(1142, 3)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(25, 25)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMaximizar.TabIndex = 18
        Me.btnMaximizar.TabStop = False
        '
        'btnRestaura
        '
        Me.btnRestaura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaura.Image = Global.proyecto.inicio.My.Resources.Resources.res
        Me.btnRestaura.Location = New System.Drawing.Point(1142, 3)
        Me.btnRestaura.Name = "btnRestaura"
        Me.btnRestaura.Size = New System.Drawing.Size(25, 25)
        Me.btnRestaura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRestaura.TabIndex = 20
        Me.btnRestaura.TabStop = False
        Me.btnRestaura.Visible = False
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.BackColor = System.Drawing.Color.Transparent
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lblCodigo.Location = New System.Drawing.Point(124, 67)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(59, 20)
        Me.lblCodigo.TabIndex = 51
        Me.lblCodigo.Text = "Código"
        '
        'lblMontoTotal
        '
        Me.lblMontoTotal.AutoSize = True
        Me.lblMontoTotal.Font = New System.Drawing.Font("Bahnschrift", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMontoTotal.Location = New System.Drawing.Point(1093, 467)
        Me.lblMontoTotal.Name = "lblMontoTotal"
        Me.lblMontoTotal.Size = New System.Drawing.Size(21, 24)
        Me.lblMontoTotal.TabIndex = 52
        Me.lblMontoTotal.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btnlineaAgregada)
        Me.Panel1.Controls.Add(Me.btnagregar)
        Me.Panel1.Controls.Add(Me.lblCodigo)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtcant)
        Me.Panel1.Controls.Add(Me.txtdescuent)
        Me.Panel1.Controls.Add(Me.txtprecioov)
        Me.Panel1.Controls.Add(Me.txtdescripcion)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cod)
        Me.Panel1.Location = New System.Drawing.Point(2, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(287, 574)
        Me.Panel1.TabIndex = 53
        '
        'btnlineaAgregada
        '
        Me.btnlineaAgregada.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnlineaAgregada.FlatAppearance.BorderSize = 0
        Me.btnlineaAgregada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnlineaAgregada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlineaAgregada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlineaAgregada.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnlineaAgregada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnlineaAgregada.Location = New System.Drawing.Point(20, 402)
        Me.btnlineaAgregada.Name = "btnlineaAgregada"
        Me.btnlineaAgregada.Size = New System.Drawing.Size(227, 26)
        Me.btnlineaAgregada.TabIndex = 56
        Me.btnlineaAgregada.Text = "Agregar Línea Editada"
        Me.btnlineaAgregada.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.Location = New System.Drawing.Point(483, 472)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(145, 26)
        Me.btnEditar.TabIndex = 54
        Me.btnEditar.Text = "Editar Línea"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'RealizarFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1179, 607)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.lblMontoTotal)
        Me.Controls.Add(Me.barratituloInicio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnbuscarproductos)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.btnguardarImprimir)
        Me.Controls.Add(Me.DGVVentas)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RealizarFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RealizarFactura"
        CType(Me.DGVVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barratituloInicio.ResumeLayout(False)
        Me.barratituloInicio.PerformLayout()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cerrarbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmaxi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestaura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGVVentas As System.Windows.Forms.DataGridView
    Friend WithEvents cod As System.Windows.Forms.Label
    Public WithEvents txtcant As System.Windows.Forms.TextBox
    Public WithEvents txtdescuent As System.Windows.Forms.TextBox
    Public WithEvents txtprecioov As System.Windows.Forms.TextBox
    Public WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents btnguardarImprimir As System.Windows.Forms.Button
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents btnbuscarproductos As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnMinimizar As System.Windows.Forms.PictureBox
    Friend WithEvents barratituloInicio As System.Windows.Forms.Panel
    Friend WithEvents LabelInicio As System.Windows.Forms.Label
    Friend WithEvents btnmini As System.Windows.Forms.PictureBox
    Friend WithEvents cerrarbtn As System.Windows.Forms.PictureBox
    Friend WithEvents btnmaxi As System.Windows.Forms.PictureBox
    Friend WithEvents btnrestaurar As System.Windows.Forms.PictureBox
    Friend WithEvents btnMaximizar As System.Windows.Forms.PictureBox
    Friend WithEvents btnRestaura As System.Windows.Forms.PictureBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblMontoTotal As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnlineaAgregada As System.Windows.Forms.Button
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precioventa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents preciototal As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
