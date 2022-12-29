Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim message As String = ""
        Dim counter As Integer = 0

        If CheckBox1.CheckState = CheckState.Checked Then
            message = message & CheckBox1.Text & vbNewLine
            counter = counter + 1
        End If
        If CheckBox2.CheckState = CheckState.Checked Then
            message = message & CheckBox2.Text & vbNewLine
            counter = counter + 1
        End If
        If CheckBox3.CheckState = CheckState.Checked Then
            message = message & CheckBox3.Text & vbNewLine
            counter = counter + 1
        End If
        If CheckBox4.CheckState = CheckState.Checked Then
            message = message & CheckBox4.Text & vbNewLine
            counter = counter + 1
        End If
        If CheckBox5.CheckState = CheckState.Checked Then
            message = message & CheckBox5.Text & vbNewLine
            counter = counter + 1
        End If

        If counter = 0 Then
            MessageBox.Show("You have chosen nothing")
        Else
            MessageBox.Show("You have chosen:" & vbNewLine & message)
        End If

        Select Case counter
            Case 0
                MessageBox.Show("What did you do for fun?")
            Case 1
                MessageBox.Show("only 1 show watched")
            Case 2
                MessageBox.Show("2 shows watched")
            Case 3
                MessageBox.Show("3 shows watched")
            Case 4
                MessageBox.Show("4 shows watched")
            Case 5
                MessageBox.Show("a soap addict")
        End Select
    End Sub

End Class
