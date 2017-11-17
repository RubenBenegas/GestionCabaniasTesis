Imports System.Data
Imports System.Data.SqlClient

Public Class Cabanias

    Inherits Conexiones

    Private idCabania_ As Integer
    Public Property idCabania() As Integer
        Get
            Return idCabania_
        End Get
        Set(ByVal value As Integer)
            idCabania_ = value
        End Set
    End Property


    Private idTipo_ As Integer
    Public Property idTipo() As Integer
        Get
            Return idTipo_
        End Get
        Set(ByVal value As Integer)
            idTipo_ = value
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


    Private descripcion_ As String
    Public Property descripcion() As String
        Get
            Return descripcion_
        End Get
        Set(ByVal value As String)
            descripcion_ = value
        End Set
    End Property


    Private CostoServicios_ As Decimal
    Public Property CostoServicios() As Decimal
        Get
            Return CostoServicios_
        End Get
        Set(ByVal value As Decimal)
            CostoServicios_ = value
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



    Public Sub TraerTabCabania(ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("CabaniasTraerTab", objConexion)
        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("TipoCabania").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Monto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        cerrarConexion()

    End Sub

    Public Function InsertarCabania(ByVal cabania As Cabanias) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("CabaniasInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdTipo", cabania.idTipo)
            objComando.Parameters.AddWithValue("@Descripcion", cabania.descripcion)
            objComando.Parameters.AddWithValue("@CostoServicios", cabania.CostoServicios)
            objComando.Parameters.AddWithValue("@CostoTotal", cabania.CostoTotal)
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

    Public Function CabaniaTraerUltimo() As Integer
        Try
            abrirConexion()

            Dim objComando As New SqlCommand("CabaniaTraerUltimo", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            Return objComando.ExecuteScalar

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function

    Public Function CabaniaTraerMontoPorTipo(ByVal idTipo As Integer) As Integer
        Try
            abrirConexion()

            Dim objComando As New SqlCommand("CabaniaTraerMontoPorTipo", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdTipoCabania", idTipo)
            Return objComando.ExecuteScalar

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function


    Public Function ModificarCabania(ByVal Cabania As Cabanias) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("CabaniasModificar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdTipo", Cabania.idTipo)
            objComando.Parameters.AddWithValue("@Descripcion", Cabania.descripcion)
            objComando.Parameters.AddWithValue("@CostoServicios", Cabania.CostoServicios)
            objComando.Parameters.AddWithValue("@CostoTotal", Cabania.CostoTotal)
            objComando.Parameters.AddWithValue("@IdCabania", Cabania.idCabania)
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

    Public Function BorrarCabania(ByVal idProducto As Integer) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("CabaniasBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdCabania", idCabania)
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

    Public Function RecuperarCabania(ByVal idCabania As Integer) As Cabanias

        Try
            abrirConexion()
            Dim cabania As New Cabanias

            Dim objComando As New SqlCommand("CabaniasRecuperar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdCabania", idCabania)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                objDataAdapter.Fill(objDataTable)
                cabania.idCabania = objDataTable.Rows(0).Item("Id")
                cabania.idTipo = objDataTable.Rows(0).Item("idTipo")
                cabania.monto = objDataTable.Rows(0).Item("Monto")
                cabania.descripcion = objDataTable.Rows(0).Item("Descripcion")
                cabania.CostoServicios = objDataTable.Rows(0).Item("CostoServicios")
                cabania.CostoTotal = objDataTable.Rows(0).Item("CostoTotal")
                Return cabania

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
                .DisplayMember = "TipoCabania"
                .ValueMember = "id"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub

    'Public Function CantidadCabania() As Integer
    '    abrirConexion()

    '    Dim cantidad As New Integer
    '    Dim objComando As New SqlCommand("CabaniasCantidad", objConexion)
    '    objComando.CommandType = CommandType.StoredProcedure
    '    Dim objDataTable As New Data.DataTable
    '    Dim objDataAdapter As New SqlDataAdapter(objComando)
    '    objDataAdapter.Fill(objDataTable)
    '    cantidad = objDataTable.Rows(0).Item("cantidad")
    '    Return cantidad

    '    cerrarConexion()

    'End Function

    Public Function DataTableCabanias() As Data.DataTable

        abrirConexion()

        Dim objComando As New SqlCommand("CabaniasDataTable", objConexion)
        objComando.CommandType = CommandType.StoredProcedure
        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        Return objDataTable

        cerrarConexion()

    End Function
    Public Sub BuscarServicio(ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("ServicioBuscar", objConexion)
        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        cerrarConexion()

    End Sub
    Public Function CabaniaServCargar(ByVal idCabania As Integer, ByVal idServicio As Integer)
        Try
            abrirConexion()

            Dim objComando As New SqlCommand("CabaniaServCargar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@idCabania", idCabania)
            objComando.Parameters.AddWithValue("@idServicios", idServicio)
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
    Public Function CabaniaServBorrar(ByVal idServicio As Integer)
        Try
            abrirConexion()

            Dim objComando As New SqlCommand("CabaniaServBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@idCabaniaServ", idServicio)
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

    Public Sub CabaniaServCarga(ByVal idCabania As Integer, ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("CabaniaServCarga", objConexion)
        objComando.CommandType = CommandType.StoredProcedure
        objComando.Parameters.AddWithValue("@idCabania", idCabania)

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 30
        tabla.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        cerrarConexion()
    End Sub

    Public Function CabaniaCostoServicio(ByVal idCabania) As Decimal
        Try
            abrirConexion()
            Dim CostoServ As Decimal
            Dim objcomando As New SqlCommand("CabaniaCostoServicio", objConexion)
            objcomando.Parameters.AddWithValue("@IdCabania", idCabania)
            objcomando.CommandType = CommandType.StoredProcedure
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objcomando)
            objDataAdapter.Fill(objDataTable)

            CostoServ = objDataTable.Rows(0).Item("CostoServ")
            Return CostoServ


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            cerrarConexion()

        End Try

    End Function

End Class

