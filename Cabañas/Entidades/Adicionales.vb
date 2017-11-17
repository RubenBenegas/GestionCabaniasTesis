Imports System.Data
Imports System.Data.SqlClient
Public Class Adicionales


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

    Private descripcion_ As String
    Public Property descripcion() As String
        Get
            Return descripcion_
        End Get
        Set(ByVal value As String)
            descripcion_ = value
        End Set
    End Property

    Private monto_ As Decimal
    Public Property monto() As Decimal
        Get
            Return monto_
        End Get
        Set(ByVal value As Decimal)
            monto_ = value
        End Set
    End Property

    Public Sub AdicionalesTraerTab(ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("AdicionalesTraerTab", objConexion)
        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        cerrarConexion()

    End Sub


    Public Function InsertarAdicional(ByVal Adicional As Adicionales) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("AdicionalesInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@descripcion", Adicional.descripcion)
            objComando.Parameters.AddWithValue("@monto", Adicional.monto)
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


    Public Function BorrarAdicional(ByVal idAdicional As Integer) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("AdicionalesBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdAdicionales", idAdicional)
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

    Public Function RecuperarAdicional(ByVal idAdicional As Integer) As Adicionales

        Try
            abrirConexion()
            Dim Adicional As New Adicionales
            Dim objComando As New SqlCommand("AdicionalesRecuperar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdAdicionales", idAdicional)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                objDataAdapter.Fill(objDataTable)
                Adicional.Id = objDataTable.Rows(0).Item("Id")
                Adicional.descripcion = objDataTable.Rows(0).Item("descripcion")
                Adicional.monto = objDataTable.Rows(0).Item("monto")
                
                Return Adicional
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function

    Public Function ModificarAdicional(ByVal Adicional As Adicionales) As Boolean

        Try
            abrirConexion()
            Dim objComando As New SqlCommand("AdicionalesModificar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@descripcion", Adicional.descripcion)
            objComando.Parameters.AddWithValue("@monto", Adicional.monto)
            objComando.Parameters.AddWithValue("@Id", Adicional.Id)
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

    Public Sub BuscarAdicionales(ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("AdicionalesBuscar", objConexion)
        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


        cerrarConexion()

    End Sub
End Class
