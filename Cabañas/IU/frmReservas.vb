Public Class frmReservas
    Private modificar_ As Boolean
    Public Property modificar() As Boolean
        Get
            Return modificar_
        End Get
        Set(ByVal value As Boolean)
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


    Private idEstado_ As Integer
    Public Property idEstado() As Integer
        Get
            Return idEstado_
        End Get
        Set(ByVal value As Integer)
            idEstado_ = value
        End Set
    End Property


    Private idCabania_ As Integer
    Public Property idCabania() As Integer
        Get
            Return idCabania_
        End Get
        Set(ByVal value As Integer)
            idCabania_ = value
        End Set
    End Property




    Private montoDiferenciaEnTotal_ As Decimal
    Public Property montoDiferenciaEnTotal() As Decimal
        Get
            Return montoDiferenciaEnTotal_
        End Get
        Set(ByVal value As Decimal)
            montoDiferenciaEnTotal_ = value
        End Set
    End Property

    Dim reserva As New Reservas
    Dim cancelacion As New Cancelaciones
    Dim pagos As New Pagos
    Dim btnReserva As New BotonReservas
    Dim montoAntesModificar As New Decimal


#Region "Load"

    Private Sub frmReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ErrorProvider1.Clear()

        reserva.ReservasCargarAdicionales(idReserva, dgvServiciosAdicionales)

        


        'reserva.CargarComboCabania(cmbIdCabania)

        If modificar = True Then

            reserva = reserva.RecuperarReserva(idReserva)

            Dim desc As String
            desc = reserva.ReservasTraerDescripcionDeCabanias(idCabania)
            reserva.ReservasCabaniasFiltrarDisponibles(idCabania, desc, dtpFechaIngreso.Value, dtpFechaSalida.Value, cmbIdCabania)

            txtId.Text = reserva.Id
            dtpFechaReserva.Value = reserva.fReserva
            txtNombreHuesped.Text = reserva.NombreHuesped
            'txtNombreHuesped.Text = lstReservas.dgvReservas.Item("Huesped", lstReservas.dgvReservas.CurrentRow.Index).Value
            txtIdHuesped.Text = CStr(reserva.IdHuesped)
            dtpFechaIngreso.Value = reserva.fIngreso
            dtpFechaSalida.Value = reserva.fSalida
            cmbIdCabania.SelectedValue = reserva.IdCabania
            txtNumeroPasajeros.Text = reserva.NroPasajeros
            txtSenia.Text = reserva.Senia
            chkConSenia.Checked = reserva.ConSenia
            dtpFechaPagoSenia.Value = reserva.fPagoSenia
            dtpCheckin.Value = reserva.Checkin
            dtpCheckout.Value = reserva.Checkout
            txtCostoEstadia.Text = reserva.CostoEstadia
            txtCostoAdicionales.Text = reserva.CostoAdicionales
            txtCostoTotal.Text = reserva.CostoTotal

            'Aqui guardamos el monto antes de ser modificado
            montoAntesModificar = reserva.CostoTotal

            RectangleShape1.Enabled = True
            RectangleShape2.Enabled = True

            RectangleShape8.Visible = True

            lblFechaSenia.Visible = True
            dtpFechaPagoSenia.Visible = True
            lblImporteSenia.Visible = True
            txtSenia.Visible = True

            idEstado = reserva.IdEstado

            If idEstado = 5 Then

                cancelacion.RecuperarCancelacion(idReserva)

                lblCostoEstadia.Visible = False
                txtCostoEstadia.Visible = False
                lblCostoAdicionales.Visible = False
                txtCostoAdicionales.Visible = False
                lblCostoTotal.Visible = False
                txtCostoTotal.Visible = False
                lblFaltaPAgar.Visible = False
                txtFaltaDePagar.Visible = False
                lblReservaCancelada.Visible = True
                RectangleShape1.Enabled = False
                RectangleShape2.Enabled = False
                RectangleShape8.Visible = False
                lblFechaSenia.Visible = False
                dtpFechaPagoSenia.Visible = False
                lblImporteSenia.Visible = False
                txtSenia.Visible = False
                txtReembolso.Visible = True
                txtReembolso.Text = cancelacion.Reembolso
                lblReembolso.Visible = True
                RectangleShape7.Visible = False
                RectangleShape9.Visible = True
                btnDetalleCancelacion.Visible = True

                'ACA CALCULAMOS EL REEMBOLSO Y HAY QUE LLEVARLO PARA EL LADO DE CANCELACIONES
                If DateDiff(DateInterval.Day, cancelacion.fCancelacion, reserva.fIngreso) > 14 Then
                    lblReembolso.Visible = True
                    lblReembolso.ForeColor = Color.White
                    lblReembolso.BackColor = Color.Transparent
                    lblReembolso.Text = "Reembolso de: "
                    txtReembolso.Visible = True
                    txtReembolso.Text = CStr(reserva.Senia / 2)
                Else
                    lblReembolso.Visible = True
                    lblReembolso.ForeColor = Color.Red
                    lblReembolso.Text = "Sin reembolso"
                    txtReembolso.Text = 0
                    txtReembolso.Visible = False
                End If
            Else


                lblCostoEstadia.Visible = True
                txtCostoEstadia.Visible = True
                lblCostoAdicionales.Visible = True
                txtCostoAdicionales.Visible = True
                lblCostoTotal.Visible = True
                txtCostoTotal.Visible = True
                lblFaltaPAgar.Visible = True
                txtFaltaDePagar.Visible = True
                lblReservaCancelada.Visible = False
                lblReembolso.Visible = False
                txtReembolso.Text = 0
                txtReembolso.Visible = False
                RectangleShape8.Visible = True
                lblFechaSenia.Visible = True
                dtpFechaPagoSenia.Visible = True
                lblImporteSenia.Visible = True
                txtSenia.Visible = True
                RectangleShape9.Visible = False
                btnDetalleCancelacion.Visible = False


                RectangleShape7.Visible = True
                

            End If

            If dtpFechaSalida.Value >= Today Then
                RectangleShape7.Visible = True
            Else
                RectangleShape7.Visible = False
            End If

            Me.Text = "Modificar reserva"

        Else

            reserva.ReservasCabaniasFiltrarDisponibles(dtpFechaIngreso.Value, dtpFechaSalida.Value, cmbIdCabania)

            txtId.Text = Nothing
            dtpFechaReserva.Value = Today
            txtIdHuesped.Text = Nothing
            txtNombreHuesped.Text = Nothing
            dtpFechaIngreso.Value = Today
            dtpFechaSalida.Value = Today.AddDays(1)

            txtNumeroPasajeros.Text = Nothing
            txtSenia.Text = Nothing
            chkConSenia.Checked = Nothing
            dtpCheckin.Value = Today
            dtpCheckout.Value = dtpFechaSalida.Value
            lblCostoEstadia.Visible = True
            txtCostoEstadia.Visible = True
            txtCostoEstadia.Text = Nothing

            lblCostoAdicionales.Visible = True
            txtCostoAdicionales.Visible = True
            txtCostoAdicionales.Text = Nothing

            lblCostoTotal.Visible = True
            txtCostoTotal.Visible = True
            txtCostoTotal.Text = Nothing

            lblFaltaPAgar.Visible = True


            txtFaltaDePagar.Visible = True

            txtFaltaDePagar.Text = Nothing


            lblReembolso.Visible = False

            txtReembolso.Text = Nothing


            txtReembolso.Text = Nothing
            txtReembolso.Visible = False


            lblReservaCancelada.Visible = False


            RectangleShape1.Enabled = True
            RectangleShape2.Enabled = True

            RectangleShape8.Visible = True

            RectangleShape9.Visible = False
            lblFechaSenia.Visible = True
            dtpFechaPagoSenia.Visible = True

            If dtpFechaReserva.Value.DayOfWeek = DayOfWeek.Friday Then
                dtpFechaPagoSenia.Value = dtpFechaReserva.Value.Date.AddDays(3)
            ElseIf dtpFechaReserva.Value.DayOfWeek = DayOfWeek.Saturday Then
                dtpFechaPagoSenia.Value = dtpFechaReserva.Value.Date.AddDays(2)
            Else
                dtpFechaPagoSenia.Value = dtpFechaReserva.Value.Date.AddDays(1)
            End If




            lblImporteSenia.Visible = True
            txtSenia.Visible = True


            RectangleShape7.Visible = False
            btnDetalleCancelacion.Visible = False

            idEstado = 1


            Me.Text = "Agregar reserva"
        End If



    End Sub
