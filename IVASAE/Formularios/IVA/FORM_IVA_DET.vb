Imports IVASAE.Utilidades
Imports IVASAE.IVA
Imports System.Text
Public Class FORM_IVA_DET
    Implements InterfazForms
    Public nmmes As Integer
    Public nmanio As Integer
    Private varlista As Generic.List(Of IVA_DET_987_CLIENTES_M200)
    Private varlistaClientes As Generic.List(Of IVA_DET_987_CLIENTES)
    Private varlistaProveedores As Generic.List(Of IVA_DET_987_PROVEEDORES)
    Private varlistaProveedoresExclu As Generic.List(Of IVA_DET_987_PROVEEDOR_EXCLU_IVA)
    Private varlistaProveedoresExtranjeros As Generic.List(Of IVA_DET_987_PROVEEDOR_EXTRANJERO)
    Private varlistaF930 As Generic.List(Of IVA_DET_930)
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

    End Sub

    Public Sub Consultar() Implements InterfazForms.Consultar
        Try
            _datasistema.ConectarIVA()
            varlista = (From u In _datasistema.ContextoIVA.IVA_DET_987_CLIENTES_M200
                    Select u Where u.NM_ANIO = nmanio And u.NM_MES = nmmes).ToList
            UIGRIDCONTROLF987M200.DataSource = varlista




            varlistaClientes = (From u In _datasistema.ContextoIVA.IVA_DET_987_CLIENTES
                    Select u Where u.NM_ANIO = nmanio And u.NM_MES = nmmes).ToList
            UIGRIDCONTROLCLIENTES.DataSource = varlistaClientes

            varlistaProveedores = (From u In _datasistema.ContextoIVA.IVA_DET_987_PROVEEDORES
                    Select u Where u.NM_ANIO = nmanio And u.NM_MES = nmmes).ToList
            UIGRIDCONTROLPROVEEDORES.DataSource = varlistaProveedores

            varlistaProveedoresExclu = (From u In _datasistema.ContextoIVA.IVA_DET_987_PROVEEDOR_EXCLU_IVA
                    Select u Where u.NM_ANIO = nmanio And u.NM_MES = nmmes).ToList
            UIGRIDCONTROLEXCLUIDO.DataSource = varlistaProveedoresExclu

            varlistaProveedoresExtranjeros = (From u In _datasistema.ContextoIVA.IVA_DET_987_PROVEEDOR_EXTRANJERO
                    Select u Where u.NM_ANIO = nmanio And u.NM_MES = nmmes).ToList
            UIGRIDCONTROLEXTRANJERO.DataSource = varlistaProveedoresExtranjeros


            varlistaF930 = (From u In _datasistema.ContextoIVA.IVA_DET_930
                  Select u Where u.NM_ANIO = nmanio And u.NM_MES = nmmes).ToList
            UIGRIDCONTROLF930.DataSource = varlistaF930



            'llenarcombos()
            desbindear()
            bindear()



            'If varlista.Count = 0 Then
            '    Limpiar()
            'End If
            'ActualizarInterfaz()
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try
    End Sub

    Public Sub desbindear() Implements InterfazForms.desbindear

    End Sub

    Public Sub Eliminar() Implements InterfazForms.Eliminar

    End Sub

    Public Sub Imprimir() Implements InterfazForms.Imprimir

    End Sub

    Public Sub Insertar() Implements InterfazForms.Insertar

    End Sub

    Public Sub Limpiar() Implements InterfazForms.Limpiar

    End Sub

    Public Sub Modificar() Implements InterfazForms.Modificar

    End Sub

    Private Sub FORM_IVA_DET_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consultar()
        uitabmaster.SelectedTabPage = uilytfactm200
    End Sub

#Region "METODOS ESPECIALES"
    Private Sub FORM_INGR_PROD_RPT_RESU_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Principal.actualizarInterfaz(1)

    End Sub

    Private Sub FORM_INGR_PROD_RPT_RESU_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Principal.actualizarInterfaz(3)
        Principal.actualizarInterfaz(6)
    End Sub
