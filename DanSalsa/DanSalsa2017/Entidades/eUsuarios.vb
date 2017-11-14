Public Class eUsuarios
    Private pnombre As String
    Public Property nombre() As String
        Get
            Return pnombre
        End Get
        Set(ByVal value As String)
            pnombre = value
        End Set
    End Property
    Private papellido As String
    Public Property apellido() As String
        Get
            Return papellido
        End Get
        Set(ByVal value As String)
            papellido = value
        End Set
    End Property
    Private plogin As String
    Public Property login() As String
        Get
            Return plogin
        End Get
        Set(ByVal value As String)
            plogin = value
        End Set
    End Property
    Private ppassword As String
    Public Property password() As String
        Get
            Return ppassword
        End Get
        Set(ByVal value As String)
            ppassword = value
        End Set
    End Property
    Private pactivo As Integer
    Public Property activo() As Integer
        Get
            Return pactivo
        End Get
        Set(ByVal value As Integer)
            pactivo = value
        End Set
    End Property
    Private pid As Integer
    Public Property id() As Integer
        Get
            Return pid
        End Get
        Set(ByVal value As Integer)
            pid = value
        End Set
    End Property
End Class
