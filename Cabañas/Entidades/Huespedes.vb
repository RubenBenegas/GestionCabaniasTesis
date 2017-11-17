Imports System.Data
Imports System.Data.SqlClient

Public Class Huespedes

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

    Private nombre_ As String
    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property


    Private dni_ As Integer
    Public Property dni() As Integer
        Get
            Return dni_
        End Get
        Set(ByVal value As Integer)
            dni_ = value
        End Set
    End Property


    Private localidad_ As String
    Public Property localidad() As String
        Get
            Return localidad_
        End Get
        Set(ByVal value As String)
            localidad_ = value
        End Set
    End Property

    Private direccion_ As String
    Public Property direccion() As String
        Get
            Return direccion_
        End Get
        Set(ByVal value As String)
            direccion_ = value
        End Set
    End Property

    Private telefono_ As String
    Public Property telefono() As String
        Get
            Return telefono_
        End Get
        Set(ByVal value As String)
            telefono_ = value
        End Set
    End Property


    Private email_ As String
    Public Property email() As String
        Get
            Return email_
        End Get
        Set(ByVal value As String)
            email_ = value
        End Set
    End Property


    Public Sub TraerTabHuespedes(ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("HuespedTraerTab", objConexion)
        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'tabla.Columns("Dni").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'tabla.Columns("Localidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'tabla.Columns("Direccion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'tabla.Columns("Telefono").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        'tabla.Columns("Email").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        cerrarConexion()

    End Sub


    Public Function InsertarHuesped(ByVal huesped As Huespedes) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("HuespedInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Nombre", huesped.nombre)
            objComando.Parameters.AddWithValue("@Dni", huesped.dni)
            objComando.Parameters.AddWithValue("@Localidad", huesped.localidad)
            objComando.Parameters.AddWithValue("@Direccion", huesped.direccion)
            objComando.Parameters.AddWithValue("@Telefono", huesped.telefono)
            objComando.Parameters.AddWithValue("@Email", huesped.email)
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


    Public Function BorraHuesped(ByVal idHuesped As Integer) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("HuespedBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdHuesped", idHuesped)
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

    Public Function RecuperarHuesped(ByVal idHuesped As Integer) As Huespedes

        Try
            abrirConexion()
            Dim huesped As New Huespedes
            Dim objComando As New SqlCommand("HuespedRecuperar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdHuesped", idHuesped)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                objDataAdapter.Fill(objDataTable)
                huesped.id = objDataTable.Rows(0).Item("Id")
                huesped.nombre = objDataTable.Rows(0).Item("Nombre")
                huesped.dni = objDataTable.Rows(0).Item("Dni")
                huesped.localidad = objDataTable.Rows(0).Item("Localidad")
                huesped.direccion = objDataTable.Rows(0).Item("Direccion")
                huesped.telefono = objDataTable.Rows(0).Item("Telefono")
                huesped.email = objDataTable.Rows(0).Item("Email")
                Return huesped
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function

    Public Function ModificarHuesped(ByVal huesped As Huespedes) As Boolean

        Try
            abrirConexion()
            Dim objComando As New SqlCommand("HuespedModificar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@Nombre", huesped.nombre)
            objComando.Parameters.AddWithValue("@Dni", huesped.dni)
            objComando.Parameters.AddWithValue("@Localidad", huesped.localidad)
            objComando.Parameters.AddWithValue("@Direccion", huesped.direccion)
            objComando.Parameters.AddWithValue("@Telefono", huesped.telefono)
            objComando.Parameters.AddWithValue("@Email", huesped.email)
            objComando.Parameters.AddWithValue("@Id", huesped.id)
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

    Public Sub BuscarHuespedes(ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("HuespedBuscar", objConexion)
        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        

        cerrarConexion()

    End Sub

    Public Sub HuespedTraerHistorial(ByVal idHuesped As Integer, ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("HuespedHistorial", objConexion)
        objComando.CommandType = CommandType.StoredProcedure
        objComando.Parameters.AddWithValue("@IdHuesped", idHuesped)
        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        For Each row As DataGridViewRow In tabla.Rows
            If row.Cells("IdEstado").Value = 5 Then
                row.DefaultCellStyle.BackColor = Color.Red
            End If
        Next

        'If objDataTable.Rows(0).Item("IdEstado") = 5 Then
        '    tabla.DefaultCellStyle.BackColor = Color.Red

        'End If

        tabla.Columns("Id").Width = 50
        tabla.Columns("IdEstado").Visible = False
        tabla.Columns("idCabania").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill



        cerrarConexion()

    End Sub

End Class
