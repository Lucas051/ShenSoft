<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlantillaInicio
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
        Me.components = New System.ComponentModel.Container()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.DTPickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.TimerHora = New System.Windows.Forms.Timer(Me.components)
        Me.lblMinuto = New System.Windows.Forms.Label()
        Me.lblAMPM = New System.Windows.Forms.Label()
        Me.lblSegundos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFecha.Location = New System.Drawing.Point(319, 306)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(64, 24)
        Me.lblFecha.TabIndex = 17
        Me.lblFecha.Text = "Fecha"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblHora.Font = New System.Drawing.Font("Bahnschrift", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.White
        Me.lblHora.Location = New System.Drawing.Point(313, 191)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(87, 58)
        Me.lblHora.TabIndex = 15
        Me.lblHora.Text = "00:"
        '
        'DTPickerFecha
        '
        Me.DTPickerFecha.Location = New System.Drawing.Point(39, 12)
        Me.DTPickerFecha.Name = "DTPickerFecha"
        Me.DTPickerFecha.Size = New System.Drawing.Size(200, 20)
        Me.DTPickerFecha.TabIndex = 16
        Me.DTPickerFecha.Visible = False
        '
        'TimerHora
        '
        Me.TimerHora.Enabled = True
        Me.TimerHora.Interval = 1000
        '
        'lblMinuto
        '
        Me.lblMinuto.AutoSize = True
        Me.lblMinuto.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblMinuto.Font = New System.Drawing.Font("Bahnschrift Condensed", 33.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinuto.ForeColor = System.Drawing.Color.White
        Me.lblMinuto.Location = New System.Drawing.Point(383, 196)
        Me.lblMinuto.Name = "lblMinuto"
        Me.lblMinuto.Size = New System.Drawing.Size(59, 53)
        Me.lblMinuto.TabIndex = 18
        Me.lblMinuto.Text = "00"
        '
        'lblAMPM
        '
        Me.lblAMPM.AutoSize = True
        Me.lblAMPM.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblAMPM.Font = New System.Drawing.Font("Bahnschrift Condensed", 33.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAMPM.ForeColor = System.Drawing.Color.White
        Me.lblAMPM.Location = New System.Drawing.Point(431, 143)
        Me.lblAMPM.Name = "lblAMPM"
        Me.lblAMPM.Size = New System.Drawing.Size(66, 53)
        Me.lblAMPM.TabIndex = 19
        Me.lblAMPM.Text = "AM"
        '
        'lblSegundos
        '
        Me.lblSegundos.AutoSize = True
        Me.lblSegundos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblSegundos.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundos.ForeColor = System.Drawing.Color.White
        Me.lblSegundos.Location = New System.Drawing.Point(434, 212)
        Me.lblSegundos.Name = "lblSegundos"
        Me.lblSegundos.Size = New System.Drawing.Size(37, 33)
        Me.lblSegundos.TabIndex = 20
        Me.lblSegundos.Text = "00"
        '
        'PlantillaInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(895, 555)
        Me.Controls.Add(Me.lblSegundos)
        Me.Controls.Add(Me.lblAMPM)
        Me.Controls.Add(Me.lblMinuto)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.DTPickerFecha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PlantillaInicio"
        Me.Text = "PlantillaInicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents DTPickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TimerHora As System.Windows.Forms.Timer
    Friend WithEvents lblMinuto As System.Windows.Forms.Label
    Friend WithEvents lblAMPM As System.Windows.Forms.Label
    Friend WithEvents lblSegundos As System.Windows.Forms.Label
End Class
