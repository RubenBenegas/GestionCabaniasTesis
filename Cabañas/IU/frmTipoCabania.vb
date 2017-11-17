Public Class frmTipoCabania


    Private id_ As Integer
    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property



    Private modificar_ As Boolean
    Public Property modificar() As Boolean
        Get
            Return modificar_
        End Get
        Set(ByVal value As Boolean)
            modificar_ = value
        End Set
    End Property


    Dim fun As New Validaciones

    Dim tipocabania As New TipoCabania


    Private Sub frmTipoCabania_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ErrorProvider1.Clear()

        If modificar = True Then
            Me.Text = "Modificar tipo cabaña"

            tipocabania = tipocabania.RecuperarTipoCabania(id)

            txtId.Text = tipocabania.id
            txtTipoCabania.Text = tipocabania.tipoCabania
            txtMonto.Text = tipocabania.monto
        Else
            Me.Text = "Agregar tipo cabaña"

            txtId.Text = Nothing
            txtTipoCabania.Text = Nothing
            txtMonto.Text = Nothing
        End If
    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        ErrorProvider1.Clear()

        If fun.validarCampos(Me, ErrorProvider1) = True Then

            tipocabania.tipoCabania = txtTipoCabania.Text
            tipocabania.monto = txtMonto.Text()

            If modificar = True Then
                If tipocabania.ModificarTipoCabania(tipocabania) = True Then
                    MsgBox("El tipo cabaña ha sido correctamente modificado.")
                    tipocabania.TraerTipoCabania(lstTipoCabania.DgvTipoCabania)
                Else
                    MsgBox("Error al modificar el tipo cabaña." + Chr(13) + "Intentelo de nuevo.")
                End If
            Else
                If tipocabania.InsertarTipoCabania(tipocabania) = True Then
                    MsgBox("El tipo cabaña ha sido correctamente insertado.")
                    tipocabania.TraerTipoCabania(lstTipoCabania.DgvTipoCabania)
                Else
                    MsgBox("Error al insertar tipo cabaña." + Chr(13) + "Intentelo de nuevo.")
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