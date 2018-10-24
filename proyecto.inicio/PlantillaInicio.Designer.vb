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
        Me.lblHora = New System.Windows.Forms.Label()
        Me.DTPickerFecha = New System.Windows.Forms.DateTimePicker()
        Me.TimerHora = New System.Windows.Forms.Timer(Me.components)
        Me.lblMinuto = New System.Windows.Forms.Label()
        Me.lblAMPM = New System.Windows.Forms.Label()
        Me.lblSegundos = New System.Windows.Forms.Label()
        Me.TimerAMPM = New System.Windows.Forms.Timer(Me.components)
        Me.TimerFecha = New System.Windows.Forms.Timer(Me.components)
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTelefonos = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblHora.Font = New System.Drawing.Font("Bahnschrift Condensed", 55.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.White
        Me.lblHora.Location = New System.Drawing.Point(265, 174)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(0, 89)
        Me.lblHora.TabIndex = 15
        '
        'DTPickerFecha
        '
        Me.DTPickerFecha.Location = New System.Drawing.Point(683, 12)
        Me.DTPickerFecha.Name = "DTPickerFecha"
        Me.DTPickerFecha.Size = New System.Drawing.Size(200, 20)
        Me.DTPickerFecha.TabIndex = 16
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
        Me.lblMinuto.Font = New System.Drawing.Font("Bahnschrift Condensed", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinuto.ForeColor = System.Drawing.Color.White
        Me.lblMinuto.Location = New System.Drawing.Point(357, 191)
        Me.lblMinuto.Name = "lblMinuto"
        Me.lblMinuto.Size = New System.Drawing.Size(0, 68)
        Me.lblMinuto.TabIndex = 18
        '
        'lblAMPM
        '
        Me.lblAMPM.AutoSize = True
        Me.lblAMPM.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblAMPM.Font = New System.Drawing.Font("Bahnschrift Condensed", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAMPM.ForeColor = System.Drawing.Color.White
        Me.lblAMPM.Location = New System.Drawing.Point(430, 181)
        Me.lblAMPM.Name = "lblAMPM"
        Me.lblAMPM.Size = New System.Drawing.Size(0, 33)
        Me.lblAMPM.TabIndex = 19
        '
        'lblSegundos
        '
        Me.lblSegundos.AutoSize = True
        Me.lblSegundos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblSegundos.Font = New System.Drawing.Font("Bahnschrift Condensed", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundos.ForeColor = System.Drawing.Color.White
        Me.lblSegundos.Location = New System.Drawing.Point(429, 214)
        Me.lblSegundos.Name = "lblSegundos"
        Me.lblSegundos.Size = New System.Drawing.Size(0, 41)
        Me.lblSegundos.TabIndex = 20
        '
        'TimerAMPM
        '
        Me.TimerAMPM.Enabled = True
        Me.TimerAMPM.Interval = 1
        '
        'TimerFecha
        '
        Me.TimerFecha.Enabled = True
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Bahnschrift Condensed", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(253, 263)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(0, 27)
        Me.lblFecha.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.proyecto.inicio.My.Resources.Resources.relojazul
        Me.PictureBox1.Location = New System.Drawing.Point(48, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(659, 377)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'lblTelefonos
        '
        Me.lblTelefonos.AutoSize = True
        Me.lblTelefonos.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonos.ForeColor = System.Drawing.Color.White
        Me.lblTelefonos.Location = New System.Drawing.Point(201, 505)
        Me.lblTelefonos.Name = "lblTelefonos"
        Me.lblTelefonos.Size = New System.Drawing.Size(362, 41)
        Me.lblTelefonos.TabIndex = 23
        Me.lblTelefonos.Text = "Tel.: 473 22722 Cel.: 092 165 355"
        '
        'PlantillaInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(895, 555)
        Me.Controls.Add(Me.lblTelefonos)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblSegundos)
        Me.Controls.Add(Me.lblAMPM)
        Me.Controls.Add(Me.lblMinuto)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.DTPickerFecha)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PlantillaInicio"
        Me.Text = "PlantillaInicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents DTPickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TimerHora As System.Windows.Forms.Timer
    Friend WithEvents lblMinuto As System.Windows.Forms.Label
    Friend WithEvents lblAMPM As System.Windows.Forms.Label
    Friend WithEvents lblSegundos As System.Windows.Forms.Label
    Friend WithEvents TimerAMPM As System.Windows.Forms.Timer
    Friend WithEvents TimerFecha As System.Windows.Forms.Timer
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTelefonos As System.Windows.Forms.Label
End Class
