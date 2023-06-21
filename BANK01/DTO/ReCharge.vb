''' <summary>
''' ReCharge
''' @CreatedBy      : Hoa Nguyen Quoc
''' @Created        : 2023/06/21
''' @Modified       :
''' </summary>
''' <remarks>Class ReCharge</remarks>
Public Class ReCharge
    Inherits BaseInfo
    Private Property m_Money As Decimal = 0
    Private Property m_TargetAccountNumber As String = ""
    Private Property m_TargetAccountName As String = ""
    Private Property m_RechargeMessage As String = ""

    Public Property Money() As Decimal
        Get
            Return m_Money
        End Get
        Set(ByVal value As Decimal)
            m_Money = value
        End Set
    End Property

    Public Property TargetAccountNumber() As String
        Get
            Return m_TargetAccountNumber
        End Get
        Set(ByVal value As String)
            m_TargetAccountNumber = value
        End Set
    End Property

    Public Property TargetAccountName() As String
        Get
            Return m_TargetAccountName
        End Get
        Set(ByVal value As String)
            m_TargetAccountName = value
        End Set
    End Property

    Public Property RechargeMessage() As String
        Get
            Return m_RechargeMessage
        End Get
        Set(ByVal value As String)
            m_RechargeMessage = value
        End Set
    End Property
End Class
