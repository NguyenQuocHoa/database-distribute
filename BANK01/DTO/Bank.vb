''' <summary>
''' BaseInfo
''' @CreatedBy      : Hoa Nguyen Quoc
''' @Created        : 2023/06/21
''' @Modified       :
''' </summary>
''' <remarks>Class Bank</remarks>
Public Class Bank
    Inherits BaseInfo
    Private Property m_BankName As String = ""

    Public Property BankName() As String
        Get
            Return m_BankName
        End Get
        Set(ByVal value As String)
            m_BankName = value
        End Set
    End Property
End Class
