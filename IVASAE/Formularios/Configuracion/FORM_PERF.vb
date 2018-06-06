Imports IVASAE.Utilidades
Public Class FORM_PERF
    Implements InterfazForms

    Dim varlista As Generic.List(Of GEN_PERFIL)
    Dim varlista_opciperfil As Generic.List(Of V_GEN_MENU_PERFIL_AUX)
    Dim varlista_opci As Generic.List(Of V_GEN_OPCION_MENU)
    Dim varNvlAcceso As Generic.List(Of clasegenericapares)

    Public Sub bindear() Implements InterfazForms.bindear
        UIID.DataBindings.Add("EditValue", varlista, "ID", False, DataSourceUpdateMode.Never)
        UIDS_NOMBRE_PERFIL.DataBindings.Add("EditValue", varlista, "DS_NOMBRE_PERFIL", False, DataSourceUpdateMode.Never)
        UICD_NVL_ACCESO.DataBindings.Add("EditValue", varlista, "CD_NIVEL_ACCESO", False, DataSourceUpdateMode.Never)
        UIFLG_NOTI_PROD.DataBindings.Add("EditValue", varlista, "FLG_NOTI_PROD", False, DataSourceUpdateMode.Never)
        UIFLG_NOTI_PROD_CDI.DataBindings.Add("EditValue", varlista, "FLG_NOTI_PROD_CDI", False, DataSourceUpdateMode.Never)
    End Sub
    Public Sub prepararcombos()
        varNvlAcceso = MetodosForm.listaNivelesAcceso
        UIGRID_CD_NIVEL_ACCESO.DataSource = varNvlAcceso
        UICD_NVL_ACCESO.Properties.DataSource = varNvlAcceso
    End Sub

    Public Sub Consultar() Implements InterfazForms.Consultar
        Try
            _datasistema.ConectarGeneral()
            varlista = (From u In _datasistema.ContextoGeneral.GEN_PERFIL
                    Select u).ToList
            UIGRIDCONTROL.DataSource = varlista
            prepararcombos()
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
        UIDS_NOMBRE_PERFIL.DataBindings.Clear()
        UICD_NVL_ACCESO.DataBindings.Clear()
        UIFLG_NOTI_PROD.DataBindings.Clear()
        UIFLG_NOTI_PROD_CDI.DataBindings.Clear()
    End Sub

    Public Sub Eliminar() Implements InterfazForms.Eliminar
        Try
            Dim tupla As GEN_PERFIL = (From a In _datasistema.ContextoGeneral.GEN_PERFIL Where a.ID = Val(UIID.Text)).ToList()(0)
            If Not tupla Is Nothing Then

                _datasistema.ContextoGeneral.GEN_PERFIL.DeleteOnSubmit(tupla)

                _datasistema.ContextoGeneral.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                Try
                    _datasistema.ContextoGeneral.SubmitChanges()
                    Consultar()
                Catch ex As Exception
                    MetodosForm.MensajeErrorDefault("Critical error")

                End Try
            Else
                MetodosForm.MensajeErrorDefault("No se modifico nada")

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
        UIID.EditValue = ""
        UIDS_NOMBRE_PERFIL.EditValue = ""
        UICD_NVL_ACCESO.EditValue = Nothing
        UIFLG_NOTI_PROD.Checked = False
        UIFLG_NOTI_PROD_CDI.Checked = False
    End Sub

    Public Sub Modificar() Implements InterfazForms.Modificar
        Try
            If UIID.Text <> "" Then
                Dim tupla As GEN_PERFIL = (From a In _datasistema.ContextoGeneral.GEN_PERFIL Where a.ID = Val(UIID.Text)).ToList()(0)
                If Not tupla Is Nothing Then

                    tupla.DS_NOMBRE_PERFIL = UIDS_NOMBRE_PERFIL.Text
                    tupla.CD_NIVEL_ACCESO = UICD_NVL_ACCESO.EditValue
                    

                    _datasistema.ContextoGeneral.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                    Try
                        _datasistema.ContextoGeneral.SubmitChanges()
                        Consultar()
                        MetodosForm.SeleccionarFila(UIGRIDVIEW, "ID", tupla.ID)

                    Catch ex As Exception
                        MetodosForm.MensajeErrorDefault("Critical error")

                    End Try
                Else
                    MetodosForm.MensajeErrorDefault("No se modifico nada")

                End If
            Else
                Dim A As New GEN_PERFIL With
           {.ID = 0,
            .DS_NOMBRE_PERFIL = UIDS_NOMBRE_PERFIL.EditValue,
            .CD_NIVEL_ACCESO = UICD_NVL_ACCESO.EditValue
           }


                _datasistema.ContextoGeneral.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                _datasistema.ContextoGeneral.GEN_PERFIL.InsertOnSubmit(A)
                Try
                    _datasistema.ContextoGeneral.SubmitChanges()
                    Consultar()
                    MetodosForm.SeleccionarFila(UIGRIDVIEW, "ID", A.ID)
                Catch ex As System.Data.SqlClient.SqlException
                    MetodosForm.MensajeErrorDefault(ex.Message)
                Catch ex As Exception
                    MetodosForm.MensajeErrorDefault("Critical error")

                End Try
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
        For i As Integer = 0 To UITABCONTROL_DETA.TabPages.Count
            UITABCONTROL_DETA.SelectedTabPageIndex = i
        Next
        UITABCONTROL_DETA.SelectedTabPageIndex = 0
    End Sub

