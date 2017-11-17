Imports System.Data
Imports System.Data.SqlClient

Public Class TipoCabania

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


    Private tipoCabania_ As String
    Public Property tipoCabania() As String
        Get
            Return tipoCabania_
        End Get
        Set(ByVal value As String)
            tipoCabania_ = value
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



    Public Sub TraerTipoCabania(ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("TipoCabaniaTraerTab", objConexion)
        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("TipoCabania").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Monto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        cerrarConexion()

    End Sub
    Public Function InsertarTipoCabania(ByVal TipoCabania As TipoCabania) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("TipoCabaniaInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@TipoCabania", TipoCabania.tipoCabania)
            objComando.Parameters.AddWithValue("@monto", TipoCabania.monto)
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

    Public Function ModificarTipoCabania(ByVal TipoCabania As TipoCabania) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("TipoCabaniaModificar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdTipoCabania", TipoCabania.id)
            objComando.Parameters.AddWithValue("@TipoCabania", TipoCabania.tipoCabania)
            objComando.Parameters.AddWithValue("@monto", TipoCabania.monto)
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

    Public Function BorrarTipoCabania(ByVal idTipoCabania As Integer) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("TipoCabaniaBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdTipoCabania", id)
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

    Public Function RecuperarTipoCabania(ByVal idTipoCabania As Integer) As TipoCabania

        Try
            abrirConexion()
            Dim TipoCabania As New TipoCabania

            Dim objComando As New SqlCommand("TipoCabaniaRecuperar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdTipoCabania", idTipoCabania)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                objDataAdapter.Fill(objDataTable)
                TipoCabania.id = objDataTable.Rows(0).Item("Id")
                TipoCabania.tipoCabania = objDataTable.Rows(0).Item("TipoCabania")
                TipoCabania.monto = objDataTable.Rows(0).Item("Monto")
                Return TipoCabania

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function

    Public Sub CargarComboCabaniaEstado(ByVal ComboActual As ComboBox)

        Try
            abrirConexion()
            Dim objComando As New SqlCommand("CabaniaCargarComboEstado", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            With ComboActual
                .DataSource = objDataTable
                .DisplayMember = "Nombre"
                .ValueMember = "id"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub

    Public Sub CargarComboCabaniaTipo(ByVal ComboActual As ComboBox)

        Try
            abrirConexion()
            Dim objComando As New SqlCommand("CabaniaCargarComboTipo", objConexion)
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
    End Sub

End Class

