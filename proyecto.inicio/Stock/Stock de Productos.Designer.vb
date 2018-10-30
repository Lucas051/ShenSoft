<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock_de_Productos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.txtpreciocosto = New System.Windows.Forms.TextBox()
        Me.txtpreciostock = New System.Windows.Forms.TextBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvstock = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.txtbuscarStock = New System.Windows.Forms.TextBox()
        Me.lblbuscar = New System.Windows.Forms.Label()
        CType(Me.dgvstock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.Location = New System.Drawing.Point(127, 40)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(124, 24)
        Me.txtdescripcion.TabIndex = 1
        '
        'txtpreciocosto
        '
        Me.txtpreciocosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpreciocosto.Location = New System.Drawing.Point(390, 39)
        Me.txtpreciocosto.Multiline = True
        Me.txtpreciocosto.Name = "txtpreciocosto"
        Me.txtpreciocosto.Size = New System.Drawing.Size(124, 24)
        Me.txtpreciocosto.TabIndex = 3
        '
        'txtpreciostock
        '
        Me.txtpreciostock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpreciostock.Location = New System.Drawing.Point(390, 85)
        Me.txtpreciostock.Multiline = True
        Me.txtpreciostock.Name = "txtpreciostock"
        Me.txtpreciostock.Size = New System.Drawing.Size(124, 24)
        Me.txtpreciostock.TabIndex = 4
        '
        'txtcantidad
        '
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.Location = New System.Drawing.Point(127, 84)
        Me.txtcantidad.Multiline = True
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(124, 24)
        Me.txtcantidad.TabIndex = 2
        '
        'txtproveedor
        '
        Me.txtproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproveedor.Location = New System.Drawing.Point(692, 38)
        Me.txtproveedor.Multiline = True
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(135, 24)
        Me.txtproveedor.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(28, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 22)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Descripcion"
        '
        'dgvstock
        '
        Me.dgvstock.BackgroundColor = System.Drawing.Color.Silver
        Me.dgvstock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Bahnschrift Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvstock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvstock.ColumnHeadersHeight = 42
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvstock.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvstock.EnableHeadersVisualStyles = False
        Me.dgvstock.GridColor = System.Drawing.Color.White
        Me.dgvstock.Location = New System.Drawing.Point(32, 143)
        Me.dgvstock.Name = "dgvstock"
        Me.dgvstock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvstock.RowHeadersVisible = False
        Me.dgvstock.RowHeadersWidth = 50
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.dgvstock.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvstock.Size = New System.Drawing.Size(819, 353)
        Me.dgvstock.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(52, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 22)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(288, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 22)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Precio Costo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(269, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 22)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Precio de Venta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(547, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 22)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Num. Factura Prov."
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnagregar.FlatAppearance.BorderSize = 0
        Me.btnagregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnagregar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnagregar.Location = New System.Drawing.Point(551, 86)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(276, 26)
        Me.btnagregar.TabIndex = 43
        Me.btnagregar.Text = "Ingresar"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'txtbuscarStock
        '
        Me.txtbuscarStock.Location = New System.Drawing.Point(710, 502)
        Me.txtbuscarStock.Multiline = True
        Me.txtbuscarStock.Name = "txtbuscarStock"
        Me.txtbuscarStock.Size = New System.Drawing.Size(141, 25)
        Me.txtbuscarStock.TabIndex = 45
        '
        'lblbuscar
        '
        Me.lblbuscar.AutoSize = True
        Me.lblbuscar.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lblbuscar.Location = New System.Drawing.Point(631, 502)
        Me.lblbuscar.Name = "lblbuscar"
        Me.lblbuscar.Size = New System.Drawing.Size(61, 23)
        Me.lblbuscar.TabIndex = 44
        Me.lblbuscar.Text = "Buscar"
        '
        'Stock_de_Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(891, 667)
        Me.Controls.Add(Me.txtbuscarStock)
        Me.Controls.Add(Me.lblbuscar)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvstock)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtproveedor)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.txtpreciostock)
        Me.Controls.Add(Me.txtpreciocosto)
        Me.Controls.Add(Me.txtdescripcion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Stock_de_Productos"
        Me.Text = "Stock de Productos"
        CType(Me.dgvstock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtpreciocosto As System.Windows.Forms.TextBox
    Friend WithEvents txtpreciostock As System.Windows.Forms.TextBox
    Friend WithEvents txtcantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtproveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgvstock As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents txtbuscarStock As System.Windows.Forms.TextBox
    Friend WithEvents lblbuscar As System.Windows.Forms.Label
End Class
