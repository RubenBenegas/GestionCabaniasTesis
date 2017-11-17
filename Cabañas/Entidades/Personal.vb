Imports System.Data
Imports System.Data.SqlClient

Public Class Personal
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

    Private Departamento_ As Integer

    Public Property Departamento() As Integer
        Get
            Return Departamento_
        End Get
        Set(ByVal value As Integer)
            Departamento_ = value
        End Set
    End Property

    Private SueldoPorMes_ As Decimal

    Public Property SueldoPorMes() As Decimal
        Get
            Return SueldoPorMes_
        End Get
        Set(ByVal value As Decimal)
            SueldoPorMes_ = value
        End Set
    End Property

    Public Sub PersonalTraerTab(ByVal tabla As DataGridView)
        abrirConexion()

        Dim objComando As New SqlCommand("PersonalTraerTab", objConexion)

        objComando.CommandType = CommandType.StoredProcedure

        Dim objDataTable As New Data.DataTable
        Dim objDataAdapter As New SqlDataAdapter(objComando)
        objDataAdapter.Fill(objDataTable)
        tabla.DataSource = objDataTable

        tabla.Columns("Id").Width = 50
        tabla.Columns("Nombre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Direccion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Telefono").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("Departamento").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        tabla.Columns("SueldoPorMes").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        cerrarConexion()

    End Sub

    Public Function PersonalInsertar(ByVal Person As Personal) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("PersonalInsertar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure

            objComando.Parameters.AddWithValue("@Nombre", Person.Nombre)
            objComando.Parameters.AddWithValue("@Direccion", Person.Direccion)
            objComando.Parameters.AddWithValue("@Telefono", Person.Telefono)
            objComando.Parameters.AddWithValue("@Departamento", Person.Departamento)
            objComando.Parameters.AddWithValue("@SueldoPorMes", Person.SueldoPorMes)

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

    Public Function PersonalRecuperar(ByVal IdPersonal As Integer) As Personal

        Try
            abrirConexion()
            Dim Personal As New Personal
            Dim objComando As New SqlCommand("PersonalRecuperar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdPersonal", IdPersonal)
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            If objDataTable.Rows.Count > 0 Then
                objDataAdapter.Fill(objDataTable)
                Personal.Id = objDataTable.Rows(0).Item("id")
                Personal.Nombre = objDataTable.Rows(0).Item("Nombre")
                Personal.Direccion = objDataTable.Rows(0).Item("Direccion")
                Personal.Telefono = objDataTable.Rows(0).Item("Telefono")
                Personal.Departamento = objDataTable.Rows(0).Item("Departamento")
                Personal.SueldoPorMes = objDataTable.Rows(0).Item("SueldoPorMes")

                Return Personal

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Function

    Public Function PersonalModificar(ByVal Personal As Personal) As Boolean

        Try
            abrirConexion()

            Dim objComando As New SqlCommand("PersonalModificar", objConexion)

            objComando.CommandType = CommandType.StoredProcedure

            objComando.Parameters.AddWithValue("@Nombre", Personal.Nombre)
            objComando.Parameters.AddWithValue("@Direccion", Personal.Direccion)
            objComando.Parameters.AddWithValue("@Telefono", Personal.Telefono)
            objComando.Parameters.AddWithValue("@Departamento", Personal.Departamento)
            objComando.Parameters.AddWithValue("SueldoPorMes", Personal.SueldoPorMes)
            objComando.Parameters.AddWithValue("@Id", Personal.Id)

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

    Public Function PersonalBorrar(ByVal IdPersonal As Integer) As Boolean
        Try

            abrirConexion()

            Dim objComando As New SqlCommand("PersonalBorrar", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@IdPersonal", IdPersonal)
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

    Public Sub CargarComboPersonal(ByVal ComboActual As ComboBox)

        Try
            abrirConexion()
            Dim objComando As New SqlCommand("PersonalCargarCombo", objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            Dim objDataTable As New Data.DataTable
            objDataAdapter.Fill(objDataTable)
            With ComboActual
                .DataSource = objDataTable
                .DisplayMember = "Nombre"
                .ValueMember = "Id"
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub

End Class
