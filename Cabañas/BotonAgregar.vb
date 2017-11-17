Imports Microsoft.VisualBasic.PowerPacks

Public Class BotonAgregar

    Inherits RectangleShape

    Public Sub New()
        Me.BackgroundImage = My.Resources.BotonAgregarMaderaNegro
        Me.BorderColor = Color.Transparent
        Me.Size = New Size(90, 30)
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.CornerRadius = 20



    End Sub

    Private Sub me_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        Me.BackgroundImage = My.Resources.BotonAgregarMaderaBlanco
    End Sub

    Private Sub me_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.BackgroundImage = My.Resources.BotonAgregarMaderaNegro
    End Sub


End Class
