<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_IVA_CONF
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
        Me.UINM_PORC_IVA = New DevExpress.XtraEditors.CalcEdit()
        Me.IVACLASEPRODUCTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.UIGROUP_MAIN,System.ComponentModel.ISupportInitialize).BeginInit
        Me.UIGROUP_MAIN.SuspendLayout
        CType(Me.UINM_PORC_IVA.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.IVACLASEPRODUCTOBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'UIGROUP_MAIN
        '
        Me.UIGROUP_MAIN.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UIGROUP_MAIN.AppearanceCaption.ForeColor = System.Drawing.Color.White
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseFont = true
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseForeColor = true
        Me.UIGROUP_MAIN.Controls.Add(Me.LabelControl1)
        Me.UIGROUP_MAIN.Controls.Add(Me.UINM_PORC_IVA)
        Me.UIGROUP_MAIN.Size = New System.Drawing.Size(729, 531)
        '
        'UINM_PORC_IVA
        '
        Me.UINM_PORC_IVA.Location = New System.Drawing.Point(209, 102)
        Me.UINM_PORC_IVA.Name = "UINM_PORC_IVA"
        Me.UINM_PORC_IVA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UINM_PORC_IVA.Size = New System.Drawing.Size(174, 20)
        Me.UINM_PORC_IVA.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(53, 105)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(17, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "IVA"
        '
        'FORM_IVA_CONF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.ClientSize = New System.Drawing.Size(729, 531)
        Me.Name = "FORM_IVA_CONF"
        CType(Me.UIGROUP_MAIN,System.ComponentModel.ISupportInitialize).EndInit
        Me.UIGROUP_MAIN.ResumeLayout(false)
        Me.UIGROUP_MAIN.PerformLayout
        CType(Me.UINM_PORC_IVA.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.IVACLASEPRODUCTOBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents IVACLASEPRODUCTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UINM_PORC_IVA As DevExpress.XtraEditors.CalcEdit

End Class
