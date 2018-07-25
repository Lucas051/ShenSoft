<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EliminarStock
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
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStock
        '
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStock.Location = New System.Drawing.Point(12, 12)
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.Size = New System.Drawing.Size(443, 248)
        Me.dgvStock.TabIndex = 0
        '
        'EliminarStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 261)
        Me.Controls.Add(Me.dgvStock)
        Me.Name = "EliminarStock"
        Me.Text = "EliminarStock"
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvStock As System.Windows.Forms.DataGridView
End Class
