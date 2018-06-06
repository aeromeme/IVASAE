Imports IVASAE.Utilidades

Public Class DataSistema

#Region "General"
    Private _cUsuario As String
    Private _idUsuario As Integer
    Private _nomUsuario As String
    Private _nomSistema As String
    Private _verSistema As String
    Private _perfil As Integer
    Private _nvlAcceso As String
    Private _ContextoGeneral As DB_GENERALDataContext

    Private _NombreOpcion As String
    Private _NombreVentana As String
    Private _CadenaConexion As String
    Private _NombreFormulario As String

    Private _cadenaIMACASA_SV As String

    Private _CadenaConexionCA As String  '---Prueba

    Private _CadenaConexionEF As String
    Private _perfilUsuario As GEN_PERFIL
    'Private _perfilImacasaSV As 


#Region "propiedades"
    Public ReadOnly Property cUsuario As String
        Get
            Return _cUsuario
        End Get
    End Property

    Public ReadOnly Property nomUsuario As String
        Get
            Return _nomUsuario
        End Get
    End Property

    Public ReadOnly Property nomSistema As String
        Get
            Return _nomSistema
        End Get
    End Property

    Public ReadOnly Property verSistema As String
        Get
            Return _verSistema
        End Get
    End Property

    Public ReadOnly Property perfil As Integer
        Get
            Return _perfil
        End Get
    End Property
    Public ReadOnly Property nvlAcceso As String
        Get
            Return _nvlAcceso
        End Get
    End Property

    Public ReadOnly Property idUsuario As Integer
        Get
            Return _idUsuario
        End Get
    End Property

    Public Property NombreOpcion As String
        Get
            Return _NombreOpcion
        End Get
        Set(value As String)
            _NombreOpcion = value
        End Set
    End Property

    Public Property NombreVentana As String
        Get
            Return _NombreVentana
        End Get
        Set(value As String)
            _NombreVentana = value
        End Set
    End Property

    Public ReadOnly Property ContextoGeneral As DB_GENERALDataContext
        Get
            Return _ContextoGeneral

        End Get
    End Property

    Public ReadOnly Property perfilUsuario As GEN_PERFIL
        Get
            Return _perfilUsuario
        End Get
    End Property


    Public Property nombreFormulario() As String
        Get
            Return _NombreFormulario
        End Get
        Set(ByVal value As String)
            _NombreFormulario = value
        End Set
    End Property



#End Region

    Sub New()
        _nomSistema = My.Application.Info.Title
        _verSistema = My.Application.Info.Version.ToString
    End Sub

    Sub GuardarConexion(cadenaConexion As String)
        _CadenaConexion = cadenaConexion
    End Sub

    Sub GuardarConexionEF(cadenaConexion As String)
        _CadenaConexionEF = cadenaConexion
    End Sub
    '----Prueba
    'Sub ObtenerConexionCA(cadenaConexionCA As String)
    '    _CadenaConexionCA = cadenaConexionCA
    'End Sub

    Sub GuardarUsuario(usuario As String)
        _cUsuario = usuario
    End Sub

    Sub ConectarGeneral()
        _ContextoGeneral = New DB_GENERALDataContext(_CadenaConexion)
    End Sub

    Function ObtenerDatosUsuario() As Boolean
        Try
            Dim u As GEN_USUARIO
            u = (From r In _ContextoGeneral.GEN_USUARIO
                       Select r Where r.CD_LOGIN = _cUsuario).ToList(0)
            If u.CD_ESTADO = "A" Then
                _nomUsuario = u.DESC_NOMBRE_USUARIO
                _perfil = u.ID_PERFIL
                _idUsuario = u.ID
                _nvlAcceso = u.GEN_PERFIL.CD_NIVEL_ACCESO
                _perfilUsuario = (From r In _ContextoGeneral.GEN_PERFIL
                             Select r Where r.ID = _perfil).ToList(0)
                Return True
            End If
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try

        Return False
    End Function

    Function ObtenerConfiguracion() As Boolean
        Try
            'Dim u As GEN_CONFIG
            'u = (From r In _ContextoGeneral.GEN_CONFIG
            '   Select r).ToList()(0)

            Return True
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try
        Return False
    End Function

#End Region

#Region "SAE"
    'Private _ContextoSAE As IMACANET_SAE.DB_SAEDataContext
    'Public ReadOnly Property ContextoSAE As IMACANET_SAE.DB_SAEDataContext
    '    Get
    '        Return _ContextoSAE
    '    End Get
    'End Property
    'Sub ConectarSAE()
    '    _ContextoSAE = New IMACANET_SAE.DB_SAEDataContext(_CadenaConexion)
    'End Sub
#End Region
    'Para Conectar con Filiales IMAC
#Region "IVA"
    Private _ContextoIVA As IMACANET_IVA.DB_IVADataContext
    Public ReadOnly Property ContextoIVA As IMACANET_IVA.DB_IVADataContext
        Get
            Return _ContextoIVA
        End Get
    End Property
    Sub ConectarIVA()
        _ContextoIVA = New IMACANET_IVA.DB_IVADataContext(_CadenaConexion)
    End Sub
#End Region

End Class
