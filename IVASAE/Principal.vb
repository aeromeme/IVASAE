Imports System.Windows.Forms
Imports DevExpress.XtraBars.Helpers
Imports IVASAE.Utilidades
Imports DevExpress.XtraBars.Alerter

Public Class Principal
    Public _datasistema As DataSistema

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True
        DevExpress.UserSkins.BonusSkins.Register()
        SkinHelper.InitSkinGallery(RibbonGalleryBarItem1, True)
        'UserLookAndFeel.Default.SkinName = My.Settings.NOMBRE_SKIN
        'SkinHelper.InitSkinPopupMenu(popupMenu1)
        Me.Enabled = False
        UI_MN_SISTEMAS.Visible = False
        'Call the method that changes the background color.
        'SetBackGroundColorOfMdiForm()
        '' InitializeTimer()
        ' Login.ShowDialog()
        Dim ProjAndForm = "IMACANET.Login"  '' String Of Your Project And Form Name
        Dim objType As Type = Type.[GetType](ProjAndForm) '' Get Type Of your string
        Dim objForm As Form = DirectCast(Activator.CreateInstance(objType), Form) '' Convert Type to Control and now you can use this Control
        objForm.ShowDialog()

    End Sub
    Public Function cargarsistema() As Boolean
        If _datasistema.ObtenerDatosUsuario() And _datasistema.ObtenerConfiguracion() Then
            UICLK_NOTIFICACIONES.Enabled = True
            Dim var_menus As Generic.List(Of V_GEN_MENU_PERFIL)
            Dim varopci_menu As Generic.List(Of V_GEN_MENU_PERFIL_AUX)
            Dim listaimagen As List(Of cImagen) = MetodosForm.listadoImagen
            var_menus = (From U In _datasistema.ContextoGeneral.V_GEN_MENU_PERFIL
                        Select U Where U.ID_PERFIL = _datasistema.perfil).ToList

            For Each menu_item As V_GEN_MENU_PERFIL In var_menus
                Dim menu As DevExpress.XtraNavBar.NavBarGroup = UINB_MENU.Groups.Add()
                menu.Caption = menu_item.COD_MENU

                menu.Expanded = False
                varopci_menu = (From U In _datasistema.ContextoGeneral.V_GEN_MENU_PERFIL_AUX
                          Select U Where U.ID_MENU = menu_item.ID And U.ID_PERFIL = _datasistema.perfil).ToList
                For Each item As V_GEN_MENU_PERFIL_AUX In varopci_menu
                    Dim opcion As DevExpress.XtraNavBar.NavBarItemLink = menu.AddItem()
                    opcion.Item.Caption = item.DS_NOMBRE_CORTO
                    opcion.Item.Tag = item
                    opcion.Item.SmallImage = MetodosForm.EncontrarImagen(item.CD_IMAGEN, listaimagen)
                    AddHandler opcion.Item.LinkClicked, AddressOf NavBarItemClicked
                Next
            Next
            If _datasistema.nvlAcceso = "A" Then
                UI_MN_SISTEMAS.Visible = True
            End If
        End If
        UITXTNOMBRE_USUARIO.Caption = _datasistema.nomUsuario
        UITXTDS_PERFIL.Caption = _datasistema.perfilUsuario.DS_NOMBRE_PERFIL

        uids_anio.DataSource = MetodosForm.listaAnios
        uids_mes.DataSource = MetodosForm.listaMeses
        ui_rbn_anio.EditValue = Now.Year
        ui_rbn_nmmes.EditValue = Now.Month
        uifechaparam.EditValue = Now
        uifecharangoini.EditValue = New Date(Now.Year, Now.Month, 1)
        uifecharangofin.EditValue = Now

        Return True
    End Function

    Private Sub NavBarItemClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs)
        ' your code here
       

        Dim a As V_GEN_MENU_PERFIL_AUX = e.Link.Item.Tag
        _datasistema.NombreOpcion = a.DS_NOMBRE_FORM
        _datasistema.NombreVentana = a.DS_NOMBRE_CORTO
        _datasistema.nombreFormulario = a.COD_FORM

        Dim flgcrear As Boolean = True

        For Each item As DevExpress.XtraTabbedMdi.XtraMdiTabPage In Me.XTRATABCONTROL.Pages
            If item.MdiChild.Name = a.COD_FORM Then
                flgcrear = False
                Me.XTRATABCONTROL.SelectedPage = item

            End If
        Next

        If flgcrear Then
            Dim path As String = System.Reflection.Assembly.GetExecutingAssembly().Location
            Dim ass As Reflection.Assembly = Reflection.Assembly.LoadFrom(path)
            Dim ProjAndForm = "IMACANET." + a.COD_FORM
            Dim FormInstanceType = ass.GetType(ProjAndForm)
            Dim objForm = CType(Activator.CreateInstance(FormInstanceType, New Object() {_datasistema}), Form)
            objForm.MdiParent = Me
            objForm.Show()
        End If
        
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="modo">1: TODAS LAS FUNCIONES, 2: SOLO CONSULTA E IMPRIMIR 3: SOLO CONSULTA 4: N/E 5:SOLO GUARDAR Y CONSULTAR</param>
    ''' <remarks></remarks>
    Public Sub actualizarInterfaz(modo As Integer)
        Select Case modo
            Case 1
                'UI_RBN_ELIMINAR.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'UI_RBN_GUARDAR.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'UI_RBN_LIMPIAR.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                'UI_RBN_IMPRIMIR.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                UI_RBN_ELIMINAR.Enabled = True
                UI_RBN_GUARDAR.Enabled = True
                UI_RBN_LIMPIAR.Enabled = True
                UI_RBN_IMPRIMIR.Enabled = True
                UI_RBN_CONSULTAR.Enabled = True
                uirbnparametros.Visible = False
                uirbnfechaparam.Visible = False
                uirbnparamfecharango.Visible = False

            Case 2

                'UI_RBN_ELIMINAR.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                'UI_RBN_GUARDAR.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                'UI_RBN_LIMPIAR.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                UI_RBN_ELIMINAR.Enabled = False
                UI_RBN_GUARDAR.Enabled = False
                UI_RBN_LIMPIAR.Enabled = False

            Case 3

                'UI_RBN_ELIMINAR.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                'UI_RBN_GUARDAR.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                'UI_RBN_LIMPIAR.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                'UI_RBN_IMPRIMIR.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                UI_RBN_ELIMINAR.Enabled = False
                UI_RBN_GUARDAR.Enabled = False
                UI_RBN_LIMPIAR.Enabled = False
                UI_RBN_IMPRIMIR.Enabled = False
            Case 5

                'UI_RBN_ELIMINAR.Visibility = DevExpress.XtraBars.BarItemVisibility.Never             
                'UI_RBN_LIMPIAR.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                'UI_RBN_IMPRIMIR.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                UI_RBN_ELIMINAR.Enabled = False
                UI_RBN_LIMPIAR.Enabled = False
                UI_RBN_IMPRIMIR.Enabled = False
            Case 6
                uirbnparametros.Visible = True
                asignarperiodoaux()
            Case 7
                uirbnfechaparam.Visible = True
                asignarfechaaux()
            Case 8
                uirbnparamfecharango.Visible = True
                asignarrangofechaaux()
        End Select
    End Sub


#Region "Opciones CRUD"
    Public Sub MostrarEspere(flgmostrar As Boolean, Optional titulo As String = "Espere", Optional descripcion As String = "Procesando...")
        Try
            If flgmostrar Then
                UIVENTANA_ESPERA.ShowWaitForm()
                UIVENTANA_ESPERA.SetWaitFormCaption(titulo)
                UIVENTANA_ESPERA.SetWaitFormDescription(descripcion)
            Else
                UIVENTANA_ESPERA.CloseWaitForm()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub marcarprogreso()
        Try
            'Dim f As MasterFormTab = Me.ActiveMdiChild
            'If (f.UIBARRAPROGRESO.Enabled = True) Then
            '    f.UIBARRAPROGRESO.Enabled = False

            'Else
            '    f.UIBARRAPROGRESO.Enabled = True

            'End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub UI_RBN_CONSULTAR_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UI_RBN_CONSULTAR.ItemClick
        If Not Me.ActiveMdiChild Is Nothing Then
            marcarprogreso()
            MostrarEspere(True)
            Dim f As Utilidades.InterfazForms = Me.ActiveMdiChild
            f.Consultar()
            MostrarEspere(False)
            marcarprogreso()
        End If

    End Sub
    'BOTON QUE SE OCUPABA PARA INSERTAR DEBE SER REMPLAZADO POR GUARDAR
    Private Sub UI_RBN_AGREGAR_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        If Not Me.ActiveMdiChild Is Nothing Then
            marcarprogreso()
            If MetodosForm.Preguntar("Esta seguro de agregar un nuevo registro", "Insertar") Then
                Dim f As Object = Me.ActiveMdiChild
                MostrarEspere(True)
                f.Insertar()
                MostrarEspere(False)
            End If
            marcarprogreso()
        End If
    End Sub

    Private Sub UI_RBN_GUARDAR_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UI_RBN_GUARDAR.ItemClick
        If Not Me.ActiveMdiChild Is Nothing Then
            marcarprogreso()
            If MetodosForm.Preguntar("Esta seguro de guardar los cambios", "Guardar") Then
                Dim f As Object = Me.ActiveMdiChild
                MostrarEspere(True)
                f.Modificar()
                MostrarEspere(False)
            End If
            marcarprogreso()
        End If
    End Sub

    Private Sub UI_RBN_ELIMINAR_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UI_RBN_ELIMINAR.ItemClick
        If Not Me.ActiveMdiChild Is Nothing Then
            marcarprogreso()
            If MetodosForm.Preguntar("Esta seguro de eliminar el registro", "Eliminar") Then
                Dim f As Object = Me.ActiveMdiChild
                MostrarEspere(True)
                f.Eliminar()
                MostrarEspere(False)
            End If
            marcarprogreso()
        End If
    End Sub

    Private Sub UI_RBN_LIMPIAR_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UI_RBN_LIMPIAR.ItemClick
        If Not Me.ActiveMdiChild Is Nothing Then
            marcarprogreso()
            Dim f As Object = Me.ActiveMdiChild
            MostrarEspere(True)
            f.Limpiar()
            MostrarEspere(False)
            marcarprogreso()
        End If
    End Sub

    Private Sub UI_RBN_IMPRIMIR_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UI_RBN_IMPRIMIR.ItemClick
        If Not Me.ActiveMdiChild Is Nothing Then
            marcarprogreso()
            Dim f As Object = Me.ActiveMdiChild
            MostrarEspere(True)
            f.Imprimir()
            MostrarEspere(False)
            marcarprogreso()
        End If
    End Sub
    Private Sub UI_RBN_CERRAR_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UI_RBN_CERRAR.ItemClick
        If Not Me.ActiveMdiChild Is Nothing Then
            Dim f As Object = Me.ActiveMdiChild
            f.Close()
        End If
    End Sub
    Private Sub UI_RBN_SALIRSIS_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UI_RBN_SALIRSIS.ItemClick
        If MetodosForm.Preguntar("Esta seguro que desea salir del sistema", "Sistema") Then
            Me.Close()
        End If
    End Sub
#End Region

#Region "OPCIONES INTERFAZ"
    Private Sub UI_RBN_AMPLIAR_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UI_RBN_AMPLIAR.ItemClick
        If UINB_MENU.Visible Then
            UINB_MENU.Hide()
        Else
            UINB_MENU.Show()
        End If
    End Sub


    Private Sub UI_RBN_ACERCA_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UI_RBN_ACERCA.ItemClick
        Dim acerca As String
        acerca = "IMPLEMENTOS AGRICOLAS CENTROAMERICANOS" + vbNewLine + vbNewLine + "IMACANET DESKTOP " + vbNewLine + vbNewLine + "Sistema desarrollado por el departamento de informatica 2015"
        Dim f As New FormDialogoTexto(acerca)
        f.ShowDialog()
    End Sub

    Private Sub UI_RBN_AYUDA_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UI_RBN_AYUDA.ItemClick
        Dim ayuda As String
        ayuda = "IMPLEMENTOS AGRICOLAS CENTROAMERICANOS" + vbNewLine + vbNewLine + "IMACANET DESKTOP " + vbNewLine + vbNewLine + " La finalidad de este sistema es dar soporte a los distintos departamentos, en su fase inicial da soporte al Maestro de barras. " + vbNewLine + vbNewLine + "Para soporte tecnico" + vbNewLine + "contacte al departamento de informatica extension 252"
        Dim f As New FormDialogoTexto(ayuda)
        f.ShowDialog()
    End Sub

    Private Sub UI_RBN_CAMBIARPASS_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles UI_RBN_CAMBIARPASS.ItemClick
        Dim f As New FcambiarPwd(_datasistema)
        f.ShowDialog()
    End Sub
#End Region

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'My.Settings.NOMBRE_SKIN = UserLookAndFeel.Default.SkinName
        My.Settings.Save()
    End Sub

#Region "OPCIONES ADMIN"
    Private Sub uinvmenu_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles uinvmenu.LinkClicked
        _datasistema.NombreVentana = "Menu"
        _datasistema.NombreOpcion = "Menu"
        Dim f As New FORM_MENU(_datasistema)
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub uinvformularios_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles uinvformularios.LinkClicked
        _datasistema.NombreVentana = "Formulario"
        _datasistema.NombreOpcion = "Formulario"
        Dim f As New FORM_FORM(_datasistema)
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub uinvperfil_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles uinvperfil.LinkClicked
        _datasistema.NombreVentana = "Perfil"
        _datasistema.NombreOpcion = "Perfil"
        Dim f As New FORM_PERF(_datasistema)
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub uinvusuarios_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles uinvusuarios.LinkClicked
        _datasistema.NombreVentana = "Usuarios"
        _datasistema.NombreOpcion = "Usuarios"
        Dim f As New Fusuarios(_datasistema)
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub uinvconfig_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles uinvconfig.LinkClicked
        '_datasistema.NombreVentana = "Configuracion"
        '_datasistema.NombreOpcion = "Configuracion"
        'Dim f As New Fconfig(_datasistema)
        'f.MdiParent = Me
        'f.Show()
    End Sub

    Private Sub uinvopci_menu_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles uinvopci_menu.LinkClicked
        _datasistema.NombreVentana = "Opciones menu"
        _datasistema.NombreOpcion = "Opciones menu"
        Dim f As New FORM_OPCI(_datasistema)
        f.MdiParent = Me
        f.Show()
    End Sub


    Private Sub uinvperf_andr_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles uinvperf_andr.LinkClicked
        '_datasistema.NombreVentana = "Perfil android"
        '_datasistema.NombreOpcion = "Perfil android"
        'Dim f As New FORM_PERF_ANDR(_datasistema)
        'f.MdiParent = Me
        'f.Show()
    End Sub
    Private Sub uinbmodulos_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles uinbmodulos.LinkClicked
        _datasistema.NombreVentana = "Modulos"
        _datasistema.NombreOpcion = "Modulos"
        Dim f As New FORM_MODULO(_datasistema)
        f.MdiParent = Me
        f.Show()
    End Sub
#End Region


#Region "Notificaciones"
    Private Sub UICLK_NOTIFICACIONES_Tick(sender As Object, e As EventArgs) Handles UICLK_NOTIFICACIONES.Tick
        Notificar()
    End Sub
    Sub Notificar()
        'If _datasistema.perfilUsuario.FLG_NOTI_PROD = CChar("S") Then
        '    _datasistema.ConectarIngrProd()
        '    If (From u In _datasistema.ContextoIngrProd.V_MOD_ING_PRO_CONTROLDETOMAS Select u Where u.CD_STATUS = "A").Count > 0 Then
        '        mostrarNoti("Existen tomas pendientes de procesar para ingresar a bodega")
        '    End If
        'End If
        'If _datasistema.perfilUsuario.FLG_NOTI_PROD_CDI = CChar("S") Then
        '    If (From U In _datasistema.ContextoIngrProd.V_MOD_ING_PRO_CONTROLDETOMAS Select U Where U.CD_STATUS_PLANTA = "A" And U.CD_STATUS_CDI = "I" And U.CD_STATUS <> "N").Count > 0 Then
        '        mostrarNoti("Existen tomas pendientes de realizar por CDI")
        '    End If
        'End If

    End Sub
    Public Sub mostrarNoti(msj As String)
        Dim info As AlertInfo = New AlertInfo("Notificacion IMACANET", msj)
        UINOTI_BALLON.Show(Me, info)
    End Sub
    Private Sub uibar_btn_notificacion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles uibar_btn_notificacion.ItemClick
        Notificar()
    End Sub
#End Region




    Private Sub uinvbar_pruebas_LinkClicked(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles uinvbar_pruebas.LinkClicked
        '_datasistema.NombreVentana = "Pruebas"
        '_datasistema.NombreOpcion = "Pruebas"
        'Dim f As New frmpruebas(_datasistema)
        'f.MdiParent = Me
        'f.Show()
    End Sub

    Private Sub asignarperiodo()
        If Not Me.ActiveMdiChild Is Nothing Then
            Dim f As Object = Me.ActiveMdiChild
            f.nmanio = ui_rbn_anio.EditValue
            f.nmmes = ui_rbn_nmmes.EditValue
            'MostrarEspere(True)
            f.Consultar()
            'MostrarEspere(False)
        End If
    End Sub
    Private Sub asignarperiodoaux()
        If Not Me.ActiveMdiChild Is Nothing Then
            Dim f As Object = Me.ActiveMdiChild

            If (f.nmanio <> ui_rbn_anio.EditValue Or f.nmmes <> ui_rbn_nmmes.EditValue) Then
                f.nmanio = ui_rbn_anio.EditValue
                f.nmmes = ui_rbn_nmmes.EditValue
                'MostrarEspere(True)
                f.Consultar()
                'MostrarEspere(False)
            End If
            
            
        End If
    End Sub
    Private Sub asignarfecha()
        If Not Me.ActiveMdiChild Is Nothing Then
            Dim f As Object = Me.ActiveMdiChild
            f.fecha = uifechaparam.EditValue
            'MostrarEspere(True)
            f.Consultar()
            'MostrarEspere(False)
        End If
    End Sub
    Private Sub asignarfechaaux()
        If Not Me.ActiveMdiChild Is Nothing Then
            Dim f As Object = Me.ActiveMdiChild

            If (f.fecha <> uifechaparam.EditValue) Then
                f.fecha = uifechaparam.EditValue
                'MostrarEspere(True)
                f.Consultar()
                'MostrarEspere(False)
            End If

            
        End If
    End Sub
    Private Sub asignarrangofecha()
        If Not Me.ActiveMdiChild Is Nothing Then
            Dim f As Object = Me.ActiveMdiChild
            If uifecharangoini.EditValue > uifecharangofin.EditValue Then
                Dim dateaux As DateTime = uifecharangoini.EditValue
                uifecharangoini.EditValue = uifecharangofin.EditValue
                uifecharangofin.EditValue = dateaux
            End If

            f.fechaini = uifecharangoini.EditValue
            f.fechafin = uifecharangofin.EditValue
            'MostrarEspere(True)
            f.Consultar()
            'MostrarEspere(False)

        End If
    End Sub
    Private Sub asignarrangofechaaux()
        If Not Me.ActiveMdiChild Is Nothing Then
            Dim f As Object = Me.ActiveMdiChild
            If uifecharangoini.EditValue > uifecharangofin.EditValue Then
                Dim dateaux As DateTime = uifecharangoini.EditValue
                uifecharangoini.EditValue = uifecharangofin.EditValue
                uifecharangofin.EditValue = dateaux
            End If
            If (f.fechaini <> uifecharangoini.EditValue Or f.fechafin <> uifecharangofin.EditValue) Then
                f.fechaini = uifecharangoini.EditValue
                f.fechafin = uifecharangofin.EditValue
                'MostrarEspere(True)
                f.Consultar()
                'MostrarEspere(False)
            End If


        End If
    End Sub
    Private Sub ui_rbn_nmmes_EditValueChanged(sender As Object, e As EventArgs) Handles ui_rbn_nmmes.EditValueChanged
        asignarperiodo()
    End Sub

    Private Sub ui_rbn_anio_EditValueChanged(sender As Object, e As EventArgs) Handles ui_rbn_anio.EditValueChanged
        asignarperiodo()
    End Sub

  
    Private Sub uifechaparam_EditValueChanged(sender As Object, e As EventArgs) Handles uifechaparam.EditValueChanged
        asignarfecha()

    End Sub
    
    Private Sub uifecharangoini_EditValueChanged(sender As Object, e As EventArgs) Handles uifecharangoini.EditValueChanged
        asignarrangofecha()
    End Sub

    Private Sub uifecharangofin_EditValueChanged(sender As Object, e As EventArgs) Handles uifecharangofin.EditValueChanged
        asignarrangofecha()
    End Sub

End Class

