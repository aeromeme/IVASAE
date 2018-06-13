Imports IVASAE.Utilidades
Imports IVASAE.clasesReporte
Imports IVASAE.IVA
Public Class FORM_IVA_COMP_RETE_ALTER

    Public fcomprete As FORM_IVA_COMP_RETE
    Public idenca As Integer
    Public flgsujexcl As Boolean
    Private Sub FORM_IVA_COMP_RETE_ALTER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UIREFERENCIA.Text = ""
        UIMONTO_RENTA.EditValue = 0.0
        UIMONTO_SUJETO.EditValue = 0.0
        UIREFERENCIA.Focus()
    End Sub

    Private Sub UIBTNSAVE_Click(sender As Object, e As EventArgs) Handles UIBTNSAVE.Click
        Try
            Dim tupla As New IVA_DETA_COMP_RETE With
                {.ID_ENCA = idenca,
                 .CVE_DOC = UIREFERENCIA.Text,
                 .NM_MONTO_RETENIDO = Decimal.Parse(UIMONTO_RENTA.EditValue.ToString),
                 .NM_MONTO_SUJETO = Decimal.Parse(UIMONTO_SUJETO.EditValue.ToString)
                    }
            fcomprete.InsertarFactura(tupla)
            Me.Close()
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault(ex.Message)
        End Try
    End Sub

    Private Sub UIMONTO_SUJETO_EditValueChanged(sender As Object, e As EventArgs) Handles UIMONTO_SUJETO.EditValueChanged
        If flgsujexcl Then
            UIMONTO_RENTA.EditValue = UIMONTO_SUJETO.EditValue * 0.13
        Else
            UIMONTO_RENTA.EditValue = UIMONTO_SUJETO.EditValue * 0.01
        End If
    End Sub
End Class