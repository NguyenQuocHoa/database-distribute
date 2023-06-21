''' <summary>
''' Customer
''' @CreatedBy      : Hoa Nguyen Quoc
''' @Created        : 2023/06/21
''' @Modified       :
''' </summary>
''' <remarks>Class Customer</remarks>
Public Class Customer
    Inherits BaseInfo
    Private Property m_CustomerName As String = ""
    Private Property m_LimitPerDay As Decimal = 0
    Private Property m_AccountNumber As String = ""
    Private Property m_CardNumber As String = ""
    Private Property m_AccountBalance As Decimal = 0
    Private Property m_Dob As Date
    Private Property m_Phone As String = ""
    Private Property m_Email As String = ""

    Public Property CustomerName() As String
        Get
            Return m_CustomerName
        End Get
        Set(ByVal value As String)
            m_CustomerName = value
        End Set
    End Property

    Public Property LimitPerDay() As Decimal
        Get
            Return m_LimitPerDay
        End Get
        Set(ByVal value As Decimal)
            m_LimitPerDay = value
        End Set
    End Property

    Public Property AccountNumber() As String
        Get
            Return m_AccountNumber
        End Get
        Set(ByVal value As String)
            m_AccountNumber = value
        End Set
    End Property

    Public Property CardNumber() As String
        Get
            Return m_CardNumber
        End Get
        Set(ByVal value As String)
            m_CardNumber = value
        End Set
    End Property

    Public Property AccountBalance() As Decimal
        Get
            Return m_AccountBalance
        End Get
        Set(ByVal value As Decimal)
            m_AccountBalance = value
        End Set
    End Property

    Public Property Dob() As Date
        Get
            Return m_Dob
        End Get
        Set(ByVal value As Date)
            m_Dob = value
        End Set
    End Property

    Public Property Phone() As String
        Get
            Return m_Phone
        End Get
        Set(ByVal value As String)
            m_Phone = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return m_Email
        End Get
        Set(ByVal value As String)
            m_Email = value
        End Set
    End Property
End Class
