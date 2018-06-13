Imports IVASAE.IVA
Imports IVASAE.Utilidades
Public Class FORM_IVA_TIPO_DOC
    Implements InterfazForms
    Public flgVenta As Boolean
    Dim varlista As Generic.List(Of IVA.IVA_TIPO_DOCUMENTO)
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

    Public Sub bindear() Implements InterfazForms.bindear
        UIID.DataBindings.Add("EditValue", varlista, "ID", False, DataSourceUpdateMode.Never)
        UIDS_NOMBRE.DataBindings.Add("EditValue", varlista, "DS_NOMBRE", False, DataSourceUpdateMode.Never)
        UISIS_SUFIJO.DataBindings.Add("EditValue", varlista, "SIS_SUFIJO", False, DataSourceUpdateMode.Never)
        UISIS_EXCLU_SUFIJO.DataBindings.Add("EditValue", varlista, "SIS_EXCLU_SUFIJO", False, DataSourceUpdateMode.Never)
        UISIS_EXCLU_SUFIJO_2.DataBindings.Add("EditValue", varlista, "SIS_EXCLU_SUFIJO_2", False, DataSourceUpdateMode.Never)
        UINM_CHARS_SERIE.DataBindings.Add("EditValue", varlista, "NM_CHARS_SERIE", False, DataSourceUpdateMode.Never)
        UINM_CHARS_SUFIJO.DataBindings.Add("EditValue", varlista, "NM_CHARS_SUFIJO", False, DataSourceUpdateMode.Never)
        UICD_DET.DataBindings.Add("EditValue", varlista, "CD_DET", False, DataSourceUpdateMode.Never)
        UICD_TIPO.DataBindings.Add("EditValue", varlista, "CD_TIPO", False, DataSourceUpdateMode.Never)
        UIFLG_IMPO_SAE.DataBindings.Add("EditValue", varlista, "FLG_IMPO_SAE", False, DataSourceUpdateMode.Never)
        UIFLG_COMPRA_GRAVADA.DataBindings.Add("EditValue", varlista, "FLG_COMPRA_GRAVADA", False, DataSourceUpdateMode.Never)

    End Sub
    Public Sub llenarcombos()
        UICD_TIPO.Properties.DataSource = MetodosForm.listaTipoDocumentos
    End Sub

    Public Sub Consultar() Implements InterfazForms.Consultar
        Try
            If flgVenta Then
                VENTA = "S"
                COMPRA = "N"
                UIFLG_COMPRA_GRAVADA.Visible = False
            Else
                VENTA = "N"
                COMPRA = "S"
                UIFLG_COMPRA_GRAVADA.Visible = True
            End If

            _datasistema.ConectarIVA()

            varlista = (From u In _datasistema.ContextoIVA.IVA_TIPO_DOCUMENTO
                    Select u Where u.FLG_COMPRA = COMPRA And u.FLG_VENTA = VENTA).ToList

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
        UIDS_NOMBRE.DataBindings.Clear()
        UISIS_SUFIJO.DataBindings.Clear()
        UISIS_EXCLU_SUFIJO.DataBindings.Clear()
        UISIS_EXCLU_SUFIJO_2.DataBindings.Clear()
        UINM_CHARS_SERIE.DataBindings.Clear()
        UINM_CHARS_SUFIJO.DataBindings.Clear()
        UICD_DET.DataBindings.Clear()
        UICD_TIPO.DataBindings.Clear()
        UIFLG_IMPO_SAE.DataBindings.Clear()
        UIFLG_COMPRA_GRAVADA.DataBindings.Clear()
    End Sub

    Public Sub Eliminar() Implements InterfazForms.Eliminar
        Try
            Dim tupla As IVA_TIPO_DOCUMENTO = (From a In _datasistema.ContextoIVA.IVA_TIPO_DOCUMENTO Where a.ID = Val(UIID.Text)).ToList()(0)
            If Not tupla Is Nothing Then

                _datasistema.ContextoIVA.IVA_TIPO_DOCUMENTO.DeleteOnSubmit(tupla)

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
        UIDS_NOMBRE.Text = ""
        UISIS_SUFIJO.Text = ""
        UISIS_EXCLU_SUFIJO.Text = ""
        UISIS_EXCLU_SUFIJO_2.Text = ""
        UINM_CHARS_SERIE.Text = ""
        UINM_CHARS_SUFIJO.Text = ""
        UICD_DET.Text = ""
        UICD_TIPO.Text = ""
        UIFLG_IMPO_SAE.Checked = False
        UIFLG_COMPRA_GRAVADA.Checked = False
    End Sub

    Public Sub Modificar() Implements InterfazForms.Modificar
        Try



            If UIID.Text <> "" Then
                Dim tupla As IVA_TIPO_DOCUMENTO = (From a In _datasistema.ContextoIVA.IVA_TIPO_DOCUMENTO Where a.ID = Val(UIID.Text)).ToList()(0)
                If Not tupla Is Nothing Then


                    tupla.DS_NOMBRE = UIDS_NOMBRE.Text
                    tupla.SIS_SUFIJO = UISIS_SUFIJO.Text
                    tupla.SIS_EXCLU_SUFIJO = UISIS_EXCLU_SUFIJO.Text
                    tupla.SIS_EXCLU_SUFIJO_2 = UISIS_EXCLU_SUFIJO_2.Text
                    tupla.NM_CHARS_SERIE = Val(UINM_CHARS_SERIE.EditValue)
                    tupla.NM_CHARS_SUFIJO = Val(UINM_CHARS_SUFIJO.EditValue)
                    tupla.CD_DET = Val(UICD_DET.EditValue)
                    tupla.CD_TIPO = UICD_TIPO.EditValue.ToString
                    tupla.FLG_IMPO_SAE = UIFLG_IMPO_SAE.EditValue.ToString
                    tupla.FLG_COMPRA_GRAVADA = UIFLG_COMPRA_GRAVADA.EditValue.ToString


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

                Dim A As New IVA_TIPO_DOCUMENTO With
         {.ID = 0,
          .DS_NOMBRE = UIDS_NOMBRE.Text,
          .SIS_SUFIJO = UISIS_SUFIJO.Text,
          .SIS_EXCLU_SUFIJO = UISIS_EXCLU_SUFIJO.Text,
           .SIS_EXCLU_SUFIJO_2 = UISIS_EXCLU_SUFIJO_2.Text,
          .NM_CHARS_SERIE = Val(UINM_CHARS_SERIE.EditValue),
          .NM_CHARS_SUFIJO = Val(UINM_CHARS_SUFIJO.EditValue),
          .CD_DET = Val(UICD_DET.EditValue),
          .CD_TIPO = UICD_TIPO.EditValue.ToString,
          .FLG_COMPRA = COMPRA,
          .FLG_VENTA = VENTA,
          .FLG_IMPO_SAE = UIFLG_IMPO_SAE.EditValue.ToString,
          .FLG_COMPRA_GRAVADA = UIFLG_COMPRA_GRAVADA.EditValue.ToString
         }

                _datasistema.ContextoIVA.Refresh(Data.Linq.RefreshMode.OverwriteCurrentValues)

                _datasistema.ContextoIVA.IVA_TIPO_DOCUMENTO.InsertOnSubmit(A)
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

    Private Sub UIFLG_IMPO_SAE_CheckedChanged(sender As Object, e As EventArgs) Handles UIFLG_IMPO_SAE.CheckedChanged
        If UIFLG_IMPO_SAE.Checked Then
            UIGRP_IMPOR_PARAM.Visible = True
        Else
            UIGRP_IMPOR_PARAM.Visible = False
        End If
    End Sub
End Class
