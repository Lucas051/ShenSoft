<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Detalle))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.barratituloInicio = New System.Windows.Forms.Panel()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.LabelInicio = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnmini = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.cerrarbtn = New System.Windows.Forms.PictureBox()
        Me.btnmaxi = New System.Windows.Forms.PictureBox()
        Me.btnrestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnRestaura = New System.Windows.Forms.PictureBox()
        Me.dgvdetalle = New System.Windows.Forms.DataGridView()
        Me.barratituloInicio.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cerrarbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmaxi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestaura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvdetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barratituloInicio
        '
        Me.barratituloInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.barratituloInicio.Controls.Add(Me.lblUsuario)
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
        Me.barratituloInicio.Size = New System.Drawing.Size(826, 35)
        Me.barratituloInicio.TabIndex = 1
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUsuario.Location = New System.Drawing.Point(939, 5)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(0, 24)
        Me.lblUsuario.TabIndex = 21
        '
        'LabelInicio
        '
        Me.LabelInicio.AutoSize = True
        Me.LabelInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelInicio.Location = New System.Drawing.Point(12, 6)
        Me.LabelInicio.Name = "LabelInicio"
        Me.LabelInicio.Size = New System.Drawing.Size(74, 24)
        Me.LabelInicio.TabIndex = 19
        Me.LabelInicio.Text = "Detalle"
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Image = Global.proyecto.inicio.My.Resources.Resources.minimazar
        Me.btnMinimizar.Location = New System.Drawing.Point(736, 4)
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
        Me.btnmini.Location = New System.Drawing.Point(876, 5)
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
        Me.btnCerrar.Location = New System.Drawing.Point(798, 4)
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
        Me.cerrarbtn.Location = New System.Drawing.Point(938, 5)
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
        Me.btnmaxi.Location = New System.Drawing.Point(907, 5)
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
        Me.btnrestaurar.Location = New System.Drawing.Point(907, 5)
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
        Me.btnMaximizar.Location = New System.Drawing.Point(767, 4)
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
        Me.btnRestaura.Location = New System.Drawing.Point(767, 3)
        Me.btnRestaura.Name = "btnRestaura"
        Me.btnRestaura.Size = New System.Drawing.Size(25, 25)
        Me.btnRestaura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRestaura.TabIndex = 20
        Me.btnRestaura.TabStop = False
        Me.btnRestaura.Visible = False
        '
        'dgvdetalle
        '
        Me.dgvdetalle.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvdetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvdetalle.ColumnHeadersHeight = 42
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvdetalle.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvdetalle.EnableHeadersVisualStyles = False
        Me.dgvdetalle.GridColor = System.Drawing.Color.White
        Me.dgvdetalle.Location = New System.Drawing.Point(25, 52)
        Me.dgvdetalle.Name = "dgvdetalle"
        Me.dgvdetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvdetalle.RowHeadersWidth = 50
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dgvdetalle.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvdetalle.Size = New System.Drawing.Size(767, 377)
        Me.dgvdetalle.TabIndex = 37
        '
        'Detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 468)
        Me.Controls.Add(Me.dgvdetalle)
        Me.Controls.Add(Me.barratituloInicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Detalle"
        Me.Text = "Detalle"
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
        CType(Me.dgvdetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents barratituloInicio As System.Windows.Forms.Panel
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents LabelInicio As System.Windows.Forms.Label
    Friend WithEvents btnMinimizar As System.Windows.Forms.PictureBox
    Friend WithEvents btnmini As System.Windows.Forms.PictureBox
    Friend WithEvents btnCerrar As System.Windows.Forms.PictureBox
    Friend WithEvents cerrarbtn As System.Windows.Forms.PictureBox
    Friend WithEvents btnmaxi As System.Windows.Forms.PictureBox
    Friend WithEvents btnrestaurar As System.Windows.Forms.PictureBox
    Friend WithEvents btnMaximizar As System.Windows.Forms.PictureBox
    Friend WithEvents btnRestaura As System.Windows.Forms.PictureBox
    Friend WithEvents dgvdetalle As System.Windows.Forms.DataGridView
End Class
