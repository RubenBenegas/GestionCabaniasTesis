Imports CrystalDecisions.Shared

Public Class lstHuesped

    Dim huesped As New Huespedes
    Private Sub lstHuesped_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        huesped.TraerTabHuespedes(dgvHuesped)
    End Sub

    Private Sub dgvHuesped_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvHuesped.CellDoubleClick

        Editar()

    End Sub

    Private Sub Editar()
        frmHuesped.modificar = True
        If dgvHuesped.Rows.Count <> 0 Then
            frmHuesped.idHuesped = dgvHuesped.Item("id", dgvHuesped.CurrentRow.Index).Value
            frmHuesped.ShowDialog()
            'Else          
            '    MsgBox("No hay elementos para modificar.", MsgBoxStyle.Information, "Mensaje")
        End If

    End Sub

    Private Sub RectangleShape1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        frmHuesped.modificar = False
        frmHuesped.idHuesped = 0
        frmHuesped.ShowDialog()
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        Editar()
    End Sub

    Private Sub RectangleShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape3.Click

        If dgvHuesped.Rows.Count <> 0 Then
            huesped.id = dgvHuesped.Item("id", dgvHuesped.CurrentRow.Index).Value

            Dim mensaje As DialogResult = MsgBox("¿Seguro quieres borrar?", MsgBoxStyle.YesNo, "Borrar")
            If mensaje = Windows.Forms.DialogResult.Yes Then
                If huesped.BorraHuesped(huesped.id) Then
                    MessageBox.Show("El huesped se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    huesped.TraerTabHuespedes(dgvHuesped)
                Else
                    MessageBox.Show("El huesped no se ha borrado ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        frmListadoHuespedes.rptListadoHuespedes1.DataSourceConnections.Item(0).SetConnection("localhost\SQLEXPRESS", "Cabania", True)
        frmListadoHuespedes.ShowDialog()

    End Sub

    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        Dim idHuesped As Integer = dgvHuesped.Item("Id", dgvHuesped.CurrentRow.Index).Value
        Dim params As New ParameterValues
        Dim par As New ParameterDiscreteValue
        params.Clear()
        par.Value = idHuesped
        params.Add(par)
        frmDetallaHuesped.rptDetalleHuesped1.DataSourceConnections.Item(0).SetConnection("localhost\SQLEXPRESS", "Cabania", True)
        frmDetallaHuesped.rptDetalleHuesped1.DataDefinition.ParameterFields("idHuesped").ApplyCurrentValues(params)
        frmDetallaHuesped.ShowDialog()
        frmDetallaHuesped.Dispose()
    End Sub
End Class
