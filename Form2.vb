Public Class Form2
    Public Longitudine, Latitudine As Single
    Dim A As Single = 0.0
    Dim B As Single = 0.0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Longitudine"
        Label2.Text = "Latitudine"
        TextBox1.Text = "0.0"
        TextBox2.Text = "0.0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Longitudine = CSng(TextBox1.Text)
        Latitudine = CSng(TextBox2.Text)
        Me.Close()
    End Sub
End Class