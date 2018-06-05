Imports System.IO
Namespace Utilidades
    Public Class subirArchivoFTP
        ''' <summary>
        ''' Methods to upload file to FTP Server
        ''' </summary>
        ''' <param name="_FileName">local source file name</param>
        ''' <param name="_UploadPath">Upload FTP path including Host name</param>
        ''' <param name="_FTPUser">FTP login username</param>
        ''' <param name="_FTPPass">FTP login password</param>

        Public Shared Sub UploadFile(ByVal _FileName As String, ByVal _UploadPath As String, ByVal _FTPUser As String, ByVal _FTPPass As String)
            Dim _FileInfo As New System.IO.FileInfo(_FileName)

            ' Create FtpWebRequest object from the Uri provided
            Dim _FtpWebRequest As System.Net.FtpWebRequest = CType(System.Net.FtpWebRequest.Create(New Uri(_UploadPath)), System.Net.FtpWebRequest)

            ' Provide the WebPermission Credintials
            _FtpWebRequest.Credentials = New System.Net.NetworkCredential(_FTPUser, _FTPPass)

            ' By default KeepAlive is true, where the control connection is not closed
            ' after a command is executed.
            _FtpWebRequest.KeepAlive = False

            ' set timeout for 20 seconds
            _FtpWebRequest.Timeout = 20000

            ' Specify the command to be executed.
            _FtpWebRequest.Method = System.Net.WebRequestMethods.Ftp.UploadFile

            ' Specify the data transfer type.
            _FtpWebRequest.UseBinary = True

            ' Notify the server about the size of the uploaded file
            _FtpWebRequest.ContentLength = _FileInfo.Length






            ' The buffer size is set to 2kb
            Dim buffLength As Integer = 2048
            Dim buff(buffLength - 1) As Byte

            ' Opens a file stream (System.IO.FileStream) to read the file to be uploaded
            Dim _FileStream As System.IO.FileStream = _FileInfo.OpenRead()

            Try
                ' Stream to which the file to be upload is written
                Dim _Stream As System.IO.Stream = _FtpWebRequest.GetRequestStream()

                ' Read from the file stream 2kb at a time
                Dim contentLen As Integer = _FileStream.Read(buff, 0, buffLength)

                ' Till Stream content ends
                Do While contentLen <> 0
                    ' Write Content from the file stream to the FTP Upload Stream
                    _Stream.Write(buff, 0, contentLen)
                    contentLen = _FileStream.Read(buff, 0, buffLength)
                Loop

                ' Close the file stream and the Request Stream
                _Stream.Close()
                _Stream.Dispose()
                _FileStream.Close()
                _FileStream.Dispose()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Public Shared Sub DescargarArchivo(nombreArchivo As String, ByVal _UploadPath As String, ByVal _FTPUser As String, ByVal _FTPPass As String)


            ' Create FtpWebRequest object from the Uri provided
            Dim _FtpWebRequest As System.Net.FtpWebRequest = CType(System.Net.FtpWebRequest.Create(New Uri(_UploadPath)), System.Net.FtpWebRequest)

            ' Provide the WebPermission Credintials
            _FtpWebRequest.Credentials = New System.Net.NetworkCredential(_FTPUser, _FTPPass)

            ' By default KeepAlive is true, where the control connection is not closed
            ' after a command is executed.
            _FtpWebRequest.KeepAlive = False

            ' set timeout for 20 seconds
            _FtpWebRequest.Timeout = 20000

            ' Specify the command to be executed.
            _FtpWebRequest.Method = System.Net.WebRequestMethods.Ftp.DownloadFile

            ' Specify the data transfer type.
            _FtpWebRequest.UseBinary = True

            Dim ftresp As System.Net.FtpWebResponse = _FtpWebRequest.GetResponse()
            Dim responsestream As Stream = ftresp.GetResponseStream
            ' Dim tempfilepath As String = Path.GetTempPath + nombreArchivo
            Dim tempfilepath As String = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + nombreArchivo
            Dim _fileStream As FileStream = File.Create(tempfilepath, responsestream.Length)
            Dim buffer(responsestream.Length) As Byte
            responsestream.Read(buffer, 0, buffer.Length)
            _fileStream.Write(buffer, 0, buffer.Length)
            _fileStream.Close()

            ' Notify the server about the size of the uploaded file
            '_FtpWebRequest.ContentLength = _FileInfo.Length
            '// Get the object used to communicate with the server.
            'FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://www.contoso.com/test.htm");
            'request.Method = WebRequestMethods.Ftp.DownloadFile;

            '// This example assumes the FTP site uses anonymous logon.
            'request.Credentials = new NetworkCredential ("anonymous","janeDoe@contoso.com");

            'FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            'Stream responseStream = response.GetResponseStream();
            'StreamReader reader = new StreamReader(responseStream);
            'Console.WriteLine(reader.ReadToEnd());

        End Sub


    End Class



End Namespace


