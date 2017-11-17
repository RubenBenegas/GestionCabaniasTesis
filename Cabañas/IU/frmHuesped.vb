Public Class frmHuesped

    Private modificar_ As Boolean
    Public Property modificar() As Boolean
        Get
            Return modificar_
        End Get
        Set(ByVal value As Boolean)
            modificar_ = value
        End Set
    End Property

    Private idHuesped_ As Integer
    Public Property idHuesped() As Integer
        Get
            Return idHuesped_
        End Get
        Set(ByVal value As Integer)
            idHuesped_ = value
        End Set
    End Property

    Dim huesped As New Huespedes
    Private Sub frmHuesped_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ErrorProvider1.Clear()
        If modificar = True Then
            Me.Text = "Modificar Huesped"

            huesped = huesped.RecuperarHuesped(idHuesped)

            txtId.Text = huesped.id
            txtNombre.Text = huesped.nombre
            txtDni.Text = huesped.dni
            txtLocalidad.Text = huesped.localidad
            txtDireccion.Text = huesped.direccion
            txtTelefono.Text = huesped.telefono
            txtEmail.Text = huesped.email
        Else
            Me.Text = "Agregar Huesped"

            txtId.Text = Nothing
            txtNombre.Text = Nothing
            txtDni.Text = Nothing
            txtLocalidad.Text = Nothing
            txtDireccion.Text = Nothing
            txtTelefono.Text = Nothing
            txtEmail.Text = Nothing
        End If

        huesped.HuespedTraerHistorial(idHuesped, dgvHistorial)

       

    End Sub

    Dim fun As New Validaciones

    Private Sub dgvHistorial_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvHistorial.CellDoubleClick

        frmReservas.modificar = True
        If dgvHistorial.Rows.Count <> 0 Then
            frmReservas.idReserva = dgvHistorial.Item("id", dgvHistorial.CurrentRow.Index).Value
            frmReservas.dtpFechaIngreso.Enabled = False
            frmReservas.dtpFechaSalida.Enabled = False
            frmReservas.dtpCheckin.Enabled = False
            frmReservas.dtpCheckout.Enabled = False
            frmReservas.RectangleShape4.Visible = False
            frmReservas.RectangleShape5.Visible = False
            frmReservas.RectangleShape1.Visible = False
            frmReservas.RectangleShape2.Visible = False
            frmReservas.cmbIdCabania.Enabled = False
            frmReservas.txtNumeroPasajeros.Enabled = False
            frmReservas.txtSenia.Enabled = False
            frmReservas.chkConSenia.Enabled = False

            frmReservas.RectangleShape8.Visible = False
            frmReservas.RectangleShape6.Visible = True

            frmReservas.ShowDialog()
            'Else          
            '    MsgBox("No hay elementos para modificar.", MsgBoxStyle.Information, "Mensaje")
        End If
    End Sub

    'VALIDACIONES

    Private Sub txtLocalidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLocalidad.KeyPress

        If Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "," Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtLocalidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLocalidad.LostFocus

        If txtLocalidad.Text <> "" Then
            txtLocalidad.Text = fun.validarNombre(txtLocalidad.Text)
        End If

    End Sub

    Private Sub txtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccion.KeyPress

        If Char.IsNumber(e.KeyChar) Or Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtDireccion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDireccion.LostFocus

        If txtDireccion.Text <> "" Then
            txtDireccion.Text = fun.validarNombre(txtDireccion.Text)
        End If

    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress

        If e.KeyChar = "+" Or e.KeyChar = "-" Or Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    
    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        If fun.validarCampos(Me, ErrorProvider1) = True Then

            huesped.nombre = txtNombre.Text
            huesped.dni = txtDni.Text
            huesped.localidad = txtLocalidad.Text
            huesped.direccion = txtDireccion.Text
            huesped.telefono = txtTelefono.Text
            huesped.email = txtEmail.Text

            If modificar = True Then
                If huesped.ModificarHuesped(huesped) = True Then
                    MsgBox("El huesped ha sido correctamente modificado.")
                    huesped.TraerTabHuespedes(lstHuesped.dgvHuesped)
                Else
                    MsgBox("Error al modificar el huesped." + Chr(13) + "Intentelo de nuevo.")
                End If
            Else
                If huesped.InsertarHuesped(huesped) = True Then
                    MsgBox("El huesped ha sido correctamente insertado.")
                    huesped.TraerTabHuespedes(lstHuesped.dgvHuesped)
                Else
                    MsgBox("Error al insertar huesped." + Chr(13) + "Intentelo de nuevo.")
                End If
            End If
            Close()
        Else
            MsgBox("Completar los campos obligatorios.", MsgBoxStyle.Information, "Importante")
        End If
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        Close()
    End Sub
End Class