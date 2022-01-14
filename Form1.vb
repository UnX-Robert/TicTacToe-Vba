Public Class Form1

    Dim checker As Boolean
    Dim plusOne As Integer
    Dim currentPlayer As String
    Dim win As Boolean

    Private Sub EnableFalse()
        BtnTic1.Enabled = False
        BtnTic2.Enabled = False
        BtnTic3.Enabled = False
        BtnTic4.Enabled = False
        BtnTic5.Enabled = False
        BtnTic6.Enabled = False
        BtnTic7.Enabled = False
        BtnTic8.Enabled = False
        BtnTic9.Enabled = False
    End Sub

    Private Sub EnableTrue()
        BtnTic1.Enabled = True
        BtnTic2.Enabled = True
        BtnTic3.Enabled = True
        BtnTic4.Enabled = True
        BtnTic5.Enabled = True
        BtnTic6.Enabled = True
        BtnTic7.Enabled = True
        BtnTic8.Enabled = True
        BtnTic9.Enabled = True
    End Sub

    Private Sub IncreaseScore()
        If Player.Text = "Player X won!" Then
            XScore.Text = Convert.ToString(Convert.ToInt32(XScore.Text) + 1)
        ElseIf Player.Text = "Player O won!" Then
            OScore.Text = Convert.ToString(Convert.ToInt32(OScore.Text) + 1)
        End If

        EnableFalse()
    End Sub

    Private Function WinConditions() As Boolean
        ' Win on lines
        If (BtnTic1.Text = BtnTic2.Text And BtnTic2.Text = BtnTic3.Text And BtnTic3.Text.Length <> 0) Then
            BtnTic1.BackColor = Color.Green
            BtnTic2.BackColor = Color.Green
            BtnTic3.BackColor = Color.Green
            Player.Text = "Player " & BtnTic1.Text & " won!"
            MsgBox("Player " & BtnTic1.Text & " won!")
            Return True

        ElseIf (BtnTic4.Text = BtnTic5.Text And BtnTic5.Text = BtnTic6.Text And BtnTic6.Text.Length <> 0) Then
            BtnTic4.BackColor = Color.Green
            BtnTic5.BackColor = Color.Green
            BtnTic6.BackColor = Color.Green
            Player.Text = "Player " & BtnTic5.Text & " won!"
            MsgBox("Player " & BtnTic5.Text & " won!")
            Return True
        ElseIf (BtnTic7.Text = BtnTic8.Text And BtnTic8.Text = BtnTic9.Text And BtnTic9.Text.Length <> 0) Then
            BtnTic7.BackColor = Color.Green
            BtnTic8.BackColor = Color.Green
            BtnTic9.BackColor = Color.Green
            Player.Text = "Player " & BtnTic7.Text & " won!"
            MsgBox("Player " & BtnTic7.Text & " won!")
            Return True
            ' Win on columns
        ElseIf (BtnTic1.Text = BtnTic4.Text And BtnTic4.Text = BtnTic7.Text And BtnTic7.Text.Length <> 0) Then
            BtnTic1.BackColor = Color.Green
            BtnTic4.BackColor = Color.Green
            BtnTic7.BackColor = Color.Green
            Player.Text = "Player " & BtnTic1.Text & " won!"
            MsgBox("Player " & BtnTic1.Text & " won!")
            Return True
        ElseIf (BtnTic2.Text = BtnTic5.Text And BtnTic5.Text = BtnTic8.Text And BtnTic8.Text.Length <> 0) Then
            BtnTic2.BackColor = Color.Green
            BtnTic5.BackColor = Color.Green
            BtnTic8.BackColor = Color.Green
            Player.Text = "Player " & BtnTic2.Text & " won!"
            MsgBox("Player " & BtnTic2.Text & " won!")
            Return True
        ElseIf (BtnTic3.Text = BtnTic6.Text And BtnTic6.Text = BtnTic9.Text And BtnTic9.Text.Length <> 0) Then
            BtnTic3.BackColor = Color.Green
            BtnTic6.BackColor = Color.Green
            BtnTic9.BackColor = Color.Green
            Player.Text = "Player " & BtnTic3.Text & " won!"
            MsgBox("Player " & BtnTic3.Text & " won!")
            Return True
            ' Win on principal
        ElseIf (BtnTic1.Text = BtnTic5.Text And BtnTic5.Text = BtnTic9.Text And BtnTic9.Text.Length <> 0) Then
            BtnTic1.BackColor = Color.Green
            BtnTic5.BackColor = Color.Green
            BtnTic9.BackColor = Color.Green
            Player.Text = "Player " & BtnTic1.Text & " won!"
            MsgBox("Player " & BtnTic1.Text & " won!")
            ' Win on secondary
        ElseIf (BtnTic3.Text = BtnTic5.Text And BtnTic5.Text = BtnTic7.Text And BtnTic7.Text.Length <> 0) Then
            BtnTic3.BackColor = Color.Green
            BtnTic5.BackColor = Color.Green
            BtnTic7.BackColor = Color.Green
            Player.Text = "Player " & BtnTic3.Text & " won!"
            MsgBox("Player " & BtnTic3.Text & " won!")
            Return True
        ElseIf (BtnTic1.Text.Length <> 0 And BtnTic2.Text.Length <> 0 And BtnTic3.Text.Length <> 0 And BtnTic4.Text.Length <> 0 And
               BtnTic5.Text.Length <> 0 And BtnTic6.Text.Length <> 0 And BtnTic7.Text.Length <> 0 And BtnTic8.Text.Length <> 0 And BtnTic9.Text.Length <> 0) Then
            Player.Text = "Equal!"
            MsgBox("Equal!")
            Return True
        End If
    End Function

    ' Buttons on Play Panel
    Private Sub BtnTic1_Click(sender As Object, e As EventArgs) Handles BtnTic1.Click
        SetButtonText(BtnTic1)

        If WinConditions() Then
            IncreaseScore()
        End If
    End Sub

    Private Sub BtnTic2_Click(sender As Object, e As EventArgs) Handles BtnTic2.Click
        SetButtonText(BtnTic2)

        If WinConditions() Then
            IncreaseScore()
        End If
    End Sub

    Private Sub BtnTic3_Click(sender As Object, e As EventArgs) Handles BtnTic3.Click
        SetButtonText(BtnTic3)

        If WinConditions() Then
            IncreaseScore()
        End If
    End Sub

    Private Sub BtnTic4_Click(sender As Object, e As EventArgs) Handles BtnTic4.Click
        SetButtonText(BtnTic4)

        If WinConditions() Then
            IncreaseScore()
        End If

    End Sub

    Private Sub BtnTic5_Click(sender As Object, e As EventArgs) Handles BtnTic5.Click
        SetButtonText(BtnTic5)

        If WinConditions() Then
            IncreaseScore()
        End If
    End Sub

    Private Sub BtnTic6_Click(sender As Object, e As EventArgs) Handles BtnTic6.Click
        SetButtonText(BtnTic6)

        If WinConditions() Then
            IncreaseScore()
        End If
    End Sub

    Private Sub BtnTic7_Click(sender As Object, e As EventArgs) Handles BtnTic7.Click
        SetButtonText(BtnTic7)

        If WinConditions() Then
            IncreaseScore()
        End If
    End Sub

    Private Sub BtnTic8_Click(sender As Object, e As EventArgs) Handles BtnTic8.Click
        SetButtonText(BtnTic8)

        If WinConditions() Then
            IncreaseScore()
        End If
    End Sub

    Private Sub BtnTic9_Click(sender As Object, e As EventArgs) Handles BtnTic9.Click
        SetButtonText(BtnTic9)

        If WinConditions() Then
            IncreaseScore()
        End If
    End Sub

    Private Sub GameNew_Click(sender As Object, e As EventArgs) Handles GameNew.Click
        ' Set buttons to start state
        BtnTic1.Text = ""
        BtnTic2.Text = ""
        BtnTic3.Text = ""
        BtnTic4.Text = ""
        BtnTic5.Text = ""
        BtnTic6.Text = ""
        BtnTic7.Text = ""
        BtnTic8.Text = ""
        BtnTic9.Text = ""

        ' Set buttons color to Ivory
        BtnTic1.BackColor = Color.Ivory
        BtnTic2.BackColor = Color.Ivory
        BtnTic3.BackColor = Color.Ivory
        BtnTic4.BackColor = Color.Ivory
        BtnTic5.BackColor = Color.Ivory
        BtnTic6.BackColor = Color.Ivory
        BtnTic7.BackColor = Color.Ivory
        BtnTic8.BackColor = Color.Ivory
        BtnTic9.BackColor = Color.Ivory

        ' Reset turn
        Player.Text = "X Turn"

        ' Make buttons click true
        EnableTrue()
    End Sub

    Private Sub PlayExit_Click(sender As Object, e As EventArgs) Handles PlayExit.Click
        HomePanel.Visible = True
        Play.Visible = False
        About.Visible = False
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        XScore.Text = "0"
        OScore.Text = "0"
    End Sub

    ' Buttons on HomePanel

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        HomePanel.Visible = False
        Play.Visible = True
        About.Visible = False
    End Sub

    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        HomePanel.Visible = False
        Play.Visible = False
        About.Visible = True
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        HomePanel.Visible = True
        About.Visible = False
    End Sub

    Function SetButtonText(ByRef button)
        currentPlayer = Player.Text
        If button.Text = "X" Or button.Text = "O" Then
            MsgBox("Position is taken!")
        ElseIf currentPlayer = "X Turn" Then
            button.Text = "X"
            Player.Text = "O Turn"
        Else
            button.Text = "O"
            Player.Text = "X Turn"
        End If
    End Function

End Class
