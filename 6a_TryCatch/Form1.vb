Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number1 As Integer
        Dim number2 As Integer
        Dim answer As Integer

        Try
            number1 = txtFirstNumber.Text
            number2 = txtSecondNumber.Text
            answer = number1 + number2
            txtNumberResult.Text = answer
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            txtNumberResult.Text = ""
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim FirstName As String = txtFirstName.Text
        Dim LastName As String = txtLastName.Text
        Dim FullName As String = FirstName & " " & LastName

        txtFullName.Text = FullName
    End Sub


End Class


