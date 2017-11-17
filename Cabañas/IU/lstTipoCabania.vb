Public Class lstTipoCabania

    Dim Tipocabania As New TipoCabania
    Private Sub lstcabania_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Tipocabania.TraerTipoCabania(DgvTipoCabania)


    End Sub



    Private Sub BtnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Editar()
    End Sub

    Private Sub Editar()
        frmTipoCabania.modificar = True
        If DgvTipoCabania.Rows.Count <> 0 Then
            frmTipoCabania.id = DgvTipoCabania.Item("Id", DgvTipoCabania.CurrentRow.Index).Value
            frmTipoCabania.ShowDialog()
            'Else
            '    MsgBox("No hay elementos para modificar.", MsgBoxStyle.Information, "Mensaje")           
        End If

    End Sub

    Private Sub dgvTipoCabania_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvTipoCabania.CellDoubleClick
        Editar()
    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        frmTipoCabania.modificar = False
        frmTipoCabania.id = 0
        frmTipoCabania.ShowDialog()
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        Editar()
    End Sub

    Private Sub RectangleShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape3.Click
        If DgvTipoCabania.Rows.Count <> 0 Then
            Tipocabania.id = DgvTipoCabania.Item("Id", DgvTipoCabania.CurrentRow.Index).Value

            Dim mensaje As DialogResult = MsgBox("¿Seguro quieres borrar?", MsgBoxStyle.YesNo, "Borrar")
            If mensaje = Windows.Forms.DialogResult.Yes Then
                If Tipocabania.BorrarTipoCabania(Tipocabania.id) Then
                    MessageBox.Show("La cabania se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Tipocabania.TraerTipoCabania(DgvTipoCabania)
                Else
                    MessageBox.Show("La cabania no se ha borrado ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
