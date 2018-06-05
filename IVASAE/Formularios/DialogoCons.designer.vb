<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogoCons
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UIGROUP_CONTAINER = New DevExpress.XtraEditors.GroupControl()
        Me.UIPANELSTATUS = New DevExpress.XtraEditors.PanelControl()
        Me.UINAV = New DevExpress.XtraEditors.ControlNavigator()
        Me.UIGRIDCONTROL = New DevExpress.XtraGrid.GridControl()
        Me.UIGRIDVIEW = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.UIGROUP_CONTAINER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIGROUP_CONTAINER.SuspendLayout()
        CType(Me.UIPANELSTATUS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIPANELSTATUS.SuspendLayout()
        CType(Me.UIGRIDCONTROL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGRIDVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UIGROUP_CONTAINER
        '
        Me.UIGROUP_CONTAINER.AppearanceCaption.BackColor = System.Drawing.Color.White
        Me.UIGROUP_CONTAINER.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.UIGROUP_CONTAINER.AppearanceCaption.ForeColor = System.Drawing.Color.White
        Me.UIGROUP_CONTAINER.AppearanceCaption.Options.UseBackColor = True
        Me.UIGROUP_CONTAINER.AppearanceCaption.Options.UseFont = True
        Me.UIGROUP_CONTAINER.AppearanceCaption.Options.UseForeColor = True
        Me.UIGROUP_CONTAINER.Controls.Add(Me.UIPANELSTATUS)
        Me.UIGROUP_CONTAINER.Controls.Add(Me.UIGRIDCONTROL)
        Me.UIGROUP_CONTAINER.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UIGROUP_CONTAINER.Location = New System.Drawing.Point(0, 0)
        Me.UIGROUP_CONTAINER.Name = "UIGROUP_CONTAINER"
        Me.UIGROUP_CONTAINER.Size = New System.Drawing.Size(546, 335)
        Me.UIGROUP_CONTAINER.TabIndex = 0
        Me.UIGROUP_CONTAINER.Text = "GroupControl1"
        '
        'UIPANELSTATUS
        '
        Me.UIPANELSTATUS.Controls.Add(Me.UINAV)
        Me.UIPANELSTATUS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UIPANELSTATUS.Location = New System.Drawing.Point(2, 310)
        Me.UIPANELSTATUS.Name = "UIPANELSTATUS"
        Me.UIPANELSTATUS.Size = New System.Drawing.Size(542, 23)
        Me.UIPANELSTATUS.TabIndex = 4
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
        Me.UINAV.Size = New System.Drawing.Size(538, 19)
        Me.UINAV.TabIndex = 1
        Me.UINAV.Text = "ControlNavigator1"
        Me.UINAV.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        '
        'UIGRIDCONTROL
        '
        Me.UIGRIDCONTROL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UIGRIDCONTROL.Location = New System.Drawing.Point(2, 32)
        Me.UIGRIDCONTROL.MainView = Me.UIGRIDVIEW
        Me.UIGRIDCONTROL.Name = "UIGRIDCONTROL"
        Me.UIGRIDCONTROL.Size = New System.Drawing.Size(542, 301)
        Me.UIGRIDCONTROL.TabIndex = 3
        Me.UIGRIDCONTROL.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.UIGRIDVIEW})
        '
        'UIGRIDVIEW
        '
        Me.UIGRIDVIEW.GridControl = Me.UIGRIDCONTROL
        Me.UIGRIDVIEW.Name = "UIGRIDVIEW"
        Me.UIGRIDVIEW.OptionsBehavior.Editable = False
        Me.UIGRIDVIEW.OptionsMenu.EnableColumnMenu = False
        Me.UIGRIDVIEW.OptionsMenu.EnableFooterMenu = False
        Me.UIGRIDVIEW.OptionsMenu.EnableGroupPanelMenu = False
        Me.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = True
        Me.UIGRIDVIEW.OptionsView.ShowGroupPanel = False
        '
        'DialogoCons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 335)
        Me.Controls.Add(Me.UIGROUP_CONTAINER)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogoCons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione"
        CType(Me.UIGROUP_CONTAINER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIGROUP_CONTAINER.ResumeLayout(False)
        CType(Me.UIPANELSTATUS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIPANELSTATUS.ResumeLayout(False)
        CType(Me.UIGRIDCONTROL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGRIDVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents UIGRIDCONTROL As DevExpress.XtraGrid.GridControl
    Public WithEvents UIGRIDVIEW As DevExpress.XtraGrid.Views.Grid.GridView
    Public WithEvents UIPANELSTATUS As DevExpress.XtraEditors.PanelControl
    Public WithEvents UINAV As DevExpress.XtraEditors.ControlNavigator
    Public WithEvents UIGROUP_CONTAINER As DevExpress.XtraEditors.GroupControl
End Class
