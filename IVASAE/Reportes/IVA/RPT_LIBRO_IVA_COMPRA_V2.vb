Imports IVASAE.Utilidades
Imports IVASAE.IVA
Public Class RPT_LIBRO_IVA_COMPRA_V2

    Private Sub uilblsubtitulo_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles uilblsubtitulo.BeforePrint
        Dim mes As String = ""
        Dim tupla As IVA_LIBRO_COMPRA
        tupla = GetCurrentRow()
        For Each item As clasegenericapares In MetodosForm.listaMeses
            If item.Codigo = tupla.NM_MES Then
                mes = item.Descripcion.ToUpper + " " + tupla.NM_ANIO.ToString
            End If
        Next
        If FLG_MOSTRAR_ENCABEZADO.Value = "S" Then
            uilblsubtitulo_MES.Text = "Para el mes de " + mes
        Else
            uilblsubtitulo.Text = mes
        End If

    End Sub

    Private Sub RPT_LIBRO_IVA_COMPRA_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        If FLG_MOSTRAR_ENCABEZADO.Value <> "S" Then
            uilbltitulo.Visible = False
            uilblsubtitulo_MES.Visible = False
            uilblnit.Visible = False
            uilblnrc.Visible = False
            uilblcomprasaterceros.Visible = False
            uilbltotal.Visible = False
            uilblretencion.Visible = False
            uilblnopag.Visible = False
            uilblfecha.Visible = False
            uilblfolio.Visible = False
            uilblnomproveedor.Visible = False
            uilblcomprobante.Visible = False
            uilblcorr.Visible = False
            uilblexeninter.Visible = False
            uilblexenlocal.Visible = False
            uilblexentas.Visible = False
            uilblgravadaimportacion.Visible = False
            uilblgravadas.Visible = False
            uilblgravlocal.Visible = False
            uilbliva.Visible = False
            uilblncrprov.Visible = False
            uilblnombreContrib.Visible = False
        Else
            uilblsubtitulo.Visible = False
        End If
    End Sub
End Class