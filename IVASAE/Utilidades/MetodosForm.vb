Imports System.Media
Imports DevExpress.XtraBars.Alerter
Imports System.IO
Namespace Utilidades
    Public Class MetodosForm
#Region "datagrid"
        Public Shared Sub SeleccionarFila(Vista As DevExpress.XtraGrid.Views.Grid.GridView, NombreDeColumna As String, Valor As Object)
            Try
                Dim RowHandle As Integer = 0
                Dim Col As DevExpress.XtraGrid.Columns.GridColumn = Vista.Columns(NombreDeColumna)
                While (True)
                    ' Locate the next row 
                    RowHandle = Vista.LocateByValue(RowHandle, Col, Valor)
                    ' Exit the loop if no row is found 
                    If RowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
                        Exit While
                    Else
                        'Vista.SelectRow(RowHandle)
                        Vista.FocusedRowHandle = RowHandle
                        Exit While
                    End If
                    ' Perform specific operations on the found row 
                    ' ... 
                    RowHandle += 1
                End While

            Finally

            End Try
        End Sub
#End Region


#Region "Mensajes"
        Public Shared Sub MensajeErrorDefault()
            SystemSounds.Asterisk.Play()
            Principal.MostrarEspere(False)
            ' MessageBox.Show("Error de sistema, reporte a informatica", "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim info As AlertInfo = New AlertInfo("Error de sistema", "Error de sistema, reporte a informatica")
            info.Image = My.Resources._1486169171_shield_error
            Principal.UINOTI_BALLON.Show(Principal, info)
        End Sub
        Public Shared Sub MensajeErrorDefault(txt As String)
            SystemSounds.Asterisk.Play()
            Principal.MostrarEspere(False)
            ' MessageBox.Show("Error de sistema, reporte a informatica: " + txt, "Error de sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim info As AlertInfo = New AlertInfo("Error de sistema", "Error de sistema, reporte a informatica: " + txt)
            info.Image = My.Resources._1486169171_shield_error
            Principal.UINOTI_BALLON.Show(Principal, info)
        End Sub
        Public Shared Sub MensajeErrorDefault(txt As String, titulo As String)
            SystemSounds.Asterisk.Play()
            Principal.MostrarEspere(False)
            'MessageBox.Show("Error de sistema, reporte a informatica: " + txt, "Error de sistema: " + titulo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Dim info As AlertInfo = New AlertInfo(titulo, "Error de sistema, reporte a informatica: " + txt)
            info.Image = My.Resources._1486169171_shield_error
            Principal.UINOTI_BALLON.Show(Principal, info)
        End Sub
        Public Shared Function Preguntar(preg As String, titulo As String) As Boolean
            SystemSounds.Question.Play()

            If MessageBox.Show(preg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Return True
            Else
                Return False
            End If
            Return False
        End Function
        Public Shared Function Preguntar(preg As String) As Boolean
            SystemSounds.Question.Play()

            If MessageBox.Show(preg, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Return True
            Else
                Return False
            End If
            Return False
        End Function
        ''' <summary>
        ''' </summary>
        ''' <param name="Tipo">1:insertar 2:modificar 3:eliminar</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function Preguntar(Tipo As Integer) As Boolean
            SystemSounds.Question.Play()
            Dim preg As String = ""
            If Tipo = 1 Then
                preg = "Esta seguro de insertar el registro"
            ElseIf Tipo = 2 Then
                preg = "Esta seguro de modificar el registro"
            ElseIf Tipo = 3 Then
                preg = "Esta seguro de eliminar el registro"
            End If

            If MessageBox.Show(preg, "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Return True
            Else
                Return False
            End If
            Return False
        End Function
        Public Shared Sub MensajeInfoDefault(txt As String)
            SystemSounds.Exclamation.Play()
            MessageBox.Show("Informacion: " + txt, "Respuesta del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        Public Shared Function PreguntarPorque(txt As String) As String
            Return InputBox(txt, "Pregunta")
        End Function
        Public Shared Sub Printexcepcion(mss As String)
            MsgBox("Excepcion no controlada" & Chr(13) & mss & Chr(13) & "Contacte con el desarrollador", MsgBoxStyle.Critical, "Error")
        End Sub
#End Region

#Region "colecciones de datos" 'NO CAMBIAR ESTOS PARAMETROS
        Public Shared Function listaMeses() As Generic.List(Of clasegenericapares)
            Dim _lista As New Generic.List(Of clasegenericapares)
            _lista.Add(New clasegenericapares(1, "Enero"))
            _lista.Add(New clasegenericapares(2, "Febrero"))
            _lista.Add(New clasegenericapares(3, "Marzo"))
            _lista.Add(New clasegenericapares(4, "Abril"))
            _lista.Add(New clasegenericapares(5, "Mayo"))
            _lista.Add(New clasegenericapares(6, "Junio"))
            _lista.Add(New clasegenericapares(7, "Julio"))
            _lista.Add(New clasegenericapares(8, "Agosto"))
            _lista.Add(New clasegenericapares(9, "Septiembre"))
            _lista.Add(New clasegenericapares(10, "Octubre"))
            _lista.Add(New clasegenericapares(11, "Noviembre"))
            _lista.Add(New clasegenericapares(12, "Diciembre"))
            Return _lista
        End Function
        Public Shared Function listaEmpaques() As Generic.List(Of clasegenericapares)
            Dim _lista As New Generic.List(Of clasegenericapares)
            _lista.Add(New clasegenericapares(CChar("P"), "Piezas"))
            _lista.Add(New clasegenericapares(CChar("I"), "Inner"))
            _lista.Add(New clasegenericapares(CChar("M"), "Master"))
            Return _lista
        End Function
        Public Shared Function listaNivelesAcceso() As Generic.List(Of clasegenericapares)
            Dim _lista As New Generic.List(Of clasegenericapares)
            _lista.Add(New clasegenericapares(CChar("U"), "Usuario"))
            _lista.Add(New clasegenericapares(CChar("A"), "Administrador"))
            Return _lista
        End Function
        Public Shared Function listaEstados() As Generic.List(Of clasegenericapares)
            Dim _lista As New Generic.List(Of clasegenericapares)
            _lista.Add(New clasegenericapares(CChar("B"), "Baja"))
            _lista.Add(New clasegenericapares(CChar("A"), "Activo"))
            Return _lista
        End Function

        Public Shared Function listaEstadosMarca() As Generic.List(Of clasegenericapares)
            Dim _lista As New Generic.List(Of clasegenericapares)
            _lista.Add(New clasegenericapares(CChar("P"), "Proceso"))
            _lista.Add(New clasegenericapares(CChar("D"), "Digitado"))
            _lista.Add(New clasegenericapares(CChar("A"), "Activa"))
            Return _lista
        End Function

        Public Shared Function listaTipoDocumentos() As Generic.List(Of clasegenericapares)
            Dim _lista As New Generic.List(Of clasegenericapares)
            _lista.Add(New clasegenericapares("CCF", "Credito fiscal"))
            _lista.Add(New clasegenericapares("LIQ", "Documento contable de liquidacion"))
            _lista.Add(New clasegenericapares("CRT", "Comprobante de retencion"))
            _lista.Add(New clasegenericapares("NDB", "Nota de debito"))
            _lista.Add(New clasegenericapares("NCR", "Nota de credito"))
            _lista.Add(New clasegenericapares("NCE", "Nota de credito exportacion"))
            _lista.Add(New clasegenericapares("NCF", "Nota de credito consumidor final"))
            _lista.Add(New clasegenericapares("FAC", "Factura"))
            _lista.Add(New clasegenericapares("FEX", "Factura exportacion"))
            _lista.Add(New clasegenericapares("FSE", "Factura sujeto excluido"))
            _lista.Add(New clasegenericapares("REC", "Recibo"))
            _lista.Add(New clasegenericapares("DEC", "Declaracion de mercancia"))
            _lista.Add(New clasegenericapares("FAD", "Formulario aduanero"))
            _lista.Add(New clasegenericapares("FAE", "Factura extranjero"))
            _lista.Add(New clasegenericapares("POL", "Poliza"))
            _lista.Add(New clasegenericapares("OTR", "Otro"))
            Return _lista
        End Function

        Public Shared Function listaSymbolos() As Generic.List(Of clasegenericapares)
            Dim _lista As New Generic.List(Of clasegenericapares)
            _lista.Add(New clasegenericapares(1, "COD128"))
            _lista.Add(New clasegenericapares(2, "EAN13"))
            Return _lista
        End Function
        Public Shared Function listaTiposMarca() As Generic.List(Of clasegenericapares)
            Dim _lista As New Generic.List(Of clasegenericapares)
            _lista.Add(New clasegenericapares(CChar("I"), "IMACASA"))
            _lista.Add(New clasegenericapares(CChar("C"), "CONDOR"))
            Return _lista
        End Function
        Public Shared Function listadoMeses() As List(Of String)
            Dim l As List(Of String) = New List(Of String)
            l.Add("ene")
            l.Add("feb")
            l.Add("mar")
            l.Add("abr")
            l.Add("may")
            l.Add("jun")
            l.Add("jul")
            l.Add("ago")
            l.Add("sep")
            l.Add("oct")
            l.Add("nov")
            l.Add("dic")
            Return l
        End Function
        Public Shared Function listadoImagen() As List(Of cImagen)
            Dim l As List(Of cImagen) = New List(Of cImagen)
            l.Add(New cImagen(1, "Produccion", My.Resources._1422071628_industry))
            l.Add(New cImagen(2, "Proveedores", My.Resources._proveedores))
            l.Add(New cImagen(3, "Finanzas", My.Resources._finance))
            l.Add(New cImagen(4, "Estadisticas", My.Resources._stat))
            l.Add(New cImagen(5, "Reportes", My.Resources._reporte2))
            l.Add(New cImagen(6, "Productos", My.Resources._product))
            l.Add(New cImagen(7, "Android", My.Resources._android))
            l.Add(New cImagen(8, "Balance", My.Resources._balance))
            l.Add(New cImagen(9, "Plan", My.Resources._plan))
            l.Add(New cImagen(10, "Receta", My.Resources._receta))
            l.Add(New cImagen(11, "Seguridad", My.Resources._security))
            l.Add(New cImagen(12, "Marca", My.Resources._brand))
            l.Add(New cImagen(13, "Analisis venta", My.Resources._stat))
            l.Add(New cImagen(14, "Firma", My.Resources._signature_mini))

            Return l
        End Function

        Public Shared Function ListaConCredito() As Generic.List(Of clasegenericapares)
            Dim _lista As New Generic.List(Of clasegenericapares)

            _lista.Add(New clasegenericapares(CChar("1"), "15 dias"))
            _lista.Add(New clasegenericapares(CChar("2"), "30 dias"))
            _lista.Add(New clasegenericapares(CChar("3"), "45 dias"))
            _lista.Add(New clasegenericapares(CChar("4"), "60 dias"))
            _lista.Add(New clasegenericapares(CChar("5"), "90 dias"))
            Return _lista
        End Function

        Public Shared Function ListaSinCredito() As Generic.List(Of clasegenericapares)
            Dim _lista As New Generic.List(Of clasegenericapares)
            _lista.Add(New clasegenericapares(CChar("6"), "100% T/T"))
            _lista.Add(New clasegenericapares(CChar("7"), "L/C AT SIGHT"))
            Return _lista
        End Function

        Public Shared Function EncontrarImagen(id As Integer, l As List(Of cImagen)) As Image
            For Each item As cImagen In l
                If item.id = id Then
                    Return item.imagen
                End If
            Next
            Return My.Resources._settin
        End Function
        Public Shared Function listaAnios() As Generic.List(Of clasegenericapares)
            Dim _lista As New Generic.List(Of clasegenericapares)

            For index = 2016 To 2050
                _lista.Add(New clasegenericapares(index, index.ToString))
            Next

            Return _lista
        End Function
        Public Shared Function ListaTipoCostoProduccion() As Generic.List(Of clasegenericapares)
            Dim _lista As New Generic.List(Of clasegenericapares)

            _lista.Add(New clasegenericapares(CChar("C"), "Combustible"))
            _lista.Add(New clasegenericapares(CChar("E"), "Electrico"))
            Return _lista
        End Function

        Public Shared Function listaLocalidades() As Generic.List(Of clasegenericapares)
            Dim _lista As New Generic.List(Of clasegenericapares)
            _lista.Add(New clasegenericapares("LOC", "Local"))
            _lista.Add(New clasegenericapares("REG", "Regional"))
            _lista.Add(New clasegenericapares("INT", "Internacional"))
            Return _lista
        End Function

        Public Shared Function listaLibrosIVA() As Generic.List(Of clasegenericapares)
            Dim _lista As New Generic.List(Of clasegenericapares)
            _lista.Add(New clasegenericapares("COM", "Compras"))
            _lista.Add(New clasegenericapares("VEN", "Ventas"))
            _lista.Add(New clasegenericapares("VCF", "Ventas consumidor final"))
            _lista.Add(New clasegenericapares("FEL", "Ventas exportacion"))
            _lista.Add(New clasegenericapares("DCF", "Detalle consumidor final"))
            _lista.Add(New clasegenericapares("DFE", "Detalle factura exportacion"))
            Return _lista
        End Function

        Public Shared Function listaEstadosDocRete() As Generic.List(Of clasegenericapares)
            Dim _lista As New Generic.List(Of clasegenericapares)
            _lista.Add(New clasegenericapares(CChar("I"), "Impreso"))
            _lista.Add(New clasegenericapares(CChar("D"), "Digitado"))
            _lista.Add(New clasegenericapares(CChar("N"), "Anulado"))
            Return _lista
        End Function
        Public Shared Function listaPeriodoMes() As Generic.List(Of clasegenericapares)
            Dim _lista As New Generic.List(Of clasegenericapares)
            _lista.Add(New clasegenericapares(CChar("P"), "Primera Quincena"))
            _lista.Add(New clasegenericapares(CChar("S"), "Segunda Quincena"))
            Return _lista
        End Function
        Public Shared Function listaTipoWorkFlow() As Generic.List(Of clasegenericapares)
            Dim _lista As New Generic.List(Of clasegenericapares)
            _lista.Add(New clasegenericapares(("STE"), "Paso a paso"))
            _lista.Add(New clasegenericapares(("BRO"), "Todos a la vez"))
            Return _lista
        End Function
#End Region

        

        Public Shared Function ImageToByteArray(imageIn As System.Drawing.Image) As Byte()

            Dim ms As MemoryStream = New MemoryStream
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Return ms.ToArray()
        End Function
        Public Shared Function ByteArrayToImage(bytearrayin As Byte()) As Image
            Dim ms As MemoryStream = New MemoryStream(bytearrayin)
            Return Image.FromStream(ms)
        End Function

    End Class
End Namespace

