Imports CrystalDecisions.Shared

Public Class LstProveedor
    Dim Proveedor As New Proveedor
    Private Sub LstProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Proveedor.traerProveedor(dgvProveedores)

    End Sub

    Private Sub Editar()
        FrmProveedor.modificar = True

        If dgvProveedores.Rows.Count <> 0 Then
            FrmProveedor.idProveedor = dgvProveedores.Item("id", dgvProveedores.CurrentRow.Index).Value
            FrmProveedor.ShowDialog()
        Else
            MsgBox("No hay elementos para modificar.", MsgBoxStyle.Information, "Mensaje")
        End If

    End Sub

    Private Sub dgvProveedores_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProveedores.CellDoubleClick
        Editar()

    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        FrmProveedor.modificar = False
        FrmProveedor.idProveedor = 0
        FrmProveedor.ShowDialog()
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        Editar()
    End Sub

    Private Sub RectangleShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape3.Click
        If dgvProveedores.Rows.Count <> 0 Then
            Proveedor.id = dgvProveedores.Item("id", dgvProveedores.CurrentRow.Index).Value

            Dim mensaje As DialogResult = MsgBox("¿Seguro quieres borrar?", MsgBoxStyle.YesNo, "Borrar")
            If mensaje = Windows.Forms.DialogResult.Yes Then
                If Proveedor.ProveedorEliminar(Proveedor.id) Then
                    MessageBox.Show("El producto se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Proveedor.traerProveedor(dgvProveedores)
                Else
                    MessageBox.Show("El producto no se ha borrado ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            'Else
            '    MsgBox("No hay elementos para eliminar.", MsgBoxStyle.Information, "Mensaje")
        End If
    End Sub

    Private Sub RectangleShape4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape4.Click
        Close()
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click

        frmListadoProveedores.rptListadoProveedores1.DataSourceConnections.Item(0).SetConnection("localhost\SQLEXPRESS", "Cabania", True)
        frmListadoProveedores.ShowDialog()

    End Sub

    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        Dim idProveeedor As Integer = dgvProveedores.Item("Id", dgvProveedores.CurrentRow.Index).Value
        Dim params As New ParameterValues
        Dim par As New ParameterDiscreteValue
        params.Clear()
        par.Value = idProveeedor
        params.Add(par)
        frmDetalleProveedores.rptDetalleProveedores1.DataSourceConnections.Item(0).SetConnection("localhost\SQLEXPRESS", "Cabania", True)
        frmDetalleProveedores.rptDetalleProveedores1.DataDefinition.ParameterFields("idProveedor").ApplyCurrentValues(params)
        frmDetalleProveedores.ShowDialog()
        frmDetalleProveedores.Dispose()
    End Sub
End Class