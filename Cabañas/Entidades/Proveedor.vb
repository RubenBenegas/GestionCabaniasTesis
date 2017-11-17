
Imports System.Data
Imports System.Data.SqlClient

Public Class Proveedor
    Inherits Conexiones

    Private id_ As Integer
    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Private Tipo_ As String
    Public Property Tipo() As String
        Get
            Return Tipo_
        End Get
        Set(ByVal value As String)
            Tipo_ = value
        End Set
    End Property


    Private Nombre_ As String
    Public Property Nombre() As String
        Get
            Return Nombre_
        End Get
        Set(ByVal value As String)
            Nombre_ = value
        End Set
    End Property

    Private Direccion_ As String
    Public Property Direccion() As String
        Get
            Return Direccion_
        End Get
        Set(ByVal value As String)
            Direccion_ = value
        End Set
    End Property


    Private Telefono_ As String
    Public Property Telefono() As String
        Get
            Return Telefono_
        End Get
        Set(ByVal value As String)
            Telefono_ = value
        End Set

    End Property

   

    Public Sub traerProveedor(ByVal tabla As DataGridView)
        abrirConexion()

        Dim objcomando As New SqlCommand("ProveedorTraerTab", objConexion)
        objcomando.CommandType = CommandType.StoredProcedure
        Dim objdatatable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objcomando)
        objDataAdapter.Fill(objdatatable)
        tabla.DataSource = objdatatable


        tabla.Columns("Id").Width = 50
        tabla.Columns("Tipo").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Direccion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Telefono").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        cerrarConexion()


    End Sub


    Public Function RecuperarProveedor(ByVal idproveedor As Integer) As Proveedor
        Try
            abrirConexion()
            Dim proveedor As New Proveedor
            Dim objcomando As New SqlCommand("ProveedorRecuperar", objConexion)
            objcomando.CommandType = CommandType.StoredProcedure
            objcomando.Parameters.AddWithValue("@idProveedor", idproveedor)
            Dim objDataAdapter As New SqlDataAdapter(objcomando)
            Dim objdatatable As New Data.DataTable
            objDataAdapter.Fill(objdatatable)
            If objdatatable.Rows.Count > 0 Then
                objDataAdapter.Fill(objdatatable)
                proveedor.id = objdatatable.Rows(0).Item("id")
                proveedor.Tipo = objdatatable.Rows(0).Item("Tipo")
                proveedor.Nombre = objdatatable.Rows(0).Item("Nombre")
                proveedor.Telefono = objdatatable.Rows(0).Item("Telefono")
                proveedor.Direccion = objdatatable.Rows(0).Item("Direccion")

                Return proveedor

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()

        End Try

    End Function


    Public Function ModificarProveedor(ByVal proveedor As Proveedor) As Boolean

        Try
            abrirConexion()

            Dim objcomando As New SqlCommand("ProveedorModificar", objConexion)
            objcomando.CommandType = CommandType.StoredProcedure


            objcomando.Parameters.AddWithValue("@Id", proveedor.id)
            objcomando.Parameters.AddWithValue("@Tipo", proveedor.Tipo)
            objcomando.Parameters.AddWithValue("@Nombre", proveedor.Nombre)
            objcomando.Parameters.AddWithValue("@Direccion", proveedor.Direccion)
            objcomando.Parameters.AddWithValue("@Telefono", proveedor.Telefono)


            If objcomando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Finally
        End Try


    End Function

    Public Function InsertarProveedor(ByVal proveedor As Proveedor) As Boolean

        Try
            abrirConexion()

            Dim objcomando As New SqlCommand("ProveedorInsertar", objConexion)
            objcomando.CommandType = CommandType.StoredProcedure


            objcomando.Parameters.AddWithValue("@Tipo", proveedor.Tipo)
            objcomando.Parameters.AddWithValue("@Nombre", proveedor.Nombre)
            objcomando.Parameters.AddWithValue("@Direccion", proveedor.Direccion)
            objcomando.Parameters.AddWithValue("@Telefono", proveedor.Telefono)
            If objcomando.ExecuteNonQuery() Then
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

    Public Function ProveedorEliminar(ByVal idProveedor As Integer) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("ProveedorBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdProveedor", idProveedor)
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

End Class



