Imports IVASAE.Utilidades
Imports IVASAE.IVA
Public Class RPT_LIBRO_IVA_EXPO

    Private Sub uilblsubtitulo_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles uilblsubtitulo.BeforePrint
        Dim mes As String = ""
        Dim tupla As V_IVA_DETALLE_VENTA
        tupla = GetCurrentRow()
        For Each item As clasegenericapares In MetodosForm.listaMeses
            If item.Codigo = tupla.NM_MES Then
                mes = item.Descripcion.ToUpper + " " + tupla.NM_ANIO.ToString
            End If
        Next

        uilblsubtitulo.Text = "Para el mes de " + mes
    End Sub
End Class