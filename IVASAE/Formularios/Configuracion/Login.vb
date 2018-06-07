Imports IVASAE.Utilidades
'Imports SysActivofijo.Clases
    Public Class Login
    ReadOnly _saveparamtroconx As New Saveconx
        'ReadOnly _validauser As New Comprobaruser
    Private _obj As cUsuario
    ReadOnly _erroLog As New Errorlog
    Private Const Msjinfo01 As String = "INFO:Inicio de sesion"
    Private Const Msjinfo02 As String = "ERROR:"
    Private _datasistema As DataSistema
    Private cConexion As New Conexion
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles EntrySys.Click
        Try
            _datasistema = New DataSistema()
            _datasistema.GuardarConexion(cConexion.ObtenerCadenaConexion)
            _datasistema.GuardarConexionEF(cConexion.ObtenerCadenaConexionEntity)
            _datasistema.ConectarGeneral()
            _obj = New cUsuario(_datasistema.ContextoGeneral)

            If _obj.Autenticar(Usuario.Text, passwork.Text) = True Then
                If Usuario.Text = "ROOT" Then

                Else
                    Guardardatosuser()

                End If
                _erroLog.Send_Result_generales(Msjinfo01 & "   " & "USUARIO.." & "   " & Usuario.Text)

                _datasistema.GuardarUsuario(Usuario.Text)
                Principal._datasistema = _datasistema
                If Principal.cargarsistema Then
                    Principal.Enabled = True
                    Close()
                End If
            Else
                MetodosForm.MensajeErrorDefault(_obj.msj)
                _erroLog.Send_Result_generales(Msjinfo02 & "   " & "Usuario o Password invalidos" & "   " & Usuario.Text)
            End If

        Catch ex As Exception
            MetodosForm.MensajeErrorDefault(ex.Message)
            ''index.Close()
        End Try

    End Sub

    Public Sub Guardardatosuser()
        If TEMPuser.Checked = True Then
            My.Settings.USUARIO = Usuario.Text
            My.Settings.PASSWORD = passwork.Text
            My.Settings.STADOCHECKEN = 2
            My.Settings.Save()

        Else
            My.Settings.STADOCHECKEN = 1
            My.Settings.Save()
        End If

    End Sub

    Public Sub Mostraconx()
        Cserver.Text = _saveparamtroconx.enviarparametrosconx_server
        Cdata.Text = _saveparamtroconx.enviarparametrosconx_database
        Cuser.Text = _saveparamtroconx.enviarparametrosconx_userserver
        Cpass.Text = _saveparamtroconx.enviarparametrosconx_passserver

    End Sub

    Private Sub Boption_Click(sender As System.Object, e As EventArgs) Handles Boption.Click

        If Size = New Size(390, 261) Then
            'ventana grande
            Size = New Size(390, 594)
            config.Visible = True
            'Me.Width = 440
            EntrySys.Location = New Point(81, 527)
            Cclose.Location = New Point(170, 527)
            Boption.Location = New Point(256, 527)
            Boption.Text = "<< Opcion"

            Mostraconx()
        Else
            'ventana pequena
            Size = New Size(390, 261)
            config.Visible = True
            'Me.Width = 440
            EntrySys.Location = New Point(88, 194)
            Cclose.Location = New Point(177, 194)
            Boption.Location = New Point(263, 194)
            Boption.Text = "Opcion >>"
        End If

    End Sub

    Private Sub Login_Load(sender As System.Object, e As EventArgs) Handles MyBase.Load

        Size = New Size(390, 261)
        Mostrardatos()
        '_erroLog.Send_Result()
        Usuario.Select()

    End Sub

    Private Sub Cclose_Click(sender As System.Object, e As EventArgs) Handles Cclose.Click
        Principal.Close()

    End Sub

    Private Sub Gconex_Click(sender As System.Object, e As EventArgs) Handles Gconex.Click

        'intancia As String, bd As String, user As String, pass As String
        _saveparamtroconx.Guardarparametrosconex(Cserver.Text, Cdata.Text, Cuser.Text, Cpass.Text)
        'MsgBox("Datos de conexiones Guardadas", MsgBoxStyle.Information)
        MetodosForm.MensajeInfoDefault("Datos de conexiones Guardadas")
        '_erroLog.Send_Result_generales(Msjinfo01 & "   " & "Datos de conexiones Guardadas")

    End Sub

    Private Sub Tconex_Click(sender As System.Object, e As EventArgs) Handles Tconex.Click
        cConexion.Validadfuncion()
    End Sub

    Public Sub Mostrardatos()
        If _saveparamtroconx.enviarparametrosconx_STADOCHECK = 2 Then
            Usuario.Text = _saveparamtroconx.enviarparametrosconx_usuario
            passwork.Text = _saveparamtroconx.enviarparametrosconx_password
            TEMPuser.Checked = True
        Else
            Usuario.Text = Nothing
            passwork.Text = Nothing
        End If
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Principal.Enabled Then
            Principal.Close()
        End If

    End Sub
End Class
