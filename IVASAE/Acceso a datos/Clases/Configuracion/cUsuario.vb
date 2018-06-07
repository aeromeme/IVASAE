Public Class cUsuario
    Private _db As DB_GENERALDataContext
    Private _msj As String
    Public Property msj
        Get
            Return _msj
        End Get
        Set(value)
            _msj = value
        End Set
    End Property

    Public Function Autenticar(pUsuario As String, pPassword As String) As Boolean
        Dim valido As Boolean
        _db.VALI_USUARIO(pUsuario, pPassword, valido, _msj)
        Return valido
    End Function
    Sub New(pDB As DB_GENERALDataContext)
        _db = pDB
    End Sub
End Class
