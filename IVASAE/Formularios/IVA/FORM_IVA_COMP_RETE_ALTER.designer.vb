<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_IVA_COMP_RETE_ALTER
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
        Me.UIREFERENCIA = New DevExpress.XtraEditors.TextEdit()
        Me.UIMONTO_SUJETO = New DevExpress.XtraEditors.CalcEdit()
        Me.UIMONTO_RENTA = New DevExpress.XtraEditors.CalcEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.UIBTNSAVE = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.UIREFERENCIA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIMONTO_SUJETO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIMONTO_RENTA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UIREFERENCIA
        '
        Me.UIREFERENCIA.Location = New System.Drawing.Point(123, 32)
        Me.UIREFERENCIA.Name = "UIREFERENCIA"
        Me.UIREFERENCIA.Size = New System.Drawing.Size(175, 20)
        Me.UIREFERENCIA.TabIndex = 0
        '
        'UIMONTO_SUJETO
        '
        Me.UIMONTO_SUJETO.Location = New System.Drawing.Point(123, 70)
        Me.UIMONTO_SUJETO.Name = "UIMONTO_SUJETO"
        Me.UIMONTO_SUJETO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UIMONTO_SUJETO.Properties.DisplayFormat.FormatString = "n6"
        Me.UIMONTO_SUJETO.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.UIMONTO_SUJETO.Properties.EditFormat.FormatString = "n6"
        Me.UIMONTO_SUJETO.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.UIMONTO_SUJETO.Properties.Mask.EditMask = "n6"
        Me.UIMONTO_SUJETO.Size = New System.Drawing.Size(175, 20)
        Me.UIMONTO_SUJETO.TabIndex = 1
        '
        'UIMONTO_RENTA
        '
        Me.UIMONTO_RENTA.Location = New System.Drawing.Point(123, 107)
        Me.UIMONTO_RENTA.Name = "UIMONTO_RENTA"
        Me.UIMONTO_RENTA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UIMONTO_RENTA.Properties.DisplayFormat.FormatString = "n6"
        Me.UIMONTO_RENTA.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.UIMONTO_RENTA.Properties.EditFormat.FormatString = "n6"
        Me.UIMONTO_RENTA.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.UIMONTO_RENTA.Properties.Mask.EditMask = "n6"
        Me.UIMONTO_RENTA.Size = New System.Drawing.Size(175, 20)
        Me.UIMONTO_RENTA.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(50, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Referencia"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(39, 73)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Monto sujeto"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(29, 110)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Monto retenido"
        '
        'UIBTNSAVE
        '
        Me.UIBTNSAVE.Location = New System.Drawing.Point(352, 35)
        Me.UIBTNSAVE.Name = "UIBTNSAVE"
        Me.UIBTNSAVE.Size = New System.Drawing.Size(125, 51)
        Me.UIBTNSAVE.TabIndex = 6
        Me.UIBTNSAVE.Text = "Guardar"
        '
        'FORM_IVA_COMP_RETE_ALTER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 180)
        Me.Controls.Add(Me.UIBTNSAVE)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.UIMONTO_RENTA)
        Me.Controls.Add(Me.UIMONTO_SUJETO)
        Me.Controls.Add(Me.UIREFERENCIA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FORM_IVA_COMP_RETE_ALTER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Digitar informacion"
        CType(Me.UIREFERENCIA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIMONTO_SUJETO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIMONTO_RENTA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UIREFERENCIA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UIMONTO_SUJETO As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents UIMONTO_RENTA As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UIBTNSAVE As DevExpress.XtraEditors.SimpleButton
End Class
