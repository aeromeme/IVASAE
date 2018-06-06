<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_OPCI
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
        Me.VGENOPCIONMENUBindingSource = New System.Windows.Forms.BindingSource()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colORDEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOD_MENU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOD_FORM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_NOMBRE_FORM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_NOMBRE_CORTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_MENU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_FORM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.UIID = New DevExpress.XtraEditors.TextEdit()
        Me.UIID_MENU = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GENMENUBindingSource = New System.Windows.Forms.BindingSource()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCOD_MENU1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UIID_FORM = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GENFORMULARIOBindingSource = New System.Windows.Forms.BindingSource()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCOD_FORM2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_NOMBRE_FORM2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_NOMBRE_CORTO2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOD_FORM1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_NOMBRE_CORTO1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_NOMBRE_FORM1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VGENFORMULARIOBindingSource = New System.Windows.Forms.BindingSource()
        Me.colDS_NOMBRE_MODULO = New DevExpress.XtraGrid.Columns.GridColumn()
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
        CType(Me.VGENOPCIONMENUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIID_MENU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GENMENUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIID_FORM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GENFORMULARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VGENFORMULARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UITABCONTROL
        '
        Me.UITABCONTROL.AppearancePage.Header.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.UITABCONTROL.AppearancePage.Header.Options.UseFont = True
        '
        'UIGRIDCONTROL
        '
        Me.UIGRIDCONTROL.DataSource = Me.VGENOPCIONMENUBindingSource
        '
        'UIPANELDATOS
        '
        Me.UIPANELDATOS.Controls.Add(Me.UIID_FORM)
        Me.UIPANELDATOS.Controls.Add(Me.UIID_MENU)
        Me.UIPANELDATOS.Controls.Add(Me.UIID)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl3)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl2)
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
        Me.UIGRIDVIEW.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colORDEN, Me.colCOD_MENU, Me.colCOD_FORM, Me.colDS_NOMBRE_FORM, Me.colDS_NOMBRE_CORTO, Me.colID_MENU, Me.colID_FORM})
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
        'VGENOPCIONMENUBindingSource
        '
        Me.VGENOPCIONMENUBindingSource.DataSource = GetType(IVASAE.V_GEN_OPCION_MENU)
        '
        'colID
        '
        Me.colID.Caption = "id"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colORDEN
        '
        Me.colORDEN.FieldName = "ORDEN"
        Me.colORDEN.Name = "colORDEN"
        '
        'colCOD_MENU
        '
        Me.colCOD_MENU.Caption = "Menu"
        Me.colCOD_MENU.FieldName = "COD_MENU"
        Me.colCOD_MENU.Name = "colCOD_MENU"
        Me.colCOD_MENU.Visible = True
        Me.colCOD_MENU.VisibleIndex = 1
        Me.colCOD_MENU.Width = 173
        '
        'colCOD_FORM
        '
        Me.colCOD_FORM.Caption = "Formulario"
        Me.colCOD_FORM.FieldName = "COD_FORM"
        Me.colCOD_FORM.Name = "colCOD_FORM"
        Me.colCOD_FORM.Visible = True
        Me.colCOD_FORM.VisibleIndex = 2
        Me.colCOD_FORM.Width = 148
        '
        'colDS_NOMBRE_FORM
        '
        Me.colDS_NOMBRE_FORM.Caption = "Nombre formulario"
        Me.colDS_NOMBRE_FORM.FieldName = "DS_NOMBRE_FORM"
        Me.colDS_NOMBRE_FORM.Name = "colDS_NOMBRE_FORM"
        Me.colDS_NOMBRE_FORM.Visible = True
        Me.colDS_NOMBRE_FORM.VisibleIndex = 3
        Me.colDS_NOMBRE_FORM.Width = 140
        '
        'colDS_NOMBRE_CORTO
        '
        Me.colDS_NOMBRE_CORTO.FieldName = "DS_NOMBRE_CORTO"
        Me.colDS_NOMBRE_CORTO.Name = "colDS_NOMBRE_CORTO"
        '
        'colID_MENU
        '
        Me.colID_MENU.FieldName = "ID_MENU"
        Me.colID_MENU.Name = "colID_MENU"
        '
        'colID_FORM
        '
        Me.colID_FORM.FieldName = "ID_FORM"
        Me.colID_FORM.Name = "colID_FORM"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(77, 34)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(8, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "id"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(59, 70)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Menu"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(35, 108)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Formulario"
        '
        'UIID
        '
        Me.UIID.Location = New System.Drawing.Point(91, 31)
        Me.UIID.Name = "UIID"
        Me.UIID.Properties.ReadOnly = True
        Me.UIID.Size = New System.Drawing.Size(130, 20)
        Me.UIID.TabIndex = 3
        '
        'UIID_MENU
        '
        Me.UIID_MENU.Location = New System.Drawing.Point(91, 70)
        Me.UIID_MENU.Name = "UIID_MENU"
        Me.UIID_MENU.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UIID_MENU.Properties.DataSource = Me.GENMENUBindingSource
        Me.UIID_MENU.Properties.DisplayMember = "COD_MENU"
        Me.UIID_MENU.Properties.NullText = "Seleccione"
        Me.UIID_MENU.Properties.ValueMember = "ID"
        Me.UIID_MENU.Properties.View = Me.GridLookUpEdit1View
        Me.UIID_MENU.Size = New System.Drawing.Size(185, 20)
        Me.UIID_MENU.TabIndex = 4
        '
        'GENMENUBindingSource
        '
        Me.GENMENUBindingSource.DataSource = GetType(IVASAE.GEN_MENU)
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCOD_MENU1, Me.colID1})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colCOD_MENU1
        '
        Me.colCOD_MENU1.Caption = "Menu"
        Me.colCOD_MENU1.FieldName = "COD_MENU"
        Me.colCOD_MENU1.Name = "colCOD_MENU1"
        Me.colCOD_MENU1.Visible = True
        Me.colCOD_MENU1.VisibleIndex = 0
        '
        'colID1
        '
        Me.colID1.FieldName = "ID"
        Me.colID1.Name = "colID1"
        '
        'UIID_FORM
        '
        Me.UIID_FORM.Location = New System.Drawing.Point(91, 105)
        Me.UIID_FORM.Name = "UIID_FORM"
        Me.UIID_FORM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UIID_FORM.Properties.DataSource = Me.VGENFORMULARIOBindingSource
        Me.UIID_FORM.Properties.DisplayMember = "DS_NOMBRE_CORTO"
        Me.UIID_FORM.Properties.NullText = "Seleccione"
        Me.UIID_FORM.Properties.ValueMember = "ID"
        Me.UIID_FORM.Properties.View = Me.GridView1
        Me.UIID_FORM.Size = New System.Drawing.Size(185, 20)
        Me.UIID_FORM.TabIndex = 5
        '
        'GENFORMULARIOBindingSource
        '
        Me.GENFORMULARIOBindingSource.DataSource = GetType(IVASAE.GEN_FORMULARIO)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCOD_FORM2, Me.colDS_NOMBRE_FORM2, Me.colDS_NOMBRE_CORTO2, Me.colID3, Me.colDS_NOMBRE_MODULO})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCOD_FORM2
        '
        Me.colCOD_FORM2.Caption = "Formulario"
        Me.colCOD_FORM2.FieldName = "COD_FORM"
        Me.colCOD_FORM2.Name = "colCOD_FORM2"
        Me.colCOD_FORM2.Visible = True
        Me.colCOD_FORM2.VisibleIndex = 1
        '
        'colDS_NOMBRE_FORM2
        '
        Me.colDS_NOMBRE_FORM2.Caption = "Nombre"
        Me.colDS_NOMBRE_FORM2.FieldName = "DS_NOMBRE_FORM"
        Me.colDS_NOMBRE_FORM2.Name = "colDS_NOMBRE_FORM2"
        Me.colDS_NOMBRE_FORM2.Visible = True
        Me.colDS_NOMBRE_FORM2.VisibleIndex = 0
        '
        'colDS_NOMBRE_CORTO2
        '
        Me.colDS_NOMBRE_CORTO2.FieldName = "DS_NOMBRE_CORTO"
        Me.colDS_NOMBRE_CORTO2.Name = "colDS_NOMBRE_CORTO2"
        '
        'colID3
        '
        Me.colID3.FieldName = "ID"
        Me.colID3.Name = "colID3"
        '
        'colCOD_FORM1
        '
        Me.colCOD_FORM1.Caption = "Formulario"
        Me.colCOD_FORM1.FieldName = "COD_FORM"
        Me.colCOD_FORM1.Name = "colCOD_FORM1"
        Me.colCOD_FORM1.Visible = True
        Me.colCOD_FORM1.VisibleIndex = 0
        '
        'colDS_NOMBRE_CORTO1
        '
        Me.colDS_NOMBRE_CORTO1.Caption = "Nombre"
        Me.colDS_NOMBRE_CORTO1.FieldName = "DS_NOMBRE_CORTO"
        Me.colDS_NOMBRE_CORTO1.Name = "colDS_NOMBRE_CORTO1"
        Me.colDS_NOMBRE_CORTO1.Visible = True
        Me.colDS_NOMBRE_CORTO1.VisibleIndex = 1
        '
        'colDS_NOMBRE_FORM1
        '
        Me.colDS_NOMBRE_FORM1.FieldName = "DS_NOMBRE_FORM"
        Me.colDS_NOMBRE_FORM1.Name = "colDS_NOMBRE_FORM1"
        Me.colDS_NOMBRE_FORM1.Visible = True
        Me.colDS_NOMBRE_FORM1.VisibleIndex = 2
        '
        'colID2
        '
        Me.colID2.FieldName = "ID"
        Me.colID2.Name = "colID2"
        '
        'VGENFORMULARIOBindingSource
        '
        Me.VGENFORMULARIOBindingSource.DataSource = GetType(IVASAE.V_GEN_FORMULARIO)
        '
        'colDS_NOMBRE_MODULO
        '
        Me.colDS_NOMBRE_MODULO.Caption = "Modulo"
        Me.colDS_NOMBRE_MODULO.FieldName = "DS_NOMBRE_MODULO"
        Me.colDS_NOMBRE_MODULO.Name = "colDS_NOMBRE_MODULO"
        Me.colDS_NOMBRE_MODULO.Visible = True
        Me.colDS_NOMBRE_MODULO.VisibleIndex = 2
        '
        'FORM_OPCI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(965, 560)
        Me.Name = "FORM_OPCI"
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
        CType(Me.VGENOPCIONMENUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIID_MENU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GENMENUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIID_FORM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GENFORMULARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VGENFORMULARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VGENOPCIONMENUBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colORDEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOD_MENU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOD_FORM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NOMBRE_FORM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NOMBRE_CORTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_MENU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_FORM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UIID_FORM As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UIID_MENU As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GENMENUBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCOD_MENU1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UIID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GENFORMULARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colCOD_FORM1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NOMBRE_CORTO1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NOMBRE_FORM1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOD_FORM2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NOMBRE_FORM2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NOMBRE_CORTO2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VGENFORMULARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colDS_NOMBRE_MODULO As DevExpress.XtraGrid.Columns.GridColumn

End Class
