Imports System
Imports System.IO
Imports System.Management
Imports IWshRuntimeLibrary

Public Class winToolFrm
    Private progress As Boolean = True
    Private timeLeft As Integer
    Dim ProgressBar2 As Integer

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DesktopFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        filePath.Text = DesktopFolder
        homeTab.SelectedTab = TabBasicSystemInfo
        toolsTab.SelectedTab = TabShutDownTimer
        settingsTab.SelectedTab = tabProgramSettings
        'Getting Drop Down Default Values for Program Settings and Style Manager and Displaying Them on Load
        Me.StyleManager = MetroStyleManager
        themeDrop.PromptText = getColorTheme()
        colorDrop.PromptText = getColorStyle()
        'Hide Non-Used Tabs and set Text 
        settingsTab.Visible = False
        toolsTab.Visible = False
        lblHome.UseStyleColors = True
        'Timer for auto updating information
        Timer1.Enabled = True

        'Display basic system information
        lblPcName.Text = "PC Name: " + My.Computer.Name
        lblOS.Text = "Operating System: " + My.Computer.Info.OSFullName
        lblOsVersion.Text = "Operating System Version: " + My.Computer.Info.OSVersion
        lblUsername.Text = "User Name:  " + SystemInformation.UserName
        lblProcessorCount.Text = "Processor Count: " + Environment.ProcessorCount.ToString()
        lblTotalPhysicalMemory.Text = "Total Physical Memory: " + (My.Computer.Info.TotalPhysicalMemory / 1073741824).ToString("f") + " GB"
        lblAvailablePhysicalMemory.Text = "Available Physical Memory: " + (My.Computer.Info.AvailablePhysicalMemory / 1073741824).ToString("f") + " GB"
        GraphicsCard()
        Processor()
        Motherboard()
        HardDrive()


    End Sub

    'Returns the serial number for your OS
    Sub WindowsKey()
        Dim objMOS As System.Management.ManagementObjectSearcher
        Dim objMOC As Management.ManagementObjectCollection
        Dim objMO As Management.ManagementObject

        objMOS = New Management.ManagementObjectSearcher("Select * From Win32_OperatingSystem")
        objMOC = objMOS.Get

        For Each objMO In objMOC
            idText.Text = objMO("SerialNumber")
        Next

        objMOS.Dispose()
        objMOS = Nothing
        objMO.Dispose()
        objMO = Nothing

    End Sub

    'Returns the name of your graphics card
    Sub GraphicsCard()
        Dim MyOBJ As Object
        Dim card As Object
        Dim name As String = ""
        Dim driverVersion As String = ""
        MyOBJ = GetObject("WinMgmts:").instancesof("Win32_VideoController")

        For Each card In MyOBJ
            name = card.Name.ToString
            driverVersion = card.DriverVersion.ToString
        Next
        lblGraphicsCard.Text = "Graphics Card: " + name
        lblTest.Text = "Driver Version: " + driverVersion

    End Sub

    'Returns the name of your CPU and its current clock speed
    Sub Processor()
        Dim MyOBJ As Object
        Dim cpu As Object
        Dim name As String = ""
        Dim speed As String = ""
        MyOBJ = GetObject("WinMgmts:").instancesof("Win32_Processor")

        For Each cpu In MyOBJ
            name = cpu.Name.ToString
            speed = cpu.CurrentClockSpeed.ToString + " Mhz"
        Next
        lblProcessor.Text = "Processor: " + name
        lblCurrentClockSpeed.Text = "Current Clock Speed : " + speed
    End Sub

    'This should return the name of the motherboard, but it doesn't. 
    Sub Motherboard()
        Dim MyOBJ As Object
        Dim motherboard As Object
        Dim name As String = ""
        Dim product As String = ""
        Dim installDate As String = ""
        MyOBJ = GetObject("WinMgmts:").instancesof("Win32_BaseBoard")

        For Each motherboard In MyOBJ
            'name = motherboard.SerialNumber.ToString
            name = motherboard.Manufacturer.ToString
            product = motherboard.Product.ToString

        Next
        lblmoboManu.Text = name
        lblMotherboard.Text = product

    End Sub

    Sub HardDrive()
        Dim MyOBJ As Object
        Dim harddrive As Object
        Dim name As String = ""
        lblHarddrive.Text = ""
        MyOBJ = GetObject("WinMgmts:").instancesof("Win32_DiskDrive")

        For Each harddrive In MyOBJ
            'name = motherboard.SerialNumber.ToString
            name += harddrive.Model.ToString + Environment.NewLine + Environment.NewLine

        Next
        lblHarddrive.Text = name
    End Sub

    'Handles the Click For the theme dropdown box in program settings
    Private Sub themeDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles themeDrop.SelectedIndexChanged
        If themeDrop.SelectedIndex = 0 Then
            MetroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light
        ElseIf themeDrop.SelectedIndex = 1 Then
            MetroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark
        End If
    End Sub

    'Handles the Click For the style dropdown box in program settings
    Private Sub colorDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles colorDrop.SelectedIndexChanged
        If colorDrop.SelectedIndex = 0 Then
            MetroStyleManager.Style = MetroFramework.MetroColorStyle.Black
        ElseIf colorDrop.SelectedIndex = 1 Then
            MetroStyleManager.Style = MetroFramework.MetroColorStyle.White
        ElseIf colorDrop.SelectedIndex = 2 Then
            MetroStyleManager.Style = MetroFramework.MetroColorStyle.Silver
        ElseIf colorDrop.SelectedIndex = 3 Then
            MetroStyleManager.Style = MetroFramework.MetroColorStyle.Blue
        ElseIf colorDrop.SelectedIndex = 4 Then
            MetroStyleManager.Style = MetroFramework.MetroColorStyle.Green
        ElseIf colorDrop.SelectedIndex = 5 Then
            MetroStyleManager.Style = MetroFramework.MetroColorStyle.Lime
        ElseIf colorDrop.SelectedIndex = 6 Then
            MetroStyleManager.Style = MetroFramework.MetroColorStyle.Teal
        ElseIf colorDrop.SelectedIndex = 7 Then
            MetroStyleManager.Style = MetroFramework.MetroColorStyle.Orange
        ElseIf colorDrop.SelectedIndex = 8 Then
            MetroStyleManager.Style = MetroFramework.MetroColorStyle.Brown
        ElseIf colorDrop.SelectedIndex = 9 Then
            MetroStyleManager.Style = MetroFramework.MetroColorStyle.Pink
        ElseIf colorDrop.SelectedIndex = 10 Then
            MetroStyleManager.Style = MetroFramework.MetroColorStyle.Magenta
        ElseIf colorDrop.SelectedIndex = 11 Then
            MetroStyleManager.Style = MetroFramework.MetroColorStyle.Purple
        ElseIf colorDrop.SelectedIndex = 12 Then
            MetroStyleManager.Style = MetroFramework.MetroColorStyle.Red
        ElseIf colorDrop.SelectedIndex = 13 Then
            MetroStyleManager.Style = MetroFramework.MetroColorStyle.Yellow
        End If
    End Sub

    'Events for clicking mutiple tabs
    Private Sub Home_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        homeTab.Visible = True
        settingsTab.Visible = False
        toolsTab.Visible = False
        lblHome.UseStyleColors = True
        lblTools.UseStyleColors = False
        lblSettings.UseStyleColors = False
        Me.Refresh()
    End Sub

    Private Sub Tools_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        homeTab.Visible = False
        settingsTab.Visible = False
        toolsTab.Visible = True
        lblHome.UseStyleColors = False
        lblTools.UseStyleColors = True
        lblSettings.UseStyleColors = False
        Me.Refresh()
    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        homeTab.Visible = False
        settingsTab.Visible = True
        toolsTab.Visible = False
        lblHome.UseStyleColors = False
        lblTools.UseStyleColors = False
        lblSettings.UseStyleColors = True
        Me.Refresh()
    End Sub

    'Change Date and Time
    Private Sub btnDateTimeChange_Click(sender As Object, e As EventArgs) Handles btnDateTimeChange.Click
        Process.Start("timedate.cpl")
    End Sub

    'Refreshes Date and Time on Shutdown Timer Tool
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = My.Computer.Clock.LocalTime
    End Sub

    'Controls the countdown timer for shutting off computer 
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' Convert time to seconds
        ' while time left is greater than 0 time left -1
        ' call get time to show how much longer is left
        If timeLeft > 0 Then
            timeLeft -= 1
            GetTime(timeLeft)
        End If
        'Shutdown Timer
        'Sleep Timer
        'Hibernate Timer

        If timeLeft = 0 And cbTimerType.Text = "Shutdown Timer" Then
            'Run the command to turn off the computer 
            Shell("C:\Windows\System32\cmd.exe /c shutdown -s -t 10") ' gave it a 10 second timer before shut down begins. 

        ElseIf timeLeft = 0 And cbTimerType.Text = "Sleep Timer" Then
            'Shell("C:\Windows\System32\cmd.exe /c rundll32.exe powrprof.dll,SetSuspendState 0,1,0")
            'Me.Close()
        ElseIf timeLeft = 0 And cbTimerType.Text = "Hibernate Timer" Then
            'Shell("C:\Windows\System32\cmd.exe /c rundll32.exe powrprof.dll,SetSuspendState Hibernate")
            'Me.Close()
        ElseIf timeLeft = 0 And cbTimerType.Text = "Logoff Timer" Then
            Shell("C:\Windows\System32\cmd.exe /c shutdown -l")
            Me.Close()

        ElseIf timeLeft = 0 And cbTimerType.Text = "Reboot Timer" Then
            Shell("C:\Windows\System32\cmd.exe /c shutdown -r")
            Me.Close()
        End If

    End Sub

    Function getColorTheme()
        If Me.Theme = 1 Then
            Return "Light"
        Else
            Return "Dark"
        End If
    End Function

    Function getColorStyle()
        If Me.Style = 1 Then
            Return "Black"
        ElseIf Me.Style = 2 Then
            Return "White"
        ElseIf Me.Style = 3 Then
            Return "Silver"
        ElseIf Me.Style = 4 Then
            Return "Blue"
        ElseIf Me.Style = 5 Then
            Return "Green"
        ElseIf Me.Style = 6 Then
            Return "Lime"
        ElseIf Me.Style = 7 Then
            Return "Teal"
        ElseIf Me.Style = 8 Then
            Return "Orange"
        ElseIf Me.Style = 9 Then
            Return "Brown"
        ElseIf Me.Style = 10 Then
            Return "Pink"
        ElseIf Me.Style = 11 Then
            Return "Magenta"
        ElseIf Me.Style = 12 Then
            Return "Purple"
        ElseIf Me.Style = 12 Then
            Return "Red"
        Else Me.Style = 14
            Return "Yellow"
        End If
    End Function

    'Gets the serial key 
    Private Sub btnWindowsKey_Click(sender As Object, e As EventArgs) Handles btnWindowsKey.Click
        WindowsKey()
    End Sub


    'Pass it the time in seconds and it will return a string with the seconds convert to Hour:Min:Second format
    'Or if the return is not needed it just sets the text for the time labels 
    Public Function GetTime(Time As Integer) As String
        Dim Hrs As Integer  'number of hours   '
        Dim Min As Integer  'number of Minutes '
        Dim Sec As Integer  'number of Sec     '
        Dim ProgressBar As Integer

        'Seconds'
        Sec = Time Mod 60
        lblSeconds.Text = "Seconds: " + Sec.ToString()

        'Minutes'
        Min = ((Time - Sec) / 60) Mod 60
        lblMinutes.Text = "Minutes: " + Min.ToString()

        'Hours'
        Hrs = ((Time - (Sec + (Min * 60))) / 3600) Mod 60
        lblHours.Text = "Hours: " + Hrs.ToString()

        ProgressBar += Hrs * 3600
        ProgressBar += Min * 60
        ProgressBar += Sec
        If progress = True Then
            ProgressBar2 = ProgressBar
        End If
        shutdownProgressBar.Value = Math.Round(ProgressBar * (100 / ProgressBar2))
        progress = False
        Return Format(Hrs, "00") & ":" & Format(Min, "00") & ":" & Format(Sec, "00")
    End Function

    Private Sub btnStartTimerInTime_Click(sender As Object, e As EventArgs) Handles btnStartTimerInTime.Click
        ' actively tell user how long they have left
        ' once timer reaches 0 run command to shutdown computer
        progress = True

        timeLeft += Convert.ToInt32(cb_in_hours.SelectedItem) * 3600 'Convert hours to seconds and add it to timeLeft
        timeLeft += Convert.ToInt32(cb_in_minutes.SelectedItem) * 60 'Convert minutes to seconds and add it to timeLeft
        timeLeft += Convert.ToInt32(cb_in_seconds.SelectedItem)
        Timer2.Enabled = True


    End Sub

    'Stops the timer, sets the text for the labels back to default, and runs a command to stop the shutdown(just in case it was started)
    Private Sub btnStopTimer_Click(sender As Object, e As EventArgs) Handles btnStopTimer.Click
        Timer2.Enabled = False
        shutdownProgressBar.Value = 0
        Shell("C:\Windows\System32\cmd.exe /c shutdown.exe -a")
        lblHours.Text = "Hours: XX"
        lblMinutes.Text = "Minutes: XX"
        lblSeconds.Text = "Seconds: XX"

    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Me.Enabled = False
        BootDisk.Show()
    End Sub

    Private Sub btnShort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShort.Click
        If destPath.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, "Please select a file for shortcut", "Select File", MessageBoxButtons.OK)
        Else
            shCut.Visible = False
        Threading.Thread.Sleep(500)
        Dim WshShell As New WshShell
        Dim MyShortcut As IWshRuntimeLibrary.IWshShortcut
        Dim Folder As String = filePath.Text
        Dim result As String
        result = Path.GetFileName(destPath.Text)

        MyShortcut = CType(WshShell.CreateShortcut(Folder & "\" + result + ".lnk"), IWshRuntimeLibrary.IWshShortcut)
        MyShortcut.TargetPath = """" + destPath.Text + """"
        MyShortcut.Save()
        shCut.Visible = True
        End If
    End Sub





    Private Sub tileWallpaper_Click(sender As Object, e As EventArgs) Handles tileWallpaper.Click
        Shell("C:\Windows\System32\control.exe /name Microsoft.Personalization /page pageWallpaper")
    End Sub

    Private Sub tileTaskManager_Click(sender As Object, e As EventArgs) Handles tileTaskManager.Click
        Shell("C:\Windows\System32\cmd.exe /c taskmgr.exe")
    End Sub

    Private Sub tileIpConfig_Click(sender As Object, e As EventArgs) Handles tileIpConfig.Click
        Shell("C:\Windows\System32\cmd.exe /k ipconfig")
    End Sub

    Private Sub tileInfo_Click(sender As Object, e As EventArgs) Handles tileInfo.Click
        Shell("msinfo32.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub tileChangePassword_Click(sender As Object, e As EventArgs) Handles tileChangePassword.Click
        Dim inputString As String = "C:\Windows\System32\cmd.exe /k net user " + SystemInformation.UserName.ToString + " *"
        Shell(inputString)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        shCut.Visible = False
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            filePath.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        shCut.Visible = False
        OpenFileDialog2.ShowDialog()
    End Sub

    Private Sub OpenFileDialog2_FileOk(sender As Object, e As ComponentModel.CancelEventArgs) Handles OpenFileDialog2.FileOk
        destPath.Text = OpenFileDialog2.FileName
    End Sub

End Class
