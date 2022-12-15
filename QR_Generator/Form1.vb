Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Codec.Data


Public Class QR
    Dim code As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim enc As New QRCodeEncoder
        code = TextBox1.Text
        enc.QRCodeScale = 7
        Dim bmp As Bitmap = enc.Encode(code)
        PictureBox1.Image = bmp
    End Sub

End Class
