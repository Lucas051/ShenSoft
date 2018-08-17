<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarClientesFact
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
        Me.dcvclientesFac = New System.Windows.Forms.DataGridView()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombrec = New System.Windows.Forms.TextBox()
        Me.txtcodigoc = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.Label()
        Me.txtbuscarc = New System.Windows.Forms.TextBox()
        CType(Me.dcvclientesFac, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dcvclientesFac
        '
        Me.dcvclientesFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dcvclientesFac.Location = New System.Drawing.Point(249, 2)
        Me.dcvclientesFac.Name = "dcvclientesFac"
        Me.dcvclientesFac.Size = New System.Drawing.Size(439, 231)
        Me.dcvclientesFac.TabIndex = 0
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(371, 257)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(75, 23)
        Me.btnvolver.TabIndex = 1
        Me.btnvolver.Text = "Volver"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(164, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Buscar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(164, 159)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Codigo"
        '
        'txtnombrec
        '
        Me.txtnombrec.Location = New System.Drawing.Point(58, 156)
        Me.txtnombrec.Name = "txtnombrec"
        Me.txtnombrec.Size = New System.Drawing.Size(100, 20)
        Me.txtnombrec.TabIndex = 12
        '
        'txtcodigoc
        '
        Me.txtcodigoc.Location = New System.Drawing.Point(58, 108)
        Me.txtcodigoc.Name = "txtcodigoc"
        Me.txtcodigoc.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigoc.TabIndex = 11
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
        'BuscarClientesFact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 292)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnombrec)
        Me.Controls.Add(Me.txtcodigoc)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.txtbuscarc)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.dcvclientesFac)
        Me.Name = "BuscarClientesFact"
        Me.Text = "BuscarClientesFact"
        CType(Me.dcvclientesFac, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dcvclientesFac As System.Windows.Forms.DataGridView
    Friend WithEvents btnvolver As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnombrec As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigoc As System.Windows.Forms.TextBox
    Friend WithEvents ID As System.Windows.Forms.Label
    Friend WithEvents txtbuscarc As System.Windows.Forms.TextBox
End Class
