Imports Microsoft.VisualBasic.PowerPacks

Public Class BotonCruz

    Inherits RectangleShape
    Public Sub New()
        Me.BackgroundImage = My.Resources.botonCruzMadera
        Me.BorderColor = Color.Transparent
        Me.Size = New Size(47, 30)
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.CornerRadius = 20


    End Sub

End Class
