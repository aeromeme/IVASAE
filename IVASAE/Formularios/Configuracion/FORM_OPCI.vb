Imports IVASAE.Utilidades
Public Class FORM_OPCI
    Implements InterfazForms

    Dim varlista As Generic.List(Of V_GEN_OPCION_MENU)
    Dim varlista_menu As Generic.List(Of GEN_MENU)
    Dim varlista_form As Generic.List(Of V_GEN_FORMULARIO)


    Public Sub bindear() Implements InterfazForms.bindear
        UIID.DataBindings.Add("EditValue", varlista, "ID", False, DataSourceUpdateMode.Never)
        UIID_FORM.DataBindings.Add("EditValue", varlista, "ID_FORM", False, DataSourceUpdateMode.Never)
        UIID_MENU.DataBindings.Add("EditValue", varlista, "ID_MENU", False, DataSourceUpdateMode.Never)
    End Sub

    Public Sub prepararcombos()
        varlista_menu = (From U In _datasistema.ContextoGeneral.GEN_MENU).ToList
        UIID_MENU.Properties.DataSource = varlista_menu
        varlista_form = (From U In _datasistema.ContextoGeneral.V_GEN_FORMULARIO).ToList
        UIID_FORM.Properties.DataSource = varlista_form
    End Sub
    Public Sub Consultar() Implements InterfazForms.Consultar
        Try
            _datasistema.ConectarGeneral()
            varlista = (From U In _datasistema.ContextoGeneral.V_GEN_OPCION_MENU
                       Select U).ToList
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
        UIID_FORM.DataBindings.Clear()
        UIID_MENU.DataBindings.Clear()
    End Sub

    Public Sub Eliminar() Implements InterfazForms.Eliminar
        Try
            Dim tupla As GEN_OPCION_MENU = (From a In _datasistema.ContextoGeneral.GEN_OPCION_MENU Where a.ID = Val(UIID.Text)).ToList()(0)
            If Not tupla Is Nothing Then

                _datasistema.ContextoGeneral.GEN_OPCION_MENU.DeleteOnSubmit(tupla)

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
        UIID_FORM.EditValue = Nothing
        UIID_MENU.EditValue = Nothing
    End Sub

    Public Sub Modificar() Implements InterfazForms.Modificar
        Try

            If UIID.Text <> "" Then
                If (From U In _datasistema.ContextoGeneral.GEN_OPCION_MENU
             Select U Where U.ID_FORM = UIID_FORM.EditValue.ToString And U.ID_MENU = UIID_MENU.EditValue.ToString).Count > 0 Then
                    MetodosForm.MensajeErrorDefault("Ya existe la opcion de menu")
                    Exit Sub
                End If
                Dim tupla As GEN_OPCION_MENU = (From a In _datasistema.ContextoGeneral.GEN_OPCION_MENU Where a.ID = Val(UIID.Text)).ToList()(0)
                If Not tupla Is Nothing Then

                    tupla.ID_FORM = UIID_FORM.EditValue
                    tupla.ID_MENU = UIID_MENU.EditValue

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
                If (From U In _datasistema.ContextoGeneral.GEN_OPCION_MENU
               Select U Where U.ID_FORM = UIID_FORM.EditValue.ToString And U.ID_MENU = UIID_MENU.EditValue.ToString).Count > 0 Then
                    MetodosForm.MensajeErrorDefault("Ya existe la opcion de menu")
                    Exit Sub
                End If
                Dim A As New GEN_OPCION_MENU With
               {.ID = 0,
                .ID_FORM = UIID_FORM.EditValue,
                .ID_MENU = UIID_MENU.EditValue
               }


                _datasistema.ContextoGeneral.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                _datasistema.ContextoGeneral.GEN_OPCION_MENU.InsertOnSubmit(A)
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
