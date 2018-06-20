Imports IVASAE.Utilidades
Imports IVASAE.IVA
Public Class FORM_IVA_CONF_COMP
    Implements InterfazForms
    Public Sub New(ds As DataSistema)
        MyBase.New(ds)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub bindear() Implements InterfazForms.bindear

    End Sub

    Public Sub Consultar() Implements InterfazForms.Consultar
        Try
            _datasistema.ConectarIVA()
            UIID_TIPO_DOC.Properties.DataSource = (From u In _datasistema.ContextoIVA.IVA_TIPO_DOCUMENTO Select u Where u.FLG_COMPRA = "S" And u.CD_TIPO = "CRT").ToList

            If (From U In _datasistema.ContextoIVA.IVA_CONF_COMP_RETE Select U).Count = 1 Then
                Dim tupla As IVA_CONF_COMP_RETE = (From a In _datasistema.ContextoIVA.IVA_CONF_COMP_RETE Select a).ToList()(0)
                If Not tupla Is Nothing Then
                    UINM_DOCS_X_COMP.EditValue = tupla.NM_DOCS_X_COMP
                    UICD_SERIE.EditValue = tupla.CD_SERIE
                    UICD_NUMERO.EditValue = tupla.CD_NUMERO
                    UIID_TIPO_DOC.EditValue = tupla.ID_TIPO_DOC_RETE
                Else
                    MetodosForm.MensajeErrorDefault("No se encontro la configuracion")

                End If
            Else
                MetodosForm.MensajeErrorDefault("Solicite ayuda a informatica la configuracion es invalida")
            End If
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try
    End Sub

    Public Sub desbindear() Implements InterfazForms.desbindear

    End Sub

    Public Sub Eliminar() Implements InterfazForms.Eliminar

    End Sub

    Public Sub Imprimir() Implements InterfazForms.Imprimir

    End Sub

    Public Sub Insertar() Implements InterfazForms.Insertar

    End Sub

    Public Sub Limpiar() Implements InterfazForms.Limpiar

    End Sub

    Public Sub Modificar() Implements InterfazForms.Modificar
        Try
            If (From U In _datasistema.ContextoIVA.IVA_CONF_COMP_RETE).Count = 1 Then
                Dim tupla As IVA_CONF_COMP_RETE = (From a In _datasistema.ContextoIVA.IVA_CONF_COMP_RETE).ToList()(0)
                If Not tupla Is Nothing Then

                    tupla.NM_DOCS_X_COMP = UINM_DOCS_X_COMP.EditValue
                    tupla.CD_NUMERO = UICD_NUMERO.EditValue
                    tupla.CD_SERIE = UICD_SERIE.EditValue
                    tupla.ID_TIPO_DOC_RETE = UIID_TIPO_DOC.EditValue

                    _datasistema.ContextoIVA.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                    Try
                        _datasistema.ContextoIVA.SubmitChanges()
                        Consultar()

                    Catch ex As Exception
                        MetodosForm.MensajeErrorDefault("Critical error")

                    End Try

                Else
                    MetodosForm.MensajeErrorDefault("No se modifico nada")

                End If
            Else
                MetodosForm.MensajeErrorDefault("Solicite ayuda a informatica la configuracion es invalida")
            End If
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try
    End Sub

#Region "METODOS ESPECIALES"
    Private Sub FORM_INGR_PROD_RPT_RESU_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Principal.actualizarInterfaz(1)

    End Sub

    Private Sub FORM_INGR_PROD_RPT_RESU_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Principal.actualizarInterfaz(5)
    End Sub
#End Region

    Private Sub FORM_IVA_CONF_COMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consultar()
    End Sub
End Class
