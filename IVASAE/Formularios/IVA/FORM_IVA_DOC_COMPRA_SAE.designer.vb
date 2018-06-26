<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_IVA_DOC_COMPRA_SAE
    Inherits IVASAE.MasterFromEdit

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
        Me.VIVADOCCOMPRASAEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCVE_DOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCVE_CLIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UIGR_CVE_PROVEEDOR = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.IVACLIEPROVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCLAVE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFE_FECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFE_RECEPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_MES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_ANIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_EXENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UICALC = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
        Me.colNM_GRAVADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_IVA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_RENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_IVA_RETENIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_IVA_PERCIVIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_TIPO_DOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UIGR_TIPO_DOC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.IVATIPODOCUMENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colSTATUS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFLG_BLOQUEADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colDS_CLIENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_NUM_REG_FISC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_NIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_TIPO_DOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.UIBR_IMPORTAR = New DevExpress.XtraBars.BarButtonItem()
        Me.uibtn_unlock = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.colFLG_NO_INCLUIR = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.UIGRIDCONTROL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGRIDVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIPANELSTATUS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIPANELSTATUS.SuspendLayout()
        CType(Me.UIGROUP_MAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIGROUP_MAIN.SuspendLayout()
        CType(Me.VIVADOCCOMPRASAEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGR_CVE_PROVEEDOR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IVACLIEPROVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UICALC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGR_TIPO_DOC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IVATIPODOCUMENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UIGRIDCONTROL
        '
        Me.UIGRIDCONTROL.DataSource = Me.VIVADOCCOMPRASAEBindingSource
        Me.UIGRIDCONTROL.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.UIGR_CVE_PROVEEDOR, Me.UIGR_TIPO_DOC, Me.UICALC})
        '
        'UIGRIDVIEW
        '
        Me.UIGRIDVIEW.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCVE_DOC, Me.colCVE_CLIE, Me.colFE_FECHA, Me.colFE_RECEPCION, Me.colNM_MES, Me.colNM_ANIO, Me.colNM_EXENTO, Me.colNM_GRAVADO, Me.colNM_IVA, Me.colNM_RENTA, Me.colNM_IVA_RETENIDO, Me.colNM_IVA_PERCIVIDO, Me.colNM_TOTAL, Me.colID_TIPO_DOC, Me.colSTATUS, Me.colFLG_BLOQUEADO, Me.colDS_CLIENTE, Me.colDS_NUM_REG_FISC, Me.colDS_NIT, Me.colDS_TIPO_DOC, Me.colFLG_NO_INCLUIR})
        Me.UIGRIDVIEW.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.UIGRIDVIEW.OptionsMenu.EnableFooterMenu = False
        Me.UIGRIDVIEW.OptionsMenu.EnableGroupPanelMenu = False
        Me.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = True
        Me.UIGRIDVIEW.OptionsView.ShowFooter = True
        Me.UIGRIDVIEW.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colID, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'UINAV
        '
        Me.UINAV.Buttons.Append.Visible = False
        Me.UINAV.Buttons.CancelEdit.Visible = False
        Me.UINAV.Buttons.Edit.Visible = False
        Me.UINAV.Buttons.EndEdit.Visible = False
        Me.UINAV.Buttons.Remove.Visible = False
        '
        'UIBARRAPROGRESO
        '
        '
        'UIGROUP_MAIN
        '
        Me.UIGROUP_MAIN.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UIGROUP_MAIN.AppearanceCaption.ForeColor = System.Drawing.Color.White
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseFont = True
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseForeColor = True
        '
        'VIVADOCCOMPRASAEBindingSource
        '
        Me.VIVADOCCOMPRASAEBindingSource.DataSource = GetType(IVA.V_IVA_DOC_COMPRA_SAE)
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.ReadOnly = True
        '
        'colCVE_DOC
        '
        Me.colCVE_DOC.Caption = "Documento"
        Me.colCVE_DOC.FieldName = "CVE_DOC"
        Me.colCVE_DOC.Name = "colCVE_DOC"
        Me.colCVE_DOC.Visible = True
        Me.colCVE_DOC.VisibleIndex = 0
        '
        'colCVE_CLIE
        '
        Me.colCVE_CLIE.Caption = "Proveedor"
        Me.colCVE_CLIE.ColumnEdit = Me.UIGR_CVE_PROVEEDOR
        Me.colCVE_CLIE.FieldName = "CVE_PROVEEDOR"
        Me.colCVE_CLIE.Name = "colCVE_CLIE"
        Me.colCVE_CLIE.OptionsColumn.AllowEdit = False
        Me.colCVE_CLIE.OptionsColumn.ReadOnly = True
        Me.colCVE_CLIE.Visible = True
        Me.colCVE_CLIE.VisibleIndex = 2
        '
        'UIGR_CVE_PROVEEDOR
        '
        Me.UIGR_CVE_PROVEEDOR.AutoHeight = False
        Me.UIGR_CVE_PROVEEDOR.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UIGR_CVE_PROVEEDOR.DataSource = Me.IVACLIEPROVBindingSource
        Me.UIGR_CVE_PROVEEDOR.DisplayMember = "DS_NOMBRE"
        Me.UIGR_CVE_PROVEEDOR.Name = "UIGR_CVE_PROVEEDOR"
        Me.UIGR_CVE_PROVEEDOR.ValueMember = "CLAVE"
        Me.UIGR_CVE_PROVEEDOR.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'IVACLIEPROVBindingSource
        '
        Me.IVACLIEPROVBindingSource.DataSource = GetType(IVA.IVA_CLIE_PROV)
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCLAVE, Me.colDS_NOMBRE})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colCLAVE
        '
        Me.colCLAVE.Caption = "Clave"
        Me.colCLAVE.FieldName = "CLAVE"
        Me.colCLAVE.Name = "colCLAVE"
        Me.colCLAVE.Visible = True
        Me.colCLAVE.VisibleIndex = 0
        Me.colCLAVE.Width = 313
        '
        'colDS_NOMBRE
        '
        Me.colDS_NOMBRE.Caption = "Proveedor"
        Me.colDS_NOMBRE.FieldName = "DS_NOMBRE"
        Me.colDS_NOMBRE.Name = "colDS_NOMBRE"
        Me.colDS_NOMBRE.Visible = True
        Me.colDS_NOMBRE.VisibleIndex = 1
        Me.colDS_NOMBRE.Width = 1421
        '
        'colFE_FECHA
        '
        Me.colFE_FECHA.Caption = "Fecha"
        Me.colFE_FECHA.FieldName = "FE_FECHA"
        Me.colFE_FECHA.Name = "colFE_FECHA"
        Me.colFE_FECHA.Visible = True
        Me.colFE_FECHA.VisibleIndex = 5
        '
        'colFE_RECEPCION
        '
        Me.colFE_RECEPCION.Caption = "Recibido"
        Me.colFE_RECEPCION.FieldName = "FE_RECEPCION"
        Me.colFE_RECEPCION.Name = "colFE_RECEPCION"
        Me.colFE_RECEPCION.Visible = True
        Me.colFE_RECEPCION.VisibleIndex = 6
        '
        'colNM_MES
        '
        Me.colNM_MES.FieldName = "NM_MES"
        Me.colNM_MES.Name = "colNM_MES"
        Me.colNM_MES.OptionsColumn.AllowEdit = False
        Me.colNM_MES.OptionsColumn.ReadOnly = True
        '
        'colNM_ANIO
        '
        Me.colNM_ANIO.FieldName = "NM_ANIO"
        Me.colNM_ANIO.Name = "colNM_ANIO"
        Me.colNM_ANIO.OptionsColumn.AllowEdit = False
        Me.colNM_ANIO.OptionsColumn.ReadOnly = True
        '
        'colNM_EXENTO
        '
        Me.colNM_EXENTO.Caption = "Exento"
        Me.colNM_EXENTO.ColumnEdit = Me.UICALC
        Me.colNM_EXENTO.FieldName = "NM_EXENTO"
        Me.colNM_EXENTO.Name = "colNM_EXENTO"
        Me.colNM_EXENTO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_EXENTO", "{0:n2}")})
        Me.colNM_EXENTO.Visible = True
        Me.colNM_EXENTO.VisibleIndex = 7
        '
        'UICALC
        '
        Me.UICALC.AutoHeight = False
        Me.UICALC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UICALC.Mask.EditMask = "n2"
        Me.UICALC.Name = "UICALC"
        '
        'colNM_GRAVADO
        '
        Me.colNM_GRAVADO.Caption = "Gravado"
        Me.colNM_GRAVADO.ColumnEdit = Me.UICALC
        Me.colNM_GRAVADO.FieldName = "NM_GRAVADO"
        Me.colNM_GRAVADO.Name = "colNM_GRAVADO"
        Me.colNM_GRAVADO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_GRAVADO", "{0:n2}")})
        Me.colNM_GRAVADO.Visible = True
        Me.colNM_GRAVADO.VisibleIndex = 8
        '
        'colNM_IVA
        '
        Me.colNM_IVA.Caption = "IVA"
        Me.colNM_IVA.ColumnEdit = Me.UICALC
        Me.colNM_IVA.FieldName = "NM_IVA"
        Me.colNM_IVA.Name = "colNM_IVA"
        Me.colNM_IVA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_IVA", "{0:n2}")})
        Me.colNM_IVA.Visible = True
        Me.colNM_IVA.VisibleIndex = 9
        '
        'colNM_RENTA
        '
        Me.colNM_RENTA.Caption = "Renta"
        Me.colNM_RENTA.ColumnEdit = Me.UICALC
        Me.colNM_RENTA.FieldName = "NM_RENTA"
        Me.colNM_RENTA.Name = "colNM_RENTA"
        Me.colNM_RENTA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_RENTA", "{0:n2}")})
        Me.colNM_RENTA.Visible = True
        Me.colNM_RENTA.VisibleIndex = 10
        '
        'colNM_IVA_RETENIDO
        '
        Me.colNM_IVA_RETENIDO.Caption = "Retenido"
        Me.colNM_IVA_RETENIDO.FieldName = "NM_IVA_RETENIDO"
        Me.colNM_IVA_RETENIDO.Name = "colNM_IVA_RETENIDO"
        Me.colNM_IVA_RETENIDO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_IVA_RETENIDO", "{0:n2}")})
        Me.colNM_IVA_RETENIDO.Visible = True
        Me.colNM_IVA_RETENIDO.VisibleIndex = 11
        '
        'colNM_IVA_PERCIVIDO
        '
        Me.colNM_IVA_PERCIVIDO.FieldName = "NM_IVA_PERCIVIDO"
        Me.colNM_IVA_PERCIVIDO.Name = "colNM_IVA_PERCIVIDO"
        '
        'colNM_TOTAL
        '
        Me.colNM_TOTAL.Caption = "Total"
        Me.colNM_TOTAL.ColumnEdit = Me.UICALC
        Me.colNM_TOTAL.FieldName = "NM_TOTAL"
        Me.colNM_TOTAL.Name = "colNM_TOTAL"
        Me.colNM_TOTAL.OptionsColumn.AllowEdit = False
        Me.colNM_TOTAL.OptionsColumn.ReadOnly = True
        Me.colNM_TOTAL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_TOTAL", "{0:n2}")})
        Me.colNM_TOTAL.Visible = True
        Me.colNM_TOTAL.VisibleIndex = 12
        '
        'colID_TIPO_DOC
        '
        Me.colID_TIPO_DOC.Caption = "Tipo documento"
        Me.colID_TIPO_DOC.ColumnEdit = Me.UIGR_TIPO_DOC
        Me.colID_TIPO_DOC.FieldName = "ID_TIPO_DOC"
        Me.colID_TIPO_DOC.Name = "colID_TIPO_DOC"
        Me.colID_TIPO_DOC.Visible = True
        Me.colID_TIPO_DOC.VisibleIndex = 1
        '
        'UIGR_TIPO_DOC
        '
        Me.UIGR_TIPO_DOC.AutoHeight = False
        Me.UIGR_TIPO_DOC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UIGR_TIPO_DOC.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DS_NOMBRE", "Documento", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SIS_SUFIJO", "SIS_SUFIJO", 68, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SIS_EXCLU_SUFIJO", "SIS_EXCLU_SUFIJO", 105, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NM_CHARS_SERIE", "NM_CHARS_SERIE", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CD_DET", "CD_DET", 49, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CD_TIPO", "CD_TIPO", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FLG_COMPRA", "FLG_COMPRA", 77, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FLG_VENTA", "FLG_VENTA", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FLG_IMPO_SAE", "FLG_IMPO_SAE", 85, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FLG_COMPRA_GRAVADA", "FLG_COMPRA_GRAVADA", 131, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NM_CHARS_SUFIJO", "NM_CHARS_SUFIJO", 107, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SIS_EXCLU_SUFIJO_2", "SIS_EXCLU_SUFIJO_2", 117, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.UIGR_TIPO_DOC.DataSource = Me.IVATIPODOCUMENTOBindingSource
        Me.UIGR_TIPO_DOC.DisplayMember = "DS_NOMBRE"
        Me.UIGR_TIPO_DOC.Name = "UIGR_TIPO_DOC"
        Me.UIGR_TIPO_DOC.ValueMember = "ID"
        '
        'IVATIPODOCUMENTOBindingSource
        '
        Me.IVATIPODOCUMENTOBindingSource.DataSource = GetType(IVA.IVA_TIPO_DOCUMENTO)
        '
        'colSTATUS
        '
        Me.colSTATUS.Caption = "Status"
        Me.colSTATUS.FieldName = "STATUS"
        Me.colSTATUS.Name = "colSTATUS"
        Me.colSTATUS.OptionsColumn.AllowEdit = False
        Me.colSTATUS.OptionsColumn.ReadOnly = True
        '
        'colFLG_BLOQUEADO
        '
        Me.colFLG_BLOQUEADO.Caption = "Bloqueado"
        Me.colFLG_BLOQUEADO.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colFLG_BLOQUEADO.FieldName = "FLG_BLOQUEADO"
        Me.colFLG_BLOQUEADO.Name = "colFLG_BLOQUEADO"
        Me.colFLG_BLOQUEADO.OptionsColumn.AllowEdit = False
        Me.colFLG_BLOQUEADO.OptionsColumn.ReadOnly = True
        Me.colFLG_BLOQUEADO.Visible = True
        Me.colFLG_BLOQUEADO.VisibleIndex = 13
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = Global.Microsoft.VisualBasic.ChrW(83)
        Me.RepositoryItemCheckEdit1.ValueUnchecked = Global.Microsoft.VisualBasic.ChrW(78)
        '
        'colDS_CLIENTE
        '
        Me.colDS_CLIENTE.Caption = "Nombre de cliente"
        Me.colDS_CLIENTE.FieldName = "DS_PROVEEDOR"
        Me.colDS_CLIENTE.Name = "colDS_CLIENTE"
        Me.colDS_CLIENTE.OptionsColumn.AllowEdit = False
        Me.colDS_CLIENTE.OptionsColumn.ReadOnly = True
        '
        'colDS_NUM_REG_FISC
        '
        Me.colDS_NUM_REG_FISC.Caption = "NRF"
        Me.colDS_NUM_REG_FISC.FieldName = "DS_NUM_REG_FISC"
        Me.colDS_NUM_REG_FISC.Name = "colDS_NUM_REG_FISC"
        Me.colDS_NUM_REG_FISC.OptionsColumn.AllowEdit = False
        Me.colDS_NUM_REG_FISC.OptionsColumn.ReadOnly = True
        Me.colDS_NUM_REG_FISC.Visible = True
        Me.colDS_NUM_REG_FISC.VisibleIndex = 3
        '
        'colDS_NIT
        '
        Me.colDS_NIT.Caption = "NIT"
        Me.colDS_NIT.FieldName = "DS_NIT"
        Me.colDS_NIT.Name = "colDS_NIT"
        Me.colDS_NIT.OptionsColumn.AllowEdit = False
        Me.colDS_NIT.OptionsColumn.ReadOnly = True
        Me.colDS_NIT.Visible = True
        Me.colDS_NIT.VisibleIndex = 4
        '
        'colDS_TIPO_DOC
        '
        Me.colDS_TIPO_DOC.Caption = "Tipo doc."
        Me.colDS_TIPO_DOC.FieldName = "DS_TIPO_DOC"
        Me.colDS_TIPO_DOC.Name = "colDS_TIPO_DOC"
        Me.colDS_TIPO_DOC.OptionsColumn.AllowEdit = False
        Me.colDS_TIPO_DOC.OptionsColumn.ReadOnly = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.UIBR_IMPORTAR, Me.uibtn_unlock})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 343)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(965, 142)
        '
        'UIBR_IMPORTAR
        '
        Me.UIBR_IMPORTAR.Caption = "Importar SAE"
        Me.UIBR_IMPORTAR.Id = 4
        Me.UIBR_IMPORTAR.LargeGlyph = Global.IVASAE.My.Resources.Resources._1422311931_Upload
        Me.UIBR_IMPORTAR.LargeWidth = 100
        Me.UIBR_IMPORTAR.Name = "UIBR_IMPORTAR"
        Me.UIBR_IMPORTAR.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'uibtn_unlock
        '
        Me.uibtn_unlock.Caption = "Desbloquear"
        Me.uibtn_unlock.Glyph = Global.IVASAE.My.Resources.Resources._1478728467_unlock_green
        Me.uibtn_unlock.Id = 5
        Me.uibtn_unlock.Name = "uibtn_unlock"
        Me.uibtn_unlock.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
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
        Me.RibbonPageGroup1.ItemLinks.Add(Me.uibtn_unlock)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Mantenimiento"
        '
        'colFLG_NO_INCLUIR
        '
        Me.colFLG_NO_INCLUIR.Caption = "Excluir"
        Me.colFLG_NO_INCLUIR.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colFLG_NO_INCLUIR.FieldName = "FLG_NO_INCLUIR"
        Me.colFLG_NO_INCLUIR.Name = "colFLG_NO_INCLUIR"
        Me.colFLG_NO_INCLUIR.Visible = True
        Me.colFLG_NO_INCLUIR.VisibleIndex = 14
        '
        'FORM_IVA_DOC_COMPRA_SAE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(965, 485)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FORM_IVA_DOC_COMPRA_SAE"
        Me.Controls.SetChildIndex(Me.UIGROUP_MAIN, 0)
        Me.Controls.SetChildIndex(Me.RibbonControl1, 0)
        CType(Me.UIGRIDCONTROL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGRIDVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIPANELSTATUS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIPANELSTATUS.ResumeLayout(False)
        CType(Me.UIGROUP_MAIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIGROUP_MAIN.ResumeLayout(False)
        CType(Me.VIVADOCCOMPRASAEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGR_CVE_PROVEEDOR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IVACLIEPROVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UICALC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGR_TIPO_DOC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IVATIPODOCUMENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VIVADOCCOMPRASAEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCVE_DOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCVE_CLIE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFE_FECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFE_RECEPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_MES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_ANIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_EXENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_GRAVADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_IVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_RENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_IVA_RETENIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_IVA_PERCIVIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_TOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_TIPO_DOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTATUS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFLG_BLOQUEADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_CLIENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NUM_REG_FISC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_TIPO_DOC As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Public WithEvents UIBR_IMPORTAR As DevExpress.XtraBars.BarButtonItem
    Public WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Public WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents UIGR_CVE_PROVEEDOR As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents IVACLIEPROVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UIGR_TIPO_DOC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents IVATIPODOCUMENTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UICALC As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Friend WithEvents uibtn_unlock As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colFLG_NO_INCLUIR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLAVE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn

End Class
