Public Class DialogoCons
    Public _datasistema As DataSistema
    Public Sub New(ds As DataSistema)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        _datasistema = ds
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        UIGROUP_CONTAINER.Text = ds.NombreOpcion
        Me.Text = ds.NombreVentana

    End Sub
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
End Class