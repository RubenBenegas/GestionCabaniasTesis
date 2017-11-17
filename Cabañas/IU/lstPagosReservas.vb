Public Class lstPagosReservas

    Dim reserva As New Reservas
    Private Sub lstPagosReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reserva.ReservasTraerSinSenia(dgvPagosReservas)
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        frmPagos.txtIdReserva.Text = dgvPagosReservas.Item("id", dgvPagosReservas.CurrentRow.Index).Value
        frmPagos.txtMonto.Text = dgvPagosReservas.Item("Senia", dgvPagosReservas.CurrentRow.Index).Value
        'frmReservas.txtNombreHuesped.Text = dgvConsHuesped.Item("Nombre", dgvConsHuesped.CurrentRow.Index).Value
        Close()
    End Sub



    Private Sub dgvPagosReservas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPagosReservas.CellDoubleClick
        frmPagos.txtIdReserva.Text = dgvPagosReservas.Item("id", dgvPagosReservas.CurrentRow.Index).Value
        frmPagos.txtMonto.Text = dgvPagosReservas.Item("Senia", dgvPagosReservas.CurrentRow.Index).Value
        'frmReservas.txtNombreHuesped.Text = dgvConsHuesped.Item("Nombre", dgvConsHuesped.CurrentRow.Index).Value
        Close()
    End Sub
End Class