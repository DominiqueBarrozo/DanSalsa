Public Class eInscripcion
    Private pid As Integer
    Public Property id() As Integer
        Get
            Return pid
        End Get
        Set(ByVal value As Integer)
            pid = value
        End Set
    End Property
    Private pfecha As DateTime
    Public Property fecha() As DateTime
        Get
            Return pfecha
        End Get
        Set(ByVal value As DateTime)
            pfecha = value
        End Set
    End Property
    Private pidClase As Integer
    Public Property idClase() As Integer
        Get
            Return pidClase
        End Get
        Set(ByVal value As Integer)
            pidClase = value
        End Set
    End Property
    Private pidAlumno As Integer
    Public Property idAlumno() As Integer
        Get
            Return pidAlumno
        End Get
        Set(ByVal value As Integer)
            pidAlumno = value
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
    Private pclase As String
    Public Property clase() As String
        Get
            Return pclase
        End Get
        Set(ByVal value As String)
            pclase = value
        End Set
    End Property

End Class
