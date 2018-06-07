<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.atras = New System.Windows.Forms.Button()
        CType(Me.DataGridbuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridbuscar
        '
        Me.DataGridbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridbuscar.Location = New System.Drawing.Point(9, 26)
        Me.DataGridbuscar.Name = "DataGridbuscar"
        Me.DataGridbuscar.Size = New System.Drawing.Size(630, 211)
        Me.DataGridbuscar.TabIndex = 33
        '
        'atras
        '
        Me.atras.Location = New System.Drawing.Point(579, 258)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(75, 23)
        Me.atras.TabIndex = 34
        Me.atras.Text = "Volver"
        Me.atras.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 293)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.DataGridbuscar)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridbuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridbuscar As System.Windows.Forms.DataGridView
    Friend WithEvents atras As System.Windows.Forms.Button
End Class
