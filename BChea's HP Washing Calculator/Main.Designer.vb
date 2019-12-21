<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnNext = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDisclaimer = New System.Windows.Forms.Label()
        Me.grpClass = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.radOther5 = New System.Windows.Forms.RadioButton()
        Me.radWarrior = New System.Windows.Forms.RadioButton()
        Me.grpOther2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.radOther3 = New System.Windows.Forms.RadioButton()
        Me.grpThiefJob = New System.Windows.Forms.GroupBox()
        Me.radOther1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.radNightLord = New System.Windows.Forms.RadioButton()
        Me.radPirate = New System.Windows.Forms.RadioButton()
        Me.radThief = New System.Windows.Forms.RadioButton()
        Me.picThief = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.grpClass.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpOther2.SuspendLayout()
        Me.grpThiefJob.SuspendLayout()
        CType(Me.picThief, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Perpetua", 14.25!)
        Me.btnNext.Location = New System.Drawing.Point(709, 432)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(103, 37)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next Page"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(824, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(93, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuAbout.Text = "About"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Ravie", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(180, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(610, 39)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "BChea's HP Washing Calculator"
        '
        'lblDisclaimer
        '
        Me.lblDisclaimer.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisclaimer.Location = New System.Drawing.Point(242, 97)
        Me.lblDisclaimer.Name = "lblDisclaimer"
        Me.lblDisclaimer.Size = New System.Drawing.Size(488, 142)
        Me.lblDisclaimer.TabIndex = 4
        Me.lblDisclaimer.Text = resources.GetString("lblDisclaimer.Text")
        '
        'grpClass
        '
        Me.grpClass.Controls.Add(Me.GroupBox1)
        Me.grpClass.Controls.Add(Me.radWarrior)
        Me.grpClass.Controls.Add(Me.grpOther2)
        Me.grpClass.Controls.Add(Me.grpThiefJob)
        Me.grpClass.Controls.Add(Me.radPirate)
        Me.grpClass.Controls.Add(Me.radThief)
        Me.grpClass.Font = New System.Drawing.Font("Perpetua", 14.25!)
        Me.grpClass.Location = New System.Drawing.Point(187, 242)
        Me.grpClass.Name = "grpClass"
        Me.grpClass.Size = New System.Drawing.Size(603, 184)
        Me.grpClass.TabIndex = 5
        Me.grpClass.TabStop = False
        Me.grpClass.Text = "Select your Class!"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.radOther5)
        Me.GroupBox1.Font = New System.Drawing.Font("Perpetua", 14.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(442, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 115)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "4th Job"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Location = New System.Drawing.Point(267, 32)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(123, 26)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Coming Soon"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'radOther5
        '
        Me.radOther5.AutoSize = True
        Me.radOther5.Enabled = False
        Me.radOther5.Location = New System.Drawing.Point(17, 32)
        Me.radOther5.Name = "radOther5"
        Me.radOther5.Size = New System.Drawing.Size(123, 26)
        Me.radOther5.TabIndex = 0
        Me.radOther5.TabStop = True
        Me.radOther5.Text = "Coming Soon"
        Me.radOther5.UseVisualStyleBackColor = True
        '
        'radWarrior
        '
        Me.radWarrior.AutoSize = True
        Me.radWarrior.Location = New System.Drawing.Point(442, 32)
        Me.radWarrior.Name = "radWarrior"
        Me.radWarrior.Size = New System.Drawing.Size(86, 26)
        Me.radWarrior.TabIndex = 8
        Me.radWarrior.TabStop = True
        Me.radWarrior.Text = "Warrior"
        Me.radWarrior.UseVisualStyleBackColor = True
        '
        'grpOther2
        '
        Me.grpOther2.Controls.Add(Me.RadioButton3)
        Me.grpOther2.Controls.Add(Me.radOther3)
        Me.grpOther2.Font = New System.Drawing.Font("Perpetua", 14.25!)
        Me.grpOther2.Location = New System.Drawing.Point(230, 63)
        Me.grpOther2.Name = "grpOther2"
        Me.grpOther2.Size = New System.Drawing.Size(146, 115)
        Me.grpOther2.TabIndex = 7
        Me.grpOther2.TabStop = False
        Me.grpOther2.Text = "4th Job"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Enabled = False
        Me.RadioButton3.Location = New System.Drawing.Point(267, 32)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(123, 26)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Coming Soon"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'radOther3
        '
        Me.radOther3.AutoSize = True
        Me.radOther3.Enabled = False
        Me.radOther3.Location = New System.Drawing.Point(17, 32)
        Me.radOther3.Name = "radOther3"
        Me.radOther3.Size = New System.Drawing.Size(123, 26)
        Me.radOther3.TabIndex = 0
        Me.radOther3.TabStop = True
        Me.radOther3.Text = "Coming Soon"
        Me.radOther3.UseVisualStyleBackColor = True
        '
        'grpThiefJob
        '
        Me.grpThiefJob.Controls.Add(Me.radOther1)
        Me.grpThiefJob.Controls.Add(Me.RadioButton1)
        Me.grpThiefJob.Controls.Add(Me.radNightLord)
        Me.grpThiefJob.Font = New System.Drawing.Font("Perpetua", 14.25!)
        Me.grpThiefJob.Location = New System.Drawing.Point(17, 63)
        Me.grpThiefJob.Name = "grpThiefJob"
        Me.grpThiefJob.Size = New System.Drawing.Size(146, 115)
        Me.grpThiefJob.TabIndex = 6
        Me.grpThiefJob.TabStop = False
        Me.grpThiefJob.Text = "4th Job"
        '
        'radOther1
        '
        Me.radOther1.AutoSize = True
        Me.radOther1.Enabled = False
        Me.radOther1.Location = New System.Drawing.Point(17, 64)
        Me.radOther1.Name = "radOther1"
        Me.radOther1.Size = New System.Drawing.Size(123, 26)
        Me.radOther1.TabIndex = 3
        Me.radOther1.TabStop = True
        Me.radOther1.Text = "Coming Soon"
        Me.radOther1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Location = New System.Drawing.Point(267, 32)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(123, 26)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Coming Soon"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'radNightLord
        '
        Me.radNightLord.AutoSize = True
        Me.radNightLord.Enabled = False
        Me.radNightLord.Location = New System.Drawing.Point(17, 32)
        Me.radNightLord.Name = "radNightLord"
        Me.radNightLord.Size = New System.Drawing.Size(106, 26)
        Me.radNightLord.TabIndex = 0
        Me.radNightLord.TabStop = True
        Me.radNightLord.Text = "Night Lord"
        Me.radNightLord.UseVisualStyleBackColor = True
        '
        'radPirate
        '
        Me.radPirate.AutoSize = True
        Me.radPirate.Location = New System.Drawing.Point(230, 32)
        Me.radPirate.Name = "radPirate"
        Me.radPirate.Size = New System.Drawing.Size(70, 26)
        Me.radPirate.TabIndex = 2
        Me.radPirate.TabStop = True
        Me.radPirate.Text = "Pirate"
        Me.radPirate.UseVisualStyleBackColor = True
        '
        'radThief
        '
        Me.radThief.AutoSize = True
        Me.radThief.Location = New System.Drawing.Point(17, 32)
        Me.radThief.Name = "radThief"
        Me.radThief.Size = New System.Drawing.Size(64, 26)
        Me.radThief.TabIndex = 0
        Me.radThief.TabStop = True
        Me.radThief.Text = "Thief"
        Me.radThief.UseVisualStyleBackColor = True
        '
        'picThief
        '
        Me.picThief.Image = Global.BChea_s_HP_Washing_Calculator.My.Resources.Resources.MapleStory_Thief1
        Me.picThief.Location = New System.Drawing.Point(12, 27)
        Me.picThief.Name = "picThief"
        Me.picThief.Size = New System.Drawing.Size(142, 223)
        Me.picThief.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picThief.TabIndex = 2
        Me.picThief.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ClientSize = New System.Drawing.Size(824, 481)
        Me.Controls.Add(Me.grpClass)
        Me.Controls.Add(Me.lblDisclaimer)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picThief)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BChea's HP Washing Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpClass.ResumeLayout(False)
        Me.grpClass.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpOther2.ResumeLayout(False)
        Me.grpOther2.PerformLayout()
        Me.grpThiefJob.ResumeLayout(False)
        Me.grpThiefJob.PerformLayout()
        CType(Me.picThief, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents picThief As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDisclaimer As Label
    Friend WithEvents grpClass As GroupBox
    Friend WithEvents radPirate As RadioButton
    Friend WithEvents radThief As RadioButton
    Friend WithEvents grpOther2 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents radOther3 As RadioButton
    Friend WithEvents grpThiefJob As GroupBox
    Friend WithEvents radOther1 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents radNightLord As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents radOther5 As RadioButton
    Friend WithEvents radWarrior As RadioButton
End Class