#End Region

#Region "Boton aceptar"
    Dim fun As New Validaciones
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If fun.validarCampos(Me, ErrorProvider1) = True Then


        '    Dim montoDiferencia As New Decimal
        '    montoDiferencia = CDec(txtCostoTotal.Text) - montoAntesModificar


        '    reserva.fReserva = dtpFechaReserva.Value
        '    reserva.IdHuesped = txtIdHuesped.Text
        '    reserva.fIngreso = dtpFechaIngreso.Value
        '    reserva.fSalida = dtpFechaSalida.Value
        '    reserva.IdCabania = cmbIdCabania.SelectedValue
        '    reserva.NroPasajeros = txtNumeroPasajeros.Text
        '    reserva.ConSenia = chkConSenia.Checked

        '    If idEstado <> 5 Then
        '        If reserva.ConSenia = True Then
        '            reserva.Senia = txtSenia.Text
        '            idEstado = 1
        '        Else
        '            reserva.Senia = 0
        '            idEstado = 2
        '        End If

        '        Dim montoTotal As Decimal
        '        Dim montoPagos As Decimal
        '        montoTotal = reserva.ReservasTraerMontoTotal(txtId.Text)
        '        montoPagos = pagos.PagosTraerTotalPagosPorReserva(txtId.Text)
        '        If montoPagos >= CDec(txtSenia.Text) And montoPagos < montoTotal + montoDiferencia Then
        '            idEstado = 3
        '        End If
        '        If (montoDiferencia + montoTotal) - montoPagos <= 0 Then
        '            idEstado = 4
        '        End If

        '    End If

        '    reserva.fPagoSenia = dtpFechaPagoSenia.Value
        '    reserva.Checkin = dtpCheckin.Value
        '    reserva.Checkout = dtpCheckout.Value
        '    reserva.CostoEstadia = txtCostoEstadia.Text
        '    reserva.CostoAdicionales = txtCostoAdicionales.Text
        '    reserva.CostoTotal = txtCostoTotal.Text
        '    reserva.IdEstado = idEstado

        '    If modificar = True Then
        '        If reserva.ModificarReserva(reserva) = True Then
        '            MsgBox("La reserva ha sido correctamente modificada.")
        '        Else
        '            MsgBox("Error al modificar la reserva." + Chr(13) + "Intentelo de nuevo.")
        '        End If
        '    Else
        '        If txtId.Text = "" Then
        '            If reserva.InsertarReserva(reserva) = False Then
        '                MsgBox("Error al insertar la reserva." + Chr(13) + "Intentelo de nuevo.")
        '            Else

        '                MsgBox("La reserva ha sido correctamente insertada.")
        '            End If
        '            'Else
        '            '    MsgBox("Error al insertar la reserva." + Chr(13) + "Intentelo de nuevo.")
        '        End If
        '    End If
        '    Close()
        'Else
        '    MsgBox("Completar los campos obligatorios.", MsgBoxStyle.Information, "Importante")
        'End If
    End Sub

