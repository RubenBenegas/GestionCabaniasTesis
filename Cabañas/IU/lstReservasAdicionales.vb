Public Class lstReservasAdicionales

    Private idReserva_ As Integer

    Public Property idReserva() As Integer
        Get
            Return idReserva_
        End Get
        Set(ByVal value As Integer)
            idReserva_ = value
        End Set
    End Property

    Dim adicionales As New Adicionales
    Dim reserva As New Reservas

    Private Sub lstReservasAdicionales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        adicionales.BuscarAdicionales(dgvAdicionales)
    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        adicionales.Id = dgvAdicionales.Item("id", dgvAdicionales.CurrentRow.Index).Value
        reserva.ReservaAdicionalInsertar(idReserva, adicionales.Id)
        reserva.ReservasCargarAdicionales(idReserva, frmReservas.dgvServiciosAdicionales)
        Close()
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        Close()
    End Sub
End Class