<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_IVA_TIPO_DOC
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
        Me.IVATIPODOCUMENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_NOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSIS_SUFIJO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSIS_EXCLU_SUFIJO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNM_CHARS_SUFIJO_SERIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCD_DET = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCD_TIPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFLG_COMPRA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFLG_VENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFLG_IMPO_SAE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LABEL1 = New DevExpress.XtraEditors.LabelControl()
        Me.UIID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.UISIS_SUFIJO = New DevExpress.XtraEditors.TextEdit()
        Me.UISIS_EXCLU_SUFIJO = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.UINM_CHARS_SERIE = New DevExpress.XtraEditors.TextEdit()
        Me.UIGRP_IMPOR_PARAM = New DevExpress.XtraEditors.GroupControl()
        Me.UISIS_EXCLU_SUFIJO_2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.UINM_CHARS_SUFIJO = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.UIFLG_COMPRA_GRAVADA = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.UIDS_NOMBRE = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.UICD_DET = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.UICD_TIPO = New DevExpress.XtraEditors.LookUpEdit()
        Me.ClasegenericaparesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UIFLG_IMPO_SAE = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.UITABCONTROL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UITABCONTROL.SuspendLayout()
        CType(Me.UIGRIDCONTROL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIPANELDATOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIPANELDATOS.SuspendLayout()
        CType(Me.UIPANELSTATUS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIPANELSTATUS.SuspendLayout()
        CType(Me.UIBARRAPROGRESO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UITABPAG_GEN.SuspendLayout()
        Me.UITABPAG_DET.SuspendLayout()
        CType(Me.UIGRIDVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGROUP_MAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIGROUP_MAIN.SuspendLayout()
        CType(Me.IVATIPODOCUMENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UISIS_SUFIJO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UISIS_EXCLU_SUFIJO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UINM_CHARS_SERIE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGRP_IMPOR_PARAM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIGRP_IMPOR_PARAM.SuspendLayout()
        CType(Me.UISIS_EXCLU_SUFIJO_2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UINM_CHARS_SUFIJO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIFLG_COMPRA_GRAVADA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIDS_NOMBRE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UICD_DET.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UICD_TIPO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClasegenericaparesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIFLG_IMPO_SAE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UIGRIDCONTROL.DataSource = Me.IVATIPODOCUMENTOBindingSource
        '
        'UIPANELDATOS
        '
        Me.UIPANELDATOS.Controls.Add(Me.UIFLG_IMPO_SAE)
        Me.UIPANELDATOS.Controls.Add(Me.UICD_TIPO)
        Me.UIPANELDATOS.Controls.Add(Me.UINM_CHARS_SERIE)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl7)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl4)
        Me.UIPANELDATOS.Controls.Add(Me.UICD_DET)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl6)
        Me.UIPANELDATOS.Controls.Add(Me.UIDS_NOMBRE)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl5)
        Me.UIPANELDATOS.Controls.Add(Me.UIGRP_IMPOR_PARAM)
        Me.UIPANELDATOS.Controls.Add(Me.UIID)
        Me.UIPANELDATOS.Controls.Add(Me.LABEL1)
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
        Me.UIGRIDVIEW.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colDS_NOMBRE, Me.colSIS_SUFIJO, Me.colSIS_EXCLU_SUFIJO, Me.colNM_CHARS_SUFIJO_SERIE, Me.colCD_DET, Me.colCD_TIPO, Me.colFLG_COMPRA, Me.colFLG_VENTA, Me.colFLG_IMPO_SAE})
        Me.UIGRIDVIEW.OptionsBehavior.Editable = False
        Me.UIGRIDVIEW.OptionsMenu.EnableFooterMenu = False
        Me.UIGRIDVIEW.OptionsMenu.EnableGroupPanelMenu = False
        Me.UIGRIDVIEW.OptionsView.ColumnAutoWidth = False
        Me.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = True
        Me.UIGRIDVIEW.OptionsView.ShowDetailButtons = False
        '
        'UIGROUP_MAIN
        '
        Me.UIGROUP_MAIN.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UIGROUP_MAIN.AppearanceCaption.ForeColor = System.Drawing.Color.White
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseFont = True
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseForeColor = True
        '
        'IVATIPODOCUMENTOBindingSource
        '
        Me.IVATIPODOCUMENTOBindingSource.DataSource = GetType(IVA.IVA_TIPO_DOCUMENTO)
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        Me.colID.Width = 48
        '
        'colDS_NOMBRE
        '
        Me.colDS_NOMBRE.Caption = "Tipo documento"
        Me.colDS_NOMBRE.FieldName = "DS_NOMBRE"
        Me.colDS_NOMBRE.Name = "colDS_NOMBRE"
        Me.colDS_NOMBRE.Visible = True
        Me.colDS_NOMBRE.VisibleIndex = 1
        Me.colDS_NOMBRE.Width = 221
        '
        'colSIS_SUFIJO
        '
        Me.colSIS_SUFIJO.Caption = "Sufijo"
        Me.colSIS_SUFIJO.FieldName = "SIS_SUFIJO"
        Me.colSIS_SUFIJO.Name = "colSIS_SUFIJO"
        '
        'colSIS_EXCLU_SUFIJO
        '
        Me.colSIS_EXCLU_SUFIJO.Caption = "Excluir"
        Me.colSIS_EXCLU_SUFIJO.FieldName = "SIS_EXCLU_SUFIJO"
        Me.colSIS_EXCLU_SUFIJO.Name = "colSIS_EXCLU_SUFIJO"
        '
        'colNM_CHARS_SUFIJO_SERIE
        '
        Me.colNM_CHARS_SUFIJO_SERIE.Caption = "Sufijo"
        Me.colNM_CHARS_SUFIJO_SERIE.FieldName = "NM_CHARS_SUFIJO_SERIE"
        Me.colNM_CHARS_SUFIJO_SERIE.Name = "colNM_CHARS_SUFIJO_SERIE"
        '
        'colCD_DET
        '
        Me.colCD_DET.Caption = "DET"
        Me.colCD_DET.FieldName = "CD_DET"
        Me.colCD_DET.Name = "colCD_DET"
        '
        'colCD_TIPO
        '
        Me.colCD_TIPO.FieldName = "CD_TIPO"
        Me.colCD_TIPO.Name = "colCD_TIPO"
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
        'colFLG_IMPO_SAE
        '
        Me.colFLG_IMPO_SAE.Caption = "Importar desde sae"
        Me.colFLG_IMPO_SAE.FieldName = "FLG_IMPO_SAE"
        Me.colFLG_IMPO_SAE.Name = "colFLG_IMPO_SAE"
        Me.colFLG_IMPO_SAE.Width = 124
        '
        'LABEL1
        '
        Me.LABEL1.Location = New System.Drawing.Point(106, 36)
        Me.LABEL1.Name = "LABEL1"
        Me.LABEL1.Size = New System.Drawing.Size(11, 13)
        Me.LABEL1.TabIndex = 0
        Me.LABEL1.Text = "ID"
        '
        'UIID
        '
        Me.UIID.Location = New System.Drawing.Point(126, 36)
        Me.UIID.Name = "UIID"
        Me.UIID.Properties.ReadOnly = True
        Me.UIID.Size = New System.Drawing.Size(54, 20)
        Me.UIID.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(80, 44)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Sufijo"
        '
        'UISIS_SUFIJO
        '
        Me.UISIS_SUFIJO.Location = New System.Drawing.Point(113, 41)
        Me.UISIS_SUFIJO.Name = "UISIS_SUFIJO"
        Me.UISIS_SUFIJO.Size = New System.Drawing.Size(100, 20)
        Me.UISIS_SUFIJO.TabIndex = 3
        '
        'UISIS_EXCLU_SUFIJO
        '
        Me.UISIS_EXCLU_SUFIJO.Location = New System.Drawing.Point(113, 102)
        Me.UISIS_EXCLU_SUFIJO.Name = "UISIS_EXCLU_SUFIJO"
        Me.UISIS_EXCLU_SUFIJO.Size = New System.Drawing.Size(100, 20)
        Me.UISIS_EXCLU_SUFIJO.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(63, 105)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "S. Excluir"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(27, 205)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "# Caracteres serie"
        '
        'UINM_CHARS_SERIE
        '
        Me.UINM_CHARS_SERIE.Location = New System.Drawing.Point(126, 202)
        Me.UINM_CHARS_SERIE.Name = "UINM_CHARS_SERIE"
        Me.UINM_CHARS_SERIE.Properties.Mask.EditMask = "d"
        Me.UINM_CHARS_SERIE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.UINM_CHARS_SERIE.Size = New System.Drawing.Size(100, 20)
        Me.UINM_CHARS_SERIE.TabIndex = 7
        '
        'UIGRP_IMPOR_PARAM
        '
        Me.UIGRP_IMPOR_PARAM.Controls.Add(Me.UISIS_EXCLU_SUFIJO_2)
        Me.UIGRP_IMPOR_PARAM.Controls.Add(Me.LabelControl8)
        Me.UIGRP_IMPOR_PARAM.Controls.Add(Me.UINM_CHARS_SUFIJO)
        Me.UIGRP_IMPOR_PARAM.Controls.Add(Me.LabelControl1)
        Me.UIGRP_IMPOR_PARAM.Controls.Add(Me.UIFLG_COMPRA_GRAVADA)
        Me.UIGRP_IMPOR_PARAM.Controls.Add(Me.UISIS_SUFIJO)
        Me.UIGRP_IMPOR_PARAM.Controls.Add(Me.LabelControl2)
        Me.UIGRP_IMPOR_PARAM.Controls.Add(Me.UISIS_EXCLU_SUFIJO)
        Me.UIGRP_IMPOR_PARAM.Controls.Add(Me.LabelControl3)
        Me.UIGRP_IMPOR_PARAM.Location = New System.Drawing.Point(457, 18)
        Me.UIGRP_IMPOR_PARAM.Name = "UIGRP_IMPOR_PARAM"
        Me.UIGRP_IMPOR_PARAM.Size = New System.Drawing.Size(257, 217)
        Me.UIGRP_IMPOR_PARAM.TabIndex = 8
        Me.UIGRP_IMPOR_PARAM.Text = "Parametros importacion"
        '
        'UISIS_EXCLU_SUFIJO_2
        '
        Me.UISIS_EXCLU_SUFIJO_2.Location = New System.Drawing.Point(113, 135)
        Me.UISIS_EXCLU_SUFIJO_2.Name = "UISIS_EXCLU_SUFIJO_2"
        Me.UISIS_EXCLU_SUFIJO_2.Size = New System.Drawing.Size(100, 20)
        Me.UISIS_EXCLU_SUFIJO_2.TabIndex = 18
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(63, 138)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl8.TabIndex = 19
        Me.LabelControl8.Text = "S. Excluir"
        '
        'UINM_CHARS_SUFIJO
        '
        Me.UINM_CHARS_SUFIJO.Location = New System.Drawing.Point(113, 70)
        Me.UINM_CHARS_SUFIJO.Name = "UINM_CHARS_SUFIJO"
        Me.UINM_CHARS_SUFIJO.Properties.Mask.EditMask = "d"
        Me.UINM_CHARS_SUFIJO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.UINM_CHARS_SUFIJO.Size = New System.Drawing.Size(100, 20)
        Me.UINM_CHARS_SUFIJO.TabIndex = 17
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 73)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl1.TabIndex = 16
        Me.LabelControl1.Text = "# Caracteres sufijo"
        '
        'UIFLG_COMPRA_GRAVADA
        '
        Me.UIFLG_COMPRA_GRAVADA.EditValue = Global.Microsoft.VisualBasic.ChrW(78)
        Me.UIFLG_COMPRA_GRAVADA.Location = New System.Drawing.Point(111, 166)
        Me.UIFLG_COMPRA_GRAVADA.Name = "UIFLG_COMPRA_GRAVADA"
        Me.UIFLG_COMPRA_GRAVADA.Properties.Caption = "Compra gravada"
        Me.UIFLG_COMPRA_GRAVADA.Properties.ValueChecked = Global.Microsoft.VisualBasic.ChrW(83)
        Me.UIFLG_COMPRA_GRAVADA.Properties.ValueUnchecked = Global.Microsoft.VisualBasic.ChrW(78)
        Me.UIFLG_COMPRA_GRAVADA.Size = New System.Drawing.Size(119, 19)
        Me.UIFLG_COMPRA_GRAVADA.TabIndex = 8
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(63, 62)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "Documento"
        '
        'UIDS_NOMBRE
        '
        Me.UIDS_NOMBRE.Location = New System.Drawing.Point(126, 62)
        Me.UIDS_NOMBRE.Name = "UIDS_NOMBRE"
        Me.UIDS_NOMBRE.Size = New System.Drawing.Size(212, 20)
        Me.UIDS_NOMBRE.TabIndex = 10
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(98, 95)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl6.TabIndex = 11
        Me.LabelControl6.Text = "DET"
        '
        'UICD_DET
        '
        Me.UICD_DET.Location = New System.Drawing.Point(126, 93)
        Me.UICD_DET.Name = "UICD_DET"
        Me.UICD_DET.Properties.Mask.EditMask = "d"
        Me.UICD_DET.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.UICD_DET.Size = New System.Drawing.Size(54, 20)
        Me.UICD_DET.TabIndex = 12
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(97, 127)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl7.TabIndex = 13
        Me.LabelControl7.Text = "Tipo"
        '
        'UICD_TIPO
        '
        Me.UICD_TIPO.Location = New System.Drawing.Point(126, 127)
        Me.UICD_TIPO.Name = "UICD_TIPO"
        Me.UICD_TIPO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UICD_TIPO.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 56, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Tipo", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.UICD_TIPO.Properties.DataSource = Me.ClasegenericaparesBindingSource
        Me.UICD_TIPO.Properties.DisplayMember = "Descripcion"
        Me.UICD_TIPO.Properties.ValueMember = "Codigo"
        Me.UICD_TIPO.Size = New System.Drawing.Size(212, 20)
        Me.UICD_TIPO.TabIndex = 14
        '
        'ClasegenericaparesBindingSource
        '
        Me.ClasegenericaparesBindingSource.DataSource = GetType(Utilidades.clasegenericapares)
        '
        'UIFLG_IMPO_SAE
        '
        Me.UIFLG_IMPO_SAE.EditValue = Global.Microsoft.VisualBasic.ChrW(78)
        Me.UIFLG_IMPO_SAE.Location = New System.Drawing.Point(124, 166)
        Me.UIFLG_IMPO_SAE.Name = "UIFLG_IMPO_SAE"
        Me.UIFLG_IMPO_SAE.Properties.Caption = "Importa desde SAE"
        Me.UIFLG_IMPO_SAE.Properties.ValueChecked = Global.Microsoft.VisualBasic.ChrW(83)
        Me.UIFLG_IMPO_SAE.Properties.ValueUnchecked = Global.Microsoft.VisualBasic.ChrW(78)
        Me.UIFLG_IMPO_SAE.Size = New System.Drawing.Size(121, 19)
        Me.UIFLG_IMPO_SAE.TabIndex = 15
        '
        'FORM_IVA_TIPO_DOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(965, 560)
        Me.Name = "FORM_IVA_TIPO_DOC"
        CType(Me.UITABCONTROL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UITABCONTROL.ResumeLayout(False)
        CType(Me.UIGRIDCONTROL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIPANELDATOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIPANELDATOS.ResumeLayout(False)
        Me.UIPANELDATOS.PerformLayout()
        CType(Me.UIPANELSTATUS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIPANELSTATUS.ResumeLayout(False)
        CType(Me.UIBARRAPROGRESO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UITABPAG_GEN.ResumeLayout(False)
        Me.UITABPAG_DET.ResumeLayout(False)
        CType(Me.UIGRIDVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGROUP_MAIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIGROUP_MAIN.ResumeLayout(False)
        CType(Me.IVATIPODOCUMENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UISIS_SUFIJO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UISIS_EXCLU_SUFIJO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UINM_CHARS_SERIE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGRP_IMPOR_PARAM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIGRP_IMPOR_PARAM.ResumeLayout(False)
        Me.UIGRP_IMPOR_PARAM.PerformLayout()
        CType(Me.UISIS_EXCLU_SUFIJO_2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UINM_CHARS_SUFIJO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIFLG_COMPRA_GRAVADA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIDS_NOMBRE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UICD_DET.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UICD_TIPO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClasegenericaparesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIFLG_IMPO_SAE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IVATIPODOCUMENTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSIS_SUFIJO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSIS_EXCLU_SUFIJO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNM_CHARS_SUFIJO_SERIE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCD_DET As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCD_TIPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFLG_COMPRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFLG_VENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFLG_IMPO_SAE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UISIS_EXCLU_SUFIJO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UISIS_SUFIJO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UIID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LABEL1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UIFLG_IMPO_SAE As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents UICD_TIPO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UICD_DET As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UIDS_NOMBRE As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UIGRP_IMPOR_PARAM As DevExpress.XtraEditors.GroupControl
    Friend WithEvents UIFLG_COMPRA_GRAVADA As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents UINM_CHARS_SERIE As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ClasegenericaparesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UINM_CHARS_SUFIJO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UISIS_EXCLU_SUFIJO_2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl

End Class
