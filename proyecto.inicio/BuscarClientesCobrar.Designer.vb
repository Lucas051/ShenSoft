﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarClientesCobrar
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
        Me.btnrestaurar = New System.Windows.Forms.PictureBox()
        Me.btnmaxi = New System.Windows.Forms.PictureBox()
        Me.DGVbuscarclientes = New System.Windows.Forms.DataGridView()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.btnbuscarf = New System.Windows.Forms.TextBox()
        Me.cod = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.barratitulo.SuspendLayout()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cerrarbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmaxi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVbuscarclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barratitulo
        '
        Me.barratitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.barratitulo.Controls.Add(Me.Label1)
        Me.barratitulo.Controls.Add(Me.btnmini)
        Me.barratitulo.Controls.Add(Me.cerrarbtn)
        Me.barratitulo.Controls.Add(Me.btnrestaurar)
        Me.barratitulo.Controls.Add(Me.btnmaxi)
        Me.barratitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.barratitulo.Location = New System.Drawing.Point(0, 0)
        Me.barratitulo.Name = "barratitulo"
        Me.barratitulo.Size = New System.Drawing.Size(765, 35)
        Me.barratitulo.TabIndex = 35
        '
        'btnmini
        '
        Me.btnmini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmini.Image = Global.proyecto.inicio.My.Resources.Resources.minimazar
        Me.btnmini.Location = New System.Drawing.Point(672, 5)
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
        Me.cerrarbtn.Location = New System.Drawing.Point(734, 5)
        Me.cerrarbtn.Name = "cerrarbtn"
        Me.cerrarbtn.Size = New System.Drawing.Size(25, 25)
        Me.cerrarbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cerrarbtn.TabIndex = 0
        Me.cerrarbtn.TabStop = False
        '
        'btnrestaurar
        '
        Me.btnrestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnrestaurar.Image = Global.proyecto.inicio.My.Resources.Resources.res
        Me.btnrestaurar.Location = New System.Drawing.Point(703, 5)
        Me.btnrestaurar.Name = "btnrestaurar"
        Me.btnrestaurar.Size = New System.Drawing.Size(25, 25)
        Me.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnrestaurar.TabIndex = 3
        Me.btnrestaurar.TabStop = False
        Me.btnrestaurar.Visible = False
        '
        'btnmaxi
        '
        Me.btnmaxi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmaxi.Image = Global.proyecto.inicio.My.Resources.Resources.maxi
        Me.btnmaxi.Location = New System.Drawing.Point(703, 5)
        Me.btnmaxi.Name = "btnmaxi"
        Me.btnmaxi.Size = New System.Drawing.Size(25, 25)
        Me.btnmaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmaxi.TabIndex = 2
        Me.btnmaxi.TabStop = False
        '
        'DGVbuscarclientes
        '
        Me.DGVbuscarclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVbuscarclientes.Location = New System.Drawing.Point(46, 88)
        Me.DGVbuscarclientes.Name = "DGVbuscarclientes"
        Me.DGVbuscarclientes.Size = New System.Drawing.Size(682, 241)
        Me.DGVbuscarclientes.TabIndex = 36
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
        Me.btnatras.Location = New System.Drawing.Point(648, 358)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(80, 26)
        Me.btnatras.TabIndex = 48
        Me.btnatras.Text = "Atrás"
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'btnbuscarf
        '
        Me.btnbuscarf.Location = New System.Drawing.Point(157, 60)
        Me.btnbuscarf.Multiline = True
        Me.btnbuscarf.Name = "btnbuscarf"
        Me.btnbuscarf.Size = New System.Drawing.Size(107, 22)
        Me.btnbuscarf.TabIndex = 50
        '
        'cod
        '
        Me.cod.AutoSize = True
        Me.cod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cod.Location = New System.Drawing.Point(42, 60)
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(109, 18)
        Me.cod.TabIndex = 49
        Me.cod.Text = "Buscar Factura"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Buscar Clientes"
        '
        'BuscarClientesCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 396)
        Me.Controls.Add(Me.btnbuscarf)
        Me.Controls.Add(Me.cod)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.DGVbuscarclientes)
        Me.Controls.Add(Me.barratitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BuscarClientesCobrar"
        Me.Text = "BuscarClientesCobrar"
        Me.barratitulo.ResumeLayout(False)
        Me.barratitulo.PerformLayout()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cerrarbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmaxi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVbuscarclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents barratitulo As System.Windows.Forms.Panel
    Friend WithEvents btnmini As System.Windows.Forms.PictureBox
    Friend WithEvents cerrarbtn As System.Windows.Forms.PictureBox
    Friend WithEvents btnmaxi As System.Windows.Forms.PictureBox
    Friend WithEvents btnrestaurar As System.Windows.Forms.PictureBox
    Friend WithEvents DGVbuscarclientes As System.Windows.Forms.DataGridView
    Friend WithEvents btnatras As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnbuscarf As System.Windows.Forms.TextBox
    Friend WithEvents cod As System.Windows.Forms.Label
End Class