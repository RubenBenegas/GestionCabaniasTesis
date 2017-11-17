<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class grafReservas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(grafReservas))
        Me.flpContenedor = New System.Windows.Forms.FlowLayoutPanel
        Me.dtpfechaDesde = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaHasta = New System.Windows.Forms.DateTimePicker
        Me.flpCabanias = New System.Windows.Forms.FlowLayoutPanel
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.RectangleShape2 = New Cabañas.BotonActualizar
        Me.RectangleShape1 = New Cabañas.BotonNuevaReserva
        Me.btnListado = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'flpContenedor
        '
        Me.flpContenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpContenedor.AutoScroll = True
        Me.flpContenedor.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpContenedor.Location = New System.Drawing.Point(74, 38)
        Me.flpContenedor.Name = "flpContenedor"
        Me.flpContenedor.Size = New System.Drawing.Size(533, 432)
        Me.flpContenedor.TabIndex = 1
        '
        'dtpfechaDesde
        '
        Me.dtpfechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechaDesde.Location = New System.Drawing.Point(12, 12)
        Me.dtpfechaDesde.Name = "dtpfechaDesde"
        Me.dtpfechaDesde.Size = New System.Drawing.Size(108, 20)
        Me.dtpfechaDesde.TabIndex = 3
        '
        'dtpFechaHasta
        '
        Me.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHasta.Location = New System.Drawing.Point(126, 12)
        Me.dtpFechaHasta.Name = "dtpFechaHasta"
        Me.dtpFechaHasta.Size = New System.Drawing.Size(108, 20)
        Me.dtpFechaHasta.TabIndex = 4
        '
        'flpCabanias
        '
        Me.flpCabanias.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpCabanias.Location = New System.Drawing.Point(15, 38)
        Me.flpCabanias.Name = "flpCabanias"
        Me.flpCabanias.Size = New System.Drawing.Size(53, 432)
        Me.flpCabanias.TabIndex = 6
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(619, 531)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackgroundImage = CType(resources.GetObject("RectangleShape2.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.CornerRadius = 12
        Me.RectangleShape2.Location = New System.Drawing.Point(473, 8)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(110, 25)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackgroundImage = CType(resources.GetObject("RectangleShape1.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.CornerRadius = 15
        Me.RectangleShape1.Location = New System.Drawing.Point(34, 488)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(120, 30)
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(335, 488)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(75, 23)
        Me.btnListado.TabIndex = 8
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'grafReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(619, 531)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.flpCabanias)
        Me.Controls.Add(Me.dtpFechaHasta)
        Me.Controls.Add(Me.dtpfechaDesde)
        Me.Controls.Add(Me.flpContenedor)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "grafReservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "grafReservas"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents flpContenedor As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents dtpfechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents flpCabanias As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Cabañas.BotonNuevaReserva
    Friend WithEvents RectangleShape2 As Cabañas.BotonActualizar
    Friend WithEvents btnListado As System.Windows.Forms.Button
End Class
