
Namespace Utilidades

    Public Class Saveconx


        'Dim ccomuser As New comprobaruser

        Public Sub Guardarparametrosconex(intancia As String, bd As String, user As String, pass As String)
            'guardar parametros
            My.Settings.SERVER = Trim(intancia)
            My.Settings.DATABASE = Trim(bd)
            My.Settings.USER_SERVER = Trim(user)
            My.Settings.PASS_SERVER = Trim(pass)
            My.Settings.Save()
        End Sub

        Public Sub Eliminardatosuser()
            'My.Settings.ID_USER = Nothing
            My.Settings.USUARIO = Nothing
            My.Settings.PASSWORD = Nothing
            'My.Settings.NIVELACCESO = Nothing
            'My.Settings.STADOCHECKEN = 1
            My.Settings.Save()
        End Sub

        Public Function enviarparametrosconx_server()

            If My.Settings.SERVER = Nothing Then
                MsgBox("vacio")
                Return Nothing
            Else
                Return My.Settings.SERVER
            End If
        End Function


        Public Function enviarparametrosconx_database()

            If My.Settings.DATABASE = Nothing Then
                Return Nothing
            Else
                Return My.Settings.DATABASE
            End If
        End Function

        Public Function enviarparametrosconx_userserver()

            If My.Settings.USER_SERVER = Nothing Then
                Return Nothing
            Else
                Return My.Settings.USER_SERVER
            End If
        End Function

        Public Function enviarparametrosconx_passserver()

            If My.Settings.PASS_SERVER = Nothing Then
                Return Nothing
            Else
                Return My.Settings.PASS_SERVER
            End If
        End Function

        Public Function enviarparametrosconx_usuario()

            If My.Settings.USUARIO = Nothing Then
                Return Nothing
            Else
                Return My.Settings.USUARIO
            End If
        End Function

        Public Function enviarparametrosconx_password()

            If My.Settings.PASSWORD = Nothing Then
                Return Nothing
            Else
                Return My.Settings.PASSWORD
            End If
        End Function

        Public Function enviarparametrosconx_STADOCHECK()

            Return My.Settings.STADOCHECKEN
        End Function


    End Class
End Namespace