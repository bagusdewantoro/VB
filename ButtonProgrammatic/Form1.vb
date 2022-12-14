Public Class Form1
    'SET A CLASS VARIABLE TO BE USED DURING THE FORM
    Private Count_control As Integer = 0
    Private Location_control As New Point(10, 50)

    Private Sub create_button()

        'INCREMENT THE COUNT_CONTROL.
        Count_control += 1
        'CHECKING IF THE BUTTONS HAS REACHED TO 5 OR NOT
        If Count_control <= 5 Then
            'SET A NEW BUTTON
            Dim new_Button As New Button
            'ADD THE PROPERTIES OF THE BUTTON
            new_Button.Name = "Button" + Count_control.ToString()
            new_Button.Text = "Button" + Count_control.ToString()
            new_Button.Location = New Point(Location_control.X + 10,
                                            Location_control.Y)
            new_Button.Width = 180
            Location_control.Y += new_Button.Height + 10
            'CREATE THE EVENT HANDLER
            AddHandler new_Button.Click, AddressOf myButtonHandler_Click
            'ADD THE NEW BUTTON TO THE COLLECTION OF CONTROLS
            Controls.Add(new_Button)
        Else

            'CHECKING IF YOU WANT TO CLEAR THE CONTROLS THAT YOU HAVE ADDED.
            If MessageBox.Show("You've reached 5 controls. Do you want to clear controls to start again?",
            "Proceed", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) _
            = Windows.Forms.DialogResult.OK Then

                Controls.Clear() 'CLEARING THE CONTROL
                Count_control = 0 'RETURNING THE COUNT_CONTROL TO ITS DEFAULT VALUE
                Location_control = New Point(10, 50) 'SET A NEW POINT OF THE CONTROLS
                create_button() 'PUT A CONTROL SO THAT YOU CAN ADD ANOTHER CONTROLS
            End If
        End If
    End Sub

    Private Sub myButtonHandler_Click(ByVal sender As Object, ByVal e As EventArgs)
        'VERIFYING THE BUTTONS
        If TypeOf sender Is Button Then
            create_button() 'CREATE A NEW BUTTON

        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        create_button()
    End Sub

End Class
