Imports Microsoft.VisualBasic.PowerPacks

Public Class BotonActualizar
    Inherits RectangleShape
    Public Sub New()
        Me.BackgroundImage = My.Resources.BotonActualizarMaderaNegro
        Me.BorderColor = Color.Transparent
        Me.Size = New Size(110, 25)
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.CornerRadius = 20
    End Sub
    Private Sub me_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Me.BackgroundImage = My.Resources.BotonActualizarMaderaBlanco
    End Sub

    Private Sub me_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.BackgroundImage = My.Resources.BotonActualizarMaderaNegro
    End Sub
End Class
