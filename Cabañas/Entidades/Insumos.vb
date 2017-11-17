
Imports System.Data
Imports System.Data.SqlClient
Public Class Insumos
    Inherits Conexiones
    Private id_ As Integer
    Private descripcion_ As String
    Private MUnitario_ As Decimal
    Private Cantidad_ As Integer
    Private Total_ As Decimal
    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property descripcion() As String
        Get
            Return descripcion_
        End Get
        Set(ByVal value As String)
            descripcion_ = value
        End Set
    End Property

    Public Property MUnitario() As Decimal
        Get
            Return MUnitario_
        End Get
        Set(ByVal value As Decimal)
            MUnitario_ = value
        End Set
    End Property

    Public Property Cantidad() As Decimal
        Get
            Return Cantidad_
        End Get
        Set(ByVal value As Decimal)
            Cantidad_ = value
        End Set
    End Property
    Public Property Total() As Decimal
        Get
            Return Total_
        End Get
        Set(ByVal value As Decimal)
            Total_ = value
        End Set
    End Property
    Public Sub verTodos(ByVal tabla As DataGridView)
        abrirConexion()
        Dim objComando As New SqlCommand("InsumosTraerTab", objConexion)
        objComando.CommandType = CommandType.StoredProcedure
        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("MontoUnitario").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Cantidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Total").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        cerrarConexion()
    End Sub
    Public Function RecuperarInsumo(ByVal idInsumo As Integer) As Insumos
        Try
            abrirConexion()
            Dim Insumo As New Insumos
            Dim objComando As New SqlCommand("InsumosRecuperar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@idInsumo", idInsumo)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                objDataAdapter.Fill(objDataTable)
                Insumo.id = objDataTable.Rows(0).Item("id")
                Insumo.descripcion = objDataTable.Rows(0).Item("descripcion")
                Insumo.MUnitario = objDataTable.Rows(0).Item("MontoUnitario")
                Insumo.Cantidad = objDataTable.Rows(0).Item("Cantidad")
                Insumo.Total = objDataTable.Rows(0).Item("Total")
                Return Insumo

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function

    Public Function ModificarInsumo(ByVal Insumo As Insumos) As Boolean
        Try
            abrirConexion()
            Dim objComando As New SqlCommand("InsumosModificar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Descripcion", Insumo.descripcion)
            objComando.Parameters.AddWithValue("@MUnitario", Insumo.MUnitario)
            objComando.Parameters.AddWithValue("@Cantidad", Insumo.Cantidad)
            objComando.Parameters.AddWithValue("@Total", Insumo.Total)
            objComando.Parameters.AddWithValue("@Id", Insumo.id)
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
    Public Function InsertarInsumo(ByVal Insumo As Insumos) As Boolean
        Try
            abrirConexion()
            Dim objComando As New SqlCommand("InsumosInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Descripcion", Insumo.descripcion)
            objComando.Parameters.AddWithValue("@MUnitario", Insumo.MUnitario)
            objComando.Parameters.AddWithValue("@Cantidad", Insumo.Cantidad)
            objComando.Parameters.AddWithValue("@Total", Insumo.Total)

            If objComando.ExecuteNonQuery() Then
                Return True
            Else : Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cerrarConexion()
        End Try
    End Function
    Public Function BorrarInsumo(ByVal idInsumo As Integer) As Boolean
        Try
            abrirConexion()
            Dim objComando As New SqlCommand("InsumosBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdInsumo", idInsumo)
            If objComando.ExecuteNonQuery() Then
                Return True
            Else : Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            cerrarConexion()
        End Try
    End Function

End Class
