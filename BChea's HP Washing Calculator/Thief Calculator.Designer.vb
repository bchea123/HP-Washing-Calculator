<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThiefCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThiefCalculator))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.txtMPLevels = New System.Windows.Forms.TextBox()
        Me.lblMPLevels = New System.Windows.Forms.Label()
        Me.lblMPWash = New System.Windows.Forms.Label()
        Me.radNo = New System.Windows.Forms.RadioButton()
        Me.radYes = New System.Windows.Forms.RadioButton()
        Me.txtEquipINT = New System.Windows.Forms.TextBox()
        Me.lblEquipINT = New System.Windows.Forms.Label()
        Me.txtCurrentINT = New System.Windows.Forms.TextBox()
        Me.lblCurrentINT = New System.Windows.Forms.Label()
        Me.txtCurrentMP = New System.Windows.Forms.TextBox()
        Me.lblCurrentMP = New System.Windows.Forms.Label()
        Me.txtCurrentHP = New System.Windows.Forms.TextBox()
        Me.lblCurrentHP = New System.Windows.Forms.Label()
        Me.txtWashUntil = New System.Windows.Forms.TextBox()
        Me.lblWashUntil = New System.Windows.Forms.Label()
        Me.txtCurrentLevel = New System.Windows.Forms.TextBox()
        Me.lblCurrentLevel = New System.Windows.Forms.Label()
        Me.grpWashable = New System.Windows.Forms.GroupBox()
        Me.lblTotalWashesOut = New System.Windows.Forms.Label()
        Me.lblProjectedMPOut = New System.Windows.Forms.Label()
        Me.lblProjectedHPOut = New System.Windows.Forms.Label()
        Me.lblWashedMPOut = New System.Windows.Forms.Label()
        Me.lblLevelMPOut = New System.Windows.Forms.Label()
        Me.lblLevelHPOut = New System.Windows.Forms.Label()
        Me.lblTotalWashes = New System.Windows.Forms.Label()
        Me.lblProjectedMP = New System.Windows.Forms.Label()
        Me.lblProjectedHP = New System.Windows.Forms.Label()
        Me.lblWashMP = New System.Windows.Forms.Label()
        Me.lblLevelMP = New System.Windows.Forms.Label()
        Me.lblLevelHP = New System.Windows.Forms.Label()
        Me.lblTotalHP = New System.Windows.Forms.Label()
        Me.lblTotalMP = New System.Windows.Forms.Label()
        Me.lblTotalHPOut = New System.Windows.Forms.Label()
        Me.lblTotalMPOut = New System.Windows.Forms.Label()
        Me.picThief = New System.Windows.Forms.PictureBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.grpInput.SuspendLayout()
        Me.grpWashable.SuspendLayout()
        CType(Me.picThief, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1236, 35)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(54, 29)
        Me.mnuFile.Text = "File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(141, 34)
        Me.mnuExit.Text = "Exit"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(65, 29)
        Me.mnuHelp.Text = "Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(164, 34)
        Me.mnuAbout.Text = "About"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Ravie", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(886, 332)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(337, 59)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Night Lord"
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Font = New System.Drawing.Font("Perpetua", 14.25!)
        Me.btnBack.Location = New System.Drawing.Point(18, 665)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(154, 57)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.btnCalculate)
        Me.grpInput.Controls.Add(Me.lblNote)
        Me.grpInput.Controls.Add(Me.txtMPLevels)
        Me.grpInput.Controls.Add(Me.lblMPLevels)
        Me.grpInput.Controls.Add(Me.lblMPWash)
        Me.grpInput.Controls.Add(Me.radNo)
        Me.grpInput.Controls.Add(Me.radYes)
        Me.grpInput.Controls.Add(Me.txtEquipINT)
        Me.grpInput.Controls.Add(Me.lblEquipINT)
        Me.grpInput.Controls.Add(Me.txtCurrentINT)
        Me.grpInput.Controls.Add(Me.lblCurrentINT)
        Me.grpInput.Controls.Add(Me.txtCurrentMP)
        Me.grpInput.Controls.Add(Me.lblCurrentMP)
        Me.grpInput.Controls.Add(Me.txtCurrentHP)
        Me.grpInput.Controls.Add(Me.lblCurrentHP)
        Me.grpInput.Controls.Add(Me.txtWashUntil)
        Me.grpInput.Controls.Add(Me.lblWashUntil)
        Me.grpInput.Controls.Add(Me.txtCurrentLevel)
        Me.grpInput.Controls.Add(Me.lblCurrentLevel)
        Me.grpInput.Font = New System.Drawing.Font("Perpetua", 14.25!)
        Me.grpInput.Location = New System.Drawing.Point(18, 58)
        Me.grpInput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpInput.Size = New System.Drawing.Size(860, 382)
        Me.grpInput.TabIndex = 7
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Character Information"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Perpetua", 14.25!)
        Me.btnCalculate.Location = New System.Drawing.Point(696, 315)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(154, 57)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Font = New System.Drawing.Font("Perpetua", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.Location = New System.Drawing.Point(496, 198)
        Me.lblNote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(365, 23)
        Me.lblNote.TabIndex = 17
        Me.lblNote.Text = "Note: There are 5 MP washes available per level."
        '
        'txtMPLevels
        '
        Me.txtMPLevels.Enabled = False
        Me.txtMPLevels.Location = New System.Drawing.Point(732, 138)
        Me.txtMPLevels.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMPLevels.Name = "txtMPLevels"
        Me.txtMPLevels.Size = New System.Drawing.Size(90, 40)
        Me.txtMPLevels.TabIndex = 9
        '
        'lblMPLevels
        '
        Me.lblMPLevels.AutoSize = True
        Me.lblMPLevels.Location = New System.Drawing.Point(508, 143)
        Me.lblMPLevels.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMPLevels.Name = "lblMPLevels"
        Me.lblMPLevels.Size = New System.Drawing.Size(213, 33)
        Me.lblMPLevels.TabIndex = 15
        Me.lblMPLevels.Text = "Number of Levels:"
        '
        'lblMPWash
        '
        Me.lblMPWash.AutoSize = True
        Me.lblMPWash.Location = New System.Drawing.Point(536, 37)
        Me.lblMPWash.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMPWash.Name = "lblMPWash"
        Me.lblMPWash.Size = New System.Drawing.Size(291, 33)
        Me.lblMPWash.TabIndex = 14
        Me.lblMPWash.Text = "Do you plan to MP Wash?"
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Checked = True
        Me.radNo.Location = New System.Drawing.Point(712, 75)
        Me.radNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(72, 37)
        Me.radNo.TabIndex = 8
        Me.radNo.TabStop = True
        Me.radNo.Text = "No"
        Me.radNo.UseVisualStyleBackColor = True
        '
        'radYes
        '
        Me.radYes.AutoSize = True
        Me.radYes.Location = New System.Drawing.Point(560, 75)
        Me.radYes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(77, 37)
        Me.radYes.TabIndex = 7
        Me.radYes.Text = "Yes"
        Me.radYes.UseVisualStyleBackColor = True
        '
        'txtEquipINT
        '
        Me.txtEquipINT.Location = New System.Drawing.Point(226, 309)
        Me.txtEquipINT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEquipINT.Name = "txtEquipINT"
        Me.txtEquipINT.Size = New System.Drawing.Size(90, 40)
        Me.txtEquipINT.TabIndex = 6
        '
        'lblEquipINT
        '
        Me.lblEquipINT.AutoSize = True
        Me.lblEquipINT.Location = New System.Drawing.Point(10, 314)
        Me.lblEquipINT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEquipINT.Name = "lblEquipINT"
        Me.lblEquipINT.Size = New System.Drawing.Size(188, 33)
        Me.lblEquipINT.TabIndex = 10
        Me.lblEquipINT.Text = "Equipment INT:"
        '
        'txtCurrentINT
        '
        Me.txtCurrentINT.Location = New System.Drawing.Point(226, 254)
        Me.txtCurrentINT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCurrentINT.Name = "txtCurrentINT"
        Me.txtCurrentINT.Size = New System.Drawing.Size(90, 40)
        Me.txtCurrentINT.TabIndex = 5
        '
        'lblCurrentINT
        '
        Me.lblCurrentINT.AutoSize = True
        Me.lblCurrentINT.Location = New System.Drawing.Point(10, 258)
        Me.lblCurrentINT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentINT.Name = "lblCurrentINT"
        Me.lblCurrentINT.Size = New System.Drawing.Size(120, 33)
        Me.lblCurrentINT.TabIndex = 8
        Me.lblCurrentINT.Text = "Raw INT:"
        '
        'txtCurrentMP
        '
        Me.txtCurrentMP.Location = New System.Drawing.Point(226, 198)
        Me.txtCurrentMP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCurrentMP.Name = "txtCurrentMP"
        Me.txtCurrentMP.Size = New System.Drawing.Size(205, 40)
        Me.txtCurrentMP.TabIndex = 4
        '
        'lblCurrentMP
        '
        Me.lblCurrentMP.AutoSize = True
        Me.lblCurrentMP.Location = New System.Drawing.Point(10, 203)
        Me.lblCurrentMP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentMP.Name = "lblCurrentMP"
        Me.lblCurrentMP.Size = New System.Drawing.Size(204, 33)
        Me.lblCurrentMP.TabIndex = 6
        Me.lblCurrentMP.Text = "Current Max MP:"
        '
        'txtCurrentHP
        '
        Me.txtCurrentHP.Location = New System.Drawing.Point(226, 143)
        Me.txtCurrentHP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCurrentHP.Name = "txtCurrentHP"
        Me.txtCurrentHP.Size = New System.Drawing.Size(205, 40)
        Me.txtCurrentHP.TabIndex = 3
        '
        'lblCurrentHP
        '
        Me.lblCurrentHP.AutoSize = True
        Me.lblCurrentHP.Location = New System.Drawing.Point(10, 148)
        Me.lblCurrentHP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentHP.Name = "lblCurrentHP"
        Me.lblCurrentHP.Size = New System.Drawing.Size(201, 33)
        Me.lblCurrentHP.TabIndex = 4
        Me.lblCurrentHP.Text = "Current Max HP:"
        '
        'txtWashUntil
        '
        Me.txtWashUntil.Location = New System.Drawing.Point(226, 91)
        Me.txtWashUntil.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtWashUntil.Name = "txtWashUntil"
        Me.txtWashUntil.Size = New System.Drawing.Size(90, 40)
        Me.txtWashUntil.TabIndex = 2
        '
        'lblWashUntil
        '
        Me.lblWashUntil.AutoSize = True
        Me.lblWashUntil.Location = New System.Drawing.Point(10, 95)
        Me.lblWashUntil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWashUntil.Name = "lblWashUntil"
        Me.lblWashUntil.Size = New System.Drawing.Size(209, 33)
        Me.lblWashUntil.TabIndex = 2
        Me.lblWashUntil.Text = "Wash Until Level:"
        '
        'txtCurrentLevel
        '
        Me.txtCurrentLevel.Location = New System.Drawing.Point(226, 40)
        Me.txtCurrentLevel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCurrentLevel.Name = "txtCurrentLevel"
        Me.txtCurrentLevel.Size = New System.Drawing.Size(90, 40)
        Me.txtCurrentLevel.TabIndex = 1
        '
        'lblCurrentLevel
        '
        Me.lblCurrentLevel.AutoSize = True
        Me.lblCurrentLevel.Location = New System.Drawing.Point(10, 45)
        Me.lblCurrentLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentLevel.Name = "lblCurrentLevel"
        Me.lblCurrentLevel.Size = New System.Drawing.Size(172, 33)
        Me.lblCurrentLevel.TabIndex = 0
        Me.lblCurrentLevel.Text = "Current Level:"
        '
        'grpWashable
        '
        Me.grpWashable.Controls.Add(Me.lblTotalWashesOut)
        Me.grpWashable.Controls.Add(Me.lblProjectedMPOut)
        Me.grpWashable.Controls.Add(Me.lblProjectedHPOut)
        Me.grpWashable.Controls.Add(Me.lblWashedMPOut)
        Me.grpWashable.Controls.Add(Me.lblLevelMPOut)
        Me.grpWashable.Controls.Add(Me.lblLevelHPOut)
        Me.grpWashable.Controls.Add(Me.lblTotalWashes)
        Me.grpWashable.Controls.Add(Me.lblProjectedMP)
        Me.grpWashable.Controls.Add(Me.lblProjectedHP)
        Me.grpWashable.Controls.Add(Me.lblWashMP)
        Me.grpWashable.Controls.Add(Me.lblLevelMP)
        Me.grpWashable.Controls.Add(Me.lblLevelHP)
        Me.grpWashable.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpWashable.Location = New System.Drawing.Point(18, 449)
        Me.grpWashable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpWashable.Name = "grpWashable"
        Me.grpWashable.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grpWashable.Size = New System.Drawing.Size(910, 206)
        Me.grpWashable.TabIndex = 8
        Me.grpWashable.TabStop = False
        Me.grpWashable.Text = "Washable Stats"
        '
        'lblTotalWashesOut
        '
        Me.lblTotalWashesOut.AutoSize = True
        Me.lblTotalWashesOut.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalWashesOut.Location = New System.Drawing.Point(688, 134)
        Me.lblTotalWashesOut.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalWashesOut.Name = "lblTotalWashesOut"
        Me.lblTotalWashesOut.Size = New System.Drawing.Size(162, 28)
        Me.lblTotalWashesOut.TabIndex = 33
        Me.lblTotalWashesOut.Text = "XXXXXXXXXX"
        Me.lblTotalWashesOut.Visible = False
        '
        'lblProjectedMPOut
        '
        Me.lblProjectedMPOut.AutoSize = True
        Me.lblProjectedMPOut.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectedMPOut.Location = New System.Drawing.Point(688, 86)
        Me.lblProjectedMPOut.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProjectedMPOut.Name = "lblProjectedMPOut"
        Me.lblProjectedMPOut.Size = New System.Drawing.Size(162, 28)
        Me.lblProjectedMPOut.TabIndex = 32
        Me.lblProjectedMPOut.Text = "XXXXXXXXXX"
        Me.lblProjectedMPOut.Visible = False
        '
        'lblProjectedHPOut
        '
        Me.lblProjectedHPOut.AutoSize = True
        Me.lblProjectedHPOut.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectedHPOut.Location = New System.Drawing.Point(688, 38)
        Me.lblProjectedHPOut.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProjectedHPOut.Name = "lblProjectedHPOut"
        Me.lblProjectedHPOut.Size = New System.Drawing.Size(162, 28)
        Me.lblProjectedHPOut.TabIndex = 31
        Me.lblProjectedHPOut.Text = "XXXXXXXXXX"
        Me.lblProjectedHPOut.Visible = False
        '
        'lblWashedMPOut
        '
        Me.lblWashedMPOut.AutoSize = True
        Me.lblWashedMPOut.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWashedMPOut.Location = New System.Drawing.Point(220, 134)
        Me.lblWashedMPOut.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWashedMPOut.Name = "lblWashedMPOut"
        Me.lblWashedMPOut.Size = New System.Drawing.Size(162, 28)
        Me.lblWashedMPOut.TabIndex = 30
        Me.lblWashedMPOut.Text = "XXXXXXXXXX"
        Me.lblWashedMPOut.Visible = False
        '
        'lblLevelMPOut
        '
        Me.lblLevelMPOut.AutoSize = True
        Me.lblLevelMPOut.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevelMPOut.Location = New System.Drawing.Point(220, 86)
        Me.lblLevelMPOut.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLevelMPOut.Name = "lblLevelMPOut"
        Me.lblLevelMPOut.Size = New System.Drawing.Size(162, 28)
        Me.lblLevelMPOut.TabIndex = 29
        Me.lblLevelMPOut.Text = "XXXXXXXXXX"
        Me.lblLevelMPOut.Visible = False
        '
        'lblLevelHPOut
        '
        Me.lblLevelHPOut.AutoSize = True
        Me.lblLevelHPOut.Font = New System.Drawing.Font("Perpetua", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevelHPOut.Location = New System.Drawing.Point(220, 38)
        Me.lblLevelHPOut.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLevelHPOut.Name = "lblLevelHPOut"
        Me.lblLevelHPOut.Size = New System.Drawing.Size(162, 28)
        Me.lblLevelHPOut.TabIndex = 28
        Me.lblLevelHPOut.Text = "XXXXXXXXXX"
        Me.lblLevelHPOut.Visible = False
        '
        'lblTotalWashes
        '
        Me.lblTotalWashes.AutoSize = True
        Me.lblTotalWashes.Location = New System.Drawing.Point(411, 134)
        Me.lblTotalWashes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalWashes.Name = "lblTotalWashes"
        Me.lblTotalWashes.Size = New System.Drawing.Size(225, 28)
        Me.lblTotalWashes.TabIndex = 23
        Me.lblTotalWashes.Text = "Total Washes Available:"
        '
        'lblProjectedMP
        '
        Me.lblProjectedMP.AutoSize = True
        Me.lblProjectedMP.Location = New System.Drawing.Point(411, 86)
        Me.lblProjectedMP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProjectedMP.Name = "lblProjectedMP"
        Me.lblProjectedMP.Size = New System.Drawing.Size(260, 28)
        Me.lblProjectedMP.TabIndex = 22
        Me.lblProjectedMP.Text = "Projected MP @ Level ___:"
        '
        'lblProjectedHP
        '
        Me.lblProjectedHP.AutoSize = True
        Me.lblProjectedHP.Location = New System.Drawing.Point(414, 38)
        Me.lblProjectedHP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProjectedHP.Name = "lblProjectedHP"
        Me.lblProjectedHP.Size = New System.Drawing.Size(257, 28)
        Me.lblProjectedHP.TabIndex = 21
        Me.lblProjectedHP.Text = "Projected HP @ Level ___:"
        '
        'lblWashMP
        '
        Me.lblWashMP.AutoSize = True
        Me.lblWashMP.Location = New System.Drawing.Point(10, 134)
        Me.lblWashMP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWashMP.Name = "lblWashMP"
        Me.lblWashMP.Size = New System.Drawing.Size(194, 28)
        Me.lblWashMP.TabIndex = 20
        Me.lblWashMP.Text = "Washed MP Gained:"
        '
        'lblLevelMP
        '
        Me.lblLevelMP.AutoSize = True
        Me.lblLevelMP.Location = New System.Drawing.Point(10, 86)
        Me.lblLevelMP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLevelMP.Name = "lblLevelMP"
        Me.lblLevelMP.Size = New System.Drawing.Size(201, 28)
        Me.lblLevelMP.TabIndex = 19
        Me.lblLevelMP.Text = "Level-up MP Gained:"
        '
        'lblLevelHP
        '
        Me.lblLevelHP.AutoSize = True
        Me.lblLevelHP.Location = New System.Drawing.Point(10, 38)
        Me.lblLevelHP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLevelHP.Name = "lblLevelHP"
        Me.lblLevelHP.Size = New System.Drawing.Size(198, 28)
        Me.lblLevelHP.TabIndex = 18
        Me.lblLevelHP.Text = "Level-up HP Gained:"
        '
        'lblTotalHP
        '
        Me.lblTotalHP.AutoSize = True
        Me.lblTotalHP.Font = New System.Drawing.Font("Perpetua", 14.25!)
        Me.lblTotalHP.Location = New System.Drawing.Point(969, 425)
        Me.lblTotalHP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalHP.Name = "lblTotalHP"
        Me.lblTotalHP.Size = New System.Drawing.Size(205, 33)
        Me.lblTotalHP.TabIndex = 24
        Me.lblTotalHP.Text = "Total HP @ ___:"
        '
        'lblTotalMP
        '
        Me.lblTotalMP.AutoSize = True
        Me.lblTotalMP.Font = New System.Drawing.Font("Perpetua", 14.25!)
        Me.lblTotalMP.Location = New System.Drawing.Point(969, 522)
        Me.lblTotalMP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalMP.Name = "lblTotalMP"
        Me.lblTotalMP.Size = New System.Drawing.Size(208, 33)
        Me.lblTotalMP.TabIndex = 25
        Me.lblTotalMP.Text = "Total MP @ ___:"
        '
        'lblTotalHPOut
        '
        Me.lblTotalHPOut.AutoSize = True
        Me.lblTotalHPOut.Font = New System.Drawing.Font("Perpetua", 14.25!)
        Me.lblTotalHPOut.ForeColor = System.Drawing.Color.Red
        Me.lblTotalHPOut.Location = New System.Drawing.Point(969, 458)
        Me.lblTotalHPOut.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalHPOut.Name = "lblTotalHPOut"
        Me.lblTotalHPOut.Size = New System.Drawing.Size(195, 33)
        Me.lblTotalHPOut.TabIndex = 26
        Me.lblTotalHPOut.Text = "XXXXXXXXXX"
        Me.lblTotalHPOut.Visible = False
        '
        'lblTotalMPOut
        '
        Me.lblTotalMPOut.AutoSize = True
        Me.lblTotalMPOut.Font = New System.Drawing.Font("Perpetua", 14.25!)
        Me.lblTotalMPOut.ForeColor = System.Drawing.Color.Blue
        Me.lblTotalMPOut.Location = New System.Drawing.Point(969, 555)
        Me.lblTotalMPOut.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalMPOut.Name = "lblTotalMPOut"
        Me.lblTotalMPOut.Size = New System.Drawing.Size(195, 33)
        Me.lblTotalMPOut.TabIndex = 27
        Me.lblTotalMPOut.Text = "XXXXXXXXXX"
        Me.lblTotalMPOut.Visible = False
        '
        'picThief
        '
        Me.picThief.Image = Global.BChea_s_HP_Washing_Calculator.My.Resources.Resources.NightWalker
        Me.picThief.Location = New System.Drawing.Point(918, 42)
        Me.picThief.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picThief.Name = "picThief"
        Me.picThief.Size = New System.Drawing.Size(267, 286)
        Me.picThief.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picThief.TabIndex = 3
        Me.picThief.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Perpetua", 14.25!)
        Me.btnClear.Location = New System.Drawing.Point(995, 643)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(154, 57)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmThiefCalculator
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(1236, 740)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTotalMPOut)
        Me.Controls.Add(Me.lblTotalHPOut)
        Me.Controls.Add(Me.lblTotalMP)
        Me.Controls.Add(Me.lblTotalHP)
        Me.Controls.Add(Me.grpWashable)
        Me.Controls.Add(Me.grpInput)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picThief)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmThiefCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BChea's HP Washing Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpWashable.ResumeLayout(False)
        Me.grpWashable.PerformLayout()
        CType(Me.picThief, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picThief As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents grpInput As GroupBox
    Friend WithEvents lblCurrentINT As Label
    Friend WithEvents txtCurrentMP As TextBox
    Friend WithEvents lblCurrentMP As Label
    Friend WithEvents txtCurrentHP As TextBox
    Friend WithEvents lblCurrentHP As Label
    Friend WithEvents txtWashUntil As TextBox
    Friend WithEvents lblWashUntil As Label
    Friend WithEvents txtCurrentLevel As TextBox
    Friend WithEvents lblCurrentLevel As Label
    Friend WithEvents lblMPWash As Label
    Friend WithEvents radNo As RadioButton
    Friend WithEvents radYes As RadioButton
    Friend WithEvents txtEquipINT As TextBox
    Friend WithEvents lblEquipINT As Label
    Friend WithEvents txtCurrentINT As TextBox
    Friend WithEvents lblNote As Label
    Friend WithEvents txtMPLevels As TextBox
    Friend WithEvents lblMPLevels As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents grpWashable As GroupBox
    Friend WithEvents lblTotalWashes As Label
    Friend WithEvents lblProjectedMP As Label
    Friend WithEvents lblProjectedHP As Label
    Friend WithEvents lblWashMP As Label
    Friend WithEvents lblLevelMP As Label
    Friend WithEvents lblLevelHP As Label
    Friend WithEvents lblTotalHP As Label
    Friend WithEvents lblTotalMP As Label
    Friend WithEvents lblTotalHPOut As Label
    Friend WithEvents lblTotalMPOut As Label
    Friend WithEvents lblLevelHPOut As Label
    Friend WithEvents lblTotalWashesOut As Label
    Friend WithEvents lblProjectedMPOut As Label
    Friend WithEvents lblProjectedHPOut As Label
    Friend WithEvents lblWashedMPOut As Label
    Friend WithEvents lblLevelMPOut As Label
    Friend WithEvents btnClear As Button
End Class
