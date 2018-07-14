Imports IVASAE.Utilidades
Imports IVASAE.IVA
Public Class FORM_IVA_DOC_NOSAE
    Implements InterfazForms
    Dim varlista As Generic.List(Of IVA.V_IVA_DOC_NO_SAE)
    Public flgVenta As Boolean
    Dim COMPRA, VENTA As String
    Public nmmes As Integer
    Public nmanio As Integer
    Private ivaconf As IVA_CONTROL_PERIODO
    Private flgbloquearInterfaz As Boolean = False
    Private porcIVA As Decimal
    Private tipoDoc As String
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

        UIID_CLIE.DataBindings.Add("EditValue", varlista, "ID_CLIE", False, DataSourceUpdateMode.Never)
        UIFE_FECHA.DataBindings.Add("EditValue", varlista, "FE_FECHA", False, DataSourceUpdateMode.Never)
        UIID_TIPO_DOC.DataBindings.Add("EditValue", varlista, "ID_TIPO_DOC", False, DataSourceUpdateMode.Never)
        UICVE_DOC.DataBindings.Add("EditValue", varlista, "CVE_DOC", False, DataSourceUpdateMode.Never)
        UINM_EXENTO.DataBindings.Add("EditValue", varlista, "NM_EXENTO", False, DataSourceUpdateMode.Never)
        UINM_GRAVADO.DataBindings.Add("EditValue", varlista, "NM_GRAVADO", False, DataSourceUpdateMode.Never)
        UINM_IVA.DataBindings.Add("EditValue", varlista, "NM_IVA", False, DataSourceUpdateMode.Never)
        UINM_RENTA.DataBindings.Add("EditValue", varlista, "NM_RENTA", False, DataSourceUpdateMode.Never)
        UINM_IVA_RETENIDO.DataBindings.Add("EditValue", varlista, "NM_IVA_RETENIDO", False, DataSourceUpdateMode.Never)
        UINM_IVA_PERCIVIDO.DataBindings.Add("EditValue", varlista, "NM_IVA_PERCIVIDO", False, DataSourceUpdateMode.Never)
        UINM_TOTAL.DataBindings.Add("EditValue", varlista, "NM_TOTAL", False, DataSourceUpdateMode.Never)
        UIID.DataBindings.Add("EditValue", varlista, "ID", False, DataSourceUpdateMode.Never)
    End Sub

    Public Sub llenarcombos()
        Try
            UIID_CLIE.Properties.DataSource = (From u In _datasistema.ContextoIVA.IVA_CLIE_PROV Select u Where u.FLG_CLIENTE = VENTA And u.FLG_PROVEEDOR = COMPRA).ToList
            UIID_TIPO_DOC.Properties.DataSource = (From u In _datasistema.ContextoIVA.IVA_TIPO_DOCUMENTO Select u Where u.FLG_COMPRA = COMPRA And u.FLG_VENTA = VENTA).ToList

        Catch ex As Exception
            MetodosForm.MensajeErrorDefault(ex.Message)
        End Try
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
            Else
                Principal.actualizarInterfaz(1)
                Principal.actualizarInterfaz(6)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Consultar() Implements InterfazForms.Consultar
        Try
            Try
                porcIVA = (From u In _datasistema.ContextoIVA.IVA_CONF Select u.NM_PORC_IVA).First

            Catch ex As Exception

            End Try
            If flgVenta Then
                VENTA = "S"
                COMPRA = "N"
                uilblpercepcion.Visible = False
                UINM_IVA_PERCIVIDO.Visible = False
                uilblrenta.Visible = False
                UINM_RENTA.Visible = False
                uilblclieprov.Text = "Cliente"
            Else
                VENTA = "N"
                COMPRA = "S"              
                UINM_IVA_RETENIDO.Visible = False
                uilblretencion.Visible = False
                uilblclieprov.Text = "Proveedor"

            End If

            _datasistema.ConectarIVA()

            varlista = (From u In _datasistema.ContextoIVA.V_IVA_DOC_NO_SAE
                    Select u Where u.FLG_COMPRA = COMPRA And u.FLG_VENTA = VENTA And u.NM_ANIO = nmanio And u.NM_MES = nmmes).ToList

            UIGRIDCONTROL.DataSource = varlista
            llenarcombos()
            desbindear()
            bindear()
            If varlista.Count = 0 Then
                Limpiar()
                If nmmes > 0 Then
                    UIFE_FECHA.EditValue = New Date(nmanio, nmmes, 1)
                End If
            Else
                Try
                    flgjumpfac = True
                    UIFACTURA.EditValue = UINM_GRAVADO.EditValue + UINM_IVA.EditValue
                Catch ex As Exception

                End Try
            End If
            ActualizarInterfaz()
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try
    End Sub

    Public Sub desbindear() Implements InterfazForms.desbindear

        UIID_CLIE.DataBindings.Clear()
        UIFE_FECHA.DataBindings.Clear()
        UIID_TIPO_DOC.DataBindings.Clear()
        UICVE_DOC.DataBindings.Clear()
        UINM_EXENTO.DataBindings.Clear()
        UINM_GRAVADO.DataBindings.Clear()
        UINM_IVA.DataBindings.Clear()
        UINM_RENTA.DataBindings.Clear()
        UINM_IVA_RETENIDO.DataBindings.Clear()
        UINM_IVA_PERCIVIDO.DataBindings.Clear()
        UINM_TOTAL.DataBindings.Clear()
        UIID.DataBindings.Clear()
    End Sub

    Public Sub Eliminar() Implements InterfazForms.Eliminar
        Try
            Dim tupla As IVA_DOC_NO_SAE = (From a In _datasistema.ContextoIVA.IVA_DOC_NO_SAE Where a.ID = Val(UIID.Text)).ToList()(0)


            _datasistema.ContextoIVA.IVA_DOC_NO_SAE.DeleteOnSubmit(tupla)

            _datasistema.ContextoIVA.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)


            _datasistema.ContextoIVA.SubmitChanges()
            Consultar()
            If (flgVenta And (From U In _datasistema.ContextoIVA.IVA_TIPO_DOCUMENTO Where U.ID = tupla.ID_TIPO_DOC And U.CD_TIPO = "FEX" Select U).Count = 1) Then
                Dim B As IVA_VENTA_DECLARACION_EXPORTACION = (From U In _datasistema.ContextoIVA.IVA_VENTA_DECLARACION_EXPORTACION Select U Where U.ID_DOC_SAE = tupla.ID And U.FLG_MANUAL = "S").First
                _datasistema.ContextoIVA.IVA_VENTA_DECLARACION_EXPORTACION.DeleteOnSubmit(B)
                _datasistema.ContextoIVA.SubmitChanges()
            End If

        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try
    End Sub

    Public Sub Imprimir() Implements InterfazForms.Imprimir

    End Sub

    Public Sub Insertar() Implements InterfazForms.Insertar

    End Sub

    Public Sub Limpiar() Implements InterfazForms.Limpiar

        UIID_CLIE.EditValue = Nothing
        'UIFE_FECHA.EditValue = New Date(nmanio, nmmes, Date.DaysInMonth(nmanio, nmmes))
        UIID_TIPO_DOC.EditValue = Nothing
        UICVE_DOC.Text = ""
        UINM_EXENTO.EditValue = 0.0
        UINM_GRAVADO.EditValue = 0.0
        UINM_IVA.EditValue = 0.0
        UINM_RENTA.EditValue = 0.0
        UINM_IVA_RETENIDO.EditValue = 0.0
        UINM_IVA_PERCIVIDO.EditValue = 0.0
        UINM_TOTAL.EditValue = 0.0
        UIFACTURA.EditValue = 0.0
        tipoDoc = ""
        UIID.Text = ""
    End Sub

    Public Sub Modificar() Implements InterfazForms.Modificar
        Try

            If (UIFE_FECHA.DateTime.Month <> nmmes And UIFE_FECHA.DateTime.Year <> nmanio) Then
                If Not (MetodosForm.Preguntar("Las fechas no conciden con el periodo seleccionado", "¿Esta seguro de proceder?")) Then
                    Exit Sub
                End If
            End If

            If UIID.Text <> "" Then
                Dim tupla As IVA_DOC_NO_SAE = (From a In _datasistema.ContextoIVA.IVA_DOC_NO_SAE Where a.ID = Val(UIID.Text)).ToList()(0)
                If Not tupla Is Nothing Then


                    tupla.ID_CLIE = Val(UIID_CLIE.EditValue)
                    tupla.FE_FECHA = UIFE_FECHA.DateTime
                    tupla.CVE_DOC = UICVE_DOC.Text
                    tupla.NM_EXENTO = Val(UINM_EXENTO.EditValue)
                    tupla.NM_GRAVADO = Val(UINM_GRAVADO.EditValue)
                    tupla.NM_IVA = Val(UINM_IVA.EditValue)
                    tupla.NM_RENTA = Val(UINM_RENTA.EditValue)
                    tupla.NM_IVA_RETENIDO = Val(UINM_IVA_RETENIDO.EditValue)
                    tupla.NM_IVA_PERCIVIDO = Val(UINM_IVA_PERCIVIDO.EditValue)
                    tupla.NM_TOTAL = Val(tupla.NM_EXENTO) + Val(tupla.NM_GRAVADO) + Val(tupla.NM_IVA) - Val(tupla.NM_RENTA) - Val(tupla.NM_IVA_RETENIDO) + Val(tupla.NM_IVA_PERCIVIDO)
                    tupla.FLG_COMPRA = COMPRA
                    tupla.FLG_VENTA = VENTA


                    _datasistema.ContextoIVA.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                    Try
                        _datasistema.ContextoIVA.SubmitChanges()

                        MetodosForm.SeleccionarFila(UIGRIDVIEW, "ID", tupla.ID)

                    Catch ex As Exception
                        MetodosForm.MensajeErrorDefault("Critical error")

                    End Try
                Else
                    MetodosForm.MensajeErrorDefault("No se modifico nada")

                End If
            Else

                Dim A As New IVA_DOC_NO_SAE With
             {.ID = 0,
              .ID_CLIE = Val(UIID_CLIE.EditValue),
              .ID_TIPO_DOC = Val(UIID_TIPO_DOC.EditValue),
              .NM_ANIO = nmanio,
              .NM_MES = nmmes,
               .FE_FECHA = UIFE_FECHA.DateTime,
                    .CVE_DOC = UICVE_DOC.Text,
                    .NM_EXENTO = Val(UINM_EXENTO.EditValue),
                    .NM_GRAVADO = Val(UINM_GRAVADO.EditValue),
                    .NM_IVA = Val(UINM_IVA.EditValue),
                    .NM_RENTA = Val(UINM_RENTA.EditValue),
                    .NM_IVA_RETENIDO = Val(UINM_IVA_RETENIDO.EditValue),
                    .NM_IVA_PERCIVIDO = Val(UINM_IVA_PERCIVIDO.EditValue),
                    .NM_TOTAL = Val(UINM_EXENTO.EditValue) + Val(UINM_GRAVADO.EditValue) + Val(UINM_IVA.EditValue) - Val(UINM_RENTA.EditValue) + Val(UINM_IVA_PERCIVIDO.EditValue) - Val(UINM_IVA_RETENIDO.EditValue),
              .FLG_COMPRA = COMPRA,
              .FLG_VENTA = VENTA
             }

                _datasistema.ContextoIVA.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                _datasistema.ContextoIVA.IVA_DOC_NO_SAE.InsertOnSubmit(A)

               

                Try
                    _datasistema.ContextoIVA.SubmitChanges()
                    Consultar()
                    MetodosForm.SeleccionarFila(UIGRIDVIEW, "ID", A.ID)
                    Dim destino As String = (From u In _datasistema.ContextoIVA.IVA_CLIE_PROV Where u.ID = Val(UIID_CLIE.EditValue) Select u.DS_DEPARTAMENTO).First()


                    If (flgVenta And (From U In _datasistema.ContextoIVA.IVA_TIPO_DOCUMENTO Where U.ID = A.ID_TIPO_DOC And U.CD_TIPO = "FEX" Select U).Count = 1) Then
                        Dim B As New IVA_VENTA_DECLARACION_EXPORTACION With
                            {.ID = 0,
                             .ID_DOC_SAE = A.ID,
                             .NM_ANIO = 0,
                             .NM_MES = 0,
                             .CD_ESTADO = "D",
                             .DS_DESTINO = destino,
                             .FLG_MANUAL = "S"}
                        _datasistema.ContextoIVA.IVA_VENTA_DECLARACION_EXPORTACION.InsertOnSubmit(B)
                        _datasistema.ContextoIVA.SubmitChanges()
                    End If

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

    Private Sub UINM_GRAVADO_EditValueChanged(sender As Object, e As EventArgs) Handles UINM_GRAVADO.EditValueChanged
        If UIID.Text = "" And tipoDoc <> "FAC" And tipoDoc <> "FEX" And tipoDoc <> "NCE" And tipoDoc <> "NCF" Then
            UINM_IVA.EditValue = UINM_GRAVADO.EditValue * porcIVA
        End If
    End Sub

    Private Sub UIID_EditValueChanged(sender As Object, e As EventArgs) Handles UIID.EditValueChanged
        Try
            flgjumpfac = True
            UIFACTURA.EditValue = UINM_GRAVADO.EditValue + UINM_IVA.EditValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UIID_TIPO_DOC_EditValueChanged(sender As Object, e As EventArgs) Handles UIID_TIPO_DOC.EditValueChanged
        Try
            Dim aux As IVA_TIPO_DOCUMENTO = (From u In _datasistema.ContextoIVA.IVA_TIPO_DOCUMENTO Where u.ID = Val(UIID_TIPO_DOC.EditValue) Select u).First
            tipoDoc = aux.CD_TIPO

            If tipoDoc = "FAC" Then
                UIFACTURA.Visible = True
                UINM_GRAVADO.Enabled = False
                UINM_IVA.Enabled = False
                UILBLFACTURA.Visible = True
            Else
                UIFACTURA.Visible = False
                UINM_GRAVADO.Enabled = True
                UINM_IVA.Enabled = True
                UILBLFACTURA.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public flgjumpfac As Boolean
    Private Sub UIFACTURA_EditValueChanged(sender As Object, e As EventArgs) Handles UIFACTURA.EditValueChanged
        If tipoDoc = "FAC" And Not flgjumpfac Then
            UINM_GRAVADO.EditValue = Math.Round(UIFACTURA.EditValue / 1.13, 6)
            UINM_IVA.EditValue = Math.Round((UIFACTURA.EditValue / 1.13) * 0.13, 6)
        Else
            flgjumpfac = False
        End If
    End Sub
End Class
