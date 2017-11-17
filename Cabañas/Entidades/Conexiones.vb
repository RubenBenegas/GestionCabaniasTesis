Imports System.Data
Imports System.Data.SqlClient

Public Class Conexiones

    Private strConexion_ As String
    Public Property strConexion() As String
        Get
            Return strConexion_
        End Get
        Set(ByVal value As String)
            strConexion_ = value
        End Set
    End Property


    Private objConexion_ As SqlConnection
    Public Property objConexion() As SqlConnection
        Get
            Return objConexion_
        End Get
        Set(ByVal value As SqlConnection)
            objConexion_ = value
        End Set
    End Property



    Public Function abrirConexion()


        Try
            strConexion = "server=LocalHost\SQLEXPRESS; database=Cabania; trusted_connection=true"

            objConexion = New SqlConnection(strConexion)

            objConexion.Open()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function cerrarConexion()

        Try
            If objConexion.State = ConnectionState.Open Then
                objConexion.Close()
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
        End Try

    End Function


End Class
