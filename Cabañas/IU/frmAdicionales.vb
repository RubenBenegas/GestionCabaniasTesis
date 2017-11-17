Public Class frmAdicionales


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

    Dim Adicional As New Adicionales

    Private Sub frmAdicionales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ErrorProvider1.Clear()

        If modificar = True Then
            Me.Text = "Modificar tipo cabaña"

            Adicional = Adicional.RecuperarAdicional(id)

            txtId.Text = Adicional.id
            txtAdicional.Text = Adicional.descripcion
            txtMonto.Text = Adicional.monto
        Else
            Me.Text = "Agregar tipo cabaña"

            txtId.Text = Nothing
            txtAdicional.Text = Nothing
            txtMonto.Text = Nothing
        End If
    End Sub

    Private Sub RectangleShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RectangleShape1.Click
        If fun.validarCampos(Me, ErrorProvider1) = True Then

            Adicional.descripcion = txtAdicional.Text
            Adicional.monto = txtMonto.Text()

            If modificar = True Then
                If Adicional.ModificarAdicional(Adicional) = True Then
                    MsgBox("El tipo cabaña ha sido correctamente modificado.")
                    Adicional.AdicionalesTraerTab(lstAdicional.DgvAdicionales)
                Else
                    MsgBox("Error al modificar el tipo cabaña." + Chr(13) + "Intentelo de nuevo.")
                End If
            Else
                If Adicional.InsertarAdicional(Adicional) = True Then
                    MsgBox("El tipo cabaña ha sido correctamente insertado.")
                    Adicional.AdicionalesTraerTab(lstAdicional.DgvAdicionales)
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