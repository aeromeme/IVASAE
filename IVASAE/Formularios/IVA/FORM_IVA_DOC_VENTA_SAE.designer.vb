<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_IVA_DOC_VENTA_SAE
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
        Me.VIVADOCVENTASAEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCVE_DOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCVE_CLIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UIGR_CVECLIE = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.IVACLIEPROVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDS_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCLAVE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFE_FECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFE_ELABORACION = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.UIGR_TIPODOC = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
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
        CType(Me.UIGRIDCONTROL,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UIGRIDVIEW,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UIPANELSTATUS,System.ComponentModel.ISupportInitialize).BeginInit
        Me.UIPANELSTATUS.SuspendLayout
        CType(Me.UIGROUP_MAIN,System.ComponentModel.ISupportInitialize).BeginInit
        Me.UIGROUP_MAIN.SuspendLayout
        CType(Me.VIVADOCVENTASAEBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UIGR_CVECLIE,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.IVACLIEPROVBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemGridLookUpEdit1View,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UICALC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UIGR_TIPODOC,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.IVATIPODOCUMENTOBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RepositoryItemCheckEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RibbonControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'UIGRIDCONTROL
        '
        Me.UIGRIDCONTROL.DataSource = Me.VIVADOCVENTASAEBindingSource
        Me.UIGRIDCONTROL.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.UIGR_CVECLIE, Me.UIGR_TIPODOC, Me.RepositoryItemCheckEdit1, Me.UICALC})
        Me.UIGRIDCONTROL.Size = New System.Drawing.Size(1045, 576)
        '
        'UIGRIDVIEW
        '
        Me.UIGRIDVIEW.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCVE_DOC, Me.colCVE_CLIE, Me.colFE_FECHA, Me.colFE_ELABORACION, Me.colNM_MES, Me.colNM_ANIO, Me.colNM_EXENTO, Me.colNM_GRAVADO, Me.colNM_IVA, Me.colNM_RENTA, Me.colNM_IVA_RETENIDO, Me.colNM_IVA_PERCIVIDO, Me.colNM_TOTAL, Me.colID_TIPO_DOC, Me.colSTATUS, Me.colFLG_BLOQUEADO, Me.colDS_CLIENTE, Me.colDS_NUM_REG_FISC, Me.colDS_NIT, Me.colDS_TIPO_DOC, Me.colFLG_NO_INCLUIR})
        Me.UIGRIDVIEW.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.UIGRIDVIEW.OptionsCustomization.AllowGroup = false
        Me.UIGRIDVIEW.OptionsMenu.EnableFooterMenu = false
        Me.UIGRIDVIEW.OptionsMenu.EnableGroupPanelMenu = false
        Me.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = true
        Me.UIGRIDVIEW.OptionsView.ShowFooter = true
        Me.UIGRIDVIEW.OptionsView.ShowGroupPanel = false
        '
        'UIPANELSTATUS
        '
        Me.UIPANELSTATUS.Location = New System.Drawing.Point(2, 614)
        Me.UIPANELSTATUS.Size = New System.Drawing.Size(1045, 27)
        '
        'UINAV
        '
        Me.UINAV.Buttons.Append.Visible = false
        Me.UINAV.Buttons.CancelEdit.Visible = false
        Me.UINAV.Buttons.Edit.Visible = false
        Me.UINAV.Buttons.EndEdit.Visible = false
        Me.UINAV.Buttons.Remove.Visible = false
        Me.UINAV.Size = New System.Drawing.Size(1041, 23)
        '
        'UIGROUP_MAIN
        '
        Me.UIGROUP_MAIN.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UIGROUP_MAIN.AppearanceCaption.ForeColor = System.Drawing.Color.White
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseFont = true
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseForeColor = true
        Me.UIGROUP_MAIN.Size = New System.Drawing.Size(1049, 643)
        '
        'VIVADOCVENTASAEBindingSource
        '
        Me.VIVADOCVENTASAEBindingSource.DataSource = GetType(IVASAE.IVA.V_IVA_DOC_VENTA_SAE)
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = false
        Me.colID.OptionsColumn.ReadOnly = true
        '
        'colCVE_DOC
        '
        Me.colCVE_DOC.Caption = "Documento"
        Me.colCVE_DOC.FieldName = "CVE_DOC"
        Me.colCVE_DOC.Name = "colCVE_DOC"
        Me.colCVE_DOC.Visible = true
        Me.colCVE_DOC.VisibleIndex = 0
        Me.colCVE_DOC.Width = 133
        '
        'colCVE_CLIE
        '
        Me.colCVE_CLIE.Caption = "Cliente"
        Me.colCVE_CLIE.ColumnEdit = Me.UIGR_CVECLIE
        Me.colCVE_CLIE.FieldName = "CVE_CLIE"
        Me.colCVE_CLIE.Name = "colCVE_CLIE"
        Me.colCVE_CLIE.OptionsColumn.AllowEdit = false
        Me.colCVE_CLIE.OptionsColumn.ReadOnly = true
        Me.colCVE_CLIE.Visible = true
        Me.colCVE_CLIE.VisibleIndex = 2
        Me.colCVE_CLIE.Width = 368
        '
        'UIGR_CVECLIE
        '
        Me.UIGR_CVECLIE.AutoHeight = false
        Me.UIGR_CVECLIE.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UIGR_CVECLIE.DataSource = Me.IVACLIEPROVBindingSource
        Me.UIGR_CVECLIE.DisplayMember = "DS_NOMBRE"
        Me.UIGR_CVECLIE.Name = "UIGR_CVECLIE"
        Me.UIGR_CVECLIE.ValueMember = "CLAVE"
        Me.UIGR_CVECLIE.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'IVACLIEPROVBindingSource
        '
        Me.IVACLIEPROVBindingSource.DataSource = GetType(IVASAE.IVA.IVA_CLIE_PROV)
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDS_NOMBRE, Me.colCLAVE})
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowAutoFilterRow = true
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false
        '
        'colDS_NOMBRE
        '
        Me.colDS_NOMBRE.Caption = "Cliente"
        Me.colDS_NOMBRE.FieldName = "DS_NOMBRE"
        Me.colDS_NOMBRE.Name = "colDS_NOMBRE"
        Me.colDS_NOMBRE.Visible = true
        Me.colDS_NOMBRE.VisibleIndex = 1
        Me.colDS_NOMBRE.Width = 1400
        '
        'colCLAVE
        '
        Me.colCLAVE.Caption = "Clave"
        Me.colCLAVE.FieldName = "CLAVE"
        Me.colCLAVE.Name = "colCLAVE"
        Me.colCLAVE.Visible = true
        Me.colCLAVE.VisibleIndex = 0
        Me.colCLAVE.Width = 334
        '
        'colFE_FECHA
        '
        Me.colFE_FECHA.Caption = "Fecha"
        Me.colFE_FECHA.FieldName = "FE_FECHA"
        Me.colFE_FECHA.Name = "colFE_FECHA"
        Me.colFE_FECHA.Visible = true
        Me.colFE_FECHA.VisibleIndex = 5
        Me.colFE_FECHA.Width = 108
        '
        'colFE_ELABORACION
        '
        Me.colFE_ELABORACION.Caption = "Elaboracion"
        Me.colFE_ELABORACION.FieldName = "FE_ELABORACION"
        Me.colFE_ELABORACION.Name = "colFE_ELABORACION"
        Me.colFE_ELABORACION.Visible = true
        Me.colFE_ELABORACION.VisibleIndex = 6
        Me.colFE_ELABORACION.Width = 108
        '
        'colNM_MES
        '
        Me.colNM_MES.FieldName = "NM_MES"
        Me.colNM_MES.Name = "colNM_MES"
        Me.colNM_MES.OptionsColumn.AllowEdit = false
        Me.colNM_MES.OptionsColumn.ReadOnly = true
        '
        'colNM_ANIO
        '
        Me.colNM_ANIO.FieldName = "NM_ANIO"
        Me.colNM_ANIO.Name = "colNM_ANIO"
        Me.colNM_ANIO.OptionsColumn.AllowEdit = false
        Me.colNM_ANIO.OptionsColumn.ReadOnly = true
        '
        'colNM_EXENTO
        '
        Me.colNM_EXENTO.Caption = "Exento"
        Me.colNM_EXENTO.ColumnEdit = Me.UICALC
        Me.colNM_EXENTO.FieldName = "NM_EXENTO"
        Me.colNM_EXENTO.Name = "colNM_EXENTO"
        Me.colNM_EXENTO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_EXENTO", "{0:n2}")})
        Me.colNM_EXENTO.Visible = true
        Me.colNM_EXENTO.VisibleIndex = 7
        Me.colNM_EXENTO.Width = 108
        '
        'UICALC
        '
        Me.UICALC.AutoHeight = false
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
        Me.colNM_GRAVADO.Visible = true
        Me.colNM_GRAVADO.VisibleIndex = 8
        Me.colNM_GRAVADO.Width = 108
        '
        'colNM_IVA
        '
        Me.colNM_IVA.Caption = "IVA"
        Me.colNM_IVA.ColumnEdit = Me.UICALC
        Me.colNM_IVA.FieldName = "NM_IVA"
        Me.colNM_IVA.Name = "colNM_IVA"
        Me.colNM_IVA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_IVA", "{0:n2}")})
        Me.colNM_IVA.Visible = true
        Me.colNM_IVA.VisibleIndex = 9
        Me.colNM_IVA.Width = 108
        '
        'colNM_RENTA
        '
        Me.colNM_RENTA.ColumnEdit = Me.UICALC
        Me.colNM_RENTA.FieldName = "NM_RENTA"
        Me.colNM_RENTA.Name = "colNM_RENTA"
        Me.colNM_RENTA.OptionsColumn.AllowEdit = false
        Me.colNM_RENTA.OptionsColumn.ReadOnly = true
        '
        'colNM_IVA_RETENIDO
        '
        Me.colNM_IVA_RETENIDO.ColumnEdit = Me.UICALC
        Me.colNM_IVA_RETENIDO.FieldName = "NM_IVA_RETENIDO"
        Me.colNM_IVA_RETENIDO.Name = "colNM_IVA_RETENIDO"
        Me.colNM_IVA_RETENIDO.OptionsColumn.AllowEdit = false
        Me.colNM_IVA_RETENIDO.OptionsColumn.ReadOnly = true
        '
        'colNM_IVA_PERCIVIDO
        '
        Me.colNM_IVA_PERCIVIDO.Caption = "Percibido"
        Me.colNM_IVA_PERCIVIDO.ColumnEdit = Me.UICALC
        Me.colNM_IVA_PERCIVIDO.FieldName = "NM_IVA_PERCIVIDO"
        Me.colNM_IVA_PERCIVIDO.Name = "colNM_IVA_PERCIVIDO"
        Me.colNM_IVA_PERCIVIDO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_IVA_PERCIVIDO", "{0:n2}")})
        Me.colNM_IVA_PERCIVIDO.Visible = true
        Me.colNM_IVA_PERCIVIDO.VisibleIndex = 10
        Me.colNM_IVA_PERCIVIDO.Width = 108
        '
        'colNM_TOTAL
        '
        Me.colNM_TOTAL.Caption = "Total"
        Me.colNM_TOTAL.ColumnEdit = Me.UICALC
        Me.colNM_TOTAL.FieldName = "NM_TOTAL"
        Me.colNM_TOTAL.Name = "colNM_TOTAL"
        Me.colNM_TOTAL.OptionsColumn.AllowEdit = false
        Me.colNM_TOTAL.OptionsColumn.ReadOnly = true
        Me.colNM_TOTAL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_TOTAL", "{0:n2}")})
        Me.colNM_TOTAL.Visible = true
        Me.colNM_TOTAL.VisibleIndex = 11
        Me.colNM_TOTAL.Width = 108
        '
        'colID_TIPO_DOC
        '
        Me.colID_TIPO_DOC.Caption = "Tipo documento"
        Me.colID_TIPO_DOC.ColumnEdit = Me.UIGR_TIPODOC
        Me.colID_TIPO_DOC.FieldName = "ID_TIPO_DOC"
        Me.colID_TIPO_DOC.Name = "colID_TIPO_DOC"
        Me.colID_TIPO_DOC.Visible = true
        Me.colID_TIPO_DOC.VisibleIndex = 1
        Me.colID_TIPO_DOC.Width = 133
        '
        'UIGR_TIPODOC
        '
        Me.UIGR_TIPODOC.AutoHeight = false
        Me.UIGR_TIPODOC.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UIGR_TIPODOC.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DS_NOMBRE", "Documento", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SIS_SUFIJO", "SIS_SUFIJO", 68, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SIS_EXCLU_SUFIJO", "SIS_EXCLU_SUFIJO", 105, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NM_CHARS_SERIE", "NM_CHARS_SERIE", 100, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CD_DET", "CD_DET", 49, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CD_TIPO", "CD_TIPO", 54, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FLG_COMPRA", "FLG_COMPRA", 77, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FLG_VENTA", "FLG_VENTA", 66, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FLG_IMPO_SAE", "FLG_IMPO_SAE", 85, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FLG_COMPRA_GRAVADA", "FLG_COMPRA_GRAVADA", 131, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NM_CHARS_SUFIJO", "NM_CHARS_SUFIJO", 107, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SIS_EXCLU_SUFIJO_2", "SIS_EXCLU_SUFIJO_2", 117, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)})
        Me.UIGR_TIPODOC.DataSource = Me.IVATIPODOCUMENTOBindingSource
        Me.UIGR_TIPODOC.DisplayMember = "DS_NOMBRE"
        Me.UIGR_TIPODOC.Name = "UIGR_TIPODOC"
        Me.UIGR_TIPODOC.ValueMember = "ID"
        '
        'IVATIPODOCUMENTOBindingSource
        '
        Me.IVATIPODOCUMENTOBindingSource.DataSource = GetType(IVASAE.IVA.IVA_TIPO_DOCUMENTO)
        '
        'colSTATUS
        '
        Me.colSTATUS.FieldName = "STATUS"
        Me.colSTATUS.Name = "colSTATUS"
        Me.colSTATUS.OptionsColumn.AllowEdit = false
        Me.colSTATUS.OptionsColumn.ReadOnly = true
        '
        'colFLG_BLOQUEADO
        '
        Me.colFLG_BLOQUEADO.Caption = "Bloqueado"
        Me.colFLG_BLOQUEADO.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colFLG_BLOQUEADO.FieldName = "FLG_BLOQUEADO"
        Me.colFLG_BLOQUEADO.Name = "colFLG_BLOQUEADO"
        Me.colFLG_BLOQUEADO.OptionsColumn.AllowEdit = false
        Me.colFLG_BLOQUEADO.OptionsColumn.ReadOnly = true
        Me.colFLG_BLOQUEADO.Visible = true
        Me.colFLG_BLOQUEADO.VisibleIndex = 12
        Me.colFLG_BLOQUEADO.Width = 128
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = false
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = Global.Microsoft.VisualBasic.ChrW(83)
        Me.RepositoryItemCheckEdit1.ValueUnchecked = Global.Microsoft.VisualBasic.ChrW(78)
        '
        'colDS_CLIENTE
        '
        Me.colDS_CLIENTE.FieldName = "DS_CLIENTE"
        Me.colDS_CLIENTE.Name = "colDS_CLIENTE"
        Me.colDS_CLIENTE.OptionsColumn.AllowEdit = false
        Me.colDS_CLIENTE.OptionsColumn.ReadOnly = true
        '
        'colDS_NUM_REG_FISC
        '
        Me.colDS_NUM_REG_FISC.Caption = "NRF"
        Me.colDS_NUM_REG_FISC.FieldName = "DS_NUM_REG_FISC"
        Me.colDS_NUM_REG_FISC.Name = "colDS_NUM_REG_FISC"
        Me.colDS_NUM_REG_FISC.OptionsColumn.AllowEdit = false
        Me.colDS_NUM_REG_FISC.OptionsColumn.ReadOnly = true
        Me.colDS_NUM_REG_FISC.Visible = true
        Me.colDS_NUM_REG_FISC.VisibleIndex = 3
        Me.colDS_NUM_REG_FISC.Width = 108
        '
        'colDS_NIT
        '
        Me.colDS_NIT.Caption = "NIT"
        Me.colDS_NIT.FieldName = "DS_NIT"
        Me.colDS_NIT.Name = "colDS_NIT"
        Me.colDS_NIT.OptionsColumn.AllowEdit = false
        Me.colDS_NIT.OptionsColumn.ReadOnly = true
        Me.colDS_NIT.Visible = true
        Me.colDS_NIT.VisibleIndex = 4
        Me.colDS_NIT.Width = 108
        '
        'colDS_TIPO_DOC
        '
        Me.colDS_TIPO_DOC.FieldName = "DS_TIPO_DOC"
        Me.colDS_TIPO_DOC.Name = "colDS_TIPO_DOC"
        Me.colDS_TIPO_DOC.OptionsColumn.AllowEdit = false
        Me.colDS_TIPO_DOC.OptionsColumn.ReadOnly = true
        '
        'RibbonControl1
        '
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.UIBR_IMPORTAR, Me.uibtn_unlock})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 502)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.Size = New System.Drawing.Size(1049, 141)
        '
        'UIBR_IMPORTAR
        '
        Me.UIBR_IMPORTAR.Caption = "Importar SAE"
        Me.UIBR_IMPORTAR.Id = 4
        Me.UIBR_IMPORTAR.ImageOptions.LargeImage = Global.IVASAE.My.Resources.Resources._1422311931_Upload
        Me.UIBR_IMPORTAR.LargeWidth = 100
        Me.UIBR_IMPORTAR.Name = "UIBR_IMPORTAR"
        Me.UIBR_IMPORTAR.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)  _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText),DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'uibtn_unlock
        '
        Me.uibtn_unlock.Caption = "Desbloquear"
        Me.uibtn_unlock.Id = 5
        Me.uibtn_unlock.ImageOptions.Image = Global.IVASAE.My.Resources.Resources._1478728467_unlock_green
        Me.uibtn_unlock.Name = "uibtn_unlock"
        Me.uibtn_unlock.RibbonStyle = CType(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText)  _
            Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText),DevExpress.XtraBars.Ribbon.RibbonItemStyles)
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
        Me.RibbonPageGroup1.ShowCaptionButton = false
        Me.RibbonPageGroup1.Text = "Mantenimiento"
        '
        'colFLG_NO_INCLUIR
        '
        Me.colFLG_NO_INCLUIR.Caption = "Excluir"
        Me.colFLG_NO_INCLUIR.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colFLG_NO_INCLUIR.FieldName = "FLG_NO_INCLUIR"
        Me.colFLG_NO_INCLUIR.Name = "colFLG_NO_INCLUIR"
        Me.colFLG_NO_INCLUIR.Visible = true
        Me.colFLG_NO_INCLUIR.VisibleIndex = 13
        '
        'FORM_IVA_DOC_VENTA_SAE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.ClientSize = New System.Drawing.Size(1049, 643)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "FORM_IVA_DOC_VENTA_SAE"
        Me.Controls.SetChildIndex(Me.UIGROUP_MAIN, 0)
        Me.Controls.SetChildIndex(Me.RibbonControl1, 0)
        CType(Me.UIGRIDCONTROL,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UIGRIDVIEW,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UIPANELSTATUS,System.ComponentModel.ISupportInitialize).EndInit
        Me.UIPANELSTATUS.ResumeLayout(false)
        CType(Me.UIGROUP_MAIN,System.ComponentModel.ISupportInitialize).EndInit
        Me.UIGROUP_MAIN.ResumeLayout(false)
        CType(Me.VIVADOCVENTASAEBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UIGR_CVECLIE,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.IVACLIEPROVBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemGridLookUpEdit1View,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UICALC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UIGR_TIPODOC,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.IVATIPODOCUMENTOBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RepositoryItemCheckEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RibbonControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents VIVADOCVENTASAEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCVE_DOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCVE_CLIE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFE_FECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFE_ELABORACION As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents UIGR_CVECLIE As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents IVACLIEPROVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UIGR_TIPODOC As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents IVATIPODOCUMENTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents UICALC As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
    Public WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Public WithEvents UIBR_IMPORTAR As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents uibtn_unlock As DevExpress.XtraBars.BarButtonItem
    Public WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Public WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents colFLG_NO_INCLUIR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLAVE As DevExpress.XtraGrid.Columns.GridColumn

End Class
