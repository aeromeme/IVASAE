<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_IVA_DOC_NOSAE
    Inherits IVASAE.MasterFormTab

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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.VIVADOCNOSAEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_CLIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFE_FECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFE_RECEPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_MES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_ANIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_GRAVADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_EXENTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_IVA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_RENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_IVA_RETENIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_IVA_PERCIVIDO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_TIPO_DOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFLG_COMPRA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFLG_VENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCLAVE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_CLIENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_NIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_NUM_REG_FISC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_TIPO_DOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.UIID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.uilblclieprov = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.uilblrenta = New DevExpress.XtraEditors.LabelControl()
        Me.uilblretencion = New DevExpress.XtraEditors.LabelControl()
        Me.uilblpercepcion = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.UIFE_FECHA = New DevExpress.XtraEditors.DateEdit()
        Me.UIID_CLIE = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.IVACLIEPROVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDS_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_NUM_REG_FISC1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_GIRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_NIT1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCLAVE1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UIID_TIPO_DOC = New DevExpress.XtraEditors.LookUpEdit()
        Me.IVATIPODOCUMENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UICVE_DOC = New DevExpress.XtraEditors.TextEdit()
        Me.UINM_EXENTO = New DevExpress.XtraEditors.CalcEdit()
        Me.UINM_GRAVADO = New DevExpress.XtraEditors.CalcEdit()
        Me.UINM_IVA = New DevExpress.XtraEditors.CalcEdit()
        Me.UINM_RENTA = New DevExpress.XtraEditors.CalcEdit()
        Me.UINM_IVA_RETENIDO = New DevExpress.XtraEditors.CalcEdit()
        Me.UINM_IVA_PERCIVIDO = New DevExpress.XtraEditors.CalcEdit()
        Me.UINM_TOTAL = New DevExpress.XtraEditors.CalcEdit()
        Me.colCD_SERIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UIFACTURA = New DevExpress.XtraEditors.CalcEdit()
        Me.UILBLFACTURA = New DevExpress.XtraEditors.LabelControl()
        CType(Me.UITABCONTROL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UITABCONTROL.SuspendLayout()
        CType(Me.UIGRIDCONTROL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIPANELDATOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIPANELDATOS.SuspendLayout()
        CType(Me.UIPANELSTATUS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIPANELSTATUS.SuspendLayout()
        Me.UITABPAG_GEN.SuspendLayout()
        Me.UITABPAG_DET.SuspendLayout()
        CType(Me.UIGRIDVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGROUP_MAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIGROUP_MAIN.SuspendLayout()
        CType(Me.VIVADOCNOSAEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIFE_FECHA.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIFE_FECHA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIID_CLIE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IVACLIEPROVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIID_TIPO_DOC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IVATIPODOCUMENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UICVE_DOC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UINM_EXENTO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UINM_GRAVADO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UINM_IVA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UINM_RENTA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UINM_IVA_RETENIDO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UINM_IVA_PERCIVIDO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UINM_TOTAL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIFACTURA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UITABCONTROL
        '
        Me.UITABCONTROL.AppearancePage.Header.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.UITABCONTROL.AppearancePage.Header.Options.UseFont = True
        Me.UITABCONTROL.SelectedTabPage = Me.UITABPAG_GEN
        '
        'UIGRIDCONTROL
        '
        Me.UIGRIDCONTROL.DataSource = Me.VIVADOCNOSAEBindingSource
        '
        'UIPANELDATOS
        '
        Me.UIPANELDATOS.Controls.Add(Me.UILBLFACTURA)
        Me.UIPANELDATOS.Controls.Add(Me.UIFACTURA)
        Me.UIPANELDATOS.Controls.Add(Me.UINM_TOTAL)
        Me.UIPANELDATOS.Controls.Add(Me.UINM_IVA_PERCIVIDO)
        Me.UIPANELDATOS.Controls.Add(Me.UINM_IVA_RETENIDO)
        Me.UIPANELDATOS.Controls.Add(Me.UINM_RENTA)
        Me.UIPANELDATOS.Controls.Add(Me.UINM_IVA)
        Me.UIPANELDATOS.Controls.Add(Me.UINM_GRAVADO)
        Me.UIPANELDATOS.Controls.Add(Me.UINM_EXENTO)
        Me.UIPANELDATOS.Controls.Add(Me.UICVE_DOC)
        Me.UIPANELDATOS.Controls.Add(Me.UIID_TIPO_DOC)
        Me.UIPANELDATOS.Controls.Add(Me.UIID_CLIE)
        Me.UIPANELDATOS.Controls.Add(Me.UIFE_FECHA)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl11)
        Me.UIPANELDATOS.Controls.Add(Me.uilblpercepcion)
        Me.UIPANELDATOS.Controls.Add(Me.uilblretencion)
        Me.UIPANELDATOS.Controls.Add(Me.uilblrenta)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl7)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl6)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl5)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl4)
        Me.UIPANELDATOS.Controls.Add(Me.uilblclieprov)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl2)
        Me.UIPANELDATOS.Controls.Add(Me.UIID)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl1)
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
        'UIGRIDVIEW
        '
        Me.UIGRIDVIEW.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colID_CLIE, Me.colFE_FECHA, Me.colFE_RECEPCION, Me.colNM_MES, Me.colNM_ANIO, Me.colNM_GRAVADO, Me.colNM_EXENTO, Me.colNM_IVA, Me.colNM_RENTA, Me.colNM_IVA_RETENIDO, Me.colNM_IVA_PERCIVIDO, Me.colNM_TOTAL, Me.colID_TIPO_DOC, Me.colFLG_COMPRA, Me.colFLG_VENTA, Me.colCLAVE, Me.colDS_CLIENTE, Me.colDS_NIT, Me.colDS_NUM_REG_FISC, Me.colDS_TIPO_DOC, Me.colCD_SERIE})
        Me.UIGRIDVIEW.OptionsBehavior.Editable = False
        Me.UIGRIDVIEW.OptionsMenu.EnableFooterMenu = False
        Me.UIGRIDVIEW.OptionsMenu.EnableGroupPanelMenu = False
        Me.UIGRIDVIEW.OptionsView.ColumnAutoWidth = False
        Me.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = True
        Me.UIGRIDVIEW.OptionsView.ShowDetailButtons = False
        Me.UIGRIDVIEW.OptionsView.ShowFooter = True
        '
        'UIGROUP_MAIN
        '
        Me.UIGROUP_MAIN.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UIGROUP_MAIN.AppearanceCaption.ForeColor = System.Drawing.Color.White
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseFont = True
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseForeColor = True
        '
        'VIVADOCNOSAEBindingSource
        '
        Me.VIVADOCNOSAEBindingSource.DataSource = GetType(IVA.V_IVA_DOC_NO_SAE)
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colID_CLIE
        '
        Me.colID_CLIE.FieldName = "ID_CLIE"
        Me.colID_CLIE.Name = "colID_CLIE"
        '
        'colFE_FECHA
        '
        Me.colFE_FECHA.Caption = "Fecha"
        Me.colFE_FECHA.FieldName = "FE_FECHA"
        Me.colFE_FECHA.Name = "colFE_FECHA"
        Me.colFE_FECHA.Visible = True
        Me.colFE_FECHA.VisibleIndex = 2
        Me.colFE_FECHA.Width = 112
        '
        'colFE_RECEPCION
        '
        Me.colFE_RECEPCION.FieldName = "FE_RECEPCION"
        Me.colFE_RECEPCION.Name = "colFE_RECEPCION"
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
        'colNM_GRAVADO
        '
        Me.colNM_GRAVADO.Caption = "Gravado"
        Me.colNM_GRAVADO.FieldName = "NM_GRAVADO"
        Me.colNM_GRAVADO.Name = "colNM_GRAVADO"
        Me.colNM_GRAVADO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_GRAVADO", "{0:n2}")})
        Me.colNM_GRAVADO.Visible = True
        Me.colNM_GRAVADO.VisibleIndex = 4
        Me.colNM_GRAVADO.Width = 109
        '
        'colNM_EXENTO
        '
        Me.colNM_EXENTO.Caption = "Exento"
        Me.colNM_EXENTO.FieldName = "NM_EXENTO"
        Me.colNM_EXENTO.Name = "colNM_EXENTO"
        Me.colNM_EXENTO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_EXENTO", "{0:n2}")})
        Me.colNM_EXENTO.Visible = True
        Me.colNM_EXENTO.VisibleIndex = 5
        Me.colNM_EXENTO.Width = 104
        '
        'colNM_IVA
        '
        Me.colNM_IVA.Caption = "IVA"
        Me.colNM_IVA.FieldName = "NM_IVA"
        Me.colNM_IVA.Name = "colNM_IVA"
        Me.colNM_IVA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_IVA", "{0:n2}")})
        Me.colNM_IVA.Visible = True
        Me.colNM_IVA.VisibleIndex = 6
        Me.colNM_IVA.Width = 96
        '
        'colNM_RENTA
        '
        Me.colNM_RENTA.Caption = "Renta"
        Me.colNM_RENTA.FieldName = "NM_RENTA"
        Me.colNM_RENTA.Name = "colNM_RENTA"
        Me.colNM_RENTA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_RENTA", "{0:n2}")})
        Me.colNM_RENTA.Visible = True
        Me.colNM_RENTA.VisibleIndex = 7
        Me.colNM_RENTA.Width = 102
        '
        'colNM_IVA_RETENIDO
        '
        Me.colNM_IVA_RETENIDO.Caption = "Retencion"
        Me.colNM_IVA_RETENIDO.FieldName = "NM_IVA_RETENIDO"
        Me.colNM_IVA_RETENIDO.Name = "colNM_IVA_RETENIDO"
        Me.colNM_IVA_RETENIDO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_IVA_RETENIDO", "{0:n2}")})
        Me.colNM_IVA_RETENIDO.Visible = True
        Me.colNM_IVA_RETENIDO.VisibleIndex = 8
        Me.colNM_IVA_RETENIDO.Width = 96
        '
        'colNM_IVA_PERCIVIDO
        '
        Me.colNM_IVA_PERCIVIDO.Caption = "Percepcion"
        Me.colNM_IVA_PERCIVIDO.FieldName = "NM_IVA_PERCIVIDO"
        Me.colNM_IVA_PERCIVIDO.Name = "colNM_IVA_PERCIVIDO"
        Me.colNM_IVA_PERCIVIDO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_IVA_PERCIVIDO", "{0:n2}")})
        Me.colNM_IVA_PERCIVIDO.Visible = True
        Me.colNM_IVA_PERCIVIDO.VisibleIndex = 9
        Me.colNM_IVA_PERCIVIDO.Width = 91
        '
        'colNM_TOTAL
        '
        Me.colNM_TOTAL.Caption = "TOTAL"
        Me.colNM_TOTAL.FieldName = "NM_TOTAL"
        Me.colNM_TOTAL.Name = "colNM_TOTAL"
        Me.colNM_TOTAL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NM_TOTAL", "{0:n2}")})
        Me.colNM_TOTAL.Visible = True
        Me.colNM_TOTAL.VisibleIndex = 10
        Me.colNM_TOTAL.Width = 99
        '
        'colID_TIPO_DOC
        '
        Me.colID_TIPO_DOC.FieldName = "ID_TIPO_DOC"
        Me.colID_TIPO_DOC.Name = "colID_TIPO_DOC"
        '
        'colFLG_COMPRA
        '
        Me.colFLG_COMPRA.FieldName = "FLG_COMPRA"
        Me.colFLG_COMPRA.Name = "colFLG_COMPRA"
        '
        'colFLG_VENTA
        '
        Me.colFLG_VENTA.FieldName = "FLG_VENTA"
        Me.colFLG_VENTA.Name = "colFLG_VENTA"
        '
        'colCLAVE
        '
        Me.colCLAVE.Caption = "Clave cliente"
        Me.colCLAVE.FieldName = "CLAVE"
        Me.colCLAVE.Name = "colCLAVE"
        Me.colCLAVE.Visible = True
        Me.colCLAVE.VisibleIndex = 13
        Me.colCLAVE.Width = 93
        '
        'colDS_CLIENTE
        '
        Me.colDS_CLIENTE.Caption = "Cliente"
        Me.colDS_CLIENTE.FieldName = "DS_CLIENTE"
        Me.colDS_CLIENTE.Name = "colDS_CLIENTE"
        Me.colDS_CLIENTE.Visible = True
        Me.colDS_CLIENTE.VisibleIndex = 3
        Me.colDS_CLIENTE.Width = 271
        '
        'colDS_NIT
        '
        Me.colDS_NIT.Caption = "NIT"
        Me.colDS_NIT.FieldName = "DS_NIT"
        Me.colDS_NIT.Name = "colDS_NIT"
        Me.colDS_NIT.Visible = True
        Me.colDS_NIT.VisibleIndex = 11
        Me.colDS_NIT.Width = 165
        '
        'colDS_NUM_REG_FISC
        '
        Me.colDS_NUM_REG_FISC.Caption = "NRF"
        Me.colDS_NUM_REG_FISC.FieldName = "DS_NUM_REG_FISC"
        Me.colDS_NUM_REG_FISC.Name = "colDS_NUM_REG_FISC"
        Me.colDS_NUM_REG_FISC.Visible = True
        Me.colDS_NUM_REG_FISC.VisibleIndex = 12
        Me.colDS_NUM_REG_FISC.Width = 154
        '
        'colDS_TIPO_DOC
        '
        Me.colDS_TIPO_DOC.Caption = "Tipo Doc."
        Me.colDS_TIPO_DOC.FieldName = "DS_TIPO_DOC"
        Me.colDS_TIPO_DOC.Name = "colDS_TIPO_DOC"
        Me.colDS_TIPO_DOC.Visible = True
        Me.colDS_TIPO_DOC.VisibleIndex = 0
        Me.colDS_TIPO_DOC.Width = 95
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(87, 47)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ID"
        '
        'UIID
        '
        Me.UIID.Location = New System.Drawing.Point(104, 44)
        Me.UIID.Name = "UIID"
        Me.UIID.Properties.ReadOnly = True
        Me.UIID.Size = New System.Drawing.Size(100, 20)
        Me.UIID.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(69, 77)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Fecha"
        '
        'uilblclieprov
        '
        Me.uilblclieprov.Location = New System.Drawing.Point(44, 109)
        Me.uilblclieprov.Name = "uilblclieprov"
        Me.uilblclieprov.Size = New System.Drawing.Size(33, 13)
        Me.uilblclieprov.TabIndex = 3
        Me.uilblclieprov.Text = "Cliente"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(44, 141)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Documento"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(63, 193)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl5.TabIndex = 5
        Me.LabelControl5.Text = "Exento"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(57, 230)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl6.TabIndex = 6
        Me.LabelControl6.Text = "Gravado"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(281, 193)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl7.TabIndex = 7
        Me.LabelControl7.Text = "IVA"
        '
        'uilblrenta
        '
        Me.uilblrenta.Location = New System.Drawing.Point(269, 272)
        Me.uilblrenta.Name = "uilblrenta"
        Me.uilblrenta.Size = New System.Drawing.Size(29, 13)
        Me.uilblrenta.TabIndex = 8
        Me.uilblrenta.Text = "Renta"
        '
        'uilblretencion
        '
        Me.uilblretencion.Location = New System.Drawing.Point(250, 316)
        Me.uilblretencion.Name = "uilblretencion"
        Me.uilblretencion.Size = New System.Drawing.Size(48, 13)
        Me.uilblretencion.TabIndex = 9
        Me.uilblretencion.Text = "Retencion"
        '
        'uilblpercepcion
        '
        Me.uilblpercepcion.Location = New System.Drawing.Point(246, 230)
        Me.uilblpercepcion.Name = "uilblpercepcion"
        Me.uilblpercepcion.Size = New System.Drawing.Size(52, 13)
        Me.uilblpercepcion.TabIndex = 10
        Me.uilblpercepcion.Text = "Percepcion"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(457, 193)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl11.TabIndex = 11
        Me.LabelControl11.Text = "TOTAL"
        '
        'UIFE_FECHA
        '
        Me.UIFE_FECHA.EditValue = Nothing
        Me.UIFE_FECHA.Location = New System.Drawing.Point(105, 77)
        Me.UIFE_FECHA.Name = "UIFE_FECHA"
        Me.UIFE_FECHA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UIFE_FECHA.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.UIFE_FECHA.Size = New System.Drawing.Size(100, 20)
        Me.UIFE_FECHA.TabIndex = 12
        '
        'UIID_CLIE
        '
        Me.UIID_CLIE.Location = New System.Drawing.Point(106, 106)
        Me.UIID_CLIE.Name = "UIID_CLIE"
        Me.UIID_CLIE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UIID_CLIE.Properties.DataSource = Me.IVACLIEPROVBindingSource
        Me.UIID_CLIE.Properties.DisplayMember = "DS_NOMBRE"
        Me.UIID_CLIE.Properties.PopupFormSize = New System.Drawing.Size(600, 0)
        Me.UIID_CLIE.Properties.ValueMember = "ID"
        Me.UIID_CLIE.Properties.View = Me.GridLookUpEdit1View
        Me.UIID_CLIE.Size = New System.Drawing.Size(330, 20)
        Me.UIID_CLIE.TabIndex = 13
        '
        'IVACLIEPROVBindingSource
        '
        Me.IVACLIEPROVBindingSource.DataSource = GetType(IVA.IVA_CLIE_PROV)
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDS_NOMBRE, Me.colDS_NUM_REG_FISC1, Me.colDS_GIRO, Me.colDS_NIT1, Me.colCLAVE1})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit1View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDS_GIRO, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colDS_NOMBRE
        '
        Me.colDS_NOMBRE.Caption = "Nombre"
        Me.colDS_NOMBRE.FieldName = "DS_NOMBRE"
        Me.colDS_NOMBRE.Name = "colDS_NOMBRE"
        Me.colDS_NOMBRE.Visible = True
        Me.colDS_NOMBRE.VisibleIndex = 1
        Me.colDS_NOMBRE.Width = 775
        '
        'colDS_NUM_REG_FISC1
        '
        Me.colDS_NUM_REG_FISC1.Caption = "NRF"
        Me.colDS_NUM_REG_FISC1.FieldName = "DS_NUM_REG_FISC"
        Me.colDS_NUM_REG_FISC1.Name = "colDS_NUM_REG_FISC1"
        Me.colDS_NUM_REG_FISC1.Visible = True
        Me.colDS_NUM_REG_FISC1.VisibleIndex = 2
        Me.colDS_NUM_REG_FISC1.Width = 339
        '
        'colDS_GIRO
        '
        Me.colDS_GIRO.Caption = "Giro"
        Me.colDS_GIRO.FieldName = "DS_GIRO"
        Me.colDS_GIRO.Name = "colDS_GIRO"
        Me.colDS_GIRO.Width = 252
        '
        'colDS_NIT1
        '
        Me.colDS_NIT1.Caption = "NIT"
        Me.colDS_NIT1.FieldName = "DS_NIT"
        Me.colDS_NIT1.Name = "colDS_NIT1"
        Me.colDS_NIT1.Visible = True
        Me.colDS_NIT1.VisibleIndex = 3
        Me.colDS_NIT1.Width = 392
        '
        'colCLAVE1
        '
        Me.colCLAVE1.Caption = "Clave"
        Me.colCLAVE1.FieldName = "CLAVE"
        Me.colCLAVE1.Name = "colCLAVE1"
        Me.colCLAVE1.Visible = True
        Me.colCLAVE1.VisibleIndex = 0
        Me.colCLAVE1.Width = 228
        '
        'UIID_TIPO_DOC
        '
        Me.UIID_TIPO_DOC.Location = New System.Drawing.Point(105, 137)
        Me.UIID_TIPO_DOC.Name = "UIID_TIPO_DOC"
        Me.UIID_TIPO_DOC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UIID_TIPO_DOC.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DS_NOMBRE", "Documento", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SIS_SUFIJO", "SIS_SUFIJO", 68, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SIS_EXCLU_SUFIJO", "SIS_EXCLU_SUFIJO", 105, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NM_CHARS_SERIE", "NM_CHARS_SERIE", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CD_DET", "CD_DET", 49, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CD_TIPO", "CD_TIPO", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FLG_COMPRA", "FLG_COMPRA", 77, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FLG_VENTA", "FLG_VENTA", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FLG_IMPO_SAE", "FLG_IMPO_SAE", 85, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FLG_COMPRA_GRAVADA", "FLG_COMPRA_GRAVADA", 131, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NM_CHARS_SUFIJO", "NM_CHARS_SUFIJO", 107, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SIS_EXCLU_SUFIJO_2", "SIS_EXCLU_SUFIJO_2", 117, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.UIID_TIPO_DOC.Properties.DataSource = Me.IVATIPODOCUMENTOBindingSource
        Me.UIID_TIPO_DOC.Properties.DisplayMember = "DS_NOMBRE"
        Me.UIID_TIPO_DOC.Properties.ValueMember = "ID"
        Me.UIID_TIPO_DOC.Size = New System.Drawing.Size(122, 20)
        Me.UIID_TIPO_DOC.TabIndex = 14
        '
        'IVATIPODOCUMENTOBindingSource
        '
        Me.IVATIPODOCUMENTOBindingSource.DataSource = GetType(IVA.IVA_TIPO_DOCUMENTO)
        '
        'UICVE_DOC
        '
        Me.UICVE_DOC.Location = New System.Drawing.Point(243, 138)
        Me.UICVE_DOC.Name = "UICVE_DOC"
        Me.UICVE_DOC.Size = New System.Drawing.Size(193, 20)
        Me.UICVE_DOC.TabIndex = 15
        Me.UICVE_DOC.ToolTip = "Serie"
        '
        'UINM_EXENTO
        '
        Me.UINM_EXENTO.Location = New System.Drawing.Point(105, 190)
        Me.UINM_EXENTO.Name = "UINM_EXENTO"
        Me.UINM_EXENTO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UINM_EXENTO.Properties.Mask.EditMask = "n2"
        Me.UINM_EXENTO.Size = New System.Drawing.Size(121, 20)
        Me.UINM_EXENTO.TabIndex = 17
        '
        'UINM_GRAVADO
        '
        Me.UINM_GRAVADO.Location = New System.Drawing.Point(105, 227)
        Me.UINM_GRAVADO.Name = "UINM_GRAVADO"
        Me.UINM_GRAVADO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UINM_GRAVADO.Properties.Mask.EditMask = "n2"
        Me.UINM_GRAVADO.Size = New System.Drawing.Size(121, 20)
        Me.UINM_GRAVADO.TabIndex = 18
        '
        'UINM_IVA
        '
        Me.UINM_IVA.Location = New System.Drawing.Point(318, 190)
        Me.UINM_IVA.Name = "UINM_IVA"
        Me.UINM_IVA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UINM_IVA.Properties.Mask.EditMask = "n2"
        Me.UINM_IVA.Size = New System.Drawing.Size(118, 20)
        Me.UINM_IVA.TabIndex = 19
        '
        'UINM_RENTA
        '
        Me.UINM_RENTA.Location = New System.Drawing.Point(318, 269)
        Me.UINM_RENTA.Name = "UINM_RENTA"
        Me.UINM_RENTA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UINM_RENTA.Properties.Mask.EditMask = "n2"
        Me.UINM_RENTA.Size = New System.Drawing.Size(118, 20)
        Me.UINM_RENTA.TabIndex = 20
        '
        'UINM_IVA_RETENIDO
        '
        Me.UINM_IVA_RETENIDO.Location = New System.Drawing.Point(318, 313)
        Me.UINM_IVA_RETENIDO.Name = "UINM_IVA_RETENIDO"
        Me.UINM_IVA_RETENIDO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UINM_IVA_RETENIDO.Properties.Mask.EditMask = "n2"
        Me.UINM_IVA_RETENIDO.Size = New System.Drawing.Size(118, 20)
        Me.UINM_IVA_RETENIDO.TabIndex = 21
        '
        'UINM_IVA_PERCIVIDO
        '
        Me.UINM_IVA_PERCIVIDO.Location = New System.Drawing.Point(318, 227)
        Me.UINM_IVA_PERCIVIDO.Name = "UINM_IVA_PERCIVIDO"
        Me.UINM_IVA_PERCIVIDO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UINM_IVA_PERCIVIDO.Properties.Mask.EditMask = "n2"
        Me.UINM_IVA_PERCIVIDO.Size = New System.Drawing.Size(118, 20)
        Me.UINM_IVA_PERCIVIDO.TabIndex = 22
        '
        'UINM_TOTAL
        '
        Me.UINM_TOTAL.Location = New System.Drawing.Point(506, 189)
        Me.UINM_TOTAL.Name = "UINM_TOTAL"
        Me.UINM_TOTAL.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.UINM_TOTAL.Properties.Mask.EditMask = "n2"
        Me.UINM_TOTAL.Properties.ReadOnly = True
        Me.UINM_TOTAL.Size = New System.Drawing.Size(100, 20)
        Me.UINM_TOTAL.TabIndex = 23
        '
        'colCD_SERIE
        '
        Me.colCD_SERIE.Caption = "Numero"
        Me.colCD_SERIE.FieldName = "CVE_DOC"
        Me.colCD_SERIE.Name = "colCD_SERIE"
        Me.colCD_SERIE.Visible = True
        Me.colCD_SERIE.VisibleIndex = 1
        Me.colCD_SERIE.Width = 130
        '
        'UIFACTURA
        '
        Me.UIFACTURA.Location = New System.Drawing.Point(106, 269)
        Me.UIFACTURA.Name = "UIFACTURA"
        Me.UIFACTURA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UIFACTURA.Properties.Mask.EditMask = "n2"
        Me.UIFACTURA.Size = New System.Drawing.Size(121, 20)
        Me.UIFACTURA.TabIndex = 24
        Me.UIFACTURA.Visible = False
        '
        'UILBLFACTURA
        '
        Me.UILBLFACTURA.Location = New System.Drawing.Point(56, 272)
        Me.UILBLFACTURA.Name = "UILBLFACTURA"
        Me.UILBLFACTURA.Size = New System.Drawing.Size(37, 13)
        Me.UILBLFACTURA.TabIndex = 25
        Me.UILBLFACTURA.Text = "Factura"
        Me.UILBLFACTURA.Visible = False
        '
        'FORM_IVA_DOC_NOSAE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(965, 560)
        Me.Name = "FORM_IVA_DOC_NOSAE"
        CType(Me.UITABCONTROL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UITABCONTROL.ResumeLayout(False)
        CType(Me.UIGRIDCONTROL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIPANELDATOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIPANELDATOS.ResumeLayout(False)
        Me.UIPANELDATOS.PerformLayout()
        CType(Me.UIPANELSTATUS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIPANELSTATUS.ResumeLayout(False)
        Me.UITABPAG_GEN.ResumeLayout(False)
        Me.UITABPAG_DET.ResumeLayout(False)
        CType(Me.UIGRIDVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGROUP_MAIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIGROUP_MAIN.ResumeLayout(False)
        CType(Me.VIVADOCNOSAEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIFE_FECHA.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIFE_FECHA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIID_CLIE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IVACLIEPROVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIID_TIPO_DOC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IVATIPODOCUMENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UICVE_DOC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UINM_EXENTO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UINM_GRAVADO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UINM_IVA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UINM_RENTA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UINM_IVA_RETENIDO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UINM_IVA_PERCIVIDO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UINM_TOTAL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIFACTURA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VIVADOCNOSAEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_CLIE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFE_FECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFE_RECEPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_MES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_ANIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_GRAVADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_EXENTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_IVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_RENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_IVA_RETENIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_IVA_PERCIVIDO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_TOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_TIPO_DOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFLG_COMPRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFLG_VENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLAVE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_CLIENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NUM_REG_FISC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_TIPO_DOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents uilblpercepcion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents uilblretencion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents uilblrenta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents uilblclieprov As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UIID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UINM_EXENTO As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents UICVE_DOC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UIID_TIPO_DOC As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents UIID_CLIE As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UIFE_FECHA As DevExpress.XtraEditors.DateEdit
    Friend WithEvents UINM_TOTAL As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents UINM_IVA_PERCIVIDO As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents UINM_IVA_RETENIDO As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents UINM_RENTA As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents UINM_IVA As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents UINM_GRAVADO As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents IVATIPODOCUMENTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IVACLIEPROVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colDS_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NUM_REG_FISC1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_GIRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NIT1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLAVE1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCD_SERIE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UILBLFACTURA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UIFACTURA As DevExpress.XtraEditors.CalcEdit

End Class
