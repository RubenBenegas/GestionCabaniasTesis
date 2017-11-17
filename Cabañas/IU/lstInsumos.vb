Public Class lstInsumos
    Dim Insumo As New Insumos


    Private Sub lstInsumos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Insumo.verTodos(dgvInsumos)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        frmInsumos.modificar = False
        frmInsumos.IdInsumo = 0
        frmInsumos.ShowDialog()
    End Sub

    Private Sub Editar()
        frmInsumos.modificar = True
        If dgvInsumos.Rows.Count <> 0 Then
            frmInsumos.IdInsumo = dgvInsumos.Item("Id", dgvInsumos.CurrentRow.Index).Value
            frmInsumos.ShowDialog()
            'Else
            '    MsgBox("No hay elementos para modificar.", MsgBoxStyle.Information, "Mensaje")
        End If


    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Editar()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If dgvInsumos.Rows.Count <> 0 Then
            Insumo.id = dgvInsumos.Item("Id", dgvInsumos.CurrentRow.Index).Value
            Dim mensaje As DialogResult = MessageBox.Show("¿Está seguro que quiere borrar?", "Advertencia", MessageBoxButtons.OKCancel)
            If mensaje = Windows.Forms.DialogResult.OK Then
                If Insumo.BorrarInsumo(Insumo.id) Then
                    MessageBox.Show("El insumo se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Insumo.verTodos(dgvInsumos)
                End If
            End If
            'Else
            '    MsgBox("No hay elementos para eliminar.", MsgBoxStyle.Information, "Mensaje")
        End If

    End Sub


    Private Sub dgvInsumos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInsumos.CellDoubleClick
        Editar()

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Close()

    End Sub
End Class