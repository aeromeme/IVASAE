﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fusuarios
    Inherits IVASAE.MasterFormTab

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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.UICD_LOGIN = New DevExpress.XtraEditors.TextEdit()
        Me.UICD_PASSWORD = New DevExpress.XtraEditors.TextEdit()
        Me.UIDESC_NOMBRE_USUARIO = New DevExpress.XtraEditors.TextEdit()
        Me.UICD_NIVEL_ACCESO = New DevExpress.XtraEditors.LookUpEdit()
        Me.GENPERFILBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UICD_ESTADO = New DevExpress.XtraEditors.LookUpEdit()
        Me.ClasegenericaparesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UIID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.GENUSUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCD_LOGIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCD_PASSWORD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESC_NOMBRE_USUARIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colID_PERFIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UIGRID_ID_PERFIL = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colCD_ESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UIGRID_CD_ESTADO = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colGEN_PERFIL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VGENUSUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colCD_CORREO_E = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UICD_CORREO_E = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.GENPERFILANDROIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.UITABCONTROL,System.ComponentModel.ISupportInitialize).BeginInit
        Me.UITABCONTROL.SuspendLayout
        CType(Me.UIGRIDCONTROL,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UIPANELDATOS,System.ComponentModel.ISupportInitialize).BeginInit
        Me.UIPANELDATOS.SuspendLayout
        CType(Me.UIPANELSTATUS,System.ComponentModel.ISupportInitialize).BeginInit
        Me.UIPANELSTATUS.SuspendLayout
        Me.UITABPAG_GEN.SuspendLayout
        Me.UITABPAG_DET.SuspendLayout
        CType(Me.UIGRIDVIEW,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UIGROUP_MAIN,System.ComponentModel.ISupportInitialize).BeginInit
        Me.UIGROUP_MAIN.SuspendLayout
        CType(Me.UICD_LOGIN.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UICD_PASSWORD.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UIDESC_NOMBRE_USUARIO.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UICD_NIVEL_ACCESO.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GENPERFILBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UICD_ESTADO.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ClasegenericaparesBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UIID.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GENUSUARIOBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UIGRID_ID_PERFIL,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UIGRID_CD_ESTADO,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.VGENUSUARIOBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.UICD_CORREO_E.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GENPERFILANDROIDBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'UITABCONTROL
        '
        Me.UITABCONTROL.AppearancePage.Header.Font = New System.Drawing.Font("Arial", 10!)
        Me.UITABCONTROL.AppearancePage.Header.Options.UseFont = true
        Me.UITABCONTROL.Location = New System.Drawing.Point(2, 38)
        Me.UITABCONTROL.Size = New System.Drawing.Size(961, 478)
        '
        'UIGRIDCONTROL
        '
        Me.UIGRIDCONTROL.DataSource = Me.VGENUSUARIOBindingSource
        Me.UIGRIDCONTROL.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.UIGRID_ID_PERFIL, Me.UIGRID_CD_ESTADO})
        Me.UIGRIDCONTROL.Size = New System.Drawing.Size(955, 447)
        '
        'UIPANELDATOS
        '
        Me.UIPANELDATOS.Controls.Add(Me.UICD_CORREO_E)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl7)
        Me.UIPANELDATOS.Controls.Add(Me.UIID)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl6)
        Me.UIPANELDATOS.Controls.Add(Me.UICD_ESTADO)
        Me.UIPANELDATOS.Controls.Add(Me.UICD_NIVEL_ACCESO)
        Me.UIPANELDATOS.Controls.Add(Me.UIDESC_NOMBRE_USUARIO)
        Me.UIPANELDATOS.Controls.Add(Me.UICD_PASSWORD)
        Me.UIPANELDATOS.Controls.Add(Me.UICD_LOGIN)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl5)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl4)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl3)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl2)
        Me.UIPANELDATOS.Controls.Add(Me.LabelControl1)
        Me.UIPANELDATOS.Size = New System.Drawing.Size(955, 447)
        '
        'UINAV
        '
        Me.UINAV.Buttons.Append.Visible = false
        Me.UINAV.Buttons.CancelEdit.Visible = false
        Me.UINAV.Buttons.Edit.Visible = false
        Me.UINAV.Buttons.EndEdit.Visible = false
        Me.UINAV.Buttons.Remove.Visible = false
        '
        'UIBARRAPROGRESO
        '
        '
        'UITABPAG_GEN
        '
        Me.UITABPAG_GEN.Size = New System.Drawing.Size(955, 447)
        '
        'UITABPAG_DET
        '
        Me.UITABPAG_DET.Size = New System.Drawing.Size(955, 447)
        '
        'UIGRIDVIEW
        '
        Me.UIGRIDVIEW.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colCD_LOGIN, Me.colCD_PASSWORD, Me.colDESC_NOMBRE_USUARIO, Me.colID_PERFIL, Me.colCD_ESTADO, Me.colGEN_PERFIL, Me.colCD_CORREO_E})
        Me.UIGRIDVIEW.OptionsBehavior.Editable = false
        Me.UIGRIDVIEW.OptionsMenu.EnableColumnMenu = false
        Me.UIGRIDVIEW.OptionsMenu.EnableFooterMenu = false
        Me.UIGRIDVIEW.OptionsMenu.EnableGroupPanelMenu = false
        Me.UIGRIDVIEW.OptionsView.ColumnAutoWidth = false
        Me.UIGRIDVIEW.OptionsView.ShowAutoFilterRow = true
        Me.UIGRIDVIEW.OptionsView.ShowDetailButtons = false
        '
        'UIGROUP_MAIN
        '
        Me.UIGROUP_MAIN.AppearanceCaption.Font = New System.Drawing.Font("Arial Narrow", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.UIGROUP_MAIN.AppearanceCaption.ForeColor = System.Drawing.Color.White
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseFont = true
        Me.UIGROUP_MAIN.AppearanceCaption.Options.UseForeColor = true
        Me.UIGROUP_MAIN.Text = "Usuarios"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(93, 67)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Usuario"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(73, 102)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Contraseña"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(92, 142)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Nombre"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(95, 172)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Acceso"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(96, 212)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Estado"
        '
        'UICD_LOGIN
        '
        Me.UICD_LOGIN.Location = New System.Drawing.Point(145, 64)
        Me.UICD_LOGIN.Name = "UICD_LOGIN"
        Me.UICD_LOGIN.Size = New System.Drawing.Size(236, 20)
        Me.UICD_LOGIN.TabIndex = 5
        '
        'UICD_PASSWORD
        '
        Me.UICD_PASSWORD.Location = New System.Drawing.Point(145, 99)
        Me.UICD_PASSWORD.Name = "UICD_PASSWORD"
        Me.UICD_PASSWORD.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UICD_PASSWORD.Size = New System.Drawing.Size(236, 20)
        Me.UICD_PASSWORD.TabIndex = 6
        '
        'UIDESC_NOMBRE_USUARIO
        '
        Me.UIDESC_NOMBRE_USUARIO.Location = New System.Drawing.Point(145, 135)
        Me.UIDESC_NOMBRE_USUARIO.Name = "UIDESC_NOMBRE_USUARIO"
        Me.UIDESC_NOMBRE_USUARIO.Size = New System.Drawing.Size(323, 20)
        Me.UIDESC_NOMBRE_USUARIO.TabIndex = 7
        '
        'UICD_NIVEL_ACCESO
        '
        Me.UICD_NIVEL_ACCESO.Location = New System.Drawing.Point(145, 169)
        Me.UICD_NIVEL_ACCESO.Name = "UICD_NIVEL_ACCESO"
        Me.UICD_NIVEL_ACCESO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UICD_NIVEL_ACCESO.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DS_NOMBRE_PERFIL", "Perfil", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CD_NIVEL_ACCESO", "CD_NIVEL_ACCESO", 105, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)})
        Me.UICD_NIVEL_ACCESO.Properties.DataSource = Me.GENPERFILBindingSource
        Me.UICD_NIVEL_ACCESO.Properties.DisplayMember = "DS_NOMBRE_PERFIL"
        Me.UICD_NIVEL_ACCESO.Properties.NullText = "Seleccione"
        Me.UICD_NIVEL_ACCESO.Properties.ValueMember = "ID"
        Me.UICD_NIVEL_ACCESO.Size = New System.Drawing.Size(172, 20)
        Me.UICD_NIVEL_ACCESO.TabIndex = 8
        '
        'GENPERFILBindingSource
        '
        Me.GENPERFILBindingSource.DataSource = GetType(IVASAE.GEN_PERFIL)
        '
        'UICD_ESTADO
        '
        Me.UICD_ESTADO.Location = New System.Drawing.Point(145, 209)
        Me.UICD_ESTADO.Name = "UICD_ESTADO"
        Me.UICD_ESTADO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, EditorButtonImageOptions1)})
        Me.UICD_ESTADO.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 56, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
        Me.UICD_ESTADO.Properties.DataSource = Me.ClasegenericaparesBindingSource
        Me.UICD_ESTADO.Properties.DisplayMember = "Descripcion"
        Me.UICD_ESTADO.Properties.NullText = ""
        Me.UICD_ESTADO.Properties.ReadOnly = true
        Me.UICD_ESTADO.Properties.ValueMember = "Codigo"
        Me.UICD_ESTADO.Size = New System.Drawing.Size(172, 20)
        Me.UICD_ESTADO.TabIndex = 9
        '
        'ClasegenericaparesBindingSource
        '
        Me.ClasegenericaparesBindingSource.DataSource = GetType(IVASAE.Utilidades.clasegenericapares)
        '
        'UIID
        '
        Me.UIID.Location = New System.Drawing.Point(145, 38)
        Me.UIID.Name = "UIID"
        Me.UIID.Properties.ReadOnly = true
        Me.UIID.Size = New System.Drawing.Size(52, 20)
        Me.UIID.TabIndex = 11
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(118, 41)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "ID"
        '
        'GENUSUARIOBindingSource
        '
        Me.GENUSUARIOBindingSource.DataSource = GetType(IVASAE.GEN_USUARIO)
        '
        'colID
        '
        Me.colID.Caption = "id"
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        Me.colID.Visible = true
        Me.colID.VisibleIndex = 0
        Me.colID.Width = 48
        '
        'colCD_LOGIN
        '
        Me.colCD_LOGIN.Caption = "Login"
        Me.colCD_LOGIN.FieldName = "CD_LOGIN"
        Me.colCD_LOGIN.Name = "colCD_LOGIN"
        Me.colCD_LOGIN.Visible = true
        Me.colCD_LOGIN.VisibleIndex = 1
        Me.colCD_LOGIN.Width = 161
        '
        'colCD_PASSWORD
        '
        Me.colCD_PASSWORD.FieldName = "CD_PASSWORD"
        Me.colCD_PASSWORD.Name = "colCD_PASSWORD"
        '
        'colDESC_NOMBRE_USUARIO
        '
        Me.colDESC_NOMBRE_USUARIO.Caption = "Nombre"
        Me.colDESC_NOMBRE_USUARIO.FieldName = "DESC_NOMBRE_USUARIO"
        Me.colDESC_NOMBRE_USUARIO.Name = "colDESC_NOMBRE_USUARIO"
        Me.colDESC_NOMBRE_USUARIO.Visible = true
        Me.colDESC_NOMBRE_USUARIO.VisibleIndex = 2
        Me.colDESC_NOMBRE_USUARIO.Width = 160
        '
        'colID_PERFIL
        '
        Me.colID_PERFIL.Caption = "Perfl"
        Me.colID_PERFIL.ColumnEdit = Me.UIGRID_ID_PERFIL
        Me.colID_PERFIL.FieldName = "ID_PERFIL"
        Me.colID_PERFIL.Name = "colID_PERFIL"
        Me.colID_PERFIL.Visible = true
        Me.colID_PERFIL.VisibleIndex = 3
        Me.colID_PERFIL.Width = 150
        '
        'UIGRID_ID_PERFIL
        '
        Me.UIGRID_ID_PERFIL.AutoHeight = false
        Me.UIGRID_ID_PERFIL.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UIGRID_ID_PERFIL.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DS_NOMBRE_PERFIL", "Perfil", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CD_NIVEL_ACCESO", "CD_NIVEL_ACCESO", 105, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FLG_NOTI_PROD", "FLG_NOTI_PROD", 93, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FLG_NOTI_PROD_CDI", "FLG_NOTI_PROD_CDI", 117, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)})
        Me.UIGRID_ID_PERFIL.DataSource = Me.GENPERFILBindingSource
        Me.UIGRID_ID_PERFIL.DisplayMember = "DS_NOMBRE_PERFIL"
        Me.UIGRID_ID_PERFIL.Name = "UIGRID_ID_PERFIL"
        Me.UIGRID_ID_PERFIL.ValueMember = "ID"
        '
        'colCD_ESTADO
        '
        Me.colCD_ESTADO.Caption = "Estado"
        Me.colCD_ESTADO.ColumnEdit = Me.UIGRID_CD_ESTADO
        Me.colCD_ESTADO.FieldName = "CD_ESTADO"
        Me.colCD_ESTADO.Name = "colCD_ESTADO"
        Me.colCD_ESTADO.Visible = true
        Me.colCD_ESTADO.VisibleIndex = 4
        '
        'UIGRID_CD_ESTADO
        '
        Me.UIGRID_CD_ESTADO.AutoHeight = false
        Me.UIGRID_CD_ESTADO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UIGRID_CD_ESTADO.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo", 56, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Estado", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
        Me.UIGRID_CD_ESTADO.DataSource = Me.ClasegenericaparesBindingSource
        Me.UIGRID_CD_ESTADO.DisplayMember = "Descripcion"
        Me.UIGRID_CD_ESTADO.Name = "UIGRID_CD_ESTADO"
        Me.UIGRID_CD_ESTADO.ValueMember = "Codigo"
        '
        'colGEN_PERFIL
        '
        Me.colGEN_PERFIL.FieldName = "GEN_PERFIL"
        Me.colGEN_PERFIL.Name = "colGEN_PERFIL"
        '
        'VGENUSUARIOBindingSource
        '
        Me.VGENUSUARIOBindingSource.DataSource = GetType(IVASAE.V_GEN_USUARIO)
        '
        'colCD_CORREO_E
        '
        Me.colCD_CORREO_E.Caption = "Correo electronico"
        Me.colCD_CORREO_E.FieldName = "CD_CORREO_E"
        Me.colCD_CORREO_E.Name = "colCD_CORREO_E"
        Me.colCD_CORREO_E.Visible = true
        Me.colCD_CORREO_E.VisibleIndex = 5
        Me.colCD_CORREO_E.Width = 108
        '
        'UICD_CORREO_E
        '
        Me.UICD_CORREO_E.Location = New System.Drawing.Point(145, 250)
        Me.UICD_CORREO_E.Name = "UICD_CORREO_E"
        Me.UICD_CORREO_E.Size = New System.Drawing.Size(323, 20)
        Me.UICD_CORREO_E.TabIndex = 13
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(92, 257)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "Correo e"
        '
        'GENPERFILANDROIDBindingSource
        '
        Me.GENPERFILANDROIDBindingSource.DataSource = GetType(IVASAE.Utilidades.clasegenericapares)
        '
        'Fusuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 15!)
        Me.ClientSize = New System.Drawing.Size(965, 560)
        Me.Name = "Fusuarios"
        Me.Text = "Usuarios"
        CType(Me.UITABCONTROL,System.ComponentModel.ISupportInitialize).EndInit
        Me.UITABCONTROL.ResumeLayout(false)
        CType(Me.UIGRIDCONTROL,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UIPANELDATOS,System.ComponentModel.ISupportInitialize).EndInit
        Me.UIPANELDATOS.ResumeLayout(false)
        Me.UIPANELDATOS.PerformLayout
        CType(Me.UIPANELSTATUS,System.ComponentModel.ISupportInitialize).EndInit
        Me.UIPANELSTATUS.ResumeLayout(false)
        Me.UITABPAG_GEN.ResumeLayout(false)
        Me.UITABPAG_DET.ResumeLayout(false)
        CType(Me.UIGRIDVIEW,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UIGROUP_MAIN,System.ComponentModel.ISupportInitialize).EndInit
        Me.UIGROUP_MAIN.ResumeLayout(false)
        CType(Me.UICD_LOGIN.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UICD_PASSWORD.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UIDESC_NOMBRE_USUARIO.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UICD_NIVEL_ACCESO.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GENPERFILBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UICD_ESTADO.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ClasegenericaparesBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UIID.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GENUSUARIOBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UIGRID_ID_PERFIL,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UIGRID_CD_ESTADO,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.VGENUSUARIOBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.UICD_CORREO_E.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GENPERFILANDROIDBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UIID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents UICD_ESTADO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents UICD_NIVEL_ACCESO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents UIDESC_NOMBRE_USUARIO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UICD_PASSWORD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UICD_LOGIN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GENUSUARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCD_LOGIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCD_PASSWORD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESC_NOMBRE_USUARIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID_PERFIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCD_ESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGEN_PERFIL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UIGRID_ID_PERFIL As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GENPERFILBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UIGRID_CD_ESTADO As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ClasegenericaparesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VGENUSUARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colCD_CORREO_E As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GENPERFILANDROIDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UICD_CORREO_E As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl

End Class
