Public Class frmInsumos
    Private idInsumo_ As Integer
    Private modificar_ As Boolean
    Dim Insumo As New Insumos
    Public Property IdInsumo() As Integer
        Get
            Return idInsumo_
        End Get
        Set(ByVal value As Integer)
            idInsumo_ = value
        End Set

    End Property
    Public Property modificar() As Boolean
        Get
            Return modificar_
        End Get
        Set(ByVal value As Boolean)
            modificar_ = value
        End Set
    End Property

    Private Sub FrmInsumos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If modificar = True Then
            Insumo = Insumo.RecuperarInsumo(IdInsumo)
            txtId.Text = Insumo.id
            txtDescripcion.Text = Insumo.descripcion
            txtMUnitario.Text = Insumo.MUnitario
            txtCantidad.Text = Insumo.Cantidad
            TxtTotal.Text = CDec(txtMUnitario.Text) * CInt(txtCantidad.Text)
            Me.Text = "Cambiar Insumo"
        Else
            txtId.Text = Nothing
            txtDescripcion.Text = Nothing
            txtMUnitario.Text = Nothing
            txtCantidad.Text = Nothing
            TxtTotal.Text = Nothing
            Me.Text = "Agregar Insumo"
        End If

    End Sub

    Dim fun As New Validaciones
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click


        If fun.validarCampos(Me, ErrorProvider1) = True Then


            Insumo.descripcion = txtDescripcion.Text
            Insumo.MUnitario = txtMUnitario.Text
            Insumo.Cantidad = txtCantidad.Text
            Insumo.Total = CDec(txtMUnitario.Text) * CDec(txtCantidad.Text)
            If modificar = True Then
                If Insumo.ModificarInsumo(Insumo) = True Then
                    MsgBox("El insumo ha sido correctamente modificado.")
                    Insumo.verTodos(lstInsumos.dgvInsumos)
                Else
                    MsgBox("Error al modificar el insumo." + Chr(13) + "Intentelo de nuevo.")
                End If
            Else
                If Insumo.InsertarInsumo(Insumo) = True Then
                    MsgBox("El insumo ha sido correctamente insertado.")
                    Insumo.verTodos(lstInsumos.dgvInsumos)
                Else
                    MsgBox("Error al insertar insumo." + Chr(13) + "Intentelo de nuevo.")
                End If
            End If
            Close()
        Else

            MsgBox("Completar los campos obligatorios.", MsgBoxStyle.Information, "Importante")
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()

    End Sub



    Private Sub txtMUnitario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMUnitario.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "," Then

            e.Handled = False

        Else

            e.Handled = True

        End If
    End Sub


    Private Sub txtMUnitario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMUnitario.LostFocus

        txtMUnitario.Text = fun.validarImporte(txtMUnitario.Text)

    End Sub


    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "," Then

            e.Handled = False

        Else

            e.Handled = True

        End If
    End Sub
End Class
