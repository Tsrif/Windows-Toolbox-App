<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class winToolFrm
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblHome = New MetroFramework.Controls.MetroLabel()
        Me.lblTools = New MetroFramework.Controls.MetroLabel()
        Me.lblSettings = New MetroFramework.Controls.MetroLabel()
        Me.MetroStyleManager = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.homeTab = New MetroFramework.Controls.MetroTabControl()
        Me.TabBasicSystemInfo = New MetroFramework.Controls.MetroTabPage()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnWindowsKey = New MetroFramework.Controls.MetroButton()
        Me.idText = New MetroFramework.Controls.MetroTextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.lblUsername = New MetroFramework.Controls.MetroLabel()
        Me.lblOsVersion = New MetroFramework.Controls.MetroLabel()
        Me.lblOS = New MetroFramework.Controls.MetroLabel()
        Me.lblPcName = New MetroFramework.Controls.MetroLabel()
        Me.TabDetailedSystemInfo = New MetroFramework.Controls.MetroTabPage()
        Me.lblAvailablePhysicalMemory = New MetroFramework.Controls.MetroLabel()
        Me.lblTotalPhysicalMemory = New MetroFramework.Controls.MetroLabel()
        Me.lblMotherboard = New MetroFramework.Controls.MetroLabel()
        Me.lblHarddrive = New MetroFramework.Controls.MetroLabel()
        Me.lblTest = New MetroFramework.Controls.MetroLabel()
        Me.lblmoboManu = New MetroFramework.Controls.MetroLabel()
        Me.lblCurrentClockSpeed = New MetroFramework.Controls.MetroLabel()
        Me.lblProcessor = New MetroFramework.Controls.MetroLabel()
        Me.lblProcessorCount = New MetroFramework.Controls.MetroLabel()
        Me.lblGraphicsCard = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.settingsTab = New MetroFramework.Controls.MetroTabControl()
        Me.tabProgramSettings = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.colorDrop = New MetroFramework.Controls.MetroComboBox()
        Me.lblTheme = New MetroFramework.Controls.MetroLabel()
        Me.themeDrop = New MetroFramework.Controls.MetroComboBox()
        Me.tabAbout = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.toolsTab = New MetroFramework.Controls.MetroTabControl()
        Me.TabShutDownTimer = New MetroFramework.Controls.MetroTabPage()
        Me.timer = New MetroFramework.Controls.MetroLabel()
        Me.cbTimerType = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.cb_in_seconds = New MetroFramework.Controls.MetroComboBox()
        Me.cb_in_minutes = New MetroFramework.Controls.MetroComboBox()
        Me.cb_in_hours = New MetroFramework.Controls.MetroComboBox()
        Me.btnStopTimer = New MetroFramework.Controls.MetroButton()
        Me.lblSeconds = New MetroFramework.Controls.MetroLabel()
        Me.lblMinutes = New MetroFramework.Controls.MetroLabel()
        Me.lblHours = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnStartTimerInTime = New MetroFramework.Controls.MetroButton()
        Me.shutdownProgressBar = New MetroFramework.Controls.MetroProgressBar()
        Me.btnDateTimeChange = New MetroFramework.Controls.MetroButton()
        Me.lblDateTime = New MetroFramework.Controls.MetroLabel()
        Me.currTime = New MetroFramework.Controls.MetroLabel()
        Me.TabShortcutCreator = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.btnShort = New MetroFramework.Controls.MetroButton()
        Me.filePath = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.destPath = New MetroFramework.Controls.MetroTextBox()
        Me.btnBrowse = New MetroFramework.Controls.MetroButton()
        Me.pathLbl = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.TabMoreTools = New MetroFramework.Controls.MetroTabPage()
        Me.tileChangePassword = New MetroFramework.Controls.MetroTile()
        Me.tileInfo = New MetroFramework.Controls.MetroTile()
        Me.tileIpConfig = New MetroFramework.Controls.MetroTile()
        Me.tileTaskManager = New MetroFramework.Controls.MetroTile()
        Me.tileWallpaper = New MetroFramework.Controls.MetroTile()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.shCut = New MetroFramework.Controls.MetroLabel()
        CType(Me.MetroStyleManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.homeTab.SuspendLayout()
        Me.TabBasicSystemInfo.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDetailedSystemInfo.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.settingsTab.SuspendLayout()
        Me.tabProgramSettings.SuspendLayout()
        Me.tabAbout.SuspendLayout()
        Me.toolsTab.SuspendLayout()
        Me.TabShutDownTimer.SuspendLayout()
        Me.TabShortcutCreator.SuspendLayout()
        Me.TabMoreTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.BackColor = System.Drawing.Color.Transparent
        Me.lblHome.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblHome.Location = New System.Drawing.Point(39, 162)
        Me.lblHome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(45, 19)
        Me.lblHome.TabIndex = 3
        Me.lblHome.Text = "Home"
        Me.lblHome.UseStyleColors = True
        '
        'lblTools
        '
        Me.lblTools.AutoSize = True
        Me.lblTools.Location = New System.Drawing.Point(42, 292)
        Me.lblTools.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTools.Name = "lblTools"
        Me.lblTools.Size = New System.Drawing.Size(38, 19)
        Me.lblTools.TabIndex = 4
        Me.lblTools.Text = "Tools"
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Location = New System.Drawing.Point(34, 422)
        Me.lblSettings.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(54, 19)
        Me.lblSettings.TabIndex = 5
        Me.lblSettings.Text = "Settings"
        '
        'MetroStyleManager
        '
        Me.MetroStyleManager.Owner = Me
        Me.MetroStyleManager.Style = MetroFramework.MetroColorStyle.Red
        Me.MetroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = Global.Windows_ToolBox.My.Resources.Resources.settings_1
        Me.PictureBox3.Location = New System.Drawing.Point(17, 331)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(89, 89)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = Global.Windows_ToolBox.My.Resources.Resources.network
        Me.PictureBox2.Location = New System.Drawing.Point(17, 201)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(89, 89)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.Windows_ToolBox.My.Resources.Resources.home
        Me.PictureBox1.Location = New System.Drawing.Point(17, 71)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'homeTab
        '
        Me.homeTab.Controls.Add(Me.TabBasicSystemInfo)
        Me.homeTab.Controls.Add(Me.TabDetailedSystemInfo)
        Me.homeTab.Location = New System.Drawing.Point(160, 70)
        Me.homeTab.Margin = New System.Windows.Forms.Padding(2)
        Me.homeTab.Name = "homeTab"
        Me.homeTab.SelectedIndex = 0
        Me.homeTab.Size = New System.Drawing.Size(800, 370)
        Me.homeTab.TabIndex = 9
        Me.homeTab.UseSelectable = True
        '
        'TabBasicSystemInfo
        '
        Me.TabBasicSystemInfo.BackColor = System.Drawing.Color.Transparent
        Me.TabBasicSystemInfo.Controls.Add(Me.MetroButton5)
        Me.TabBasicSystemInfo.Controls.Add(Me.PictureBox5)
        Me.TabBasicSystemInfo.Controls.Add(Me.btnWindowsKey)
        Me.TabBasicSystemInfo.Controls.Add(Me.idText)
        Me.TabBasicSystemInfo.Controls.Add(Me.PictureBox4)
        Me.TabBasicSystemInfo.Controls.Add(Me.lblUsername)
        Me.TabBasicSystemInfo.Controls.Add(Me.lblOsVersion)
        Me.TabBasicSystemInfo.Controls.Add(Me.lblOS)
        Me.TabBasicSystemInfo.Controls.Add(Me.lblPcName)
        Me.TabBasicSystemInfo.HorizontalScrollbarBarColor = True
        Me.TabBasicSystemInfo.HorizontalScrollbarHighlightOnWheel = False
        Me.TabBasicSystemInfo.HorizontalScrollbarSize = 8
        Me.TabBasicSystemInfo.Location = New System.Drawing.Point(4, 38)
        Me.TabBasicSystemInfo.Margin = New System.Windows.Forms.Padding(2)
        Me.TabBasicSystemInfo.Name = "TabBasicSystemInfo"
        Me.TabBasicSystemInfo.Size = New System.Drawing.Size(792, 328)
        Me.TabBasicSystemInfo.TabIndex = 0
        Me.TabBasicSystemInfo.Text = "Basic System Information"
        Me.TabBasicSystemInfo.VerticalScrollbarBarColor = True
        Me.TabBasicSystemInfo.VerticalScrollbarHighlightOnWheel = False
        Me.TabBasicSystemInfo.VerticalScrollbarSize = 8
        '
        'MetroButton5
        '
        Me.MetroButton5.Location = New System.Drawing.Point(401, 180)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(179, 23)
        Me.MetroButton5.TabIndex = 12
        Me.MetroButton5.Text = "Create Boot Disk"
        Me.MetroButton5.UseSelectable = True
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Windows_ToolBox.My.Resources.Resources.Windows_logo_Cyan_rgb_D
        Me.PictureBox5.Location = New System.Drawing.Point(169, 21)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(391, 124)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'btnWindowsKey
        '
        Me.btnWindowsKey.Location = New System.Drawing.Point(150, 180)
        Me.btnWindowsKey.Name = "btnWindowsKey"
        Me.btnWindowsKey.Size = New System.Drawing.Size(179, 23)
        Me.btnWindowsKey.TabIndex = 10
        Me.btnWindowsKey.Text = "View Windows Serial Key"
        Me.btnWindowsKey.UseSelectable = True
        '
        'idText
        '
        Me.idText.Enabled = False
        Me.idText.Lines = New String() {"XXXXX-XXXXX-XXXXX-XXXXX"}
        Me.idText.Location = New System.Drawing.Point(150, 151)
        Me.idText.MaxLength = 32767
        Me.idText.Name = "idText"
        Me.idText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.idText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.idText.SelectedText = ""
        Me.idText.Size = New System.Drawing.Size(430, 23)
        Me.idText.TabIndex = 9
        Me.idText.Text = "XXXXX-XXXXX-XXXXX-XXXXX"
        Me.idText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.idText.UseSelectable = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.Windows_ToolBox.My.Resources.Resources.Paomedia_Small_N_Flat_Key
        Me.PictureBox4.Location = New System.Drawing.Point(119, 151)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(169, 299)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(78, 19)
        Me.lblUsername.TabIndex = 7
        Me.lblUsername.Text = "User Name:"
        '
        'lblOsVersion
        '
        Me.lblOsVersion.AutoSize = True
        Me.lblOsVersion.Location = New System.Drawing.Point(169, 271)
        Me.lblOsVersion.Name = "lblOsVersion"
        Me.lblOsVersion.Size = New System.Drawing.Size(163, 19)
        Me.lblOsVersion.TabIndex = 6
        Me.lblOsVersion.Text = "Operating System Version:"
        '
        'lblOS
        '
        Me.lblOS.AutoSize = True
        Me.lblOS.Location = New System.Drawing.Point(168, 243)
        Me.lblOS.Name = "lblOS"
        Me.lblOS.Size = New System.Drawing.Size(117, 19)
        Me.lblOS.TabIndex = 5
        Me.lblOS.Text = "Operating System:"
        '
        'lblPcName
        '
        Me.lblPcName.AutoSize = True
        Me.lblPcName.Location = New System.Drawing.Point(169, 215)
        Me.lblPcName.Name = "lblPcName"
        Me.lblPcName.Size = New System.Drawing.Size(69, 19)
        Me.lblPcName.TabIndex = 3
        Me.lblPcName.Text = "PC Name:"
        '
        'TabDetailedSystemInfo
        '
        Me.TabDetailedSystemInfo.Controls.Add(Me.lblAvailablePhysicalMemory)
        Me.TabDetailedSystemInfo.Controls.Add(Me.lblTotalPhysicalMemory)
        Me.TabDetailedSystemInfo.Controls.Add(Me.lblMotherboard)
        Me.TabDetailedSystemInfo.Controls.Add(Me.lblHarddrive)
        Me.TabDetailedSystemInfo.Controls.Add(Me.lblTest)
        Me.TabDetailedSystemInfo.Controls.Add(Me.lblmoboManu)
        Me.TabDetailedSystemInfo.Controls.Add(Me.lblCurrentClockSpeed)
        Me.TabDetailedSystemInfo.Controls.Add(Me.lblProcessor)
        Me.TabDetailedSystemInfo.Controls.Add(Me.lblProcessorCount)
        Me.TabDetailedSystemInfo.Controls.Add(Me.lblGraphicsCard)
        Me.TabDetailedSystemInfo.Controls.Add(Me.PictureBox10)
        Me.TabDetailedSystemInfo.Controls.Add(Me.PictureBox9)
        Me.TabDetailedSystemInfo.Controls.Add(Me.PictureBox8)
        Me.TabDetailedSystemInfo.Controls.Add(Me.PictureBox7)
        Me.TabDetailedSystemInfo.Controls.Add(Me.PictureBox6)
        Me.TabDetailedSystemInfo.HorizontalScrollbarBarColor = True
        Me.TabDetailedSystemInfo.HorizontalScrollbarHighlightOnWheel = False
        Me.TabDetailedSystemInfo.HorizontalScrollbarSize = 10
        Me.TabDetailedSystemInfo.Location = New System.Drawing.Point(4, 38)
        Me.TabDetailedSystemInfo.Name = "TabDetailedSystemInfo"
        Me.TabDetailedSystemInfo.Size = New System.Drawing.Size(792, 328)
        Me.TabDetailedSystemInfo.TabIndex = 1
        Me.TabDetailedSystemInfo.Text = "Detailed System Information"
        Me.TabDetailedSystemInfo.VerticalScrollbarBarColor = True
        Me.TabDetailedSystemInfo.VerticalScrollbarHighlightOnWheel = False
        Me.TabDetailedSystemInfo.VerticalScrollbarSize = 10
        '
        'lblAvailablePhysicalMemory
        '
        Me.lblAvailablePhysicalMemory.AutoSize = True
        Me.lblAvailablePhysicalMemory.Location = New System.Drawing.Point(66, 275)
        Me.lblAvailablePhysicalMemory.Name = "lblAvailablePhysicalMemory"
        Me.lblAvailablePhysicalMemory.Size = New System.Drawing.Size(166, 19)
        Me.lblAvailablePhysicalMemory.TabIndex = 17
        Me.lblAvailablePhysicalMemory.Text = "Available Physical Memory"
        '
        'lblTotalPhysicalMemory
        '
        Me.lblTotalPhysicalMemory.AutoSize = True
        Me.lblTotalPhysicalMemory.Location = New System.Drawing.Point(66, 241)
        Me.lblTotalPhysicalMemory.Name = "lblTotalPhysicalMemory"
        Me.lblTotalPhysicalMemory.Size = New System.Drawing.Size(140, 19)
        Me.lblTotalPhysicalMemory.TabIndex = 16
        Me.lblTotalPhysicalMemory.Text = "Total Physical Memory"
        '
        'lblMotherboard
        '
        Me.lblMotherboard.AutoSize = True
        Me.lblMotherboard.Location = New System.Drawing.Point(66, 158)
        Me.lblMotherboard.Name = "lblMotherboard"
        Me.lblMotherboard.Size = New System.Drawing.Size(88, 19)
        Me.lblMotherboard.TabIndex = 15
        Me.lblMotherboard.Text = "Motherboard"
        '
        'lblHarddrive
        '
        Me.lblHarddrive.Location = New System.Drawing.Point(485, 122)
        Me.lblHarddrive.Name = "lblHarddrive"
        Me.lblHarddrive.Size = New System.Drawing.Size(315, 100)
        Me.lblHarddrive.TabIndex = 14
        Me.lblHarddrive.Text = "HardDrive"
        '
        'lblTest
        '
        Me.lblTest.AutoSize = True
        Me.lblTest.Location = New System.Drawing.Point(485, 41)
        Me.lblTest.Name = "lblTest"
        Me.lblTest.Size = New System.Drawing.Size(83, 19)
        Me.lblTest.TabIndex = 12
        Me.lblTest.Text = "MetroLabel4"
        '
        'lblmoboManu
        '
        Me.lblmoboManu.AutoSize = True
        Me.lblmoboManu.Location = New System.Drawing.Point(66, 127)
        Me.lblmoboManu.Name = "lblmoboManu"
        Me.lblmoboManu.Size = New System.Drawing.Size(88, 19)
        Me.lblmoboManu.TabIndex = 11
        Me.lblmoboManu.Text = "Motherboard"
        '
        'lblCurrentClockSpeed
        '
        Me.lblCurrentClockSpeed.AutoSize = True
        Me.lblCurrentClockSpeed.Location = New System.Drawing.Point(66, 73)
        Me.lblCurrentClockSpeed.Name = "lblCurrentClockSpeed"
        Me.lblCurrentClockSpeed.Size = New System.Drawing.Size(133, 19)
        Me.lblCurrentClockSpeed.TabIndex = 10
        Me.lblCurrentClockSpeed.Text = "Current Clock Speed:"
        '
        'lblProcessor
        '
        Me.lblProcessor.AutoSize = True
        Me.lblProcessor.Location = New System.Drawing.Point(66, 41)
        Me.lblProcessor.Name = "lblProcessor"
        Me.lblProcessor.Size = New System.Drawing.Size(70, 19)
        Me.lblProcessor.TabIndex = 9
        Me.lblProcessor.Text = "Processor:"
        '
        'lblProcessorCount
        '
        Me.lblProcessorCount.AutoSize = True
        Me.lblProcessorCount.Location = New System.Drawing.Point(66, 10)
        Me.lblProcessorCount.Name = "lblProcessorCount"
        Me.lblProcessorCount.Size = New System.Drawing.Size(108, 19)
        Me.lblProcessorCount.TabIndex = 8
        Me.lblProcessorCount.Text = "Processor Count:"
        '
        'lblGraphicsCard
        '
        Me.lblGraphicsCard.AutoSize = True
        Me.lblGraphicsCard.Location = New System.Drawing.Point(485, 10)
        Me.lblGraphicsCard.Name = "lblGraphicsCard"
        Me.lblGraphicsCard.Size = New System.Drawing.Size(95, 19)
        Me.lblGraphicsCard.TabIndex = 7
        Me.lblGraphicsCard.Text = "Graphics Card:"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.Image = Global.Windows_ToolBox.My.Resources.Resources._004_hard_drive
        Me.PictureBox10.Location = New System.Drawing.Point(402, 127)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 6
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = Global.Windows_ToolBox.My.Resources.Resources._002_video_card
        Me.PictureBox9.Location = New System.Drawing.Point(402, 10)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 5
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = Global.Windows_ToolBox.My.Resources.Resources._003_ram_memory
        Me.PictureBox8.Location = New System.Drawing.Point(4, 244)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 4
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = Global.Windows_ToolBox.My.Resources.Resources._001_motherboard
        Me.PictureBox7.Location = New System.Drawing.Point(4, 127)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 3
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.Windows_ToolBox.My.Resources.Resources._005_technology
        Me.PictureBox6.Location = New System.Drawing.Point(4, 10)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 2
        Me.PictureBox6.TabStop = False
        '
        'settingsTab
        '
        Me.settingsTab.Controls.Add(Me.tabProgramSettings)
        Me.settingsTab.Controls.Add(Me.tabAbout)
        Me.settingsTab.Location = New System.Drawing.Point(160, 70)
        Me.settingsTab.Margin = New System.Windows.Forms.Padding(2)
        Me.settingsTab.Name = "settingsTab"
        Me.settingsTab.SelectedIndex = 1
        Me.settingsTab.Size = New System.Drawing.Size(800, 370)
        Me.settingsTab.TabIndex = 10
        Me.settingsTab.UseSelectable = True
        '
        'tabProgramSettings
        '
        Me.tabProgramSettings.Controls.Add(Me.MetroLabel5)
        Me.tabProgramSettings.Controls.Add(Me.colorDrop)
        Me.tabProgramSettings.Controls.Add(Me.lblTheme)
        Me.tabProgramSettings.Controls.Add(Me.themeDrop)
        Me.tabProgramSettings.HorizontalScrollbarBarColor = True
        Me.tabProgramSettings.HorizontalScrollbarHighlightOnWheel = False
        Me.tabProgramSettings.HorizontalScrollbarSize = 8
        Me.tabProgramSettings.Location = New System.Drawing.Point(4, 38)
        Me.tabProgramSettings.Margin = New System.Windows.Forms.Padding(2)
        Me.tabProgramSettings.Name = "tabProgramSettings"
        Me.tabProgramSettings.Size = New System.Drawing.Size(792, 328)
        Me.tabProgramSettings.TabIndex = 0
        Me.tabProgramSettings.Text = "Program Settings"
        Me.tabProgramSettings.VerticalScrollbarBarColor = True
        Me.tabProgramSettings.VerticalScrollbarHighlightOnWheel = False
        Me.tabProgramSettings.VerticalScrollbarSize = 8
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(4, 110)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(147, 19)
        Me.MetroLabel5.TabIndex = 5
        Me.MetroLabel5.Text = "Program Color Accents"
        '
        'colorDrop
        '
        Me.colorDrop.FormattingEnabled = True
        Me.colorDrop.ItemHeight = 23
        Me.colorDrop.Items.AddRange(New Object() {"Black", "White", "Silver", "Blue", "Green", "Lime", "Teal", "Orange", "Brown", "Pink", "Magenta", "Purple", "Red ", "Yellow"})
        Me.colorDrop.Location = New System.Drawing.Point(3, 135)
        Me.colorDrop.Name = "colorDrop"
        Me.colorDrop.Size = New System.Drawing.Size(190, 29)
        Me.colorDrop.TabIndex = 4
        Me.colorDrop.UseSelectable = True
        '
        'lblTheme
        '
        Me.lblTheme.AutoSize = True
        Me.lblTheme.Location = New System.Drawing.Point(4, 41)
        Me.lblTheme.Name = "lblTheme"
        Me.lblTheme.Size = New System.Drawing.Size(106, 19)
        Me.lblTheme.TabIndex = 3
        Me.lblTheme.Text = "Program Theme"
        '
        'themeDrop
        '
        Me.themeDrop.FormattingEnabled = True
        Me.themeDrop.ItemHeight = 23
        Me.themeDrop.Items.AddRange(New Object() {"Light ", "Dark"})
        Me.themeDrop.Location = New System.Drawing.Point(4, 63)
        Me.themeDrop.Name = "themeDrop"
        Me.themeDrop.Size = New System.Drawing.Size(190, 29)
        Me.themeDrop.TabIndex = 2
        Me.themeDrop.UseSelectable = True
        '
        'tabAbout
        '
        Me.tabAbout.Controls.Add(Me.MetroLabel10)
        Me.tabAbout.Controls.Add(Me.MetroLabel8)
        Me.tabAbout.Controls.Add(Me.MetroLabel7)
        Me.tabAbout.Controls.Add(Me.MetroLabel6)
        Me.tabAbout.Controls.Add(Me.MetroLabel4)
        Me.tabAbout.HorizontalScrollbarBarColor = True
        Me.tabAbout.HorizontalScrollbarHighlightOnWheel = False
        Me.tabAbout.HorizontalScrollbarSize = 10
        Me.tabAbout.Location = New System.Drawing.Point(4, 38)
        Me.tabAbout.Name = "tabAbout"
        Me.tabAbout.Size = New System.Drawing.Size(792, 328)
        Me.tabAbout.TabIndex = 2
        Me.tabAbout.Text = "About"
        Me.tabAbout.VerticalScrollbarBarColor = True
        Me.tabAbout.VerticalScrollbarHighlightOnWheel = False
        Me.tabAbout.VerticalScrollbarSize = 10
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(0, 64)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(77, 19)
        Me.MetroLabel10.TabIndex = 6
        Me.MetroLabel10.Text = "Created By:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(0, 98)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(106, 19)
        Me.MetroLabel8.TabIndex = 5
        Me.MetroLabel8.Text = "Brandon Conner"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(0, 126)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel7.TabIndex = 4
        Me.MetroLabel7.Text = "Ricky Rivera"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(0, 152)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel6.TabIndex = 3
        Me.MetroLabel6.Text = "Version: 1.0"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(0, 33)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(182, 19)
        Me.MetroLabel4.TabIndex = 2
        Me.MetroLabel4.Text = "Windows ToolBox Application"
        '
        'toolsTab
        '
        Me.toolsTab.Controls.Add(Me.TabShutDownTimer)
        Me.toolsTab.Controls.Add(Me.TabShortcutCreator)
        Me.toolsTab.Controls.Add(Me.TabMoreTools)
        Me.toolsTab.Location = New System.Drawing.Point(160, 70)
        Me.toolsTab.Margin = New System.Windows.Forms.Padding(2)
        Me.toolsTab.Name = "toolsTab"
        Me.toolsTab.SelectedIndex = 1
        Me.toolsTab.Size = New System.Drawing.Size(800, 381)
        Me.toolsTab.TabIndex = 11
        Me.toolsTab.UseSelectable = True
        '
        'TabShutDownTimer
        '
        Me.TabShutDownTimer.Controls.Add(Me.timer)
        Me.TabShutDownTimer.Controls.Add(Me.cbTimerType)
        Me.TabShutDownTimer.Controls.Add(Me.MetroLabel17)
        Me.TabShutDownTimer.Controls.Add(Me.MetroLabel18)
        Me.TabShutDownTimer.Controls.Add(Me.MetroLabel19)
        Me.TabShutDownTimer.Controls.Add(Me.cb_in_seconds)
        Me.TabShutDownTimer.Controls.Add(Me.cb_in_minutes)
        Me.TabShutDownTimer.Controls.Add(Me.cb_in_hours)
        Me.TabShutDownTimer.Controls.Add(Me.btnStopTimer)
        Me.TabShutDownTimer.Controls.Add(Me.lblSeconds)
        Me.TabShutDownTimer.Controls.Add(Me.lblMinutes)
        Me.TabShutDownTimer.Controls.Add(Me.lblHours)
        Me.TabShutDownTimer.Controls.Add(Me.MetroLabel1)
        Me.TabShutDownTimer.Controls.Add(Me.btnStartTimerInTime)
        Me.TabShutDownTimer.Controls.Add(Me.shutdownProgressBar)
        Me.TabShutDownTimer.Controls.Add(Me.btnDateTimeChange)
        Me.TabShutDownTimer.Controls.Add(Me.lblDateTime)
        Me.TabShutDownTimer.Controls.Add(Me.currTime)
        Me.TabShutDownTimer.HorizontalScrollbarBarColor = True
        Me.TabShutDownTimer.HorizontalScrollbarHighlightOnWheel = False
        Me.TabShutDownTimer.HorizontalScrollbarSize = 8
        Me.TabShutDownTimer.Location = New System.Drawing.Point(4, 38)
        Me.TabShutDownTimer.Margin = New System.Windows.Forms.Padding(2)
        Me.TabShutDownTimer.Name = "TabShutDownTimer"
        Me.TabShutDownTimer.Size = New System.Drawing.Size(792, 339)
        Me.TabShutDownTimer.TabIndex = 0
        Me.TabShutDownTimer.Text = "Timers"
        Me.TabShutDownTimer.VerticalScrollbarBarColor = True
        Me.TabShutDownTimer.VerticalScrollbarHighlightOnWheel = False
        Me.TabShutDownTimer.VerticalScrollbarSize = 8
        '
        'timer
        '
        Me.timer.AutoSize = True
        Me.timer.Location = New System.Drawing.Point(0, 110)
        Me.timer.Name = "timer"
        Me.timer.Size = New System.Drawing.Size(153, 19)
        Me.timer.TabIndex = 41
        Me.timer.Text = "Please Select Timer Type"
        '
        'cbTimerType
        '
        Me.cbTimerType.FormattingEnabled = True
        Me.cbTimerType.ItemHeight = 23
        Me.cbTimerType.Items.AddRange(New Object() {"Shutdown Timer", "Sleep Timer", "Hibernate Timer", "Logoff Timer", "Reboot Timer"})
        Me.cbTimerType.Location = New System.Drawing.Point(4, 135)
        Me.cbTimerType.Name = "cbTimerType"
        Me.cbTimerType.Size = New System.Drawing.Size(184, 29)
        Me.cbTimerType.TabIndex = 40
        Me.cbTimerType.UseSelectable = True
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(293, 197)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel17.TabIndex = 39
        Me.MetroLabel17.Text = "Second"
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.Location = New System.Drawing.Point(175, 197)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(49, 19)
        Me.MetroLabel18.TabIndex = 38
        Me.MetroLabel18.Text = "Minute"
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.Location = New System.Drawing.Point(63, 197)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(43, 19)
        Me.MetroLabel19.TabIndex = 37
        Me.MetroLabel19.Text = "Hours"
        '
        'cb_in_seconds
        '
        Me.cb_in_seconds.FormattingEnabled = True
        Me.cb_in_seconds.ItemHeight = 23
        Me.cb_in_seconds.Items.AddRange(New Object() {"00", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cb_in_seconds.Location = New System.Drawing.Point(233, 191)
        Me.cb_in_seconds.Name = "cb_in_seconds"
        Me.cb_in_seconds.PromptText = "00"
        Me.cb_in_seconds.Size = New System.Drawing.Size(51, 29)
        Me.cb_in_seconds.TabIndex = 36
        Me.cb_in_seconds.UseSelectable = True
        '
        'cb_in_minutes
        '
        Me.cb_in_minutes.FormattingEnabled = True
        Me.cb_in_minutes.ItemHeight = 23
        Me.cb_in_minutes.Items.AddRange(New Object() {"00", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cb_in_minutes.Location = New System.Drawing.Point(115, 191)
        Me.cb_in_minutes.Name = "cb_in_minutes"
        Me.cb_in_minutes.PromptText = "00"
        Me.cb_in_minutes.Size = New System.Drawing.Size(51, 29)
        Me.cb_in_minutes.TabIndex = 35
        Me.cb_in_minutes.UseSelectable = True
        '
        'cb_in_hours
        '
        Me.cb_in_hours.FormattingEnabled = True
        Me.cb_in_hours.ItemHeight = 23
        Me.cb_in_hours.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cb_in_hours.Location = New System.Drawing.Point(3, 191)
        Me.cb_in_hours.Name = "cb_in_hours"
        Me.cb_in_hours.PromptText = "0"
        Me.cb_in_hours.Size = New System.Drawing.Size(51, 29)
        Me.cb_in_hours.TabIndex = 34
        Me.cb_in_hours.UseSelectable = True
        '
        'btnStopTimer
        '
        Me.btnStopTimer.Location = New System.Drawing.Point(694, 306)
        Me.btnStopTimer.Name = "btnStopTimer"
        Me.btnStopTimer.Size = New System.Drawing.Size(95, 23)
        Me.btnStopTimer.TabIndex = 22
        Me.btnStopTimer.Text = "Stop Timer"
        Me.btnStopTimer.UseSelectable = True
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Location = New System.Drawing.Point(316, 306)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(80, 19)
        Me.lblSeconds.TabIndex = 21
        Me.lblSeconds.Text = "Seconds: XX"
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Location = New System.Drawing.Point(233, 306)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(77, 19)
        Me.lblMinutes.TabIndex = 20
        Me.lblMinutes.Text = "Minutes: XX"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(161, 306)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(66, 19)
        Me.lblHours.TabIndex = 19
        Me.lblHours.Text = "Hours: XX"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 306)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(159, 19)
        Me.MetroLabel1.TabIndex = 17
        Me.MetroLabel1.Text = "Your PC will shut down in:"
        '
        'btnStartTimerInTime
        '
        Me.btnStartTimerInTime.Location = New System.Drawing.Point(3, 226)
        Me.btnStartTimerInTime.Name = "btnStartTimerInTime"
        Me.btnStartTimerInTime.Size = New System.Drawing.Size(185, 23)
        Me.btnStartTimerInTime.TabIndex = 15
        Me.btnStartTimerInTime.Text = "Start Timer"
        Me.btnStartTimerInTime.UseSelectable = True
        '
        'shutdownProgressBar
        '
        Me.shutdownProgressBar.Location = New System.Drawing.Point(3, 279)
        Me.shutdownProgressBar.Name = "shutdownProgressBar"
        Me.shutdownProgressBar.Size = New System.Drawing.Size(786, 23)
        Me.shutdownProgressBar.Step = 1
        Me.shutdownProgressBar.TabIndex = 9
        '
        'btnDateTimeChange
        '
        Me.btnDateTimeChange.Location = New System.Drawing.Point(4, 61)
        Me.btnDateTimeChange.Name = "btnDateTimeChange"
        Me.btnDateTimeChange.Size = New System.Drawing.Size(184, 23)
        Me.btnDateTimeChange.TabIndex = 6
        Me.btnDateTimeChange.Text = "Change Date and Time"
        Me.btnDateTimeChange.UseSelectable = True
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblDateTime.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblDateTime.Location = New System.Drawing.Point(3, 32)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(180, 25)
        Me.lblDateTime.TabIndex = 5
        Me.lblDateTime.Text = "XXXXXXXXXXXXXX"
        '
        'currTime
        '
        Me.currTime.AutoSize = True
        Me.currTime.Location = New System.Drawing.Point(0, 13)
        Me.currTime.Name = "currTime"
        Me.currTime.Size = New System.Drawing.Size(143, 19)
        Me.currTime.TabIndex = 2
        Me.currTime.Text = "Current Date and Time"
        '
        'TabShortcutCreator
        '
        Me.TabShortcutCreator.Controls.Add(Me.shCut)
        Me.TabShortcutCreator.Controls.Add(Me.MetroLabel12)
        Me.TabShortcutCreator.Controls.Add(Me.btnShort)
        Me.TabShortcutCreator.Controls.Add(Me.filePath)
        Me.TabShortcutCreator.Controls.Add(Me.MetroButton1)
        Me.TabShortcutCreator.Controls.Add(Me.MetroLabel11)
        Me.TabShortcutCreator.Controls.Add(Me.destPath)
        Me.TabShortcutCreator.Controls.Add(Me.btnBrowse)
        Me.TabShortcutCreator.Controls.Add(Me.pathLbl)
        Me.TabShortcutCreator.Controls.Add(Me.MetroLabel3)
        Me.TabShortcutCreator.HorizontalScrollbarBarColor = True
        Me.TabShortcutCreator.HorizontalScrollbarHighlightOnWheel = False
        Me.TabShortcutCreator.HorizontalScrollbarSize = 10
        Me.TabShortcutCreator.Location = New System.Drawing.Point(4, 38)
        Me.TabShortcutCreator.Name = "TabShortcutCreator"
        Me.TabShortcutCreator.Size = New System.Drawing.Size(792, 339)
        Me.TabShortcutCreator.TabIndex = 2
        Me.TabShortcutCreator.Text = "Shortcut Creator"
        Me.TabShortcutCreator.VerticalScrollbarBarColor = True
        Me.TabShortcutCreator.VerticalScrollbarHighlightOnWheel = False
        Me.TabShortcutCreator.VerticalScrollbarSize = 10
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(182, 133)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(180, 19)
        Me.MetroLabel12.TabIndex = 15
        Me.MetroLabel12.Text = "Default destination is Desktop"
        '
        'btnShort
        '
        Me.btnShort.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnShort.Location = New System.Drawing.Point(262, 232)
        Me.btnShort.Name = "btnShort"
        Me.btnShort.Size = New System.Drawing.Size(210, 45)
        Me.btnShort.TabIndex = 14
        Me.btnShort.Text = "Create Shortcut"
        Me.btnShort.UseSelectable = True
        '
        'filePath
        '
        Me.filePath.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.filePath.Lines = New String(-1) {}
        Me.filePath.Location = New System.Drawing.Point(182, 107)
        Me.filePath.MaxLength = 32767
        Me.filePath.Name = "filePath"
        Me.filePath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.filePath.ReadOnly = True
        Me.filePath.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.filePath.SelectedText = ""
        Me.filePath.Size = New System.Drawing.Size(292, 23)
        Me.filePath.TabIndex = 13
        Me.filePath.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(480, 107)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(88, 23)
        Me.MetroButton1.TabIndex = 12
        Me.MetroButton1.Text = "Browse"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel11.Location = New System.Drawing.Point(182, 79)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(255, 25)
        Me.MetroLabel11.TabIndex = 11
        Me.MetroLabel11.Text = "Select a destination for shortcut:"
        '
        'destPath
        '
        Me.destPath.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.destPath.Lines = New String(-1) {}
        Me.destPath.Location = New System.Drawing.Point(182, 191)
        Me.destPath.MaxLength = 32767
        Me.destPath.Name = "destPath"
        Me.destPath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.destPath.ReadOnly = True
        Me.destPath.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.destPath.SelectedText = ""
        Me.destPath.Size = New System.Drawing.Size(292, 23)
        Me.destPath.TabIndex = 10
        Me.destPath.UseSelectable = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(480, 191)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(88, 23)
        Me.btnBrowse.TabIndex = 9
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseSelectable = True
        '
        'pathLbl
        '
        Me.pathLbl.AutoSize = True
        Me.pathLbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.pathLbl.Location = New System.Drawing.Point(182, 163)
        Me.pathLbl.Name = "pathLbl"
        Me.pathLbl.Size = New System.Drawing.Size(223, 50)
        Me.pathLbl.TabIndex = 8
        Me.pathLbl.Text = "Select a file for the shortcut:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel3.Location = New System.Drawing.Point(309, 11)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(128, 25)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Shortcut Maker"
        '
        'TabMoreTools
        '
        Me.TabMoreTools.Controls.Add(Me.tileChangePassword)
        Me.TabMoreTools.Controls.Add(Me.tileInfo)
        Me.TabMoreTools.Controls.Add(Me.tileIpConfig)
        Me.TabMoreTools.Controls.Add(Me.tileTaskManager)
        Me.TabMoreTools.Controls.Add(Me.tileWallpaper)
        Me.TabMoreTools.HorizontalScrollbarBarColor = True
        Me.TabMoreTools.HorizontalScrollbarHighlightOnWheel = False
        Me.TabMoreTools.HorizontalScrollbarSize = 10
        Me.TabMoreTools.Location = New System.Drawing.Point(4, 38)
        Me.TabMoreTools.Name = "TabMoreTools"
        Me.TabMoreTools.Size = New System.Drawing.Size(792, 339)
        Me.TabMoreTools.TabIndex = 1
        Me.TabMoreTools.Text = "Useful Tools"
        Me.TabMoreTools.VerticalScrollbarBarColor = True
        Me.TabMoreTools.VerticalScrollbarHighlightOnWheel = False
        Me.TabMoreTools.VerticalScrollbarSize = 10
        '
        'tileChangePassword
        '
        Me.tileChangePassword.ActiveControl = Nothing
        Me.tileChangePassword.Location = New System.Drawing.Point(128, 122)
        Me.tileChangePassword.Name = "tileChangePassword"
        Me.tileChangePassword.Size = New System.Drawing.Size(90, 90)
        Me.tileChangePassword.TabIndex = 11
        Me.tileChangePassword.Text = "Change" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        Me.tileChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tileChangePassword.UseSelectable = True
        '
        'tileInfo
        '
        Me.tileInfo.ActiveControl = Nothing
        Me.tileInfo.Location = New System.Drawing.Point(128, 26)
        Me.tileInfo.Name = "tileInfo"
        Me.tileInfo.Size = New System.Drawing.Size(90, 90)
        Me.tileInfo.TabIndex = 10
        Me.tileInfo.Text = "System " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Information"
        Me.tileInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tileInfo.UseSelectable = True
        '
        'tileIpConfig
        '
        Me.tileIpConfig.ActiveControl = Nothing
        Me.tileIpConfig.Location = New System.Drawing.Point(32, 218)
        Me.tileIpConfig.Name = "tileIpConfig"
        Me.tileIpConfig.Size = New System.Drawing.Size(90, 90)
        Me.tileIpConfig.TabIndex = 9
        Me.tileIpConfig.Text = "IP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Config"
        Me.tileIpConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tileIpConfig.UseSelectable = True
        '
        'tileTaskManager
        '
        Me.tileTaskManager.ActiveControl = Nothing
        Me.tileTaskManager.Location = New System.Drawing.Point(32, 122)
        Me.tileTaskManager.Name = "tileTaskManager"
        Me.tileTaskManager.Size = New System.Drawing.Size(90, 90)
        Me.tileTaskManager.TabIndex = 8
        Me.tileTaskManager.Text = "Task " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Manager"
        Me.tileTaskManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tileTaskManager.UseSelectable = True
        '
        'tileWallpaper
        '
        Me.tileWallpaper.ActiveControl = Nothing
        Me.tileWallpaper.Location = New System.Drawing.Point(32, 26)
        Me.tileWallpaper.Name = "tileWallpaper"
        Me.tileWallpaper.Size = New System.Drawing.Size(90, 90)
        Me.tileWallpaper.TabIndex = 7
        Me.tileWallpaper.Text = "Change" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wallpaper"
        Me.tileWallpaper.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tileWallpaper.UseSelectable = True
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'shCut
        '
        Me.shCut.AutoSize = True
        Me.shCut.Location = New System.Drawing.Point(309, 280)
        Me.shCut.Name = "shCut"
        Me.shCut.Size = New System.Drawing.Size(112, 19)
        Me.shCut.TabIndex = 16
        Me.shCut.Text = "Shortcut Created."
        Me.shCut.Visible = False
        '
        'winToolFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 459)
        Me.Controls.Add(Me.lblSettings)
        Me.Controls.Add(Me.lblTools)
        Me.Controls.Add(Me.lblHome)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.toolsTab)
        Me.Controls.Add(Me.homeTab)
        Me.Controls.Add(Me.settingsTab)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "winToolFrm"
        Me.Padding = New System.Windows.Forms.Padding(15, 60, 15, 16)
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.Text = "Windows ToolBox"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        CType(Me.MetroStyleManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.homeTab.ResumeLayout(False)
        Me.TabBasicSystemInfo.ResumeLayout(False)
        Me.TabBasicSystemInfo.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDetailedSystemInfo.ResumeLayout(False)
        Me.TabDetailedSystemInfo.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.settingsTab.ResumeLayout(False)
        Me.tabProgramSettings.ResumeLayout(False)
        Me.tabProgramSettings.PerformLayout()
        Me.tabAbout.ResumeLayout(False)
        Me.tabAbout.PerformLayout()
        Me.toolsTab.ResumeLayout(False)
        Me.TabShutDownTimer.ResumeLayout(False)
        Me.TabShutDownTimer.PerformLayout()
        Me.TabShortcutCreator.ResumeLayout(False)
        Me.TabShortcutCreator.PerformLayout()
        Me.TabMoreTools.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblHome As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTools As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSettings As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroStyleManager As MetroFramework.Components.MetroStyleManager
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents homeTab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabBasicSystemInfo As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnWindowsKey As MetroFramework.Controls.MetroButton
    Friend WithEvents idText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblUsername As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblOsVersion As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblOS As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPcName As MetroFramework.Controls.MetroLabel
    Friend WithEvents TabDetailedSystemInfo As MetroFramework.Controls.MetroTabPage
    Friend WithEvents lblAvailablePhysicalMemory As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTotalPhysicalMemory As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblMotherboard As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblHarddrive As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTest As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblmoboManu As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCurrentClockSpeed As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblProcessor As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblProcessorCount As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblGraphicsCard As MetroFramework.Controls.MetroLabel
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents toolsTab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents TabShutDownTimer As MetroFramework.Controls.MetroTabPage
    Friend WithEvents timer As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbTimerType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cb_in_seconds As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cb_in_minutes As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cb_in_hours As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnStopTimer As MetroFramework.Controls.MetroButton
    Friend WithEvents lblSeconds As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblMinutes As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblHours As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnStartTimerInTime As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDateTimeChange As MetroFramework.Controls.MetroButton
    Friend WithEvents lblDateTime As MetroFramework.Controls.MetroLabel
    Friend WithEvents currTime As MetroFramework.Controls.MetroLabel
    Friend WithEvents TabMoreTools As MetroFramework.Controls.MetroTabPage
    Friend WithEvents settingsTab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabProgramSettings As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents colorDrop As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblTheme As MetroFramework.Controls.MetroLabel
    Friend WithEvents themeDrop As MetroFramework.Controls.MetroComboBox
    Friend WithEvents tabAbout As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tileWallpaper As MetroFramework.Controls.MetroTile
    Friend WithEvents tileChangePassword As MetroFramework.Controls.MetroTile
    Friend WithEvents tileInfo As MetroFramework.Controls.MetroTile
    Friend WithEvents tileIpConfig As MetroFramework.Controls.MetroTile
    Friend WithEvents tileTaskManager As MetroFramework.Controls.MetroTile
    Friend WithEvents TabShortcutCreator As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnShort As MetroFramework.Controls.MetroButton
    Friend WithEvents filePath As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents destPath As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnBrowse As MetroFramework.Controls.MetroButton
    Friend WithEvents pathLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents shutdownProgressBar As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents shCut As MetroFramework.Controls.MetroLabel
End Class
