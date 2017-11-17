<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lstGastos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lstGastos))
        Me.dgvGastos = New System.Windows.Forms.DataGridView
        Me.btnTodos = New System.Windows.Forms.Button
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.RectangleShape5 = New Cabañas.BotonBuscar
        Me.RectangleShape4 = New Cabañas.BotonCerrar
        Me.RectangleShape3 = New Cabañas.BotonEliminar
        Me.RectangleShape2 = New Cabañas.BotonModificar
        Me.RectangleShape1 = New Cabañas.BotonAgregar
        Me.cmbCategoria = New System.Windows.Forms.ComboBox
        CType(Me.dgvGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGastos
        '
        Me.dgvGastos.AllowUserToAddRows = False
        Me.dgvGastos.AllowUserToDeleteRows = False
        Me.dgvGastos.AllowUserToResizeColumns = False
        Me.dgvGastos.AllowUserToResizeRows = False
        Me.dgvGastos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvGastos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGastos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGastos.Location = New System.Drawing.Point(12, 48)
        Me.dgvGastos.MultiSelect = False
        Me.dgvGastos.Name = "dgvGastos"
        Me.dgvGastos.ReadOnly = True
        Me.dgvGastos.RowHeadersVisible = False
        Me.dgvGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGastos.Size = New System.Drawing.Size(960, 367)
        Me.dgvGastos.TabIndex = 0
        '
        'btnTodos
        '
        Me.btnTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTodos.ForeColor = System.Drawing.Color.White
        Me.btnTodos.Location = New System.Drawing.Point(230, 13)
        Me.btnTodos.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTodos.Name = "btnTodos"
        Me.btnTodos.Size = New System.Drawing.Size(47, 30)
        Me.btnTodos.TabIndex = 7
        Me.btnTodos.Text = "X"
        Me.btnTodos.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(547, 434)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(137, 20)
        Me.txtTotal.TabIndex = 9
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(494, 437)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Costo:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5, Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(984, 461)
        Me.ShapeContainer1.TabIndex = 15
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape5
        '
        Me.RectangleShape5.BackgroundImage = CType(resources.GetObject("RectangleShape5.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape5.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape5.CornerRadius = 13
        Me.RectangleShape5.Location = New System.Drawing.Point(149, 13)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(80, 26)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackgroundImage = CType(resources.GetObject("RectangleShape4.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape4.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape4.CornerRadius = 17
        Me.RectangleShape4.Location = New System.Drawing.Point(844, 419)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(122, 35)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackgroundImage = CType(resources.GetObject("RectangleShape3.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape3.CornerRadius = 17
        Me.RectangleShape3.Location = New System.Drawing.Point(258, 419)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(122, 35)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackgroundImage = CType(resources.GetObject("RectangleShape2.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.CornerRadius = 17
        Me.RectangleShape2.Location = New System.Drawing.Point(134, 419)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(122, 35)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackgroundImage = CType(resources.GetObject("RectangleShape1.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.CornerRadius = 17
        Me.RectangleShape1.Location = New System.Drawing.Point(10, 418)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(122, 35)
        '
        'cmbCategoria
        '
        Me.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(10, 12)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(121, 23)
        Me.cmbCategoria.TabIndex = 16
        '
        'lstGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnTodos)
        Me.Controls.Add(Me.dgvGastos)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(500, 300)
        Me.Name = "lstGastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista gastos"
        CType(Me.dgvGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvGastos As System.Windows.Forms.DataGridView
    Friend WithEvents btnTodos As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Cabañas.BotonAgregar
    Friend WithEvents RectangleShape3 As Cabañas.BotonEliminar
    Friend WithEvents RectangleShape2 As Cabañas.BotonModificar
    Friend WithEvents RectangleShape4 As Cabañas.BotonCerrar
    Friend WithEvents cmbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents RectangleShape5 As Cabañas.BotonBuscar
End Class
