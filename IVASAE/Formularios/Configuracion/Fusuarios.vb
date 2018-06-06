Imports IVASAE.Utilidades
Imports DevExpress.XtraEditors.Repository
Public Class Fusuarios
    Implements InterfazForms
    Dim varlista As Generic.List(Of V_GEN_USUARIO)
    Dim flgcamposenlazados As Boolean
    Dim varlista_estados As Generic.List(Of clasegenericapares)
    Dim varlista_accesos As Generic.List(Of GEN_PERFIL)
    Public Sub PrepararCombos()

        varlista_estados = MetodosForm.listaEstados
        UICD_ESTADO.Properties.DataSource = varlista_estados
        UIGRID_CD_ESTADO.DataSource = varlista_estados

        varlista_accesos = (From u In _datasistema.ContextoGeneral.GEN_PERFIL
                          Select u).ToList
        UICD_NIVEL_ACCESO.Properties.DataSource = varlista_accesos
        UIGRID_ID_PERFIL.DataSource = varlista_accesos
       

    End Sub
    Public Sub bindear() Implements InterfazForms.bindear
        UIID.DataBindings.Add("EditValue", varlista, "ID", False, DataSourceUpdateMode.Never)
        UICD_LOGIN.DataBindings.Add("EditValue", varlista, "CD_LOGIN", False, DataSourceUpdateMode.Never)
        UICD_PASSWORD.DataBindings.Add("EditValue", varlista, "CD_PASSWORD", False, DataSourceUpdateMode.Never)
        UIDESC_NOMBRE_USUARIO.DataBindings.Add("EditValue", varlista, "DESC_NOMBRE_USUARIO", False, DataSourceUpdateMode.Never)
        UICD_NIVEL_ACCESO.DataBindings.Add("EditValue", varlista, "ID_PERFIL", False, DataSourceUpdateMode.Never)
        UICD_ESTADO.DataBindings.Add("EditValue", varlista, "CD_ESTADO", False, DataSourceUpdateMode.Never)
        UICD_CORREO_E.DataBindings.Add("EditValue", varlista, "CD_CORREO_E", False, DataSourceUpdateMode.Never)
        flgcamposenlazados = True
    End Sub

    Public Sub Consultar() Implements InterfazForms.Consultar
        Try
            _datasistema.ConectarGeneral()
            varlista = (From u In _datasistema.ContextoGeneral.V_GEN_USUARIO
                  Select u).ToList

            UIGRIDCONTROL.DataSource = varlista

            PrepararCombos()

            desbindear()
            bindear()
            If varlista.Count = 0 Then
                Limpiar()
            End If
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try
    End Sub

    Public Sub desbindear() Implements InterfazForms.desbindear
        UIID.DataBindings.Clear()
        UICD_LOGIN.DataBindings.Clear()
        UICD_PASSWORD.DataBindings.Clear()
        UIDESC_NOMBRE_USUARIO.DataBindings.Clear()
        UICD_NIVEL_ACCESO.DataBindings.Clear()
        UICD_ESTADO.DataBindings.Clear()
        UICD_CORREO_E.DataBindings.Clear()
        flgcamposenlazados = False
    End Sub

    Public Sub Eliminar() Implements InterfazForms.Eliminar
        Try
            Dim tupla As GEN_USUARIO = (From a In _datasistema.ContextoGeneral.GEN_USUARIO Where a.ID = Val(UIID.Text)).ToList()(0)
            If Not tupla Is Nothing Then

                If tupla.CD_LOGIN <> "admin" Then
                    _datasistema.ContextoGeneral.GEN_USUARIO.DeleteOnSubmit(tupla)

                    _datasistema.ContextoGeneral.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                    Try
                        _datasistema.ContextoGeneral.SubmitChanges()
                        Consultar()
                    Catch ex As Exception
                        MetodosForm.MensajeErrorDefault("Critical error")

                    End Try
                Else
                    MetodosForm.MensajeErrorDefault("No se puede eliminar el usuario administrador")
                End If

            End If
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try
    End Sub

    Public Sub Imprimir() Implements InterfazForms.Imprimir

    End Sub

    Public Sub Insertar() Implements InterfazForms.Insertar
        Try
           
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try
    End Sub

    Public Sub Limpiar() Implements InterfazForms.Limpiar
        Try
            UIID.Text = ""
            UICD_LOGIN.Text = ""
            UICD_PASSWORD.Text = ""
            UIDESC_NOMBRE_USUARIO.Text = ""
            UICD_NIVEL_ACCESO.EditValue = Nothing
            UICD_ESTADO.EditValue = CChar("A")
            UICD_CORREO_E.EditValue = ""
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Modificar() Implements InterfazForms.Modificar
        Try
            If UIID.Text <> "" Then
                Dim tupla As GEN_USUARIO = (From a In _datasistema.ContextoGeneral.GEN_USUARIO Where a.ID = Val(UIID.Text)).ToList()(0)
                If Not tupla Is Nothing Then
                    If tupla.CD_LOGIN <> "admin" Then
                        tupla.CD_PASSWORD = UICD_PASSWORD.Text
                        tupla.ID_PERFIL = UICD_NIVEL_ACCESO.EditValue
                        tupla.DESC_NOMBRE_USUARIO = UIDESC_NOMBRE_USUARIO.Text
                        tupla.CD_CORREO_E = UICD_CORREO_E.Text

                        _datasistema.ContextoGeneral.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                        Try
                            _datasistema.ContextoGeneral.SubmitChanges()
                            Consultar()
                            MetodosForm.SeleccionarFila(UIGRIDVIEW, "ID", tupla.ID)

                        Catch ex As Exception
                            MetodosForm.MensajeErrorDefault("Critical error")

                        End Try
                    Else
                        MetodosForm.MensajeErrorDefault("No se puede modificar el usuario admin")
                    End If

                Else
                    MetodosForm.MensajeErrorDefault("No se modifico nada")

                End If
            Else
                If UICD_LOGIN.Text <> "admin" Then
                    If (From U In _datasistema.ContextoGeneral.GEN_USUARIO Where U.CD_LOGIN = UICD_LOGIN.Text).Count = 0 Then
                        Dim A As New GEN_USUARIO With
                 {.ID = 0,
                  .CD_LOGIN = UICD_LOGIN.Text,
                  .CD_PASSWORD = UICD_PASSWORD.Text,
                  .DESC_NOMBRE_USUARIO = UIDESC_NOMBRE_USUARIO.Text,
                  .ID_PERFIL = UICD_NIVEL_ACCESO.EditValue,
                  .CD_ESTADO = "A",
                  .CD_CORREO_E = UICD_CORREO_E.Text
                 }

                        _datasistema.ContextoGeneral.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                        _datasistema.ContextoGeneral.GEN_USUARIO.InsertOnSubmit(A)
                        Try
                            _datasistema.ContextoGeneral.SubmitChanges()
                            Consultar()
                            MetodosForm.SeleccionarFila(UIGRIDVIEW, "ID", A.ID)
                        Catch ex As Exception
                            MetodosForm.MensajeErrorDefault("Critical error")

                        End Try
                    Else
                        MetodosForm.MensajeErrorDefault("El usuario ya existe en sistema, digite otro usuario")

                    End If
                Else
                    MetodosForm.MensajeErrorDefault("El usuario admin no puede ser adicionado, consulte a soporte de informatica")

                End If
            End If
            
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try
    End Sub
    Public Sub New(ds As DataSistema)
        MyBase.New(ds)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Overrides Sub Refrescar()
        Consultar()
    End Sub
End Class
