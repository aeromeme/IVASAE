Public Class FORM_IVA_PROV
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub New(ds As DataSistema)
        MyBase.New(ds)
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        MyBase.flgVenta = False
        MyBase.UIBR_IMPORTAR.Caption = "Importar proveedores SAE"
    End Sub
End Class
