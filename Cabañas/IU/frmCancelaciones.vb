Public Class frmCancelaciones
    Private idCancelacion_ As Integer
    Public Property idCancelacion() As Integer
        Get
            Return idCancelacion_
        End Get
        Set(ByVal value As Integer)
            idCancelacion_ = value
        End Set
    End Property


    Private modificar_ As Integer
    Public Property modificar() As Integer
        Get
            Return modificar_
        End Get
        Set(ByVal value As Integer)
            modificar_ = value
        End Set
    End Property


    Private idReserva_ As Integer
    Public Property idReserva() As Integer
        Get
            Return idReserva_
        End Get
        Set(ByVal value As Integer)
            idReserva_ = value
        End Set
    End Property


    Dim cancelacion As New Cancelaciones
    Private Sub frmCancelaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ErrorProvider1.Clear()
        If modificar = True Then
            Me.Text = "Modificar cancelacion"

            cancelacion = cancelacion.RecuperarCancelacion(idReserva)

            txtId.Text = cancelacion.Id
            dtpFechaCancelacion.Value = cancelacion.fCancelacion
            txtDescripcion.Text = cancelacion.Descripcion
            txtReembolso.Text = cancelacion.Reembolso
            idReserva = cancelacion.IdReserva



            dtpFechaCancelacion.Enabled = False
            txtDescripcion.Enabled = False
            txtReembolso.Enabled = False


            RectangleShape1.Visible = False
            RectangleShape3.Visible = False
            RectangleShape2.Visible = True
        Else
            Me.Text = "Agregar cancelacion"

            txtId.Text = Nothing
            dtpFechaCancelacion.Value = Today
            txtDescripcion.Text = Nothing
            txtReembolso.Text = Nothing
            idReserva = idReserva


            dtpFechaCancelacion.Enabled = True
            txtDescripcion.Enabled = True
            txtReembolso.Enabled = False

            RectangleShape1.Visible = True
            RectangleShape3.Visible = True
            RectangleShape2.Visible = False

            If DateDiff(DateInterval.Day, dtpFechaCancelacion.Value, frmReservas.dtpFechaIngreso.Value) > 14 Then

                txtReembolso.Text = CInt(frmReservas.txtSenia.Text) / 2
            Else

                txtReembolso.Text = 0

            End If


        End If
    End Sub

    'Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
    '    cancelacion.fCancelacion = dtpFechaCancelacion.Value
    '    cancelacion.Descripcion = txtDescripcion.Text
    '    cancelacion.Reembolso = txtReembolso.Text
    '    cancelacion.IdReserva = idReserva

    '    If modificar = True Then
    '        If cancelacion.ModificarCancelacion(cancelacion) = True Then
    '            frmReservas.idEstado = 5
    '            MsgBox("La cancelacion ha sido correctamente modificada.")

    '        Else
    '            MsgBox("Error al modificar la cancelacion." + Chr(13) + "Intentelo de nuevo.")
    '        End If
    '    Else
    '        If cancelacion.InsertarCancelacion(cancelacion) = True Then
    '            frmReservas.idEstado = 5
    '            MsgBox("La cancelacion ha sido correctamente insertada.")

    '        Else
    '            MsgBox("Error al insertar la cancelacion." + Chr(13) + "Intentelo de nuevo.")
    '        End If
    '    End If

    '    If DateDiff(DateInterval.Day, dtpFechaCancelacion.Value, frmReservas.dtpFechaIngreso.Value) > 14 Then
    '        'MessageBox.Show(DateDiff(DateInterval.Day, Today, reserva.fIngreso))
    '        frmReservas.lblReservaCancelada.Visible = True
    '        frmReservas.lblReembolso.Visible = True
    '        frmReservas.lblReembolso.ForeColor = Color.Green
    '        frmReservas.lblReembolso.Text = "Reembolso de: "
    '        frmReservas.txtReembolso.Visible = True
    '        frmReservas.txtReembolso.Text = txtReembolso.Text
    '    Else
    '        'MessageBox.Show(DateDiff(DateInterval.Day, Today, reserva.fIngreso))
    '        frmReservas.lblReservaCancelada.Visible = True
    '        frmReservas.lblReembolso.Visible = True
    '        frmReservas.lblReembolso.ForeColor = Color.Red
    '        frmReservas.lblReembolso.Text = "Sin reembolso"
    '        frmReservas.txtReembolso.Text = 0
    '        frmReservas.txtReembolso.Visible = False
    '    End If

    '    frmReservas.lblCostoEstadia.Visible = False
    '    frmReservas.txtCostoEstadia.Visible = False

    '    frmReservas.lblCostoAdicionales.Visible = False
    '    frmReservas.txtCostoAdicionales.Visible = False

    '    frmReservas.lblCostoTotal.Visible = False
    '    frmReservas.txtCostoTotal.Visible = False

    '    frmReservas.lblFaltaPAgar.Visible = False
    '    frmReservas.txtFaltaDePagar.Visible = False

    '    frmReservas.lblReservaCancelada.Visible = True
    '    frmReservas.btnAgregar.Enabled = False
    '    frmReservas.btnBorrar.Enabled = False
    '    frmReservas.btnConsultarCostos.Visible = False
    '    frmReservas.lblFechaSenia.Visible = False
    '    frmReservas.dtpFechaPagoSenia.Visible = False
    '    frmReservas.lblImporteSenia.Visible = False
    '    frmReservas.txtSenia.Visible = False

    '    frmReservas.btnCancelarReserva.Visible = False
    '    frmReservas.btnDetalleCancelacion.Visible = True

    '    Close()
    'End Sub


    Private Sub dtpFechaCancelacion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaCancelacion.LostFocus
        If DateDiff(DateInterval.Day, dtpFechaCancelacion.Value, frmReservas.dtpFechaIngreso.Value) > 14 Then

            txtReembolso.Text = CInt(frmReservas.txtSenia.Text) / 2
        Else

            txtReembolso.Text = 0

        End If

        'frmReservas.lblCostoEstadia.Visible = False
        'frmReservas.txtCostoEstadia.Visible = False

        'frmReservas.lblCostoAdicionales.Visible = False
        'frmReservas.txtCostoAdicionales.Visible = False

        'frmReservas.lblCostoTotal.Visible = False
        'frmReservas.txtCostoTotal.Visible = False

        'frmReservas.lblFaltaPAgar.Visible = False
        'frmReservas.txtFaltaDePagar.Visible = False

        'frmReservas.lblReservaCancelada.Visible = True
        'frmReservas.btnAgregar.Enabled = False
        'frmReservas.btnBorrar.Enabled = False
        'frmReservas.btnConsultarCostos.Visible = False
        'frmReservas.lblFechaSenia.Visible = False
        'frmReservas.dtpFechaPagoSenia.Visible = False
        'frmReservas.lblImporteSenia.Visible = False
        'frmReservas.txtSenia.Visible = False

        'frmReservas.btnEstadoReserva.Visible = False
        'frmReservas.btnDetalleCancelacion.Visible = True
    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click

        cancelacion.fCancelacion = dtpFechaCancelacion.Value
        cancelacion.Descripcion = txtDescripcion.Text
        cancelacion.Reembolso = txtReembolso.Text
        cancelacion.IdReserva = idReserva

        If modificar = True Then
            If cancelacion.ModificarCancelacion(cancelacion) = True Then
                frmReservas.idEstado = 5
                MsgBox("La cancelacion ha sido correctamente modificada.")

            Else
                MsgBox("Error al modificar la cancelacion." + Chr(13) + "Intentelo de nuevo.")
            End If
        Else
            If cancelacion.InsertarCancelacion(cancelacion) = True Then
                frmReservas.idEstado = 5
                MsgBox("La cancelacion ha sido correctamente insertada.")

            Else
                MsgBox("Error al insertar la cancelacion." + Chr(13) + "Intentelo de nuevo.")
            End If
        End If

        If DateDiff(DateInterval.Day, dtpFechaCancelacion.Value, frmReservas.dtpFechaIngreso.Value) > 14 Then
            'MessageBox.Show(DateDiff(DateInterval.Day, Today, reserva.fIngreso))
            frmReservas.lblReservaCancelada.Visible = True
            frmReservas.lblReembolso.Visible = True
            frmReservas.lblReembolso.ForeColor = Color.Green
            frmReservas.lblReembolso.Text = "Reembolso de: "
            frmReservas.txtReembolso.Visible = True
            frmReservas.txtReembolso.Text = txtReembolso.Text
        Else
            'MessageBox.Show(DateDiff(DateInterval.Day, Today, reserva.fIngreso))
            frmReservas.lblReservaCancelada.Visible = True
            frmReservas.lblReembolso.Visible = True
            frmReservas.lblReembolso.ForeColor = Color.Red
            frmReservas.lblReembolso.Text = "Sin reembolso"
            frmReservas.txtReembolso.Text = 0
            frmReservas.txtReembolso.Visible = False
        End If

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

        Close()
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        Close()
    End Sub

    Private Sub RectangleShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape3.Click
        Close()
    End Sub
End Class