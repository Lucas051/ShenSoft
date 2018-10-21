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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RealizarFactura))
        Me.DataGridFacturas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cod = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtcant = New System.Windows.Forms.TextBox()
        Me.txtdescuent = New System.Windows.Forms.TextBox()
        Me.txtprecioov = New System.Windows.Forms.TextBox()
        Me.txtdesc = New System.Windows.Forms.TextBox()
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
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barratituloInicio.SuspendLayout()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cerrarbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmaxi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestaura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridFacturas
        '
        Me.DataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridFacturas.Location = New System.Drawing.Point(264, 84)
        Me.DataGridFacturas.Name = "DataGridFacturas"
        Me.DataGridFacturas.Size = New System.Drawing.Size(849, 395)
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
        Me.cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.cod.Location = New System.Drawing.Point(40, 71)
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(56, 18)
        Me.cod.TabIndex = 22
        Me.cod.Text = "Código"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(104, 72)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 27
        '
        'txtcant
        '
        Me.txtcant.Location = New System.Drawing.Point(104, 135)
        Me.txtcant.Name = "txtcant"
        Me.txtcant.Size = New System.Drawing.Size(100, 20)
        Me.txtcant.TabIndex = 28
        '
        'txtdescuent
        '
        Me.txtdescuent.Location = New System.Drawing.Point(104, 167)
        Me.txtdescuent.Name = "txtdescuent"
        Me.txtdescuent.Size = New System.Drawing.Size(100, 20)
        Me.txtdescuent.TabIndex = 29
        '
        'txtprecioov
        '
        Me.txtprecioov.Location = New System.Drawing.Point(104, 199)
        Me.txtprecioov.Name = "txtprecioov"
        Me.txtprecioov.Size = New System.Drawing.Size(100, 20)
        Me.txtprecioov.TabIndex = 30
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(104, 103)
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(100, 20)
        Me.txtdesc.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 18)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Descripción"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(27, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Descuento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(2, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 18)
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
        Me.btnagregar.Location = New System.Drawing.Point(30, 238)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(174, 26)
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
        Me.btnguardarImprimir.Location = New System.Drawing.Point(210, 552)
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
        Me.btnborrar.Location = New System.Drawing.Point(264, 485)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(114, 26)
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
        Me.btnatras.Location = New System.Drawing.Point(1055, 552)
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
        Me.btnbuscarproductos.Location = New System.Drawing.Point(1034, 52)
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
        Me.Label5.Location = New System.Drawing.Point(905, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 18)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Buscar Productos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(945, 482)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 18)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Monto Total"
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Image = Global.proyecto.inicio.My.Resources.Resources.minimazar
        Me.btnMinimizar.Location = New System.Drawing.Point(1069, 3)
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
        Me.barratituloInicio.Size = New System.Drawing.Size(1147, 35)
        Me.barratituloInicio.TabIndex = 50
        '
        'LabelInicio
        '
        Me.LabelInicio.AutoSize = True
        Me.LabelInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelInicio.Location = New System.Drawing.Point(12, 6)
        Me.LabelInicio.Name = "LabelInicio"
        Me.LabelInicio.Size = New System.Drawing.Size(60, 24)
        Me.LabelInicio.TabIndex = 19
        Me.LabelInicio.Text = "Inicio"
        '
        'btnmini
        '
        Me.btnmini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmini.Image = CType(resources.GetObject("btnmini.Image"), System.Drawing.Image)
        Me.btnmini.Location = New System.Drawing.Point(1197, 5)
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
        Me.cerrarbtn.Location = New System.Drawing.Point(1259, 5)
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
        Me.btnmaxi.Location = New System.Drawing.Point(1228, 5)
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
        Me.btnrestaurar.Location = New System.Drawing.Point(1228, 5)
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
        Me.btnMaximizar.Location = New System.Drawing.Point(1100, 3)
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
        Me.btnRestaura.Location = New System.Drawing.Point(1100, 3)
        Me.btnRestaura.Name = "btnRestaura"
        Me.btnRestaura.Size = New System.Drawing.Size(25, 25)
        Me.btnRestaura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRestaura.TabIndex = 20
        Me.btnRestaura.TabStop = False
        Me.btnRestaura.Visible = False
        '
        'RealizarFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1147, 590)
        Me.Controls.Add(Me.barratituloInicio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnbuscarproductos)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.btnguardarImprimir)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdesc)
        Me.Controls.Add(Me.txtprecioov)
        Me.Controls.Add(Me.txtdescuent)
        Me.Controls.Add(Me.txtcant)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.cod)
        Me.Controls.Add(Me.DataGridFacturas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RealizarFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RealizarFactura"
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barratituloInicio.ResumeLayout(False)
        Me.barratituloInicio.PerformLayout()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cerrarbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmaxi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestaura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents cod As System.Windows.Forms.Label
    Public WithEvents txtcodigo As System.Windows.Forms.TextBox
    Public WithEvents txtcant As System.Windows.Forms.TextBox
    Public WithEvents txtdescuent As System.Windows.Forms.TextBox
    Public WithEvents txtprecioov As System.Windows.Forms.TextBox
    Public WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
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
End Class
