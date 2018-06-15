Imports IVASAE.Utilidades
Imports IVASAE.IVA
Public Class RPT_LIBRO_IVA_VENTA

    Private Sub TopMargin_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles TopMargin.BeforePrint
        If FLG_MOSTRAR_ENCABEZADO.Value <> "S" Then
            uilbltitulo.Visible = False
            uilblsubtitulo.Visible = False
            uilblnit.Visible = False
            uilblnrc.Visible = False
           
            uilblnopag.Visible = False

            uilblfolio.Visible = False
            uilblcorr.Visible = False
            uilblExentas.Visible = False
            uilblgravadas.Visible = False
            uilblpercepcion.Visible = False
            uilblIVA.Visible = False
            uilblnombreContrib.Visible = False
            uilblsubtotal.Visible = False
            uilbldia.Visible = False
            uilblventas.Visible = False
            uilblcliente.Visible = False
            uilbldocumento.Visible = False
            uilblbncr.Visible = False
        End If
    End Sub

    Private Sub uilblsubtitulo_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles uilblsubtitulo.BeforePrint
        Dim mes As String = ""
        Dim tupla As IVA_LIBRO_VENTA_CONTRIBUYENTE
        tupla = GetCurrentRow()
        For Each item As clasegenericapares In MetodosForm.listaMeses
            If item.Codigo = tupla.NM_MES Then
                mes = item.Descripcion
            End If
        Next

        uilblsubtitulo.Text = "Para el mes de " + mes
    End Sub
End Class