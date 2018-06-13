Imports IVASAE.IVA
Imports IVASAE.Utilidades

Public Class FORM_IVA_SELECT_DOC_PERC_SAE

    Private varlista As Generic.List(Of V_IVA_RETENCION)
    Public id_respuesta As Integer = 0
    Public cve_prove As String
    Public NMANIO As Integer
    Public NMMES As Integer
    Public formenca As FORM_IVA_COMP_RETE
    Public idenca As Integer
    Public flgtodos As Boolean


    Public Sub New(ds As DataSistema)
        _datasistema = ds
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub UIGRIDCONTROL_DoubleClick(sender As Object, e As EventArgs) Handles UIGRIDCONTROL.DoubleClick

        Try
            If flgtodos Then

            Else
                Dim aux As V_IVA_RETENCION = UIGRIDVIEW.GetFocusedRow
                Dim deta As New IVA_DETA_COMP_RETE With
                    {.CVE_DOC = aux.No_DOCTO,
                     .NM_MONTO_RETENIDO = aux.IMPUESTO,
                     .NM_MONTO_SUJETO = aux.MONTO,
                    .ID_ENCA = idenca}

                Try
                    formenca.InsertarFactura(deta)
                    formenca.ConsultarDetalle()
                    Consultar()
                Catch ex As Exception
                    MetodosForm.MensajeErrorDefault("Critical error: " + ex.Message)
                End Try
            End If


        Catch ex As Exception
            MetodosForm.MensajeErrorDefault("Critical error: " + ex.Message)
        End Try

    End Sub

    Private Sub FORM_IVA_SELECT_DOC_PERC_SAE_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        Consultar()
        If flgtodos Then
            colNOMBRE.VisibleIndex = 1

        End If

    End Sub

    Public Sub Consultar()

        Try
            UIGROUP_CONTAINER.Text = "Seleccione la(s) facturas"
            _datasistema.ConectarIVA()
            If flgtodos Then
                varlista = (From u In _datasistema.ContextoIVA.V_IVA_RETENCION
                 Select u Where u.MES = NMMES And u.ANIO = NMANIO).ToList
            Else
                varlista = (From u In _datasistema.ContextoIVA.V_IVA_RETENCION
                 Select u Where u.CVE_CLPV = cve_prove And u.MES = NMMES And u.ANIO = NMANIO).ToList
            End If


            Dim aux As New Generic.List(Of V_IVA_RETENCION)
            Dim deta As Generic.List(Of IVA_DETA_COMP_RETE)
            Dim existe As Boolean
            deta = (From u In _datasistema.ContextoIVA.IVA_DETA_COMP_RETE Select u).ToList

            For Each item In varlista
                existe = False
                For Each tupla In deta
                    If item.No_DOCTO = tupla.CVE_DOC Then
                        existe = True
                    End If
                Next
                If Not existe Then
                    aux.Add(item)
                End If
            Next

            UIGRIDCONTROL.DataSource = aux

        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try

    End Sub

End Class
