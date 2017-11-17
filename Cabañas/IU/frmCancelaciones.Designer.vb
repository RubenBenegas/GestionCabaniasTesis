<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCancelaciones
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCancelaciones))
        Me.lblId = New System.Windows.Forms.Label
        Me.lblFechaCancelacion = New System.Windows.Forms.Label
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.dtpFechaCancelacion = New System.Windows.Forms.DateTimePicker
        Me.lblReembolso = New System.Windows.Forms.Label
        Me.txtReembolso = New System.Windows.Forms.TextBox
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.RectangleShape3 = New Cabañas.BotonCancelar
        Me.RectangleShape2 = New Cabañas.BotonAceptar
        Me.RectangleShape1 = New Cabañas.BotonAceptar
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.White
        Me.lblId.Location = New System.Drawing.Point(12, 9)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(22, 13)
        Me.lblId.TabIndex = 2
        Me.lblId.Text = "Id:"
        '
        'lblFechaCancelacion
        '
        Me.lblFechaCancelacion.AutoSize = True
        Me.lblFechaCancelacion.BackColor = System.Drawing.Color.Transparent
        Me.lblFechaCancelacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaCancelacion.ForeColor = System.Drawing.Color.White
        Me.lblFechaCancelacion.Location = New System.Drawing.Point(12, 48)
        Me.lblFechaCancelacion.Name = "lblFechaCancelacion"
        Me.lblFechaCancelacion.Size = New System.Drawing.Size(120, 13)
        Me.lblFechaCancelacion.TabIndex = 3
        Me.lblFechaCancelacion.Text = "Fecha Cancelacion:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.White
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 75)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(78, 13)
        Me.lblDescripcion.TabIndex = 4
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(138, 6)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(53, 20)
        Me.txtId.TabIndex = 5
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(138, 72)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(188, 97)
        Me.txtDescripcion.TabIndex = 6
        Me.txtDescripcion.Tag = "*"
        '
        'dtpFechaCancelacion
        '
        Me.dtpFechaCancelacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCancelacion.Location = New System.Drawing.Point(139, 42)
        Me.dtpFechaCancelacion.Name = "dtpFechaCancelacion"
        Me.dtpFechaCancelacion.Size = New System.Drawing.Size(99, 20)
        Me.dtpFechaCancelacion.TabIndex = 7
        '
        'lblReembolso
        '
        Me.lblReembolso.AutoSize = True
        Me.lblReembolso.BackColor = System.Drawing.Color.Transparent
        Me.lblReembolso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReembolso.ForeColor = System.Drawing.Color.White
        Me.lblReembolso.Location = New System.Drawing.Point(12, 185)
        Me.lblReembolso.Name = "lblReembolso"
        Me.lblReembolso.Size = New System.Drawing.Size(73, 13)
        Me.lblReembolso.TabIndex = 9
        Me.lblReembolso.Text = "Reembolso:"
        '
        'txtReembolso
        '
        Me.txtReembolso.Location = New System.Drawing.Point(139, 182)
        Me.txtReembolso.Name = "txtReembolso"
        Me.txtReembolso.Size = New System.Drawing.Size(100, 20)
        Me.txtReembolso.TabIndex = 10
        Me.txtReembolso.Tag = "*"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(344, 264)
        Me.ShapeContainer1.TabIndex = 11
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackgroundImage = CType(resources.GetObject("RectangleShape3.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape3.CornerRadius = 13
        Me.RectangleShape3.Location = New System.Drawing.Point(206, 231)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(80, 26)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackgroundImage = CType(resources.GetObject("RectangleShape2.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.CornerRadius = 13
        Me.RectangleShape2.Location = New System.Drawing.Point(136, 231)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(80, 26)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackgroundImage = CType(resources.GetObject("RectangleShape1.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.CornerRadius = 13
        Me.RectangleShape1.Location = New System.Drawing.Point(73, 231)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(80, 26)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmCancelaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.ClientSize = New System.Drawing.Size(344, 264)
        Me.Controls.Add(Me.txtReembolso)
        Me.Controls.Add(Me.lblReembolso)
        Me.Controls.Add(Me.dtpFechaCancelacion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblFechaCancelacion)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCancelaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCancelaciones"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblFechaCancelacion As System.Windows.Forms.Label
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaCancelacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblReembolso As System.Windows.Forms.Label
    Friend WithEvents txtReembolso As System.Windows.Forms.TextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Cabañas.BotonAceptar
    Friend WithEvents RectangleShape2 As Cabañas.BotonAceptar
    Friend WithEvents RectangleShape3 As Cabañas.BotonCancelar
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
