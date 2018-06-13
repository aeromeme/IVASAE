<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_IVA_SELECT_DOC_PERC_SAE
    Inherits IVASAE.DialogoCons

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
        Me.VIVARETENCIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOMBRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRFC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNIT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCALLE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colANIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.UIGRIDCONTROL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGRIDVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIPANELSTATUS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIPANELSTATUS.SuspendLayout()
        CType(Me.UIGROUP_CONTAINER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIGROUP_CONTAINER.SuspendLayout()
        CType(Me.VIVARETENCIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UIGRIDCONTROL
        '
        Me.UIGRIDCONTROL.DataSource = Me.VIVARETENCIONBindingSource
        '
        'UIGRIDVIEW
        '
        Me.UIGRIDVIEW.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.colNOMBRE, Me.colRFC, Me.colNIT, Me.colCALLE, Me.GridColumn3, Me.GridColumn4, Me.colANIO, Me.GridColumn5, Me.GridColumn6})
        Me.UIGRIDVIEW.OptionsBehavior.Editable = False
        Me.UIGRIDVIEW.OptionsMenu.EnableColumnMenu = False
        Me.UIGRIDVIEW.OptionsMenu.EnableFooterMenu = False
        Me.UIGRIDVIEW.OptionsMenu.EnableGroupPanelMenu = False
        Me.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = True
        Me.UIGRIDVIEW.OptionsView.ShowGroupPanel = False
        '
        'UINAV
        '
        Me.UINAV.Buttons.Append.Visible = False
        Me.UINAV.Buttons.CancelEdit.Visible = False
        Me.UINAV.Buttons.Edit.Visible = False
        Me.UINAV.Buttons.EndEdit.Visible = False
        Me.UINAV.Buttons.Remove.Visible = False
        '
        'UIGROUP_CONTAINER
        '
        Me.UIGROUP_CONTAINER.AppearanceCaption.BackColor = System.Drawing.Color.White
        Me.UIGROUP_CONTAINER.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.UIGROUP_CONTAINER.AppearanceCaption.ForeColor = System.Drawing.Color.White
        Me.UIGROUP_CONTAINER.AppearanceCaption.Options.UseBackColor = True
        Me.UIGROUP_CONTAINER.AppearanceCaption.Options.UseFont = True
        Me.UIGROUP_CONTAINER.AppearanceCaption.Options.UseForeColor = True
        '
        'VIVARETENCIONBindingSource
        '
        Me.VIVARETENCIONBindingSource.DataSource = GetType(IVA.V_IVA_RETENCION)
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Documento"
        Me.GridColumn1.FieldName = "No_DOCTO"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "CVE_CLPV"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'colNOMBRE
        '
        Me.colNOMBRE.Caption = "Proveedor"
        Me.colNOMBRE.FieldName = "NOMBRE"
        Me.colNOMBRE.Name = "colNOMBRE"
        '
        'colRFC
        '
        Me.colRFC.FieldName = "RFC"
        Me.colRFC.Name = "colRFC"
        '
        'colNIT
        '
        Me.colNIT.FieldName = "NIT"
        Me.colNIT.Name = "colNIT"
        '
        'colCALLE
        '
        Me.colCALLE.FieldName = "CALLE"
        Me.colCALLE.Name = "colCALLE"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Fecha"
        Me.GridColumn3.FieldName = "FECHA_DOC"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "MES"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'colANIO
        '
        Me.colANIO.FieldName = "ANIO"
        Me.colANIO.Name = "colANIO"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Retencion"
        Me.GridColumn5.FieldName = "IMPUESTO"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Sujeto"
        Me.GridColumn6.FieldName = "MONTO"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        '
        'FORM_IVA_SELECT_DOC_PERC_SAE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(546, 335)
        Me.Name = "FORM_IVA_SELECT_DOC_PERC_SAE"
        CType(Me.UIGRIDCONTROL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGRIDVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIPANELSTATUS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIPANELSTATUS.ResumeLayout(False)
        CType(Me.UIGROUP_CONTAINER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIGROUP_CONTAINER.ResumeLayout(False)
        CType(Me.VIVARETENCIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VIVAPERCEPCIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colNo_DOCTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA_DOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIMPUESTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMONTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCVE_CLPV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAÑO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VIVARETENCIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOMBRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRFC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNIT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCALLE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colANIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn

End Class
