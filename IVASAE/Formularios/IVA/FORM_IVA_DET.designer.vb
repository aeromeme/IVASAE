<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_IVA_DET
    Inherits IVASAE.MasterForm

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.UIGRIDCONTROLF930 = New DevExpress.XtraGrid.GridControl()
        Me.UIMENUGRID = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExportarAExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IVADET930BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UIGRIDVIEWF930 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCALIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMODALIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOD_DOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUM_DOC4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_SUJETO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRETENCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPERIODO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_MES5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_ANIO5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_MONTO_SUJETO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_RETENCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UIGRIDCONTROLEXTRANJERO = New DevExpress.XtraGrid.GridControl()
        Me.IVADET987PROVEEDOREXTRANJEROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UIGRIDVIEWEXTRANJERO = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMES3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCONCEPTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDOCUMENTO_ID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUM_DOC_ID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE_PROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colREPRESENTANTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPO_DOC3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUM_DOC3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_TOTAL4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIVA_TOTAL3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colANIO4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_MES4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_ANIO4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_IVA_TOTAL3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_MONTO_TOTAL4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UIGRIDCONTROLEXCLUIDO = New DevExpress.XtraGrid.GridControl()
        Me.IVADET987PROVEEDOREXCLUIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UIGRIDVIEWEXCLUIDO = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMES2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDOCUMENTO_ID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUM_DOC_ID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPO_DOC2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUM_DOC2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_TOTAL3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDIRECCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colANIO3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_MES3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_ANIO3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_MONTO_TOTAL3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UIGRIDCONTROLPROVEEDORES = New DevExpress.XtraGrid.GridControl()
        Me.IVADET987PROVEEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UIGRIDVIEWPROVEEDORES = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMES1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDOCUMENTO_ID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUM_DOC_ID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPO_DOC1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUM_DOC1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_TOTAL2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIVA_TOTAL2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colANIO2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_MES2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_ANIO2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_IVA_TOTAL2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_MONTO_TOTAL2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UIGRIDCONTROLCLIENTES = New DevExpress.XtraGrid.GridControl()
        Me.IVADET987CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UIGRIDVIEWCLIENTES = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDOCUMENTO_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUM_DOC_ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPO_DOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUM_DOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_TOTAL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIVA_TOTAL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colANIO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_MES1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_ANIO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_IVA_TOTAL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_MONTO_TOTAL1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UIGRIDCONTROLF987M200 = New DevExpress.XtraGrid.GridControl()
        Me.IVADET987CLIENTESM200BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UIGRIDVIEWF987M200 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colREGISTROS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMONTO_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIVA_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colANIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_MES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_ANIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_IVA_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_MONTO_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.uitabmaster = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.uilytf930 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.uilytfactm200 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.uilytclientes = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.uilytproveedores = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.uilytexcluido = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.uilytextranjero = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.UIBR_IMPORTAR = New DevExpress.XtraBars.BarButtonItem()
        Me.ExpoTXT = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.UIDIALOGO_GUARDAREXCEL = New System.Windows.Forms.SaveFileDialog()
        Me.UIDIALOGOTEXT = New System.Windows.Forms.SaveFileDialog()
        CType(Me.UIGROUP_MAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIGROUP_MAIN.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.UIGRIDCONTROLF930, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIMENUGRID.SuspendLayout()
        CType(Me.IVADET930BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGRIDVIEWF930, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGRIDCONTROLEXTRANJERO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IVADET987PROVEEDOREXTRANJEROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGRIDVIEWEXTRANJERO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGRIDCONTROLEXCLUIDO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IVADET987PROVEEDOREXCLUIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGRIDVIEWEXCLUIDO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGRIDCONTROLPROVEEDORES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IVADET987PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGRIDVIEWPROVEEDORES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGRIDCONTROLCLIENTES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IVADET987CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGRIDVIEWCLIENTES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGRIDCONTROLF987M200, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IVADET987CLIENTESM200BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGRIDVIEWF987M200, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uitabmaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uilytf930, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uilytfactm200, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uilytclientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uilytproveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uilytexcluido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uilytextranjero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UIGROUP_MAIN
        '
        Me.UIGROUP_MAIN.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UIGROUP_MAIN.AppearanceCaption.ForeColor = System.Drawing.Color.White
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseFont = True
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseForeColor = True
        Me.UIGROUP_MAIN.Controls.Add(Me.LayoutControl1)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.UIGRIDCONTROLF930)
        Me.LayoutControl1.Controls.Add(Me.UIGRIDCONTROLEXTRANJERO)
        Me.LayoutControl1.Controls.Add(Me.UIGRIDCONTROLEXCLUIDO)
        Me.LayoutControl1.Controls.Add(Me.UIGRIDCONTROLPROVEEDORES)
        Me.LayoutControl1.Controls.Add(Me.UIGRIDCONTROLCLIENTES)
        Me.LayoutControl1.Controls.Add(Me.UIGRIDCONTROLF987M200)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(2, 39)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(961, 444)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'UIGRIDCONTROLF930
        '
        Me.UIGRIDCONTROLF930.ContextMenuStrip = Me.UIMENUGRID
        Me.UIGRIDCONTROLF930.DataSource = Me.IVADET930BindingSource
        Me.UIGRIDCONTROLF930.Location = New System.Drawing.Point(24, 24)
        Me.UIGRIDCONTROLF930.MainView = Me.UIGRIDVIEWF930
        Me.UIGRIDCONTROLF930.Name = "UIGRIDCONTROLF930"
        Me.UIGRIDCONTROLF930.Size = New System.Drawing.Size(913, 374)
        Me.UIGRIDCONTROLF930.TabIndex = 10
        Me.UIGRIDCONTROLF930.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.UIGRIDVIEWF930})
        '
        'UIMENUGRID
        '
        Me.UIMENUGRID.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarAExcelToolStripMenuItem})
        Me.UIMENUGRID.Name = "UIMENUGRID"
        Me.UIMENUGRID.Size = New System.Drawing.Size(156, 26)
        '
        'ExportarAExcelToolStripMenuItem
        '
        Me.ExportarAExcelToolStripMenuItem.Name = "ExportarAExcelToolStripMenuItem"
        Me.ExportarAExcelToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExportarAExcelToolStripMenuItem.Text = "Exportar a Excel"
        '
        'IVADET930BindingSource
        '
        Me.IVADET930BindingSource.DataSource = GetType(IVA.IVA_DET_930)
        '
        'UIGRIDVIEWF930
        '
        Me.UIGRIDVIEWF930.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNOMBRE, Me.colNIT, Me.colCALIDAD, Me.colMODALIDAD, Me.colCOD_DOC, Me.colNUM_DOC4, Me.colMONTO_SUJETO, Me.colRETENCION, Me.colPERIODO, Me.colNM_MES5, Me.colNM_ANIO5, Me.colID5, Me.colNM_MONTO_SUJETO, Me.colNM_RETENCION})
        Me.UIGRIDVIEWF930.GridControl = Me.UIGRIDCONTROLF930
        Me.UIGRIDVIEWF930.Name = "UIGRIDVIEWF930"
        Me.UIGRIDVIEWF930.OptionsBehavior.Editable = False
        Me.UIGRIDVIEWF930.OptionsBehavior.ReadOnly = True
        Me.UIGRIDVIEWF930.OptionsView.ShowAutoFilterRow = True
        Me.UIGRIDVIEWF930.OptionsView.ShowFooter = True
        Me.UIGRIDVIEWF930.OptionsView.ShowGroupPanel = False
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Caption = "Nombre"
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        Me.colNOMBRE.Visible = True
        Me.colNOMBRE.VisibleIndex = 0
        '
        'colNIT
        '
        Me.colNIT.Caption = "NIT"
        Me.colNIT.FieldName = "NIT"
        Me.colNIT.Name = "colNIT"
        Me.colNIT.Visible = True
        Me.colNIT.VisibleIndex = 1
        '
        'colCALIDAD
        '
        Me.colCALIDAD.Caption = "Calidad en que actua"
        Me.colCALIDAD.FieldName = "CALIDAD"
        Me.colCALIDAD.Name = "colCALIDAD"
        Me.colCALIDAD.Visible = True
        Me.colCALIDAD.VisibleIndex = 2
        '
        'colMODALIDAD
        '
        Me.colMODALIDAD.Caption = "Modalidad"
        Me.colMODALIDAD.FieldName = "MODALIDAD"
        Me.colMODALIDAD.Name = "colMODALIDAD"
        Me.colMODALIDAD.Visible = True
        Me.colMODALIDAD.VisibleIndex = 3
        '
        'colCOD_DOC
        '
        Me.colCOD_DOC.Caption = "Codigo del documento"
        Me.colCOD_DOC.FieldName = "COD_DOC"
        Me.colCOD_DOC.Name = "colCOD_DOC"
        Me.colCOD_DOC.Visible = True
        Me.colCOD_DOC.VisibleIndex = 4
        '
        'colNUM_DOC4
        '
        Me.colNUM_DOC4.Caption = "Numero de Documento"
        Me.colNUM_DOC4.FieldName = "NUM_DOC"
        Me.colNUM_DOC4.Name = "colNUM_DOC4"
        Me.colNUM_DOC4.Visible = True
        Me.colNUM_DOC4.VisibleIndex = 5
        '
        'colMONTO_SUJETO
        '
        Me.colMONTO_SUJETO.Caption = "Monto sujeto"
        Me.colMONTO_SUJETO.FieldName = "MONTO_SUJETO"
        Me.colMONTO_SUJETO.Name = "colMONTO_SUJETO"
        Me.colMONTO_SUJETO.Visible = True
        Me.colMONTO_SUJETO.VisibleIndex = 6
        '
        'colRETENCION
        '
        Me.colRETENCION.Caption = "Ingresos sujetos de retencion"
        Me.colRETENCION.FieldName = "RETENCION"
        Me.colRETENCION.Name = "colRETENCION"
        Me.colRETENCION.Visible = True
        Me.colRETENCION.VisibleIndex = 7
        '
        'colPERIODO
        '
        Me.colPERIODO.Caption = "Periodo"
        Me.colPERIODO.FieldName = "PERIODO"
        Me.colPERIODO.Name = "colPERIODO"
        Me.colPERIODO.Visible = True
        Me.colPERIODO.VisibleIndex = 8
        '
        'colNM_MES5
        '
        Me.colNM_MES5.FieldName = "NM_MES"
        Me.colNM_MES5.Name = "colNM_MES5"
        '
        'colNM_ANIO5
        '
        Me.colNM_ANIO5.FieldName = "NM_ANIO"
        Me.colNM_ANIO5.Name = "colNM_ANIO5"
        '
        'colID5
        '
        Me.colID5.FieldName = "ID"
        Me.colID5.Name = "colID5"
        '
        'colNM_MONTO_SUJETO
        '
        Me.colNM_MONTO_SUJETO.Caption = "Monto sujeto $"
        Me.colNM_MONTO_SUJETO.FieldName = "NM_MONTO_SUJETO"
        Me.colNM_MONTO_SUJETO.Name = "colNM_MONTO_SUJETO"
        Me.colNM_MONTO_SUJETO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_MONTO_SUJETO", "{0:n2}")})
        Me.colNM_MONTO_SUJETO.Visible = True
        Me.colNM_MONTO_SUJETO.VisibleIndex = 9
        '
        'colNM_RETENCION
        '
        Me.colNM_RETENCION.Caption = "Monto retenido $"
        Me.colNM_RETENCION.FieldName = "NM_RETENCION"
        Me.colNM_RETENCION.Name = "colNM_RETENCION"
        Me.colNM_RETENCION.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_RETENCION", "{0:n2}")})
        Me.colNM_RETENCION.Visible = True
        Me.colNM_RETENCION.VisibleIndex = 10
        '
        'UIGRIDCONTROLEXTRANJERO
        '
        Me.UIGRIDCONTROLEXTRANJERO.ContextMenuStrip = Me.UIMENUGRID
        Me.UIGRIDCONTROLEXTRANJERO.DataSource = Me.IVADET987PROVEEDOREXTRANJEROBindingSource
        Me.UIGRIDCONTROLEXTRANJERO.Location = New System.Drawing.Point(24, 24)
        Me.UIGRIDCONTROLEXTRANJERO.MainView = Me.UIGRIDVIEWEXTRANJERO
        Me.UIGRIDCONTROLEXTRANJERO.Name = "UIGRIDCONTROLEXTRANJERO"
        Me.UIGRIDCONTROLEXTRANJERO.Size = New System.Drawing.Size(913, 374)
        Me.UIGRIDCONTROLEXTRANJERO.TabIndex = 9
        Me.UIGRIDCONTROLEXTRANJERO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.UIGRIDVIEWEXTRANJERO})
        '
        'IVADET987PROVEEDOREXTRANJEROBindingSource
        '
        Me.IVADET987PROVEEDOREXTRANJEROBindingSource.DataSource = GetType(IVA.IVA_DET_987_PROVEEDOR_EXTRANJERO)
        '
        'UIGRIDVIEWEXTRANJERO
        '
        Me.UIGRIDVIEWEXTRANJERO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMES3, Me.colCONCEPTO, Me.colDOCUMENTO_ID3, Me.colNUM_DOC_ID3, Me.colNOMBRE_PROVEEDOR, Me.colREPRESENTANTE, Me.colFECHA4, Me.colTIPO_DOC3, Me.colNUM_DOC3, Me.colMONTO_TOTAL4, Me.colIVA_TOTAL3, Me.colANIO4, Me.colNM_MES4, Me.colNM_ANIO4, Me.colID4, Me.colNM_IVA_TOTAL3, Me.colNM_MONTO_TOTAL4})
        Me.UIGRIDVIEWEXTRANJERO.GridControl = Me.UIGRIDCONTROLEXTRANJERO
        Me.UIGRIDVIEWEXTRANJERO.Name = "UIGRIDVIEWEXTRANJERO"
        Me.UIGRIDVIEWEXTRANJERO.OptionsBehavior.Editable = False
        Me.UIGRIDVIEWEXTRANJERO.OptionsBehavior.ReadOnly = True
        Me.UIGRIDVIEWEXTRANJERO.OptionsView.ShowAutoFilterRow = True
        Me.UIGRIDVIEWEXTRANJERO.OptionsView.ShowFooter = True
        Me.UIGRIDVIEWEXTRANJERO.OptionsView.ShowGroupPanel = False
        '
        'colMES3
        '
        Me.colMES3.Caption = "Mes"
        Me.colMES3.FieldName = "MES"
        Me.colMES3.Name = "colMES3"
        Me.colMES3.Visible = True
        Me.colMES3.VisibleIndex = 0
        '
        'colCONCEPTO
        '
        Me.colCONCEPTO.Caption = "Concepto de operacion"
        Me.colCONCEPTO.FieldName = "CONCEPTO"
        Me.colCONCEPTO.Name = "colCONCEPTO"
        Me.colCONCEPTO.Visible = True
        Me.colCONCEPTO.VisibleIndex = 1
        '
        'colDOCUMENTO_ID3
        '
        Me.colDOCUMENTO_ID3.Caption = "Documento identificacion"
        Me.colDOCUMENTO_ID3.FieldName = "DOCUMENTO_ID"
        Me.colDOCUMENTO_ID3.Name = "colDOCUMENTO_ID3"
        Me.colDOCUMENTO_ID3.Visible = True
        Me.colDOCUMENTO_ID3.VisibleIndex = 2
        '
        'colNUM_DOC_ID3
        '
        Me.colNUM_DOC_ID3.Caption = "Numero identificacion"
        Me.colNUM_DOC_ID3.FieldName = "NUM_DOC_ID"
        Me.colNUM_DOC_ID3.Name = "colNUM_DOC_ID3"
        Me.colNUM_DOC_ID3.Visible = True
        Me.colNUM_DOC_ID3.VisibleIndex = 3
        '
        'colNOMBRE_PROVEEDOR
        '
        Me.colNOMBRE_PROVEEDOR.Caption = "Nombre proveedor"
        Me.colNOMBRE_PROVEEDOR.FieldName = "NOMBRE_PROVEEDOR"
        Me.colNOMBRE_PROVEEDOR.Name = "colNOMBRE_PROVEEDOR"
        Me.colNOMBRE_PROVEEDOR.Visible = True
        Me.colNOMBRE_PROVEEDOR.VisibleIndex = 4
        '
        'colREPRESENTANTE
        '
        Me.colREPRESENTANTE.Caption = "Nombre Representante"
        Me.colREPRESENTANTE.FieldName = "REPRESENTANTE"
        Me.colREPRESENTANTE.Name = "colREPRESENTANTE"
        Me.colREPRESENTANTE.Visible = True
        Me.colREPRESENTANTE.VisibleIndex = 5
        '
        'colFECHA4
        '
        Me.colFECHA4.Caption = "Fecha de emision"
        Me.colFECHA4.FieldName = "FECHA"
        Me.colFECHA4.Name = "colFECHA4"
        Me.colFECHA4.Visible = True
        Me.colFECHA4.VisibleIndex = 6
        '
        'colTIPO_DOC3
        '
        Me.colTIPO_DOC3.Caption = "Tipo de documento"
        Me.colTIPO_DOC3.FieldName = "TIPO_DOC"
        Me.colTIPO_DOC3.Name = "colTIPO_DOC3"
        Me.colTIPO_DOC3.Visible = True
        Me.colTIPO_DOC3.VisibleIndex = 7
        '
        'colNUM_DOC3
        '
        Me.colNUM_DOC3.Caption = "Numero de documento"
        Me.colNUM_DOC3.FieldName = "NUM_DOC"
        Me.colNUM_DOC3.Name = "colNUM_DOC3"
        Me.colNUM_DOC3.Visible = True
        Me.colNUM_DOC3.VisibleIndex = 8
        '
        'colMONTO_TOTAL4
        '
        Me.colMONTO_TOTAL4.Caption = "Monto de operacion"
        Me.colMONTO_TOTAL4.FieldName = "MONTO_TOTAL"
        Me.colMONTO_TOTAL4.Name = "colMONTO_TOTAL4"
        Me.colMONTO_TOTAL4.Visible = True
        Me.colMONTO_TOTAL4.VisibleIndex = 9
        '
        'colIVA_TOTAL3
        '
        Me.colIVA_TOTAL3.Caption = "IVA de operacion"
        Me.colIVA_TOTAL3.FieldName = "IVA_TOTAL"
        Me.colIVA_TOTAL3.Name = "colIVA_TOTAL3"
        Me.colIVA_TOTAL3.Visible = True
        Me.colIVA_TOTAL3.VisibleIndex = 10
        '
        'colANIO4
        '
        Me.colANIO4.Caption = "Año"
        Me.colANIO4.FieldName = "ANIO"
        Me.colANIO4.Name = "colANIO4"
        Me.colANIO4.Visible = True
        Me.colANIO4.VisibleIndex = 11
        '
        'colNM_MES4
        '
        Me.colNM_MES4.FieldName = "NM_MES"
        Me.colNM_MES4.Name = "colNM_MES4"
        '
        'colNM_ANIO4
        '
        Me.colNM_ANIO4.FieldName = "NM_ANIO"
        Me.colNM_ANIO4.Name = "colNM_ANIO4"
        '
        'colID4
        '
        Me.colID4.FieldName = "ID"
        Me.colID4.Name = "colID4"
        '
        'colNM_IVA_TOTAL3
        '
        Me.colNM_IVA_TOTAL3.Caption = "IVA $"
        Me.colNM_IVA_TOTAL3.FieldName = "NM_IVA_TOTAL"
        Me.colNM_IVA_TOTAL3.Name = "colNM_IVA_TOTAL3"
        Me.colNM_IVA_TOTAL3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_IVA_TOTAL", "{0:n2}")})
        Me.colNM_IVA_TOTAL3.Visible = True
        Me.colNM_IVA_TOTAL3.VisibleIndex = 12
        '
        'colNM_MONTO_TOTAL4
        '
        Me.colNM_MONTO_TOTAL4.Caption = "Monto $"
        Me.colNM_MONTO_TOTAL4.FieldName = "NM_MONTO_TOTAL"
        Me.colNM_MONTO_TOTAL4.Name = "colNM_MONTO_TOTAL4"
        Me.colNM_MONTO_TOTAL4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_MONTO_TOTAL", "{0:n2}")})
        Me.colNM_MONTO_TOTAL4.Visible = True
        Me.colNM_MONTO_TOTAL4.VisibleIndex = 13
        '
        'UIGRIDCONTROLEXCLUIDO
        '
        Me.UIGRIDCONTROLEXCLUIDO.ContextMenuStrip = Me.UIMENUGRID
        Me.UIGRIDCONTROLEXCLUIDO.DataSource = Me.IVADET987PROVEEDOREXCLUIVABindingSource
        Me.UIGRIDCONTROLEXCLUIDO.Location = New System.Drawing.Point(24, 24)
        Me.UIGRIDCONTROLEXCLUIDO.MainView = Me.UIGRIDVIEWEXCLUIDO
        Me.UIGRIDCONTROLEXCLUIDO.Name = "UIGRIDCONTROLEXCLUIDO"
        Me.UIGRIDCONTROLEXCLUIDO.Size = New System.Drawing.Size(913, 374)
        Me.UIGRIDCONTROLEXCLUIDO.TabIndex = 8
        Me.UIGRIDCONTROLEXCLUIDO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.UIGRIDVIEWEXCLUIDO})
        '
        'IVADET987PROVEEDOREXCLUIVABindingSource
        '
        Me.IVADET987PROVEEDOREXCLUIVABindingSource.DataSource = GetType(IVA.IVA_DET_987_PROVEEDOR_EXCLU_IVA)
        '
        'UIGRIDVIEWEXCLUIDO
        '
        Me.UIGRIDVIEWEXCLUIDO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMES2, Me.colDOCUMENTO_ID2, Me.colNUM_DOC_ID2, Me.colFECHA3, Me.colTIPO_DOC2, Me.colNUM_DOC2, Me.colMONTO_TOTAL3, Me.colDIRECCION, Me.colANIO3, Me.colNM_MES3, Me.colNM_ANIO3, Me.colID3, Me.colNM_MONTO_TOTAL3})
        Me.UIGRIDVIEWEXCLUIDO.GridControl = Me.UIGRIDCONTROLEXCLUIDO
        Me.UIGRIDVIEWEXCLUIDO.Name = "UIGRIDVIEWEXCLUIDO"
        Me.UIGRIDVIEWEXCLUIDO.OptionsBehavior.Editable = False
        Me.UIGRIDVIEWEXCLUIDO.OptionsBehavior.ReadOnly = True
        Me.UIGRIDVIEWEXCLUIDO.OptionsView.ShowAutoFilterRow = True
        Me.UIGRIDVIEWEXCLUIDO.OptionsView.ShowFooter = True
        Me.UIGRIDVIEWEXCLUIDO.OptionsView.ShowGroupPanel = False
        '
        'colMES2
        '
        Me.colMES2.Caption = "Mes"
        Me.colMES2.FieldName = "MES"
        Me.colMES2.Name = "colMES2"
        Me.colMES2.Visible = True
        Me.colMES2.VisibleIndex = 0
        '
        'colDOCUMENTO_ID2
        '
        Me.colDOCUMENTO_ID2.Caption = "Documento identificacion"
        Me.colDOCUMENTO_ID2.FieldName = "DOCUMENTO_ID"
        Me.colDOCUMENTO_ID2.Name = "colDOCUMENTO_ID2"
        Me.colDOCUMENTO_ID2.Visible = True
        Me.colDOCUMENTO_ID2.VisibleIndex = 1
        '
        'colNUM_DOC_ID2
        '
        Me.colNUM_DOC_ID2.Caption = "Numero de identificacion"
        Me.colNUM_DOC_ID2.FieldName = "NUM_DOC_ID"
        Me.colNUM_DOC_ID2.Name = "colNUM_DOC_ID2"
        Me.colNUM_DOC_ID2.Visible = True
        Me.colNUM_DOC_ID2.VisibleIndex = 2
        '
        'colFECHA3
        '
        Me.colFECHA3.Caption = "Fehca de emision"
        Me.colFECHA3.FieldName = "FECHA"
        Me.colFECHA3.Name = "colFECHA3"
        Me.colFECHA3.Visible = True
        Me.colFECHA3.VisibleIndex = 3
        '
        'colTIPO_DOC2
        '
        Me.colTIPO_DOC2.Caption = "Tipo de documento"
        Me.colTIPO_DOC2.FieldName = "TIPO_DOC"
        Me.colTIPO_DOC2.Name = "colTIPO_DOC2"
        Me.colTIPO_DOC2.Visible = True
        Me.colTIPO_DOC2.VisibleIndex = 4
        '
        'colNUM_DOC2
        '
        Me.colNUM_DOC2.Caption = "Numero de documento"
        Me.colNUM_DOC2.FieldName = "NUM_DOC"
        Me.colNUM_DOC2.Name = "colNUM_DOC2"
        Me.colNUM_DOC2.Visible = True
        Me.colNUM_DOC2.VisibleIndex = 5
        '
        'colMONTO_TOTAL3
        '
        Me.colMONTO_TOTAL3.Caption = "Monto de operacion"
        Me.colMONTO_TOTAL3.FieldName = "MONTO_TOTAL"
        Me.colMONTO_TOTAL3.Name = "colMONTO_TOTAL3"
        Me.colMONTO_TOTAL3.Visible = True
        Me.colMONTO_TOTAL3.VisibleIndex = 6
        '
        'colDIRECCION
        '
        Me.colDIRECCION.Caption = "Direccion"
        Me.colDIRECCION.FieldName = "DIRECCION"
        Me.colDIRECCION.Name = "colDIRECCION"
        Me.colDIRECCION.Visible = True
        Me.colDIRECCION.VisibleIndex = 7
        '
        'colANIO3
        '
        Me.colANIO3.Caption = "Año"
        Me.colANIO3.FieldName = "ANIO"
        Me.colANIO3.Name = "colANIO3"
        Me.colANIO3.Visible = True
        Me.colANIO3.VisibleIndex = 8
        '
        'colNM_MES3
        '
        Me.colNM_MES3.FieldName = "NM_MES"
        Me.colNM_MES3.Name = "colNM_MES3"
        '
        'colNM_ANIO3
        '
        Me.colNM_ANIO3.FieldName = "NM_ANIO"
        Me.colNM_ANIO3.Name = "colNM_ANIO3"
        '
        'colID3
        '
        Me.colID3.FieldName = "ID"
        Me.colID3.Name = "colID3"
        '
        'colNM_MONTO_TOTAL3
        '
        Me.colNM_MONTO_TOTAL3.Caption = "Monto $"
        Me.colNM_MONTO_TOTAL3.FieldName = "NM_MONTO_TOTAL"
        Me.colNM_MONTO_TOTAL3.Name = "colNM_MONTO_TOTAL3"
        Me.colNM_MONTO_TOTAL3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_MONTO_TOTAL", "{0:n2}")})
        Me.colNM_MONTO_TOTAL3.Visible = True
        Me.colNM_MONTO_TOTAL3.VisibleIndex = 9
        '
        'UIGRIDCONTROLPROVEEDORES
        '
        Me.UIGRIDCONTROLPROVEEDORES.ContextMenuStrip = Me.UIMENUGRID
        Me.UIGRIDCONTROLPROVEEDORES.DataSource = Me.IVADET987PROVEEDORESBindingSource
        Me.UIGRIDCONTROLPROVEEDORES.Location = New System.Drawing.Point(24, 24)
        Me.UIGRIDCONTROLPROVEEDORES.MainView = Me.UIGRIDVIEWPROVEEDORES
        Me.UIGRIDCONTROLPROVEEDORES.Name = "UIGRIDCONTROLPROVEEDORES"
        Me.UIGRIDCONTROLPROVEEDORES.Size = New System.Drawing.Size(913, 374)
        Me.UIGRIDCONTROLPROVEEDORES.TabIndex = 7
        Me.UIGRIDCONTROLPROVEEDORES.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.UIGRIDVIEWPROVEEDORES})
        '
        'IVADET987PROVEEDORESBindingSource
        '
        Me.IVADET987PROVEEDORESBindingSource.DataSource = GetType(IVA.IVA_DET_987_PROVEEDORES)
        '
        'UIGRIDVIEWPROVEEDORES
        '
        Me.UIGRIDVIEWPROVEEDORES.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMES1, Me.colDOCUMENTO_ID1, Me.colNUM_DOC_ID1, Me.colFECHA2, Me.colTIPO_DOC1, Me.colNUM_DOC1, Me.colMONTO_TOTAL2, Me.colIVA_TOTAL2, Me.colANIO2, Me.colNM_MES2, Me.colNM_ANIO2, Me.colID2, Me.colNM_IVA_TOTAL2, Me.colNM_MONTO_TOTAL2})
        Me.UIGRIDVIEWPROVEEDORES.GridControl = Me.UIGRIDCONTROLPROVEEDORES
        Me.UIGRIDVIEWPROVEEDORES.Name = "UIGRIDVIEWPROVEEDORES"
        Me.UIGRIDVIEWPROVEEDORES.OptionsBehavior.Editable = False
        Me.UIGRIDVIEWPROVEEDORES.OptionsBehavior.ReadOnly = True
        Me.UIGRIDVIEWPROVEEDORES.OptionsView.ShowAutoFilterRow = True
        Me.UIGRIDVIEWPROVEEDORES.OptionsView.ShowFooter = True
        Me.UIGRIDVIEWPROVEEDORES.OptionsView.ShowGroupPanel = False
        '
        'colMES1
        '
        Me.colMES1.Caption = "Mes"
        Me.colMES1.FieldName = "MES"
        Me.colMES1.Name = "colMES1"
        Me.colMES1.Visible = True
        Me.colMES1.VisibleIndex = 0
        '
        'colDOCUMENTO_ID1
        '
        Me.colDOCUMENTO_ID1.Caption = "Documento identificacion"
        Me.colDOCUMENTO_ID1.FieldName = "DOCUMENTO_ID"
        Me.colDOCUMENTO_ID1.Name = "colDOCUMENTO_ID1"
        Me.colDOCUMENTO_ID1.Visible = True
        Me.colDOCUMENTO_ID1.VisibleIndex = 1
        '
        'colNUM_DOC_ID1
        '
        Me.colNUM_DOC_ID1.Caption = "Numero de identificacion"
        Me.colNUM_DOC_ID1.FieldName = "NUM_DOC_ID"
        Me.colNUM_DOC_ID1.Name = "colNUM_DOC_ID1"
        Me.colNUM_DOC_ID1.Visible = True
        Me.colNUM_DOC_ID1.VisibleIndex = 2
        '
        'colFECHA2
        '
        Me.colFECHA2.Caption = "Fecha de emision"
        Me.colFECHA2.FieldName = "FECHA"
        Me.colFECHA2.Name = "colFECHA2"
        Me.colFECHA2.Visible = True
        Me.colFECHA2.VisibleIndex = 3
        '
        'colTIPO_DOC1
        '
        Me.colTIPO_DOC1.Caption = "Tipo de documento"
        Me.colTIPO_DOC1.FieldName = "TIPO_DOC"
        Me.colTIPO_DOC1.Name = "colTIPO_DOC1"
        Me.colTIPO_DOC1.Visible = True
        Me.colTIPO_DOC1.VisibleIndex = 4
        '
        'colNUM_DOC1
        '
        Me.colNUM_DOC1.Caption = "Numero de documento"
        Me.colNUM_DOC1.FieldName = "NUM_DOC"
        Me.colNUM_DOC1.Name = "colNUM_DOC1"
        Me.colNUM_DOC1.Visible = True
        Me.colNUM_DOC1.VisibleIndex = 5
        '
        'colMONTO_TOTAL2
        '
        Me.colMONTO_TOTAL2.Caption = "Monto de operacion"
        Me.colMONTO_TOTAL2.FieldName = "MONTO_TOTAL"
        Me.colMONTO_TOTAL2.Name = "colMONTO_TOTAL2"
        Me.colMONTO_TOTAL2.Visible = True
        Me.colMONTO_TOTAL2.VisibleIndex = 6
        '
        'colIVA_TOTAL2
        '
        Me.colIVA_TOTAL2.Caption = "IVA de operacion"
        Me.colIVA_TOTAL2.FieldName = "IVA_TOTAL"
        Me.colIVA_TOTAL2.Name = "colIVA_TOTAL2"
        Me.colIVA_TOTAL2.Visible = True
        Me.colIVA_TOTAL2.VisibleIndex = 7
        '
        'colANIO2
        '
        Me.colANIO2.Caption = "Año"
        Me.colANIO2.FieldName = "ANIO"
        Me.colANIO2.Name = "colANIO2"
        Me.colANIO2.Visible = True
        Me.colANIO2.VisibleIndex = 8
        '
        'colNM_MES2
        '
        Me.colNM_MES2.FieldName = "NM_MES"
        Me.colNM_MES2.Name = "colNM_MES2"
        '
        'colNM_ANIO2
        '
        Me.colNM_ANIO2.FieldName = "NM_ANIO"
        Me.colNM_ANIO2.Name = "colNM_ANIO2"
        '
        'colID2
        '
        Me.colID2.FieldName = "ID"
        Me.colID2.Name = "colID2"
        '
        'colNM_IVA_TOTAL2
        '
        Me.colNM_IVA_TOTAL2.Caption = "IVA $"
        Me.colNM_IVA_TOTAL2.FieldName = "NM_IVA_TOTAL"
        Me.colNM_IVA_TOTAL2.Name = "colNM_IVA_TOTAL2"
        Me.colNM_IVA_TOTAL2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_IVA_TOTAL", "{0:n2}")})
        Me.colNM_IVA_TOTAL2.Visible = True
        Me.colNM_IVA_TOTAL2.VisibleIndex = 9
        '
        'colNM_MONTO_TOTAL2
        '
        Me.colNM_MONTO_TOTAL2.Caption = "Monto $"
        Me.colNM_MONTO_TOTAL2.FieldName = "NM_MONTO_TOTAL"
        Me.colNM_MONTO_TOTAL2.Name = "colNM_MONTO_TOTAL2"
        Me.colNM_MONTO_TOTAL2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_MONTO_TOTAL", "{0:n2}")})
        Me.colNM_MONTO_TOTAL2.Visible = True
        Me.colNM_MONTO_TOTAL2.VisibleIndex = 10
        '
        'UIGRIDCONTROLCLIENTES
        '
        Me.UIGRIDCONTROLCLIENTES.ContextMenuStrip = Me.UIMENUGRID
        Me.UIGRIDCONTROLCLIENTES.DataSource = Me.IVADET987CLIENTESBindingSource
        Me.UIGRIDCONTROLCLIENTES.Location = New System.Drawing.Point(24, 24)
        Me.UIGRIDCONTROLCLIENTES.MainView = Me.UIGRIDVIEWCLIENTES
        Me.UIGRIDCONTROLCLIENTES.Name = "UIGRIDCONTROLCLIENTES"
        Me.UIGRIDCONTROLCLIENTES.Size = New System.Drawing.Size(913, 374)
        Me.UIGRIDCONTROLCLIENTES.TabIndex = 6
        Me.UIGRIDCONTROLCLIENTES.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.UIGRIDVIEWCLIENTES})
        '
        'IVADET987CLIENTESBindingSource
        '
        Me.IVADET987CLIENTESBindingSource.DataSource = GetType(IVA.IVA_DET_987_CLIENTES)
        '
        'UIGRIDVIEWCLIENTES
        '
        Me.UIGRIDVIEWCLIENTES.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMES, Me.colDOCUMENTO_ID, Me.colNUM_DOC_ID, Me.colFECHA1, Me.colTIPO_DOC, Me.colNUM_DOC, Me.colMONTO_TOTAL1, Me.colIVA_TOTAL1, Me.colANIO1, Me.colNM_MES1, Me.colNM_ANIO1, Me.colID1, Me.colNM_IVA_TOTAL1, Me.colNM_MONTO_TOTAL1})
        Me.UIGRIDVIEWCLIENTES.GridControl = Me.UIGRIDCONTROLCLIENTES
        Me.UIGRIDVIEWCLIENTES.Name = "UIGRIDVIEWCLIENTES"
        Me.UIGRIDVIEWCLIENTES.OptionsBehavior.Editable = False
        Me.UIGRIDVIEWCLIENTES.OptionsBehavior.ReadOnly = True
        Me.UIGRIDVIEWCLIENTES.OptionsView.ShowAutoFilterRow = True
        Me.UIGRIDVIEWCLIENTES.OptionsView.ShowFooter = True
        Me.UIGRIDVIEWCLIENTES.OptionsView.ShowGroupPanel = False
        '
        'colMES
        '
        Me.colMES.Caption = "Mes"
        Me.colMES.FieldName = "MES"
        Me.colMES.Name = "colMES"
        Me.colMES.Visible = True
        Me.colMES.VisibleIndex = 0
        '
        'colDOCUMENTO_ID
        '
        Me.colDOCUMENTO_ID.Caption = "Documento identificacion"
        Me.colDOCUMENTO_ID.FieldName = "DOCUMENTO_ID"
        Me.colDOCUMENTO_ID.Name = "colDOCUMENTO_ID"
        Me.colDOCUMENTO_ID.Visible = True
        Me.colDOCUMENTO_ID.VisibleIndex = 1
        '
        'colNUM_DOC_ID
        '
        Me.colNUM_DOC_ID.Caption = "Numero de identificacion"
        Me.colNUM_DOC_ID.FieldName = "NUM_DOC_ID"
        Me.colNUM_DOC_ID.Name = "colNUM_DOC_ID"
        Me.colNUM_DOC_ID.Visible = True
        Me.colNUM_DOC_ID.VisibleIndex = 2
        '
        'colFECHA1
        '
        Me.colFECHA1.Caption = "Fecha de emision"
        Me.colFECHA1.FieldName = "FECHA"
        Me.colFECHA1.Name = "colFECHA1"
        Me.colFECHA1.Visible = True
        Me.colFECHA1.VisibleIndex = 3
        '
        'colTIPO_DOC
        '
        Me.colTIPO_DOC.Caption = "Tipo de documento"
        Me.colTIPO_DOC.FieldName = "TIPO_DOC"
        Me.colTIPO_DOC.Name = "colTIPO_DOC"
        Me.colTIPO_DOC.Visible = True
        Me.colTIPO_DOC.VisibleIndex = 4
        '
        'colNUM_DOC
        '
        Me.colNUM_DOC.Caption = "Numero de documento"
        Me.colNUM_DOC.FieldName = "NUM_DOC"
        Me.colNUM_DOC.Name = "colNUM_DOC"
        Me.colNUM_DOC.Visible = True
        Me.colNUM_DOC.VisibleIndex = 5
        '
        'colMONTO_TOTAL1
        '
        Me.colMONTO_TOTAL1.Caption = "Monto de operacion"
        Me.colMONTO_TOTAL1.FieldName = "MONTO_TOTAL"
        Me.colMONTO_TOTAL1.Name = "colMONTO_TOTAL1"
        Me.colMONTO_TOTAL1.Visible = True
        Me.colMONTO_TOTAL1.VisibleIndex = 6
        '
        'colIVA_TOTAL1
        '
        Me.colIVA_TOTAL1.Caption = "IVA de operacion"
        Me.colIVA_TOTAL1.FieldName = "IVA_TOTAL"
        Me.colIVA_TOTAL1.Name = "colIVA_TOTAL1"
        Me.colIVA_TOTAL1.Visible = True
        Me.colIVA_TOTAL1.VisibleIndex = 7
        '
        'colANIO1
        '
        Me.colANIO1.Caption = "Año"
        Me.colANIO1.FieldName = "ANIO"
        Me.colANIO1.Name = "colANIO1"
        Me.colANIO1.Visible = True
        Me.colANIO1.VisibleIndex = 8
        '
        'colNM_MES1
        '
        Me.colNM_MES1.FieldName = "NM_MES"
        Me.colNM_MES1.Name = "colNM_MES1"
        '
        'colNM_ANIO1
        '
        Me.colNM_ANIO1.FieldName = "NM_ANIO"
        Me.colNM_ANIO1.Name = "colNM_ANIO1"
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.Name = "colID1"
        '
        'colNM_IVA_TOTAL1
        '
        Me.colNM_IVA_TOTAL1.Caption = "IVA $"
        Me.colNM_IVA_TOTAL1.FieldName = "NM_IVA_TOTAL"
        Me.colNM_IVA_TOTAL1.Name = "colNM_IVA_TOTAL1"
        Me.colNM_IVA_TOTAL1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_IVA_TOTAL", "{0:n2}")})
        Me.colNM_IVA_TOTAL1.Visible = True
        Me.colNM_IVA_TOTAL1.VisibleIndex = 9
        '
        'colNM_MONTO_TOTAL1
        '
        Me.colNM_MONTO_TOTAL1.Caption = "Monto $"
        Me.colNM_MONTO_TOTAL1.FieldName = "NM_MONTO_TOTAL"
        Me.colNM_MONTO_TOTAL1.Name = "colNM_MONTO_TOTAL1"
        Me.colNM_MONTO_TOTAL1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_MONTO_TOTAL", "{0:n2}")})
        Me.colNM_MONTO_TOTAL1.Visible = True
        Me.colNM_MONTO_TOTAL1.VisibleIndex = 10
        '
        'UIGRIDCONTROLF987M200
        '
        Me.UIGRIDCONTROLF987M200.ContextMenuStrip = Me.UIMENUGRID
        Me.UIGRIDCONTROLF987M200.DataSource = Me.IVADET987CLIENTESM200BindingSource
        Me.UIGRIDCONTROLF987M200.Location = New System.Drawing.Point(24, 24)
        Me.UIGRIDCONTROLF987M200.MainView = Me.UIGRIDVIEWF987M200
        Me.UIGRIDCONTROLF987M200.Name = "UIGRIDCONTROLF987M200"
        Me.UIGRIDCONTROLF987M200.Size = New System.Drawing.Size(913, 374)
        Me.UIGRIDCONTROLF987M200.TabIndex = 5
        Me.UIGRIDCONTROLF987M200.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.UIGRIDVIEWF987M200})
        '
        'IVADET987CLIENTESM200BindingSource
        '
        Me.IVADET987CLIENTESM200BindingSource.DataSource = GetType(IVA.IVA_DET_987_CLIENTES_M200)
        '
        'UIGRIDVIEWF987M200
        '
        Me.UIGRIDVIEWF987M200.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFECHA, Me.colREGISTROS, Me.colMONTO_TOTAL, Me.colIVA_TOTAL, Me.colANIO, Me.colNM_MES, Me.colNM_ANIO, Me.colID, Me.colNM_IVA_TOTAL, Me.colNM_MONTO_TOTAL})
        Me.UIGRIDVIEWF987M200.GridControl = Me.UIGRIDCONTROLF987M200
        Me.UIGRIDVIEWF987M200.Name = "UIGRIDVIEWF987M200"
        Me.UIGRIDVIEWF987M200.OptionsBehavior.Editable = False
        Me.UIGRIDVIEWF987M200.OptionsBehavior.ReadOnly = True
        Me.UIGRIDVIEWF987M200.OptionsView.ShowAutoFilterRow = True
        Me.UIGRIDVIEWF987M200.OptionsView.ShowFooter = True
        Me.UIGRIDVIEWF987M200.OptionsView.ShowGroupPanel = False
        '
        'colFECHA
        '
        Me.colFECHA.Caption = "Fecha de emision"
        Me.colFECHA.FieldName = "FECHA"
        Me.colFECHA.Name = "colFECHA"
        Me.colFECHA.Visible = True
        Me.colFECHA.VisibleIndex = 0
        '
        'colREGISTROS
        '
        Me.colREGISTROS.Caption = "Registros"
        Me.colREGISTROS.FieldName = "REGISTROS"
        Me.colREGISTROS.Name = "colREGISTROS"
        Me.colREGISTROS.Visible = True
        Me.colREGISTROS.VisibleIndex = 1
        '
        'colMONTO_TOTAL
        '
        Me.colMONTO_TOTAL.Caption = "Monto total"
        Me.colMONTO_TOTAL.FieldName = "MONTO_TOTAL"
        Me.colMONTO_TOTAL.Name = "colMONTO_TOTAL"
        Me.colMONTO_TOTAL.Visible = True
        Me.colMONTO_TOTAL.VisibleIndex = 2
        '
        'colIVA_TOTAL
        '
        Me.colIVA_TOTAL.Caption = "IVA total"
        Me.colIVA_TOTAL.FieldName = "IVA_TOTAL"
        Me.colIVA_TOTAL.Name = "colIVA_TOTAL"
        Me.colIVA_TOTAL.Visible = True
        Me.colIVA_TOTAL.VisibleIndex = 3
        '
        'colANIO
        '
        Me.colANIO.Caption = "Año"
        Me.colANIO.FieldName = "ANIO"
        Me.colANIO.Name = "colANIO"
        Me.colANIO.Visible = True
        Me.colANIO.VisibleIndex = 4
        '
        'colNM_MES
        '
        Me.colNM_MES.FieldName = "NM_MES"
        Me.colNM_MES.Name = "colNM_MES"
        '
        'colNM_ANIO
        '
        Me.colNM_ANIO.FieldName = "NM_ANIO"
        Me.colNM_ANIO.Name = "colNM_ANIO"
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colNM_IVA_TOTAL
        '
        Me.colNM_IVA_TOTAL.Caption = "IVA $"
        Me.colNM_IVA_TOTAL.FieldName = "NM_IVA_TOTAL"
        Me.colNM_IVA_TOTAL.Name = "colNM_IVA_TOTAL"
        Me.colNM_IVA_TOTAL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_IVA_TOTAL", "{0:n2}")})
        Me.colNM_IVA_TOTAL.Visible = True
        Me.colNM_IVA_TOTAL.VisibleIndex = 5
        '
        'colNM_MONTO_TOTAL
        '
        Me.colNM_MONTO_TOTAL.Caption = "Monto $"
        Me.colNM_MONTO_TOTAL.FieldName = "NM_MONTO_TOTAL"
        Me.colNM_MONTO_TOTAL.Name = "colNM_MONTO_TOTAL"
        Me.colNM_MONTO_TOTAL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_MONTO_TOTAL", "{0:n2}")})
        Me.colNM_MONTO_TOTAL.Visible = True
        Me.colNM_MONTO_TOTAL.VisibleIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.uitabmaster})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(961, 444)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'uitabmaster
        '
        Me.uitabmaster.CustomizationFormText = "TabbedControlGroup1"
        Me.uitabmaster.Location = New System.Drawing.Point(0, 0)
        Me.uitabmaster.Name = "uitabmaster"
        Me.uitabmaster.SelectedTabPage = Me.uilytexcluido
        Me.uitabmaster.SelectedTabPageIndex = 3
        Me.uitabmaster.Size = New System.Drawing.Size(941, 424)
        Me.uitabmaster.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.uilytfactm200, Me.uilytclientes, Me.uilytproveedores, Me.uilytexcluido, Me.uilytextranjero, Me.uilytf930})
        Me.uitabmaster.Text = "uitabmaster"
        Me.uitabmaster.TextLocation = DevExpress.Utils.Locations.Bottom
        '
        'uilytf930
        '
        Me.uilytf930.CustomizationFormText = "LayoutControlGroup3"
        Me.uilytf930.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6})
        Me.uilytf930.Location = New System.Drawing.Point(0, 0)
        Me.uilytf930.Name = "uilytf930"
        Me.uilytf930.Size = New System.Drawing.Size(917, 378)
        Me.uilytf930.Text = "F930"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.UIGRIDCONTROLF930
        Me.LayoutControlItem6.CustomizationFormText = "LayoutControlItem6"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(917, 378)
        Me.LayoutControlItem6.Text = "LayoutControlItem6"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextToControlDistance = 0
        Me.LayoutControlItem6.TextVisible = False
        '
        'uilytfactm200
        '
        Me.uilytfactm200.CustomizationFormText = "F987 Facturas <200"
        Me.uilytfactm200.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2})
        Me.uilytfactm200.Location = New System.Drawing.Point(0, 0)
        Me.uilytfactm200.Name = "uilytfactm200"
        Me.uilytfactm200.Size = New System.Drawing.Size(917, 378)
        Me.uilytfactm200.Text = "F987 Facturas <200"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.UIGRIDCONTROLF987M200
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(917, 378)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'uilytclientes
        '
        Me.uilytclientes.CustomizationFormText = "F987 Clientes"
        Me.uilytclientes.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.uilytclientes.Location = New System.Drawing.Point(0, 0)
        Me.uilytclientes.Name = "uilytclientes"
        Me.uilytclientes.Size = New System.Drawing.Size(917, 378)
        Me.uilytclientes.Text = "F987 Clientes"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.UIGRIDCONTROLCLIENTES
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(917, 378)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'uilytproveedores
        '
        Me.uilytproveedores.CustomizationFormText = "F987 Proveedores"
        Me.uilytproveedores.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3})
        Me.uilytproveedores.Location = New System.Drawing.Point(0, 0)
        Me.uilytproveedores.Name = "uilytproveedores"
        Me.uilytproveedores.Size = New System.Drawing.Size(917, 378)
        Me.uilytproveedores.Text = "F987 Proveedores"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.UIGRIDCONTROLPROVEEDORES
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(917, 378)
        Me.LayoutControlItem3.Text = "LayoutControlItem3"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextToControlDistance = 0
        Me.LayoutControlItem3.TextVisible = False
        '
        'uilytexcluido
        '
        Me.uilytexcluido.CustomizationFormText = "F987 Proveedor excluido"
        Me.uilytexcluido.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4})
        Me.uilytexcluido.Location = New System.Drawing.Point(0, 0)
        Me.uilytexcluido.Name = "uilytexcluido"
        Me.uilytexcluido.Size = New System.Drawing.Size(917, 378)
        Me.uilytexcluido.Text = "F987 Proveedor excluido"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.UIGRIDCONTROLEXCLUIDO
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(917, 378)
        Me.LayoutControlItem4.Text = "LayoutControlItem4"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextToControlDistance = 0
        Me.LayoutControlItem4.TextVisible = False
        '
        'uilytextranjero
        '
        Me.uilytextranjero.CustomizationFormText = "F987 Proveedor extranjero"
        Me.uilytextranjero.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5})
        Me.uilytextranjero.Location = New System.Drawing.Point(0, 0)
        Me.uilytextranjero.Name = "uilytextranjero"
        Me.uilytextranjero.Size = New System.Drawing.Size(917, 378)
        Me.uilytextranjero.Text = "F987 Proveedor extranjero"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.UIGRIDCONTROLEXTRANJERO
        Me.LayoutControlItem5.CustomizationFormText = "LayoutControlItem5"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(917, 378)
        Me.LayoutControlItem5.Text = "LayoutControlItem5"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextToControlDistance = 0
        Me.LayoutControlItem5.TextVisible = False
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Principal"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.UIBR_IMPORTAR)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.ExpoTXT)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Mantenimiento"
        '
        'UIBR_IMPORTAR
        '
        Me.UIBR_IMPORTAR.Caption = "Procesar"
        Me.UIBR_IMPORTAR.Id = 4
        Me.UIBR_IMPORTAR.LargeGlyph = Global.IVASAE.My.Resources.Resources._1422070454_Settings
        Me.UIBR_IMPORTAR.LargeWidth = 100
        Me.UIBR_IMPORTAR.Name = "UIBR_IMPORTAR"
        Me.UIBR_IMPORTAR.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'ExpoTXT
        '
        Me.ExpoTXT.Caption = "Exportar TXT"
        Me.ExpoTXT.Id = 6
        Me.ExpoTXT.LargeGlyph = Global.IVASAE.My.Resources.Resources._reports
        Me.ExpoTXT.Name = "ExpoTXT"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.UIBR_IMPORTAR, Me.ExpoTXT})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 7
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(965, 142)
        '
        'UIDIALOGO_GUARDAREXCEL
        '
        Me.UIDIALOGO_GUARDAREXCEL.Filter = "Archivos Excel | *.xlsx"
        '
        'UIDIALOGOTEXT
        '
        Me.UIDIALOGOTEXT.Filter = "Archivos Texto | *.txt"
        '
        'FORM_IVA_DET
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(965, 485)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FORM_IVA_DET"
        Me.Controls.SetChildIndex(Me.UIGROUP_MAIN, 0)
        Me.Controls.SetChildIndex(Me.RibbonControl1, 0)
        CType(Me.UIGROUP_MAIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIGROUP_MAIN.ResumeLayout(False)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.UIGRIDCONTROLF930, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIMENUGRID.ResumeLayout(False)
        CType(Me.IVADET930BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGRIDVIEWF930, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGRIDCONTROLEXTRANJERO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IVADET987PROVEEDOREXTRANJEROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGRIDVIEWEXTRANJERO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGRIDCONTROLEXCLUIDO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IVADET987PROVEEDOREXCLUIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGRIDVIEWEXCLUIDO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGRIDCONTROLPROVEEDORES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IVADET987PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGRIDVIEWPROVEEDORES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGRIDCONTROLCLIENTES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IVADET987CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGRIDVIEWCLIENTES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGRIDCONTROLF987M200, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IVADET987CLIENTESM200BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGRIDVIEWF987M200, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uitabmaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uilytf930, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uilytfactm200, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uilytclientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uilytproveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uilytexcluido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uilytextranjero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents UIGRIDCONTROLEXTRANJERO As DevExpress.XtraGrid.GridControl
    Friend WithEvents UIGRIDVIEWEXTRANJERO As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UIGRIDCONTROLEXCLUIDO As DevExpress.XtraGrid.GridControl
    Friend WithEvents UIGRIDVIEWEXCLUIDO As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UIGRIDCONTROLPROVEEDORES As DevExpress.XtraGrid.GridControl
    Friend WithEvents UIGRIDVIEWPROVEEDORES As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UIGRIDCONTROLCLIENTES As DevExpress.XtraGrid.GridControl
    Friend WithEvents UIGRIDVIEWCLIENTES As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UIGRIDCONTROLF987M200 As DevExpress.XtraGrid.GridControl
    Friend WithEvents UIGRIDVIEWF987M200 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents uitabmaster As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents uilytextranjero As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents uilytfactm200 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents uilytclientes As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents uilytproveedores As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents uilytexcluido As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents UIGRIDCONTROLF930 As DevExpress.XtraGrid.GridControl
    Friend WithEvents UIGRIDVIEWF930 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents uilytf930 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Public WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Public WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Public WithEvents UIBR_IMPORTAR As DevExpress.XtraBars.BarButtonItem
    Public WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents UIMENUGRID As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExportarAExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UIDIALOGO_GUARDAREXCEL As System.Windows.Forms.SaveFileDialog
    Friend WithEvents IVADET987CLIENTESM200BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colFECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREGISTROS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_TOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIVA_TOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colANIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_MES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_ANIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IVADET987PROVEEDORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colMES1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDOCUMENTO_ID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUM_DOC_ID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_DOC1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUM_DOC1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_TOTAL2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIVA_TOTAL2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colANIO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_MES2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_ANIO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IVADET987CLIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colMES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDOCUMENTO_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUM_DOC_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_DOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUM_DOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_TOTAL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIVA_TOTAL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colANIO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_MES1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_ANIO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IVADET987PROVEEDOREXCLUIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colMES2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDOCUMENTO_ID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUM_DOC_ID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_DOC2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUM_DOC2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_TOTAL3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDIRECCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colANIO3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_MES3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_ANIO3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IVADET987PROVEEDOREXTRANJEROBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colMES3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCONCEPTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDOCUMENTO_ID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUM_DOC_ID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE_PROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREPRESENTANTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_DOC3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUM_DOC3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_TOTAL4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIVA_TOTAL3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colANIO4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_MES4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_ANIO4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IVADET930BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCALIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMODALIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOD_DOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUM_DOC4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO_SUJETO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRETENCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPERIODO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_MES5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_ANIO5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ExpoTXT As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents UIDIALOGOTEXT As System.Windows.Forms.SaveFileDialog
    Friend WithEvents colNM_MONTO_SUJETO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_RETENCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_IVA_TOTAL3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_MONTO_TOTAL4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_MONTO_TOTAL3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_IVA_TOTAL2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_MONTO_TOTAL2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_IVA_TOTAL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_MONTO_TOTAL1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_IVA_TOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_MONTO_TOTAL As DevExpress.XtraGrid.Columns.GridColumn

End Class
