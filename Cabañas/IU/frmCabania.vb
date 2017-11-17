Public Class frmCabania

    Private modificar_ As Boolean
    Public Property modificar() As Boolean
        Get
            Return modificar_
        End Get
        Set(ByVal value As Boolean)
            modificar_ = value
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


    Dim cabania As New Cabanias

    Private Sub CabaniaForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ErrorProvider2.Clear()
        cabania.CargarComboCabaniaTipo(cmbTipoCabania)
        cabania.CabaniaServCarga(idCabania, dgvCabaniaServicios)


        If modificar = True Then

            Me.Text = "Modificar Cabaña"

            cabania = cabania.RecuperarCabania(idCabania)

            txtIdCabania.Text = cabania.idCabania
            cmbTipoCabania.SelectedValue = cabania.idTipo
            txtMonto.Text = cabania.monto
            txtDescripcion.Text = cabania.descripcion
            txtCostoServicios.Text = cabania.CostoServicios
            txtCostoTotal.Text = cabania.CostoTotal



        Else

            Me.Text = "Agregar Cabaña"

            txtIdCabania.Text = Nothing
            cmbTipoCabania.SelectedValue = 1
            txtMonto.Text = cabania.CabaniaTraerMontoPorTipo(1)
            txtDescripcion.Text = Nothing
            txtCostoServicios.Text = Nothing
            txtCostoTotal.Text = Nothing
        End If

    End Sub

    Dim fun As New Validaciones

    'Private Sub cmbTipoCabania_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoCabania.SelectedIndexChanged
    '     txtMonto.Text = 
    'End Sub

    Private Sub btnConsultarCostos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultarCostos.Click

        If dgvCabaniaServicios.Rows.Count = 0 Then
            txtCostoServicios.Text = 0
        Else
            txtCostoServicios.Text = cabania.CabaniaCostoServicio(idCabania)
        End If

        txtCostoTotal.Text = CDec(txtMonto.Text) + CDec(txtCostoServicios.Text)
    End Sub


    'Private Sub cmbTipoCabania_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipoCabania.SelectedValueChanged
    '    txtMonto.Text = cabania.CabaniaTraerMontoPorTipo(CInt(cmbTipoCabania.SelectedValue))
    'End Sub

    'Private Sub cmbTipoCabania_ValueMemberChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipoCabania.ValueMemberChanged
    '    txtMonto.Text = cabania.CabaniaTraerMontoPorTipo(cmbTipoCabania.SelectedValue)
    'End Sub

    Private Sub cmbTipoCabania_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipoCabania.LostFocus
        txtMonto.Text = cabania.CabaniaTraerMontoPorTipo(cmbTipoCabania.SelectedValue)
    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        If fun.validarCampos(Me, ErrorProvider2) = True Then


            cabania.idTipo = cmbTipoCabania.SelectedValue
            cabania.descripcion = txtDescripcion.Text
            cabania.CostoServicios = txtCostoServicios.Text
            cabania.CostoTotal = txtCostoTotal.Text


            If modificar = True Then
                If cabania.ModificarCabania(cabania) = True Then
                    MsgBox("La cabaña ha sido correctamente modificada.")
                    cabania.TraerTabCabania(lstcabania.dgvCabanias)
                Else
                    MsgBox("Error al modificar la cabaña." + Chr(13) + "Intentelo de nuevo.")
                End If
            Else
                If txtIdCabania.Text = "" Then


                    If cabania.InsertarCabania(cabania) = False Then

                        MsgBox("Error al insertar cabaña." + Chr(13) + "Intentelo de nuevo.")
                    Else
                        MsgBox("La cabaña ha sido correctamente insertada.")

                    End If
                End If
                cabania.TraerTabCabania(lstcabania.dgvCabanias)
            End If
            Close()
        Else
            MsgBox("Completar los campos obligatorios.", MsgBoxStyle.Information, "Importante")
        End If
    End Sub

    Private Sub RectangleShape3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape3.Click
        If txtIdCabania.Text = "" Then

            cabania.idTipo = cmbTipoCabania.SelectedValue
            cabania.descripcion = txtDescripcion.Text
            cabania.CostoServicios = txtCostoServicios.Text
            cabania.CostoTotal = txtCostoTotal.Text

            cabania.InsertarCabania(cabania)
            cabania.idCabania = cabania.CabaniaTraerUltimo
            txtIdCabania.Text = cabania.idCabania
        End If
        lstCabaniaServicios.idCabania = txtIdCabania.Text
        lstCabaniaServicios.ShowDialog()
    End Sub

    Private Sub RectangleShape4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape4.Click
        Dim idCabaniaServ As Integer = dgvCabaniaServicios.Item("id", dgvCabaniaServicios.CurrentRow.Index).Value
        cabania.CabaniaServBorrar(idCabaniaServ)
        cabania.CabaniaServCarga(idCabania, dgvCabaniaServicios)
    End Sub

    Private Sub RectangleShape2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape2.Click
        Close()

    End Sub
End Class

