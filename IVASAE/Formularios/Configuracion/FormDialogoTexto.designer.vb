<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDialogoTexto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDialogoTexto))
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.UIINFORMACIONTABPAGE = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.UITXTLEYENDA = New DevExpress.XtraEditors.MemoEdit()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.UIINFORMACIONTABPAGE.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UITXTLEYENDA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.UIINFORMACIONTABPAGE
        Me.XtraTabControl1.Size = New System.Drawing.Size(451, 374)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.UIINFORMACIONTABPAGE, Me.XtraTabPage2})
        '
        'UIINFORMACIONTABPAGE
        '
        Me.UIINFORMACIONTABPAGE.Controls.Add(Me.PanelControl1)
        Me.UIINFORMACIONTABPAGE.Name = "UIINFORMACIONTABPAGE"
        Me.UIINFORMACIONTABPAGE.Size = New System.Drawing.Size(445, 346)
        Me.UIINFORMACIONTABPAGE.Text = "Informacion"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PictureEdit2)
        Me.PanelControl1.Controls.Add(Me.UITXTLEYENDA)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(445, 346)
        Me.PanelControl1.TabIndex = 1
        '
        'PictureEdit2
        '
        Me.PictureEdit2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit2.EditValue = Global.IVASAE.My.Resources.Resources._1424930818_stock_view_details
        Me.PictureEdit2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureEdit2.Location = New System.Drawing.Point(2, 2)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Size = New System.Drawing.Size(113, 342)
        Me.PictureEdit2.TabIndex = 1
        '
        'UITXTLEYENDA
        '
        Me.UITXTLEYENDA.Dock = System.Windows.Forms.DockStyle.Right
        Me.UITXTLEYENDA.Location = New System.Drawing.Point(115, 2)
        Me.UITXTLEYENDA.Name = "UITXTLEYENDA"
        Me.UITXTLEYENDA.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.UITXTLEYENDA.Size = New System.Drawing.Size(328, 342)
        Me.UITXTLEYENDA.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.PanelControl2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(445, 346)
        Me.XtraTabPage2.Text = "Publicacion"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.PictureEdit1)
        Me.PanelControl2.Controls.Add(Me.MemoEdit1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(445, 346)
        Me.PanelControl2.TabIndex = 2
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureEdit1.EditValue = Global.IVASAE.My.Resources.Resources.logo_imacasa
        Me.PictureEdit1.Location = New System.Drawing.Point(2, 2)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Size = New System.Drawing.Size(441, 101)
        Me.PictureEdit1.TabIndex = 1
        '
        'MemoEdit1
        '
        Me.MemoEdit1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[True]
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MemoEdit1.EditValue = resources.GetString("MemoEdit1.EditValue")
        Me.MemoEdit1.Location = New System.Drawing.Point(2, 103)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.[True]
        Me.MemoEdit1.Size = New System.Drawing.Size(441, 241)
        Me.MemoEdit1.TabIndex = 0
        '
        'FormDialogoTexto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 374)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FormDialogoTexto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informacion"
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.UIINFORMACIONTABPAGE.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UITXTLEYENDA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UIINFORMACIONTABPAGE As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents UITXTLEYENDA As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
End Class
