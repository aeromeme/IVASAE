<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RPT_LIBRO_IVA_EXPO
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblnit = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblnrc = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblsubtitulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilbltitulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilbldelno = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblalno = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblexportaciones = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblnosujeta = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblexentas = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilbldia = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.BindingSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel7, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1})
        Me.Detail.Dpi = 254!
        Me.Detail.HeightF = 51!
        Me.Detail.KeepTogether = true
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ID")})
        Me.XrLabel7.Dpi = 254!
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 8!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(79.99998!, 50!)
        Me.XrLabel7.StylePriority.UseFont = false
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel7.Summary = XrSummary1
        Me.XrLabel7.Text = "XrLabel7"
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DS_CLIENTE")})
        Me.XrLabel4.Dpi = 254!
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 8!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(603.9999!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(746.0001!, 50!)
        Me.XrLabel4.StylePriority.UseFont = false
        Me.XrLabel4.Text = "XrLabel4"
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_TOTAL", "{0:n2}")})
        Me.XrLabel3.Dpi = 254!
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 8!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(1370!, 0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(250.0001!, 50!)
        Me.XrLabel3.StylePriority.UseFont = false
        Me.XrLabel3.StylePriority.UseTextAlignment = false
        Me.XrLabel3.Text = "XrLabel3"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FE_FECHA", "{0:dd/MM/yyyy}")})
        Me.XrLabel2.Dpi = 254!
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 8!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(180!, 0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(150!, 50!)
        Me.XrLabel2.StylePriority.UseFont = false
        Me.XrLabel2.Text = "XrLabel2"
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CVE_DOC")})
        Me.XrLabel1.Dpi = 254!
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 8!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(349.9999!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(254!, 50!)
        Me.XrLabel1.StylePriority.UseFont = false
        Me.XrLabel1.Text = "XrLabel1"
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10, Me.XrLabel9, Me.uilblnit, Me.uilblnrc, Me.uilblsubtitulo, Me.uilbltitulo, Me.uilbldelno, Me.uilblalno, Me.uilblexportaciones, Me.uilblnosujeta, Me.uilblexentas, Me.uilbldia})
        Me.TopMargin.Dpi = 254!
        Me.TopMargin.HeightF = 910!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.Dpi = 254!
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 8!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(0!, 668.6243!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(92.60432!, 58.42004!)
        Me.XrLabel10.StylePriority.UseFont = false
        Me.XrLabel10.Text = "NIT:"
        '
        'XrLabel9
        '
        Me.XrLabel9.Dpi = 254!
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 8!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0!, 596.75!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(195.7918!, 58.4201!)
        Me.XrLabel9.StylePriority.UseFont = false
        Me.XrLabel9.Text = "No. de Reg.:"
        '
        'uilblnit
        '
        Me.uilblnit.Dpi = 254!
        Me.uilblnit.Font = New System.Drawing.Font("Times New Roman", 8!, System.Drawing.FontStyle.Bold)
        Me.uilblnit.LocationFloat = New DevExpress.Utils.PointFloat(92.604!, 668.6243!)
        Me.uilblnit.Name = "uilblnit"
        Me.uilblnit.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblnit.SizeF = New System.Drawing.SizeF(247.771!, 58.42004!)
        Me.uilblnit.StylePriority.UseFont = false
        Me.uilblnit.Text = " 0210-080290-101-3"
        '
        'uilblnrc
        '
        Me.uilblnrc.Dpi = 254!
        Me.uilblnrc.Font = New System.Drawing.Font("Times New Roman", 8!, System.Drawing.FontStyle.Bold)
        Me.uilblnrc.LocationFloat = New DevExpress.Utils.PointFloat(195.7915!, 596.7499!)
        Me.uilblnrc.Name = "uilblnrc"
        Me.uilblnrc.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblnrc.SizeF = New System.Drawing.SizeF(144.5835!, 58.42004!)
        Me.uilblnrc.StylePriority.UseFont = false
        Me.uilblnrc.Text = "3783-4"
        '
        'uilblsubtitulo
        '
        Me.uilblsubtitulo.Dpi = 254!
        Me.uilblsubtitulo.Font = New System.Drawing.Font("Times New Roman", 8!, System.Drawing.FontStyle.Bold)
        Me.uilblsubtitulo.LocationFloat = New DevExpress.Utils.PointFloat(525.2291!, 702.7949!)
        Me.uilblsubtitulo.Name = "uilblsubtitulo"
        Me.uilblsubtitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblsubtitulo.SizeF = New System.Drawing.SizeF(719.6667!, 58.41998!)
        Me.uilblsubtitulo.StylePriority.UseFont = false
        Me.uilblsubtitulo.StylePriority.UseTextAlignment = false
        Me.uilblsubtitulo.Text = "Para el mes de"
        Me.uilblsubtitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'uilbltitulo
        '
        Me.uilbltitulo.Dpi = 254!
        Me.uilbltitulo.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold)
        Me.uilbltitulo.LocationFloat = New DevExpress.Utils.PointFloat(349.9996!, 596.7499!)
        Me.uilbltitulo.Name = "uilbltitulo"
        Me.uilbltitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilbltitulo.SizeF = New System.Drawing.SizeF(1130.729!, 106.045!)
        Me.uilbltitulo.StylePriority.UseFont = false
        Me.uilbltitulo.StylePriority.UseTextAlignment = false
        Me.uilbltitulo.Text = "DETALLE DE LAS EXPORTACIONES DEL PERIODO"
        Me.uilbltitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'uilbldelno
        '
        Me.uilbldelno.Dpi = 254!
        Me.uilbldelno.Font = New System.Drawing.Font("Times New Roman", 8!, System.Drawing.FontStyle.Bold)
        Me.uilbldelno.LocationFloat = New DevExpress.Utils.PointFloat(179.9997!, 838.9628!)
        Me.uilbldelno.Name = "uilbldelno"
        Me.uilbldelno.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilbldelno.SizeF = New System.Drawing.SizeF(150!, 58.41998!)
        Me.uilbldelno.StylePriority.UseFont = false
        Me.uilbldelno.Text = "Fecha"
        '
        'uilblalno
        '
        Me.uilblalno.Dpi = 254!
        Me.uilblalno.Font = New System.Drawing.Font("Times New Roman", 8!, System.Drawing.FontStyle.Bold)
        Me.uilblalno.LocationFloat = New DevExpress.Utils.PointFloat(349.9996!, 838.9628!)
        Me.uilblalno.Name = "uilblalno"
        Me.uilblalno.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblalno.SizeF = New System.Drawing.SizeF(250!, 58.42001!)
        Me.uilblalno.StylePriority.UseFont = false
        Me.uilblalno.Text = "Fact No."
        '
        'uilblexportaciones
        '
        Me.uilblexportaciones.Dpi = 254!
        Me.uilblexportaciones.Font = New System.Drawing.Font("Times New Roman", 8!, System.Drawing.FontStyle.Bold)
        Me.uilblexportaciones.LocationFloat = New DevExpress.Utils.PointFloat(599.9999!, 839.8092!)
        Me.uilblexportaciones.Name = "uilblexportaciones"
        Me.uilblexportaciones.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblexportaciones.SizeF = New System.Drawing.SizeF(750!, 58.41998!)
        Me.uilblexportaciones.StylePriority.UseFont = false
        Me.uilblexportaciones.StylePriority.UseTextAlignment = false
        Me.uilblexportaciones.Text = "Cliente"
        Me.uilblexportaciones.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'uilblnosujeta
        '
        Me.uilblnosujeta.Dpi = 254!
        Me.uilblnosujeta.Font = New System.Drawing.Font("Times New Roman", 8!, System.Drawing.FontStyle.Bold)
        Me.uilblnosujeta.LocationFloat = New DevExpress.Utils.PointFloat(1370!, 838.9628!)
        Me.uilblnosujeta.Name = "uilblnosujeta"
        Me.uilblnosujeta.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblnosujeta.SizeF = New System.Drawing.SizeF(250!, 58.41998!)
        Me.uilblnosujeta.StylePriority.UseFont = false
        Me.uilblnosujeta.StylePriority.UseTextAlignment = false
        Me.uilblnosujeta.Text = "Valor Factura US$"
        Me.uilblnosujeta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'uilblexentas
        '
        Me.uilblexentas.Dpi = 254!
        Me.uilblexentas.Font = New System.Drawing.Font("Times New Roman", 8!, System.Drawing.FontStyle.Bold)
        Me.uilblexentas.LocationFloat = New DevExpress.Utils.PointFloat(1689.417!, 767.1843!)
        Me.uilblexentas.Name = "uilblexentas"
        Me.uilblexentas.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilblexentas.SizeF = New System.Drawing.SizeF(198.9998!, 130.1984!)
        Me.uilblexentas.StylePriority.UseFont = false
        Me.uilblexentas.StylePriority.UseTextAlignment = false
        Me.uilblexentas.Text = "No. Declaracion Mercancia"
        Me.uilblexentas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'uilbldia
        '
        Me.uilbldia.Dpi = 254!
        Me.uilbldia.Font = New System.Drawing.Font("Times New Roman", 8!, System.Drawing.FontStyle.Bold)
        Me.uilbldia.LocationFloat = New DevExpress.Utils.PointFloat(0!, 838.9628!)
        Me.uilbldia.Name = "uilbldia"
        Me.uilbldia.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.uilbldia.SizeF = New System.Drawing.SizeF(80!, 58.41998!)
        Me.uilbldia.StylePriority.UseFont = false
        Me.uilbldia.Text = "Corr."
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254!
        Me.BottomMargin.HeightF = 100!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(IVASAE.IVA.V_IVA_DETALLE_VENTA)
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.XrLine1, Me.XrLabel8, Me.XrLabel6, Me.XrLabel5})
        Me.ReportFooter.Dpi = 254!
        Me.ReportFooter.HeightF = 555.625!
        Me.ReportFooter.KeepTogether = true
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLine2
        '
        Me.XrLine2.Dpi = 254!
        Me.XrLine2.LineWidth = 3
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(1370!, 69.00338!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(250!, 18.73249!)
        '
        'XrLine1
        '
        Me.XrLine1.Dpi = 254!
        Me.XrLine1.LineWidth = 3
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(435.6254!, 346.4984!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(904.8748!, 58.42001!)
        '
        'XrLabel8
        '
        Me.XrLabel8.Dpi = 254!
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 8!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(435.6254!, 404.9184!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(904.8748!, 58.42004!)
        Me.XrLabel8.StylePriority.UseFont = false
        Me.XrLabel8.StylePriority.UseTextAlignment = false
        Me.XrLabel8.Text = "Nombre y Firma del Responsable"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.Dpi = 254!
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(1096!, 10.58333!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(254!, 58.42!)
        Me.XrLabel6.StylePriority.UseFont = false
        Me.XrLabel6.Text = "Total"
        '
        'XrLabel5
        '
        Me.XrLabel5.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.XrLabel5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_TOTAL")})
        Me.XrLabel5.Dpi = 254!
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 8!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(1370!, 10.58333!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(250.0001!, 58.42!)
        Me.XrLabel5.StylePriority.UseBorderDashStyle = false
        Me.XrLabel5.StylePriority.UseBorders = false
        Me.XrLabel5.StylePriority.UseFont = false
        Me.XrLabel5.StylePriority.UseTextAlignment = false
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel5.Summary = XrSummary2
        Me.XrLabel5.Text = "XrLabel5"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'RPT_LIBRO_IVA_EXPO
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter})
        Me.DataSource = Me.BindingSource1
        Me.Dpi = 254!
        Me.Margins = New System.Drawing.Printing.Margins(140, 120, 910, 100)
        Me.PageHeight = 2794
        Me.PageWidth = 2159
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
    Friend WithEvents uilblnit As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblnrc As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblsubtitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilbltitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilbldelno As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblalno As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblexportaciones As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblnosujeta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblexentas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilbldia As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
End Class
