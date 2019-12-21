Public Class frmThiefCalculator
    'Formulas
    Dim intResult As Integer
    Function roundDown(rawINT, equipINT) As Integer 'Round down INT stat to nearest multiple of 10
        intResult = (rawINT + equipINT) - ((rawINT + equipINT) Mod 10)
        Return intResult
    End Function

    Function HPGain(currentLevel, washLevel) As Integer 'Total HP gained from user level to desired wash level
        intResult = (washLevel - currentLevel) * 22
        Return intResult
    End Function

    Function MPGain(currentLevel, washLevel, roundedINT) As Integer 'Total MP gained from user level to desired wash level
        intResult = (washLevel - currentLevel) * (15 + (roundedINT / 10))
        Return intResult
    End Function

    Function BWtotalMP(currentMP, MPGained, MPWashed) As Integer 'Projected total MP before wash
        intResult = currentMP + MPGained + MPWashed
        Return intResult
    End Function

    Function BWtotalHP(currentHP, HPGained) As Integer 'Projected total HP before wash
        intResult = currentHP + HPGained
        Return intResult
    End Function

    Function washableMP(BWtotalMP, washLevel) As Integer 'Total washable MP to convert into HP
        intResult = BWtotalMP - ((14 * washLevel) + 148)
        Return intResult
    End Function

    Function washedHP(washableMP) As Integer 'Total HP gained from wash
        Dim intTotalWashes As Integer = (washableMP - (washableMP Mod 12)) / 12
        intResult = intTotalWashes * 18
        Return intResult
    End Function

    Function washedMP(totalWashes) As Integer 'Total MP lost from wash
        intResult = totalWashes * 12
        Return intResult
    End Function

    Function PWtotalHP(BWtotalHP, washedHP) As Integer 'Projected total HP post wash
        intResult = BWtotalHP + washedHP
        Return intResult
    End Function

    Function PWtotalMP(BWtotalMP, washedMP) 'Projected total MP post wash
        intResult = BWtotalMP - washedMP
        Return intResult
    End Function

    Function MPWashed(MPWashCount, rawINT) As Integer 'MP Wash
        intResult = MPWashCount * (11 + ((rawINT - (rawINT Mod 10)) / 10))
        Return intResult
    End Function

    Dim boolCompute As Boolean = False

    'Input Variables
    Dim intCurrentLevel As Integer
    Dim intUntilLevel As Integer
    Dim intCurrentHP As Integer
    Dim intCurrentMP As Integer
    Dim intRawINT As Integer
    Dim intEquipmentINT As Integer
    Dim intNumMPWashes As Integer

    'Calculation Variables
    Dim intRoundedINT As Integer
    Dim intWashableMP As Integer
    Dim intWashedHP As Integer
    Dim intWashedMP As Integer
    Dim intPWtotalHP As Integer
    Dim intPWtotalMP As Integer

    'Output Variables
    Dim intLevelHPGained As Integer
    Dim intLevelMPGained As Integer
    Dim intMPWashed As Integer
    Dim intBWtotalHP As Integer
    Dim intBWtotalMP As Integer
    Dim intTotalWashes As Integer

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        frmMain.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub radYes_CheckedChanged(sender As Object, e As EventArgs) Handles radYes.CheckedChanged
        If radYes.Checked = True Then
            txtMPLevels.Enabled = True
        End If
    End Sub

    Private Sub radNo_CheckedChanged(sender As Object, e As EventArgs) Handles radNo.CheckedChanged
        If radNo.Checked = True Then
            txtMPLevels.Text = ""
            txtMPLevels.Enabled = False
        End If
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strCurrentLevel As String = txtCurrentLevel.Text
        Dim strUntilLevel As String = txtWashUntil.Text
        Dim strCurrentHP As String = txtCurrentHP.Text
        Dim strCurrentMP As String = txtCurrentMP.Text
        Dim strRawINT As String = txtCurrentINT.Text
        Dim strEquipmentINT As String = txtEquipINT.Text

        Try
            intCurrentLevel = Convert.ToInt16(strCurrentLevel)
            intUntilLevel = Convert.ToInt16(strUntilLevel)
            boolCompute = True
        Catch ex As FormatException
            MsgBox("Please input a valid character level!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation,
                       "Invalid Character Level")
            boolCompute = False
        End Try

        Try
            intCurrentHP = Convert.ToInt32(strCurrentHP)
            intCurrentMP = Convert.ToInt16(strCurrentMP)
            intRawINT = Convert.ToInt16(strRawINT)
            intEquipmentINT = Convert.ToInt16(strEquipmentINT)
            boolCompute = True
        Catch ex As FormatException
            MsgBox("Please input a positive integer number!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation,
                       "Invalid Input")
            boolCompute = False
        End Try

        intRoundedINT = roundDown(intRawINT, intEquipmentINT)

        If radYes.Checked = True Then
            Dim strNumMPWashes As String = txtMPLevels.Text
            Try
                intNumMPWashes = Convert.ToInt16(strNumMPWashes)
                boolCompute = True
            Catch ex As FormatException
                MsgBox("Please input a positive integer number!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation,
                           "Invalid Input")
                boolCompute = False
            End Try

            intMPWashed = Convert.ToInt16(MPWashed(intNumMPWashes * 5, intRawINT))
        Else
            intMPWashed = 0
        End If

        If boolCompute = True Then
            intLevelHPGained = HPGain(intCurrentLevel, intUntilLevel)
            intLevelMPGained = Convert.ToInt16(MPGain(intCurrentLevel, intUntilLevel, intRoundedINT))
            intBWtotalHP = BWtotalHP(intCurrentHP, intLevelHPGained)
            intBWtotalMP = Convert.ToInt16(BWtotalMP(intCurrentMP, intLevelMPGained, intMPWashed))
            intWashableMP = washableMP(intBWtotalMP, intUntilLevel)
            intTotalWashes = Convert.ToInt16((intWashableMP - (intWashableMP Mod 12)) / 12)
            intWashedHP = washedHP(intWashableMP)
            intWashedMP = washedMP(intTotalWashes)
            intPWtotalHP = Convert.ToInt16(PWtotalHP(intBWtotalHP, intWashedHP))
            intPWtotalMP = Convert.ToInt16(PWtotalMP(intBWtotalMP, intWashedMP))

            'Populate output
            lblTotalHP.Text = "Total HP @ " & intUntilLevel & ":"
            lblTotalMP.Text = "Total MP @ " & intUntilLevel & ":"
            lblProjectedHP.Text = "Projected HP @ Level " & intUntilLevel & ":"
            lblProjectedMP.Text = "Projected MP @ Level " & intUntilLevel & ":"
            lblLevelHPOut.Text = intLevelHPGained
            lblLevelMPOut.Text = intLevelMPGained
            lblWashedMPOut.Text = intMPWashed
            lblProjectedHPOut.Text = intBWtotalHP
            lblProjectedMPOut.Text = intBWtotalMP
            lblTotalWashesOut.Text = intTotalWashes

            lblTotalHPOut.Text = intPWtotalHP
            lblTotalMPOut.Text = intPWtotalMP

            'Make all output labels visible
            lblProjectedHP.Visible = True
            lblProjectedMP.Visible = True
            lblLevelHPOut.Visible = True
            lblLevelMPOut.Visible = True
            lblWashedMPOut.Visible = True
            lblProjectedHPOut.Visible = True
            lblProjectedMPOut.Visible = True
            lblTotalWashesOut.Visible = True

            lblTotalHPOut.Visible = True
            lblTotalMPOut.Visible = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all text fields
        txtCurrentLevel.Clear()
        txtWashUntil.Clear()
        txtCurrentHP.Clear()
        txtCurrentMP.Clear()
        txtCurrentINT.Clear()
        txtEquipINT.Clear()
        radNo.Checked = True
        txtMPLevels.Clear()

        'Make all output labels invisible
        lblLevelHPOut.Visible = False
        lblLevelMPOut.Visible = False
        lblWashedMPOut.Visible = False
        lblProjectedHPOut.Visible = False
        lblProjectedMPOut.Visible = False
        lblTotalWashesOut.Visible = False
        lblTotalHPOut.Visible = False
        lblTotalMPOut.Visible = False

        'Set focus to txtCurrentLevel
        txtCurrentLevel.Focus()
    End Sub
End Class