#End Region

#Region "Boton Cancelar"
    'Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
    '    Close()
    'End Sub
#End Region

#Region "Boton buscar huesped"
    Private Sub btnBuscarHuesped_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarHuesped.Click
        lstConsHuesped.ShowDialog()
    End Sub
#End Region

#Region "Boton agregar servicio"
    'Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
    '    If txtId.Text = "" Then

    '        reserva.fReserva = dtpFechaReserva.Value
    '        reserva.IdHuesped = txtIdHuesped.Text
    '        reserva.fIngreso = dtpFechaIngreso.Value
    '        reserva.fSalida = dtpFechaSalida.Value
    '        reserva.IdCabania = cmbIdCabania.SelectedValue
    '        reserva.NroPasajeros = txtNumeroPasajeros.Text
    '        reserva.ConSenia = chkConSenia.Checked
    '        If reserva.ConSenia = True Then
    '            reserva.Senia = txtSenia.Text
    '            idEstado = 1
    '        Else
    '            reserva.Senia = 0
    '            idEstado = 2
    '        End If

    '        reserva.fPagoSenia = dtpFechaPagoSenia.Value
    '        reserva.Checkin = dtpCheckin.Value
    '        reserva.Checkout = dtpCheckout.Value
    '        reserva.CostoEstadia = txtCostoEstadia.Text
    '        reserva.CostoAdicionales = txtCostoAdicionales.Text
    '        reserva.CostoTotal = txtCostoTotal.Text
    '        reserva.IdEstado = idEstado



    '        reserva.InsertarReserva(reserva)
    '        reserva.Id = reserva.ReservasTraerUltimo
    '        txtId.Text = reserva.Id

    '    End If
    '    lstReservasAdicionales.idReserva = txtId.Text
    '    lstReservasAdicionales.ShowDialog()
    ' End Sub
