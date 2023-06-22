Imports DAL
''' <summary>
''' frmLogin
''' @CreatedBy      : Hoa Nguyen Quoc
''' @Created        : 2023/06/22
''' @Modified       :
''' </summary>
''' <remarks>Class frmLogin</remarks>
Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim BankDALInstance As BankDAL = New BankDAL("SELECT * FROM Bank")
            BankDALInstance.FillDataToGridView(dgvBank)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim BankDALInstance As BankDAL = New BankDAL("SELECT * FROM Bank")
            BankDALInstance.UpdateDataToDB()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
