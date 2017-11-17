Imports CrystalDecisions.Shared

Public Class lstcabania

    Dim cabania As New Cabanias
    Private Sub lstcabania_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cabania.TraerTabCabania(dgvCabanias)


    End Sub

    Private Sub Editar()
        frmCabania.modificar = True
        If dgvCabanias.Rows.Count <> 0 Then
            frmCabania.idCabania = dgvCabanias.Item("Id", dgvCabanias.CurrentRow.Index).Value
            frmCabania.ShowDialog()
            'Else
            '    MsgBox("No hay elementos para modificar.", MsgBoxStyle.Information, "Mensaje")           
        End If

    End Sub

    Private Sub dgvCabanias_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCabanias.CellDoubleClick
        Editar()
    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        frmCabania.modificar = False
        frmCabania.idCabania = 0
        frmCabania.ShowDialog()

    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        Editar()
    End Sub

    Private Sub RectangleShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape3.Click
        If dgvCabanias.Rows.Count <> 0 Then
            cabania.idCabania = dgvCabanias.Item("Id", dgvCabanias.CurrentRow.Index).Value

            Dim mensaje As DialogResult = MsgBox("¿Seguro quieres borrar?", MsgBoxStyle.YesNo, "Borrar")
            If mensaje = Windows.Forms.DialogResult.Yes Then
                If cabania.BorrarCabania(cabania.idCabania) Then
                    MessageBox.Show("La cabania se ha borrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cabania.TraerTabCabania(dgvCabanias)
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

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        frmListadoCabanias.rptListadoCabanias1.DataSourceConnections.Item(0).SetConnection("localhost\SQLEXPRESS", "Cabania", True)
        frmListadoCabanias.ShowDialog()
    End Sub

    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        Dim idCabanias As Integer = dgvCabanias.Item("Id", dgvCabanias.CurrentRow.Index).Value
        Dim params As New ParameterValues
        Dim par As New ParameterDiscreteValue
        params.Clear()
        par.Value = idCabanias
        params.Add(par)
        frmDetallaCabanias.rptDetallaCabanias1.DataSourceConnections.Item(0).SetConnection("localhost\SQLEXPRESS", "Cabania", True)
        frmDetallaCabanias.rptDetallaCabanias1.DataDefinition.ParameterFields("idCabanias").ApplyCurrentValues(params)
        frmDetallaCabanias.ShowDialog()
        frmDetallaCabanias.Dispose()
    End Sub
End Class
