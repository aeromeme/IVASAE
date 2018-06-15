Imports IVASAE.Utilidades
Imports IVASAE.IVA

Public Class FORM_IVA_DOC_VENTA_SAE
    Implements InterfazForms
    Public nmmes As Integer
    Public nmanio As Integer
    Private varlista As Generic.List(Of V_IVA_DOC_VENTA_SAE)
    Private ivaconf As IVA_CONTROL_PERIODO
    Private flgbloquearInterfaz As Boolean = False
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(ds As DataSistema)
        MyBase.New(ds)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub bindear() Implements InterfazForms.bindear

    End Sub

    Public Sub llenarcombos()
        UIGR_CVECLIE.DataSource = (From u In _datasistema.ContextoIVA.IVA_CLIE_PROV Select u Where u.FLG_CLIENTE = "S" And u.FLG_PROVEEDOR = "N" And u.CLAVE <> "").ToList
        UIGR_TIPODOC.DataSource = (From u In _datasistema.ContextoIVA.IVA_TIPO_DOCUMENTO Select u Where u.FLG_COMPRA = "N" And u.FLG_VENTA = "S").ToList

    End Sub
    Public Sub ActualizarInterfaz()
        Try
            Try
                ivaconf = (From u In _datasistema.ContextoIVA.IVA_CONTROL_PERIODO Where u.ANIO = nmanio And u.MES = nmmes).First

            Catch ex As Exception

            End Try

            If Not ivaconf Is Nothing Then
                flgbloquearInterfaz = If(ivaconf.CD_ESTADO = "D", False, True)
            End If

            If flgbloquearInterfaz Then
                UIGRIDVIEW.OptionsBehavior.Editable = False
                UIGRIDVIEW.OptionsBehavior.ReadOnly = True
                UIBR_IMPORTAR.Enabled = False
                uibtn_unlock.Enabled = False
            Else
                UIGRIDVIEW.OptionsBehavior.Editable = True
                UIGRIDVIEW.OptionsBehavior.ReadOnly = False
                UIBR_IMPORTAR.Enabled = True
                uibtn_unlock.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Consultar() Implements InterfazForms.Consultar
        Try
            _datasistema.ConectarIVA()
            varlista = (From u In _datasistema.ContextoIVA.V_IVA_DOC_VENTA_SAE
                    Select u Where u.NM_ANIO = nmanio And u.NM_MES = nmmes).ToList
            UIGRIDCONTROL.DataSource = varlista
            llenarcombos()
            desbindear()
            bindear()

            If varlista.Count = 0 Then
                Limpiar()
            End If
            ActualizarInterfaz()
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

    End Sub
#Region "METODOS ESPECIALES"
    Private Sub FORM_INGR_PROD_RPT_RESU_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Principal.actualizarInterfaz(1)

    End Sub

    Private Sub FORM_INGR_PROD_RPT_RESU_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Principal.actualizarInterfaz(3)
        Principal.actualizarInterfaz(6)
    End Sub
#End Region
    Private Sub UIBR_IMPORTAR_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UIBR_IMPORTAR.ItemClick
        Try
            If (MetodosForm.Preguntar("¿Esta seguro de importar los documentos de venta?")) Then
                Principal.MostrarEspere(True)
                Dim msj As String = ""
                Dim nmerror As Integer = 0
                _datasistema.ContextoIVA.PR_IVA_IMPO_VENT(nmanio, nmmes, msj, nmerror)
                If (nmerror <> 0) Then
                    Throw New Exception(msj)
                Else
                    Consultar()
                End If
            End If
            Principal.MostrarEspere(False)
        Catch ex As Exception
            Principal.MostrarEspere(False)
            MetodosForm.MensajeErrorDefault(ex.Message)
        End Try
    End Sub

    Private Sub uibtn_unlock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles uibtn_unlock.ItemClick
        Try
            Dim row As V_IVA_DOC_VENTA_SAE = UIGRIDVIEW.GetFocusedRow

            Dim id As Integer = row.ID
            Dim doc As IVA_DOC_VENTA_SAE = (From u In _datasistema.ContextoIVA.IVA_DOC_VENTA_SAE
                                                   Select u Where u.ID = id).ToList(0)

            doc.FLG_BLOQUEADO = "N"

            _datasistema.ContextoIVA.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

            Try

                _datasistema.ContextoIVA.SubmitChanges()
                Consultar()

            Catch ex As Exception
                MetodosForm.MensajeErrorDefault("Critical error:" + ex.Message)

            End Try
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FORM_IVA_DOC_VENTA_SAE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consultar()
    End Sub

    Private Sub UIGRIDVIEW_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles UIGRIDVIEW.RowUpdated
        Try
            Dim row As V_IVA_DOC_VENTA_SAE = e.Row

            Dim id As Integer = row.ID
            Dim doc As IVA_DOC_VENTA_SAE = (From u In _datasistema.ContextoIVA.IVA_DOC_VENTA_SAE
                                                   Select u Where u.ID = id).ToList(0)

            doc.CVE_DOC = row.CVE_DOC
            doc.ID_TIPO_DOC = row.ID_TIPO_DOC
            doc.NM_EXENTO = row.NM_EXENTO
            doc.NM_GRAVADO = row.NM_GRAVADO
            doc.NM_IVA = row.NM_IVA
            doc.NM_IVA_RETENIDO = row.NM_IVA_RETENIDO
            doc.NM_RENTA = row.NM_RENTA
            doc.NM_IVA_PERCIVIDO = row.NM_IVA_PERCIVIDO
            doc.FE_FECHA = row.FE_FECHA
            doc.FE_ELABORACION = row.FE_ELABORACION
            doc.FLG_NO_INCLUIR = row.FLG_NO_INCLUIR


            doc.NM_TOTAL = row.NM_EXENTO + row.NM_GRAVADO + row.NM_IVA + row.NM_IVA_RETENIDO - row.NM_RENTA

            doc.FLG_BLOQUEADO = "S"

            _datasistema.ContextoIVA.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

            Try

                _datasistema.ContextoIVA.SubmitChanges()
                Consultar()

            Catch ex As Exception
                MetodosForm.MensajeErrorDefault("Critical error: " + ex.Message)

            End Try
        Catch ex As Exception

        End Try
    End Sub
End Class