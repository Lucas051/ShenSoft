﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MODIFICARCLIENTES
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.DgvClientes = New System.Windows.Forms.DataGridView()
        Me.txtsaldo = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnañadir = New System.Windows.Forms.Button()
        Me.btnborrar = New System.Windows.Forms.Button()
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(53, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Teléfono:"
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(108, 173)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(100, 20)
        Me.txttelefono.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(50, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Dirección:"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(108, 147)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtdireccion.TabIndex = 28
        '
        'DgvClientes
        '
        Me.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvClientes.Location = New System.Drawing.Point(239, 56)
        Me.DgvClientes.Name = "DgvClientes"
        Me.DgvClientes.ReadOnly = True
        Me.DgvClientes.Size = New System.Drawing.Size(673, 281)
        Me.DgvClientes.TabIndex = 27
        '
        'txtsaldo
        '
        Me.txtsaldo.Location = New System.Drawing.Point(108, 121)
        Me.txtsaldo.Name = "txtsaldo"
        Me.txtsaldo.Size = New System.Drawing.Size(100, 20)
        Me.txtsaldo.TabIndex = 24
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(108, 95)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(100, 20)
        Me.txtnombre.TabIndex = 23
        '
        'txtcedula
        '
        Me.txtcedula.Location = New System.Drawing.Point(108, 69)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(100, 20)
        Me.txtcedula.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(69, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Saldo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nombre Completo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Cédula:"
        '
        'btnañadir
        '
        Me.btnañadir.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnañadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnañadir.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnañadir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnañadir.Location = New System.Drawing.Point(25, 294)
        Me.btnañadir.Name = "btnañadir"
        Me.btnañadir.Size = New System.Drawing.Size(83, 34)
        Me.btnañadir.TabIndex = 32
        Me.btnañadir.Text = "Ingresar"
        Me.btnañadir.UseVisualStyleBackColor = False
        '
        'btnborrar
        '
        Me.btnborrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnborrar.Font = New System.Drawing.Font("Bahnschrift Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnborrar.Location = New System.Drawing.Point(108, 199)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(80, 28)
        Me.btnborrar.TabIndex = 33
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = False
        '
        'MODIFICARCLIENTES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 401)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.btnañadir)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.DgvClientes)
        Me.Controls.Add(Me.txtsaldo)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MODIFICARCLIENTES"
        Me.Text = "MODIFICARCLIENTES"
        CType(Me.DgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents DgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents txtsaldo As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtcedula As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnañadir As System.Windows.Forms.Button
    Friend WithEvents btnborrar As System.Windows.Forms.Button
End Class
