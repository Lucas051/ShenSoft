<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class buscarproductos
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
        Me.DataGridbuscar = New System.Windows.Forms.DataGridView()
        Me.barratitulo = New System.Windows.Forms.Panel()
        Me.btnmini = New System.Windows.Forms.PictureBox()
        Me.cerrarbtn = New System.Windows.Forms.PictureBox()
        Me.btnmaxi = New System.Windows.Forms.PictureBox()
        Me.btnrestaurar = New System.Windows.Forms.PictureBox()
        Me.cod = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.atras = New System.Windows.Forms.Button()
        CType(Me.DataGridbuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barratitulo.SuspendLayout()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cerrarbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmaxi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridbuscar
        '
        Me.DataGridbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridbuscar.Location = New System.Drawing.Point(20, 84)
        Me.DataGridbuscar.Name = "DataGridbuscar"
        Me.DataGridbuscar.Size = New System.Drawing.Size(667, 198)
        Me.DataGridbuscar.TabIndex = 33
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
        Me.barratitulo.Size = New System.Drawing.Size(701, 35)
        Me.barratitulo.TabIndex = 34
        '
        'btnmini
        '
        Me.btnmini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmini.Image = Global.proyecto.inicio.My.Resources.Resources.minimazar
        Me.btnmini.Location = New System.Drawing.Point(608, 5)
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
        Me.cerrarbtn.Location = New System.Drawing.Point(670, 5)
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
        Me.btnmaxi.Location = New System.Drawing.Point(639, 5)
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
        Me.btnrestaurar.Location = New System.Drawing.Point(639, 5)
        Me.btnrestaurar.Name = "btnrestaurar"
        Me.btnrestaurar.Size = New System.Drawing.Size(25, 25)
        Me.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnrestaurar.TabIndex = 3
        Me.btnrestaurar.TabStop = False
        Me.btnrestaurar.Visible = False
        '
        'cod
        '
        Me.cod.AutoSize = True
        Me.cod.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cod.Location = New System.Drawing.Point(17, 52)
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(107, 18)
        Me.cod.TabIndex = 35
        Me.cod.Text = "Buscar Factura"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(130, 51)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(107, 22)
        Me.TextBox1.TabIndex = 36
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
        Me.atras.Location = New System.Drawing.Point(607, 292)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(80, 26)
        Me.atras.TabIndex = 47
        Me.atras.Text = "Atrás"
        Me.atras.UseVisualStyleBackColor = False
        '
        'buscarproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(701, 330)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cod)
        Me.Controls.Add(Me.barratitulo)
        Me.Controls.Add(Me.DataGridbuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "buscarproductos"
        Me.Text = "Buscar Productos"
        CType(Me.DataGridbuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barratitulo.ResumeLayout(False)
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cerrarbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmaxi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridbuscar As System.Windows.Forms.DataGridView
    Friend WithEvents barratitulo As System.Windows.Forms.Panel
    Friend WithEvents btnmini As System.Windows.Forms.PictureBox
    Friend WithEvents cerrarbtn As System.Windows.Forms.PictureBox
    Friend WithEvents btnmaxi As System.Windows.Forms.PictureBox
    Friend WithEvents btnrestaurar As System.Windows.Forms.PictureBox
    Friend WithEvents cod As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents atras As System.Windows.Forms.Button
End Class
