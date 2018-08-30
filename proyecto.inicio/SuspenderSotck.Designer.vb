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
        Me.dgvEliminar = New System.Windows.Forms.DataGridView()
        Me.btnsuspender = New System.Windows.Forms.Button()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEliminar
        '
        Me.dgvEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEliminar.Location = New System.Drawing.Point(12, 53)
        Me.dgvEliminar.Name = "dgvEliminar"
        Me.dgvEliminar.ReadOnly = True
        Me.dgvEliminar.Size = New System.Drawing.Size(552, 287)
        Me.dgvEliminar.TabIndex = 0
        Me.dgvEliminar.UseWaitCursor = True
        '
        'btnsuspender
        '
        Me.btnsuspender.Location = New System.Drawing.Point(618, 156)
        Me.btnsuspender.Name = "btnsuspender"
        Me.btnsuspender.Size = New System.Drawing.Size(75, 60)
        Me.btnsuspender.TabIndex = 4
        Me.btnsuspender.Text = "Suspender"
        Me.btnsuspender.UseVisualStyleBackColor = True
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(611, 95)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(611, 240)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 56)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Mostrar Datos Suspendidos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(29, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Modificar Stock"
        '
        'SuspenderStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(748, 352)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.btnsuspender)
        Me.Controls.Add(Me.dgvEliminar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SuspenderStock"
        Me.Text = "SuspenderSotck"
        CType(Me.dgvEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvEliminar As System.Windows.Forms.DataGridView
    Friend WithEvents btnsuspender As System.Windows.Forms.Button
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
