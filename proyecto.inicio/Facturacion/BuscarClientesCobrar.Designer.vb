<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarClientesCobrar))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cod = New System.Windows.Forms.Label()
        Me.barratituloInicio = New System.Windows.Forms.Panel()
        Me.LabelInicio = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnmini = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.cerrarbtn = New System.Windows.Forms.PictureBox()
        Me.btnmaxi = New System.Windows.Forms.PictureBox()
        Me.btnrestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnRestaura = New System.Windows.Forms.PictureBox()
        Me.DGVbuscarclientes = New System.Windows.Forms.DataGridView()
        Me.barratituloInicio.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cerrarbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmaxi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestaura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVbuscarclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(76, 48)
        Me.txtbuscar.Multiline = True
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(133, 22)
        Me.txtbuscar.TabIndex = 50
        '
        'cod
        '
        Me.cod.AutoSize = True
        Me.cod.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cod.Location = New System.Drawing.Point(13, 50)
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(57, 18)
        Me.cod.TabIndex = 49
        Me.cod.Text = "Buscar:"
        '
        'barratituloInicio
        '
        Me.barratituloInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.barratituloInicio.Controls.Add(Me.LabelInicio)
        Me.barratituloInicio.Controls.Add(Me.btnMinimizar)
        Me.barratituloInicio.Controls.Add(Me.btnmini)
        Me.barratituloInicio.Controls.Add(Me.btnCerrar)
        Me.barratituloInicio.Controls.Add(Me.cerrarbtn)
        Me.barratituloInicio.Controls.Add(Me.btnmaxi)
        Me.barratituloInicio.Controls.Add(Me.btnrestaurar)
        Me.barratituloInicio.Controls.Add(Me.btnMaximizar)
        Me.barratituloInicio.Controls.Add(Me.btnRestaura)
        Me.barratituloInicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.barratituloInicio.Location = New System.Drawing.Point(0, 0)
        Me.barratituloInicio.Name = "barratituloInicio"
        Me.barratituloInicio.Size = New System.Drawing.Size(663, 35)
        Me.barratituloInicio.TabIndex = 51
        '
        'LabelInicio
        '
        Me.LabelInicio.AutoSize = True
        Me.LabelInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelInicio.Location = New System.Drawing.Point(12, 9)
        Me.LabelInicio.Name = "LabelInicio"
        Me.LabelInicio.Size = New System.Drawing.Size(74, 20)
        Me.LabelInicio.TabIndex = 19
        Me.LabelInicio.Text = "Clientes"
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Image = Global.proyecto.inicio.My.Resources.Resources.minimazar
        Me.btnMinimizar.Location = New System.Drawing.Point(573, 4)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(25, 25)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 16
        Me.btnMinimizar.TabStop = False
        '
        'btnmini
        '
        Me.btnmini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmini.Image = CType(resources.GetObject("btnmini.Image"), System.Drawing.Image)
        Me.btnmini.Location = New System.Drawing.Point(713, 5)
        Me.btnmini.Name = "btnmini"
        Me.btnmini.Size = New System.Drawing.Size(25, 25)
        Me.btnmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmini.TabIndex = 1
        Me.btnmini.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Image = Global.proyecto.inicio.My.Resources.Resources.cerrar
        Me.btnCerrar.Location = New System.Drawing.Point(635, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 15
        Me.btnCerrar.TabStop = False
        '
        'cerrarbtn
        '
        Me.cerrarbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrarbtn.Image = CType(resources.GetObject("cerrarbtn.Image"), System.Drawing.Image)
        Me.cerrarbtn.Location = New System.Drawing.Point(775, 5)
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
        Me.btnmaxi.Location = New System.Drawing.Point(744, 5)
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
        Me.btnrestaurar.Location = New System.Drawing.Point(744, 5)
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
        Me.btnMaximizar.Location = New System.Drawing.Point(604, 4)
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
        Me.btnRestaura.Location = New System.Drawing.Point(604, 4)
        Me.btnRestaura.Name = "btnRestaura"
        Me.btnRestaura.Size = New System.Drawing.Size(25, 25)
        Me.btnRestaura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRestaura.TabIndex = 17
        Me.btnRestaura.TabStop = False
        Me.btnRestaura.Visible = False
        '
        'DGVbuscarclientes
        '
        Me.DGVbuscarclientes.BackgroundColor = System.Drawing.Color.Silver
        Me.DGVbuscarclientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Bahnschrift Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVbuscarclientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVbuscarclientes.ColumnHeadersHeight = 42
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVbuscarclientes.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGVbuscarclientes.EnableHeadersVisualStyles = False
        Me.DGVbuscarclientes.GridColor = System.Drawing.Color.White
        Me.DGVbuscarclientes.Location = New System.Drawing.Point(16, 83)
        Me.DGVbuscarclientes.Name = "DGVbuscarclientes"
        Me.DGVbuscarclientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVbuscarclientes.RowHeadersVisible = False
        Me.DGVbuscarclientes.RowHeadersWidth = 50
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.DGVbuscarclientes.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGVbuscarclientes.Size = New System.Drawing.Size(612, 259)
        Me.DGVbuscarclientes.TabIndex = 37
        '
        'BuscarClientesCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 397)
        Me.Controls.Add(Me.DGVbuscarclientes)
        Me.Controls.Add(Me.barratituloInicio)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.cod)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BuscarClientesCobrar"
        Me.Text = "BuscarClientesCobrar"
        Me.barratituloInicio.ResumeLayout(False)
        Me.barratituloInicio.PerformLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cerrarbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmaxi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestaura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVbuscarclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbuscar As System.Windows.Forms.TextBox
    Friend WithEvents cod As System.Windows.Forms.Label
    Friend WithEvents barratituloInicio As System.Windows.Forms.Panel
    Friend WithEvents LabelInicio As System.Windows.Forms.Label
    Friend WithEvents btnMinimizar As System.Windows.Forms.PictureBox
    Friend WithEvents btnmini As System.Windows.Forms.PictureBox
    Friend WithEvents btnCerrar As System.Windows.Forms.PictureBox
    Friend WithEvents cerrarbtn As System.Windows.Forms.PictureBox
    Friend WithEvents btnmaxi As System.Windows.Forms.PictureBox
    Friend WithEvents btnrestaurar As System.Windows.Forms.PictureBox
    Friend WithEvents btnMaximizar As System.Windows.Forms.PictureBox
    Friend WithEvents btnRestaura As System.Windows.Forms.PictureBox
    Friend WithEvents DGVbuscarclientes As System.Windows.Forms.DataGridView
End Class
