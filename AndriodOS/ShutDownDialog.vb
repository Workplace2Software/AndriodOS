Public Class ShutDownDialog

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.shutdownallowed = True
        Process.Start("shutdown.exe", "/s /t 0")
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.ReassuringSoundOfConfirmationThatYouDidIndeedTapTheButtonThatYouThoughtYouTappedHopefullyIfTheDigitizerDidItsJobAlright, AudioPlayMode.Background)
        If My.Settings.FlightMode = True Then
            My.Settings.FlightMode = False
            Try
                Process.Start("C:\Andriod\FlightModeOFF.bat")
            Catch ex As Exception
                My.Settings.Wallpepper = My.Settings.Wallpepper
            End Try
        Else
            My.Settings.FlightMode = True
            Try
                Process.Start("C:\Andriod\FlightModeON.bat")
            Catch ex As Exception
                My.Settings.Wallpepper = My.Settings.Wallpepper
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        My.Computer.Audio.Play(My.Resources.Notification, AudioPlayMode.Background)
    End Sub

    Private Sub ShutDownDialog_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        Me.Close()
    End Sub
End Class