<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuspenderStock
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
        Me.dgvEliminar = New System.Windows.Forms.DataGridView()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnsuspender = New System.Windows.Forms.Button()
        Me.btnMostrarStock = New System.Windows.Forms.Button()
        Me.btnCancelarSusp = New System.Windows.Forms.Button()
        CType(Me.dgvEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEliminar
        '
        Me.dgvEliminar.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvEliminar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEliminar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEliminar.ColumnHeadersHeight = 42
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEliminar.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEliminar.EnableHeadersVisualStyles = False
        Me.dgvEliminar.GridColor = System.Drawing.Color.White
        Me.dgvEliminar.Location = New System.Drawing.Point(33, 130)
        Me.dgvEliminar.Name = "dgvEliminar"
        Me.dgvEliminar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvEliminar.RowHeadersVisible = False
        Me.dgvEliminar.RowHeadersWidth = 50
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dgvEliminar.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEliminar.Size = New System.Drawing.Size(819, 412)
        Me.dgvEliminar.TabIndex = 36
        '
        'txtcodigo
        '
        Me.txtcodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(156, 27)
        Me.txtcodigo.Multiline = True
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(142, 25)
        Me.txtcodigo.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(33, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 22)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Ingresar Código"
        '
        'btnsuspender
        '
        Me.btnsuspender.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnsuspender.FlatAppearance.BorderSize = 0
        Me.btnsuspender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnsuspender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsuspender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsuspender.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnsuspender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnsuspender.Location = New System.Drawing.Point(338, 27)
        Me.btnsuspender.Name = "btnsuspender"
        Me.btnsuspender.Size = New System.Drawing.Size(198, 34)
        Me.btnsuspender.TabIndex = 80
        Me.btnsuspender.Text = "Suspender"
        Me.btnsuspender.UseVisualStyleBackColor = False
        '
        'btnMostrarStock
        '
        Me.btnMostrarStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMostrarStock.FlatAppearance.BorderSize = 0
        Me.btnMostrarStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnMostrarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarStock.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMostrarStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMostrarStock.Location = New System.Drawing.Point(654, 86)
        Me.btnMostrarStock.Name = "btnMostrarStock"
        Me.btnMostrarStock.Size = New System.Drawing.Size(198, 38)
        Me.btnMostrarStock.TabIndex = 81
        Me.btnMostrarStock.Text = "Mostrar Stock Suspendido"
        Me.btnMostrarStock.UseVisualStyleBackColor = False
        '
        'btnCancelarSusp
        '
        Me.btnCancelarSusp.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCancelarSusp.FlatAppearance.BorderSize = 0
        Me.btnCancelarSusp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCancelarSusp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarSusp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarSusp.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCancelarSusp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelarSusp.Location = New System.Drawing.Point(338, 67)
        Me.btnCancelarSusp.Name = "btnCancelarSusp"
        Me.btnCancelarSusp.Size = New System.Drawing.Size(198, 34)
        Me.btnCancelarSusp.TabIndex = 82
        Me.btnCancelarSusp.Text = "Cancelar Suspender"
        Me.btnCancelarSusp.UseVisualStyleBackColor = False
        '
        'SuspenderStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(891, 667)
        Me.Controls.Add(Me.btnCancelarSusp)
        Me.Controls.Add(Me.btnMostrarStock)
        Me.Controls.Add(Me.btnsuspender)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvEliminar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SuspenderStock"
        Me.Text = "SuspenderSotck"
        CType(Me.dgvEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvEliminar As System.Windows.Forms.DataGridView
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnsuspender As System.Windows.Forms.Button
    Friend WithEvents btnMostrarStock As System.Windows.Forms.Button
    Friend WithEvents btnCancelarSusp As System.Windows.Forms.Button
End Class
