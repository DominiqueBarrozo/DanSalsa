Public Class eClase
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

    Private pDescripcion As String
    Public Property Descripcion() As String
        Get
            Return pDescripcion
        End Get
        Set(ByVal value As String)
            pDescripcion = value
        End Set
    End Property

    Private pidProfesor As Integer
    Public Property IdProfesor() As Integer
        Get
            Return pidProfesor
        End Get
        Set(ByVal value As Integer)
            pidProfesor = value
        End Set
    End Property

    Private pidRitmo As Integer
    Public Property IdRitmo() As Integer
        Get
            Return pidRitmo
        End Get
        Set(ByVal value As Integer)
            pidRitmo = value
        End Set
    End Property
    Private pMonto As Double
    Public Property Monto() As Double
        Get
            Return pMonto
        End Get
        Set(ByVal value As Double)
            pMonto = value
        End Set
    End Property
End Class
