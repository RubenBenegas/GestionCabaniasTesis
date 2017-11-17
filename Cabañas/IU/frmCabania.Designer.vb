<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCabania
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCabania))
        Me.txtIdCabania = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbTipoCabania = New System.Windows.Forms.ComboBox
        Me.lblMonto = New System.Windows.Forms.Label
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.lblDescripcion = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.dgvCabaniaServicios = New System.Windows.Forms.DataGridView
        Me.Servicios = New System.Windows.Forms.Label
        Me.lblCostoTotal = New System.Windows.Forms.Label
        Me.lblCostoServicios = New System.Windows.Forms.Label
        Me.txtCostoTotal = New System.Windows.Forms.TextBox
        Me.txtCostoServicios = New System.Windows.Forms.TextBox
        Me.btnConsultarCostos = New System.Windows.Forms.Button
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RectangleShape4 = New Cabañas.BotonEliminarFrm
        Me.RectangleShape3 = New Cabañas.BotonAgregarFrm
        Me.RectangleShape2 = New Cabañas.BotonCancelar
        Me.RectangleShape1 = New Cabañas.BotonAceptar
        CType(Me.dgvCabaniaServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdCabania
        '
        Me.txtIdCabania.Enabled = False
        Me.txtIdCabania.Location = New System.Drawing.Point(131, 6)
        Me.txtIdCabania.Name = "txtIdCabania"
        Me.txtIdCabania.Size = New System.Drawing.Size(55, 20)
        Me.txtIdCabania.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tipo Cabaña:"
        '
        'cmbTipoCabania
        '
        Me.cmbTipoCabania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCabania.FormattingEnabled = True
        Me.cmbTipoCabania.Location = New System.Drawing.Point(131, 31)
        Me.cmbTipoCabania.Name = "cmbTipoCabania"
        Me.cmbTipoCabania.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoCabania.TabIndex = 1
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.BackColor = System.Drawing.Color.Transparent
        Me.lblMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonto.ForeColor = System.Drawing.Color.White
        Me.lblMonto.Location = New System.Drawing.Point(12, 61)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(46, 13)
        Me.lblMonto.TabIndex = 9
        Me.lblMonto.Text = "Monto:"
        '
        'txtMonto
        '
        Me.txtMonto.Enabled = False
        Me.txtMonto.Location = New System.Drawing.Point(131, 59)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(100, 20)
        Me.txtMonto.TabIndex = 2
        Me.txtMonto.Tag = "*"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.White
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 88)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(78, 13)
        Me.lblDescripcion.TabIndex = 11
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(131, 85)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(167, 91)
        Me.txtDescripcion.TabIndex = 3
        Me.txtDescripcion.Tag = "*"
        '
        'dgvCabaniaServicios
        '
        Me.dgvCabaniaServicios.AllowUserToAddRows = False
        Me.dgvCabaniaServicios.AllowUserToDeleteRows = False
        Me.dgvCabaniaServicios.AllowUserToResizeColumns = False
        Me.dgvCabaniaServicios.AllowUserToResizeRows = False
        Me.dgvCabaniaServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCabaniaServicios.Location = New System.Drawing.Point(15, 212)
        Me.dgvCabaniaServicios.MultiSelect = False
        Me.dgvCabaniaServicios.Name = "dgvCabaniaServicios"
        Me.dgvCabaniaServicios.ReadOnly = True
        Me.dgvCabaniaServicios.RowHeadersVisible = False
        Me.dgvCabaniaServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCabaniaServicios.Size = New System.Drawing.Size(340, 180)
        Me.dgvCabaniaServicios.TabIndex = 13
        Me.dgvCabaniaServicios.Tag = ""
        '
        'Servicios
        '
        Me.Servicios.AutoSize = True
        Me.Servicios.BackColor = System.Drawing.Color.Transparent
        Me.Servicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Servicios.ForeColor = System.Drawing.Color.White
        Me.Servicios.Location = New System.Drawing.Point(21, 192)
        Me.Servicios.Name = "Servicios"
        Me.Servicios.Size = New System.Drawing.Size(59, 13)
        Me.Servicios.TabIndex = 16
        Me.Servicios.Text = "Servicios"
        '
        'lblCostoTotal
        '
        Me.lblCostoTotal.AutoSize = True
        Me.lblCostoTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblCostoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoTotal.ForeColor = System.Drawing.Color.White
        Me.lblCostoTotal.Location = New System.Drawing.Point(149, 412)
        Me.lblCostoTotal.Name = "lblCostoTotal"
        Me.lblCostoTotal.Size = New System.Drawing.Size(76, 13)
        Me.lblCostoTotal.TabIndex = 41
        Me.lblCostoTotal.Text = "Costo Total:"
        '
        'lblCostoServicios
        '
        Me.lblCostoServicios.AutoSize = True
        Me.lblCostoServicios.BackColor = System.Drawing.Color.Transparent
        Me.lblCostoServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoServicios.ForeColor = System.Drawing.Color.White
        Me.lblCostoServicios.Location = New System.Drawing.Point(21, 412)
        Me.lblCostoServicios.Name = "lblCostoServicios"
        Me.lblCostoServicios.Size = New System.Drawing.Size(117, 13)
        Me.lblCostoServicios.TabIndex = 40
        Me.lblCostoServicios.Text = "Costo de Servicios:"
        '
        'txtCostoTotal
        '
        Me.txtCostoTotal.Enabled = False
        Me.txtCostoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoTotal.Location = New System.Drawing.Point(152, 430)
        Me.txtCostoTotal.Multiline = True
        Me.txtCostoTotal.Name = "txtCostoTotal"
        Me.txtCostoTotal.Size = New System.Drawing.Size(100, 25)
        Me.txtCostoTotal.TabIndex = 39
        Me.txtCostoTotal.Tag = "*"
        Me.txtCostoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCostoServicios
        '
        Me.txtCostoServicios.Enabled = False
        Me.txtCostoServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoServicios.Location = New System.Drawing.Point(24, 430)
        Me.txtCostoServicios.Multiline = True
        Me.txtCostoServicios.Name = "txtCostoServicios"
        Me.txtCostoServicios.Size = New System.Drawing.Size(100, 25)
        Me.txtCostoServicios.TabIndex = 38
        Me.txtCostoServicios.Tag = "*"
        Me.txtCostoServicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConsultarCostos
        '
        Me.btnConsultarCostos.Location = New System.Drawing.Point(268, 432)
        Me.btnConsultarCostos.Name = "btnConsultarCostos"
        Me.btnConsultarCostos.Size = New System.Drawing.Size(99, 23)
        Me.btnConsultarCostos.TabIndex = 44
        Me.btnConsultarCostos.Text = "Consultar costos"
        Me.btnConsultarCostos.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape4, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(476, 519)
        Me.ShapeContainer1.TabIndex = 45
        Me.ShapeContainer1.TabStop = False
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'RectangleShape4
        '
        Me.RectangleShape4.BackgroundImage = CType(resources.GetObject("RectangleShape4.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape4.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape4.CornerRadius = 15
        Me.RectangleShape4.Location = New System.Drawing.Point(367, 259)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(90, 30)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BackgroundImage = Global.Cabañas.My.Resources.Resources.BotonAgregarMaderaNegroFrm
        Me.RectangleShape3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape3.CornerRadius = 15
        Me.RectangleShape3.Location = New System.Drawing.Point(366, 214)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(90, 30)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackgroundImage = CType(resources.GetObject("RectangleShape2.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape2.CornerRadius = 13
        Me.RectangleShape2.Location = New System.Drawing.Point(254, 486)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(80, 26)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackgroundImage = CType(resources.GetObject("RectangleShape1.BackgroundImage"), System.Drawing.Image)
        Me.RectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RectangleShape1.BorderColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.CornerRadius = 13
        Me.RectangleShape1.Location = New System.Drawing.Point(152, 486)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(80, 26)
        '
        'frmCabania
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(476, 519)
        Me.Controls.Add(Me.btnConsultarCostos)
        Me.Controls.Add(Me.lblCostoTotal)
        Me.Controls.Add(Me.lblCostoServicios)
        Me.Controls.Add(Me.txtCostoTotal)
        Me.Controls.Add(Me.txtCostoServicios)
        Me.Controls.Add(Me.Servicios)
        Me.Controls.Add(Me.dgvCabaniaServicios)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.cmbTipoCabania)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdCabania)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCabania"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CabaniaForm"
        CType(Me.dgvCabaniaServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIdCabania As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbTipoCabania As System.Windows.Forms.ComboBox
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents Servicios As System.Windows.Forms.Label
    Friend WithEvents dgvCabaniaServicios As System.Windows.Forms.DataGridView
    Friend WithEvents lblCostoTotal As System.Windows.Forms.Label
    Friend WithEvents lblCostoServicios As System.Windows.Forms.Label
    Friend WithEvents txtCostoTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtCostoServicios As System.Windows.Forms.TextBox
    Friend WithEvents btnConsultarCostos As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Cabañas.BotonAceptar
    Friend WithEvents RectangleShape2 As Cabañas.BotonCancelar
    Friend WithEvents RectangleShape3 As Cabañas.BotonAgregarFrm
    Friend WithEvents RectangleShape4 As Cabañas.BotonEliminarFrm
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
End Class
