﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RPT_LIBRO_IVA_VENTA
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
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
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
        Me.uilblnombreContrib = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblnit = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblnrc = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblfolio = New DevExpress.XtraReports.UI.XRLabel()
        Me.uilblnopag = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.NM_FACTURACION = New DevExpress.XtraReports.UI.CalculatedField()
        Me.FLG_MOSTRAR_ENCABEZADO = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 69.0!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_FACTURACION", "{0:n2}")})
        Me.XrLabel10.Dpi = 254.0!
        Me.XrLabel10.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(1902.46!, 0.0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(253.9999!, 58.42!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "XrLabel10"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_PERCEPCION", "{0:n2}")})
        Me.XrLabel9.Dpi = 254.0!
        Me.XrLabel9.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(2346.96!, 0.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(190.5!, 58.42!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "XrLabel9"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_IVA", "{0:n2}")})
        Me.XrLabel8.Dpi = 254.0!
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(2156.46!, 0.0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(190.5!, 58.42!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "XrLabel8"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel7
        '
        Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_GRAVADO", "{0:n2}")})
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(1648.46!, 0.0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(254.0!, 58.42!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "XrLabel7"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel6
        '
        Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_EXENTO", "{0:n2}")})
        Me.XrLabel6.Dpi = 254.0!
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(1394.46!, 0.0!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(254.0!, 58.42!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "XrLabel6"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DS_NRF")})
        Me.XrLabel5.Dpi = 254.0!
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(950.0!, 0.0!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(150.0!, 58.42!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "XrLabel5"
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DS_CLIENTE")})
        Me.XrLabel4.Dpi = 254.0!
        Me.XrLabel4.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(431.2708!, 0.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(470.0!, 58.42!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "XrLabel4"
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CVE_DOC")})
        Me.XrLabel3.Dpi = 254.0!
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(210.0!, 0.0!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(130.0!, 58.42!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "XrLabel3"
        '
        'XrLabel2
        '
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "FECHA", "{0:dd}")})
        Me.XrLabel2.Dpi = 254.0!
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(130.0!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(40.0!, 58.42!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "DS_CORR")})
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(60.0!, 58.42!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.uilblpercepcion, Me.uilblIVA, Me.uilblsubtotal, Me.uilblgravadas, Me.uilblExentas, Me.uilblventas, Me.uilblbncr, Me.uilblcliente, Me.uilbldocumento, Me.uilbldia, Me.uilblcorr, Me.uilbltitulo, Me.uilblsubtitulo, Me.uilblnombreContrib, Me.uilblnit, Me.uilblnrc, Me.uilblfolio, Me.uilblnopag})
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 490.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'uilblpercepcion
        '
        Me.uilblpercepcion.Dpi = 254.0!
        Me.uilblpercepcion.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.uilblpercepcion.LocationFloat = New DevExpress.Utils.PointFloat(2346.96!, 421.058!)
        Me.uilblpercepcion.Name = "uilblpercepcion"
        Me.uilblpercepcion.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.uilblpercepcion.SizeF = New System.Drawing.SizeF(190.5!, 58.41998!)
        Me.uilblpercepcion.StylePriority.UseFont = False
        Me.uilblpercepcion.Text = "Percepcion"
        '
        'uilblIVA
        '
        Me.uilblIVA.Dpi = 254.0!
        Me.uilblIVA.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.uilblIVA.LocationFloat = New DevExpress.Utils.PointFloat(2156.46!, 421.058!)
        Me.uilblIVA.Name = "uilblIVA"
        Me.uilblIVA.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.uilblIVA.SizeF = New System.Drawing.SizeF(190.5!, 58.41998!)
        Me.uilblIVA.StylePriority.UseFont = False
        Me.uilblIVA.Text = "IVA"
        '
        'uilblsubtotal
        '
        Me.uilblsubtotal.Dpi = 254.0!
        Me.uilblsubtotal.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.uilblsubtotal.LocationFloat = New DevExpress.Utils.PointFloat(1902.46!, 421.058!)
        Me.uilblsubtotal.Name = "uilblsubtotal"
        Me.uilblsubtotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.uilblsubtotal.SizeF = New System.Drawing.SizeF(253.9999!, 58.41998!)
        Me.uilblsubtotal.StylePriority.UseFont = False
        Me.uilblsubtotal.Text = "Ventas"
        '
        'uilblgravadas
        '
        Me.uilblgravadas.Dpi = 254.0!
        Me.uilblgravadas.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.uilblgravadas.LocationFloat = New DevExpress.Utils.PointFloat(1648.46!, 425.0795!)
        Me.uilblgravadas.Name = "uilblgravadas"
        Me.uilblgravadas.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.uilblgravadas.SizeF = New System.Drawing.SizeF(254.0!, 58.42001!)
        Me.uilblgravadas.StylePriority.UseFont = False
        Me.uilblgravadas.Text = "Gravadas"
        '
        'uilblExentas
        '
        Me.uilblExentas.Dpi = 254.0!
        Me.uilblExentas.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.uilblExentas.LocationFloat = New DevExpress.Utils.PointFloat(1394.46!, 425.0795!)
        Me.uilblExentas.Name = "uilblExentas"
        Me.uilblExentas.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.uilblExentas.SizeF = New System.Drawing.SizeF(254.0!, 58.42001!)
        Me.uilblExentas.StylePriority.UseFont = False
        Me.uilblExentas.Text = "Exentas"
        '
        'uilblventas
        '
        Me.uilblventas.Dpi = 254.0!
        Me.uilblventas.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.uilblventas.LocationFloat = New DevExpress.Utils.PointFloat(1394.46!, 358.6164!)
        Me.uilblventas.Name = "uilblventas"
        Me.uilblventas.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.uilblventas.SizeF = New System.Drawing.SizeF(1143.0!, 58.42001!)
        Me.uilblventas.StylePriority.UseFont = False
        Me.uilblventas.StylePriority.UseTextAlignment = False
        Me.uilblventas.Text = "OPERACIONES DE VENTAS PROPIAS"
        Me.uilblventas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'uilblbncr
        '
        Me.uilblbncr.Dpi = 254.0!
        Me.uilblbncr.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.uilblbncr.LocationFloat = New DevExpress.Utils.PointFloat(950.0!, 358.6164!)
        Me.uilblbncr.Name = "uilblbncr"
        Me.uilblbncr.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.uilblbncr.SizeF = New System.Drawing.SizeF(150.0!, 58.41998!)
        Me.uilblbncr.StylePriority.UseFont = False
        Me.uilblbncr.Text = "N.C.R."
        '
        'uilblcliente
        '
        Me.uilblcliente.Dpi = 254.0!
        Me.uilblcliente.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.uilblcliente.LocationFloat = New DevExpress.Utils.PointFloat(431.2708!, 358.6164!)
        Me.uilblcliente.Name = "uilblcliente"
        Me.uilblcliente.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.uilblcliente.SizeF = New System.Drawing.SizeF(470.0!, 58.42001!)
        Me.uilblcliente.StylePriority.UseFont = False
        Me.uilblcliente.Text = "Cliente"
        '
        'uilbldocumento
        '
        Me.uilbldocumento.Dpi = 254.0!
        Me.uilbldocumento.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.uilbldocumento.LocationFloat = New DevExpress.Utils.PointFloat(210.0!, 358.6164!)
        Me.uilbldocumento.Name = "uilbldocumento"
        Me.uilbldocumento.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.uilbldocumento.SizeF = New System.Drawing.SizeF(150.0!, 58.42001!)
        Me.uilbldocumento.StylePriority.UseFont = False
        Me.uilbldocumento.Text = "Documento"
        '
        'uilbldia
        '
        Me.uilbldia.Dpi = 254.0!
        Me.uilbldia.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.uilbldia.LocationFloat = New DevExpress.Utils.PointFloat(120.0!, 358.6164!)
        Me.uilbldia.Name = "uilbldia"
        Me.uilbldia.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.uilbldia.SizeF = New System.Drawing.SizeF(60.0!, 58.42001!)
        Me.uilbldia.StylePriority.UseFont = False
        Me.uilbldia.Text = "Día"
        '
        'uilblcorr
        '
        Me.uilblcorr.Dpi = 254.0!
        Me.uilblcorr.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.uilblcorr.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 358.6164!)
        Me.uilblcorr.Name = "uilblcorr"
        Me.uilblcorr.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.uilblcorr.SizeF = New System.Drawing.SizeF(60.0!, 58.42001!)
        Me.uilblcorr.StylePriority.UseFont = False
        Me.uilblcorr.Text = "No."
        '
        'uilbltitulo
        '
        Me.uilbltitulo.Dpi = 254.0!
        Me.uilbltitulo.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.uilbltitulo.LocationFloat = New DevExpress.Utils.PointFloat(689.2919!, 149.1721!)
        Me.uilbltitulo.Name = "uilbltitulo"
        Me.uilbltitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.uilbltitulo.SizeF = New System.Drawing.SizeF(1086.168!, 84.87836!)
        Me.uilbltitulo.StylePriority.UseFont = False
        Me.uilbltitulo.StylePriority.UseTextAlignment = False
        Me.uilbltitulo.Text = "LIBRO DE VENTAS A CONTRIBUYENTES"
        Me.uilbltitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'uilblsubtitulo
        '
        Me.uilblsubtitulo.Dpi = 254.0!
        Me.uilblsubtitulo.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.uilblsubtitulo.LocationFloat = New DevExpress.Utils.PointFloat(855.9808!, 234.0504!)
        Me.uilblsubtitulo.Name = "uilblsubtitulo"
        Me.uilblsubtitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.uilblsubtitulo.SizeF = New System.Drawing.SizeF(719.6666!, 58.41998!)
        Me.uilblsubtitulo.StylePriority.UseFont = False
        Me.uilblsubtitulo.StylePriority.UseTextAlignment = False
        Me.uilblsubtitulo.Text = "Para el mes de"
        Me.uilblsubtitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'uilblnombreContrib
        '
        Me.uilblnombreContrib.Dpi = 254.0!
        Me.uilblnombreContrib.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.uilblnombreContrib.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 104.1929!)
        Me.uilblnombreContrib.Name = "uilblnombreContrib"
        Me.uilblnombreContrib.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.uilblnombreContrib.SizeF = New System.Drawing.SizeF(874.607!, 44.97916!)
        Me.uilblnombreContrib.StylePriority.UseFont = False
        Me.uilblnombreContrib.Text = "IMPLEMENTOS AGRICOLAS CENTROAMERICANOS, S.A. DE C.V."
        '
        'uilblnit
        '
        Me.uilblnit.Dpi = 254.0!
        Me.uilblnit.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.uilblnit.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 234.0505!)
        Me.uilblnit.Name = "uilblnit"
        Me.uilblnit.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.uilblnit.SizeF = New System.Drawing.SizeF(460.375!, 58.42001!)
        Me.uilblnit.StylePriority.UseFont = False
        Me.uilblnit.Text = "NIT 0210-120364-001-2"
        '
        'uilblnrc
        '
        Me.uilblnrc.Dpi = 254.0!
        Me.uilblnrc.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.uilblnrc.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 175.6304!)
        Me.uilblnrc.Name = "uilblnrc"
        Me.uilblnrc.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.uilblnrc.SizeF = New System.Drawing.SizeF(460.375!, 58.42001!)
        Me.uilblnrc.StylePriority.UseFont = False
        Me.uilblnrc.Text = "No DE REGISTRO  3783-4"
        '
        'uilblfolio
        '
        Me.uilblfolio.Dpi = 254.0!
        Me.uilblfolio.LocationFloat = New DevExpress.Utils.PointFloat(2283.46!, 104.193!)
        Me.uilblfolio.Name = "uilblfolio"
        Me.uilblfolio.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.uilblfolio.SizeF = New System.Drawing.SizeF(161.3958!, 58.42!)
        Me.uilblfolio.Text = "Folio No."
        '
        'uilblnopag
        '
        Me.uilblnopag.Dpi = 254.0!
        Me.uilblnopag.LocationFloat = New DevExpress.Utils.PointFloat(2444.856!, 104.193!)
        Me.uilblnopag.Name = "uilblnopag"
        Me.uilblnopag.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.uilblnopag.PageInfo = DevExpress.XtraPrinting.PageInfo.Number
        Me.uilblnopag.SizeF = New System.Drawing.SizeF(76.72925!, 58.42!)
        Me.uilblnopag.StylePriority.UseTextAlignment = False
        Me.uilblnopag.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(IVA.IVA_LIBRO_VENTA_CONTRIBUYENTE)
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel27, Me.XrSubreport1, Me.XrLabel11, Me.XrLabel12, Me.XrLabel13, Me.XrLabel14, Me.XrLabel15})
        Me.ReportFooter.Dpi = 254.0!
        Me.ReportFooter.HeightF = 466.0!
        Me.ReportFooter.KeepTogether = True
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLabel27
        '
        Me.XrLabel27.Dpi = 254.0!
        Me.XrLabel27.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(719.0001!, 24.65919!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(381.0!, 58.42!)
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "Totales"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_EXENTO")})
        Me.XrLabel11.Dpi = 254.0!
        Me.XrLabel11.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(1394.46!, 25.40002!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(254.0!, 58.42!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:n2}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel11.Summary = XrSummary1
        Me.XrLabel11.Text = "XrLabel11"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel12
        '
        Me.XrLabel12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_GRAVADO")})
        Me.XrLabel12.Dpi = 254.0!
        Me.XrLabel12.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(1648.46!, 25.40002!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(254.0!, 58.42!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:n2}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel12.Summary = XrSummary2
        Me.XrLabel12.Text = "XrLabel12"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel13
        '
        Me.XrLabel13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_FACTURACION")})
        Me.XrLabel13.Dpi = 254.0!
        Me.XrLabel13.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(1902.46!, 25.40002!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(253.9999!, 58.42!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:n2}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel13.Summary = XrSummary3
        Me.XrLabel13.Text = "XrLabel13"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel14
        '
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_IVA")})
        Me.XrLabel14.Dpi = 254.0!
        Me.XrLabel14.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(2156.46!, 24.65919!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(190.5!, 58.42!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:n2}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel14.Summary = XrSummary4
        Me.XrLabel14.Text = "XrLabel14"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel15
        '
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NM_PERCEPCION")})
        Me.XrLabel15.Dpi = 254.0!
        Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(2346.96!, 24.65919!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(190.5!, 58.42!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:n2}"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel15.Summary = XrSummary5
        Me.XrLabel15.Text = "XrLabel15"
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
        Me.FLG_MOSTRAR_ENCABEZADO.Value = "N"
        Me.FLG_MOSTRAR_ENCABEZADO.Visible = False
        '
        'XrSubreport1
        '
        Me.XrSubreport1.Dpi = 254.0!
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 227.4358!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ReportSource = New RPT_SUB_LIBRO_IVA_VENTA_V2()
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(2537.46!, 238.2309!)
        '
        'RPT_LIBRO_IVA_VENTA
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.NM_FACTURACION})
        Me.DataSource = Me.BindingSource1
        Me.Dpi = 254.0!
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(80, 50, 490, 100)
        Me.PageHeight = 2159
        Me.PageWidth = 2794
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.FLG_MOSTRAR_ENCABEZADO})
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.SnapGridSize = 31.75!
        Me.Version = "12.1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

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
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
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
    Friend WithEvents uilblnombreContrib As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblnit As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblnrc As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblfolio As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uilblnopag As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents FLG_MOSTRAR_ENCABEZADO As DevExpress.XtraReports.Parameters.Parameter
End Class
