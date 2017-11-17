Public Class lstPagosAdicionales

    Dim reserva As New Reservas
    Private Sub lstPagosAdicionales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reserva.ReservasCargarAdicionales(frmPagos.txtIdReserva.Text, dgvPagosAdicionales)

    End Sub
End Class