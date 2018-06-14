<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_proveedor
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.volver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(63, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Agregar/Modificar Proveedor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(63, 195)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 40)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Buscar Proveedor"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'volver
        '
        Me.volver.Location = New System.Drawing.Point(106, 130)
        Me.volver.Name = "volver"
        Me.volver.Size = New System.Drawing.Size(75, 36)
        Me.volver.TabIndex = 2
        Me.volver.Text = "Volver"
        Me.volver.UseVisualStyleBackColor = True
        '
        'Consulta_proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.volver)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Consulta_proveedor"
        Me.Text = "Consulta_proveedor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents volver As System.Windows.Forms.Button
End Class
