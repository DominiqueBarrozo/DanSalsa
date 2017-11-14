Imports System.Data.SqlClient

Public Class BDHelper
    ' La clase BDHelper permite quitar del código del formulario todo lo relacionado con el acceso a bd.
    ' Permite ejecutar comandos sql y retornar resultados a la capa de datos.
    ' Implementa el patrón SINGLETON, que garantiza tener solo una instancia de esta clase.

    Private string_conexion As String
    Private Shared instance As BDHelper 'Unica instancia de la clase
    Dim conexion As New SqlConnection
    Dim Transaction As SqlTransaction

    Private Sub New()
        'string_conexion = "Data Source=USUARIO-PC\SQLEXPRESS;Initial Catalog=DanSalsa;Persist Security Info=True;User ID=sa;Password=fori=0"
        ' string_conexion = "Data Source=BRUNO;Initial Catalog=DanSalsa;Persist Security Info=True;User ID=sa;Password=S1m0n4$$"
        string_conexion = "Data Source=DESKTOP-CC08B1S\SQLEXPRESS;Initial Catalog=DanSalsa;Integrated Security=True"
    End Sub

    Public Shared Function getDBHelper() As BDHelper
        If IsNothing(instance) Then
            instance = New BDHelper()
        End If
        Return instance
    End Function

    Public Sub IniciarTransaccion()
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            Transaction = conexion.BeginTransaction
        Catch ex As Exception
            Throw ex
        End Try



    End Sub

    Public Sub Commit()
        Transaction.Commit()

    End Sub

    Public Sub Rollback()
        Transaction.Rollback()

    End Sub

    Public Function EjecutarSQL(ByVal strSql As String) As Integer
        ' Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”

        Dim cmd As New SqlCommand

        'Try Catch Finally
        'Trata de ejecutar el código contenido dentro del bloque Try - Catch
        'Si hay error lo capta a través de una excepción
        'Si no hubo error
        Try
            ' Establece que conexión usar
            conexion.ConnectionString = string_conexion

            ' Abre la conexión
            If conexion.State <> ConnectionState.Open Then
                conexion.Open()

            End If


            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.Transaction = Transaction
            ' Establece la instrucción a ejecutar
            cmd.CommandText = strSql
            ' Retorna el resultado de ejecutar el comando
            Return cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            ' Cierra la conexión
            If conexion.State = ConnectionState.Open Then conexion.Close()
            conexion.Dispose()
        End Try
    End Function

    Public Function EjecutarSQL(ByVal strSql As String, ByVal Cierra As Boolean) As Integer
        ' Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”

        Dim cmd As New SqlCommand

        'Try Catch Finally
        'Trata de ejecutar el código contenido dentro del bloque Try - Catch
        'Si hay error lo capta a través de una excepción
        'Si no hubo error
        Try
            ' Establece que conexión usar
            'conexion.ConnectionString = string_conexion

            ' Abre la conexión
            If conexion.State <> ConnectionState.Open Then
                conexion.Open()

            End If


            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.Transaction = Transaction
            ' Establece la instrucción a ejecutar
            cmd.CommandText = strSql
            ' Retorna el resultado de ejecutar el comando
            Return cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            ' Cierra la conexión
            If Cierra Then
                If conexion.State = ConnectionState.Open Then conexion.Close()
                conexion.Dispose()
            End If

        End Try
    End Function
    Public Function EjecutarSQL(ByVal strSql As String, ByVal strSql2 As String) As Integer
        Dim cmd As New SqlCommand
        Try
            IniciarTransaccion()
            EjecutarSQL(strSql, False)
            EjecutarSQL(strSql2, False)
            Commit()
            cmd.ExecuteNonQuery()

            Return 1
        Catch ex As Exception
            Rollback()
            Throw ex
        Finally

        End Try
    End Function

    Public Function ConsultaSQL(ByVal strSql As String) As Data.DataTable
        ' Se utiliza para sentencias SQL del tipo “Select”
        ' La función recibe por valor una sentencia sql como string, devuelve un objeto de tipo DataTable
        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = strSql
            ' El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos
            tabla.Load(cmd.ExecuteReader)
            ' La función retorna el objeto datatable con 0, 1 o mas registros
            Return tabla
        Catch ex As Exception
            Throw ex
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
            'Dispose() libera los recursos asociados a la conexón
            conexion.Dispose()
        End Try
    End Function

    Public Function ConsultarSQLConParametros(ByVal sqlStr As String, ByVal params As Object()) As Data.DataTable
        ' Se utiliza para sentencias SQL del tipo “Select” con parámetros recibidos desde la interfaz
        ' La función recibe por valor una sentencia sql como string y un arreglo de parámetros, devuelve un objeto de tipo DataTable

        Dim conexion As New SqlConnection
        Dim cmd As New SqlCommand
        Dim tabla As New DataTable
        Dim n_param As String
        Try
            conexion.ConnectionString = string_conexion
            conexion.Open()
            cmd.Connection = conexion
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sqlStr

            'Agregamos a la colección de parámetros del comando los filtros recibidos
            'IMPORTANTE: cada parametro deberá llamarse: param1, param2,.., paramN
            For i = 0 To params.Length - 1
                If Not IsNothing(params(i)) Then
                    n_param = "param" + Convert.ToString(i + 1)
                    cmd.Parameters.AddWithValue(n_param, params(i))
                End If
            Next

            ' El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos
            tabla.Load(cmd.ExecuteReader)
            ' La función retorna el objeto datatable con 0, 1 o mas registros
            Return tabla
        Catch ex As Exception
            Throw ex
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
            'Dispose() libera los recursos asociados a la conexón
            conexion.Dispose()
        End Try
    End Function
End Class

