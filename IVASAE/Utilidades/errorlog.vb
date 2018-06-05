Namespace Utilidades
    Public Class Errorlog
        Dim _privateIp As String
        Function MyprivateIp() As String

            _privateIp = String.Empty
            Try
                ' ReSharper disable VBWarnings::BC40008
                '_privateIp = Net.Dns.Resolve(My.Computer.Name).AddressList(0).ToString
                _privateIp = Net.Dns.GetHostEntry(My.Computer.Name).AddressList(0).ToString
                ' ReSharper restore VBWarnings::BC40008
            Catch ex As Exception
                _privateIp = "(No Disponible)"
            End Try
            Return _privateIp
        End Function
        Dim _dir As String
        Public Sub Send_Result()

            Try


                Const fic As String = "log_sysreport02.txt"
                ' Dim texto As String = "Pablito tenía una moto con un pito."



                _dir = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\log_sysreport02.txt"

                Dim programa = Now.ToShortDateString & "   " & Now.ToLongTimeString & "...Programa sysreport02..." & "   " & Now.ToShortDateString & "   " & MyprivateIp()

                Dim inicioDelsistema = Now.ToShortDateString & "   " & Now.ToLongTimeString & "...Inicio del sistema" & "   " & MyprivateIp()

                Dim connec = Now.ToShortDateString & "   " & Now.ToLongTimeString & "...Conexion al Servidor" & "   " & MyprivateIp()


                Dim sendto = Now.ToShortDateString & "   " & Now.ToLongTimeString & " Archivo enviado a: " & "   " & MyprivateIp()


                Dim writeInfo As String = Chr(13) & Chr(10) & programa & vbNewLine & inicioDelsistema & vbNewLine & connec & vbNewLine & sendto


                My.Computer.FileSystem.WriteAllText(_dir, writeInfo, True)

                Dim sw As New IO.StreamWriter(fic, True)

                sw.WriteLine(writeInfo)

                sw.Close()

            Catch ex As Exception
                Const fic1 As String = "log_error_sysreport02"

                Dim sw As New IO.StreamWriter(fic1, True)

                sw.WriteLine(ex.Message & vbNewLine & ex.StackTrace)

                sw.Close()

                My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\log_error_sysreport02", ex.Message & vbNewLine & ex.StackTrace, True)

            End Try

        End Sub
        ' ReSharper disable InconsistentNaming
        Dim Dir As String
        ' ReSharper restore InconsistentNaming
        Dim _msjError As String
        Public Sub Send_Result_generales(msjerror As String)

            Try

                Const fic As String = "log_sysreport02.txt"


                Dir = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\log_sysreport02.txt"

                'Dim Programa = Now.ToShortDateString & "...Programa CC..." & Now.ToShortDateString

                'Dim Inicio_Delsistema = Now.ToShortDateString & Now.ToLongTimeString & "...Inicio del sistema"

                'Dim Connec = Now.ToShortDateString & Now.ToLongTimeString & "...Conexion al Servidor"


                _msjError = Now.ToShortDateString & "   " & Now.ToLongTimeString & "   " & msjerror & "....Sistema" & "   " & MyprivateIp()

                Dim sendto = Now.ToShortDateString & "   " & Now.ToLongTimeString & " Archivo enviado a:   " & MyprivateIp()


                Dim writeInfo As String = Chr(13) & Chr(10) & _msjError & vbNewLine & sendto


                My.Computer.FileSystem.WriteAllText(Dir, writeInfo, True)

                Dim sw As New IO.StreamWriter(fic, True)

                sw.WriteLine(writeInfo)

                sw.Close()

            Catch ex As Exception

                Const fic1 As String = "log_error_sysreport02"

                Dim sw As New IO.StreamWriter(fic1, True)

                sw.WriteLine(ex.Message & vbNewLine & ex.StackTrace)

                sw.Close()

                My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\log_error_sysreport02", ex.Message & vbNewLine & ex.StackTrace, True)

            End Try

        End Sub
    End Class
End Namespace