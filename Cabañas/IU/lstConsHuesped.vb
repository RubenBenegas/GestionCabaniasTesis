Public Class lstConsHuesped

    Dim huesped As New Huespedes
    Private Sub lstConsHuesped_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        huesped.BuscarHuespedes(dgvConsHuesped)
    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        frmReservas.txtIdHuesped.Text = dgvConsHuesped.Item("id", dgvConsHuesped.CurrentRow.Index).Value
        frmReservas.txtNombreHuesped.Text = dgvConsHuesped.Item("Nombre", dgvConsHuesped.CurrentRow.Index).Value
        Close()
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        Close()
    End Sub
End Class