Imports IVASAE.Utilidades
Imports IVASAE.IVA
Public Class RPT_DETALLE_VENTA

    Private Sub XrLabel5_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles uilblsubtitulo.BeforePrint
        Dim mes As String = ""
        Dim anio As Integer
        Dim tupla As V_IVA_DETALLE_VENTA
        tupla = GetCurrentRow()
        For Each item As clasegenericapares In MetodosForm.listaMeses
            If item.Codigo = tupla.NM_MES Then
                mes = item.Descripcion
            End If
        Next
        anio = tupla.NM_ANIO

        uilblsubtitulo.Text = "Para el mes de " + mes + " " + anio.ToString()
    End Sub

    Private Sub XrLabel6_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles uilbltitulo.BeforePrint

    End Sub

    Private Sub RPT_DETALLE_VENTA_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        uilbltitulo.Text = uilbltitulo.Text + " " + DS_TITULO.Value.ToString
    End Sub

    Private Sub ReportFooter_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles ReportFooter.BeforePrint
        If (DS_TITULO.Value.ToString = "EXPORTACIONES") Then
            uipanel_debito.Visible = False
        End If
    End Sub
End Class