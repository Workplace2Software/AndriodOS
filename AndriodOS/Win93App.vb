Public Class Win93App

    Private Sub HomeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeButton.Click
        My.Computer.Audio.Play(My.Resources.ReassuringSoundOfConfirmationThatYouDidIndeedTapTheButtonThatYouThoughtYouTappedHopefullyIfTheDigitizerDidItsJobAlright, AudioPlayMode.Background)
        Me.Close()
    End Sub

    Private Sub Win93App_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(Me.Location.X, Me.Location.Y + 18)
    End Sub
End Class