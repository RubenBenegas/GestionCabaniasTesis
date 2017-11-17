Imports System.Data
Imports System.Data.SqlClient

Public Class Cancelaciones

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


    Private fCancelacion_ As Date
    Public Property fCancelacion() As Date
        Get
            Return fCancelacion_
        End Get
        Set(ByVal value As Date)
            fCancelacion_ = value
        End Set
    End Property


    Private Descripcion_ As String
    Public Property Descripcion() As String
        Get
            Return Descripcion_
        End Get
        Set(ByVal value As String)
            Descripcion_ = value
        End Set
    End Property


    Private Reembolso_ As Decimal
    Public Property Reembolso() As Decimal
        Get
            Return Reembolso_
        End Get
        Set(ByVal value As Decimal)
            Reembolso_ = value
        End Set
    End Property

    Private IdReserva_ As Integer
    Public Property IdReserva() As Integer
        Get
            Return IdReserva_
        End Get
        Set(ByVal value As Integer)
            IdReserva_ = value
        End Set
    End Property

    Public Sub TraerTabCancelaciones(ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("CancelacionesTraerTab", objConexion)
        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("fCancelacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Reembolso").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("IdReserva").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        cerrarConexion()

    End Sub


    Public Function InsertarCancelacion(ByVal cancelacion As Cancelaciones) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("CancelacionInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@fCancelacion", cancelacion.fCancelacion)
            objComando.Parameters.AddWithValue("@Descripcion", cancelacion.Descripcion)
            objComando.Parameters.AddWithValue("@Reembolso", cancelacion.Reembolso)
            objComando.Parameters.AddWithValue("@IdReserva", cancelacion.IdReserva)
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


    Public Function ModificarCancelacion(ByVal cancelacion As Cancelaciones) As Boolean

        Try
            abrirConexion()
            Dim objComando As New SqlCommand("HuespedModificar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@fCancelacion", cancelacion.fCancelacion)
            objComando.Parameters.AddWithValue("@Descripcion", cancelacion.Descripcion)
            objComando.Parameters.AddWithValue("@Reembolso", cancelacion.Reembolso)
            objComando.Parameters.AddWithValue("@IdReserva", cancelacion.IdReserva)
            objComando.Parameters.AddWithValue("@Id", cancelacion.Id)
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


    Public Function RecuperarCancelacion(ByVal idReserva As Integer) As Cancelaciones

        Try
            abrirConexion()
            Dim cancelacion As New Cancelaciones
            Dim objComando As New SqlCommand("CancelacionRecuperar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@idReserva", idReserva)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                objDataAdapter.Fill(objDataTable)
                cancelacion.Id = objDataTable.Rows(0).Item("Id")
                cancelacion.fCancelacion = objDataTable.Rows(0).Item("fCancelacion")
                cancelacion.Descripcion = objDataTable.Rows(0).Item("Descripcion")
                cancelacion.Reembolso = objDataTable.Rows(0).Item("Reembolso")
                cancelacion.IdReserva = objDataTable.Rows(0).Item("IdReserva")

                Return cancelacion
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function
End Class
