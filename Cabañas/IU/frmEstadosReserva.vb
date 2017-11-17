Public Class frmEstadosReserva

    Private modifica_ As Boolean
    Public Property modifica() As Boolean
        Get
            Return modifica_
        End Get
        Set(ByVal value As Boolean)
            modifica_ = value
        End Set
    End Property


    Private Sub rdEspera_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdEspera.CheckedChanged
        btnCancelarReserva.Visible = False
        

    End Sub

    Private Sub rdSeniada_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdSeniada.CheckedChanged
        btnCancelarReserva.Visible = False
        
    End Sub

    Private Sub rdEnCurso_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdEnCurso.CheckedChanged
        btnCancelarReserva.Visible = False
        
    End Sub

    Private Sub rdCancelada_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdCancelada.CheckedChanged
        btnCancelarReserva.Visible = True
        

    End Sub


    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Close()
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If rdCancelada.Checked = True Then
            frmReservas.idEstado = 4
        ElseIf rdEspera.Checked = True Then
            frmReservas.idEstado = 1
        ElseIf rdSeniada.Checked = True Then
            frmReservas.idEstado = 2
        Else
            frmReservas.idEstado = 3

        End If











        Me.Close()

    End Sub


    Private Sub frmEstadosReserva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If frmReservas.modificar = True Then

        rdCancelada.Visible = True

        If frmReservas.idEstado = 1 Then
            rdEspera.Checked = True
        End If
        If frmReservas.idEstado = 2 Then
            rdSeniada.Checked = True
        End If
        If frmReservas.idEstado = 3 Then
            rdEnCurso.Checked = True
        End If
        If frmReservas.idEstado = 4 Then
            rdCancelada.Checked = True


            'cancelacion.RecuperarCancelacion(frmReservas.idReserva)
            'Dim fecha As Date

            ''dtpFechaCancelacion.Value = cancelacion.fCancelacion
            'TextBox1.Text = cancelacion.fCancelacion.ToString
            'txtDescripcion.Text = cancelacion.Descripcion
            'Else
            '    rdEspera.Checked = True
        End If

        'End If











        If frmReservas.modificar = False Then

            rdCancelada.Visible = False

        End If

    End Sub

    Private Sub btnCancelarReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarReserva.Click

        frmCancelaciones.idCancelacion = 0
        frmCancelaciones.idReserva = frmReservas.txtId.Text
        frmCancelaciones.modificar = False
        frmCancelaciones.ShowDialog()

    End Sub
End Class