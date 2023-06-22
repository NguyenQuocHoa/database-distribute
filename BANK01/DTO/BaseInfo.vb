''' <summary>
''' BaseInfo
''' @CreatedBy      : Hoa Nguyen Quoc
''' @Created        : 2023/06/21
''' @Modified       :
''' </summary>
''' <remarks>Class include infomation for all class</remarks>
Public MustInherit Class BaseInfo
    Private Property m_Id As Integer = 0
    Private Property m_Description As String = ""
    Private Property m_IsActive As Boolean = False
    Private Property m_IsDelete As Boolean = False
    Private Property m_CreatedDate As DateTime
    Private Property m_Creater As Integer = 0
    Private Property m_LastModifiedDate As DateTime
    Private Property m_Updator As Integer = 0

    Public Property Id() As Integer
        Get
            Return m_Id
        End Get
        Set(ByVal value As Integer)
            m_Id = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return m_Description
        End Get
        Set(ByVal value As String)
            m_Description = value
        End Set
    End Property

    Public Property IsActive() As Boolean
        Get
            Return m_IsActive
        End Get
        Set(ByVal value As Boolean)
            m_IsActive = value
        End Set
    End Property

    Public Property IsDelete() As Boolean
        Get
            Return m_IsDelete
        End Get
        Set(ByVal value As Boolean)
            m_IsDelete = value
        End Set
    End Property

    Public Property CreatedDate() As DateTime
        Get
            Return m_CreatedDate
        End Get
        Set(ByVal value As DateTime)
            m_CreatedDate = value
        End Set
    End Property

    Public Property Creater() As Integer
        Get
            Return m_Creater
        End Get
        Set(ByVal value As Integer)
            m_Creater = value
        End Set
    End Property

    Public Property LastModifiedDate() As DateTime
        Get
            Return m_LastModifiedDate
        End Get
        Set(ByVal value As DateTime)
            m_LastModifiedDate = value
        End Set
    End Property

    Public Property Updator() As Integer
        Get
            Return m_Updator
        End Get
        Set(ByVal value As Integer)
            m_Updator = value
        End Set
    End Property
End Class
