Imports System.Windows.Forms

Public Class frmPrincipal


    Private Sub HuespedesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HuespedesToolStripMenuItem.Click

        lstHuesped.ShowDialog()

    End Sub

    Private Sub PersonalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalToolStripMenuItem.Click

        z.ShowDialog()

    End Sub

    Private Sub InsumosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsumosToolStripMenuItem.Click
        lstGastos.ShowDialog()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click

        LstProveedor.ShowDialog()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click

        Dim respuesta As Integer

        respuesta = MsgBox("¿Seguro quieres salir?", MsgBoxStyle.YesNo, "Salir")

        If respuesta = vbYes Then
            Me.Close()
        End If

    End Sub

 
    Private Sub CabañasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CabañasToolStripMenuItem.Click

        lstcabania.ShowDialog()

    End Sub

    Private Sub TipoCabaniaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoCabaniaToolStripMenuItem.Click
        lstTipoCabania.ShowDialog()

    End Sub

    Private Sub ReservasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReservasToolStripMenuItem.Click
        grafReservas.ShowDialog()
    End Sub

    Private Sub PruebaABMReservasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PruebaABMReservasToolStripMenuItem.Click
        lstReservas.ShowDialog()
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiciosToolStripMenuItem.Click
        lstServicios.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        lstAdicional.ShowDialog()
    End Sub

    Private Sub EstadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstadoToolStripMenuItem.Click
        lstEstadosReservas.ShowDialog()

    End Sub

    Private Sub PagosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lstPagos.ShowDialog()

    End Sub

    Private Sub CancelacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelacionesToolStripMenuItem.Click
        lstCancelaciones.ShowDialog()

    End Sub

    Private Sub frmPrincipal_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frmArranque.Close()

    End Sub

    Private Sub OvalShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape1.Click
        OvalShape1.Size = New Size(75, 75)
        OvalShape1.BackgroundImage = My.Resources.IconoCabania
        OvalShape1.BorderStyle = Drawing2D.DashStyle.Custom
        OvalShape1.BorderWidth = 0
        lstcabania.ShowDialog()
    End Sub

    Private Sub OvalShape1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape1.MouseHover
        OvalShape1.Size = New Size(82, 82)
        OvalShape1.BackgroundImage = My.Resources.IconoCabaniaSombra
        OvalShape1.BorderStyle = Drawing2D.DashStyle.Custom
        OvalShape1.BorderWidth = 0

    End Sub

    Private Sub OvalShape1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape1.MouseLeave
        OvalShape1.Size = New Size(75, 75)
        OvalShape1.BackgroundImage = My.Resources.IconoCabania
        OvalShape1.BorderStyle = Drawing2D.DashStyle.Custom
        OvalShape1.BorderWidth = 0
    End Sub

    Private Sub OvalShape2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape2.MouseHover
        OvalShape2.Size = New Size(82, 82)
        OvalShape2.BackgroundImage = My.Resources.IconoHuespedSombra2
        OvalShape2.BorderStyle = Drawing2D.DashStyle.Custom
        OvalShape2.BorderWidth = 0
    End Sub

    Private Sub OvalShape2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape2.MouseLeave
        OvalShape2.Size = New Size(75, 75)
        OvalShape2.BackgroundImage = My.Resources.IconoHuesped
        OvalShape2.BorderStyle = Drawing2D.DashStyle.Custom
        OvalShape2.BorderWidth = 0
    End Sub

    Private Sub OvalShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape2.Click
        OvalShape2.Size = New Size(75, 75)
        OvalShape2.BackgroundImage = My.Resources.IconoHuesped
        OvalShape2.BorderStyle = Drawing2D.DashStyle.Custom
        OvalShape2.BorderWidth = 0
        lstHuesped.ShowDialog()
    End Sub

    Private Sub OvalShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape3.Click
        OvalShape3.Size = New Size(75, 75)
        OvalShape3.BackgroundImage = My.Resources.IconoCalendario2
        OvalShape3.BorderStyle = Drawing2D.DashStyle.Custom
        OvalShape3.BorderWidth = 0
        grafReservas.ShowDialog()
    End Sub


    Private Sub OvalShape3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape3.MouseHover
        OvalShape3.Size = New Size(82, 82)
        OvalShape3.BackgroundImage = My.Resources.IconoCalendarioSombra
        OvalShape3.BorderStyle = Drawing2D.DashStyle.Custom
        OvalShape3.BorderWidth = 0
    End Sub

    Private Sub OvalShape3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape3.MouseLeave
        OvalShape3.Size = New Size(75, 75)
        OvalShape3.BackgroundImage = My.Resources.IconoCalendario2
        OvalShape3.BorderStyle = Drawing2D.DashStyle.Custom
        OvalShape3.BorderWidth = 0
    End Sub


End Class
