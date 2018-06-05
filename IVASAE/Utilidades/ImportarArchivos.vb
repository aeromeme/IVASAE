
Imports DevExpress.LookAndFeel
Imports System.IO 'esta libreria nos va a servir para poder activar el commandialog
Imports DevExpress.XtraEditors
Imports DevExpress.XtraWaitForm
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports DevExpress.XtraGrid
Imports IVASAE.Utilidades
Imports DevExpress.XtraGrid.Views.Grid

Imports Microsoft.Office.Interop
Imports System.Data
Imports System
Imports Microsoft.VisualBasic

Public Class ImportarArchivos

    Sub importar_Excel(ByVal tabla As GridControl)
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""

        With myFileDialog
            .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*"
            .Title = "Abrir Archivo"
            .ShowDialog()
        End With
        If myFileDialog.FileName.ToString <> "" Then
            Dim ExcelFile As String = myFileDialog.FileName.ToString

            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim conn As OleDbConnection

            xSheet = InputBox("Digite el nombre de la Hoja que desea importar", "Complete")
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ExcelFile + ";Extended Properties=Excel 12.0;")

            Try
                da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)

                conn.Open()
                da.Fill(ds, "MyData")
                dt = ds.Tables("MyData")
                tabla.DataSource = ds
                tabla.DataMember = "MyData"
            Catch ex As Exception
                MsgBox("Inserte un nombre valido de la Hoja que desea importar", MsgBoxStyle.Information, "Informacion")
            Finally
                conn.Close()
            End Try
        End If
        MsgBox("Se ha cargado la importacion correctamente", MsgBoxStyle.Information, "Importado con exito")
    End Sub



    'Public Function ImportExcel(ruta As String) As Data.DataTable
    '    Try
    '        Dim stConexion As String = ("Provider=Microsoft.ACE.OLEDB.12.0;" & ("Data Source=" & (ruta & ";Extended Properties=""Excel 12.0;Xml;HDR=YES;IMEX=2"";")))
    '        Dim cnConex As New OleDbConnection(stConexion)
    '        Dim Cmd As New OleDbCommand("Select * From [Hoja1$]")
    '        Dim Ds As New DataSet
    '        Dim Da As New OleDbDataAdapter
    '        Dim Dt As New DataTable

    '        cnConex.Open()
    '        Cmd.Connection = cnConex
    '        Da.SelectCommand = Cmd
    '        Da.Fill(Ds)
    '        Dt = Ds.Tables(0)
    '        Return Dt
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    '    End Try
    'End Function

    '********************************************************************************

    'Function Excel(ruta As String, DataGrid As DevExpress.XtraGrid.GridControl)
    '    Try
    '        Dim DT As DataTable
    '        Dim MyConnection As System.Data.OleDb.OleDbConnection
    '        Dim dataSet As System.Data.DataSet
    '        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
    '        'Dim ruta As String = "C:\\Users\\jsandoval\\Desktop\\ejemplo_1.xls"

    '        MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta + ";Extended Properties=Excel 12.0;")
    '        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Hoja1$]", MyConnection)

    '        dataSet = New System.Data.DataSet
    '        'MyCommand.Fill(dataSet)
    '        'DT = dataSet.Tables(0)
    '        DT = dataSet.Tables(0)

    '        MyConnection.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '    End Try
    'End Function



    'Function ValidarDatos(cuenta As String, referencia As String, pNombre As String, sNombre As String, pApellido As String, SApellido As String) As String

    '    Dim validar As String = False


    'End Function

    Public _datasistema As DataSistema

    

End Class