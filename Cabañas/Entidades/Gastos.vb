
Imports System.Data
Imports System.Data.SqlClient
Public Class Gastos
    Inherits Conexiones
    Private id_ As Integer
    Private descripcion_ As String
    Private MUnitario_ As Decimal
    Private Cantidad_ As Integer
    Private Total_ As Decimal
    Private idProveedor_ As Integer
    Private fecha_ As Date

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


    Private idCategoria_ As Integer
    Public Property idCategoria() As Integer
        Get
            Return idCategoria_
        End Get
        Set(ByVal value As Integer)
            idCategoria_ = value
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
    Public Property idProveedor() As Integer
        Get
            Return idProveedor_
        End Get
        Set(ByVal value As Integer)
            idProveedor_ = value
        End Set
    End Property
    Public Property fecha() As Date
        Get
            Return fecha_
        End Get
        Set(ByVal value As Date)
            fecha_ = value
        End Set
    End Property

    Public Sub verTodos(ByVal tabla As DataGridView)
        abrirConexion()
        Dim objComando As New SqlCommand("GastosTraerTab", objConexion)
        objComando.CommandType = CommandType.StoredProcedure
        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Categoria").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Proveedor").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("MontoUnitario").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Cantidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Total").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        
        cerrarConexion()

    End Sub
    Public Function RecuperarGasto(ByVal idGasto As Integer) As Gastos
        Try
            abrirConexion()
            Dim gastos As New Gastos
            Dim objComando As New SqlCommand("GastosRecuperar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@idGasto", idGasto)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                objDataAdapter.Fill(objDataTable)
                gastos.id = objDataTable.Rows(0).Item("id")
                gastos.descripcion = objDataTable.Rows(0).Item("descripcion")
                gastos.fecha = objDataTable.Rows(0).Item("Fecha")
                gastos.idCategoria = objDataTable.Rows(0).Item("Categoria")
                gastos.idProveedor = objDataTable.Rows(0).Item("Proveedor")
                gastos.MUnitario = objDataTable.Rows(0).Item("MontoUnitario")
                gastos.Cantidad = objDataTable.Rows(0).Item("Cantidad")
                gastos.Total = objDataTable.Rows(0).Item("Total")

                Return gastos

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function

    Public Function ModificarGasto(ByVal gastos As Gastos) As Boolean
        Try
            abrirConexion()
            Dim objComando As New SqlCommand("GastosModificar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Descripcion", gastos.descripcion)
            objComando.Parameters.AddWithValue("@Fecha", gastos.fecha)
            objComando.Parameters.AddWithValue("@IdCategoria", gastos.idCategoria)
            objComando.Parameters.AddWithValue("@IdProveedor", gastos.idProveedor)
            objComando.Parameters.AddWithValue("@MUnitario", gastos.MUnitario)
            objComando.Parameters.AddWithValue("@Cantidad", gastos.Cantidad)
            objComando.Parameters.AddWithValue("@Total", gastos.Total)
            objComando.Parameters.AddWithValue("@Id", gastos.id)
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
    Public Function InsertarGasto(ByVal gasto As Gastos) As Boolean
        Try
            abrirConexion()
            Dim objComando As New SqlCommand("GastosInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Descripcion", gasto.descripcion)
            objComando.Parameters.AddWithValue("@Fecha", gasto.fecha)
            objComando.Parameters.AddWithValue("@IdCategoria", gasto.idCategoria)
            objComando.Parameters.AddWithValue("@IdProveedor", gasto.idProveedor)
            objComando.Parameters.AddWithValue("@MUnitario", gasto.MUnitario)
            objComando.Parameters.AddWithValue("@Cantidad", gasto.Cantidad)
            objComando.Parameters.AddWithValue("@Total", gasto.Total)

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
    Public Function BorrarGasto(ByVal idGasto As Integer) As Boolean
        Try
            abrirConexion()
            Dim objComando As New SqlCommand("GastosBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdGasto", idGasto)
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

    Public Function CargarComboCategoria(ByVal ComboActual As ComboBox)
        Try
            abrirConexion()
            Dim objComando As New SqlCommand("GastosCargarComboCategoria", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            With ComboActual
                .DataSource = objDataTable
                .DisplayMember = "Categoria"
                .ValueMember = "id"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try

    End Function

    Public Function CargarComboProveedor(ByVal ComboActual As ComboBox)
        Try
            abrirConexion()
            Dim objComando As New SqlCommand("GastosCargarComboProveedor", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            With ComboActual
                .DataSource = objDataTable
                .DisplayMember = "Proveedor"
                .ValueMember = "id"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try

    End Function

    Public Function GastosCalcularTotal() As Decimal
        Try
            abrirConexion()

            Dim Total As Decimal
            Dim objComando As New SqlCommand("GastosCalcularTotal", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)

            Total = objDataTable.Rows(0).Item("Total")
            Return Total

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()

        End Try
    End Function



    Public Function GastosCalcularPorCategoria(ByVal idCategoria As Integer) As Decimal
        Try
            abrirConexion()

            Dim Total As Decimal
            Dim objComando As New SqlCommand("GastosCalcularPorCategoria", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdCategoria", idCategoria)
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)

            Total = objDataTable.Rows(0).Item("Total")
            Return Total

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()

        End Try
    End Function


    Public Sub GastosFiltrarPorCategoria(ByVal idCategoria As Integer, ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("GastosFiltrarPorCategoria", objConexion)
        objComando.CommandType = CommandType.StoredProcedure
        objComando.Parameters.AddWithValue("@idCategoria", idCategoria)

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)

        tabla.DataSource = objDataTable
        tabla.Columns("Id").Width = 50
        tabla.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        cerrarConexion()

    End Sub
End Class
