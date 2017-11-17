Public Class FrmProveedor

    Private modificar_ As Boolean
    Public Property modificar() As Boolean
        Get
            Return modificar_
        End Get
        Set(ByVal value As Boolean)
            modificar_ = value

        End Set
    End Property


    Private idProveedor_ As Integer
    Public Property idProveedor() As Integer
        Get
            Return idProveedor_
        End Get
        Set(ByVal value As Integer)
            idProveedor_ = value
        End Set
    End Property


    Dim Proveedor As New Proveedor


    Private Sub FrmProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ErrorProvider1.Clear()

        If modificar = True Then

            Proveedor = Proveedor.RecuperarProveedor(idProveedor)
            txtId.Text = Proveedor.id
            txtTipo.Text = Proveedor.Tipo
            txtNombre.Text = Proveedor.Nombre
            txtTelefono.Text = Proveedor.Telefono
            txtDireccion.Text = Proveedor.Direccion
            Me.Text = "Modificar Proveedor"

        Else
            txtId.Text = Nothing
            txtTipo.Text = Nothing
            txtNombre.Text = Nothing
            txtTelefono.Text = Nothing
            txtDireccion.Text = Nothing
            Me.Text = "Agregar Proveedor"

        End If

    End Sub

    Dim fun As New Validaciones

    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub


    Private Sub txtNombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus


        If txtNombre.Text <> "" Then
            txtNombre.Text = fun.validarNombre(txtNombre.Text)
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

            Proveedor.Tipo = txtTipo.Text
            Proveedor.Nombre = txtNombre.Text
            Proveedor.Telefono = txtTelefono.Text
            Proveedor.Direccion = txtDireccion.Text
            If modificar = True Then
                If Proveedor.ModificarProveedor(Proveedor) = True Then
                    MsgBox("El proveedor ha sido correctamente modificado.")
                    Proveedor.traerProveedor(LstProveedor.dgvProveedores)
                Else
                    MsgBox("Error al modificar el proveedor." + Chr(13) + "Intentelo de nuevo.")
                End If
            Else
                If Proveedor.InsertarProveedor(Proveedor) = True Then
                    MsgBox("El proveedor ha sido correctamente insertado.")
                    Proveedor.traerProveedor(LstProveedor.dgvProveedores)
                Else
                    MsgBox("Error al insertar proveedor." + Chr(13) + "Intentelo de nuevo.")
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