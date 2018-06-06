Imports IVASAE.Utilidades

Public Class FORM_MODULO
    Implements InterfazForms
    Dim varlista As Generic.List(Of GEN_MODULO)

    Public Sub bindear() Implements InterfazForms.bindear
        UIDS_NOMBRE_MODULO.DataBindings.Add("EditValue", varlista, "DS_NOMBRE_MODULO", False, DataSourceUpdateMode.Never)
        UIID.DataBindings.Add("EditValue", varlista, "ID", False, DataSourceUpdateMode.Never)
        uicd_imagen.DataBindings.Add("EditValue", varlista, "CD_IMAGEN", False, DataSourceUpdateMode.Never)
    End Sub
    Public Sub popularcombos()
        uicd_imagen.Properties.DataSource = MetodosForm.listadoImagen
    End Sub

    Public Sub Consultar() Implements InterfazForms.Consultar
        Try
            _datasistema.ConectarGeneral()
            varlista = (From u In _datasistema.ContextoGeneral.GEN_MODULO
                        Select u).ToList
            UIGRIDCONTROL.DataSource = varlista
            desbindear()
            bindear()
            If varlista.Count = 0 Then
                Limpiar()
            End If
            popularcombos()
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try
    End Sub

    Public Sub desbindear() Implements InterfazForms.desbindear
        UIDS_NOMBRE_MODULO.DataBindings.Clear()
        UIID.DataBindings.Clear()
        uicd_imagen.DataBindings.Clear()
    End Sub

    Public Sub Eliminar() Implements InterfazForms.Eliminar
        Try
            Dim tupla As GEN_MODULO = (From a In _datasistema.ContextoGeneral.GEN_MODULO Where a.ID = Val(UIID.Text)).ToList()(0)
            If Not tupla Is Nothing Then

                _datasistema.ContextoGeneral.GEN_MODULO.DeleteOnSubmit(tupla)

                _datasistema.ContextoGeneral.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                Try
                    _datasistema.ContextoGeneral.SubmitChanges()
                    Consultar()
                Catch ex As Exception
                    MetodosForm.MensajeErrorDefault("Critical Error")

                End Try
            Else
                MetodosForm.MensajeErrorDefault("No se modifico Nada")
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
        UIDS_NOMBRE_MODULO.EditValue = ""
        UIID.EditValue = ""
        uicd_imagen.EditValue = Nothing

    End Sub

    Public Sub Modificar() Implements InterfazForms.Modificar
        Try
            If UIID.Text <> "" Then
                Dim tupla As GEN_MODULO = (From a In _datasistema.ContextoGeneral.GEN_MODULO Where a.ID = Val(UIID.Text)).ToList()(0)
                If Not tupla Is Nothing Then

                    tupla.DS_NOMBRE_MODULO = UIDS_NOMBRE_MODULO.EditValue
                    tupla.CD_IMAGEN = uicd_imagen.EditValue

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
                Dim A As New GEN_MODULO With
                {.ID = 0,
                  .DS_NOMBRE_MODULO = UIDS_NOMBRE_MODULO.EditValue,
                 .CD_IMAGEN = uicd_imagen.EditValue
                }
                _datasistema.ContextoGeneral.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                _datasistema.ContextoGeneral.GEN_MODULO.InsertOnSubmit(A)
                Try
                    _datasistema.ContextoGeneral.SubmitChanges()
                    Consultar()
                    MetodosForm.SeleccionarFila(UIGRIDVIEW, "ID", A.ID)

                Catch ex As System.Data.SqlClient.SqlException

                    MetodosForm.MensajeErrorDefault(ex.Message)

                Catch ex As Exception
                    MetodosForm.MensajeErrorDefault("Critical Error")
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