#Region "Detalle"
    Public Sub ConsultarDetalle()
        Try
            Dim coll As Integer()
            coll = (From u In _datasistema.ContextoGeneral.GEN_MENU_PERFIL
                                      Where u.ID_PERFIL = UIID.EditValue.ToString Select u.ID_OPC_MENU).ToArray

            _datasistema.ConectarGeneral()
            varlista_opci = (From u In _datasistema.ContextoGeneral.V_GEN_OPCION_MENU
                    Select u Where Not coll.Contains(u.ID)).ToList
            UIGRID_CONTROL_OPC.DataSource = varlista_opci

            varlista_opciperfil = (From U In _datasistema.ContextoGeneral.V_GEN_MENU_PERFIL_AUX
                                  Where U.ID_PERFIL = UIID.EditValue.ToString).ToList
            UIGRID_CONTROL_DETA.DataSource = varlista_opciperfil
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try
    End Sub
    Private Sub UIGRID_VIEW_OPC_DoubleClick(sender As Object, e As EventArgs) Handles UIGRID_VIEW_OPC.DoubleClick
        Try
            Dim A As New GEN_MENU_PERFIL With
           {.ID = 0,
            .ID_PERFIL = UIID.EditValue,
            .ID_OPC_MENU = UIGRID_VIEW_OPC.GetFocusedRowCellValue("ID").ToString()
           }


            _datasistema.ContextoGeneral.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

            _datasistema.ContextoGeneral.GEN_MENU_PERFIL.InsertOnSubmit(A)
            Try
                _datasistema.ContextoGeneral.SubmitChanges()
                ConsultarDetalle()
                MetodosForm.SeleccionarFila(UIGRIDVIEW, "ID", A.ID)
            Catch ex As System.Data.SqlClient.SqlException
                MetodosForm.MensajeErrorDefault(ex.Message)
            Catch ex As Exception
                MetodosForm.MensajeErrorDefault("Critical error")

            End Try


        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try
    End Sub

    Private Sub UIGRID_CONTROL_DETA_DoubleClick(sender As Object, e As EventArgs) Handles UIGRID_CONTROL_DETA.DoubleClick
        Try
            Dim tupla As GEN_MENU_PERFIL = (From a In _datasistema.ContextoGeneral.GEN_MENU_PERFIL Where a.ID = Val(UIGRID_VIEW_DETA.GetFocusedRowCellValue("ID").ToString())).ToList()(0)
            If Not tupla Is Nothing Then

                _datasistema.ContextoGeneral.GEN_MENU_PERFIL.DeleteOnSubmit(tupla)

                _datasistema.ContextoGeneral.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                Try
                    _datasistema.ContextoGeneral.SubmitChanges()
                    ConsultarDetalle()
                Catch ex As Exception
                    MetodosForm.MensajeErrorDefault("Critical error")

                End Try
            Else
                MetodosForm.MensajeErrorDefault("No se modifico nada")

            End If

        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try
    End Sub
#End Region

    Private Sub UIID_EditValueChanged(sender As Object, e As EventArgs) Handles UIID.EditValueChanged
        ConsultarDetalle()
    End Sub

    
End Class
