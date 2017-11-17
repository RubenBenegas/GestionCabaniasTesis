Imports System.Data
Imports System.Data.SqlClient
Public Class Reservas

    Inherits Conexiones

    Private Id_ As Integer
    Public Property Id() As Integer
        Get
            Return Id_
        End Get
        Set(ByVal value As Integer)
            Id_ = value
        End Set
    End Property

    Private fReserva_ As Date
    Public Property fReserva() As Date
        Get
            Return fReserva_
        End Get
        Set(ByVal value As Date)
            fReserva_ = value
        End Set
    End Property


    Private IdHuesped_ As Integer
    Public Property IdHuesped() As Integer
        Get
            Return IdHuesped_
        End Get
        Set(ByVal value As Integer)
            IdHuesped_ = value
        End Set
    End Property


    Private NombreHuesped_ As String
    Public Property NombreHuesped() As String
        Get
            Return NombreHuesped_
        End Get
        Set(ByVal value As String)
            NombreHuesped_ = value
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

    Private IdCabania_ As Integer
    Public Property IdCabania() As Integer
        Get
            Return IdCabania_
        End Get
        Set(ByVal value As Integer)
            IdCabania_ = value
        End Set
    End Property


    Private NroPasajeros_ As Integer
    Public Property NroPasajeros() As Integer
        Get
            Return NroPasajeros_
        End Get
        Set(ByVal value As Integer)
            NroPasajeros_ = value
        End Set
    End Property


    Private ConSenia_ As Boolean
    Public Property ConSenia() As Boolean
        Get
            Return ConSenia_
        End Get
        Set(ByVal value As Boolean)
            ConSenia_ = value
        End Set
    End Property


    Private fPagoSenia_ As Date
    Public Property fPagoSenia() As Date
        Get
            Return fPagoSenia_
        End Get
        Set(ByVal value As Date)
            fPagoSenia_ = value
        End Set
    End Property


    Private CheckIn_ As Date
    Public Property Checkin() As Date
        Get
            Return CheckIn_
        End Get
        Set(ByVal value As Date)
            CheckIn_ = value
        End Set
    End Property

    Private CheckOut_ As Date
    Public Property Checkout() As Date
        Get
            Return CheckOut_
        End Get
        Set(ByVal value As Date)
            CheckOut_ = value
        End Set
    End Property


    Private CostoEstadia_ As Decimal
    Public Property CostoEstadia() As Decimal
        Get
            Return CostoEstadia_
        End Get
        Set(ByVal value As Decimal)
            CostoEstadia_ = value
        End Set
    End Property


    Private CostoAdicionales_ As Decimal
    Public Property CostoAdicionales() As Decimal
        Get
            Return CostoAdicionales_
        End Get
        Set(ByVal value As Decimal)
            CostoAdicionales_ = value
        End Set
    End Property

    Private Senia_ As Decimal
    Public Property Senia() As Decimal
        Get
            Return Senia_
        End Get
        Set(ByVal value As Decimal)
            Senia_ = value
        End Set
    End Property


    Private CostoTotal_ As Decimal
    Public Property CostoTotal() As Decimal
        Get
            Return CostoTotal_
        End Get
        Set(ByVal value As Decimal)
            CostoTotal_ = value
        End Set
    End Property


    Private IdEstado_ As Integer
    Public Property IdEstado() As Integer
        Get
            Return IdEstado_
        End Get
        Set(ByVal value As Integer)
            IdEstado_ = value
        End Set
    End Property





    Public Sub TraerTabReservas(ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("ReservasTraerTab", objConexion)
        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        'tabla.Columns("Huesped").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'tabla.Columns("IdCabania").Width = False

        cerrarConexion()

    End Sub


    Public Function InsertarReserva(ByVal reserva As Reservas) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ReservasInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@fReserva", reserva.fReserva)
            objComando.Parameters.AddWithValue("@IdHuesped", reserva.IdHuesped)
            objComando.Parameters.AddWithValue("@fIngreso", reserva.fIngreso)
            objComando.Parameters.AddWithValue("@fSalida", reserva.fSalida)
            objComando.Parameters.AddWithValue("@IdCabania", reserva.IdCabania)
            objComando.Parameters.AddWithValue("@NroPasajeros", reserva.NroPasajeros)
            objComando.Parameters.AddWithValue("@Senia", reserva.Senia)
            objComando.Parameters.AddWithValue("@ConSenia", reserva.ConSenia)
            objComando.Parameters.AddWithValue("@fPagoSenia", reserva.fPagoSenia)
            objComando.Parameters.AddWithValue("@Checkin", reserva.Checkin)
            objComando.Parameters.AddWithValue("@Checkout", reserva.Checkout)
            objComando.Parameters.AddWithValue("@CostoEstadia", reserva.CostoEstadia)
            objComando.Parameters.AddWithValue("@CostoAdicionales", reserva.CostoAdicionales)
            objComando.Parameters.AddWithValue("@CostoTotal", reserva.CostoTotal)
            objComando.Parameters.AddWithValue("@IdEstadoReserva", reserva.IdEstado)


            If objComando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function

    Public Function ReservasTraerUltimo() As Integer
        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ReservasTraerUltimo", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            Return objComando.ExecuteScalar

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function

    Public Function BorraReserva(ByVal idReserva As Integer) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ReservasBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdReserva", idReserva)
            If objComando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cerrarConexion()
        End Try

    End Function

    Public Function RecuperarReserva(ByVal idReserva As Integer) As Reservas

        Try
            abrirConexion()
            Dim reserva As New Reservas
            Dim objComando As New SqlCommand("ReservasRecuperar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Idreserva", idReserva)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                objDataAdapter.Fill(objDataTable)
                reserva.Id = objDataTable.Rows(0).Item("Id")
                reserva.fReserva = objDataTable.Rows(0).Item("fReserva")
                reserva.IdHuesped = objDataTable.Rows(0).Item("IdHuesped")
                reserva.NombreHuesped = objDataTable.Rows(0).Item("Nombre")
                reserva.fIngreso = objDataTable.Rows(0).Item("fIngreso")
                reserva.fSalida = objDataTable.Rows(0).Item("fSalida")
                reserva.IdCabania = objDataTable.Rows(0).Item("IdCabania")
                reserva.NroPasajeros = objDataTable.Rows(0).Item("NroPasajeros")
                reserva.Senia = objDataTable.Rows(0).Item("Senia")
                reserva.ConSenia = objDataTable.Rows(0).Item("ConSenia")
                reserva.fPagoSenia = objDataTable.Rows(0).Item("fPagoSenia")
                reserva.Checkin = objDataTable.Rows(0).Item("Checkin")
                reserva.Checkout = objDataTable.Rows(0).Item("Checkout")
                reserva.CostoEstadia = objDataTable.Rows(0).Item("CostoEstadia")
                reserva.CostoAdicionales = objDataTable.Rows(0).Item("CostoAdicionales")
                reserva.CostoTotal = objDataTable.Rows(0).Item("CostoTotal")
                reserva.IdEstado = objDataTable.Rows(0).Item("IdEstado")
                Return reserva
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function

    Public Function ModificarReserva(ByVal reserva As Reservas) As Boolean

        Try
            abrirConexion()
            Dim objComando As New SqlCommand("ReservasModificar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@fReserva", reserva.fReserva)
            objComando.Parameters.AddWithValue("@IdHuesped", reserva.IdHuesped)
            objComando.Parameters.AddWithValue("@fIngreso", reserva.fIngreso)
            objComando.Parameters.AddWithValue("@fSalida", reserva.fSalida)
            objComando.Parameters.AddWithValue("@IdCabania", reserva.IdCabania)
            objComando.Parameters.AddWithValue("@NroPasajeros", reserva.NroPasajeros)
            objComando.Parameters.AddWithValue("@Senia", reserva.Senia)
            objComando.Parameters.AddWithValue("@ConSenia", reserva.ConSenia)
            objComando.Parameters.AddWithValue("@fPagoSenia", reserva.fPagoSenia)
            objComando.Parameters.AddWithValue("@Checkin", reserva.Checkin)
            objComando.Parameters.AddWithValue("@Checkout", reserva.Checkout)
            objComando.Parameters.AddWithValue("@CostoEstadia", reserva.CostoEstadia)
            objComando.Parameters.AddWithValue("@CostoAdicionales", reserva.CostoAdicionales)
            objComando.Parameters.AddWithValue("@CostoTotal", reserva.CostoTotal)
            objComando.Parameters.AddWithValue("@IdEstadoReserva", reserva.IdEstado)
            objComando.Parameters.AddWithValue("@Id", reserva.Id)
            If objComando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cerrarConexion()
        End Try
    End Function

    Public Function CargarComboCabania(ByVal ComboActual As ComboBox)
        Try
            abrirConexion()
            Dim objComando As New SqlCommand("ReservasCargarComboCabania", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            With ComboActual
                .DataSource = objDataTable
                .DisplayMember = "TipoCabania"
                .ValueMember = "id"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try

    End Function

    Public Function ReservasCabaniasFiltrarDisponibles(ByVal idCabania As Integer, ByVal tipoCabania As String, ByVal fecheDesde As Date, ByVal fecheHasta As Date, ByVal ComboActual As ComboBox)
        Try
            abrirConexion()
            Dim objComando As New SqlCommand("ReservasCabaniasFiltrarDisponibles", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@fDesde", fecheDesde)
            objComando.Parameters.AddWithValue("@fHasta", fecheHasta)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)

            Dim NewRow As DataRow
            NewRow = objDataTable.NewRow
            NewRow("id") = idCabania
            NewRow("TipoCabania") = "  " + CStr(idCabania) + " - " + tipoCabania
            objDataTable.Rows.Add(NewRow)

            With ComboActual
                .DataSource = objDataTable
                .DisplayMember = "TipoCabania"
                .ValueMember = "id"
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try

    End Function

    Public Function ReservasCabaniasFiltrarDisponibles(ByVal fecheDesde As Date, ByVal fecheHasta As Date, ByVal ComboActual As ComboBox)
        Try
            abrirConexion()
            Dim objComando As New SqlCommand("ReservasCabaniasFiltrarDisponibles", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@fDesde", fecheDesde)
            objComando.Parameters.AddWithValue("@fHasta", fecheHasta)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)

            With ComboActual
                .DataSource = objDataTable
                .DisplayMember = "TipoCabania"
                .ValueMember = "id"
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try

    End Function

    Public Sub CantidadReservas(ByVal tabla As DataGridView)
        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ReservasTraerTab", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)
            tabla.DataSource = objDataTable

            tabla.Columns("Id").Width = 50
            tabla.Columns("Huesped").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub


    Public Function DataTableReservas(ByVal fDesde As Date, ByVal fHasta As Date) As Data.DataTable
        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ReservasDataTable", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@fDesde", fDesde)
            objComando.Parameters.AddWithValue("@fHasta", fHasta)
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)
            Return objDataTable

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function


    'Public Function DataTableReservas() As Data.DataTable
    '    Try
    '        abrirConexion()

    '        Dim objComando As New SqlCommand("ReservasDataTable", objConexion)
    '        objComando.CommandType = CommandType.StoredProcedure
    '        Dim objDataTable As New Data.DataTable
    '        Dim objDataAdapter As New SqlDataAdapter(objComando)
    '        objDataAdapter.Fill(objDataTable)
    '        Return objDataTable

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        cerrarConexion()
    '    End Try
    'End Function


    Public Function ReservaAdicionalInsertar(ByVal idReserva As Integer, ByVal idAdicional As Integer)
        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ReservaAdicionalInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@idReserva", idReserva)
            objComando.Parameters.AddWithValue("@idAdicional", idAdicional)
            If objComando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cerrarConexion()
        End Try
    End Function

    Public Sub ReservasCargarAdicionales(ByVal idReserva As Integer, ByVal tabla As DataGridView)
        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ReservasCargarAdicionales", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@idReserva", idReserva)

            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)
            tabla.DataSource = objDataTable
            'tabla.Columns("id").Visible = False
            tabla.Columns("id").Width = 30
            tabla.Columns("Adicionales").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub


    Public Function ReservaAdicionalBorrar(ByVal idAdicional As Integer)
        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ReservaAdicionalBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            'objComando.Parameters.AddWithValue("@idReserva", idReserva)
            objComando.Parameters.AddWithValue("@idAdicional", idAdicional)
            If objComando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cerrarConexion()
        End Try
    End Function





    Public Function ReservaCostoEstadia(ByVal idReserva) As Decimal
        Try
            abrirConexion()
            Dim CostoEstadia As Decimal
            Dim objComando As New SqlCommand("ReservaCostoEstadia", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdReserva", idReserva)
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)
            CostoEstadia = objDataTable.Rows(0).Item("CostoEstadia")
            Return CostoEstadia

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function

    Public Function ReservaCostoAdicionales(ByVal idReserva) As Decimal

        Try
            abrirConexion()
            Dim CostoAdicionales As Decimal
            Dim objComando As New SqlCommand("ReservaCostoAdicionales", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdReserva", idReserva)

            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)
            CostoAdicionales = objDataTable.Rows(0).Item("CostoAdicionales")

            Return CostoAdicionales

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function


    Public Function ReservaTraerMontoDeCabania(ByVal idCabania) As Decimal

        Try
            abrirConexion()
            Dim MontoDeCabania As Decimal
            Dim objComando As New SqlCommand("ReservaTraerMontoDeCabania", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@idCabania", idCabania)
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)

            MontoDeCabania = objDataTable.Rows(0).Item("CostoTotal")
            Return MontoDeCabania

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function


    Public Sub ReservasFiltrarPorEstado(ByVal idEstado As Integer, ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("ReservasFiltrarPorEstado", objConexion)
        objComando.CommandType = CommandType.StoredProcedure
        objComando.Parameters.AddWithValue("@idEstado", idEstado)
        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("Huesped").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        cerrarConexion()

    End Sub

    Public Sub ReservasTraerSinSenia(ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("ReservasTraerSinSenia", objConexion)
        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        cerrarConexion()
    End Sub



    Public Function ReservasActualizarEstado(ByVal idEstado As Integer, ByVal idReserva As Integer) As Boolean

        Try
            abrirConexion()
            Dim objComando As New SqlCommand("ReservasActualizarEstado", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdEstadoReserva", idEstado)
            objComando.Parameters.AddWithValue("@IdReserva", idReserva)
            If objComando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cerrarConexion()
        End Try
    End Function




    Public Function ReservasTraerMontoTotal(ByVal idReserva As Integer) As Decimal
        Try
            abrirConexion()
            Dim MontoTotal
            Dim objComando As New SqlCommand("ReservasTraerMontoTotal", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdReserva", idReserva)
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)

            MontoTotal = objDataTable.Rows(0).Item("CostoTotal")
            Return MontoTotal


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function


    Public Function CargarComboEstados(ByVal ComboActual As ComboBox)
        Try
            abrirConexion()
            Dim objComando As New SqlCommand("EstadosReservasCargarComboEstado", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            With ComboActual
                .DataSource = objDataTable
                .DisplayMember = "Descripcion"
                .ValueMember = "id"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try

    End Function 

    Public Function ReservasTraerDescripcionDeCabanias(ByVal idCabania As Integer) As String
        Try
            abrirConexion()
            Dim Descripcion
            Dim objComando As New SqlCommand("ReservasTraerDescripcionDeCabanias", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdCabania", idCabania)
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)

            Descripcion = objDataTable.Rows(0).Item("TipoCabania")
            Return Descripcion

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function

End Class
