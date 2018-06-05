Imports DevExpress.XtraEditors.DXErrorProvider
Imports System.Text.RegularExpressions
Imports IVASAE.Utilidades
Public Class FcambiarPwd
    Public _datasistema As DataSistema

    Private Sub UIPASS_Enter(sender As Object, e As EventArgs) Handles UIPASS.Enter
        UIPASSCONFIRM.EditValue = ""
    End Sub
    Public Sub New(ds As DataSistema)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        _datasistema = ds
    End Sub
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub



    Private Sub uibtnguardar_Click(sender As Object, e As EventArgs) Handles uibtnguardar.Click
        If UIValidador.Validate Or UIPASSCONFIRM.Text = "" Then
            If (From u In _datasistema.ContextoGeneral.GEN_USUARIO
                Select u Where u.CD_LOGIN = _datasistema.cUsuario And u.CD_PASSWORD = UIOLDPASS.EditValue.ToString).Count > 0 Then


                Dim usuario As GEN_USUARIO = (From u In _datasistema.ContextoGeneral.GEN_USUARIO
                Select u Where u.CD_LOGIN = _datasistema.cUsuario).ToList()(0)

                usuario.CD_PASSWORD = UIPASS.EditValue

                Dim historial As New GEN_HIST_PASS With
            {.ID = 0,
             .ID_USUARIO = _datasistema.idUsuario,
             .CD_PASSWORD = UIPASS.EditValue,
             .FECHA_HIST = Now
                }

                _datasistema.ContextoGeneral.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                _datasistema.ContextoGeneral.GEN_HIST_PASS.InsertOnSubmit(historial)
                Try
                    _datasistema.ContextoGeneral.SubmitChanges()
                    Me.Close()
                Catch ex As System.Data.SqlClient.SqlException
                    MetodosForm.MensajeErrorDefault(ex.Message)
                Catch ex As Exception
                    MetodosForm.MensajeErrorDefault("Critical error")
                End Try
            Else
                MetodosForm.MensajeErrorDefault("Contraseña antigua invalida")
            End If
        Else
            MetodosForm.MensajeErrorDefault("Nuevas contraseñas invalidas")
        End If
    End Sub

    Private Sub uibtncancelar_Click(sender As Object, e As EventArgs) Handles uibtncancelar.Click
        Me.Close()
    End Sub
    Private Sub FcambiarPwd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim customValidationRule As New CustomValidationRule()
        customValidationRule.ErrorText = "Formate de contraseña invalido"
        customValidationRule.ErrorType = ErrorType.Warning
        UIValidador.SetValidationRule(UIPASS, customValidationRule)
        UIOLDPASS.Select()

    End Sub
End Class
Public Class CustomValidationRule
    Inherits ValidationRule
    Public Overrides Function Validate(control As Control, value As Object) As Boolean
        Dim str As String = CStr(value)
        If IsNothing(str) Or str = "" Then
            Return True
        End If
        Dim re As Regex = New Regex("(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$")
        Return re.IsMatch(str)
    End Function
End Class