<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.CabañasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HuespedesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InsumosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TipoCabaniaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.EstadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CancelacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PruebaABMReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.OvalShape3 = New Microsoft.VisualBasic.PowerPacks.OvalShape
        Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape
        Me.MenuStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.MenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.SalirToolStripMenuItem, Me.ToolStripMenuItem1, Me.PruebaABMReservasToolStripMenuItem})
        Me.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1362, 32)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.AutoSize = False
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CabañasToolStripMenuItem, Me.HuespedesToolStripMenuItem, Me.PersonalToolStripMenuItem, Me.InsumosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.TipoCabaniaToolStripMenuItem, Me.ReservasToolStripMenuItem, Me.ServiciosToolStripMenuItem, Me.ToolStripMenuItem2, Me.EstadoToolStripMenuItem, Me.CancelacionesToolStripMenuItem})
        Me.FileMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FileMenu.ForeColor = System.Drawing.Color.White
        Me.FileMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(94, 25)
        Me.FileMenu.Text = "Secciones"
        '
        'CabañasToolStripMenuItem
        '
        Me.CabañasToolStripMenuItem.AutoSize = False
        Me.CabañasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CabañasToolStripMenuItem.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.CabañasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CabañasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CabañasToolStripMenuItem.Name = "CabañasToolStripMenuItem"
        Me.CabañasToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CabañasToolStripMenuItem.Text = "Cabañas"
        '
        'HuespedesToolStripMenuItem
        '
        Me.HuespedesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.HuespedesToolStripMenuItem.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.HuespedesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.HuespedesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HuespedesToolStripMenuItem.Name = "HuespedesToolStripMenuItem"
        Me.HuespedesToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.HuespedesToolStripMenuItem.Text = "Huespedes"
        '
        'PersonalToolStripMenuItem
        '
        Me.PersonalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PersonalToolStripMenuItem.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.PersonalToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PersonalToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem"
        Me.PersonalToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.PersonalToolStripMenuItem.Text = "Personal"
        '
        'InsumosToolStripMenuItem
        '
        Me.InsumosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.InsumosToolStripMenuItem.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.InsumosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.InsumosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InsumosToolStripMenuItem.Name = "InsumosToolStripMenuItem"
        Me.InsumosToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.InsumosToolStripMenuItem.Text = "Gastos"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProveedoresToolStripMenuItem.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.ProveedoresToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ProveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'TipoCabaniaToolStripMenuItem
        '
        Me.TipoCabaniaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TipoCabaniaToolStripMenuItem.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.TipoCabaniaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TipoCabaniaToolStripMenuItem.Name = "TipoCabaniaToolStripMenuItem"
        Me.TipoCabaniaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.TipoCabaniaToolStripMenuItem.Text = "TipoCabania"
        '
        'ReservasToolStripMenuItem
        '
        Me.ReservasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ReservasToolStripMenuItem.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.ReservasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReservasToolStripMenuItem.Name = "ReservasToolStripMenuItem"
        Me.ReservasToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ReservasToolStripMenuItem.Text = "Reservas"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ServiciosToolStripMenuItem.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.ServiciosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ToolStripMenuItem2.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem2.Text = "Adicionales"
        '
        'EstadoToolStripMenuItem
        '
        Me.EstadoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.EstadoToolStripMenuItem.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.EstadoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EstadoToolStripMenuItem.Name = "EstadoToolStripMenuItem"
        Me.EstadoToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.EstadoToolStripMenuItem.Text = "EstadosReservas"
        '
        'CancelacionesToolStripMenuItem
        '
        Me.CancelacionesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CancelacionesToolStripMenuItem.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.CancelacionesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CancelacionesToolStripMenuItem.Name = "CancelacionesToolStripMenuItem"
        Me.CancelacionesToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.CancelacionesToolStripMenuItem.Text = "Cancelaciones"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.AutoSize = False
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(94, 25)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(12, 4)
        '
        'PruebaABMReservasToolStripMenuItem
        '
        Me.PruebaABMReservasToolStripMenuItem.Name = "PruebaABMReservasToolStripMenuItem"
        Me.PruebaABMReservasToolStripMenuItem.Size = New System.Drawing.Size(130, 19)
        Me.PruebaABMReservasToolStripMenuItem.Text = "Prueba ABMReservas"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaPanel
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(135, 629)
        Me.Panel1.TabIndex = 7
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape3, Me.OvalShape2, Me.OvalShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(135, 629)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape3
        '
        Me.OvalShape3.BackgroundImage = Global.Cabañas.My.Resources.Resources.IconoCalendario2
        Me.OvalShape3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OvalShape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.OvalShape3.Location = New System.Drawing.Point(25, 203)
        Me.OvalShape3.Name = "OvalShape3"
        Me.OvalShape3.Size = New System.Drawing.Size(75, 75)
        '
        'OvalShape2
        '
        Me.OvalShape2.BackgroundImage = Global.Cabañas.My.Resources.Resources.IconoHuesped
        Me.OvalShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OvalShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.OvalShape2.Location = New System.Drawing.Point(27, 112)
        Me.OvalShape2.Name = "OvalShape2"
        Me.OvalShape2.Size = New System.Drawing.Size(75, 75)
        '
        'OvalShape1
        '
        Me.OvalShape1.BackgroundImage = Global.Cabañas.My.Resources.Resources.IconoCabania
        Me.OvalShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OvalShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.OvalShape1.Location = New System.Drawing.Point(26, 18)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(75, 75)
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Cabañas.My.Resources.Resources.FondoMaderaClaro3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 661)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents HuespedesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsumosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CabañasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoCabaniaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PruebaABMReservasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancelacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape2 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape3 As Microsoft.VisualBasic.PowerPacks.OvalShape

End Class
