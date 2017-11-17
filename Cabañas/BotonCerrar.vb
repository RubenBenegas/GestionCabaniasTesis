Imports Microsoft.VisualBasic.PowerPacks

Public Class BotonCerrar

    Inherits RectangleShape

    Public Sub New()
        Me.BackgroundImage = My.Resources.BotonCerrarMaderaNegro
        Me.BorderColor = Color.Transparent
        Me.Size = New Size(122, 35)
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.CornerRadius = 20
    End Sub

    Private Sub me_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Me.BackgroundImage = My.Resources.BotonCerrarMaderaBlanco
    End Sub

    Private Sub me_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.BackgroundImage = My.Resources.BotonCerrarMaderaNegro
    End Sub
End Class
