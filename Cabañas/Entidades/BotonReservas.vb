Public Class BotonReservas
    Inherits Button

    Private id_ As Integer

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Private fIngreso_ As Date
    Public Property fIngreso() As Date
        Get
            Return fIngreso_
        End Get
        Set(ByVal value As Date)
            fIngreso_ = value
        End Set
    End Property

    Private fSalida_ As Date
    Public Property fSalida() As Date
        Get
            Return fSalida_
        End Get
        Set(ByVal value As Date)
            fSalida_ = value
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


    Private idEstado_ As Integer
    Public Property idEstado() As Integer
        Get
            Return idEstado_
        End Get
        Set(ByVal value As Integer)
            idEstado_ = value
        End Set
    End Property



    Public Sub New()
        Me.FlatStyle = Windows.Forms.FlatStyle.Flat
        Me.Margin = New Padding(0, 0, 0, 0)
        Me.Height = 32
    End Sub

    Private Sub Reservas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Click

        'MessageBox.Show("Esta es la reserva: " + Str(id))

        frmReservas.modificar = True
        frmReservas.idReserva = id
        frmReservas.idCabania = idCabania
        frmReservas.ShowDialog()

    End Sub

    
End Class
