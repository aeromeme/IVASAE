Public Class MasterPrintXRForm
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
End Class
