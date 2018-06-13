Imports IVASAE.Utilidades
Imports IVASAE.clasesReporte
Imports IVASAE.IVA

Public Class FORM_IVA_COMP_RETE

    Implements InterfazForms
    Public nmmes As Integer
    Public nmanio As Integer
    Private ivaconf As IVA_CONTROL_PERIODO
    Private ivaconf_comp As IVA_CONF_COMP_RETE
    Dim varlistaProv As Generic.List(Of IVA_CLIE_PROV)
    Dim varlista As Generic.List(Of V_IVA_ENCA_COMP_RETE)
    Dim varlista_deta As Generic.List(Of V_IVA_DETA_COMP_RETE)
    Private flgbloquearInterfaz As Boolean = False
    Public Sub New(ds As DataSistema)
        MyBase.New(ds)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub


    Public Sub bindear() Implements InterfazForms.bindear


        UI_CVE_PROVEEDOR.DataBindings.Add("EditValue", varlista, "CVE_PROVEEDOR", False, DataSourceUpdateMode.Never)
        UI_SERIE.DataBindings.Add("EditValue", varlista, "CD_SERIE", False, DataSourceUpdateMode.Never)
        UI_NoCompr.DataBindings.Add("EditValue", varlista, "CD_NUMERO", False, DataSourceUpdateMode.Never)
        UIFE_COMPROB.DataBindings.Add("EditValue", varlista, "FE_FECHA", False, DataSourceUpdateMode.Never)
        UICD_ESTADO.DataBindings.Add("EditValue", varlista, "CD_ESTADO", False, DataSourceUpdateMode.Never)
        UIFLG_SUJ_EXCL.DataBindings.Add("EditValue", varlista, "FLG_SUJ_EXCL", False, DataSourceUpdateMode.Never)
        UIID.DataBindings.Add("Text", varlista, "ID", False, DataSourceUpdateMode.Never)


    End Sub

    Public Sub prepararCombos()
        varlistaProv = (From u In _datasistema.ContextoIVA.IVA_CLIE_PROV
                            Select u Where u.FLG_PROVEEDOR = "S" And u.CLAVE <> "").ToList
        UI_CVE_PROVEEDOR.Properties.DataSource = varlistaProv
        UICD_ESTADO.Properties.DataSource = MetodosForm.listaEstadosDocRete

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
                Principal.actualizarInterfaz(3)
                Btn_Find.Enabled = False
                uibtn_agregarItemNOSAE.Enabled = False
            Else
                Principal.actualizarInterfaz(1)
                Principal.actualizarInterfaz(6)
                Btn_Find.Enabled = True
                uibtn_agregarItemNOSAE.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Consultar() Implements InterfazForms.Consultar

        Try
            _datasistema.ConectarIVA()
            'varlistaProv = (From u In _datasistema.ContextoSAE.V_PROV
            '        Select u).ToList

            varlista = (From u In _datasistema.ContextoIVA.V_IVA_ENCA_COMP_RETE
                    Select u Where u.NM_EJERCICIO = nmanio And u.NM_PERIODO = nmmes).ToList

            UIGRIDCONTROL.DataSource = varlista
            prepararCombos()
            desbindear()
            bindear()
            If varlista.Count = 0 Then
                Limpiar()
                If nmmes > 0 Then
                    UIFE_COMPROB.DateTime = New Date(nmanio, nmmes, Date.DaysInMonth(nmanio, nmmes))
                End If
            End If
            ActualizarInterfaz()
            ConsultarDetalle()
            If (UICD_ESTADO.EditValue <> "D") Then
                Btn_Find.Enabled = False
                uibtn_agregarItemNOSAE.Enabled = False
            Else
                Btn_Find.Enabled = True
                uibtn_agregarItemNOSAE.Enabled = True
            End If
            Try
                ivaconf_comp = (From u In _datasistema.ContextoIVA.IVA_CONF_COMP_RETE Select u).First
            Catch ex As Exception

            End Try
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try

    End Sub

    Public Sub desbindear() Implements InterfazForms.desbindear
        UI_CVE_PROVEEDOR.DataBindings.Clear()

        UI_SERIE.DataBindings.Clear()
        UI_NoCompr.DataBindings.Clear()
        UIFE_COMPROB.DataBindings.Clear()
        UICD_ESTADO.DataBindings.Clear()
        UIFLG_SUJ_EXCL.DataBindings.Clear()
        UIID.DataBindings.Clear()
    End Sub

    Public Sub Eliminar() Implements InterfazForms.Eliminar
        Try

            If (From u In _datasistema.ContextoIVA.V_IVA_DETA_COMP_RETE
                Select u Where u.ID_ENCA = UIID.Text).Count > 0 Then
                MetodosForm.MensajeErrorDefault("Para eliminar este item, elimine los documentos registrados")
                Exit Sub
            End If
            Dim tupla As IVA_ENCA_COMP_RETE = (From a In _datasistema.ContextoIVA.IVA_ENCA_COMP_RETE Where a.ID = Val(UIID.Text)).ToList()(0)

            If Not tupla Is Nothing Then
                If tupla.CD_ESTADO = "D" Then
                    _datasistema.ContextoIVA.IVA_ENCA_COMP_RETE.DeleteOnSubmit(tupla)

                    _datasistema.ContextoIVA.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                    Try
                        _datasistema.ContextoIVA.SubmitChanges()
                        Consultar()
                    Catch ex As Exception
                        MetodosForm.MensajeErrorDefault("Critical error")

                    End Try
                End If
                
            Else
                MetodosForm.MensajeErrorDefault("No se modifico nada")

            End If

        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try
    End Sub

    Public Sub Imprimir() Implements InterfazForms.Imprimir
        Try
            Dim numreg As Integer = (From u In _datasistema.ContextoIVA.IVA_ENCA_COMP_RETE Where u.ID = Val(UIID.Text) Select u).Count()

            If numreg < 1 Then
                MetodosForm.MensajeErrorDefault("Comprobante sin registros que mostrar")
                Exit Sub
            End If
            Dim tupla As IVA_ENCA_COMP_RETE = (From a In _datasistema.ContextoIVA.IVA_ENCA_COMP_RETE Where a.ID = Val(UIID.Text)).ToList()(0)

            If tupla.CD_ESTADO = "D" Then
                Dim cdserie As String = ""
                Dim cdnumero As Integer = 0
                _datasistema.ContextoIVA.PR_IVA_GENE_NM_COMP(cdserie, cdnumero)
                If (cdnumero = 0) Then
                    MetodosForm.MensajeErrorDefault("No se pudo obtener el correlativo de impresion")
                    Exit Sub
                Else
                    tupla.CD_NUMERO = cdnumero
                    tupla.CD_SERIE = cdserie
                    tupla.CD_ESTADO = "I"
                    _datasistema.ContextoIVA.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)
                    _datasistema.ContextoIVA.SubmitChanges()
                End If
            ElseIf tupla.CD_ESTADO = "I" Then
                MetodosForm.MensajeInfoDefault("Reimprimira el documento")
            Else
                Exit Sub
            End If
            Dim deta As Generic.List(Of V_IVA_DETA_COMP_RETE) = (From u In _datasistema.ContextoIVA.V_IVA_DETA_COMP_RETE Select u Where u.ID_ENCA = tupla.ID).ToList
            Dim enca As V_IVA_ENCA_COMP_RETE = (From a In _datasistema.ContextoIVA.V_IVA_ENCA_COMP_RETE Where a.ID = tupla.ID).ToList()(0)
            Dim total As Decimal = (From u In _datasistema.ContextoIVA.V_IVA_DETA_COMP_RETE Where u.ID_ENCA = tupla.ID Select u.NM_MONTO_RETENIDO).Sum
            Dim datos As New Generic.List(Of cRIVA_COMP_RETE)
            datos.Add(New cRIVA_COMP_RETE(enca, deta))
            Dim reporte As New RPT_IVA_COMP_RETE
            reporte.DataSource = datos
            reporte.DS_MONTO_RETE.Value = _datasistema.ContextoIVA.CantidadConLetra(total)
            Principal.MostrarEspere(False)
            'reporte.ShowPreviewDialog()
            Consultar()
            MetodosForm.SeleccionarFila(UIGRIDVIEW, "ID", tupla.ID)

        Catch ex As Exception
            MetodosForm.MensajeErrorDefault(ex.Message)
        End Try
    End Sub

    Public Sub Insertar() Implements InterfazForms.Insertar

    End Sub

    Public Sub Limpiar() Implements InterfazForms.Limpiar

        desbindear()

        UICD_ESTADO.EditValue = "D"
        UI_CVE_PROVEEDOR.EditValue = Nothing
        UI_SERIE.Text = ""
        UI_NoCompr.Text = ""
        UIFLG_SUJ_EXCL.Checked = False
        UIID.Text = ""
        'UIFE_COMPROB.DateTime = New Date(nmanio, nmmes, Date.DaysInMonth(nmanio, nmmes))

    End Sub

    Public Sub Modificar() Implements InterfazForms.Modificar
        Try
            If UIID.Text <> "" Then

                Dim tupla As IVA_ENCA_COMP_RETE = (From a In _datasistema.ContextoIVA.IVA_ENCA_COMP_RETE Where a.ID = Val(UIID.Text)).ToList()(0)
                If Not tupla Is Nothing Then

                    If tupla.CD_ESTADO = "D" Then
                        ' tupla.CVE_PROVEEDOR = UI_CVE_PROVEEDOR.EditValue
                        tupla.FE_FECHA = UIFE_COMPROB.DateTime
                        tupla.FLG_SUJ_EXCL = UIFLG_SUJ_EXCL.EditValue
                        _datasistema.ContextoIVA.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                        Try
                            _datasistema.ContextoIVA.SubmitChanges()
                            Consultar()
                            MetodosForm.SeleccionarFila(UIGRIDVIEW, "ID", tupla.ID)

                        Catch ex As Exception
                            MetodosForm.MensajeErrorDefault("Critical error")

                        End Try
                    Else
                        MetodosForm.MensajeErrorDefault("No se modifico nada")
                    End If

                   
                Else
                    MetodosForm.MensajeErrorDefault("No se modifico nada")
                End If

            Else

               
                If IsNothing(UI_CVE_PROVEEDOR.EditValue) Then
                    MetodosForm.MensajeErrorDefault("Debe seleccionar un registro")
                    Exit Sub
                End If

                Dim A As New IVA_ENCA_COMP_RETE With
                   {.ID = 0,
                   .CVE_PROVEEDOR = UI_CVE_PROVEEDOR.EditValue,
                    .FE_FECHA = UIFE_COMPROB.DateTime,
                    .CD_ESTADO = "D",
                    .CD_NUMERO = 0,
                    .CD_SERIE = "IMPR",
                    .NM_MONTO_RETENIDO = 0,
                    .NM_PERIODO = nmmes,
                    .NM_EJERCICIO = nmanio,
                    .FLG_SUJ_EXCL = UIFLG_SUJ_EXCL.EditValue
                     }

                '.FE_FECHA = UIFE_COMPROB.DateTime,

                _datasistema.ContextoIVA.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)
                _datasistema.ContextoIVA.IVA_ENCA_COMP_RETE.InsertOnSubmit(A)
                _datasistema.ContextoIVA.SubmitChanges()
                Consultar()
                MetodosForm.SeleccionarFila(UIGRIDVIEW, "ID", A.ID)

            End If
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try

    End Sub
    Public Overrides Sub Refrescar()
        Consultar()
    End Sub
