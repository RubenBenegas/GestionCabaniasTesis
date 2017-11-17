Imports Microsoft.VisualBasic.PowerPacks

Public Class BotonPagos

    Inherits RectangleShape
    Public Sub New()
        Me.BackgroundImage = My.Resources.BotonPagosMaderaNegro
        Me.BorderColor = Color.Transparent
        Me.Size = New Size(80, 26)
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.CornerRadius = 20



    End Sub

    Private Sub me_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Me.BackgroundImage = My.Resources.BotonPagosMaderaBlanco
    End Sub

    Private Sub me_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.BackgroundImage = My.Resources.BotonPagosMaderaNegro
    End Sub
End Class
