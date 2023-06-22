Imports System.Data.SqlClient
Imports System.Windows.Forms
''' <summary>
''' BaseDAL
''' @CreatedBy      : Hoa Nguyen Quoc
''' @Created        : 2023/06/22
''' @Modified       :
''' </summary>
''' <remarks>Class BaseDAL</remarks>
Public MustInherit Class BaseDAL
    Private conn As Connection
    Private adp As SqlDataAdapter
    Private ds As DataSet
    Private Property m_QueryString As String = ""

    Public Sub New()
        conn = New Connection()
    End Sub
    Public Sub New(QueryString As String)
        Me.New()
        m_QueryString = QueryString
    End Sub

    Private Sub ExecuteQuery()
        If String.IsNullOrEmpty(m_QueryString) = False Then
            conn.ConnectToDB()
            adp = New SqlDataAdapter(m_QueryString, conn.ConnInstance)
            ds = New DataSet()
            adp.Fill(ds)
            conn.DisconnectToDB()
        End If
    End Sub

    Public Sub FillDataToGridView(ByRef dgv As DataGridView)
        ExecuteQuery()
        dgv.DataSource = ds.Tables(0)
    End Sub

    Public Sub UpdateDataToDB()
        conn.ConnectToDB()
        Dim UpdateCommand As New SqlCommand("UPDATE Bank Set lastModifiedDate = @now WHERE ID = 2", conn.ConnInstance)
        UpdateCommand.Parameters.AddWithValue("@now", DateTime.Now)
        UpdateCommand.ExecuteNonQuery()
        conn.DisconnectToDB()
    End Sub

    Public Property QueryString() As String
        Get
            Return m_QueryString
        End Get
        Set(value As String)
            m_QueryString = value
        End Set
    End Property
End Class
