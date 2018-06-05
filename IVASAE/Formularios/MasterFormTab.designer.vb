<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterFormTab
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
        Me.UITABCONTROL = New DevExpress.XtraTab.XtraTabControl()
        Me.UITABPAG_GEN = New DevExpress.XtraTab.XtraTabPage()
        Me.UIPANELDATOS = New DevExpress.XtraEditors.PanelControl()
        Me.UITABPAG_DET = New DevExpress.XtraTab.XtraTabPage()
        Me.UIGRIDCONTROL = New DevExpress.XtraGrid.GridControl()
        Me.UIMENUGRID = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExportarAExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UIGRIDVIEW = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.UIPANELSTATUS = New DevExpress.XtraEditors.PanelControl()
        Me.UINAV = New DevExpress.XtraEditors.ControlNavigator()
        Me.UIBARRAPROGRESO = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        Me.UIDIALOGO_GUARDAREXCEL = New System.Windows.Forms.SaveFileDialog()
        CType(Me.UIGROUP_MAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIGROUP_MAIN.SuspendLayout()
        CType(Me.UITABCONTROL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UITABCONTROL.SuspendLayout()
        Me.UITABPAG_GEN.SuspendLayout()
        CType(Me.UIPANELDATOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UITABPAG_DET.SuspendLayout()
        CType(Me.UIGRIDCONTROL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIMENUGRID.SuspendLayout()
        CType(Me.UIGRIDVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIPANELSTATUS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIPANELSTATUS.SuspendLayout()
        CType(Me.UIBARRAPROGRESO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UIGROUP_MAIN
        '
        Me.UIGROUP_MAIN.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UIGROUP_MAIN.AppearanceCaption.ForeColor = System.Drawing.Color.White
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseFont = True
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseForeColor = True
        Me.UIGROUP_MAIN.Controls.Add(Me.UITABCONTROL)
        Me.UIGROUP_MAIN.Controls.Add(Me.UIPANELSTATUS)
        Me.UIGROUP_MAIN.Size = New System.Drawing.Size(965, 560)
        '
        'UITABCONTROL
        '
        Me.UITABCONTROL.AppearancePage.Header.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.UITABCONTROL.AppearancePage.Header.Options.UseFont = True
        Me.UITABCONTROL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UITABCONTROL.Location = New System.Drawing.Point(2, 39)
        Me.UITABCONTROL.Name = "UITABCONTROL"
        Me.UITABCONTROL.SelectedTabPage = Me.UITABPAG_GEN
        Me.UITABCONTROL.Size = New System.Drawing.Size(961, 477)
        Me.UITABCONTROL.TabIndex = 0
        Me.UITABCONTROL.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.UITABPAG_GEN, Me.UITABPAG_DET})
        '
        'UITABPAG_GEN
        '
        Me.UITABPAG_GEN.Controls.Add(Me.UIPANELDATOS)
        Me.UITABPAG_GEN.Name = "UITABPAG_GEN"
        Me.UITABPAG_GEN.Size = New System.Drawing.Size(955, 446)
        Me.UITABPAG_GEN.Text = "Detalle"
        '
        'UIPANELDATOS
        '
        Me.UIPANELDATOS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UIPANELDATOS.Location = New System.Drawing.Point(0, 0)
        Me.UIPANELDATOS.Name = "UIPANELDATOS"
        Me.UIPANELDATOS.Size = New System.Drawing.Size(955, 446)
        Me.UIPANELDATOS.TabIndex = 1
        '
        'UITABPAG_DET
        '
        Me.UITABPAG_DET.Controls.Add(Me.UIGRIDCONTROL)
        Me.UITABPAG_DET.Name = "UITABPAG_DET"
        Me.UITABPAG_DET.Size = New System.Drawing.Size(955, 371)
        Me.UITABPAG_DET.Text = "General"
        '
        'UIGRIDCONTROL
        '
        Me.UIGRIDCONTROL.ContextMenuStrip = Me.UIMENUGRID
        Me.UIGRIDCONTROL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UIGRIDCONTROL.Location = New System.Drawing.Point(0, 0)
        Me.UIGRIDCONTROL.MainView = Me.UIGRIDVIEW
        Me.UIGRIDCONTROL.Name = "UIGRIDCONTROL"
        Me.UIGRIDCONTROL.Size = New System.Drawing.Size(955, 371)
        Me.UIGRIDCONTROL.TabIndex = 0
        Me.UIGRIDCONTROL.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.UIGRIDVIEW})
        '
        'UIMENUGRID
        '
        Me.UIMENUGRID.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarAExcelToolStripMenuItem})
        Me.UIMENUGRID.Name = "UIMENUGRID"
        Me.UIMENUGRID.Size = New System.Drawing.Size(156, 48)
        '
        'ExportarAExcelToolStripMenuItem
        '
        Me.ExportarAExcelToolStripMenuItem.Name = "ExportarAExcelToolStripMenuItem"
        Me.ExportarAExcelToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExportarAExcelToolStripMenuItem.Text = "Exportar a Excel"
        '
        'UIGRIDVIEW
        '
        Me.UIGRIDVIEW.GridControl = Me.UIGRIDCONTROL
        Me.UIGRIDVIEW.Name = "UIGRIDVIEW"
        Me.UIGRIDVIEW.OptionsBehavior.Editable = False
        Me.UIGRIDVIEW.OptionsMenu.EnableFooterMenu = False
        Me.UIGRIDVIEW.OptionsMenu.EnableGroupPanelMenu = False
        Me.UIGRIDVIEW.OptionsView.ColumnAutoWidth = False
        Me.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = True
        Me.UIGRIDVIEW.OptionsView.ShowDetailButtons = False
        '
        'UIPANELSTATUS
        '
        Me.UIPANELSTATUS.Controls.Add(Me.UINAV)
        Me.UIPANELSTATUS.Controls.Add(Me.UIBARRAPROGRESO)
        Me.UIPANELSTATUS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UIPANELSTATUS.Location = New System.Drawing.Point(2, 516)
        Me.UIPANELSTATUS.Name = "UIPANELSTATUS"
        Me.UIPANELSTATUS.Size = New System.Drawing.Size(961, 42)
        Me.UIPANELSTATUS.TabIndex = 2
        '
        'UINAV
        '
        Me.UINAV.Buttons.Append.Visible = False
        Me.UINAV.Buttons.CancelEdit.Visible = False
        Me.UINAV.Buttons.Edit.Visible = False
        Me.UINAV.Buttons.EndEdit.Visible = False
        Me.UINAV.Buttons.Remove.Visible = False
        Me.UINAV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UINAV.Location = New System.Drawing.Point(2, 2)
        Me.UINAV.Name = "UINAV"
        Me.UINAV.NavigatableControl = Me.UIGRIDCONTROL
        Me.UINAV.Size = New System.Drawing.Size(957, 20)
        Me.UINAV.TabIndex = 1
        Me.UINAV.Text = "ControlNavigator1"
        Me.UINAV.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        '
        'UIBARRAPROGRESO
        '
        Me.UIBARRAPROGRESO.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UIBARRAPROGRESO.EditValue = 0
        Me.UIBARRAPROGRESO.Enabled = False
        Me.UIBARRAPROGRESO.Location = New System.Drawing.Point(2, 22)
        Me.UIBARRAPROGRESO.Name = "UIBARRAPROGRESO"
        Me.UIBARRAPROGRESO.Properties.ProgressAnimationMode = DevExpress.Utils.Drawing.ProgressAnimationMode.PingPong
        Me.UIBARRAPROGRESO.Size = New System.Drawing.Size(957, 18)
        Me.UIBARRAPROGRESO.TabIndex = 0
        Me.UIBARRAPROGRESO.ToolTip = "Procesando"
        '
        'UIDIALOGO_GUARDAREXCEL
        '
        Me.UIDIALOGO_GUARDAREXCEL.Filter = "Archivos Excel | *.xlsx"
        '
        'MasterFormTab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(965, 560)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MasterFormTab"
        Me.Controls.SetChildIndex(Me.UIGROUP_MAIN, 0)
        CType(Me.UIGROUP_MAIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIGROUP_MAIN.ResumeLayout(False)
        CType(Me.UITABCONTROL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UITABCONTROL.ResumeLayout(False)
        Me.UITABPAG_GEN.ResumeLayout(False)
        CType(Me.UIPANELDATOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UITABPAG_DET.ResumeLayout(False)
        CType(Me.UIGRIDCONTROL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIMENUGRID.ResumeLayout(False)
        CType(Me.UIGRIDVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIPANELSTATUS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIPANELSTATUS.ResumeLayout(False)
        CType(Me.UIBARRAPROGRESO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents UITABCONTROL As DevExpress.XtraTab.XtraTabControl
    Public WithEvents UIGRIDCONTROL As DevExpress.XtraGrid.GridControl
    Public WithEvents UIPANELDATOS As DevExpress.XtraEditors.PanelControl
    Public WithEvents UIPANELSTATUS As DevExpress.XtraEditors.PanelControl
    Public WithEvents UINAV As DevExpress.XtraEditors.ControlNavigator
    Public WithEvents UIBARRAPROGRESO As DevExpress.XtraEditors.MarqueeProgressBarControl
    Public WithEvents UITABPAG_GEN As DevExpress.XtraTab.XtraTabPage
    Public WithEvents UITABPAG_DET As DevExpress.XtraTab.XtraTabPage
    Public WithEvents UIGRIDVIEW As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents UIMENUGRID As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExportarAExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UIDIALOGO_GUARDAREXCEL As System.Windows.Forms.SaveFileDialog

End Class
