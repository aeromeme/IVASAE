<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_IVA_CONF_COMP
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.UICD_SERIE = New DevExpress.XtraEditors.TextEdit()
        Me.UICD_NUMERO = New DevExpress.XtraEditors.TextEdit()
        Me.UINM_DOCS_X_COMP = New DevExpress.XtraEditors.TextEdit()
        Me.UIID_TIPO_DOC = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.UIGROUP_MAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIGROUP_MAIN.SuspendLayout()
        CType(Me.UICD_SERIE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UICD_NUMERO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UINM_DOCS_X_COMP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIID_TIPO_DOC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UIGROUP_MAIN
        '
        Me.UIGROUP_MAIN.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UIGROUP_MAIN.AppearanceCaption.ForeColor = System.Drawing.Color.White
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseFont = True
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseForeColor = True
        Me.UIGROUP_MAIN.Controls.Add(Me.UIID_TIPO_DOC)
        Me.UIGROUP_MAIN.Controls.Add(Me.LabelControl4)
        Me.UIGROUP_MAIN.Controls.Add(Me.UINM_DOCS_X_COMP)
        Me.UIGROUP_MAIN.Controls.Add(Me.UICD_NUMERO)
        Me.UIGROUP_MAIN.Controls.Add(Me.UICD_SERIE)
        Me.UIGROUP_MAIN.Controls.Add(Me.LabelControl3)
        Me.UIGROUP_MAIN.Controls.Add(Me.LabelControl2)
        Me.UIGROUP_MAIN.Controls.Add(Me.LabelControl1)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(107, 65)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Serie"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(94, 94)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Numero"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(31, 124)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Docs x Comprobante"
        '
        'UICD_SERIE
        '
        Me.UICD_SERIE.Location = New System.Drawing.Point(137, 62)
        Me.UICD_SERIE.Name = "UICD_SERIE"
        Me.UICD_SERIE.Properties.MaxLength = 10
        Me.UICD_SERIE.Size = New System.Drawing.Size(100, 20)
        Me.UICD_SERIE.TabIndex = 3
        '
        'UICD_NUMERO
        '
        Me.UICD_NUMERO.Location = New System.Drawing.Point(137, 91)
        Me.UICD_NUMERO.Name = "UICD_NUMERO"
        Me.UICD_NUMERO.Properties.Mask.EditMask = "d"
        Me.UICD_NUMERO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.UICD_NUMERO.Properties.MaxLength = 10
        Me.UICD_NUMERO.Size = New System.Drawing.Size(100, 20)
        Me.UICD_NUMERO.TabIndex = 4
        '
        'UINM_DOCS_X_COMP
        '
        Me.UINM_DOCS_X_COMP.Location = New System.Drawing.Point(137, 121)
        Me.UINM_DOCS_X_COMP.Name = "UINM_DOCS_X_COMP"
        Me.UINM_DOCS_X_COMP.Properties.Mask.EditMask = "d"
        Me.UINM_DOCS_X_COMP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.UINM_DOCS_X_COMP.Properties.MaxLength = 10
        Me.UINM_DOCS_X_COMP.Size = New System.Drawing.Size(100, 20)
        Me.UINM_DOCS_X_COMP.TabIndex = 5
        '
        'UIID_TIPO_DOC
        '
        Me.UIID_TIPO_DOC.Location = New System.Drawing.Point(137, 147)
        Me.UIID_TIPO_DOC.Name = "UIID_TIPO_DOC"
        Me.UIID_TIPO_DOC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UIID_TIPO_DOC.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DS_NOMBRE", "Documento", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SIS_SUFIJO", "SIS_SUFIJO", 68, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SIS_EXCLU_SUFIJO", "SIS_EXCLU_SUFIJO", 105, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NM_CHARS_SERIE", "NM_CHARS_SERIE", 100, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CD_DET", "CD_DET", 49, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CD_TIPO", "CD_TIPO", 54, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FLG_COMPRA", "FLG_COMPRA", 77, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FLG_VENTA", "FLG_VENTA", 66, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FLG_IMPO_SAE", "FLG_IMPO_SAE", 85, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("
", "FLG_COMPRA_GRAVADA", 131, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NM_CHARS_SUFIJO", "NM_CHARS_SUFIJO", 107, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SIS_EXCLU_SUFIJO_2", "SIS_EXCLU_SUFIJO_2", 117, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.UIID_TIPO_DOC.Properties.DisplayMember = "DS_NOMBRE"
        Me.UIID_TIPO_DOC.Properties.ValueMember = "ID"
        Me.UIID_TIPO_DOC.Size = New System.Drawing.Size(122, 20)
        Me.UIID_TIPO_DOC.TabIndex = 16
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(76, 151)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl4.TabIndex = 15
        Me.LabelControl4.Text = "Documento"
        '
        'FORM_IVA_CONF_COMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(965, 485)
        Me.Name = "FORM_IVA_CONF_COMP"
        CType(Me.UIGROUP_MAIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIGROUP_MAIN.ResumeLayout(False)
        Me.UIGROUP_MAIN.PerformLayout()
        CType(Me.UICD_SERIE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UICD_NUMERO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UINM_DOCS_X_COMP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIID_TIPO_DOC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UINM_DOCS_X_COMP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UICD_NUMERO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UICD_SERIE As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UIID_TIPO_DOC As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl

End Class