#Region "METODOS ESPECIALES"
    Private Sub FORM_INGR_PROD_RPT_RESU_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Principal.actualizarInterfaz(1)

    End Sub

    Private Sub FORM_INGR_PROD_RPT_RESU_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Principal.actualizarInterfaz(1)
        Principal.actualizarInterfaz(6)
    End Sub
#End Region



    Public Sub ConsultarDetalle()

        Try
            varlista_deta = (From u In _datasistema.ContextoIVA.V_IVA_DETA_COMP_RETE Select u Where u.ID_ENCA = Val(UIID.Text)).ToList
            UIGRIDCONTROL_DETA.DataSource = varlista_deta
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try

    End Sub

    Public Sub InsertarFactura(FACTURA As IVA_DETA_COMP_RETE)

        Try

            Dim numreg As Integer = (From u In _datasistema.ContextoIVA.IVA_DETA_COMP_RETE Where u.ID_ENCA = Val(UIID.Text) Select u).Count()

            If numreg + 1 > ivaconf_comp.NM_DOCS_X_COMP Then
                MetodosForm.MensajeErrorDefault("Numero de documentos maximo alcanzado")
                Exit Sub
            End If

            _datasistema.ContextoIVA.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)
            _datasistema.ContextoIVA.IVA_DETA_COMP_RETE.InsertOnSubmit(FACTURA)

            Try
                _datasistema.ContextoIVA.SubmitChanges()

            Catch ex As System.Data.SqlClient.SqlException
                MetodosForm.MensajeErrorDefault(ex.Message)
            Catch ex As Exception
                MetodosForm.MensajeErrorDefault("Critical error")

            End Try
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try

        ConsultarDetalle()

    End Sub

    Public Sub EliminarFactura(FACTURA As V_IVA_DETA_COMP_RETE)

        Try
            Dim tupla As IVA_DETA_COMP_RETE = (From a In _datasistema.ContextoIVA.IVA_DETA_COMP_RETE Where a.ID = FACTURA.ID).ToList()(0)
            If Not tupla Is Nothing Then

                _datasistema.ContextoIVA.IVA_DETA_COMP_RETE.DeleteOnSubmit(tupla)
                _datasistema.ContextoIVA.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                Try
                    _datasistema.ContextoIVA.SubmitChanges()

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

   

   

    Private Sub Btn_Find_Click(sender As Object, e As EventArgs) Handles Btn_Find.Click

        Try
            If Val(UIID.Text) <> 0 And UICD_ESTADO.EditValue = "D" Then
                Dim f As New FORM_IVA_SELECT_DOC_PERC_SAE(_datasistema)
                f.NMANIO = nmanio
                f.NMMES = nmmes
                f.cve_prove = UI_CVE_PROVEEDOR.EditValue
                f.formenca = Me
                f.idenca = Val(UIID.Text)
                f.ShowDialog()
            End If
           
        Catch ex As Exception

        End Try

    End Sub

    Private Sub UIID_EditValueChanged(sender As Object, e As EventArgs) Handles UIID.EditValueChanged
        ConsultarDetalle()
        If (UICD_ESTADO.EditValue <> "D") Then
            Btn_Find.Enabled = False
            uibtn_agregarItemNOSAE.Enabled = False
        Else
            Btn_Find.Enabled = True
            uibtn_agregarItemNOSAE.Enabled = True
        End If
    End Sub

    Private Sub UIGRIDVIEW_DETA_KeyDown(sender As Object, e As KeyEventArgs) Handles UIGRIDVIEW_DETA.KeyDown
        If e.KeyCode = Keys.Delete And Not IsNothing(UIGRIDVIEW_DETA.GetFocusedRow) And UICD_ESTADO.EditValue = "D" Then

            If MetodosForm.Preguntar(3) Then
                Dim aux As V_IVA_DETA_COMP_RETE = UIGRIDVIEW_DETA.GetFocusedRow
                Dim ENCA As V_IVA_ENCA_COMP_RETE = UIGRIDVIEW.GetFocusedRow

                If ENCA.CD_ESTADO <> "D" Or aux.ID <= 0 Then
                    MetodosForm.MensajeErrorDefault("Verificar el estado del comprobante")
                Else
                    EliminarFactura(aux)
                End If
            End If
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles uibtn_agregarItemNOSAE.Click
        Dim ventana As New FORM_IVA_COMP_RETE_ALTER
        ventana.idenca = Val(UIID.Text)
        ventana.flgsujexcl = UIFLG_SUJ_EXCL.Checked
        ventana.fcomprete = Me
        ventana.ShowDialog()

    End Sub

    Private Sub uibtn_anular_Click(sender As Object, e As EventArgs) Handles uibtn_anular.Click
        Try
          
            Dim tupla As IVA_ENCA_COMP_RETE = (From a In _datasistema.ContextoIVA.IVA_ENCA_COMP_RETE Where a.ID = Val(UIID.Text)).ToList()(0)

            If tupla.CD_ESTADO = "I" Then
                If Not MetodosForm.Preguntar("Esta seguro de anular el comprobante") Then
                    Exit Sub
                End If
                Dim MSJ As String = ""
                Dim NMERROR As Integer = 0
                _datasistema.ContextoIVA.PR_IVA_ANUL_COMP_RETE(tupla.ID, MSJ, NMERROR)
                If (NMERROR > 0) Then
                    MetodosForm.MensajeErrorDefault(MSJ)
                End If
            Else
                Exit Sub
            End If
            
            Consultar()
            MetodosForm.SeleccionarFila(UIGRIDVIEW, "ID", tupla.ID)

        Catch ex As Exception
            MetodosForm.MensajeErrorDefault(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            'If Val(UIID.Text) <> 0 And UICD_ESTADO.EditValue = "D" Then
            Dim f As New FORM_IVA_SELECT_DOC_PERC_SAE(_datasistema)
            f.NMANIO = nmanio
            f.NMMES = nmmes
            'f.cve_prove = UI_CVE_PROVEEDOR.EditValue
            f.formenca = Me
            'f.idenca = Val(UIID.Text)
            f.flgtodos = True
            f.ShowDialog()
            'End If

        Catch ex As Exception

        End Try
    End Sub
End Class
