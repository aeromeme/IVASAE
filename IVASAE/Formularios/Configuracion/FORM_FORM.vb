Imports IVASAE.Utilidades
Public Class FORM_FORM
    Implements InterfazForms
    Dim varlista As Generic.List(Of V_GEN_FORMULARIO)
    Dim varlista_mod As Generic.IList(Of GEN_MODULO)


    Public Sub bindear() Implements InterfazForms.bindear
        UICOD_FORM.DataBindings.Add("EditValue", varlista, "COD_FORM", False, DataSourceUpdateMode.Never)
        UIDS_NOMBRE_FORM.DataBindings.Add("EditValue", varlista, "DS_NOMBRE_FORM", False, DataSourceUpdateMode.Never)
        UIDS_NOMBRE_CORTO.DataBindings.Add("EditValue", varlista, "DS_NOMBRE_CORTO", False, DataSourceUpdateMode.Never)
        UIID.DataBindings.Add("EditValue", varlista, "ID", False, DataSourceUpdateMode.Never)
        UIID_MODULO.DataBindings.Add("EditValue", varlista, "ID_MODULO", False, DataSourceUpdateMode.Never)
    End Sub
    Public Sub prepararcombo()
        varlista_mod = (From U In _datasistema.ContextoGeneral.GEN_MODULO).ToList
        UIID_MODULO.Properties.DataSource = varlista_mod

    End Sub
    Public Sub Consultar() Implements InterfazForms.Consultar
        Try
            _datasistema.ConectarGeneral()
            varlista = (From u In _datasistema.ContextoGeneral.V_GEN_FORMULARIO
                    Select u).ToList
            UIGRIDCONTROL.DataSource = varlista

            prepararcombo()
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
        UICOD_FORM.DataBindings.Clear()
        UIDS_NOMBRE_FORM.DataBindings.Clear()
        UIDS_NOMBRE_CORTO.DataBindings.Clear()
        UIID.DataBindings.Clear()
        UIID_MODULO.DataBindings.Clear()
    End Sub

    Public Sub Eliminar() Implements InterfazForms.Eliminar
        Try
            Dim tupla As GEN_FORMULARIO = (From a In _datasistema.ContextoGeneral.GEN_FORMULARIO Where a.ID = Val(UIID.Text)).ToList()(0)
            If Not tupla Is Nothing Then

                _datasistema.ContextoGeneral.GEN_FORMULARIO.DeleteOnSubmit(tupla)

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
        UICOD_FORM.EditValue = ""
        UIDS_NOMBRE_FORM.EditValue = ""
        UIDS_NOMBRE_CORTO.EditValue = ""
        UIID_MODULO.EditValue = Nothing

    End Sub

    Public Sub Modificar() Implements InterfazForms.Modificar
        Try
            If UIID.Text <> "" Then
                Dim tupla As GEN_FORMULARIO = (From a In _datasistema.ContextoGeneral.GEN_FORMULARIO Where a.ID = Val(UIID.Text)).ToList()(0)
                If Not tupla Is Nothing Then

                    tupla.COD_FORM = UICOD_FORM.EditValue
                    tupla.DS_NOMBRE_FORM = UIDS_NOMBRE_FORM.EditValue
                    tupla.DS_NOMBRE_CORTO = UIDS_NOMBRE_CORTO.EditValue
                    tupla.ID_MODULO = UIID_MODULO.EditValue

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
                Dim A As New GEN_FORMULARIO With
          {.ID = 0,
           .COD_FORM = UICOD_FORM.EditValue,
           .DS_NOMBRE_CORTO = UIDS_NOMBRE_CORTO.EditValue,
           .DS_NOMBRE_FORM = UIDS_NOMBRE_FORM.EditValue,
           .ID_MODULO = UIID_MODULO.EditValue
          }
                _datasistema.ContextoGeneral.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                _datasistema.ContextoGeneral.GEN_FORMULARIO.InsertOnSubmit(A)
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
    End Sub
End Class
