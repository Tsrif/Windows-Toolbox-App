Imports System
Imports System.IO

Public Class BootDisk
    Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
    Dim d As DriveInfo

    Private Sub BootDisk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StyleManager = winToolFrm.MetroStyleManager
        isoLbl.Theme = Me.Theme
        isoLbl.Style = Me.Style
        fileText.Theme = Me.Theme
        fileText.Style = Me.Style
        btnBrowse.Theme = Me.Theme
        btnBrowse.Style = Me.Style
        drivelbl.Theme = Me.Theme
        drivelbl.Style = Me.Style
        driveBox.Theme = Me.Theme
        driveBox.Style = Me.Style
        createbtn.Theme = Me.Theme
        createbtn.Style = Me.Style
        exitbtn.Theme = Me.Theme
        exitbtn.Style = Me.Style
        isoLabel.Theme = Me.Theme
        isoLabel.Style = Me.Style
        isoBox.Theme = Me.Theme
        isoBox.Style = Me.Style
        wait.Theme = Me.Theme
        wait.Style = Me.Style
        spinwait.Theme = Me.Theme
        spinwait.Style = Me.Style
        btnRestart.Theme = Me.Theme
        btnRestart.Style = Me.Style
        helplbl.Theme = Me.Theme
        helplbl.Style = Me.Style
        errorlbl.Theme = Me.Theme
        errorlbl.Style = Me.Style
        createlbl.Theme = Me.Theme
        createlbl.Style = Me.Style
    End Sub

    Private Sub BootDisk_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Shell("C:\Windows\System32\cmd.exe /c PowerShell Dismount-DiskImage -ImagePath " + """" + fileText.Text + """")
        winToolFrm.BringToFront()
        winToolFrm.Enabled = True
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Me.Close()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        fileText.Text = OpenFileDialog1.FileName
        Shell("C:\Windows\System32\cmd.exe /c PowerShell Mount-DiskImage -ImagePath " + """" + fileText.Text + """")
        spinwait.Visible = True
        wait.Visible = True
        Timer2.Enabled = True
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (driveBox.Text = "") Or (fileText.Text = "") Or (isoBox.Text = "") Then
            createbtn.Enabled = False
        Else
            createbtn.Enabled = True
        End If
    End Sub

    Private Sub createbtn_Click(sender As Object, e As EventArgs) Handles createbtn.Click
        Dim result As DialogResult = MetroFramework.MetroMessageBox.Show(Me, "Enable to create a bootable drive you must first formate the disk drive. If the drive is not formatted it will not work. To format the drive open my computer, right click the drive, select format then quick format. Is your drive formatted?", "Format Disk", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim driveOne As String
            driveOne = isoBox.SelectedItem.ToString()
            Dim driveOne2 As String
            driveOne2 = driveOne.Substring(0, 2)
            isoLabel.Text = driveOne2

            Dim driveTwo As String
            driveTwo = driveBox.SelectedItem.ToString()
            Dim driveTwo2 As String
            driveTwo2 = driveTwo.Substring(0, 2)
            isoLabel.Text = driveTwo2

            Dim psi As New ProcessStartInfo("cmd.exe")
            psi.Arguments = "/k XCOPY " + driveOne2 + "\*" + " " + driveTwo2 + "\" + " /e"
            psi.WindowStyle = ProcessWindowStyle.Minimized
            Dim p As New Process
            p.StartInfo = psi
            p.Start()

            createlbl.Visible = True
            errorlbl.Visible = True
            isoBox.Visible = False
            helplbl.Visible = False
            isoLabel.Visible = False
            driveBox.Visible = False
            drivelbl.Visible = False
            Me.Enabled = False
            p.WaitForExit()
            Me.Enabled = True
            createlbl.Visible = False
            errorlbl.Visible = False
            isoBox.Visible = True
            helplbl.Visible = True
            isoLabel.Visible = True
            driveBox.Visible = True
            drivelbl.Visible = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        spinwait.Visible = False
        wait.Visible = False
        isoBox.Visible = True
        helplbl.Visible = True
        isoLabel.Visible = True
        driveBox.Visible = True
        drivelbl.Visible = True
        Dim allDrives() As DriveInfo = DriveInfo.GetDrives()
        Dim d As DriveInfo
        For Each d In allDrives
            If d.IsReady = True Then
                If d.DriveType = 2 Then
                    driveBox.Items.Add(d.Name + d.VolumeLabel)
                Else
                    isoBox.Items.Add(d.Name + d.VolumeLabel)
                End If
            End If
        Next
        Timer2.Enabled = False
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Dim frm = New BootDisk
        frm.Show()
        Me.Close()
        winToolFrm.Enabled = False
    End Sub
End Class