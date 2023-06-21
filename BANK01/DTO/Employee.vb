''' <summary>
''' Employee
''' @CreatedBy      : Hoa Nguyen Quoc
''' @Created        : 2023/06/21
''' @Modified       :
''' </summary>
''' <remarks>Class Employee</remarks>
Public Class Employee
    Inherits BaseInfo
    Private Property m_EmployeeName As String = ""
    Private Property m_Username As String = ""
    Private Property m_Password As String = ""
    Private Property m_Dob As Date
    Private Property m_Phone As String = ""
    Private Property m_Email As String = ""

    Public Property EmployeeName() As String
        Get
            Return m_EmployeeName
        End Get
        Set(ByVal value As String)
            m_EmployeeName = value
        End Set
    End Property

    Public Property Username() As String
        Get
            Return m_Username
        End Get
        Set(ByVal value As String)
            m_Username = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return m_Password
        End Get
        Set(ByVal value As String)
            m_Password = value
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
