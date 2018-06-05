<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FcambiarPwd
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
        Me.components = New System.ComponentModel.Container()
        Dim CompareAgainstControlValidationRule2 As DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule = New DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule()
        Me.UIPASS = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.uibtncancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.uibtnguardar = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.UIPASSCONFIRM = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.UIOLDPASS = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.UIValidador = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
        CType(Me.UIPASS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.UIPASSCONFIRM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIOLDPASS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIValidador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UIPASS
        '
        Me.UIPASS.Location = New System.Drawing.Point(73, 49)
        Me.UIPASS.Name = "UIPASS"
        Me.UIPASS.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UIPASS.Size = New System.Drawing.Size(183, 20)
        Me.UIPASS.TabIndex = 2
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.PanelControl2)
        Me.LayoutControl1.Controls.Add(Me.PanelControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(324, 257)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.uibtncancelar)
        Me.PanelControl2.Controls.Add(Me.uibtnguardar)
        Me.PanelControl2.Location = New System.Drawing.Point(12, 178)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(300, 67)
        Me.PanelControl2.TabIndex = 50
        '
        'uibtncancelar
        '
        Me.uibtncancelar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uibtncancelar.Image = Global.IVASAE.My.Resources.Resources._1422070421_Cancel
        Me.uibtncancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.uibtncancelar.Location = New System.Drawing.Point(150, 2)
        Me.uibtncancelar.Name = "uibtncancelar"
        Me.uibtncancelar.Size = New System.Drawing.Size(148, 63)
        Me.uibtncancelar.TabIndex = 5
        Me.uibtncancelar.TabStop = False
        Me.uibtncancelar.Text = "Cancelar"
        '
        'uibtnguardar
        '
        Me.uibtnguardar.Dock = System.Windows.Forms.DockStyle.Left
        Me.uibtnguardar.Image = Global.IVASAE.My.Resources.Resources._1422070247_Save
        Me.uibtnguardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.uibtnguardar.Location = New System.Drawing.Point(2, 2)
        Me.uibtnguardar.Name = "uibtnguardar"
        Me.uibtnguardar.Size = New System.Drawing.Size(148, 63)
        Me.uibtnguardar.TabIndex = 4
        Me.uibtnguardar.TabStop = False
        Me.uibtnguardar.Text = "Guardar"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.UIPASSCONFIRM)
        Me.PanelControl1.Controls.Add(Me.UIPASS)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.UIOLDPASS)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(300, 162)
        Me.PanelControl1.TabIndex = 40
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelControl4.Location = New System.Drawing.Point(2, 118)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(296, 42)
        Me.LabelControl4.TabIndex = 60
        Me.LabelControl4.Text = "La contraseña debe tener al menos 8 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "caracteres, un caracter mayuscula y " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "un nu" & _
    "mero."
        '
        'UIPASSCONFIRM
        '
        Me.UIPASSCONFIRM.Location = New System.Drawing.Point(73, 83)
        Me.UIPASSCONFIRM.Name = "UIPASSCONFIRM"
        Me.UIPASSCONFIRM.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UIPASSCONFIRM.Size = New System.Drawing.Size(183, 20)
        Me.UIPASSCONFIRM.TabIndex = 3
        CompareAgainstControlValidationRule2.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals
        CompareAgainstControlValidationRule2.Control = Me.UIPASS
        CompareAgainstControlValidationRule2.ErrorText = "Contraseñas deben coincidir"
        CompareAgainstControlValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning
        Me.UIValidador.SetValidationRule(Me.UIPASSCONFIRM, CompareAgainstControlValidationRule2)
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(20, 87)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl3.TabIndex = 30
        Me.LabelControl3.Text = "Confirmar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(36, 52)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl2.TabIndex = 20
        Me.LabelControl2.Text = "Nueva"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(37, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Actual"
        '
        'UIOLDPASS
        '
        Me.UIOLDPASS.Location = New System.Drawing.Point(73, 14)
        Me.UIOLDPASS.Name = "UIOLDPASS"
        Me.UIOLDPASS.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UIOLDPASS.Size = New System.Drawing.Size(183, 20)
        Me.UIOLDPASS.TabIndex = 1
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(324, 257)
        Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PanelControl1
        Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(304, 166)
        Me.LayoutControlItem1.Text = "LayoutControlItem1"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextToControlDistance = 0
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.PanelControl2
        Me.LayoutControlItem2.CustomizationFormText = "LayoutControlItem2"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 166)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(304, 71)
        Me.LayoutControlItem2.Text = "LayoutControlItem2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextToControlDistance = 0
        Me.LayoutControlItem2.TextVisible = False
        '
        'UIValidador
        '
        Me.UIValidador.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual
        '
        'FcambiarPwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 257)
        Me.Controls.Add(Me.LayoutControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FcambiarPwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar contraseña"
        CType(Me.UIPASS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.UIPASSCONFIRM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIOLDPASS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIValidador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents uibtncancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents uibtnguardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents UIPASSCONFIRM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UIPASS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UIOLDPASS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents UIValidador As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
