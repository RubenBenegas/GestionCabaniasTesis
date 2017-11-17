Imports Microsoft.VisualBasic.PowerPacks

Public Class BotonNuevaReserva
    Inherits RectangleShape
    Public Sub New()
        Me.BackgroundImage = My.Resources.BotonNuevaReservaMaderaNegro
        Me.BorderColor = Color.Transparent
        Me.Size = New Size(120, 30)
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.CornerRadius = 20
    End Sub
    Private Sub me_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Me.BackgroundImage = My.Resources.BotonNuevaReservaMaderaBlanco
    End Sub

    Private Sub me_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.BackgroundImage = My.Resources.BotonNuevaReservaMaderaNegro
    End Sub

End Class
