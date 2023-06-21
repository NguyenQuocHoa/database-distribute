''' <summary>
''' Role
''' @CreatedBy      : Hoa Nguyen Quoc
''' @Created        : 2023/06/21
''' @Modified       :
''' </summary>
''' <remarks>Class Role</remarks>
Public Class Role
    Inherits BaseInfo
    Private Property m_RoleName As String = ""

    Public Property RoleName() As String
        Get
            Return m_RoleName
        End Get
        Set(ByVal value As String)
            m_RoleName = value
        End Set
    End Property
End Class
