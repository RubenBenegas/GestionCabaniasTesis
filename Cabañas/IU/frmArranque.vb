Public Class frmArranque

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 200 Then
            ProgressBar1.Value = ProgressBar1.Value + 10
            Label1.Text = "Cargando sistema: " + CStr(ProgressBar1.Value / 2) + "%"
        Else
            Timer1.Enabled = False
            Me.Hide()
            frmPrincipal.ShowDialog()

        End If
    End Sub
End Class