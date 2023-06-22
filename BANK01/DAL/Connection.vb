Imports System.Data.SqlClient
''' <summary>
''' Connection
''' @CreatedBy      : Hoa Nguyen Quoc
''' @Created        : 2023/06/22
''' @Modified       :
''' </summary>
''' <remarks>Class Make Connection</remarks>
Public Class Connection

    Public ReadOnly Property ConnInstance() As SqlConnection = New SqlConnection()

    Public Sub New()
        Me.ConnInstance.ConnectionString = "Data Source=MSI\SQLEXPRESS;User Id=navicat;Password=1 _
            Initial Catalog=testDB;Database=DB_BANK1;Integrated Security=True"
    End Sub

    Public Sub ConnectToDB()
        Me.ConnInstance.Open()
    End Sub

    Public Sub DisconnectToDB()
        Me.ConnInstance.Close()
    End Sub
End Class
