<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MODIFPROVEEDORES
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
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.dgvproveedores = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnvolver = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnañadir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtsaldo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvproveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(169, 97)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtdireccion.TabIndex = 27
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(169, 53)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(100, 20)
        Me.txttelefono.TabIndex = 26
        '
        'txtproveedor
        '
        Me.txtproveedor.Location = New System.Drawing.Point(169, 11)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(100, 20)
        Me.txtproveedor.TabIndex = 25
        '
        'dgvproveedores
        '
        Me.dgvproveedores.AllowUserToAddRows = False
        Me.dgvproveedores.AllowUserToDeleteRows = False
        Me.dgvproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvproveedores.Location = New System.Drawing.Point(40, 191)
        Me.dgvproveedores.Name = "dgvproveedores"
        Me.dgvproveedores.ReadOnly = True
        Me.dgvproveedores.Size = New System.Drawing.Size(443, 156)
        Me.dgvproveedores.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Dirección"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Teléfono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Proveedor"
        '
        'btnvolver
        '
        Me.btnvolver.Location = New System.Drawing.Point(611, 169)
        Me.btnvolver.Name = "btnvolver"
        Me.btnvolver.Size = New System.Drawing.Size(60, 152)
        Me.btnvolver.TabIndex = 18
        Me.btnvolver.Text = "VOLVER"
        Me.btnvolver.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(540, 90)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(65, 73)
        Me.btnlimpiar.TabIndex = 17
        Me.btnlimpiar.Text = "LIMPIAR"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btnborrar
        '
        Me.btnborrar.Location = New System.Drawing.Point(540, 248)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(65, 73)
        Me.btnborrar.TabIndex = 16
        Me.btnborrar.Text = "BORRAR"
        Me.btnborrar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Location = New System.Drawing.Point(540, 169)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(65, 73)
        Me.btneditar.TabIndex = 15
        Me.btneditar.Text = "EDITAR"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnañadir
        '
        Me.btnañadir.Location = New System.Drawing.Point(540, 11)
        Me.btnañadir.Name = "btnañadir"
        Me.btnañadir.Size = New System.Drawing.Size(65, 73)
        Me.btnañadir.TabIndex = 14
        Me.btnañadir.Text = "AÑADIR"
        Me.btnañadir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.proyecto.inicio.My.Resources.Resources.logoencamino1
        Me.PictureBox1.Location = New System.Drawing.Point(202, -58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(403, 287)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'txtsaldo
        '
        Me.txtsaldo.Location = New System.Drawing.Point(169, 137)
        Me.txtsaldo.Name = "txtsaldo"
        Me.txtsaldo.Size = New System.Drawing.Size(100, 20)
        Me.txtsaldo.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Saldo"
        '
        'MODIFPROVEEDORES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 346)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtsaldo)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtproveedor)
        Me.Controls.Add(Me.dgvproveedores)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnvolver)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btnañadir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "MODIFPROVEEDORES"
        Me.Text = "MODIFPROVEEDORES"
        CType(Me.dgvproveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtproveedor As System.Windows.Forms.TextBox
    Friend WithEvents dgvproveedores As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnvolver As System.Windows.Forms.Button
    Friend WithEvents btnlimpiar As System.Windows.Forms.Button
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents btneditar As System.Windows.Forms.Button
    Friend WithEvents btnañadir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtsaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
