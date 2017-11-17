Public Class lstAdicional

    Dim Adicional As New Adicionales
    Private Sub lstadicional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Adicional.AdicionalesTraerTab(DgvAdicionales)


    End Sub

    Private Sub Editar()
        frmAdicionales.modificar = True
        If DgvAdicionales.Rows.Count <> 0 Then
            frmAdicionales.id = DgvAdicionales.Item("Id", DgvAdicionales.CurrentRow.Index).Value
            frmAdicionales.ShowDialog()
            'Else
            '    MsgBox("No hay elementos para modificar.", MsgBoxStyle.Information, "Mensaje")           
        End If

    End Sub

    Private Sub dgvAdicional_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvAdicionales.CellDoubleClick
        Editar()
    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        frmAdicionales.modificar = False
        frmAdicionales.id = 0
        frmAdicionales.ShowDialog()
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        Editar()
    End Sub

    Private Sub RectangleShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape3.Click
        If DgvAdicionales.Rows.Count <> 0 Then
            Adicional.Id = DgvAdicionales.Item("Id", DgvAdicionales.CurrentRow.Index).Value

            Dim mensaje As DialogResult = MsgBox("¿Seguro quieres borrar?", MsgBoxStyle.YesNo, "Borrar")
            If mensaje = Windows.Forms.DialogResult.Yes Then
                If Adicional.BorrarAdicional(Adicional.Id) Then
                    MessageBox.Show("El adicional se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Adicional.AdicionalesTraerTab(DgvAdicionales)
                Else
                    MessageBox.Show("El adicional no se ha borrado ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            'Else
            '    MsgBox("No hay elementos para eliminar.", MsgBoxStyle.Information, "Mensaje")
        End If
    End Sub

    Private Sub RectangleShape4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape4.Click
        Close()
    End Sub
End Class