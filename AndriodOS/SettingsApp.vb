Public Class SettingsApp

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        My.Computer.Audio.Play(My.Resources.ReassuringSoundOfConfirmationThatYouDidIndeedTapTheButtonThatYouThoughtYouTappedHopefullyIfTheDigitizerDidItsJobAlright, AudioPlayMode.Background)
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        My.Computer.Audio.Play(My.Resources.ReassuringSoundOfConfirmationThatYouDidIndeedTapTheButtonThatYouThoughtYouTappedHopefullyIfTheDigitizerDidItsJobAlright, AudioPlayMode.Background)
        MoreSettings.Location = New Point(0, 82)
        MoreSettings.Show()
    End Sub

    Private Sub SettingsApp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        My.Computer.Audio.Play(My.Resources.ReassuringSoundOfConfirmationThatYouDidIndeedTapTheButtonThatYouThoughtYouTappedHopefullyIfTheDigitizerDidItsJobAlright, AudioPlayMode.Background)
        MoreSettings.Hide()
        Wallpeppers.Hide()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        My.Computer.Audio.Play(My.Resources.ReassuringSoundOfConfirmationThatYouDidIndeedTapTheButtonThatYouThoughtYouTappedHopefullyIfTheDigitizerDidItsJobAlright, AudioPlayMode.Background)
        Wallpeppers.Location = New Point(0, 82)
        Wallpeppers.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles WiFiListing.Click, WiFiButton.Click
        My.Computer.Audio.Play(My.Resources.ReassuringSoundOfConfirmationThatYouDidIndeedTapTheButtonThatYouThoughtYouTappedHopefullyIfTheDigitizerDidItsJobAlright, AudioPlayMode.Background)
        If My.Settings.FlightMode = True Then
            Try
                Process.Start("C:\Andriod\FlightModeOFF.bat")
            Catch ex As Exception
                My.Settings.Wallpepper = My.Settings.Wallpepper
            End Try
            My.Settings.FlightMode = False
            WiFiButton.Location = New Point(409, 134)
            WiFiButton.BackColor = Color.DeepSkyBlue
            WiFiButton.ForeColor = Color.White
            WiFiButton.Text = "ON"
        Else
            Try
                Process.Start("C:\Andriod\FlightModeON.bat")
            Catch ex As Exception
                My.Settings.Wallpepper = My.Settings.Wallpepper
            End Try
            My.Settings.FlightMode = True
            WiFiButton.Location = New Point(354, 134)
            WiFiButton.BackColor = Color.FromArgb(64, 64, 64)
            WiFiButton.ForeColor = Color.White
            WiFiButton.Text = "OFF"
        End If
    End Sub
    Private Sub Button10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.Click
        My.Computer.Audio.Play(My.Resources.ReassuringSoundOfConfirmationThatYouDidIndeedTapTheButtonThatYouThoughtYouTappedHopefullyIfTheDigitizerDidItsJobAlright, AudioPlayMode.Background)
        If My.Settings.FlightMode = True Then
            Try
                Process.Start("C:\Andriod\FlightModeOFF.bat")
            Catch ex As Exception
                My.Settings.Wallpepper = My.Settings.Wallpepper
            End Try
            My.Settings.FlightMode = False
            WiFiButton.Location = New Point(409, 134)
            WiFiButton.BackColor = Color.DeepSkyBlue
            WiFiButton.ForeColor = Color.White
            WiFiButton.Text = "ON"
            Button10.Text = ""
        Else
            Try
                Process.Start("C:\Andriod\FlightModeON.bat")
            Catch ex As Exception
                My.Settings.Wallpepper = My.Settings.Wallpepper
            End Try
            My.Settings.FlightMode = True
            WiFiButton.Location = New Point(354, 134)
            WiFiButton.BackColor = Color.FromArgb(64, 64, 64)
            WiFiButton.ForeColor = Color.White
            WiFiButton.Text = "OFF"
            Button10.Text = "X"
        End If
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        My.Computer.Audio.Play(My.Resources.ReassuringSoundOfConfirmationThatYouDidIndeedTapTheButtonThatYouThoughtYouTappedHopefullyIfTheDigitizerDidItsJobAlright, AudioPlayMode.Background)
        My.Settings.Wallpepper = 2
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        My.Computer.Audio.Play(My.Resources.ReassuringSoundOfConfirmationThatYouDidIndeedTapTheButtonThatYouThoughtYouTappedHopefullyIfTheDigitizerDidItsJobAlright, AudioPlayMode.Background)
        My.Settings.Wallpepper = 3
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        My.Computer.Audio.Play(My.Resources.ReassuringSoundOfConfirmationThatYouDidIndeedTapTheButtonThatYouThoughtYouTappedHopefullyIfTheDigitizerDidItsJobAlright, AudioPlayMode.Background)
        My.Settings.Wallpepper = 4
    End Sub
    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        My.Computer.Audio.Play(My.Resources.ReassuringSoundOfConfirmationThatYouDidIndeedTapTheButtonThatYouThoughtYouTappedHopefullyIfTheDigitizerDidItsJobAlright, AudioPlayMode.Background)
        My.Settings.Wallpepper = 5
    End Sub

    Private Sub SettingsApp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Location = New Point(Me.Location.X, Me.Location.Y + 18)
    End Sub
    Private Sub SettingsApp_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If My.Settings.FlightMode = False Then
            WiFiButton.Location = New Point(409, 134)
            WiFiButton.BackColor = Color.DeepSkyBlue
            WiFiButton.ForeColor = Color.White
            WiFiButton.Text = "ON"
            Button10.Text = ""
        Else
            WiFiButton.Location = New Point(354, 134)
            WiFiButton.BackColor = Color.FromArgb(64, 64, 64)
            WiFiButton.ForeColor = Color.White
            WiFiButton.Text = "OFF"
            Button10.Text = "X"
        End If
    End Sub
End Class