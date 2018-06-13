Imports IVASAE.Utilidades
Imports IVASAE.IVA
Public Class FORM_IVA_CLIE
    Implements InterfazForms
    Public flgVenta As Boolean = True
    Dim varlista As Generic.List(Of IVA.IVA_CLIE_PROV)
    Dim COMPRA, VENTA As String

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

    Public Sub llenarcombos()
        UICD_TIPO_LOCALIDAD.Properties.DataSource = MetodosForm.listaLocalidades
    End Sub

    Public Sub bindear() Implements InterfazForms.bindear
        UIID.DataBindings.Add("EditValue", varlista, "ID", False, DataSourceUpdateMode.Never)
        UICLAVE.DataBindings.Add("EditValue", varlista, "CLAVE", False, DataSourceUpdateMode.Never)
        UIDS_NOMBRE.DataBindings.Add("EditValue", varlista, "DS_NOMBRE", False, DataSourceUpdateMode.Never)
        UIDS_DIRECCION.DataBindings.Add("EditValue", varlista, "DS_DIRECCION", False, DataSourceUpdateMode.Never)
        UIDS_NOMBRE_REPRESENTANTE.DataBindings.Add("EditValue", varlista, "DS_NOMBRE_REPRESENTANTE", False, DataSourceUpdateMode.Never)
        UICD_TIPO_LOCALIDAD.DataBindings.Add("EditValue", varlista, "CD_TIPO_LOCALIDAD", False, DataSourceUpdateMode.Never)
        UIDS_GIRO.DataBindings.Add("EditValue", varlista, "DS_GIRO", False, DataSourceUpdateMode.Never)
        UIDS_DEPARTAMENTO.DataBindings.Add("EditValue", varlista, "DS_DEPARTAMENTO", False, DataSourceUpdateMode.Never)
        UIDS_NIT.DataBindings.Add("EditValue", varlista, "DS_NIT", False, DataSourceUpdateMode.Never)
        UIDS_NUM_REG_FISC.DataBindings.Add("EditValue", varlista, "DS_NUM_REG_FISC", False, DataSourceUpdateMode.Never)
        UIDS_DUI.DataBindings.Add("EditValue", varlista, "DS_DUI", False, DataSourceUpdateMode.Never)
    End Sub

    Public Sub Consultar() Implements InterfazForms.Consultar
        Try
            If flgVenta Then
                VENTA = "S"
                COMPRA = "N"
            Else
                VENTA = "N"
                COMPRA = "S"
            End If

            _datasistema.ConectarIVA()

            varlista = (From u In _datasistema.ContextoIVA.IVA_CLIE_PROV
                    Select u Where u.FLG_PROVEEDOR = COMPRA And u.FLG_CLIENTE = VENTA).ToList

            UIGRIDCONTROL.DataSource = varlista
            llenarcombos()
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
        UICLAVE.DataBindings.Clear()
        UIDS_NOMBRE.DataBindings.Clear()
        UIDS_DIRECCION.DataBindings.Clear()
        UIDS_NOMBRE_REPRESENTANTE.DataBindings.Clear()
        UICD_TIPO_LOCALIDAD.DataBindings.Clear()
        UIDS_GIRO.DataBindings.Clear()
        UIDS_DEPARTAMENTO.DataBindings.Clear()
        UIDS_NIT.DataBindings.Clear()
        UIDS_NUM_REG_FISC.DataBindings.Clear()
        UIDS_DUI.DataBindings.Clear()

    End Sub

    Public Sub Eliminar() Implements InterfazForms.Eliminar
        Try
            Dim tupla As IVA_CLIE_PROV = (From a In _datasistema.ContextoIVA.IVA_CLIE_PROV Where a.ID = Val(UIID.Text)).ToList()(0)
            If Not tupla Is Nothing And tupla.FLG_SAE = CChar("N") Then

                _datasistema.ContextoIVA.IVA_CLIE_PROV.DeleteOnSubmit(tupla)

                _datasistema.ContextoIVA.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)


                _datasistema.ContextoIVA.SubmitChanges()
                Consultar()

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

    End Sub

    Public Sub Limpiar() Implements InterfazForms.Limpiar
        desbindear()
        UIID.Text = ""
        UICLAVE.Text = ""
        UIDS_NOMBRE.Text = ""
        UIDS_DIRECCION.Text = ""
        UIDS_NOMBRE_REPRESENTANTE.Text = ""
        UICD_TIPO_LOCALIDAD.EditValue = Nothing
        UIDS_GIRO.Text = ""
        UIDS_DEPARTAMENTO.Text = ""
        UIDS_NIT.Text = ""
        UIDS_NUM_REG_FISC.Text = ""
        UIDS_DUI.Text = ""

    End Sub

    Public Sub Modificar() Implements InterfazForms.Modificar
        Try



            If UIID.Text <> "" Then
                Dim tupla As IVA_CLIE_PROV = (From a In _datasistema.ContextoIVA.IVA_CLIE_PROV Where a.ID = Val(UIID.Text)).ToList()(0)
                If Not tupla Is Nothing Then


                    tupla.DS_NOMBRE = UIDS_NOMBRE.Text
                    'tupla.CLAVE = UICLAVE.Text
                    tupla.DS_DIRECCION = UIDS_DIRECCION.Text
                    tupla.DS_NOMBRE_REPRESENTANTE = UIDS_NOMBRE_REPRESENTANTE.Text
                    tupla.CD_TIPO_LOCALIDAD = UICD_TIPO_LOCALIDAD.EditValue.ToString
                    tupla.DS_GIRO = UIDS_GIRO.Text
                    tupla.DS_DEPARTAMENTO = UIDS_DEPARTAMENTO.Text
                    tupla.DS_NIT = UIDS_NIT.Text
                    tupla.DS_NUM_REG_FISC = UIDS_NUM_REG_FISC.Text
                    tupla.DS_DUI = UIDS_DUI.Text


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

                Dim A As New IVA_CLIE_PROV With
         {.ID = 0,
           .DS_NOMBRE = UIDS_NOMBRE.Text,
                .CLAVE = "",
                .DS_DIRECCION = UIDS_DIRECCION.Text,
                .DS_NOMBRE_REPRESENTANTE = UIDS_NOMBRE_REPRESENTANTE.Text,
                .CD_TIPO_LOCALIDAD = UICD_TIPO_LOCALIDAD.EditValue.ToString,
                .DS_GIRO = UIDS_GIRO.Text,
                .DS_DEPARTAMENTO = UIDS_DEPARTAMENTO.Text,
                .DS_NIT = UIDS_NIT.Text,
                .DS_NUM_REG_FISC = UIDS_NUM_REG_FISC.Text,
                .DS_DUI = UIDS_DUI.Text,
          .FLG_SAE = "N",
          .FLG_CLIENTE = VENTA,
          .FLG_PROVEEDOR = COMPRA
         }

                _datasistema.ContextoIVA.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                _datasistema.ContextoIVA.IVA_CLIE_PROV.InsertOnSubmit(A)
                Try
                    _datasistema.ContextoIVA.SubmitChanges()
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
    Public Overrides Sub Refrescar()
        Consultar()
    End Sub

    Private Sub UIBR_IMPORTAR_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UIBR_IMPORTAR.ItemClick
        Try
            If (MetodosForm.Preguntar("¿Esta seguro de importar?")) Then
                Principal.MostrarEspere(True)
                Dim msj As String = ""
                Dim nmerror As Integer = 0
                _datasistema.ContextoIVA.PR_IVA_IMPO_CLIE_PROV(nmerror, msj)
                If (nmerror <> 0) Then
                    Throw New Exception(msj)
                End If
            End If
            Principal.MostrarEspere(False)      
        Catch ex As Exception
            Principal.MostrarEspere(False)
            MetodosForm.MensajeErrorDefault(ex.Message)
        End Try

    End Sub
End Class