#End Region

#Region "Boton borrar servicio"
    'Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

    '    Dim idAdicional As Integer = dgvServiciosAdicionales.Item("id", dgvServiciosAdicionales.CurrentRow.Index).Value
    '    reserva.ReservaAdicionalBorrar(idAdicional)
    '    reserva.ReservasCargarAdicionales(txtId.Text, dgvServiciosAdicionales)
    'End Sub
#End Region


    'ESTE BOTON SOLAMENTE SE UTILIZA CUANDO ACCEDEMOS DESDE EL HISTORIAL DE HUESPEDES

#Region "Boton salir (desde huespedes)"
    'Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

    '    Close()

    '    dtpFechaIngreso.Enabled = True
    '    dtpFechaSalida.Enabled = True
    '    dtpCheckin.Enabled = True
    '    dtpCheckout.Enabled = True
    '    RectangleShape4.Visible = True
    '    RectangleShape5.Visible = True
    '    RectangleShape1.Visible = True
    '    RectangleShape2.Visible = True
    '    cmbIdCabania.Enabled = True
    '    txtNumeroPasajeros.Enabled = True
    '    txtSenia.Enabled = True
    '    chkConSenia.Enabled = True

    '    btnConsultarCostos.Visible = True
    '    btnSalir.Visible = False
    'End Sub
#End Region

#Region "Consultar costo"
    'Private Sub btnConsultarCostos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarCostos.Click
    '    Dim montoCabania As Decimal
    '    montoCabania = reserva.ReservaTraerMontoDeCabania(cmbIdCabania.SelectedValue)
    '    Dim dias As Integer
    '    dias = DateDiff(DateInterval.Day, dtpFechaIngreso.Value, dtpFechaSalida.Value)
    '    txtCostoEstadia.Text = dias * montoCabania

    '    If dgvServiciosAdicionales.Rows.Count = 0 Then
    '        txtCostoAdicionales.Text = 0
    '    Else
    '        txtCostoAdicionales.Text = reserva.ReservaCostoAdicionales(idReserva)
    '    End If

    '    If chkConSenia.Checked = True Then
    '        txtSenia.Text = CInt(txtCostoEstadia.Text) / 2
    '    Else
    '        txtSenia.Text = 0
    '    End If

    '    txtCostoTotal.Text = CDec(txtCostoEstadia.Text) + CDec(txtCostoAdicionales.Text)
    '    dtpFechaPagoSenia.Value = dtpFechaReserva.Value.Date.AddDays(3)

    'End Sub
