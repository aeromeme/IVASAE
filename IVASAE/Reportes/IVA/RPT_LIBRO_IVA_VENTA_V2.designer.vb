<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RPT_LIBRO_IVA_VENTA_V2
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.uilblsubtitulo_MES = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblnrc = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblnit = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblnombreContrib = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblpercepcion = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblIVA = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblsubtotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblgravadas = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblExentas = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblventas = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblbncr = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblcliente = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilbldocumento = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilbldia = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblcorr = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilbltitulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblsubtitulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblfolio = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblnopag = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.NM_FACTURACION = New DevExpress.XtraReports.UI.CalculatedField()
        Me.FLG_MOSTRAR_ENCABEZADO = New DevExpress.XtraReports.Parameters.Parameter()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.acreditacion = New DevExpress.XtraReports.Parameters.Parameter()
        Me.contador = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel34 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.BindingSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.XrLabel10})
        Me.Detail.Dpi = 254!
        Me.Detail.HeightF = 52!
        Me.Detail.KeepTogether = true
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_RETENCION", "{0:n2}")})
        Me.XrLabel9.Dpi = 254!
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(1887.643!, 0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(141.3567!, 50!)
        Me.XrLabel9.StylePriority.UseFont = false
        Me.XrLabel9.StylePriority.UseTextAlignment = false
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_IVA", "{0:n2}")})
        Me.XrLabel8.Dpi = 254!
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(1720!, 0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(145.5203!, 50!)
        Me.XrLabel8.StylePriority.UseFont = false
        Me.XrLabel8.StylePriority.UseTextAlignment = false
        Me.XrLabel8.Text = "XrLabel8"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_GRAVADO", "{0:n2}")})
        Me.XrLabel7.Dpi = 254!
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(1375.646!, 0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(124.354!, 50!)
        Me.XrLabel7.StylePriority.UseFont = false
        Me.XrLabel7.StylePriority.UseTextAlignment = false
        Me.XrLabel7.Text = "XrLabel7"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_EXENTO", "{0:n2}")})
        Me.XrLabel6.Dpi = 254!
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(1200.896!, 0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(109.1039!, 50!)
        Me.XrLabel6.StylePriority.UseFont = false
        Me.XrLabel6.StylePriority.UseTextAlignment = false
        Me.XrLabel6.Text = "XrLabel6"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DS_NRF")})
        Me.XrLabel5.Dpi = 254!
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(950.0001!, 0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(167.0419!, 50!)
        Me.XrLabel5.StylePriority.UseFont = false
        Me.XrLabel5.Text = "XrLabel5"
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DS_CLIENTE")})
        Me.XrLabel4.Dpi = 254!
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(419.7292!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(530.2708!, 50!)
        Me.XrLabel4.StylePriority.UseFont = false
        Me.XrLabel4.Text = "XrLabel4"
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CVE_DOC")})
        Me.XrLabel3.Dpi = 254!
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(150.3125!, 0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(259.4166!, 50!)
        Me.XrLabel3.StylePriority.UseFont = false
        Me.XrLabel3.Text = "XrLabel3"
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FECHA", "{0:dd}")})
        Me.XrLabel2.Dpi = 254!
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(78.52081!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(60!, 50!)
        Me.XrLabel2.StylePriority.UseFont = false
        Me.XrLabel2.StylePriority.UseTextAlignment = false
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DS_CORR")})
        Me.XrLabel1.Dpi = 254!
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(78.52084!, 50!)
        Me.XrLabel1.StylePriority.UseFont = false
        Me.XrLabel1.StylePriority.UseTextAlignment = false
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_FACTURACION", "{0:n2}")})
        Me.XrLabel10.Dpi = 254!
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(1574.479!, 0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(115.5208!, 50!)
        Me.XrLabel10.StylePriority.UseFont = false
        Me.XrLabel10.StylePriority.UseTextAlignment = false
        Me.XrLabel10.Text = "XrLabel10"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.uilblsubtitulo_MES, Me.uilblnrc, Me.uilblnit, Me.uilblnombreContrib, Me.uilblpercepcion, Me.uilblIVA, Me.uilblsubtotal, Me.uilblgravadas, Me.uilblExentas, Me.uilblventas, Me.uilblbncr, Me.uilblcliente, Me.uilbldocumento, Me.uilbldia, Me.uilblcorr, Me.uilbltitulo, Me.uilblsubtitulo, Me.uilblfolio, Me.uilblnopag})
        Me.TopMargin.Dpi = 254!
        Me.TopMargin.HeightF = 530!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'uilblsubtitulo_MES
        '
        Me.uilblsubtitulo_MES.Dpi = 254!
        Me.uilblsubtitulo_MES.Font = New System.Drawing.Font("Times New Roman", 7!, System.Drawing.FontStyle.Bold)
        Me.uilblsubtitulo_MES.LocationFloat = New DevExpress.Utils.PointFloat(713.1055!, 190.1009!)
        Me.uilblsubtitulo_MES.Name = "uilblsubtitulo_MES"
        Me.uilblsubtitulo_MES.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblsubtitulo_MES.SizeF = New System.Drawing.SizeF(719.6667!, 39.89915!)
        Me.uilblsubtitulo_MES.StylePriority.UseFont = false
        Me.uilblsubtitulo_MES.StylePriority.UseTextAlignment = false
        Me.uilblsubtitulo_MES.Text = "Para el mes de"
        Me.uilblsubtitulo_MES.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'uilblnrc
        '
        Me.uilblnrc.Dpi = 254!
        Me.uilblnrc.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.uilblnrc.LocationFloat = New DevExpress.Utils.PointFloat(0!, 138.8004!)
        Me.uilblnrc.Name = "uilblnrc"
        Me.uilblnrc.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblnrc.SizeF = New System.Drawing.SizeF(460.375!, 58.42001!)
        Me.uilblnrc.StylePriority.UseFont = false
        Me.uilblnrc.Text = "No DE REGISTRO  45417-6"
        '
        'uilblnit
        '
        Me.uilblnit.Dpi = 254!
        Me.uilblnit.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.uilblnit.LocationFloat = New DevExpress.Utils.PointFloat(0!, 197.2204!)
        Me.uilblnit.Name = "uilblnit"
        Me.uilblnit.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblnit.SizeF = New System.Drawing.SizeF(460.375!, 58.42001!)
        Me.uilblnit.StylePriority.UseFont = false
        Me.uilblnit.Text = "NIT 0210-080290-101-3"
        '
        'uilblnombreContrib
        '
        Me.uilblnombreContrib.Dpi = 254!
        Me.uilblnombreContrib.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.uilblnombreContrib.LocationFloat = New DevExpress.Utils.PointFloat(0!, 67.36289!)
        Me.uilblnombreContrib.Name = "uilblnombreContrib"
        Me.uilblnombreContrib.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblnombreContrib.SizeF = New System.Drawing.SizeF(874.607!, 44.97916!)
        Me.uilblnombreContrib.StylePriority.UseFont = false
        Me.uilblnombreContrib.Text = "Asociación de Trabajador de Servicios Profesionales de Occidente"
        '
        'uilblpercepcion
        '
        Me.uilblpercepcion.Dpi = 254!
        Me.uilblpercepcion.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.uilblpercepcion.LocationFloat = New DevExpress.Utils.PointFloat(1887.643!, 429.789!)
        Me.uilblpercepcion.Name = "uilblpercepcion"
        Me.uilblpercepcion.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblpercepcion.SizeF = New System.Drawing.SizeF(141.3568!, 58.41998!)
        Me.uilblpercepcion.StylePriority.UseFont = false
        Me.uilblpercepcion.Text = "Retencion"
        '
        'uilblIVA
        '
        Me.uilblIVA.Dpi = 254!
        Me.uilblIVA.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.uilblIVA.LocationFloat = New DevExpress.Utils.PointFloat(1720!, 429.789!)
        Me.uilblIVA.Name = "uilblIVA"
        Me.uilblIVA.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblIVA.SizeF = New System.Drawing.SizeF(145.5208!, 58.41998!)
        Me.uilblIVA.StylePriority.UseFont = false
        Me.uilblIVA.Text = "IVA"
        '
        'uilblsubtotal
        '
        Me.uilblsubtotal.Dpi = 254!
        Me.uilblsubtotal.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.uilblsubtotal.LocationFloat = New DevExpress.Utils.PointFloat(1598.833!, 431.58!)
        Me.uilblsubtotal.Name = "uilblsubtotal"
        Me.uilblsubtotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblsubtotal.SizeF = New System.Drawing.SizeF(91.16699!, 58.41995!)
        Me.uilblsubtotal.StylePriority.UseFont = false
        Me.uilblsubtotal.Text = "Ventas"
        '
        'uilblgravadas
        '
        Me.uilblgravadas.Dpi = 254!
        Me.uilblgravadas.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.uilblgravadas.LocationFloat = New DevExpress.Utils.PointFloat(1375.646!, 431.58!)
        Me.uilblgravadas.Name = "uilblgravadas"
        Me.uilblgravadas.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblgravadas.SizeF = New System.Drawing.SizeF(124.354!, 58.41995!)
        Me.uilblgravadas.StylePriority.UseFont = false
        Me.uilblgravadas.Text = "Gravadas"
        '
        'uilblExentas
        '
        Me.uilblExentas.Dpi = 254!
        Me.uilblExentas.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.uilblExentas.LocationFloat = New DevExpress.Utils.PointFloat(1200.896!, 429.79!)
        Me.uilblExentas.Name = "uilblExentas"
        Me.uilblExentas.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblExentas.SizeF = New System.Drawing.SizeF(109.1039!, 58.41995!)
        Me.uilblExentas.StylePriority.UseFont = false
        Me.uilblExentas.Text = "Exentas"
        '
        'uilblventas
        '
        Me.uilblventas.Dpi = 254!
        Me.uilblventas.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.uilblventas.LocationFloat = New DevExpress.Utils.PointFloat(1200.896!, 363.3259!)
        Me.uilblventas.Name = "uilblventas"
        Me.uilblventas.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblventas.SizeF = New System.Drawing.SizeF(828.104!, 58.41998!)
        Me.uilblventas.StylePriority.UseFont = false
        Me.uilblventas.StylePriority.UseTextAlignment = false
        Me.uilblventas.Text = "OPERACIONES DE VENTAS PROPIAS"
        Me.uilblventas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'uilblbncr
        '
        Me.uilblbncr.Dpi = 254!
        Me.uilblbncr.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.uilblbncr.LocationFloat = New DevExpress.Utils.PointFloat(950.0001!, 363.3257!)
        Me.uilblbncr.Name = "uilblbncr"
        Me.uilblbncr.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblbncr.SizeF = New System.Drawing.SizeF(167.0416!, 58.42001!)
        Me.uilblbncr.StylePriority.UseFont = false
        Me.uilblbncr.Text = "N.C.R."
        '
        'uilblcliente
        '
        Me.uilblcliente.Dpi = 254!
        Me.uilblcliente.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.uilblcliente.LocationFloat = New DevExpress.Utils.PointFloat(419.7292!, 363.3259!)
        Me.uilblcliente.Name = "uilblcliente"
        Me.uilblcliente.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblcliente.SizeF = New System.Drawing.SizeF(530.2708!, 58.42004!)
        Me.uilblcliente.StylePriority.UseFont = false
        Me.uilblcliente.Text = "Cliente"
        '
        'uilbldocumento
        '
        Me.uilbldocumento.Dpi = 254!
        Me.uilbldocumento.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.uilbldocumento.LocationFloat = New DevExpress.Utils.PointFloat(150.3125!, 363.3259!)
        Me.uilbldocumento.Name = "uilbldocumento"
        Me.uilbldocumento.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilbldocumento.SizeF = New System.Drawing.SizeF(259.4166!, 58.41998!)
        Me.uilbldocumento.StylePriority.UseFont = false
        Me.uilbldocumento.Text = "Documento"
        '
        'uilbldia
        '
        Me.uilbldia.Dpi = 254!
        Me.uilbldia.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.uilbldia.LocationFloat = New DevExpress.Utils.PointFloat(78.52081!, 363.3259!)
        Me.uilbldia.Name = "uilbldia"
        Me.uilbldia.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilbldia.SizeF = New System.Drawing.SizeF(60!, 60!)
        Me.uilbldia.StylePriority.UseFont = false
        Me.uilbldia.Text = "Día"
        '
        'uilblcorr
        '
        Me.uilblcorr.Dpi = 254!
        Me.uilblcorr.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.uilblcorr.LocationFloat = New DevExpress.Utils.PointFloat(0!, 363.3259!)
        Me.uilblcorr.Name = "uilblcorr"
        Me.uilblcorr.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblcorr.SizeF = New System.Drawing.SizeF(78.52084!, 58.41998!)
        Me.uilblcorr.StylePriority.UseFont = false
        Me.uilblcorr.Text = "No."
        '
        'uilbltitulo
        '
        Me.uilbltitulo.Dpi = 254!
        Me.uilbltitulo.Font = New System.Drawing.Font("Times New Roman", 10!, System.Drawing.FontStyle.Bold)
        Me.uilbltitulo.LocationFloat = New DevExpress.Utils.PointFloat(546.4169!, 112.3421!)
        Me.uilbltitulo.Name = "uilbltitulo"
        Me.uilbltitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilbltitulo.SizeF = New System.Drawing.SizeF(1086.168!, 53.12836!)
        Me.uilbltitulo.StylePriority.UseFont = false
        Me.uilbltitulo.StylePriority.UseTextAlignment = false
        Me.uilbltitulo.Text = "LIBRO DE VENTAS A CONTRIBUYENTES"
        Me.uilbltitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'uilblsubtitulo
        '
        Me.uilblsubtitulo.Dpi = 254!
        Me.uilblsubtitulo.Font = New System.Drawing.Font("Times New Roman", 8!, System.Drawing.FontStyle.Bold)
        Me.uilblsubtitulo.LocationFloat = New DevExpress.Utils.PointFloat(960!, 230!)
        Me.uilblsubtitulo.Name = "uilblsubtitulo"
        Me.uilblsubtitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblsubtitulo.SizeF = New System.Drawing.SizeF(420.6875!, 58.41997!)
        Me.uilblsubtitulo.StylePriority.UseFont = false
        Me.uilblsubtitulo.StylePriority.UseTextAlignment = false
        Me.uilblsubtitulo.Text = "Para el mes de"
        Me.uilblsubtitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'uilblfolio
        '
        Me.uilblfolio.Dpi = 254!
        Me.uilblfolio.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.uilblfolio.LocationFloat = New DevExpress.Utils.PointFloat(1710.372!, 25.00001!)
        Me.uilblfolio.Name = "uilblfolio"
        Me.uilblfolio.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblfolio.SizeF = New System.Drawing.SizeF(161.3959!, 58.42001!)
        Me.uilblfolio.StylePriority.UseFont = false
        Me.uilblfolio.Text = "Folio No."
        '
        'uilblnopag
        '
        Me.uilblnopag.Dpi = 254!
        Me.uilblnopag.Font = New System.Drawing.Font("Times New Roman", 7!)
        Me.uilblnopag.LocationFloat = New DevExpress.Utils.PointFloat(1871.768!, 25.00001!)
        Me.uilblnopag.Name = "uilblnopag"
        Me.uilblnopag.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblnopag.PageInfo = DevExpress.XtraPrinting.PageInfo.Number
        Me.uilblnopag.SizeF = New System.Drawing.SizeF(76.72925!, 58.42001!)
        Me.uilblnopag.StylePriority.UseFont = false
        Me.uilblnopag.StylePriority.UseTextAlignment = false
        Me.uilblnopag.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254!
        Me.BottomMargin.HeightF = 100!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel31, Me.XrLabel32, Me.XrLabel33, Me.XrLabel34, Me.XrSubreport1, Me.XrLabel11, Me.XrLabel12, Me.XrLabel13, Me.XrLabel14, Me.XrLabel15})
        Me.ReportFooter.Dpi = 254!
        Me.ReportFooter.HeightF = 854.9375!
        Me.ReportFooter.KeepTogether = true
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrSubreport1
        '
        Me.XrSubreport1.Dpi = 254!
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(24.99993!, 212.7328!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ReportSource = New IVASAE.RPT_SUB_LIBRO_IVA_VENTA_V2()
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(1968!, 238.2309!)
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_EXENTO")})
        Me.XrLabel11.Dpi = 254!
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 7!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(1200.896!, 25.00001!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(109.1041!, 58.41998!)
        Me.XrLabel11.StylePriority.UseFont = false
        Me.XrLabel11.StylePriority.UseTextAlignment = false
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel11.Summary = XrSummary1
        Me.XrLabel11.Text = "XrLabel11"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_GRAVADO")})
        Me.XrLabel12.Dpi = 254!
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 7!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(1359.771!, 24.65919!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(140.2291!, 58.42001!)
        Me.XrLabel12.StylePriority.UseFont = false
        Me.XrLabel12.StylePriority.UseTextAlignment = false
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel12.Summary = XrSummary2
        Me.XrLabel12.Text = "XrLabel12"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel13
        '
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_FACTURACION")})
        Me.XrLabel13.Dpi = 254!
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 7!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(1526.855!, 25.00001!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(163.1459!, 58.41998!)
        Me.XrLabel13.StylePriority.UseFont = false
        Me.XrLabel13.StylePriority.UseTextAlignment = false
        XrSummary3.FormatString = "{0:n2}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel13.Summary = XrSummary3
        Me.XrLabel13.Text = "XrLabel13"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel14
        '
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_IVA")})
        Me.XrLabel14.Dpi = 254!
        Me.XrLabel14.Font = New System.Drawing.Font("Times New Roman", 7!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(1720!, 24.65919!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(145.52!, 58.42001!)
        Me.XrLabel14.StylePriority.UseFont = false
        Me.XrLabel14.StylePriority.UseTextAlignment = false
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel14.Summary = XrSummary4
        Me.XrLabel14.Text = "XrLabel14"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel15
        '
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_RETENCION")})
        Me.XrLabel15.Dpi = 254!
        Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 7!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(1887.643!, 25.00001!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(141.3567!, 58.42!)
        Me.XrLabel15.StylePriority.UseFont = false
        Me.XrLabel15.StylePriority.UseTextAlignment = false
        XrSummary5.FormatString = "{0:n2}"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel15.Summary = XrSummary5
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'NM_FACTURACION
        '
        Me.NM_FACTURACION.Expression = "[NM_EXENTO] + [NM_GRAVADO]"
        Me.NM_FACTURACION.Name = "NM_FACTURACION"
        '
        'FLG_MOSTRAR_ENCABEZADO
        '
        Me.FLG_MOSTRAR_ENCABEZADO.Description = "Parameter1"
        Me.FLG_MOSTRAR_ENCABEZADO.Name = "FLG_MOSTRAR_ENCABEZADO"
        Me.FLG_MOSTRAR_ENCABEZADO.ValueInfo = "N"
        Me.FLG_MOSTRAR_ENCABEZADO.Visible = false
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(IVASAE.IVA.IVA_LIBRO_VENTA_CONTRIBUYENTE)
        '
        'acreditacion
        '
        Me.acreditacion.Description = "Parameter1"
        Me.acreditacion.Name = "acreditacion"
        Me.acreditacion.Visible = false
        '
        'contador
        '
        Me.contador.Description = "Parameter1"
        Me.contador.Name = "contador"
        Me.contador.Visible = false
        '
        'XrLabel31
        '
        Me.XrLabel31.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.contador, "Text", "")})
        Me.XrLabel31.Dpi = 254!
        Me.XrLabel31.Font = New System.Drawing.Font("Times New Roman", 6!)
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(1351.393!, 699.8838!)
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(662.6072!, 58.41998!)
        Me.XrLabel31.StylePriority.UseFont = false
        Me.XrLabel31.StylePriority.UseTextAlignment = false
        Me.XrLabel31.Text = "XrLabel31"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel32
        '
        Me.XrLabel32.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.acreditacion, "Text", "")})
        Me.XrLabel32.Dpi = 254!
        Me.XrLabel32.Font = New System.Drawing.Font("Times New Roman", 6!)
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(1653.018!, 758.3037!)
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(360.9822!, 58.42004!)
        Me.XrLabel32.StylePriority.UseFont = false
        Me.XrLabel32.Text = "XrLabel32"
        '
        'XrLabel33
        '
        Me.XrLabel33.Dpi = 254!
        Me.XrLabel33.Font = New System.Drawing.Font("Times New Roman", 6!, System.Drawing.FontStyle.Bold)
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(1351.393!, 758.3037!)
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(268.6067!, 58.42004!)
        Me.XrLabel33.StylePriority.UseFont = false
        Me.XrLabel33.StylePriority.UseTextAlignment = false
        Me.XrLabel33.Text = "No. de acreditacion"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel34
        '
        Me.XrLabel34.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel34.Dpi = 254!
        Me.XrLabel34.Font = New System.Drawing.Font("Times New Roman", 6!, System.Drawing.FontStyle.Bold)
        Me.XrLabel34.LocationFloat = New DevExpress.Utils.PointFloat(1351.394!, 641.4637!)
        Me.XrLabel34.Name = "XrLabel34"
        Me.XrLabel34.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel34.SizeF = New System.Drawing.SizeF(662.6064!, 58.42004!)
        Me.XrLabel34.StylePriority.UseBorders = false
        Me.XrLabel34.StylePriority.UseFont = false
        Me.XrLabel34.StylePriority.UseTextAlignment = false
        Me.XrLabel34.Text = "F. "
        Me.XrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'RPT_LIBRO_IVA_VENTA_V2
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.NM_FACTURACION})
        Me.DataSource = Me.BindingSource1
        Me.Dpi = 254!
        Me.Margins = New System.Drawing.Printing.Margins(70, 50, 530, 100)
        Me.PageHeight = 2794
        Me.PageWidth = 2159
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.FLG_MOSTRAR_ENCABEZADO, Me.acreditacion, Me.contador})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnapGridSize = 31.75!
        Me.Version = "17.1"
        CType(Me.BindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents NM_FACTURACION As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents uilblpercepcion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblIVA As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblsubtotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblgravadas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblExentas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblventas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblbncr As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblcliente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilbldocumento As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilbldia As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblcorr As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilbltitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblsubtitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblfolio As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblnopag As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents FLG_MOSTRAR_ENCABEZADO As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents uilblnrc As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblnit As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblnombreContrib As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblsubtitulo_MES As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents acreditacion As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents contador As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel34 As DevExpress.XtraReports.UI.XRLabel
End Class
