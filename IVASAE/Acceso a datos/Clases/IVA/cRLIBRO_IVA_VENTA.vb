Namespace clasesReporte
    Public Class cRLIBRO_IVA_VENTA
        Private _nm_ventas_internas_gravadas_contrib As Decimal
        Private _nm_ventas_internas_gravadas_consumidores As Decimal
        Private _nm_ventas_internas_exentas_contrib As Decimal
        Private _nm_ventas_internas_exentas_consumidores As Decimal
        Private _nm_exportaciones As Decimal
        Private _nm_iva_interno_contrib As Decimal
        Private _nm_iva_interno_consumidores As Decimal

        Public Property nm_ventas_internas_gravadas_contrib As Decimal
            Set(value As Decimal)
                _nm_ventas_internas_gravadas_contrib = value
            End Set
            Get
                Return _nm_ventas_internas_gravadas_contrib
            End Get
        End Property
        Public Property nm_ventas_internas_gravadas_consumidores As Decimal
            Get
                Return _nm_ventas_internas_gravadas_consumidores
            End Get
            Set(value As Decimal)
                _nm_ventas_internas_gravadas_consumidores = value
            End Set
        End Property
        Public Property nm_ventas_internas_exentas_contrib As Decimal
            Get
                Return _nm_ventas_internas_exentas_contrib
            End Get
            Set(value As Decimal)
                _nm_ventas_internas_exentas_contrib = value
            End Set
        End Property
        Public Property nm_ventas_internas_exentas_consumidores As Decimal
            Get
                Return _nm_ventas_internas_exentas_consumidores
            End Get
            Set(value As Decimal)
                _nm_ventas_internas_exentas_consumidores = value
            End Set
        End Property
        Public Property nm_exportaciones As Decimal
            Get
                Return _nm_exportaciones
            End Get
            Set(value As Decimal)
                _nm_exportaciones = value
            End Set
        End Property
        Public Property nm_iva_interno_contrib As Decimal
            Get
                Return _nm_iva_interno_contrib
            End Get
            Set(value As Decimal)
                _nm_iva_interno_contrib = value
            End Set
        End Property
        Public Property nm_iva_interno_consumidores As Decimal
            Get
                Return _nm_iva_interno_consumidores
            End Get
            Set(value As Decimal)
                _nm_iva_interno_consumidores = value
            End Set
        End Property
        Public Sub New(vta_int_grav_contrib As Decimal, vta_int_grav_consu As Decimal, vta_int_exe_contrib As Decimal, vta_int_exe_consu As Decimal,
                       exportacion As Decimal, iva_contrib As Decimal, iva_consumidor As Decimal)
            _nm_ventas_internas_gravadas_contrib = vta_int_grav_contrib
            _nm_ventas_internas_gravadas_consumidores = vta_int_grav_consu
            _nm_ventas_internas_exentas_contrib = vta_int_exe_contrib
            _nm_ventas_internas_exentas_consumidores = vta_int_exe_consu
            _nm_exportaciones = exportacion
            _nm_iva_interno_contrib = iva_contrib
            _nm_iva_interno_consumidores = iva_consumidor

        End Sub
        Public Sub New()

        End Sub

    End Class
End Namespace

