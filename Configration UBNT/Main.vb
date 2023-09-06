Public Class Main

    Private Sub Main_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TextIPaddress.Focus()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToParent()

    End Sub

    Private Sub PictureClose_Click(sender As Object, e As EventArgs) Handles PictureClose.Click
        Application.Exit()
    End Sub

    Private Sub NextBTN_Click(sender As Object, e As EventArgs) Handles NextBTN.Click

    End Sub
End Class
