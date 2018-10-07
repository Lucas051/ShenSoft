<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buscar_proveedores
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
        Me.dgvbuscarprov = New System.Windows.Forms.DataGridView()
        Me.txtbuscarprov = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.Label()
        CType(Me.dgvbuscarprov, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvbuscarprov
        '
        Me.dgvbuscarprov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvbuscarprov.Location = New System.Drawing.Point(208, 12)
        Me.dgvbuscarprov.Name = "dgvbuscarprov"
        Me.dgvbuscarprov.Size = New System.Drawing.Size(729, 341)
        Me.dgvbuscarprov.TabIndex = 0
        '
        'txtbuscarprov
        '
        Me.txtbuscarprov.Location = New System.Drawing.Point(58, 35)
        Me.txtbuscarprov.Name = "txtbuscarprov"
        Me.txtbuscarprov.Size = New System.Drawing.Size(100, 20)
        Me.txtbuscarprov.TabIndex = 1
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(12, 38)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(40, 13)
        Me.ID.TabIndex = 2
        Me.ID.Text = "Buscar"
        '
        'Buscar_proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 416)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.txtbuscarprov)
        Me.Controls.Add(Me.dgvbuscarprov)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Buscar_proveedores"
        Me.Text = "Buscar_proveedores"
        CType(Me.dgvbuscarprov, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvbuscarprov As System.Windows.Forms.DataGridView
    Friend WithEvents txtbuscarprov As System.Windows.Forms.TextBox
    Friend WithEvents ID As System.Windows.Forms.Label
End Class
