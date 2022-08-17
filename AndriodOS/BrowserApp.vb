Public Class BrowserApp
    Dim r As New Random()
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeButton.Click
        My.Computer.Audio.Play(My.Resources.ReassuringSoundOfConfirmationThatYouDidIndeedTapTheButtonThatYouThoughtYouTappedHopefullyIfTheDigitizerDidItsJobAlright, AudioPlayMode.Background)
        Me.Close()
    End Sub


    Private Sub WebBrowser1_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        TextBox1.Text = WebBrowser1.Url.ToString()
    End Sub

    Private Sub GoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoButton.Click
        WebBrowser1.Navigate(TextBox1.Text)
        If r.Next(1, 15) = 8 Then
            LuggyAd.ShowDialog()
        End If
        My.Computer.Audio.Play(My.Resources.ReassuringSoundOfConfirmationThatYouDidIndeedTapTheButtonThatYouThoughtYouTappedHopefullyIfTheDigitizerDidItsJobAlright, AudioPlayMode.Background)
    End Sub

    Private Sub WebBrowser1_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        My.Computer.Audio.Play(My.Resources.ReassuringSoundOfConfirmationThatYouDidIndeedTapTheButtonThatYouThoughtYouTappedHopefullyIfTheDigitizerDidItsJobAlright, AudioPlayMode.Background)
    End Sub

    Private Sub BrowserApp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(Me.Location.X, Me.Location.Y + 18)
    End Sub
End Class