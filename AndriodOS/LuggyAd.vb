Public Class LuggyAd

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.ReassuringSoundOfConfirmationThatYouDidIndeedTapTheButtonThatYouThoughtYouTappedHopefullyIfTheDigitizerDidItsJobAlright, AudioPlayMode.WaitToComplete)
        Button1.Hide()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Button1.Show()
        Timer1.Enabled = False
    End Sub

    Private Sub LuggyAd_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Timer1.Enabled = True
        My.Computer.Audio.Play(My.Resources.LuggyAdAud, AudioPlayMode.Background)
    End Sub
End Class