#End Region

#Region "Boton cancelacion"
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarReserva.Click
    '    frmCancelaciones.idReserva = txtId.Text
    '    frmCancelaciones.ShowDialog()
    'End Sub
#End Region

#Region "Boton detalle de cancelacion"
    'Private Sub btnDetalleCancelacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalleCancelacion.Click
    '    frmCancelaciones.idReserva = txtId.Text
    '    frmCancelaciones.modificar = True
    '    frmCancelaciones.ShowDialog()
    'End Sub
#End Region

#Region "Boton pagos"
    'Private Sub btnPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagos.Click

    'If txtId.Text = "" Then


    '    reserva.fReserva = dtpFechaReserva.Value
    '    reserva.IdHuesped = txtIdHuesped.Text
    '    reserva.fIngreso = dtpFechaIngreso.Value
    '    reserva.fSalida = dtpFechaSalida.Value
    '    reserva.IdCabania = cmbIdCabania.SelectedValue
    '    reserva.NroPasajeros = txtNumeroPasajeros.Text
    '    reserva.ConSenia = chkConSenia.Checked
    '    If reserva.ConSenia = True Then
    '        reserva.Senia = txtSenia.Text
    '        idEstado = 1
    '    Else
    '        reserva.Senia = 0
    '        idEstado = 2
    '    End If

    '    reserva.fPagoSenia = dtpFechaPagoSenia.Value
    '    reserva.Checkin = dtpCheckin.Value
    '    reserva.Checkout = dtpCheckout.Value
    '    reserva.CostoEstadia = txtCostoEstadia.Text
    '    reserva.CostoAdicionales = txtCostoAdicionales.Text
    '    reserva.CostoTotal = txtCostoTotal.Text
    '    reserva.IdEstado = idEstado

    '    reserva.InsertarReserva(reserva)
    '    reserva.Id = reserva.ReservasTraerUltimo
    '    txtId.Text = reserva.Id
    'End If

    'Dim montoDiferencia As New Decimal
    'montoDiferencia = CDec(txtCostoTotal.Text) - montoAntesModificar
    'montoDiferenciaEnTotal = montoDiferencia

    'lstPagos.ShowDialog()
    'End Sub
#End Region

#Region "Eventos"
    Private Sub dtpFechaIngreso_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaIngreso.LostFocus
        dtpCheckin.Value = dtpFechaIngreso.Value
    End Sub

    Private Sub dtpFechaSalida_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaSalida.LostFocus
        dtpCheckout.Value = dtpFechaSalida.Value
    End Sub

    Private Sub dtpFechaReserva_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaReserva.LostFocus
        If dtpFechaReserva.Value.DayOfWeek = DayOfWeek.Friday Then
            dtpFechaPagoSenia.Value = dtpFechaReserva.Value.Date.AddDays(3)
        ElseIf dtpFechaReserva.Value.DayOfWeek = DayOfWeek.Saturday Then
            dtpFechaPagoSenia.Value = dtpFechaReserva.Value.Date.AddDays(2)
        Else
            dtpFechaPagoSenia.Value = dtpFechaReserva.Value.Date.AddDays(1)
        End If
    End Sub



    Private Sub cmbIdCabania_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbIdCabania.GotFocus

        If modificar = True Then
            Dim desc As String
            desc = reserva.ReservasTraerDescripcionDeCabanias(idCabania)
            reserva.ReservasCabaniasFiltrarDisponibles(idCabania, desc, dtpFechaIngreso.Value, dtpFechaSalida.Value, cmbIdCabania)
        Else
            reserva.ReservasCabaniasFiltrarDisponibles(dtpFechaIngreso.Value, dtpFechaSalida.Value, cmbIdCabania)
        End If
        
    End Sub
