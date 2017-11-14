Public Class eAlumnos
    Private pId As String
    Public Property Id() As Integer
        Get
            Return pId
        End Get
        Set(ByVal value As Integer)
            pId = value
        End Set
    End Property
    Private pNombre As String
    Public Property Nombre() As String
        Get
            Return pNombre
        End Get
        Set(ByVal value As String)
            pNombre = value
        End Set
    End Property

    Private pApellido As String
    Public Property Apellido() As String
        Get
            Return pApellido
        End Get
        Set(ByVal value As String)
            pApellido = value
        End Set
    End Property

    Private pTipoDoc As String
    Public Property TipoDoc() As String
        Get
            Return pTipoDoc
        End Get
        Set(ByVal value As String)
            pTipoDoc = value
        End Set
    End Property

    Private pNroDoc As Integer
    Public Property NroDoc() As Integer
        Get
            Return pNroDoc
        End Get
        Set(ByVal value As Integer)
            pNroDoc = value
        End Set
    End Property

    Private pTelefono As Integer
    Public Property Telefono() As Integer
        Get
            Return pTelefono
        End Get
        Set(ByVal value As Integer)
            pTelefono = value
        End Set
    End Property

    Private pSexo As Integer
    Public Property Sexo() As Integer
        Get
            Return pSexo
        End Get
        Set(ByVal value As Integer)
            pSexo = value
        End Set
    End Property
    Private pLegajo As Integer
    Public Property Legajo() As Integer
        Get
            Return pLegajo
        End Get
        Set(ByVal value As Integer)
            pLegajo = value
        End Set
    End Property
    Private pNro As Integer
    Public Property Nro() As Integer
        Get
            Return pNro
        End Get
        Set(ByVal value As Integer)
            pNro = value
        End Set
    End Property
    Private pCalle As String
    Public Property Calle() As String
        Get
            Return pCalle
        End Get
        Set(ByVal value As String)
            pCalle = value
        End Set
    End Property
    Private pActivo As Integer
    Public Property Activo() As Integer
        Get
            Return pActivo
        End Get
        Set(ByVal value As Integer)
            pActivo = value
        End Set
    End Property
    Private pFechaNac As DateTime
    Public Property FechaNac() As DateTime
        Get
            Return pFechaNac
        End Get
        Set(ByVal value As DateTime)
            pFechaNac = value
        End Set
    End Property
End Class
