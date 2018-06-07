Imports IVASAE.IVA
Namespace clasesReporte
    Public Class cRIVA_COMP_RETE
        Private _enca As V_IVA_ENCA_COMP_RETE
        Private _deta As Generic.List(Of V_IVA_DETA_COMP_RETE)

        Public ReadOnly Property enca As V_IVA_ENCA_COMP_RETE
            Get
                Return _enca
            End Get
        End Property
        Public ReadOnly Property deta As Generic.List(Of V_IVA_DETA_COMP_RETE)
            Get
                Return _deta
            End Get
        End Property
        Public Sub New(penca As V_IVA_ENCA_COMP_RETE, pdeta As Generic.List(Of V_IVA_DETA_COMP_RETE))
            _enca = penca
            _deta = pdeta
        End Sub

    End Class
End Namespace

