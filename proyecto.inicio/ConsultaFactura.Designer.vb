<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaFactura
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
        Me.datagridconsulta = New System.Windows.Forms.DataGridView()
        Me.Atras = New System.Windows.Forms.Button()
        CType(Me.datagridconsulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagridconsulta
        '
        Me.datagridconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridconsulta.Location = New System.Drawing.Point(12, 42)
        Me.datagridconsulta.Name = "datagridconsulta"
        Me.datagridconsulta.Size = New System.Drawing.Size(195, 203)
        Me.datagridconsulta.TabIndex = 0
        '
        'Atras
        '
        Me.Atras.Location = New System.Drawing.Point(408, 243)
        Me.Atras.Name = "Atras"
        Me.Atras.Size = New System.Drawing.Size(75, 23)
        Me.Atras.TabIndex = 1
        Me.Atras.Text = "Atrás"
        Me.Atras.UseVisualStyleBackColor = True
        '
        'ConsultaFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 278)
        Me.Controls.Add(Me.Atras)
        Me.Controls.Add(Me.datagridconsulta)
        Me.Name = "ConsultaFactura"
        Me.Text = "ConsultaFactura"
        CType(Me.datagridconsulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents datagridconsulta As System.Windows.Forms.DataGridView
    Friend WithEvents Atras As System.Windows.Forms.Button
End Class
