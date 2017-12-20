<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lstAdicional
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lstAdicional))
        Me.DgvAdicionales = New System.Windows.Forms.DataGridView
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.RectangleShape4 = New Cabañas.BotonCerrar
        Me.RectangleShape3 = New Cabañas.BotonEliminar
        Me.RectangleShape2 = New Cabañas.BotonModificar
        Me.RectangleShape1 = New Cabañas.BotonAgregar
        Me.btnListado = New System.Windows.Forms.Button
        Me.btnDetalle = New System.Windows.Forms.Button
        CType(Me.DgvAdicionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvAdicionales
        '
        Me.DgvAdicionales.AllowUserToAddRows = False
        Me.DgvAdicionales.AllowUserToDeleteRows = False
        Me.DgvAdicionales.AllowUserToResizeColumns = False
        Me.DgvAdicionales.AllowUserToResizeRows = False
        Me.DgvAdicionales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvAdicionales.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvAdicionales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DgvAdicionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAdicionales.Location = New System.Drawing.Point(12, 12)
        Me.DgvAdicionales.MultiSelect = False
        Me.DgvAdicionales.Name = "DgvAdicionales"
        Me.DgvAdicionales.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvAdicionales.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DgvAdicionales.RowHeadersVisible = False
        Me.DgvAdicionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvAdicionales.Size = New System.Drawing.Size(960, 406)
        Me.DgvAdicionales.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(984, 461)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackgroundImage = CType(resources.GetObject("RectangleShape4.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape4.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape4.CornerRadius = 17
        Me.RectangleShape4.Location = New System.Drawing.Point(851, 420)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(122, 35)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackgroundImage = CType(resources.GetObject("RectangleShape3.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape3.CornerRadius = 17
        Me.RectangleShape3.Location = New System.Drawing.Point(254, 422)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(122, 35)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackgroundImage = CType(resources.GetObject("RectangleShape2.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.CornerRadius = 17
        Me.RectangleShape2.Location = New System.Drawing.Point(130, 422)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(122, 35)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackgroundImage = CType(resources.GetObject("RectangleShape1.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.CornerRadius = 17
        Me.RectangleShape1.Location = New System.Drawing.Point(5, 421)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(122, 35)
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(408, 426)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(75, 23)
        Me.btnListado.TabIndex = 2
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'btnDetalle
        '
        Me.btnDetalle.Location = New System.Drawing.Point(499, 426)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(75, 23)
        Me.btnDetalle.TabIndex = 3
        Me.btnDetalle.Text = "Detalle"
        Me.btnDetalle.UseVisualStyleBackColor = True
        '
        'lstAdicional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.btnDetalle)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.DgvAdicionales)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "lstAdicional"
        Me.Text = "lstAdicionales"
        CType(Me.DgvAdicionales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvAdicionales As System.Windows.Forms.DataGridView
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape4 As Cabañas.BotonCerrar
    Friend WithEvents RectangleShape3 As Cabañas.BotonEliminar
    Friend WithEvents RectangleShape2 As Cabañas.BotonModificar
    Friend WithEvents RectangleShape1 As Cabañas.BotonAgregar
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents btnDetalle As System.Windows.Forms.Button
End Class
