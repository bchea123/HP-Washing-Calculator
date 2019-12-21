Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display splash screen for 3.5 seconds
        Threading.Thread.Sleep(3500)
    End Sub
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Make sure a class is selected, if not display error message
        If radNightLord.Checked = True Then
            Me.Hide()
            frmThiefCalculator.Show()
        ElseIf radNightLord.Checked = False Then
            MsgBox("Please select an available 4th Job!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "No 4th Job Selected")
        End If
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub radThief_CheckedChanged(sender As Object, e As EventArgs) Handles radThief.CheckedChanged
        If radThief.Checked = True Then
            radNightLord.Enabled = True
        Else
            radNightLord.Checked = False
            radNightLord.Enabled = False
        End If
    End Sub
End Class
