Imports IVASAE.Utilidades
Imports IVASAE.IVA
Public Class FORM_IVA_CONF
    Implements InterfazForms
    Dim varlista_clasesprod As Generic.List(Of IVA_CLASE_PRODUCTO)
    Public Sub New(ds As DataSistema)
        MyBase.New(ds)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub bindear() Implements InterfazForms.bindear

    End Sub
    Public Sub PrepararCombos()
        varlista_clasesprod = (From U In _datasistema.ContextoIVA.IVA_CLASE_PRODUCTO Select U).ToList
        'UIID_DEF_CLASE_PRODUCTO.Properties.DataSource = varlista_clasesprod

    End Sub
    Public Sub Consultar() Implements InterfazForms.Consultar
        Try
            _datasistema.ConectarIVA()
            PrepararCombos()
            If (From U In _datasistema.ContextoIVA.IVA_CONF Select U).Count = 1 Then
                Dim tupla As IVA_CONF = (From a In _datasistema.ContextoIVA.IVA_CONF Select a).ToList()(0)
                If Not tupla Is Nothing Then
                    'UIID_DEF_CLASE_PRODUCTO.EditValue = tupla.ID_DEF_CLASE_PRODUCTO
                    'UIDS_NOMBRE_POLIZA.EditValue = tupla.DS_NOMBRE_POLIZA
                    UINM_PORC_IVA.EditValue = tupla.NM_PORC_IVA
                    

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
            If (From U In _datasistema.ContextoIVA.IVA_CONF).Count = 1 Then
                Dim tupla As IVA_CONF = (From a In _datasistema.ContextoIVA.IVA_CONF).ToList()(0)
                If Not tupla Is Nothing Then

                    tupla.NM_PORC_IVA = UINM_PORC_IVA.EditValue
                    'tupla.DS_NOMBRE_POLIZA = UIDS_NOMBRE_POLIZA.EditValue
                    'tupla.ID_DEF_CLASE_PRODUCTO = UIID_DEF_CLASE_PRODUCTO.EditValue

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

    Private Sub FORM_IVA_CONF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consultar()
    End Sub

#Region "METODOS ESPECIALES"
    Private Sub FORM_INGR_PROD_RPT_RESU_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Principal.actualizarInterfaz(1)

    End Sub

    Private Sub FORM_INGR_PROD_RPT_RESU_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Principal.actualizarInterfaz(5)
    End Sub
#End Region
End Class
