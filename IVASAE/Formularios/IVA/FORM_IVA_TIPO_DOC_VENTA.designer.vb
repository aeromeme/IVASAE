<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_IVA_TIPO_DOC_VENTA
    Inherits IVASAE.FORM_IVA_TIPO_DOC

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
        CType(Me.UITABCONTROL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UITABCONTROL.SuspendLayout()
        CType(Me.UIGRIDCONTROL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIPANELDATOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIPANELSTATUS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIPANELSTATUS.SuspendLayout()
        CType(Me.UIBARRAPROGRESO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UITABPAG_GEN.SuspendLayout()
        Me.UITABPAG_DET.SuspendLayout()
        CType(Me.UIGRIDVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGROUP_MAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIGROUP_MAIN.SuspendLayout()
        Me.SuspendLayout()
        '
        'UITABCONTROL
        '
        Me.UITABCONTROL.AppearancePage.Header.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.UITABCONTROL.AppearancePage.Header.Options.UseFont = True
        Me.UITABCONTROL.SelectedTabPage = Me.UITABPAG_GEN
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
        'FORM_IVA_TIPO_DOC_VENTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.ClientSize = New System.Drawing.Size(965, 560)
        Me.Name = "FORM_IVA_TIPO_DOC_VENTA"
        CType(Me.UITABCONTROL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UITABCONTROL.ResumeLayout(False)
        CType(Me.UIGRIDCONTROL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIPANELDATOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIPANELSTATUS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIPANELSTATUS.ResumeLayout(False)
        CType(Me.UIBARRAPROGRESO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UITABPAG_GEN.ResumeLayout(False)
        Me.UITABPAG_DET.ResumeLayout(False)
        CType(Me.UIGRIDVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGROUP_MAIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIGROUP_MAIN.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

End Class
