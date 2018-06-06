<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_MODULO
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
        Me.GENMODULOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDS_NOMBRE_MODULO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.UIID = New DevExpress.XtraEditors.TextEdit()
        Me.UIDS_NOMBRE_MODULO = New DevExpress.XtraEditors.TextEdit()
        Me.CImagenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.uicd_imagen = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colimagen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
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
        CType(Me.GENMODULOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIDS_NOMBRE_MODULO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CImagenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uicd_imagen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UITABCONTROL
        '
        Me.UITABCONTROL.AppearancePage.Header.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.UITABCONTROL.AppearancePage.Header.Options.UseFont = True
        '
        'UIGRIDCONTROL
        '
        Me.UIGRIDCONTROL.DataSource = Me.GENMODULOBindingSource
        '
        'UIPANELDATOS
        '
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl3)
        Me.UIPANELDATOS.Controls.Add(Me.uicd_imagen)
        Me.UIPANELDATOS.Controls.Add(Me.UIDS_NOMBRE_MODULO)
        Me.UIPANELDATOS.Controls.Add(Me.UIID)
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
        Me.UIGRIDVIEW.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colDS_NOMBRE_MODULO})
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
        'GENMODULOBindingSource
        '
        Me.GENMODULOBindingSource.DataSource = GetType(IVASAE.GEN_MODULO)
        '
        'colID
        '
        Me.colID.Caption = "id"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        '
        'colDS_NOMBRE_MODULO
        '
        Me.colDS_NOMBRE_MODULO.Caption = "Modulo"
        Me.colDS_NOMBRE_MODULO.FieldName = "DS_NOMBRE_MODULO"
        Me.colDS_NOMBRE_MODULO.Name = "colDS_NOMBRE_MODULO"
        Me.colDS_NOMBRE_MODULO.Visible = True
        Me.colDS_NOMBRE_MODULO.VisibleIndex = 1
        Me.colDS_NOMBRE_MODULO.Width = 192
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(88, 37)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ID"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(25, 65)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Nombre Modulo"
        '
        'UIID
        '
        Me.UIID.Location = New System.Drawing.Point(111, 34)
        Me.UIID.Name = "UIID"
        Me.UIID.Properties.ReadOnly = True
        Me.UIID.Size = New System.Drawing.Size(100, 20)
        Me.UIID.TabIndex = 4
        '
        'UIDS_NOMBRE_MODULO
        '
        Me.UIDS_NOMBRE_MODULO.Location = New System.Drawing.Point(111, 62)
        Me.UIDS_NOMBRE_MODULO.Name = "UIDS_NOMBRE_MODULO"
        Me.UIDS_NOMBRE_MODULO.Size = New System.Drawing.Size(201, 20)
        Me.UIDS_NOMBRE_MODULO.TabIndex = 3
        '
        'CImagenBindingSource
        '
        Me.CImagenBindingSource.DataSource = GetType(IVASAE.cImagen)
        '
        'uicd_imagen
        '
        Me.uicd_imagen.Location = New System.Drawing.Point(111, 88)
        Me.uicd_imagen.Name = "uicd_imagen"
        Me.uicd_imagen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.uicd_imagen.Properties.DataSource = Me.CImagenBindingSource
        Me.uicd_imagen.Properties.DisplayMember = "nombre"
        Me.uicd_imagen.Properties.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1})
        Me.uicd_imagen.Properties.ValueMember = "id"
        Me.uicd_imagen.Properties.View = Me.GridLookUpEdit1View
        Me.uicd_imagen.Size = New System.Drawing.Size(201, 20)
        Me.uicd_imagen.TabIndex = 5
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colimagen})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colimagen
        '
        Me.colimagen.ColumnEdit = Me.RepositoryItemPictureEdit1
        Me.colimagen.FieldName = "imagen"
        Me.colimagen.Name = "colimagen"
        Me.colimagen.Visible = True
        Me.colimagen.VisibleIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(63, 91)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Imagen"
        '
        'FORM_MODULO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(965, 560)
        Me.Name = "FORM_MODULO"
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
        CType(Me.GENMODULOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIDS_NOMBRE_MODULO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CImagenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uicd_imagen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GENMODULOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDS_NOMBRE_MODULO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UIDS_NOMBRE_MODULO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UIID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CImagenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents uicd_imagen As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colimagen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl

End Class
