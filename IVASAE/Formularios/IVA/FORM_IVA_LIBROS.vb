Imports IVASAE.Utilidades
Imports IVASAE.IVA
Imports IVASAE.clasesReporte
Public Class FORM_IVA_LIBROS
    Implements InterfazForms
    Public nmmes As Integer
    Public nmanio As Integer
    Private ivaconf As IVA_CONTROL_PERIODO
    Private flgbloquearInterfaz As Boolean = False
    Private flgreporte As Boolean = False
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
                uibtnpreparar.Enabled = False
            Else
                uibtnpreparar.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Consultar() Implements InterfazForms.Consultar
        Try
            uicd_libro.Properties.DataSource = MetodosForm.listaLibrosIVA
            ActualizarInterfaz()
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault(ex.Message)
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

    Private Sub FORM_IVA_LIBROS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consultar()
    End Sub

    Private Sub uibtnpreparar_Click(sender As Object, e As EventArgs) Handles uibtnpreparar.Click
        Try
            If MetodosForm.Preguntar("¿Esta seguro de procesar los libros de IVA?") Then
                _datasistema.ConectarIVA()
                Dim nmerror As Integer = 0
                Dim msj As String = ""
                Select Case uicd_libro.EditValue.ToString

                    Case "COM"
                        _datasistema.ContextoIVA.PR_IVA_GENE_LIBRO_COMPRA(nmanio, nmmes, nmerror, msj)
                    Case "VEN"
                        _datasistema.ContextoIVA.PR_IVA_GENE_LIBRO_VENTA(nmanio, nmmes, nmerror, msj)
                    Case "VCF"
                        _datasistema.ContextoIVA.PR_IVA_GENE_LIBRO_VENTA_CONSU(nmanio, nmmes, nmerror, msj)
                End Select

                If nmerror <> 0 Then
                    Throw New Exception(msj)
                Else
                    MetodosForm.MensajeInfoDefault("Todo listo, proceda a reportear")
                End If
            End If

        Catch ex As Exception
            MetodosForm.MensajeErrorDefault(ex.Message)
        End Try
    End Sub

    Private Sub uibtngenerar_Click(sender As Object, e As EventArgs) Handles uibtngenerar.Click
        Try
            flgreporte = False
            uigridexport.DataSource = Nothing
            uigridviewexport.Columns.Clear()
            Select Case uicd_libro.EditValue.ToString

                Case "COM"
                    _datasistema.ConectarIVA()
                    Dim data As Generic.List(Of IVA_LIBRO_COMPRA)
                    data = (From u In _datasistema.ContextoIVA.IVA_LIBRO_COMPRA Where u.NM_ANIO = nmanio And u.NM_MES = nmmes Order By u.CD_CORR Ascending).ToList
                    Dim rpt As New RPT_LIBRO_IVA_COMPRA_V2
                    rpt.DataSource = data
                    rpt.FLG_MOSTRAR_ENCABEZADO.Value = If(uiflgenca.Checked, "S", "N")
                    rpt.RequestParameters = False
                    UIVISOR_REPORTES.PrintingSystem = rpt.PrintingSystem
                    rpt.CreateDocument()
                    Principal.RibbonControl1.SelectedPage = Principal.RibbonControl1.MergedPages(0)
                    uigridexport.DataSource = data
                    flgreporte = True
                Case "VEN"
                    _datasistema.ConectarIVA()
                    Dim data As Generic.List(Of IVA_LIBRO_VENTA_CONTRIBUYENTE)
                    data = (From u In _datasistema.ContextoIVA.IVA_LIBRO_VENTA_CONTRIBUYENTE Where u.NM_ANIO = nmanio And u.NM_MES = nmmes Order By u.CD_CORR Ascending, u.FECHA.Value.Day Ascending, u.CVE_DOC Ascending Select u).ToList

                    Dim dataconsu As Generic.List(Of IVA_LIBRO_VENTA_CONSUMIDOR)
                    dataconsu = (From u In _datasistema.ContextoIVA.IVA_LIBRO_VENTA_CONSUMIDOR Where u.NM_ANIO = nmanio And u.NM_MES = nmmes).ToList

                    Dim datasub As New Generic.List(Of cRLIBRO_IVA_VENTA)
                    Dim itemsub As New cRLIBRO_IVA_VENTA

                    For Each item As IVA_LIBRO_VENTA_CONTRIBUYENTE In data
                        itemsub.nm_ventas_internas_gravadas_contrib = item.NM_GRAVADO + itemsub.nm_ventas_internas_gravadas_contrib
                        itemsub.nm_iva_interno_contrib = item.NM_IVA + itemsub.nm_iva_interno_contrib
                        itemsub.nm_ventas_internas_exentas_contrib = item.NM_EXENTO + itemsub.nm_ventas_internas_exentas_contrib
                    Next

                    For Each item As IVA_LIBRO_VENTA_CONSUMIDOR In dataconsu
                        itemsub.nm_exportaciones = item.NM_EXPORTACION + itemsub.nm_exportaciones
                        itemsub.nm_ventas_internas_gravadas_consumidores = item.NM_GRAVADAS + itemsub.nm_ventas_internas_gravadas_consumidores
                        itemsub.nm_iva_interno_consumidores = item.NM_IVA + itemsub.nm_iva_interno_consumidores
                        itemsub.nm_ventas_internas_exentas_consumidores = item.NM_EXENTAS + itemsub.nm_ventas_internas_exentas_consumidores
                    Next
                    datasub.Add(itemsub)


                    Dim rpt As New RPT_LIBRO_IVA_VENTA_V2
                    rpt.DataSource = data
                    rpt.FLG_MOSTRAR_ENCABEZADO.Value = If(uiflgenca.Checked, "S", "N")

                    rpt.XrSubreport1.ReportSource.DataSource = datasub


                    UIVISOR_REPORTES.PrintingSystem = rpt.PrintingSystem
                    rpt.CreateDocument()

                    Principal.RibbonControl1.SelectedPage = Principal.RibbonControl1.MergedPages(0)
                    uigridexport.DataSource = data
                    flgreporte = True
                Case "VCF"
                    _datasistema.ConectarIVA()
                    Dim data As Generic.List(Of IVA_LIBRO_VENTA_CONSUMIDOR)
                    data = (From u In _datasistema.ContextoIVA.IVA_LIBRO_VENTA_CONSUMIDOR Where u.NM_ANIO = nmanio And u.NM_MES = nmmes Order By u.CD_CORR Ascending).ToList
                    Dim rpt As New RPT_LIBRO_IVA_VENTA_CONSUFINAL
                    rpt.DataSource = data
                    rpt.FLG_MOSTRAR_ENCABEZADO.Value = If(uiflgenca.Checked, "S", "N")
                    UIVISOR_REPORTES.PrintingSystem = rpt.PrintingSystem
                    rpt.CreateDocument()
                    Principal.RibbonControl1.SelectedPage = Principal.RibbonControl1.MergedPages(0)
                    uigridexport.DataSource = data
                    flgreporte = True
                Case "DCF"
                    _datasistema.ConectarIVA()
                    Dim data As Generic.List(Of V_IVA_DETALLE_VENTA)
                    data = (From u In _datasistema.ContextoIVA.V_IVA_DETALLE_VENTA Where u.NM_ANIO = nmanio And u.NM_MES = nmmes And (u.CD_TIPO = "FAC" Or u.CD_TIPO = "NCF")
                           Order By u.DIA Ascending, u.CVE_DOC Ascending Select u).ToList
                    Dim rpt As New RPT_DETALLE_VENTA
                    rpt.DataSource = data
                    rpt.DS_TITULO.Value = "VENTAS A CONSUMIDOR FINAL"
                    UIVISOR_REPORTES.PrintingSystem = rpt.PrintingSystem
                    rpt.CreateDocument()
                    Principal.RibbonControl1.SelectedPage = Principal.RibbonControl1.MergedPages(0)
                    uigridexport.DataSource = data
                    flgreporte = True
                Case "DFE"
                    _datasistema.ConectarIVA()
                    Dim data As Generic.List(Of V_IVA_DETALLE_VENTA)
                    data = (From u In _datasistema.ContextoIVA.V_IVA_DETALLE_VENTA Where u.NM_ANIO = nmanio And u.NM_MES = nmmes And (u.CD_TIPO = "FEX" Or u.CD_TIPO = "NCE")
                           Order By u.DIA Ascending, u.CVE_DOC Ascending Select u).ToList
                    Dim rpt As New RPT_DETALLE_VENTA
                    rpt.DataSource = data
                    rpt.DS_TITULO.Value = "EXPORTACIONES"
                    UIVISOR_REPORTES.PrintingSystem = rpt.PrintingSystem
                    rpt.CreateDocument()
                    Principal.RibbonControl1.SelectedPage = Principal.RibbonControl1.MergedPages(0)
                    uigridexport.DataSource = data
                    flgreporte = True
                Case "FEL"
                    _datasistema.ConectarIVA()
                    Dim data As Generic.List(Of V_IVA_DETALLE_VENTA)
                    data = (From u In _datasistema.ContextoIVA.V_IVA_DETALLE_VENTA Where u.NM_ANIO = nmanio And u.NM_MES = nmmes And (u.CD_TIPO = "FEX" Or u.CD_TIPO = "NCE")
                           Order By u.DIA Ascending, u.CVE_DOC Ascending Select u).ToList
                    Dim rpt As New RPT_LIBRO_IVA_EXPO
                    rpt.DataSource = data
                    ''rpt.DS_TITULO.Value = "EXPORTACIONES"
                    UIVISOR_REPORTES.PrintingSystem = rpt.PrintingSystem
                    rpt.CreateDocument()
                    Principal.RibbonControl1.SelectedPage = Principal.RibbonControl1.MergedPages(0)
                    uigridexport.DataSource = data
                    flgreporte = True

            End Select
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault(ex.Message)
        End Try
    End Sub

    Private Sub uibtncerrarPeriodo_Click(sender As Object, e As EventArgs) Handles uibtncerrarPeriodo.Click
        Try
            Try
                ivaconf = (From u In _datasistema.ContextoIVA.IVA_CONTROL_PERIODO Where u.ANIO = nmanio And u.MES = nmmes).First

            Catch ex As Exception

            End Try

            If Not ivaconf Is Nothing Then

                If ivaconf.CD_ESTADO = "D" Then
                    If (MetodosForm.Preguntar("¿Esta seguro de cerrar el periodo?")) Then
                        ivaconf.CD_ESTADO = "A"
                        _datasistema.ContextoIVA.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                        Try
                            _datasistema.ContextoIVA.SubmitChanges()

                            Consultar()

                        Catch ex As Exception
                            MetodosForm.MensajeErrorDefault("Critical error")

                        End Try

                    End If
                Else
                    MetodosForm.MensajeInfoDefault("Periodo ya cerrado")
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If flgreporte Then
                If UIDIALOGO_GUARDAREXCEL.ShowDialog = DialogResult.OK Then
                    uigridexport.ExportToXlsx(UIDIALOGO_GUARDAREXCEL.FileName)
                End If
            End If
           
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try
    End Sub
End Class
