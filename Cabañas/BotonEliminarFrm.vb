Imports Microsoft.VisualBasic.PowerPacks

Public Class BotonEliminarFrm

    Inherits RectangleShape

    Public Sub New()
        Me.BackgroundImage = My.Resources.BotonEliminarMaderaNegroFrm
        Me.BorderColor = Color.Transparent
        Me.Size = New Size(90, 30)
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.CornerRadius = 20
    End Sub
    Private Sub me_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Me.BackgroundImage = My.Resources.BotonEliminarMaderaBlancoFrm
    End Sub

    Private Sub me_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.BackgroundImage = My.Resources.BotonEliminarMaderaNegroFrm
    End Sub

End Class
