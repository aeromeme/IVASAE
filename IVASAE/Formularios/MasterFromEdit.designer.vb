<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterFromEdit
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
        Me.UIMENU = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExportarAExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UIDIALOGO_GUARDAREXCEL = New System.Windows.Forms.SaveFileDialog()
        Me.UIGRIDCONTROL = New DevExpress.XtraGrid.GridControl()
        Me.UIGRIDVIEW = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.UIPANELSTATUS = New DevExpress.XtraEditors.PanelControl()
        Me.UINAV = New DevExpress.XtraEditors.ControlNavigator()
        CType(Me.UIGROUP_MAIN,System.ComponentModel.ISupportInitialize).BeginInit
        Me.UIGROUP_MAIN.SuspendLayout
        Me.UIMENU.SuspendLayout
        CType(Me.UIGRIDCONTROL,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UIGRIDVIEW,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UIPANELSTATUS,System.ComponentModel.ISupportInitialize).BeginInit
        Me.UIPANELSTATUS.SuspendLayout
        Me.SuspendLayout
        '
        'UIGROUP_MAIN
        '
        Me.UIGROUP_MAIN.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UIGROUP_MAIN.AppearanceCaption.ForeColor = System.Drawing.Color.White
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseFont = true
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseForeColor = true
        Me.UIGROUP_MAIN.Controls.Add(Me.UIGRIDCONTROL)
        Me.UIGROUP_MAIN.Controls.Add(Me.UIPANELSTATUS)
        '
        'UIMENU
        '
        Me.UIMENU.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportarAExcelToolStripMenuItem})
        Me.UIMENU.Name = "UIMENU"
        Me.UIMENU.Size = New System.Drawing.Size(156, 26)
        '
        'ExportarAExcelToolStripMenuItem
        '
        Me.ExportarAExcelToolStripMenuItem.Name = "ExportarAExcelToolStripMenuItem"
        Me.ExportarAExcelToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExportarAExcelToolStripMenuItem.Text = "Exportar a excel"
        '
        'UIDIALOGO_GUARDAREXCEL
        '
        Me.UIDIALOGO_GUARDAREXCEL.Filter = "Archivos Excel | *.xlsx"
        '
        'UIGRIDCONTROL
        '
        Me.UIGRIDCONTROL.ContextMenuStrip = Me.UIMENU
        Me.UIGRIDCONTROL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UIGRIDCONTROL.Location = New System.Drawing.Point(2, 38)
        Me.UIGRIDCONTROL.MainView = Me.UIGRIDVIEW
        Me.UIGRIDCONTROL.Name = "UIGRIDCONTROL"
        Me.UIGRIDCONTROL.Size = New System.Drawing.Size(961, 418)
        Me.UIGRIDCONTROL.TabIndex = 1
        Me.UIGRIDCONTROL.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.UIGRIDVIEW})
        '
        'UIGRIDVIEW
        '
        Me.UIGRIDVIEW.GridControl = Me.UIGRIDCONTROL
        Me.UIGRIDVIEW.Name = "UIGRIDVIEW"
        Me.UIGRIDVIEW.OptionsCustomization.AllowGroup = false
        Me.UIGRIDVIEW.OptionsMenu.EnableFooterMenu = false
        Me.UIGRIDVIEW.OptionsMenu.EnableGroupPanelMenu = false
        Me.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = true
        Me.UIGRIDVIEW.OptionsView.ShowGroupPanel = false
        '
        'UIPANELSTATUS
        '
        Me.UIPANELSTATUS.Controls.Add(Me.UINAV)
        Me.UIPANELSTATUS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UIPANELSTATUS.Location = New System.Drawing.Point(2, 456)
        Me.UIPANELSTATUS.Name = "UIPANELSTATUS"
        Me.UIPANELSTATUS.Size = New System.Drawing.Size(961, 27)
        Me.UIPANELSTATUS.TabIndex = 3
        '
        'UINAV
        '
        Me.UINAV.Buttons.Append.Visible = false
        Me.UINAV.Buttons.CancelEdit.Visible = false
        Me.UINAV.Buttons.Edit.Visible = false
        Me.UINAV.Buttons.EndEdit.Visible = false
        Me.UINAV.Buttons.Remove.Visible = false
        Me.UINAV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UINAV.Location = New System.Drawing.Point(2, 2)
        Me.UINAV.Name = "UINAV"
        Me.UINAV.NavigatableControl = Me.UIGRIDCONTROL
        Me.UINAV.Size = New System.Drawing.Size(957, 23)
        Me.UINAV.TabIndex = 1
        Me.UINAV.Text = "ControlNavigator1"
        Me.UINAV.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        '
        'MasterFromEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.ClientSize = New System.Drawing.Size(965, 485)
        Me.Name = "MasterFromEdit"
        Me.Controls.SetChildIndex(Me.UIGROUP_MAIN, 0)
        CType(Me.UIGROUP_MAIN,System.ComponentModel.ISupportInitialize).EndInit
        Me.UIGROUP_MAIN.ResumeLayout(false)
        Me.UIMENU.ResumeLayout(false)
        CType(Me.UIGRIDCONTROL,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UIGRIDVIEW,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UIPANELSTATUS,System.ComponentModel.ISupportInitialize).EndInit
        Me.UIPANELSTATUS.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents UIMENU As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExportarAExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UIDIALOGO_GUARDAREXCEL As System.Windows.Forms.SaveFileDialog
    Public WithEvents UIGRIDCONTROL As DevExpress.XtraGrid.GridControl
    Public WithEvents UIGRIDVIEW As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents UIPANELSTATUS As DevExpress.XtraEditors.PanelControl
    Public WithEvents UINAV As DevExpress.XtraEditors.ControlNavigator

End Class
