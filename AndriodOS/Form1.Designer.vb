<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BootTime = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AppIcon_Win93 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AppIcon_Browser = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AppIcon_Settings = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlightModeIndicator = New System.Windows.Forms.PictureBox()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Clock = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.AppIcon_Win93.SuspendLayout()
        Me.AppIcon_Browser.SuspendLayout()
        Me.AppIcon_Settings.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.FlightModeIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgressBar1.Location = New System.Drawing.Point(71, 481)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(329, 10)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 0
        Me.ProgressBar1.Value = 100
        '
        'BootTime
        '
        Me.BootTime.Enabled = True
        Me.BootTime.Interval = 22326
        Me.BootTime.Tag = "23226"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackgroundImage = Global.AndriodOS.My.Resources.Resources.WallPepper1
        Me.Panel1.Controls.Add(Me.AppIcon_Win93)
        Me.Panel1.Controls.Add(Me.AppIcon_Browser)
        Me.Panel1.Controls.Add(Me.AppIcon_Settings)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.MaximumSize = New System.Drawing.Size(480, 854)
        Me.Panel1.MinimumSize = New System.Drawing.Size(480, 854)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 854)
        Me.Panel1.TabIndex = 1
        Me.Panel1.Visible = False
        '
        'AppIcon_Win93
        '
        Me.AppIcon_Win93.BackgroundImage = Global.AndriodOS.My.Resources.Resources.Window93
        Me.AppIcon_Win93.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AppIcon_Win93.Controls.Add(Me.Label5)
        Me.AppIcon_Win93.Location = New System.Drawing.Point(143, 730)
        Me.AppIcon_Win93.Name = "AppIcon_Win93"
        Me.AppIcon_Win93.Size = New System.Drawing.Size(101, 112)
        Me.AppIcon_Win93.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(18, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Win93"
        '
        'AppIcon_Browser
        '
        Me.AppIcon_Browser.BackgroundImage = Global.AndriodOS.My.Resources.Resources.Browser
        Me.AppIcon_Browser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AppIcon_Browser.Controls.Add(Me.Label4)
        Me.AppIcon_Browser.Location = New System.Drawing.Point(255, 730)
        Me.AppIcon_Browser.Name = "AppIcon_Browser"
        Me.AppIcon_Browser.Size = New System.Drawing.Size(101, 112)
        Me.AppIcon_Browser.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Browser"
        '
        'AppIcon_Settings
        '
        Me.AppIcon_Settings.BackgroundImage = Global.AndriodOS.My.Resources.Resources.Settings
        Me.AppIcon_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AppIcon_Settings.Controls.Add(Me.Label3)
        Me.AppIcon_Settings.Location = New System.Drawing.Point(367, 730)
        Me.AppIcon_Settings.Name = "AppIcon_Settings"
        Me.AppIcon_Settings.Size = New System.Drawing.Size(101, 112)
        Me.AppIcon_Settings.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Settings"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.FlightModeIndicator)
        Me.Panel2.Controls.Add(Me.ProgressBar2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(480, 35)
        Me.Panel2.TabIndex = 0
        '
        'FlightModeIndicator
        '
        Me.FlightModeIndicator.Image = Global.AndriodOS.My.Resources.Resources.FlightMode_status
        Me.FlightModeIndicator.Location = New System.Drawing.Point(307, 6)
        Me.FlightModeIndicator.Name = "FlightModeIndicator"
        Me.FlightModeIndicator.Size = New System.Drawing.Size(24, 23)
        Me.FlightModeIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FlightModeIndicator.TabIndex = 2
        Me.FlightModeIndicator.TabStop = False
        Me.FlightModeIndicator.Visible = False
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(381, 9)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(24, 16)
        Me.ProgressBar2.TabIndex = 1
        Me.ProgressBar2.Value = 100
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(337, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "100%"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(411, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "00:00"
        '
        'Clock
        '
        Me.Clock.Enabled = True
        Me.Clock.Interval = 2000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.AndriodOS.My.Resources.Resources.Andriod
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(480, 854)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Andriod Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.AppIcon_Win93.ResumeLayout(False)
        Me.AppIcon_Win93.PerformLayout()
        Me.AppIcon_Browser.ResumeLayout(False)
        Me.AppIcon_Browser.PerformLayout()
        Me.AppIcon_Settings.ResumeLayout(False)
        Me.AppIcon_Settings.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.FlightModeIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents BootTime As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Clock As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents AppIcon_Settings As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FlightModeIndicator As System.Windows.Forms.PictureBox
    Friend WithEvents AppIcon_Browser As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AppIcon_Win93 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
