''' <summary>
''' Charge
''' @CreatedBy      : Hoa Nguyen Quoc
''' @Created        : 2023/06/21
''' @Modified       :
''' </summary>
''' <remarks>Class ReCharge</remarks>
Public Class Charge
    Inherits BaseInfo
    Private Property m_Fee As Decimal = 0
    Private Property m_IsSuccess As Boolean = False
    Private Property m_ChargeMessage As String = ""

    Public Property Fee() As Decimal
        Get
            Return m_Fee
        End Get
        Set(ByVal value As Decimal)
            m_Fee = value
        End Set
    End Property

    Public Property IsSuccess() As Boolean
        Get
            Return m_IsSuccess
        End Get
        Set(ByVal value As Boolean)
            m_IsSuccess = value
        End Set
    End Property

    Public Property ChargeMessage() As String
        Get
            Return m_ChargeMessage
        End Get
        Set(ByVal value As String)
            m_ChargeMessage = value
        End Set
    End Property
End Class
