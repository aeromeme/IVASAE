﻿Imports IVASAE.Utilidades
Imports System.Windows.Forms
Public Class MasterFormTab
    Public Sub New(ds As DataSistema)
        MyBase.New(ds)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New()
        MyBase.New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub MasterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refrescar()
    End Sub
    Public Overridable Sub Refrescar()

    End Sub

    Private Sub UIGRIDVIEW_DoubleClick(sender As Object, e As EventArgs) Handles UIGRIDVIEW.DoubleClick
        UITABCONTROL.SelectedTabPageIndex = 0
    End Sub

    Private Sub ExportarAExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarAExcelToolStripMenuItem.Click
        Try
            If UIDIALOGO_GUARDAREXCEL.ShowDialog = Windows.Forms.DialogResult.OK Then
                UIGRIDVIEW.ExportToXlsx(UIDIALOGO_GUARDAREXCEL.FileName)
            End If
        Catch ex As Exception
            MetodosForm.MensajeErrorDefault()
        End Try
    End Sub
End Class
