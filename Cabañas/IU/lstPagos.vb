Imports CrystalDecisions.Shared

Public Class lstPagos
    Dim Pago As New Pagos

    Private Sub lstPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Pago.PagosTraerTab(frmReservas.txtId.Text, dgvPagos)

    End Sub

    Private Sub dgvPagos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPagos.CellDoubleClick
        Editar()
    End Sub

    Private Sub Editar()
        frmPagos.modificar = True
        If dgvPagos.Rows.Count <> 0 Then
            frmPagos.IdPago = dgvPagos.Item("id", dgvPagos.CurrentRow.Index).Value
            frmPagos.ShowDialog()
            'Else
            '    MsgBox("No hay elementos para modificar.", MsgBoxStyle.Information, "Mensaje")
        End If
    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        If dgvPagos.Rows.Count = 0 Then
            frmReservas.montoDiferenciaEnTotal = 0
        End If
        frmPagos.modificar = False
        frmPagos.IdPago = 0
        frmPagos.ShowDialog()
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        Editar()
    End Sub

    Private Sub RectangleShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape3.Click
        If dgvPagos.Rows.Count <> 0 Then
            Pago.Id = dgvPagos.Item("id", dgvPagos.CurrentRow.Index).Value
            Dim mensaje As DialogResult = MsgBox("¿Està seguro que quiere borrar?", MsgBoxStyle.OkCancel, "Advertencia")
            If mensaje = Windows.Forms.DialogResult.OK Then
                If Pago.PagosBorrar(Pago.Id) Then
                    MessageBox.Show("El pago se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Pago.PagosTraerTab(frmReservas.txtId.Text, dgvPagos)
                Else
                    MessageBox.Show("El cliente NO se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Dim idPago As Integer = dgvPagos.Item("Id", dgvPagos.CurrentRow.Index).Value
        Dim params As New ParameterValues
        Dim par As New ParameterDiscreteValue
        params.Clear()
        par.Value = idPago
        params.Add(par)
        frmListadoPagos.rptListadoPagos3.DataSourceConnections.Item(0).SetConnection("localhost\SQLEXPRESS", "Cabania", True)
        frmListadoPagos.rptListadoPagos3.DataDefinition.ParameterFields("idPago").ApplyCurrentValues(params)
        frmListadoPagos.ShowDialog()
        frmListadoPagos.Dispose()
    End Sub
End Class



