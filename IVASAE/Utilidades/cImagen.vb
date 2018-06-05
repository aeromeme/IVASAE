Public Class cImagen
    Private _nombre As String
    Private _imagen As Image
    Private _id As Integer
    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property imagen As Image
        Get
            Return _imagen
        End Get
        Set(value As Image)
            _imagen = value
        End Set
    End Property
    Public Sub New(pid As Integer, pnombre As String, pimagen As Image)
        _nombre = pnombre
        _imagen = pimagen
        _id = pid
    End Sub
End Class
