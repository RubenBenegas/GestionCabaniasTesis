Imports CrystalDecisions.Shared

Public Class z
    Dim Personal As New Personal

    Private Sub lstPersonal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Personal.PersonalTraerTab(dgvPersonal)
    End Sub

    Private Sub Editar()
        frmPersonal.Modificar = True
        If dgvPersonal.Rows.Count <> 0 Then
            frmPersonal.IdPersonal = dgvPersonal.Item("id", dgvPersonal.CurrentRow.Index).Value
            frmPersonal.ShowDialog()
            'Else
            '    MsgBox("No hay elementos para modificar.", MsgBoxStyle.Information, "Mensaje")
        End If

    End Sub

    Private Sub dgvPersonal_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPersonal.CellDoubleClick
        Editar()

    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        frmPersonal.Modificar = False
        frmPersonal.IdPersonal = 0
        frmPersonal.ShowDialog()
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        Editar()
    End Sub

    Private Sub RectangleShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape3.Click

        If dgvPersonal.Rows.Count <> 0 Then
            Personal.Id = dgvPersonal.Item("id", dgvPersonal.CurrentRow.Index).Value
            Dim mensaje As DialogResult = MsgBox("Està seguro que quiere borrar ...", MsgBoxStyle.OkCancel, "Advertencia")
            If mensaje = Windows.Forms.DialogResult.OK Then
                If Personal.PersonalBorrar(Personal.Id) Then
                    MessageBox.Show("El cliente se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Personal.PersonalTraerTab(dgvPersonal)
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

    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        Dim idPersonal As Integer = dgvPersonal.Item("Id", dgvPersonal.CurrentRow.Index).Value
        Dim params As New ParameterValues
        Dim par As New ParameterDiscreteValue
        params.Clear()
        par.Value = idPersonal
        params.Add(par)
        frmDetallePersonal.rptDetallePersonal1.DataSourceConnections.Item(0).SetConnection("localhost\SQLEXPRESS", "Cabania", True)
        frmDetallePersonal.rptDetallePersonal1.DataDefinition.ParameterFields("idPersonal").ApplyCurrentValues(params)
        frmDetallePersonal.ShowDialog()
        frmDetallePersonal.Dispose()
    End Sub
End Class