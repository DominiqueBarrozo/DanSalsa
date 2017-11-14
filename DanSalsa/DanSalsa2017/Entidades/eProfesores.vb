Public Class eProfesores
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
End Class
