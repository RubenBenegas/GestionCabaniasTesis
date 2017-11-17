Public Class Huecos
    Inherits Button

    Public Sub New(ByVal cantDias As Integer, ByVal anchoDia As Integer)
        Me.FlatStyle = Windows.Forms.FlatStyle.Flat
        Me.BackColor = Color.LightGray
        Me.ForeColor = Color.Transparent
        Me.Margin = New Padding(0, 0, 0, 0)
        Me.Height = 32
        Me.Width = cantDias * anchoDia
    End Sub

End Class
