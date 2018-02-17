<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BootDisk
    Inherits MetroFramework.Forms.MetroForm

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
        Me.exitbtn = New MetroFramework.Controls.MetroButton()
        Me.createbtn = New MetroFramework.Controls.MetroButton()
        Me.isoLbl = New MetroFramework.Controls.MetroLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnBrowse = New MetroFramework.Controls.MetroButton()
        Me.drivelbl = New MetroFramework.Controls.MetroLabel()
        Me.driveBox = New MetroFramework.Controls.MetroComboBox()
        Me.fileText = New MetroFramework.Controls.MetroTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.isoBox = New MetroFramework.Controls.MetroComboBox()
        Me.isoLabel = New MetroFramework.Controls.MetroLabel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.spinwait = New MetroFramework.Controls.MetroProgressSpinner()
        Me.wait = New MetroFramework.Controls.MetroLabel()
        Me.helplbl = New MetroFramework.Controls.MetroLabel()
        Me.btnRestart = New MetroFramework.Controls.MetroButton()
        Me.createlbl = New MetroFramework.Controls.MetroLabel()
        Me.errorlbl = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'exitbtn
        '
        Me.exitbtn.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.exitbtn.Location = New System.Drawing.Point(23, 431)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(109, 41)
        Me.exitbtn.TabIndex = 0
        Me.exitbtn.Text = "Exit"
        Me.exitbtn.UseSelectable = True
        '
        'createbtn
        '
        Me.createbtn.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.createbtn.Location = New System.Drawing.Point(282, 431)
        Me.createbtn.Name = "createbtn"
        Me.createbtn.Size = New System.Drawing.Size(108, 41)
        Me.createbtn.TabIndex = 1
        Me.createbtn.Text = "Create"
        Me.createbtn.UseSelectable = True
        '
        'isoLbl
        '
        Me.isoLbl.AutoSize = True
        Me.isoLbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.isoLbl.Location = New System.Drawing.Point(23, 98)
        Me.isoLbl.Name = "isoLbl"
        Me.isoLbl.Size = New System.Drawing.Size(133, 25)
        Me.isoLbl.TabIndex = 2
        Me.isoLbl.Text = "Select a ISO file:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Select your ISO"
        Me.OpenFileDialog1.Filter = "ISO Files |*.iso"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(321, 126)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(88, 23)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseSelectable = True
        '
        'drivelbl
        '
        Me.drivelbl.AutoSize = True
        Me.drivelbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.drivelbl.Location = New System.Drawing.Point(23, 285)
        Me.drivelbl.Name = "drivelbl"
        Me.drivelbl.Size = New System.Drawing.Size(218, 25)
        Me.drivelbl.TabIndex = 5
        Me.drivelbl.Text = "Select a Drive for boot disk:"
        Me.drivelbl.Visible = False
        '
        'driveBox
        '
        Me.driveBox.FormattingEnabled = True
        Me.driveBox.ItemHeight = 23
        Me.driveBox.Location = New System.Drawing.Point(23, 313)
        Me.driveBox.Name = "driveBox"
        Me.driveBox.Size = New System.Drawing.Size(386, 29)
        Me.driveBox.TabIndex = 6
        Me.driveBox.UseSelectable = True
        Me.driveBox.Visible = False
        '
        'fileText
        '
        Me.fileText.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.fileText.Lines = New String(-1) {}
        Me.fileText.Location = New System.Drawing.Point(23, 126)
        Me.fileText.MaxLength = 32767
        Me.fileText.Name = "fileText"
        Me.fileText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.fileText.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.fileText.SelectedText = ""
        Me.fileText.Size = New System.Drawing.Size(292, 23)
        Me.fileText.TabIndex = 7
        Me.fileText.UseSelectable = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'isoBox
        '
        Me.isoBox.FormattingEnabled = True
        Me.isoBox.ItemHeight = 23
        Me.isoBox.Location = New System.Drawing.Point(23, 248)
        Me.isoBox.Name = "isoBox"
        Me.isoBox.Size = New System.Drawing.Size(386, 29)
        Me.isoBox.TabIndex = 9
        Me.isoBox.UseSelectable = True
        Me.isoBox.Visible = False
        '
        'isoLabel
        '
        Me.isoLabel.AutoSize = True
        Me.isoLabel.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.isoLabel.Location = New System.Drawing.Point(23, 220)
        Me.isoLabel.Name = "isoLabel"
        Me.isoLabel.Size = New System.Drawing.Size(293, 25)
        Me.isoLabel.TabIndex = 8
        Me.isoLabel.Text = "Select which drive ISO is mounted to:"
        Me.isoLabel.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 6000
        '
        'spinwait
        '
        Me.spinwait.Location = New System.Drawing.Point(111, 266)
        Me.spinwait.Maximum = 100
        Me.spinwait.Name = "spinwait"
        Me.spinwait.Size = New System.Drawing.Size(53, 57)
        Me.spinwait.TabIndex = 10
        Me.spinwait.UseSelectable = True
        Me.spinwait.Visible = False
        '
        'wait
        '
        Me.wait.AutoSize = True
        Me.wait.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.wait.Location = New System.Drawing.Point(184, 280)
        Me.wait.Name = "wait"
        Me.wait.Size = New System.Drawing.Size(110, 25)
        Me.wait.TabIndex = 11
        Me.wait.Text = "Please Wait..."
        Me.wait.Visible = False
        '
        'helplbl
        '
        Me.helplbl.AutoSize = True
        Me.helplbl.Location = New System.Drawing.Point(23, 345)
        Me.helplbl.Name = "helplbl"
        Me.helplbl.Size = New System.Drawing.Size(338, 38)
        Me.helplbl.TabIndex = 12
        Me.helplbl.Text = "If no drives are shown make sure you have a removable " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "drive inserted."
        Me.helplbl.Visible = False
        '
        'btnRestart
        '
        Me.btnRestart.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.btnRestart.Location = New System.Drawing.Point(153, 431)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(108, 41)
        Me.btnRestart.TabIndex = 13
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseSelectable = True
        '
        'createlbl
        '
        Me.createlbl.AutoSize = True
        Me.createlbl.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.createlbl.Location = New System.Drawing.Point(115, 280)
        Me.createlbl.Name = "createlbl"
        Me.createlbl.Size = New System.Drawing.Size(179, 25)
        Me.createlbl.TabIndex = 14
        Me.createlbl.Text = "Creating Please Wait..."
        Me.createlbl.Visible = False
        '
        'errorlbl
        '
        Me.errorlbl.AutoSize = True
        Me.errorlbl.Location = New System.Drawing.Point(52, 305)
        Me.errorlbl.Name = "errorlbl"
        Me.errorlbl.Size = New System.Drawing.Size(309, 19)
        Me.errorlbl.TabIndex = 15
        Me.errorlbl.Text = "Do not exit the program, the disk is being created..."
        Me.errorlbl.Visible = False
        '
        'BootDisk
        '
        Me.AcceptButton = Me.createbtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 491)
        Me.Controls.Add(Me.errorlbl)
        Me.Controls.Add(Me.createlbl)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.helplbl)
        Me.Controls.Add(Me.wait)
        Me.Controls.Add(Me.spinwait)
        Me.Controls.Add(Me.isoBox)
        Me.Controls.Add(Me.isoLabel)
        Me.Controls.Add(Me.fileText)
        Me.Controls.Add(Me.driveBox)
        Me.Controls.Add(Me.drivelbl)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.isoLbl)
        Me.Controls.Add(Me.createbtn)
        Me.Controls.Add(Me.exitbtn)
        Me.Name = "BootDisk"
        Me.Style = MetroFramework.MetroColorStyle.[Default]
        Me.Text = "Boot Disk Manager"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitbtn As MetroFramework.Controls.MetroButton
    Friend WithEvents createbtn As MetroFramework.Controls.MetroButton
    Friend WithEvents isoLbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnBrowse As MetroFramework.Controls.MetroButton
    Friend WithEvents drivelbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents driveBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents fileText As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents isoBox As MetroFramework.Controls.MetroComboBox
    Friend WithEvents isoLabel As MetroFramework.Controls.MetroLabel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents spinwait As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents wait As MetroFramework.Controls.MetroLabel
    Friend WithEvents helplbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnRestart As MetroFramework.Controls.MetroButton
    Friend WithEvents createlbl As MetroFramework.Controls.MetroLabel
    Friend WithEvents errorlbl As MetroFramework.Controls.MetroLabel
End Class
