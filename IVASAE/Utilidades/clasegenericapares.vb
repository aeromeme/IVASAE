Namespace Utilidades
    Public Class clasegenericapares
        Private _codigo As Object
        Private _descripcion As String

        Public ReadOnly Property Codigo As Object
            Get
                Return _codigo
            End Get
        End Property
        Public ReadOnly Property Descripcion As String
            Get
                Return _descripcion
            End Get
        End Property
        Public Sub New(_pcodigo As Object, _pdescripcion As String)
            _codigo = _pcodigo
            _descripcion = _pdescripcion
        End Sub
    End Class
End Namespace

