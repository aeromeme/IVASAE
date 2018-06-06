Imports IVASAE.Utilidades
Public Class FORM_MENU
    Implements InterfazForms

    Dim varlista As Generic.List(Of GEN_MENU)
    Public Sub bindear() Implements InterfazForms.bindear
        UIID.DataBindings.Add("EditValue", varlista, "ID", False, DataSourceUpdateMode.Never)
        UICOD_MENU.DataBindings.Add("EditValue", varlista, "COD_MENU", False, DataSourceUpdateMode.Never)
    End Sub

    Public Sub Consultar() Implements InterfazForms.Consultar
        Try
            _datasistema.ConectarGeneral()
            varlista = (From u In _datasistema.ContextoGeneral.GEN_MENU
                    Select u).ToList
            UIGRIDCONTROL.DataSource = varlista
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
        UICOD_MENU.DataBindings.Clear()
    End Sub

    Public Sub Eliminar() Implements InterfazForms.Eliminar
        Try
            Dim tupla As GEN_MENU = (From a In _datasistema.ContextoGeneral.GEN_MENU Where a.ID = Val(UIID.Text)).ToList()(0)
            If Not tupla Is Nothing Then

                _datasistema.ContextoGeneral.GEN_MENU.DeleteOnSubmit(tupla)

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
        desbindear()
        UICOD_MENU.EditValue = ""
        UIID.EditValue = ""
    End Sub

    Public Sub Modificar() Implements InterfazForms.Modificar
        Try
            If UIID.Text <> "" Then
                Dim tupla As GEN_MENU = (From a In _datasistema.ContextoGeneral.GEN_MENU Where a.ID = Val(UIID.Text)).ToList()(0)
                If Not tupla Is Nothing Then

                    tupla.COD_MENU = UICOD_MENU.Text

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
                Dim A As New GEN_MENU With
          {.ID = 0,
           .COD_MENU = UICOD_MENU.EditValue
          }

                _datasistema.ContextoGeneral.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                _datasistema.ContextoGeneral.GEN_MENU.InsertOnSubmit(A)
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
