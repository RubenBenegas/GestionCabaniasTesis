Public Class lstEstadosReservas


    Private idEstado_ As Integer
    Public Property idEstado() As Integer
        Get
            Return idEstado_
        End Get
        Set(ByVal value As Integer)
            idEstado_ = value
        End Set
    End Property

    Dim reservas As New Reservas
 
    Private Sub lstEstadosReservas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        reservas.TraerTabReservas(dgvEstadoReservas)
        reservas.CargarComboEstados(cmbEstados)
    End Sub

    Private Sub dgvEstadoReservas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEstadoReservas.CellDoubleClick
        Editar()




        frmReservas.lblCostoEstadia.Visible = False
        frmReservas.txtCostoEstadia.Visible = False

        frmReservas.lblCostoAdicionales.Visible = False
        frmReservas.txtCostoAdicionales.Visible = False

        frmReservas.lblCostoTotal.Visible = False
        frmReservas.txtCostoTotal.Visible = False

        frmReservas.lblFaltaPAgar.Visible = False
        frmReservas.txtFaltaDePagar.Visible = False

        frmReservas.lblReservaCancelada.Visible = True
        frmReservas.RectangleShape1.Enabled = False
        frmReservas.RectangleShape2.Enabled = False
        frmReservas.RectangleShape8.Visible = False
        frmReservas.lblFechaSenia.Visible = False
        frmReservas.dtpFechaPagoSenia.Visible = False
        frmReservas.lblImporteSenia.Visible = False
        frmReservas.txtSenia.Visible = False

        frmReservas.RectangleShape7.Visible = False
        frmReservas.btnDetalleCancelacion.Visible = True

        'frmReservas.RectangleShape4.Visible = False
        'frmReservas.RectangleShape5.Visible = False

        'frmReservas.RectangleShape7.Visible = False



    End Sub


    Private Sub Editar()
        frmReservas.modificar = True

        If dgvEstadoReservas.Rows.Count <> 0 Then
            frmReservas.idReserva = dgvEstadoReservas.Item("id", dgvEstadoReservas.CurrentRow.Index).Value
            frmReservas.idCabania = dgvEstadoReservas.Item("IdCabania", dgvEstadoReservas.CurrentRow.Index).Value
            frmReservas.ShowDialog()
        Else
            MsgBox("No hay elementos para modificar.", MsgBoxStyle.Information, "Mensaje")
        End If

    End Sub

    Private Sub btnTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodos.Click
        reservas.TraerTabReservas(dgvEstadoReservas)
    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        Close()
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        reservas.ReservasFiltrarPorEstado(cmbEstados.SelectedValue, dgvEstadoReservas)
    End Sub
End Class
