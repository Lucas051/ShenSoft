﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.cerrarbtn = New System.Windows.Forms.PictureBox()
        Me.btnmaxi = New System.Windows.Forms.PictureBox()
        Me.btnrestaurar = New System.Windows.Forms.PictureBox()
        Me.Menuvertical = New System.Windows.Forms.Panel()
        Me.PictureBoxsalir = New System.Windows.Forms.PictureBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnclientes = New System.Windows.Forms.Button()
        Me.btnprov = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnstock = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnfacturacion = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.panelmedio = New System.Windows.Forms.Panel()
        Me.panetlstock = New System.Windows.Forms.Panel()
        Me.btnaddstock = New System.Windows.Forms.Button()
        Me.btnmodistock = New System.Windows.Forms.Button()
        Me.Panelproveedores = New System.Windows.Forms.Panel()
        Me.btnbuscarprov = New System.Windows.Forms.Button()
        Me.Panelclientes = New System.Windows.Forms.Panel()
        Me.btndeudores = New System.Windows.Forms.Button()
        Me.btnconsultclient = New System.Windows.Forms.Button()
        Me.PanelFact = New System.Windows.Forms.Panel()
        Me.btnrealizarfact = New System.Windows.Forms.Button()
        Me.btnconslfact = New System.Windows.Forms.Button()
        Me.btnmodprov = New System.Windows.Forms.Button()
        Me.barratitulo.SuspendLayout()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cerrarbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmaxi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menuvertical.SuspendLayout()
        CType(Me.PictureBoxsalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelmedio.SuspendLayout()
        Me.panetlstock.SuspendLayout()
        Me.Panelproveedores.SuspendLayout()
        Me.Panelclientes.SuspendLayout()
        Me.PanelFact.SuspendLayout()
        Me.SuspendLayout()
        '
        'barratitulo
        '
        Me.barratitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.barratitulo.Controls.Add(Me.btnmini)
        Me.barratitulo.Controls.Add(Me.cerrarbtn)
        Me.barratitulo.Controls.Add(Me.btnmaxi)
        Me.barratitulo.Controls.Add(Me.btnrestaurar)
        Me.barratitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.barratitulo.Location = New System.Drawing.Point(0, 0)
        Me.barratitulo.Name = "barratitulo"
        Me.barratitulo.Size = New System.Drawing.Size(984, 35)
        Me.barratitulo.TabIndex = 0
        '
        'btnmini
        '
        Me.btnmini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmini.Image = Global.proyecto.inicio.My.Resources.Resources.minimazar
        Me.btnmini.Location = New System.Drawing.Point(891, 5)
        Me.btnmini.Name = "btnmini"
        Me.btnmini.Size = New System.Drawing.Size(25, 25)
        Me.btnmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmini.TabIndex = 1
        Me.btnmini.TabStop = False
        '
        'cerrarbtn
        '
        Me.cerrarbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrarbtn.Image = Global.proyecto.inicio.My.Resources.Resources.cerrar
        Me.cerrarbtn.Location = New System.Drawing.Point(953, 5)
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
        Me.btnmaxi.Location = New System.Drawing.Point(922, 5)
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
        Me.btnrestaurar.Location = New System.Drawing.Point(922, 5)
        Me.btnrestaurar.Name = "btnrestaurar"
        Me.btnrestaurar.Size = New System.Drawing.Size(25, 25)
        Me.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnrestaurar.TabIndex = 3
        Me.btnrestaurar.TabStop = False
        Me.btnrestaurar.Visible = False
        '
        'Menuvertical
        '
        Me.Menuvertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Menuvertical.Controls.Add(Me.PictureBoxsalir)
        Me.Menuvertical.Controls.Add(Me.Panel9)
        Me.Menuvertical.Controls.Add(Me.Panel4)
        Me.Menuvertical.Controls.Add(Me.Panel3)
        Me.Menuvertical.Controls.Add(Me.btnclientes)
        Me.Menuvertical.Controls.Add(Me.btnprov)
        Me.Menuvertical.Controls.Add(Me.Panel2)
        Me.Menuvertical.Controls.Add(Me.btnstock)
        Me.Menuvertical.Controls.Add(Me.Panel1)
        Me.Menuvertical.Controls.Add(Me.btnfacturacion)
        Me.Menuvertical.Controls.Add(Me.PictureBox1)
        Me.Menuvertical.Controls.Add(Me.btnsalir)
        Me.Menuvertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.Menuvertical.Location = New System.Drawing.Point(0, 35)
        Me.Menuvertical.Name = "Menuvertical"
        Me.Menuvertical.Size = New System.Drawing.Size(200, 426)
        Me.Menuvertical.TabIndex = 1
        '
        'PictureBoxsalir
        '
        Me.PictureBoxsalir.Image = Global.proyecto.inicio.My.Resources.Resources.salir1
        Me.PictureBoxsalir.Location = New System.Drawing.Point(16, 384)
        Me.PictureBoxsalir.Name = "PictureBoxsalir"
        Me.PictureBoxsalir.Size = New System.Drawing.Size(33, 30)
        Me.PictureBoxsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxsalir.TabIndex = 12
        Me.PictureBoxsalir.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.Location = New System.Drawing.Point(197, 299)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(200, 100)
        Me.Panel9.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 266)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 30)
        Me.Panel4.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 333)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 30)
        Me.Panel3.TabIndex = 9
        '
        'btnclientes
        '
        Me.btnclientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnclientes.FlatAppearance.BorderSize = 0
        Me.btnclientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclientes.Font = New System.Drawing.Font("Bahnschrift Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclientes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnclientes.Image = Global.proyecto.inicio.My.Resources.Resources.clientes1
        Me.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnclientes.Location = New System.Drawing.Point(0, 266)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(200, 30)
        Me.btnclientes.TabIndex = 8
        Me.btnclientes.Text = "        Clientes"
        Me.btnclientes.UseVisualStyleBackColor = False
        '
        'btnprov
        '
        Me.btnprov.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnprov.FlatAppearance.BorderSize = 0
        Me.btnprov.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnprov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprov.Font = New System.Drawing.Font("Bahnschrift Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprov.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnprov.Image = Global.proyecto.inicio.My.Resources.Resources.compras
        Me.btnprov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnprov.Location = New System.Drawing.Point(1, 333)
        Me.btnprov.Name = "btnprov"
        Me.btnprov.Size = New System.Drawing.Size(201, 30)
        Me.btnprov.TabIndex = 8
        Me.btnprov.Text = "          Proveedores"
        Me.btnprov.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 198)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 30)
        Me.Panel2.TabIndex = 7
        '
        'btnstock
        '
        Me.btnstock.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnstock.FlatAppearance.BorderSize = 0
        Me.btnstock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstock.Font = New System.Drawing.Font("Bahnschrift Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstock.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnstock.Image = Global.proyecto.inicio.My.Resources.Resources.stock1
        Me.btnstock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnstock.Location = New System.Drawing.Point(3, 198)
        Me.btnstock.Name = "btnstock"
        Me.btnstock.Size = New System.Drawing.Size(197, 30)
        Me.btnstock.TabIndex = 6
        Me.btnstock.Text = "            Stock de Prod."
        Me.btnstock.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(1, 131)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 30)
        Me.Panel1.TabIndex = 5
        '
        'btnfacturacion
        '
        Me.btnfacturacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnfacturacion.FlatAppearance.BorderSize = 0
        Me.btnfacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnfacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfacturacion.Font = New System.Drawing.Font("Bahnschrift Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfacturacion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnfacturacion.Image = Global.proyecto.inicio.My.Resources.Resources.venta
        Me.btnfacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnfacturacion.Location = New System.Drawing.Point(1, 131)
        Me.btnfacturacion.Name = "btnfacturacion"
        Me.btnfacturacion.Size = New System.Drawing.Size(200, 30)
        Me.btnfacturacion.TabIndex = 1
        Me.btnfacturacion.Text = "          Facturación"
        Me.btnfacturacion.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.proyecto.inicio.My.Resources.Resources.logoencamino1
        Me.PictureBox1.Location = New System.Drawing.Point(-45, -68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(292, 248)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnsalir.FlatAppearance.BorderSize = 0
        Me.btnsalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.Font = New System.Drawing.Font("Bahnschrift Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsalir.Location = New System.Drawing.Point(21, 384)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(119, 30)
        Me.btnsalir.TabIndex = 11
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'panelmedio
        '
        Me.panelmedio.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.panelmedio.Controls.Add(Me.panetlstock)
        Me.panelmedio.Controls.Add(Me.Panelproveedores)
        Me.panelmedio.Controls.Add(Me.Panelclientes)
        Me.panelmedio.Controls.Add(Me.PanelFact)
        Me.panelmedio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelmedio.Location = New System.Drawing.Point(0, 0)
        Me.panelmedio.Name = "panelmedio"
        Me.panelmedio.Size = New System.Drawing.Size(984, 461)
        Me.panelmedio.TabIndex = 2
        '
        'panetlstock
        '
        Me.panetlstock.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.panetlstock.Controls.Add(Me.btnaddstock)
        Me.panetlstock.Controls.Add(Me.btnmodistock)
        Me.panetlstock.Location = New System.Drawing.Point(200, 233)
        Me.panetlstock.Name = "panetlstock"
        Me.panetlstock.Size = New System.Drawing.Size(198, 66)
        Me.panetlstock.TabIndex = 14
        Me.panetlstock.Visible = False
        '
        'btnaddstock
        '
        Me.btnaddstock.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnaddstock.FlatAppearance.BorderSize = 0
        Me.btnaddstock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnaddstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddstock.Font = New System.Drawing.Font("Bahnschrift Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddstock.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnaddstock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaddstock.Location = New System.Drawing.Point(0, 0)
        Me.btnaddstock.Name = "btnaddstock"
        Me.btnaddstock.Size = New System.Drawing.Size(202, 30)
        Me.btnaddstock.TabIndex = 2
        Me.btnaddstock.Text = "Agregar Stock"
        Me.btnaddstock.UseVisualStyleBackColor = False
        '
        'btnmodistock
        '
        Me.btnmodistock.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnmodistock.FlatAppearance.BorderSize = 0
        Me.btnmodistock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnmodistock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodistock.Font = New System.Drawing.Font("Bahnschrift Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodistock.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnmodistock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodistock.Location = New System.Drawing.Point(0, 31)
        Me.btnmodistock.Name = "btnmodistock"
        Me.btnmodistock.Size = New System.Drawing.Size(202, 35)
        Me.btnmodistock.TabIndex = 3
        Me.btnmodistock.Text = "Modificar Stock"
        Me.btnmodistock.UseVisualStyleBackColor = False
        '
        'Panelproveedores
        '
        Me.Panelproveedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panelproveedores.Controls.Add(Me.btnbuscarprov)
        Me.Panelproveedores.Controls.Add(Me.btnmodprov)
        Me.Panelproveedores.Location = New System.Drawing.Point(200, 368)
        Me.Panelproveedores.Name = "Panelproveedores"
        Me.Panelproveedores.Size = New System.Drawing.Size(201, 69)
        Me.Panelproveedores.TabIndex = 13
        Me.Panelproveedores.Visible = False
        '
        'btnbuscarprov
        '
        Me.btnbuscarprov.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnbuscarprov.FlatAppearance.BorderSize = 0
        Me.btnbuscarprov.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnbuscarprov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscarprov.Font = New System.Drawing.Font("Bahnschrift Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscarprov.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnbuscarprov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnbuscarprov.Location = New System.Drawing.Point(1, 36)
        Me.btnbuscarprov.Name = "btnbuscarprov"
        Me.btnbuscarprov.Size = New System.Drawing.Size(201, 32)
        Me.btnbuscarprov.TabIndex = 9
        Me.btnbuscarprov.Text = "Consulta de Prov."
        Me.btnbuscarprov.UseVisualStyleBackColor = False
        '
        'Panelclientes
        '
        Me.Panelclientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panelclientes.Controls.Add(Me.btndeudores)
        Me.Panelclientes.Controls.Add(Me.btnconsultclient)
        Me.Panelclientes.Location = New System.Drawing.Point(200, 301)
        Me.Panelclientes.Name = "Panelclientes"
        Me.Panelclientes.Size = New System.Drawing.Size(198, 66)
        Me.Panelclientes.TabIndex = 9
        Me.Panelclientes.Visible = False
        '
        'btndeudores
        '
        Me.btndeudores.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btndeudores.FlatAppearance.BorderSize = 0
        Me.btndeudores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btndeudores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeudores.Font = New System.Drawing.Font("Bahnschrift Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeudores.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btndeudores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndeudores.Location = New System.Drawing.Point(0, 36)
        Me.btndeudores.Name = "btndeudores"
        Me.btndeudores.Size = New System.Drawing.Size(200, 30)
        Me.btndeudores.TabIndex = 9
        Me.btndeudores.Text = "Deudores"
        Me.btndeudores.UseVisualStyleBackColor = False
        '
        'btnconsultclient
        '
        Me.btnconsultclient.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnconsultclient.FlatAppearance.BorderSize = 0
        Me.btnconsultclient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnconsultclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconsultclient.Font = New System.Drawing.Font("Bahnschrift Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultclient.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnconsultclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnconsultclient.Location = New System.Drawing.Point(0, 0)
        Me.btnconsultclient.Name = "btnconsultclient"
        Me.btnconsultclient.Size = New System.Drawing.Size(202, 30)
        Me.btnconsultclient.TabIndex = 7
        Me.btnconsultclient.Text = "Consulta de Client."
        Me.btnconsultclient.UseVisualStyleBackColor = False
        '
        'PanelFact
        '
        Me.PanelFact.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelFact.Controls.Add(Me.btnrealizarfact)
        Me.PanelFact.Controls.Add(Me.btnconslfact)
        Me.PanelFact.Location = New System.Drawing.Point(200, 166)
        Me.PanelFact.Name = "PanelFact"
        Me.PanelFact.Size = New System.Drawing.Size(198, 63)
        Me.PanelFact.TabIndex = 0
        Me.PanelFact.Visible = False
        '
        'btnrealizarfact
        '
        Me.btnrealizarfact.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnrealizarfact.FlatAppearance.BorderSize = 0
        Me.btnrealizarfact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnrealizarfact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrealizarfact.Font = New System.Drawing.Font("Bahnschrift Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrealizarfact.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnrealizarfact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnrealizarfact.Location = New System.Drawing.Point(0, 0)
        Me.btnrealizarfact.Name = "btnrealizarfact"
        Me.btnrealizarfact.Size = New System.Drawing.Size(202, 30)
        Me.btnrealizarfact.TabIndex = 2
        Me.btnrealizarfact.Text = "Realizar Factura"
        Me.btnrealizarfact.UseVisualStyleBackColor = False
        '
        'btnconslfact
        '
        Me.btnconslfact.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnconslfact.FlatAppearance.BorderSize = 0
        Me.btnconslfact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnconslfact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconslfact.Font = New System.Drawing.Font("Bahnschrift Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconslfact.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnconslfact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnconslfact.Location = New System.Drawing.Point(0, 32)
        Me.btnconslfact.Name = "btnconslfact"
        Me.btnconslfact.Size = New System.Drawing.Size(200, 34)
        Me.btnconslfact.TabIndex = 3
        Me.btnconslfact.Text = "Consulta de Fact."
        Me.btnconslfact.UseVisualStyleBackColor = False
        '
        'btnmodprov
        '
        Me.btnmodprov.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnmodprov.FlatAppearance.BorderSize = 0
        Me.btnmodprov.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnmodprov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodprov.Font = New System.Drawing.Font("Bahnschrift Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodprov.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnmodprov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnmodprov.Location = New System.Drawing.Point(1, 1)
        Me.btnmodprov.Name = "btnmodprov"
        Me.btnmodprov.Size = New System.Drawing.Size(202, 29)
        Me.btnmodprov.TabIndex = 8
        Me.btnmodprov.Text = "Modificar Prov."
        Me.btnmodprov.UseVisualStyleBackColor = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.Menuvertical)
        Me.Controls.Add(Me.barratitulo)
        Me.Controls.Add(Me.panelmedio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InicioP"
        Me.barratitulo.ResumeLayout(False)
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cerrarbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmaxi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menuvertical.ResumeLayout(False)
        CType(Me.PictureBoxsalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelmedio.ResumeLayout(False)
        Me.panetlstock.ResumeLayout(False)
        Me.Panelproveedores.ResumeLayout(False)
        Me.Panelclientes.ResumeLayout(False)
        Me.PanelFact.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents barratitulo As System.Windows.Forms.Panel
    Friend WithEvents btnmini As System.Windows.Forms.PictureBox
    Friend WithEvents btnmaxi As System.Windows.Forms.PictureBox
    Friend WithEvents cerrarbtn As System.Windows.Forms.PictureBox
    Friend WithEvents Menuvertical As System.Windows.Forms.Panel
    Friend WithEvents panelmedio As System.Windows.Forms.Panel
    Friend WithEvents btnrestaurar As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnfacturacion As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnclientes As System.Windows.Forms.Button
    Friend WithEvents btnprov As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnstock As System.Windows.Forms.Button
    Friend WithEvents PanelFact As System.Windows.Forms.Panel
    Friend WithEvents btnconslfact As System.Windows.Forms.Button
    Friend WithEvents btnrealizarfact As System.Windows.Forms.Button
    Friend WithEvents btnconsultclient As System.Windows.Forms.Button
    Friend WithEvents Panelclientes As System.Windows.Forms.Panel
    Friend WithEvents btndeudores As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panelproveedores As System.Windows.Forms.Panel
    Friend WithEvents btnbuscarprov As System.Windows.Forms.Button
    Friend WithEvents PictureBoxsalir As System.Windows.Forms.PictureBox
    Friend WithEvents btnsalir As System.Windows.Forms.Button
    Friend WithEvents panetlstock As System.Windows.Forms.Panel
    Friend WithEvents btnaddstock As System.Windows.Forms.Button
    Friend WithEvents btnmodistock As System.Windows.Forms.Button
    Friend WithEvents btnmodprov As System.Windows.Forms.Button
End Class
