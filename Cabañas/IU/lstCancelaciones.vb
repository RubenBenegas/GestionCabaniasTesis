Public Class lstCancelaciones


    Dim cancelacion As New Cancelaciones
    Private Sub lstCancelaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cancelacion.TraerTabCancelaciones(DataGridView1)
        DataGridView1.RowsDefaultCellStyle.BackColor = Color.AliceBlue
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.AntiqueWhite
    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        Close()
    End Sub
End Class