Public Class frmPersonal
    Private Modificar_ As Boolean
    Public Property Modificar() As Boolean
        Get
            Return Modificar_
        End Get
        Set(ByVal value As Boolean)
            Modificar_ = value
        End Set
    End Property


    Private IdPersonal_ As Integer
    Public Property IdPersonal() As Integer
        Get
            Return IdPersonal_
        End Get
        Set(ByVal value As Integer)
            IdPersonal_ = value
        End Set
    End Property

    Dim Personal As New Personal
    Private Sub frmPersonal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ErrorProvider1.Clear()

        Personal.CargarComboPersonal(cmbDepartamento)
        If Modificar = True Then

            Me.Text = "Modificar Personal"

            Personal = Personal.PersonalRecuperar(IdPersonal)

            txtId.Text = Personal.Id
            txtNombre.Text = Personal.Nombre
            txtDireccion.Text = Personal.Direccion
            txtTelefono.Text = Personal.Telefono
            cmbDepartamento.SelectedValue = Personal.Departamento
            txtSueldoPorMes.Text = Personal.SueldoPorMes


        Else

            Me.Text = "Agregar Personal"

            txtId.Text = Nothing
            txtNombre.Text = Nothing
            txtDireccion.Text = Nothing
            txtTelefono.Text = Nothing
            txtSueldoPorMes.Text = Nothing


        End If
    End Sub

    Dim fun As New Validaciones

    'VALIDACIONES

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

    Private Sub txtDepartamento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtSueldoPorMes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSueldoPorMes.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "," Then

            e.Handled = False

        Else

            e.Handled = True

        End If
    End Sub


    Private Sub txtSueldoPorMes_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSueldoPorMes.LostFocus
        txtSueldoPorMes.Text = fun.validarImporte(txtSueldoPorMes.Text)
    End Sub


    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        If fun.validarCampos(Me, ErrorProvider1) = True Then

            Personal.Nombre = txtNombre.Text
            Personal.Direccion = txtDireccion.Text
            Personal.Telefono = txtTelefono.Text
            Personal.Departamento = cmbDepartamento.SelectedValue
            Personal.SueldoPorMes = txtSueldoPorMes.Text


            If Modificar = True Then
                If Personal.PersonalModificar(Personal) = True Then
                    MsgBox("El personal ha sido correctamente modificado.")
                    Personal.PersonalTraerTab(z.dgvPersonal)
                Else
                    MsgBox("Error al modificar el personsal." + Chr(13) + "Intentelo de nuevo.")
                End If
            Else
                If Personal.PersonalInsertar(Personal) = True Then
                    MsgBox("El personal ha sido correctamente insertado.")
                    Personal.PersonalTraerTab(z.dgvPersonal)
                Else
                    MsgBox("Error al insertar personal." + Chr(13) + "Intentelo de nuevo.")
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