#End Region


    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        If txtId.Text = "" Then

            reserva.fReserva = dtpFechaReserva.Value
            reserva.IdHuesped = txtIdHuesped.Text
            reserva.fIngreso = dtpFechaIngreso.Value
            reserva.fSalida = dtpFechaSalida.Value
            reserva.IdCabania = cmbIdCabania.SelectedValue
            reserva.NroPasajeros = txtNumeroPasajeros.Text
            reserva.ConSenia = chkConSenia.Checked
            If reserva.ConSenia = True Then
                reserva.Senia = txtSenia.Text
                idEstado = 1
            Else
                reserva.Senia = 0
                idEstado = 2
            End If

            reserva.fPagoSenia = dtpFechaPagoSenia.Value
            reserva.Checkin = dtpCheckin.Value
            reserva.Checkout = dtpCheckout.Value
            reserva.CostoEstadia = txtCostoEstadia.Text
            reserva.CostoAdicionales = txtCostoAdicionales.Text
            reserva.CostoTotal = txtCostoTotal.Text
            reserva.IdEstado = idEstado



            reserva.InsertarReserva(reserva)
            reserva.Id = reserva.ReservasTraerUltimo
            txtId.Text = reserva.Id

        End If
        lstReservasAdicionales.idReserva = txtId.Text
        lstReservasAdicionales.ShowDialog()
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        Dim idAdicional As Integer = dgvServiciosAdicionales.Item("id", dgvServiciosAdicionales.CurrentRow.Index).Value
        reserva.ReservaAdicionalBorrar(idAdicional)
        reserva.ReservasCargarAdicionales(txtId.Text, dgvServiciosAdicionales)
    End Sub

    Private Sub RectangleShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape3.Click
        If txtId.Text = "" Then


            reserva.fReserva = dtpFechaReserva.Value
            reserva.IdHuesped = txtIdHuesped.Text
            reserva.fIngreso = dtpFechaIngreso.Value
            reserva.fSalida = dtpFechaSalida.Value
            reserva.IdCabania = cmbIdCabania.SelectedValue
            reserva.NroPasajeros = txtNumeroPasajeros.Text
            reserva.ConSenia = chkConSenia.Checked
            If reserva.ConSenia = True Then
                reserva.Senia = txtSenia.Text
                idEstado = 1
            Else
                reserva.Senia = 0
                idEstado = 2
            End If

            reserva.fPagoSenia = dtpFechaPagoSenia.Value
            reserva.Checkin = dtpCheckin.Value
            reserva.Checkout = dtpCheckout.Value
            reserva.CostoEstadia = txtCostoEstadia.Text
            reserva.CostoAdicionales = txtCostoAdicionales.Text
            reserva.CostoTotal = txtCostoTotal.Text
            reserva.IdEstado = idEstado

            reserva.InsertarReserva(reserva)
            reserva.Id = reserva.ReservasTraerUltimo
            txtId.Text = reserva.Id
        End If

        Dim montoDiferencia As New Decimal
        montoDiferencia = CDec(txtCostoTotal.Text) - montoAntesModificar
        montoDiferenciaEnTotal = montoDiferencia

        lstPagos.ShowDialog()
    End Sub

    Private Sub RectangleShape4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape4.Click
        If fun.validarCampos(Me, ErrorProvider1) = True Then


            Dim montoDiferencia As New Decimal
            montoDiferencia = CDec(txtCostoTotal.Text) - montoAntesModificar


            reserva.fReserva = dtpFechaReserva.Value
            reserva.IdHuesped = txtIdHuesped.Text
            reserva.fIngreso = dtpFechaIngreso.Value
            reserva.fSalida = dtpFechaSalida.Value
            reserva.IdCabania = cmbIdCabania.SelectedValue
            reserva.NroPasajeros = txtNumeroPasajeros.Text
            reserva.ConSenia = chkConSenia.Checked

            If idEstado <> 5 Then
                If reserva.ConSenia = True Then
                    reserva.Senia = txtSenia.Text
                    idEstado = 1
                Else
                    reserva.Senia = 0
                    idEstado = 2
                End If

                If txtId.Text <> "" Then


                    Dim montoTotal As Decimal
                    Dim montoPagos As Decimal
                    montoTotal = reserva.ReservasTraerMontoTotal(txtId.Text)
                    montoPagos = pagos.PagosTraerTotalPagosPorReserva(txtId.Text)
                    If montoPagos >= CDec(txtSenia.Text) And montoPagos < montoTotal + montoDiferencia Then
                        idEstado = 3
                    End If
                    If (montoDiferencia + montoTotal) - montoPagos <= 0 Then
                        idEstado = 4
                    End If
                End If

            End If

            reserva.fPagoSenia = dtpFechaPagoSenia.Value
            reserva.Checkin = dtpCheckin.Value
            reserva.Checkout = dtpCheckout.Value
            reserva.CostoEstadia = txtCostoEstadia.Text
            reserva.CostoAdicionales = txtCostoAdicionales.Text
            reserva.CostoTotal = txtCostoTotal.Text
            reserva.IdEstado = idEstado

            If modificar = True Then
                If reserva.ModificarReserva(reserva) = True Then
                    MsgBox("La reserva ha sido correctamente modificada.")
                Else
                    MsgBox("Error al modificar la reserva." + Chr(13) + "Intentelo de nuevo.")
                End If
            Else
                If txtId.Text = "" Then
                    If reserva.InsertarReserva(reserva) = False Then
                        MsgBox("Error al insertar la reserva." + Chr(13) + "Intentelo de nuevo.")
                    Else

                        MsgBox("La reserva ha sido correctamente insertada.")

                    End If
                    'Else
                    '    MsgBox("Error al insertar la reserva." + Chr(13) + "Intentelo de nuevo.")
                End If
            End If
            Close()
        Else
            MsgBox("Completar los campos obligatorios.", MsgBoxStyle.Information, "Importante")
        End If
    End Sub

    Private Sub RectangleShape5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape5.Click
        Close()
    End Sub

    Private Sub RectangleShape6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape6.Click
        Close()

        dtpFechaIngreso.Enabled = True
        dtpFechaSalida.Enabled = True
        dtpCheckin.Enabled = True
        dtpCheckout.Enabled = True
        RectangleShape4.Visible = True
        RectangleShape5.Visible = True
        RectangleShape1.Visible = True
        RectangleShape2.Visible = True
        cmbIdCabania.Enabled = True
        txtNumeroPasajeros.Enabled = True
        txtSenia.Enabled = True
        chkConSenia.Enabled = True

        RectangleShape8.Visible = True
        RectangleShape6.Visible = False
    End Sub

    Private Sub RectangleShape7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape7.Click
        frmCancelaciones.idReserva = txtId.Text
        frmCancelaciones.ShowDialog()
    End Sub

    Private Sub RectangleShape8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape8.Click
        Dim montoCabania As Decimal
        montoCabania = reserva.ReservaTraerMontoDeCabania(cmbIdCabania.SelectedValue)
        Dim dias As Integer
        dias = DateDiff(DateInterval.Day, dtpFechaIngreso.Value, dtpFechaSalida.Value)
        txtCostoEstadia.Text = dias * montoCabania

        If dgvServiciosAdicionales.Rows.Count = 0 Then
            txtCostoAdicionales.Text = 0
        Else
            txtCostoAdicionales.Text = reserva.ReservaCostoAdicionales(idReserva)
        End If

        If chkConSenia.Checked = True Then
            txtSenia.Text = CInt(txtCostoEstadia.Text) / 2
        Else
            txtSenia.Text = 0
        End If

        txtCostoTotal.Text = CDec(txtCostoEstadia.Text) + CDec(txtCostoAdicionales.Text)
        dtpFechaPagoSenia.Value = dtpFechaReserva.Value.Date.AddDays(3)

    End Sub

    Private Sub RectangleShape9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape9.Click
        frmCancelaciones.idReserva = txtId.Text
        frmCancelaciones.modificar = True
        frmCancelaciones.ShowDialog()
    End Sub
End Class


