Public Class Form2
    Public Rating
    Public Name

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Name = TextBox1.Text
        Rating = TextBox2.Text

        Form1.ListBox2.Items.Add(Name + " -- " + Rating)

        Me.Hide()
    End Sub

    Private Sub RadioButton70_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton69_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton68_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton67_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton66_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton55_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton54_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton53_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton52_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton51_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class