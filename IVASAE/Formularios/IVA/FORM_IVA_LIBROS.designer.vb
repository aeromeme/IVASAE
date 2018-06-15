<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORM_IVA_LIBROS
    Inherits IVASAE.MasterPrintXRForm

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
        Me.uicd_libro = New DevExpress.XtraEditors.LookUpEdit()
        Me.ClasegenericaparesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.uibtngenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.uibtnpreparar = New DevExpress.XtraEditors.SimpleButton()
        Me.uiflgenca = New DevExpress.XtraEditors.CheckEdit()
        Me.uibtncerrarPeriodo = New DevExpress.XtraEditors.SimpleButton()
        Me.uigridexport = New DevExpress.XtraGrid.GridControl()
        Me.uigridviewexport = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.UIDIALOGO_GUARDAREXCEL = New System.Windows.Forms.SaveFileDialog()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.uipanelfiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uipanelfiltro.SuspendLayout()
        CType(Me.uipanelcolapsefiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIRBNCONTROL_REPORT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIPRINTRIBBONCONTROL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UIGROUP_MAIN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UIGROUP_MAIN.SuspendLayout()
        CType(Me.uicd_libro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClasegenericaparesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uiflgenca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uigridexport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uigridviewexport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Size = New System.Drawing.Size(1254, 581)
        Me.LayoutControl1.Controls.SetChildIndex(Me.uipanelfiltro, 0)
        Me.LayoutControl1.Controls.SetChildIndex(Me.UIREPORT_STATUS, 0)
        Me.LayoutControl1.Controls.SetChildIndex(Me.UIVISOR_REPORTES, 0)
        '
        'uipanelfiltro
        '
        Me.uipanelfiltro.Controls.Add(Me.SimpleButton1)
        Me.uipanelfiltro.Controls.Add(Me.uigridexport)
        Me.uipanelfiltro.Controls.Add(Me.uibtncerrarPeriodo)
        Me.uipanelfiltro.Controls.Add(Me.uiflgenca)
        Me.uipanelfiltro.Controls.Add(Me.uibtnpreparar)
        Me.uipanelfiltro.Controls.Add(Me.uibtngenerar)
        Me.uipanelfiltro.Controls.Add(Me.LabelControl1)
        Me.uipanelfiltro.Controls.Add(Me.uicd_libro)
        Me.uipanelfiltro.Location = New System.Drawing.Point(1054, 24)
        Me.uipanelfiltro.TabIndex = 2
        '
        'uipanelcolapsefiltro
        '
        Me.uipanelcolapsefiltro.Location = New System.Drawing.Point(1030, 0)
        '
        'UIRBNCONTROL_REPORT
        '
        Me.UIRBNCONTROL_REPORT.ExpandCollapseItem.Id = 0
        Me.UIRBNCONTROL_REPORT.Size = New System.Drawing.Size(1258, 142)
        '
        'UIVISOR_REPORTES
        '
        Me.UIVISOR_REPORTES.Size = New System.Drawing.Size(1002, 484)
        Me.UIVISOR_REPORTES.TabIndex = 0
        '
        'UIREPORT_STATUS
        '
        Me.UIREPORT_STATUS.Size = New System.Drawing.Size(1002, 27)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Size = New System.Drawing.Size(1006, 488)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1006, 30)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1254, 581)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1030, 561)
        '
        'UIGROUP_MAIN
        '
        Me.UIGROUP_MAIN.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UIGROUP_MAIN.AppearanceCaption.ForeColor = System.Drawing.Color.White
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseFont = True
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseForeColor = True
        Me.UIGROUP_MAIN.Size = New System.Drawing.Size(1258, 622)
        '
        'uicd_libro
        '
        Me.uicd_libro.Location = New System.Drawing.Point(17, 38)
        Me.uicd_libro.MenuManager = Me.UIRBNCONTROL_REPORT
        Me.uicd_libro.Name = "uicd_libro"
        Me.uicd_libro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.uicd_libro.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 56, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Libro", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.uicd_libro.Properties.DataSource = Me.ClasegenericaparesBindingSource
        Me.uicd_libro.Properties.DisplayMember = "Descripcion"
        Me.uicd_libro.Properties.ValueMember = "Codigo"
        Me.uicd_libro.Size = New System.Drawing.Size(129, 20)
        Me.uicd_libro.TabIndex = 0
        '
        'ClasegenericaparesBindingSource
        '
        Me.ClasegenericaparesBindingSource.DataSource = GetType(IVASAE.Utilidades.clasegenericapares)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(17, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Libro"
        '
        'uibtngenerar
        '
        Me.uibtngenerar.Location = New System.Drawing.Point(17, 118)
        Me.uibtngenerar.Name = "uibtngenerar"
        Me.uibtngenerar.Size = New System.Drawing.Size(129, 35)
        Me.uibtngenerar.TabIndex = 2
        Me.uibtngenerar.Text = "Imprimir reporte"
        '
        'uibtnpreparar
        '
        Me.uibtnpreparar.Location = New System.Drawing.Point(17, 170)
        Me.uibtnpreparar.Name = "uibtnpreparar"
        Me.uibtnpreparar.Size = New System.Drawing.Size(129, 35)
        Me.uibtnpreparar.TabIndex = 3
        Me.uibtnpreparar.Text = "Preparar libro"
        '
        'uiflgenca
        '
        Me.uiflgenca.Location = New System.Drawing.Point(15, 76)
        Me.uiflgenca.MenuManager = Me.UIRBNCONTROL_REPORT
        Me.uiflgenca.Name = "uiflgenca"
        Me.uiflgenca.Properties.Caption = "Mostrar encabezado"
        Me.uiflgenca.Size = New System.Drawing.Size(131, 19)
        Me.uiflgenca.TabIndex = 4
        '
        'uibtncerrarPeriodo
        '
        Me.uibtncerrarPeriodo.Image = Global.IVASAE.My.Resources.Resources._1424930626_change_password
        Me.uibtncerrarPeriodo.Location = New System.Drawing.Point(17, 221)
        Me.uibtncerrarPeriodo.Name = "uibtncerrarPeriodo"
        Me.uibtncerrarPeriodo.Size = New System.Drawing.Size(129, 35)
        Me.uibtncerrarPeriodo.TabIndex = 5
        Me.uibtncerrarPeriodo.Text = "Cerrar periodo"
        '
        'uigridexport
        '
        Me.uigridexport.Location = New System.Drawing.Point(17, 330)
        Me.uigridexport.MainView = Me.uigridviewexport
        Me.uigridexport.MenuManager = Me.UIRBNCONTROL_REPORT
        Me.uigridexport.Name = "uigridexport"
        Me.uigridexport.Size = New System.Drawing.Size(357, 257)
        Me.uigridexport.TabIndex = 6
        Me.uigridexport.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.uigridviewexport})
        Me.uigridexport.Visible = False
        '
        'uigridviewexport
        '
        Me.uigridviewexport.GridControl = Me.uigridexport
        Me.uigridviewexport.Name = "uigridviewexport"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(17, 277)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(129, 33)
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "Exportar datos"
        '
        'UIDIALOGO_GUARDAREXCEL
        '
        Me.UIDIALOGO_GUARDAREXCEL.Filter = "Archivos Excel | *.xlsx"
        '
        'FORM_IVA_LIBROS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1258, 622)
        Me.Name = "FORM_IVA_LIBROS"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.uipanelfiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uipanelfiltro.ResumeLayout(False)
        Me.uipanelfiltro.PerformLayout()
        CType(Me.uipanelcolapsefiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIRBNCONTROL_REPORT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIPRINTRIBBONCONTROL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UIGROUP_MAIN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UIGROUP_MAIN.ResumeLayout(False)
        CType(Me.uicd_libro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClasegenericaparesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uiflgenca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uigridexport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uigridviewexport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents uibtngenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents uicd_libro As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ClasegenericaparesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents uibtnpreparar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents uiflgenca As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents uibtncerrarPeriodo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents uigridexport As DevExpress.XtraGrid.GridControl
    Friend WithEvents uigridviewexport As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents UIDIALOGO_GUARDAREXCEL As System.Windows.Forms.SaveFileDialog

End Class
