<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarClientes
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
        Me.dcvclientes = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.Label()
        Me.txtbuscarc = New System.Windows.Forms.TextBox()
        CType(Me.dcvclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dcvclientes
        '
        Me.dcvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dcvclientes.Location = New System.Drawing.Point(231, 12)
        Me.dcvclientes.Name = "dcvclientes"
        Me.dcvclientes.Size = New System.Drawing.Size(697, 330)
        Me.dcvclientes.TabIndex = 0
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(12, 46)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(40, 13)
        Me.ID.TabIndex = 10
        Me.ID.Text = "Buscar"
        '
        'txtbuscarc
        '
        Me.txtbuscarc.Location = New System.Drawing.Point(58, 46)
        Me.txtbuscarc.Name = "txtbuscarc"
        Me.txtbuscarc.Size = New System.Drawing.Size(100, 20)
        Me.txtbuscarc.TabIndex = 9
        '
        'BuscarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 405)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.txtbuscarc)
        Me.Controls.Add(Me.dcvclientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BuscarClientes"
        Me.Text = "BuscarClientesFact"
        CType(Me.dcvclientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dcvclientes As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.Label
    Friend WithEvents txtbuscarc As System.Windows.Forms.TextBox
End Class