#End Region

    Private Sub ExportarAExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarAExcelToolStripMenuItem.Click

        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        Dim s As ContextMenuStrip = item.Owner
        'MessageBox.Show(s.SourceControl.Name)
        If UIDIALOGO_GUARDAREXCEL.ShowDialog = DialogResult.OK Then
            Select Case s.SourceControl.Name

                Case "UIGRIDCONTROLF987M200"
                    UIGRIDVIEWF987M200.ExportToXlsx(UIDIALOGO_GUARDAREXCEL.FileName)
                Case "UIGRIDCONTROLCLIENTES"
                    UIGRIDVIEWCLIENTES.ExportToXlsx(UIDIALOGO_GUARDAREXCEL.FileName)
                Case "UIGRIDCONTROLPROVEEDORES"
                    UIGRIDVIEWPROVEEDORES.ExportToXlsx(UIDIALOGO_GUARDAREXCEL.FileName)
                Case "UIGRIDCONTROLEXCLUIDO"
                    UIGRIDVIEWEXCLUIDO.ExportToXlsx(UIDIALOGO_GUARDAREXCEL.FileName)
                Case "UIGRIDCONTROLEXTRANJERO"
                    UIGRIDVIEWEXTRANJERO.ExportToXlsx(UIDIALOGO_GUARDAREXCEL.FileName)
                Case "UIGRIDCONTROLF930"
                    UIGRIDVIEWF930.ExportToXlsx(UIDIALOGO_GUARDAREXCEL.FileName)
            End Select

        End If



    End Sub

    Private Sub UIBR_IMPORTAR_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UIBR_IMPORTAR.ItemClick
        Try
            If (MetodosForm.Preguntar("¿Esta seguro de procesar los exportables DET?")) Then
                Principal.MostrarEspere(True)
                Dim msj As String = ""
                Dim nmerror As Integer = 0
                _datasistema.ContextoIVA.PR_IVA_GENE_DET(nmanio, nmmes, nmerror, msj)
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

    Private Sub ExpoTXT_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ExpoTXT.ItemClick
        If UIDIALOGOTEXT.ShowDialog = DialogResult.OK Then
            escribirArchivo(UIDIALOGOTEXT.FileName)
        End If

    End Sub

    Public Sub escribirArchivo(rutaFile As String)
        Try

            Dim ascii As Encoding = Encoding.ASCII
            Dim utf8 As Encoding = Encoding.UTF8
            
            Dim newString As String

            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(rutaFile, False, System.Text.Encoding.Default)
            'MsgBox(file.Encoding.ToString())


            Select Case uitabmaster.SelectedTabPageName
                Case uilytfactm200.Name
                    varlista = (From u In _datasistema.ContextoIVA.IVA_DET_987_CLIENTES_M200
                        Select u Where u.NM_ANIO = nmanio And u.NM_MES = nmmes).ToList
                    For Each item As IVA_DET_987_CLIENTES_M200 In varlista
                        'unicodeString = item.FECHA + item.REGISTROS + item.MONTO_TOTAL + item.IVA_TOTAL + item.ANIO
                        'bytes = utf8.GetBytes(unicodeString)
                        'newString = ascii.GetString(bytes)
                        newString = item.FECHA + item.REGISTROS + item.MONTO_TOTAL + item.IVA_TOTAL + item.ANIO

                        file.WriteLine(newString)
                    Next
                Case uilytclientes.Name
                    varlistaClientes = (From u In _datasistema.ContextoIVA.IVA_DET_987_CLIENTES
                      Select u Where u.NM_ANIO = nmanio And u.NM_MES = nmmes).ToList
                    For Each item As IVA_DET_987_CLIENTES In varlistaClientes
                        'unicodeString = item.MES + item.DOCUMENTO_ID + item.NUM_DOC_ID + item.FECHA + item.TIPO_DOC + item.NUM_DOC + item.MONTO_TOTAL + item.IVA_TOTAL + item.ANIO
                        'bytes = utf8.GetBytes(unicodeString)
                        'newString = ascii.GetString(bytes)
                        newString = item.MES + item.DOCUMENTO_ID + item.NUM_DOC_ID + item.FECHA + item.TIPO_DOC + item.NUM_DOC + item.MONTO_TOTAL + item.IVA_TOTAL + item.ANIO

                        file.WriteLine(newString)
                    Next
                Case uilytproveedores.Name
                    varlistaProveedores = (From u In _datasistema.ContextoIVA.IVA_DET_987_PROVEEDORES
                   Select u Where u.NM_ANIO = nmanio And u.NM_MES = nmmes).ToList
                    For Each item As IVA_DET_987_PROVEEDORES In varlistaProveedores
                        'unicodeString = item.MES + item.DOCUMENTO_ID + item.NUM_DOC_ID + item.FECHA + item.TIPO_DOC + item.NUM_DOC + item.MONTO_TOTAL + item.IVA_TOTAL + item.ANIO
                        'bytes = utf8.GetBytes(unicodeString)
                        'newString = ascii.GetString(bytes)
                        newString = item.MES + item.DOCUMENTO_ID + item.NUM_DOC_ID + item.FECHA + item.TIPO_DOC + item.NUM_DOC + item.MONTO_TOTAL + item.IVA_TOTAL + item.ANIO
                        file.WriteLine(newString)
                    Next
                Case uilytexcluido.Name
                    varlistaProveedoresExclu = (From u In _datasistema.ContextoIVA.IVA_DET_987_PROVEEDOR_EXCLU_IVA
                    Select u Where u.NM_ANIO = nmanio And u.NM_MES = nmmes).ToList
                    For Each item As IVA_DET_987_PROVEEDOR_EXCLU_IVA In varlistaProveedoresExclu
                        'unicodeString = item.MES + item.DOCUMENTO_ID + item.NUM_DOC_ID + item.FECHA + item.TIPO_DOC + item.NUM_DOC + item.MONTO_TOTAL + item.DIRECCION + item.ANIO
                        'bytes = utf8.GetBytes(unicodeString)
                        'newString = ascii.GetString(bytes)
                        newString = item.MES + item.DOCUMENTO_ID + item.NUM_DOC_ID + item.FECHA + item.TIPO_DOC + item.NUM_DOC + item.MONTO_TOTAL + item.DIRECCION + item.ANIO
                        file.WriteLine(newString)
                    Next
                Case uilytextranjero.Name
                    varlistaProveedoresExtranjeros = (From u In _datasistema.ContextoIVA.IVA_DET_987_PROVEEDOR_EXTRANJERO
                   Select u Where u.NM_ANIO = nmanio And u.NM_MES = nmmes).ToList
                    For Each item As IVA_DET_987_PROVEEDOR_EXTRANJERO In varlistaProveedoresExtranjeros
                        'unicodeString = item.MES + item.CONCEPTO + item.DOCUMENTO_ID + item.NUM_DOC_ID + item.NOMBRE_PROVEEDOR + item.REPRESENTANTE + item.FECHA + item.TIPO_DOC + item.NUM_DOC + item.MONTO_TOTAL + item.IVA_TOTAL + item.ANIO
                        'bytes = utf8.GetBytes(unicodeString)
                        'newString = ascii.GetString(bytes)
                        newString = item.MES + item.CONCEPTO + item.DOCUMENTO_ID + item.NUM_DOC_ID + item.NOMBRE_PROVEEDOR + item.REPRESENTANTE + item.FECHA + item.TIPO_DOC + item.NUM_DOC + item.MONTO_TOTAL + item.IVA_TOTAL + item.ANIO
                        file.WriteLine(newString)
                    Next
                Case uilytf930.Name
                    varlistaF930 = (From u In _datasistema.ContextoIVA.IVA_DET_930
                 Select u Where u.NM_ANIO = nmanio And u.NM_MES = nmmes).ToList
                    For Each item As IVA_DET_930 In varlistaF930
                        'unicodeString = item.NOMBRE + item.NIT + item.CALIDAD + item.MODALIDAD + item.COD_DOC + item.NUM_DOC + item.MONTO_SUJETO + item.RETENCION + item.PERIODO
                        'bytes = utf8.GetBytes(unicodeString)
                        'newString = ascii.GetString(bytes)
                        'MsgBox(item.NOMBRE.GetTypeCode().ToString)
                        '' ascii.item.NOMBRE()
                        newString = item.NOMBRE + item.NIT + item.CALIDAD + item.MODALIDAD + item.COD_DOC + item.NUM_DOC + item.MONTO_SUJETO + item.RETENCION + item.PERIODO
                        file.WriteLine(newString)
                    Next

            End Select


            'file.WriteLine("Here is the first string 2.")
            MetodosForm.MensajeInfoDefault("Archivo exportado correctamente")
            file.Close()
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault(ex.Message)
        End Try

       
    End Sub
End Class
