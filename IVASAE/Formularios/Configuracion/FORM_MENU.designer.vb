<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_MENU
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
        Me.GENMENUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOD_MENU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UIID = New DevExpress.XtraEditors.TextEdit()
        Me.UICOD_MENU = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
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
        CType(Me.GENMENUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UICOD_MENU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UITABCONTROL
        '
        Me.UITABCONTROL.AppearancePage.Header.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.UITABCONTROL.AppearancePage.Header.Options.UseFont = True
        '
        'UIGRIDCONTROL
        '
        Me.UIGRIDCONTROL.DataSource = Me.GENMENUBindingSource
        '
        'UIPANELDATOS
        '
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl2)
        Me.UIPANELDATOS.Controls.Add(Me.UIID)
        Me.UIPANELDATOS.Controls.Add(Me.UICOD_MENU)
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
        Me.UIGRIDVIEW.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCOD_MENU})
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
        'GENMENUBindingSource
        '
        Me.GENMENUBindingSource.DataSource = GetType(IVASAE.GEN_MENU)
        '
        'colID
        '
        Me.colID.Caption = "id"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colCOD_MENU
        '
        Me.colCOD_MENU.Caption = "menu"
        Me.colCOD_MENU.FieldName = "COD_MENU"
        Me.colCOD_MENU.Name = "colCOD_MENU"
        Me.colCOD_MENU.Visible = True
        Me.colCOD_MENU.VisibleIndex = 1
        Me.colCOD_MENU.Width = 187
        '
        'UIID
        '
        Me.UIID.Location = New System.Drawing.Point(83, 43)
        Me.UIID.Name = "UIID"
        Me.UIID.Properties.ReadOnly = True
        Me.UIID.Size = New System.Drawing.Size(100, 20)
        Me.UIID.TabIndex = 0
        '
        'UICOD_MENU
        '
        Me.UICOD_MENU.Location = New System.Drawing.Point(83, 84)
        Me.UICOD_MENU.Name = "UICOD_MENU"
        Me.UICOD_MENU.Properties.MaxLength = 50
        Me.UICOD_MENU.Size = New System.Drawing.Size(352, 20)
        Me.UICOD_MENU.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(49, 87)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Menu"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(64, 46)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "ID"
        '
        'FORM_MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(965, 560)
        Me.Name = "FORM_MENU"
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
        CType(Me.GENMENUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UICOD_MENU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GENMENUBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UICOD_MENU As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UIID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOD_MENU As DevExpress.XtraGrid.Columns.GridColumn

End Class
