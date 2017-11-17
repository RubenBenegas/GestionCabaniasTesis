<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lstConsHuesped
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(lstConsHuesped))
        Me.dgvConsHuesped = New System.Windows.Forms.DataGridView
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.RectangleShape2 = New Cabañas.BotonCancelar
        Me.RectangleShape1 = New Cabañas.BotonAceptar
        CType(Me.dgvConsHuesped, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvConsHuesped
        '
        Me.dgvConsHuesped.AllowUserToAddRows = False
        Me.dgvConsHuesped.AllowUserToDeleteRows = False
        Me.dgvConsHuesped.AllowUserToResizeColumns = False
        Me.dgvConsHuesped.AllowUserToResizeRows = False
        Me.dgvConsHuesped.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvConsHuesped.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.dgvConsHuesped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsHuesped.Location = New System.Drawing.Point(13, 12)
        Me.dgvConsHuesped.MultiSelect = False
        Me.dgvConsHuesped.Name = "dgvConsHuesped"
        Me.dgvConsHuesped.ReadOnly = True
        Me.dgvConsHuesped.RowHeadersVisible = False
        Me.dgvConsHuesped.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsHuesped.Size = New System.Drawing.Size(408, 336)
        Me.dgvConsHuesped.TabIndex = 0
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(433, 387)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackgroundImage = CType(resources.GetObject("RectangleShape2.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.CornerRadius = 13
        Me.RectangleShape2.Location = New System.Drawing.Point(294, 356)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(80, 26)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackgroundImage = CType(resources.GetObject("RectangleShape1.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.CornerRadius = 13
        Me.RectangleShape1.Location = New System.Drawing.Point(194, 356)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(80, 26)
        '
        'lstConsHuesped
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(433, 387)
        Me.Controls.Add(Me.dgvConsHuesped)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "lstConsHuesped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "lstBuscarHuesped"
        CType(Me.dgvConsHuesped, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvConsHuesped As System.Windows.Forms.DataGridView
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Cabañas.BotonAceptar
    Friend WithEvents RectangleShape2 As Cabañas.BotonCancelar
End Class
