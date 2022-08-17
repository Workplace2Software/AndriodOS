Public Class Form1
    Public shutdownallowed As Boolean = False
    Dim powerstatus As PowerStatus = SystemInformation.PowerStatus
    Dim percent As Single = powerstatus.BatteryLifePercent

    Public Function NewWallpepper()
        Select Case My.Settings.Wallpepper
            Case 1
                Panel1.BackgroundImage = My.Resources.WallPepper1
            Case 2
                Panel1.BackgroundImage = My.Resources.WallPepper2
            Case 3
                Panel1.BackgroundImage = My.Resources.WallPepper3
            Case 4
                Panel1.BackgroundImage = My.Resources.WallPepper4
            Case 5
                Panel1.BackgroundImage = My.Resources.WallPepper5
        End Select
    End Function

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If shutdownallowed = False Then
            e.Cancel = True
            ShutDownDialog.ShowDialog()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.YourAndriodIsInPain, AudioPlayMode.Background)
        NewWallpepper()
    End Sub

    Private Sub BootTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BootTime.Tick
        Me.BackgroundImage = My.Resources.ItsNotFinePLSHelpMe
        BootTime.Stop()
        My.Computer.Audio.Stop()
        ProgressBar1.Hide()
        Application.DoEvents()
        Threading.Thread.Sleep(900)
        Panel1.Show()
    End Sub

    Private Sub Clock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clock.Tick
        Label1.Text = Format(Now, "HH:mm")
        Label2.Text = percent * 100 & "%"
        ProgressBar2.Value = percent * 100
        If My.Settings.FlightMode = True Then
            FlightModeIndicator.Show()
        Else
            FlightModeIndicator.Hide()
        End If
    End Sub
    Private Sub Panel3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AppIcon_Settings.Click
        SettingsApp.ShowDialog()
        NewWallpepper()
    End Sub

    Private Sub Panel1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.DoubleClick
        LuggyAd.ShowDialog()
    End Sub
    Private Sub Panel4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AppIcon_Browser.Click
        My.Computer.Audio.Play(My.Resources.ReassuringSoundOfConfirmationThatYouDidIndeedTapTheButtonThatYouThoughtYouTappedHopefullyIfTheDigitizerDidItsJobAlright, AudioPlayMode.Background)
        BrowserApp.ShowDialog()
    End Sub
    Private Sub Panel5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AppIcon_Win93.Click
        My.Computer.Audio.Play(My.Resources.ReassuringSoundOfConfirmationThatYouDidIndeedTapTheButtonThatYouThoughtYouTappedHopefullyIfTheDigitizerDidItsJobAlright, AudioPlayMode.Background)
        Win93App.ShowDialog()
    End Sub
End Class
