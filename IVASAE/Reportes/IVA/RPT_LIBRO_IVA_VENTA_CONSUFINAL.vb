Imports IVASAE.Utilidades
Imports IVASAE.IVA
Public Class RPT_LIBRO_IVA_VENTA_CONSUFINAL

    Private Sub uilblsubtitulo_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles uilblsubtitulo.BeforePrint
        Dim mes As String = ""
        'Dim anio As Integer
        Dim tupla As IVA_LIBRO_VENTA_CONSUMIDOR
        tupla = GetCurrentRow()
        For Each item As clasegenericapares In MetodosForm.listaMeses
            If item.Codigo = tupla.NM_MES Then
                mes = item.Descripcion.ToUpper + "  " + tupla.NM_ANIO.ToString
            End If
        Next
        If FLG_MOSTRAR_ENCABEZADO.Value = "S" Then
            uilblsubtitulo_MES.Text = "Para el mes de " + mes
        Else
            uilblsubtitulo.Text = mes
        End If
    End Sub

    Private Sub TopMargin_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles TopMargin.BeforePrint
        If FLG_MOSTRAR_ENCABEZADO.Value <> "S" Then
            uilbltitulo.Visible = False
            uilblsubtitulo_MES.Visible = False
            uilblnit.Visible = False
            uilblnrc.Visible = False
            uilblventas.Visible = False
            uilbltotal.Visible = False
            uilblexportaciones.Visible = False
            uilblnosujeta.Visible = False
            uilbldia.Visible = False
            uilblexentas.Visible = False
            uilblgravadas.Visible = False
            uilbldocumentos.Visible = False
            uilbldelno.Visible = False
            uilblalno.Visible = False
            uilblnombreContrib.Visible = False
            ' uilblno.Visible = False
        Else
            uilblsubtitulo.Visible = False
        End If
    End Sub
End Class