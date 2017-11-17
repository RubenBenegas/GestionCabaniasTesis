<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoPagos
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
        Me.rptPagos = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.rptListadoPagos2 = New Cabañas.rptListadoPagos
        Me.rptListadoPagos1 = New Cabañas.rptListadoPagos
        Me.rptListadoPagos3 = New Cabañas.rptListadoPagos
        Me.SuspendLayout()
        '
        'rptPagos
        '
        Me.rptPagos.ActiveViewIndex = 0
        Me.rptPagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptPagos.DisplayGroupTree = False
        Me.rptPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptPagos.Location = New System.Drawing.Point(0, 0)
        Me.rptPagos.Name = "rptPagos"
        Me.rptPagos.ReportSource = Me.rptListadoPagos3
        Me.rptPagos.Size = New System.Drawing.Size(496, 392)
        Me.rptPagos.TabIndex = 0
        '
        'frmListadoPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 392)
        Me.Controls.Add(Me.rptPagos)
        Me.Name = "frmListadoPagos"
        Me.Text = "frmListadoPagos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rptPagos As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptListadoPagos1 As Cabañas.rptListadoPagos
    Friend WithEvents rptListadoPagos2 As Cabañas.rptListadoPagos
    Friend WithEvents rptListadoPagos3 As Cabañas.rptListadoPagos
End Class
