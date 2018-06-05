
Imports System.Data.SqlClient
Imports System.Data.OleDb

Namespace Utilidades
    Public Class Conexion
        Inherits Saveconx

        ReadOnly _errorlog As New Errorlog
        Public Conn As New SqlConnection
        Public Connt As New SqlConnection
        Dim _cadena As String


        Private Const Msjinfo02 As String = "ERROR:"

        Public Function Conectar()
            _cadena = "Server=" & enviarparametrosconx_server() & ";uid=" & enviarparametrosconx_userserver() & ";pwd=" & enviarparametrosconx_passserver() & ";database=" & enviarparametrosconx_database() & ""
            Conn = New SqlConnection(_cadena)
            Return Conn
        End Function
        Public Function ObtenerCadenaConexion()
            _cadena = "Server=" & enviarparametrosconx_server() & ";uid=" & enviarparametrosconx_userserver() & ";pwd=" & enviarparametrosconx_passserver() & ";database=" & enviarparametrosconx_database() & ""
            Return _cadena
        End Function
        Public Function ObtenerCadenaConexionEntity()
            Return "metadata='res://*/Acceso a datos.ModelSyscalf.csdl|res://*/Acceso a datos.ModelSyscalf.ssdl|res://*/Acceso a datos.ModelSyscalf.msl';provider=System.Data.SqlClient;provider connection string='data source=" + enviarparametrosconx_server() + ";initial catalog=SysCalif;persist security info=True;user id=" + enviarparametrosconx_userserver() + ";password=" + enviarparametrosconx_passserver() + ";MultipleActiveResultSets=True;App=EntityFramework'"
        End Function



        '---Pruebas
        'Public Function ObtenerCadenaConexionGT()
        '    _cadenaCA = "Server=168.234.200.4;uid=ASPEL;pwd=SAE;database=SYSREPORTCA02"
        '    Return _cadenaCA
        'End Function

        'Public Function ObtenerCadenaConexionHN()
        '    _cadenaCA = "Server=190.5.91.219;uid=ASPEL;pwd=SAE;database=SYSREPORTCA02"
        '    Return _cadenaCA
        'End Function

        'Public Function ObtenerCadenaConexionNIC()
        '    _cadenaCA = "Server=165.98.69.187;uid=ASPEL;pwd=SAE;database=SYSREPORTCA02"
        '    Return _cadenaCA
        'End Function

        'Public Function ObtenerCadenaConexionCR()
        '    _cadenaCA = "Server=190.241.189.62;uid=ASPEL;pwd=SAE;database=SYSREPORTCA02"
        '    Return _cadenaCA
        'End Function

        Private _returncox As Boolean
        Public Function Validadfuncion()

            Try
                Conectar.open()
                _returncox = True
                MsgBox("Conexion Exitosa")
                Conectar.close()

            Catch ex As Exception

                MsgBox(ex.Message)
                _errorlog.Send_Result_generales(Msjinfo02 & "  #" & ex.Message)

                Conectar.close()
                _returncox = False

            End Try

            Return _returncox

        End Function

    End Class
End Namespace