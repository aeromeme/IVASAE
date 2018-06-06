<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_FORM
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
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOD_FORM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_NOMBRE_FORM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_NOMBRE_CORTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.UIID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.UICOD_FORM = New DevExpress.XtraEditors.TextEdit()
        Me.UIDS_NOMBRE_FORM = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.UIDS_NOMBRE_CORTO = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.UIID_MODULO = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.VGENFORMULARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GENFORMULARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colID_MODULO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_NOMBRE_MODULO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GENOPCIONMENUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GENMODULOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colDS_NOMBRE_MODULO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        CType(Me.UIID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UICOD_FORM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIDS_NOMBRE_FORM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIDS_NOMBRE_CORTO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIID_MODULO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VGENFORMULARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GENFORMULARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GENOPCIONMENUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GENMODULOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UIGRIDCONTROL.DataSource = Me.VGENFORMULARIOBindingSource
        '
        'UIPANELDATOS
        '
        Me.UIPANELDATOS.Controls.Add(Me.UIID_MODULO)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl5)
        Me.UIPANELDATOS.Controls.Add(Me.UIDS_NOMBRE_CORTO)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl4)
        Me.UIPANELDATOS.Controls.Add(Me.UIDS_NOMBRE_FORM)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl3)
        Me.UIPANELDATOS.Controls.Add(Me.UICOD_FORM)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl1)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl2)
        Me.UIPANELDATOS.Controls.Add(Me.UIID)
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
        Me.UIGRIDVIEW.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCOD_FORM, Me.colDS_NOMBRE_FORM, Me.colDS_NOMBRE_CORTO, Me.colID_MODULO, Me.colDS_NOMBRE_MODULO})
        Me.UIGRIDVIEW.OptionsBehavior.Editable = False
        Me.UIGRIDVIEW.OptionsMenu.EnableColumnMenu = False
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
        'colID
        '
        Me.colID.Caption = "id"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colCOD_FORM
        '
        Me.colCOD_FORM.Caption = "Formulario"
        Me.colCOD_FORM.FieldName = "COD_FORM"
        Me.colCOD_FORM.Name = "colCOD_FORM"
        Me.colCOD_FORM.Visible = True
        Me.colCOD_FORM.VisibleIndex = 1
        Me.colCOD_FORM.Width = 137
        '
        'colDS_NOMBRE_FORM
        '
        Me.colDS_NOMBRE_FORM.Caption = "Nombre"
        Me.colDS_NOMBRE_FORM.FieldName = "DS_NOMBRE_FORM"
        Me.colDS_NOMBRE_FORM.Name = "colDS_NOMBRE_FORM"
        Me.colDS_NOMBRE_FORM.Visible = True
        Me.colDS_NOMBRE_FORM.VisibleIndex = 2
        Me.colDS_NOMBRE_FORM.Width = 191
        '
        'colDS_NOMBRE_CORTO
        '
        Me.colDS_NOMBRE_CORTO.Caption = "Nombre corto"
        Me.colDS_NOMBRE_CORTO.FieldName = "DS_NOMBRE_CORTO"
        Me.colDS_NOMBRE_CORTO.Name = "colDS_NOMBRE_CORTO"
        Me.colDS_NOMBRE_CORTO.Visible = True
        Me.colDS_NOMBRE_CORTO.VisibleIndex = 3
        Me.colDS_NOMBRE_CORTO.Width = 131
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(90, 36)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "ID"
        '
        'UIID
        '
        Me.UIID.Location = New System.Drawing.Point(110, 33)
        Me.UIID.Name = "UIID"
        Me.UIID.Properties.ReadOnly = True
        Me.UIID.Size = New System.Drawing.Size(100, 20)
        Me.UIID.TabIndex = 4
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(51, 69)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Formulario"
        '
        'UICOD_FORM
        '
        Me.UICOD_FORM.Location = New System.Drawing.Point(110, 66)
        Me.UICOD_FORM.Name = "UICOD_FORM"
        Me.UICOD_FORM.Properties.MaxLength = 50
        Me.UICOD_FORM.Size = New System.Drawing.Size(190, 20)
        Me.UICOD_FORM.TabIndex = 7
        '
        'UIDS_NOMBRE_FORM
        '
        Me.UIDS_NOMBRE_FORM.Location = New System.Drawing.Point(110, 98)
        Me.UIDS_NOMBRE_FORM.Name = "UIDS_NOMBRE_FORM"
        Me.UIDS_NOMBRE_FORM.Properties.MaxLength = 50
        Me.UIDS_NOMBRE_FORM.Size = New System.Drawing.Size(190, 20)
        Me.UIDS_NOMBRE_FORM.TabIndex = 9
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(64, 101)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Nombre"
        '
        'UIDS_NOMBRE_CORTO
        '
        Me.UIDS_NOMBRE_CORTO.Location = New System.Drawing.Point(110, 133)
        Me.UIDS_NOMBRE_CORTO.Name = "UIDS_NOMBRE_CORTO"
        Me.UIDS_NOMBRE_CORTO.Properties.MaxLength = 25
        Me.UIDS_NOMBRE_CORTO.Size = New System.Drawing.Size(190, 20)
        Me.UIDS_NOMBRE_CORTO.TabIndex = 11
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(36, 136)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl4.TabIndex = 10
        Me.LabelControl4.Text = "Nombre corto"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(67, 171)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl5.TabIndex = 12
        Me.LabelControl5.Text = "Modulo"
        '
        'UIID_MODULO
        '
        Me.UIID_MODULO.EditValue = "Seleccione"
        Me.UIID_MODULO.Location = New System.Drawing.Point(110, 168)
        Me.UIID_MODULO.Name = "UIID_MODULO"
        Me.UIID_MODULO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UIID_MODULO.Properties.DataSource = Me.GENMODULOBindingSource
        Me.UIID_MODULO.Properties.DisplayMember = "DS_NOMBRE_MODULO"
        Me.UIID_MODULO.Properties.NullText = "Seleccione"
        Me.UIID_MODULO.Properties.ValueMember = "ID"
        Me.UIID_MODULO.Properties.View = Me.GridLookUpEdit1View
        Me.UIID_MODULO.Size = New System.Drawing.Size(190, 20)
        Me.UIID_MODULO.TabIndex = 7
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDS_NOMBRE_MODULO1, Me.colID1})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'VGENFORMULARIOBindingSource
        '
        Me.VGENFORMULARIOBindingSource.DataSource = GetType(IVASAE.V_GEN_FORMULARIO)
        '
        'GENFORMULARIOBindingSource
        '
        Me.GENFORMULARIOBindingSource.DataSource = GetType(IVASAE.GEN_FORMULARIO)
        '
        'colID_MODULO
        '
        Me.colID_MODULO.FieldName = "ID_MODULO"
        Me.colID_MODULO.Name = "colID_MODULO"
        '
        'colDS_NOMBRE_MODULO
        '
        Me.colDS_NOMBRE_MODULO.Caption = "Modulo"
        Me.colDS_NOMBRE_MODULO.FieldName = "DS_NOMBRE_MODULO"
        Me.colDS_NOMBRE_MODULO.Name = "colDS_NOMBRE_MODULO"
        Me.colDS_NOMBRE_MODULO.Visible = True
        Me.colDS_NOMBRE_MODULO.VisibleIndex = 4
        '
        'GENOPCIONMENUBindingSource
        '
        Me.GENOPCIONMENUBindingSource.DataMember = "GEN_OPCION_MENU"
        Me.GENOPCIONMENUBindingSource.DataSource = Me.GENFORMULARIOBindingSource
        '
        'GENMODULOBindingSource
        '
        Me.GENMODULOBindingSource.DataSource = GetType(IVASAE.GEN_MODULO)
        '
        'colDS_NOMBRE_MODULO1
        '
        Me.colDS_NOMBRE_MODULO1.Caption = "Modulo"
        Me.colDS_NOMBRE_MODULO1.FieldName = "DS_NOMBRE_MODULO"
        Me.colDS_NOMBRE_MODULO1.Name = "colDS_NOMBRE_MODULO1"
        Me.colDS_NOMBRE_MODULO1.Visible = True
        Me.colDS_NOMBRE_MODULO1.VisibleIndex = 0
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.Name = "colID1"
        '
        'FORM_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(965, 560)
        Me.Name = "FORM_FORM"
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
        CType(Me.UIID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UICOD_FORM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIDS_NOMBRE_FORM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIDS_NOMBRE_CORTO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIID_MODULO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VGENFORMULARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GENFORMULARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GENOPCIONMENUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GENMODULOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOD_FORM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NOMBRE_FORM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NOMBRE_CORTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UIDS_NOMBRE_CORTO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UIDS_NOMBRE_FORM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UICOD_FORM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UIID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UIID_MODULO As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents VGENFORMULARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GENFORMULARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colID_MODULO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NOMBRE_MODULO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GENMODULOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colDS_NOMBRE_MODULO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GENOPCIONMENUBindingSource As System.Windows.Forms.BindingSource

End Class
