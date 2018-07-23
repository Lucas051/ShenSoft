<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cobrar
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Vendedor = New System.Windows.Forms.Label()
        Me.imprimir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.devolver = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pagocon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBoxcliente = New System.Windows.Forms.TextBox()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.buscarCliente = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(85, 172)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 30
        '
        'Vendedor
        '
        Me.Vendedor.AutoSize = True
        Me.Vendedor.Location = New System.Drawing.Point(29, 175)
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.Size = New System.Drawing.Size(53, 13)
        Me.Vendedor.TabIndex = 29
        Me.Vendedor.Text = "Vendedor"
        '
        'imprimir
        '
        Me.imprimir.Location = New System.Drawing.Point(126, 385)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(75, 23)
        Me.imprimir.TabIndex = 25
        Me.imprimir.Text = "Imprimir"
        Me.imprimir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Cobrar Monto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(85, 258)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Total a pagar"
        '
        'devolver
        '
        Me.devolver.Location = New System.Drawing.Point(85, 345)
        Me.devolver.Name = "devolver"
        Me.devolver.Size = New System.Drawing.Size(100, 20)
        Me.devolver.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Devolver"
        '
        'pagocon
        '
        Me.pagocon.Location = New System.Drawing.Point(85, 302)
        Me.pagocon.Name = "pagocon"
        Me.pagocon.Size = New System.Drawing.Size(100, 20)
        Me.pagocon.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Pagó con"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(322, 391)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBoxcliente
        '
        Me.TextBoxcliente.Location = New System.Drawing.Point(85, 215)
        Me.TextBoxcliente.Name = "TextBoxcliente"
        Me.TextBoxcliente.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxcliente.TabIndex = 33
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Location = New System.Drawing.Point(40, 218)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Cliente.TabIndex = 32
        Me.Cliente.Text = "Cliente"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.proyecto.inicio.My.Resources.Resources.logoencamino1
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(411, 251)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'buscarCliente
        '
        Me.buscarCliente.Location = New System.Drawing.Point(191, 213)
        Me.buscarCliente.Name = "buscarCliente"
        Me.buscarCliente.Size = New System.Drawing.Size(100, 23)
        Me.buscarCliente.TabIndex = 35
        Me.buscarCliente.Text = "Buscar Cliente"
        Me.buscarCliente.UseVisualStyleBackColor = True
        '
        'Cobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 426)
        Me.Controls.Add(Me.buscarCliente)
        Me.Controls.Add(Me.TextBoxcliente)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Vendedor)
        Me.Controls.Add(Me.imprimir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.devolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pagocon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Cobrar"
        Me.Text = "Cobrar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Vendedor As System.Windows.Forms.Label
    Friend WithEvents imprimir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents devolver As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pagocon As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents TextBoxcliente As System.Windows.Forms.TextBox
    Friend WithEvents Cliente As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents buscarCliente As System.Windows.Forms.Button
End Class
=======
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cobrar
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Vendedor = New System.Windows.Forms.Label()
        Me.imprimir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.devolver = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pagocon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBoxcliente = New System.Windows.Forms.TextBox()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.buscarCliente = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(85, 172)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 30
        '
        'Vendedor
        '
        Me.Vendedor.AutoSize = True
        Me.Vendedor.Location = New System.Drawing.Point(29, 175)
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.Size = New System.Drawing.Size(53, 13)
        Me.Vendedor.TabIndex = 29
        Me.Vendedor.Text = "Vendedor"
        '
        'imprimir
        '
        Me.imprimir.Location = New System.Drawing.Point(126, 385)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(75, 23)
        Me.imprimir.TabIndex = 25
        Me.imprimir.Text = "Imprimir"
        Me.imprimir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Cobrar Monto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(85, 258)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Total a pagar"
        '
        'devolver
        '
        Me.devolver.Location = New System.Drawing.Point(85, 345)
        Me.devolver.Name = "devolver"
        Me.devolver.Size = New System.Drawing.Size(100, 20)
        Me.devolver.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Devolver"
        '
        'pagocon
        '
        Me.pagocon.Location = New System.Drawing.Point(85, 302)
        Me.pagocon.Name = "pagocon"
        Me.pagocon.Size = New System.Drawing.Size(100, 20)
        Me.pagocon.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Pagó con"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(322, 391)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBoxcliente
        '
        Me.TextBoxcliente.Location = New System.Drawing.Point(85, 215)
        Me.TextBoxcliente.Name = "TextBoxcliente"
        Me.TextBoxcliente.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxcliente.TabIndex = 33
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Location = New System.Drawing.Point(40, 218)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Cliente.TabIndex = 32
        Me.Cliente.Text = "Cliente"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.proyecto.inicio.My.Resources.Resources.logoencamino1
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(411, 251)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'buscarCliente
        '
        Me.buscarCliente.Location = New System.Drawing.Point(191, 213)
        Me.buscarCliente.Name = "buscarCliente"
        Me.buscarCliente.Size = New System.Drawing.Size(100, 23)
        Me.buscarCliente.TabIndex = 35
        Me.buscarCliente.Text = "Buscar Cliente"
        Me.buscarCliente.UseVisualStyleBackColor = True
        '
        'Cobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 426)
        Me.Controls.Add(Me.buscarCliente)
        Me.Controls.Add(Me.TextBoxcliente)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Vendedor)
        Me.Controls.Add(Me.imprimir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.devolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pagocon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Cobrar"
        Me.Text = "Cobrar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Vendedor As System.Windows.Forms.Label
    Friend WithEvents imprimir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents devolver As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pagocon As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents TextBoxcliente As System.Windows.Forms.TextBox
    Friend WithEvents Cliente As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents buscarCliente As System.Windows.Forms.Button
End Class
>>>>>>> b9ac1fc0ad416c297c35c829e7c17ad9a49cbaf6
=======
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cobrar
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Vendedor = New System.Windows.Forms.Label()
        Me.imprimir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.devolver = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pagocon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBoxcliente = New System.Windows.Forms.TextBox()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.buscarCliente = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(85, 172)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 30
        '
        'Vendedor
        '
        Me.Vendedor.AutoSize = True
        Me.Vendedor.Location = New System.Drawing.Point(29, 175)
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.Size = New System.Drawing.Size(53, 13)
        Me.Vendedor.TabIndex = 29
        Me.Vendedor.Text = "Vendedor"
        '
        'imprimir
        '
        Me.imprimir.Location = New System.Drawing.Point(126, 385)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(75, 23)
        Me.imprimir.TabIndex = 25
        Me.imprimir.Text = "Imprimir"
        Me.imprimir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Cobrar Monto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(85, 258)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Total a pagar"
        '
        'devolver
        '
        Me.devolver.Location = New System.Drawing.Point(85, 345)
        Me.devolver.Name = "devolver"
        Me.devolver.Size = New System.Drawing.Size(100, 20)
        Me.devolver.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Devolver"
        '
        'pagocon
        '
        Me.pagocon.Location = New System.Drawing.Point(85, 302)
        Me.pagocon.Name = "pagocon"
        Me.pagocon.Size = New System.Drawing.Size(100, 20)
        Me.pagocon.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Pagó con"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(322, 391)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBoxcliente
        '
        Me.TextBoxcliente.Location = New System.Drawing.Point(85, 215)
        Me.TextBoxcliente.Name = "TextBoxcliente"
        Me.TextBoxcliente.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxcliente.TabIndex = 33
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Location = New System.Drawing.Point(40, 218)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Cliente.TabIndex = 32
        Me.Cliente.Text = "Cliente"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.proyecto.inicio.My.Resources.Resources.logoencamino1
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(411, 251)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'buscarCliente
        '
        Me.buscarCliente.Location = New System.Drawing.Point(191, 213)
        Me.buscarCliente.Name = "buscarCliente"
        Me.buscarCliente.Size = New System.Drawing.Size(100, 23)
        Me.buscarCliente.TabIndex = 35
        Me.buscarCliente.Text = "Buscar Cliente"
        Me.buscarCliente.UseVisualStyleBackColor = True
        '
        'Cobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 426)
        Me.Controls.Add(Me.buscarCliente)
        Me.Controls.Add(Me.TextBoxcliente)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Vendedor)
        Me.Controls.Add(Me.imprimir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.devolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pagocon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Cobrar"
        Me.Text = "Cobrar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Vendedor As System.Windows.Forms.Label
    Friend WithEvents imprimir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents devolver As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pagocon As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents TextBoxcliente As System.Windows.Forms.TextBox
    Friend WithEvents Cliente As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents buscarCliente As System.Windows.Forms.Button
End Class
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
=======
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cobrar
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Vendedor = New System.Windows.Forms.Label()
        Me.imprimir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.devolver = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pagocon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBoxcliente = New System.Windows.Forms.TextBox()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.buscarCliente = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(85, 172)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 30
        '
        'Vendedor
        '
        Me.Vendedor.AutoSize = True
        Me.Vendedor.Location = New System.Drawing.Point(29, 175)
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.Size = New System.Drawing.Size(53, 13)
        Me.Vendedor.TabIndex = 29
        Me.Vendedor.Text = "Vendedor"
        '
        'imprimir
        '
        Me.imprimir.Location = New System.Drawing.Point(126, 385)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(75, 23)
        Me.imprimir.TabIndex = 25
        Me.imprimir.Text = "Imprimir"
        Me.imprimir.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Cobrar Monto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(85, 258)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Total a pagar"
        '
        'devolver
        '
        Me.devolver.Location = New System.Drawing.Point(85, 345)
        Me.devolver.Name = "devolver"
        Me.devolver.Size = New System.Drawing.Size(100, 20)
        Me.devolver.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Devolver"
        '
        'pagocon
        '
        Me.pagocon.Location = New System.Drawing.Point(85, 302)
        Me.pagocon.Name = "pagocon"
        Me.pagocon.Size = New System.Drawing.Size(100, 20)
        Me.pagocon.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Pagó con"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(322, 391)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Volver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBoxcliente
        '
        Me.TextBoxcliente.Location = New System.Drawing.Point(85, 215)
        Me.TextBoxcliente.Name = "TextBoxcliente"
        Me.TextBoxcliente.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxcliente.TabIndex = 33
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Location = New System.Drawing.Point(40, 218)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Cliente.TabIndex = 32
        Me.Cliente.Text = "Cliente"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.proyecto.inicio.My.Resources.Resources.logoencamino1
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(411, 251)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'buscarCliente
        '
        Me.buscarCliente.Location = New System.Drawing.Point(191, 213)
        Me.buscarCliente.Name = "buscarCliente"
        Me.buscarCliente.Size = New System.Drawing.Size(100, 23)
        Me.buscarCliente.TabIndex = 35
        Me.buscarCliente.Text = "Buscar Cliente"
        Me.buscarCliente.UseVisualStyleBackColor = True
        '
        'Cobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 426)
        Me.Controls.Add(Me.buscarCliente)
        Me.Controls.Add(Me.TextBoxcliente)
        Me.Controls.Add(Me.Cliente)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Vendedor)
        Me.Controls.Add(Me.imprimir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.devolver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pagocon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Cobrar"
        Me.Text = "Cobrar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Vendedor As System.Windows.Forms.Label
    Friend WithEvents imprimir As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents devolver As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pagocon As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents TextBoxcliente As System.Windows.Forms.TextBox
    Friend WithEvents Cliente As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents buscarCliente As System.Windows.Forms.Button
End Class
>>>>>>> 62e125c36027cfa6bb4448f5a34b20b073f6979e
=======
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cobrar
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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.devolver = New System.Windows.Forms.TextBox()
        Me.pagocon = New System.Windows.Forms.TextBox()
        Me.TextBoxcliente = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnmini = New System.Windows.Forms.PictureBox()
        Me.barratitulo = New System.Windows.Forms.Panel()
        Me.cerrarbtn = New System.Windows.Forms.PictureBox()
        Me.btnrestaurar = New System.Windows.Forms.PictureBox()
        Me.btnmaxi = New System.Windows.Forms.PictureBox()
        Me.cobrarmontobtn = New System.Windows.Forms.Button()
        Me.buscarCliente = New System.Windows.Forms.Button()
        Me.cod = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.imprimirbtn = New System.Windows.Forms.Button()
        Me.atras = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.barratitulo.SuspendLayout()
        CType(Me.cerrarbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnrestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmaxi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(134, 213)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 30
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(134, 297)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(100, 20)
        Me.total.TabIndex = 22
        '
        'devolver
        '
        Me.devolver.Location = New System.Drawing.Point(134, 384)
        Me.devolver.Name = "devolver"
        Me.devolver.Size = New System.Drawing.Size(100, 20)
        Me.devolver.TabIndex = 20
        '
        'pagocon
        '
        Me.pagocon.Location = New System.Drawing.Point(134, 341)
        Me.pagocon.Name = "pagocon"
        Me.pagocon.Size = New System.Drawing.Size(100, 20)
        Me.pagocon.TabIndex = 18
        '
        'TextBoxcliente
        '
        Me.TextBoxcliente.Location = New System.Drawing.Point(134, 254)
        Me.TextBoxcliente.Name = "TextBoxcliente"
        Me.TextBoxcliente.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxcliente.TabIndex = 33
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.proyecto.inicio.My.Resources.Resources.logoencamino1
        Me.PictureBox1.Location = New System.Drawing.Point(-19, -13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(440, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(10, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 19)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "La Pollería - Guardar e Imprimir"
        '
        'btnmini
        '
        Me.btnmini.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmini.Image = Global.proyecto.inicio.My.Resources.Resources.minimazar
        Me.btnmini.Location = New System.Drawing.Point(322, 5)
        Me.btnmini.Name = "btnmini"
        Me.btnmini.Size = New System.Drawing.Size(25, 25)
        Me.btnmini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmini.TabIndex = 1
        Me.btnmini.TabStop = False
        '
        'barratitulo
        '
        Me.barratitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.barratitulo.Controls.Add(Me.Label4)
        Me.barratitulo.Controls.Add(Me.btnmini)
        Me.barratitulo.Controls.Add(Me.cerrarbtn)
        Me.barratitulo.Controls.Add(Me.btnrestaurar)
        Me.barratitulo.Controls.Add(Me.btnmaxi)
        Me.barratitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.barratitulo.Location = New System.Drawing.Point(0, 0)
        Me.barratitulo.Name = "barratitulo"
        Me.barratitulo.Size = New System.Drawing.Size(415, 35)
        Me.barratitulo.TabIndex = 37
        '
        'cerrarbtn
        '
        Me.cerrarbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cerrarbtn.Image = Global.proyecto.inicio.My.Resources.Resources.cerrar
        Me.cerrarbtn.Location = New System.Drawing.Point(384, 5)
        Me.cerrarbtn.Name = "cerrarbtn"
        Me.cerrarbtn.Size = New System.Drawing.Size(25, 25)
        Me.cerrarbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cerrarbtn.TabIndex = 0
        Me.cerrarbtn.TabStop = False
        '
        'btnrestaurar
        '
        Me.btnrestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnrestaurar.Image = Global.proyecto.inicio.My.Resources.Resources.res
        Me.btnrestaurar.Location = New System.Drawing.Point(353, 5)
        Me.btnrestaurar.Name = "btnrestaurar"
        Me.btnrestaurar.Size = New System.Drawing.Size(25, 25)
        Me.btnrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnrestaurar.TabIndex = 3
        Me.btnrestaurar.TabStop = False
        Me.btnrestaurar.Visible = False
        '
        'btnmaxi
        '
        Me.btnmaxi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmaxi.Image = Global.proyecto.inicio.My.Resources.Resources.maxi
        Me.btnmaxi.Location = New System.Drawing.Point(353, 5)
        Me.btnmaxi.Name = "btnmaxi"
        Me.btnmaxi.Size = New System.Drawing.Size(25, 25)
        Me.btnmaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmaxi.TabIndex = 2
        Me.btnmaxi.TabStop = False
        '
        'cobrarmontobtn
        '
        Me.cobrarmontobtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cobrarmontobtn.FlatAppearance.BorderSize = 0
        Me.cobrarmontobtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.cobrarmontobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cobrarmontobtn.Font = New System.Drawing.Font("Bahnschrift Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cobrarmontobtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cobrarmontobtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cobrarmontobtn.Location = New System.Drawing.Point(28, 426)
        Me.cobrarmontobtn.Name = "cobrarmontobtn"
        Me.cobrarmontobtn.Size = New System.Drawing.Size(124, 26)
        Me.cobrarmontobtn.TabIndex = 50
        Me.cobrarmontobtn.Text = "Cobrar Monto"
        Me.cobrarmontobtn.UseVisualStyleBackColor = False
        '
        'buscarCliente
        '
        Me.buscarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.buscarCliente.FlatAppearance.BorderSize = 0
        Me.buscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.buscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buscarCliente.Font = New System.Drawing.Font("Bahnschrift Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.buscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buscarCliente.Location = New System.Drawing.Point(249, 250)
        Me.buscarCliente.Name = "buscarCliente"
        Me.buscarCliente.Size = New System.Drawing.Size(128, 27)
        Me.buscarCliente.TabIndex = 51
        Me.buscarCliente.Text = "Buscar Cliente"
        Me.buscarCliente.UseVisualStyleBackColor = False
        '
        'cod
        '
        Me.cod.AutoSize = True
        Me.cod.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.cod.Location = New System.Drawing.Point(47, 215)
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(71, 18)
        Me.cod.TabIndex = 52
        Me.cod.Text = "Vendedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(25, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 18)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Total a Pagar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(64, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 18)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Cliente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(51, 340)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 18)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Pagó con"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(51, 386)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 18)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Devolver"
        '
        'imprimirbtn
        '
        Me.imprimirbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.imprimirbtn.FlatAppearance.BorderSize = 0
        Me.imprimirbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.imprimirbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.imprimirbtn.Font = New System.Drawing.Font("Bahnschrift Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imprimirbtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.imprimirbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.imprimirbtn.Location = New System.Drawing.Point(170, 426)
        Me.imprimirbtn.Name = "imprimirbtn"
        Me.imprimirbtn.Size = New System.Drawing.Size(80, 26)
        Me.imprimirbtn.TabIndex = 57
        Me.imprimirbtn.Text = "Imprimir"
        Me.imprimirbtn.UseVisualStyleBackColor = False
        '
        'atras
        '
        Me.atras.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.atras.FlatAppearance.BorderSize = 0
        Me.atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.atras.Font = New System.Drawing.Font("Bahnschrift Light", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atras.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.atras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.atras.Location = New System.Drawing.Point(322, 447)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(80, 26)
        Me.atras.TabIndex = 58
        Me.atras.Text = "Atrás"
        Me.atras.UseVisualStyleBackColor = False
        '
        'Cobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(415, 485)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.imprimirbtn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cod)
        Me.Controls.Add(Me.buscarCliente)
        Me.Controls.Add(Me.cobrarmontobtn)
        Me.Controls.Add(Me.barratitulo)
        Me.Controls.Add(Me.TextBoxcliente)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.devolver)
        Me.Controls.Add(Me.pagocon)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cobrar"
        Me.Text = "Cobrar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.barratitulo.ResumeLayout(False)
        Me.barratitulo.PerformLayout()
        CType(Me.cerrarbtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnrestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmaxi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents devolver As System.Windows.Forms.TextBox
    Friend WithEvents pagocon As System.Windows.Forms.TextBox
    Public WithEvents TextBoxcliente As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnmini As System.Windows.Forms.PictureBox
    Friend WithEvents barratitulo As System.Windows.Forms.Panel
    Friend WithEvents cerrarbtn As System.Windows.Forms.PictureBox
    Friend WithEvents btnmaxi As System.Windows.Forms.PictureBox
    Friend WithEvents btnrestaurar As System.Windows.Forms.PictureBox
    Friend WithEvents cobrarmontobtn As System.Windows.Forms.Button
    Friend WithEvents buscarCliente As System.Windows.Forms.Button
    Friend WithEvents cod As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents imprimirbtn As System.Windows.Forms.Button
    Friend WithEvents atras As System.Windows.Forms.Button
End Class
>>>>>>> d19429f7d8081b4cb9859b313d55c7febe1d6b68
