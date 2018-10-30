<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarProv
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBuscarP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvproveedores = New System.Windows.Forms.DataGridView()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumProv = New System.Windows.Forms.Label()
        Me.btnEliminarProv = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        CType(Me.dgvproveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscarP
        '
        Me.txtBuscarP.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarP.Location = New System.Drawing.Point(719, 22)
        Me.txtBuscarP.Multiline = True
        Me.txtBuscarP.Name = "txtBuscarP"
        Me.txtBuscarP.Size = New System.Drawing.Size(142, 25)
        Me.txtBuscarP.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(562, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 22)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Buscar Proveedores:"
        '
        'dgvproveedores
        '
        Me.dgvproveedores.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvproveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Bahnschrift Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvproveedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvproveedores.ColumnHeadersHeight = 42
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvproveedores.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvproveedores.EnableHeadersVisualStyles = False
        Me.dgvproveedores.GridColor = System.Drawing.Color.White
        Me.dgvproveedores.Location = New System.Drawing.Point(12, 88)
        Me.dgvproveedores.Name = "dgvproveedores"
        Me.dgvproveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvproveedores.RowHeadersWidth = 50
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dgvproveedores.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvproveedores.Size = New System.Drawing.Size(845, 410)
        Me.dgvproveedores.TabIndex = 48
        '
        'txtproveedor
        '
        Me.txtproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproveedor.Location = New System.Drawing.Point(272, 16)
        Me.txtproveedor.Multiline = True
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(139, 28)
        Me.txtproveedor.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(150, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 22)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Nom. Proveedor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 22)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Cód. Prov.:"
        '
        'lblNumProv
        '
        Me.lblNumProv.AutoSize = True
        Me.lblNumProv.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumProv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lblNumProv.Location = New System.Drawing.Point(107, 19)
        Me.lblNumProv.Name = "lblNumProv"
        Me.lblNumProv.Size = New System.Drawing.Size(19, 22)
        Me.lblNumProv.TabIndex = 56
        Me.lblNumProv.Text = "0"
        '
        'btnEliminarProv
        '
        Me.btnEliminarProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEliminarProv.FlatAppearance.BorderSize = 0
        Me.btnEliminarProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEliminarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProv.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEliminarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminarProv.Location = New System.Drawing.Point(272, 52)
        Me.btnEliminarProv.Name = "btnEliminarProv"
        Me.btnEliminarProv.Size = New System.Drawing.Size(139, 26)
        Me.btnEliminarProv.TabIndex = 57
        Me.btnEliminarProv.Text = "Eliminar"
        Me.btnEliminarProv.UseVisualStyleBackColor = False
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSeleccionar.FlatAppearance.BorderSize = 0
        Me.btnSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSeleccionar.Location = New System.Drawing.Point(643, 504)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(214, 28)
        Me.btnSeleccionar.TabIndex = 58
        Me.btnSeleccionar.Text = "Seleccionar Proveedor"
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'EliminarProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(891, 667)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.btnEliminarProv)
        Me.Controls.Add(Me.lblNumProv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtproveedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscarP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvproveedores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EliminarProv"
        Me.Text = "EliminarProv"
        CType(Me.dgvproveedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscarP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvproveedores As System.Windows.Forms.DataGridView
    Friend WithEvents txtproveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNumProv As System.Windows.Forms.Label
    Friend WithEvents btnEliminarProv As System.Windows.Forms.Button
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
End Class
