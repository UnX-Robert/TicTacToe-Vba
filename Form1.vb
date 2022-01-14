Public Class Form1

    Dim checker As Boolean
    Dim plusOne As Integer
    Dim currentPlayer As String
    Dim win As Boolean
    Dim Buttons As New Collection

    'Add buttons to collection\
    Sub CreateCollection()
        Buttons.Add(BtnTic1)
        Buttons.Add(BtnTic2)
        Buttons.Add(BtnTic3)
        Buttons.Add(BtnTic4)
        Buttons.Add(BtnTic5)
        Buttons.Add(BtnTic6)
        Buttons.Add(BtnTic7)
        Buttons.Add(BtnTic8)
        Buttons.Add(BtnTic9)
    End Sub

    Private Sub EnableFalse()
        For Each button In Buttons
            button.Enabled = False
        Next button
    End Sub

    Private Sub EnableTrue()
        For Each button In Buttons
            button.Enabled = True
        Next button
    End Sub

    Private Sub SetButtonText(ByRef button)
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
    End Sub

    Private Sub EndGame(ByRef btn1, ByRef btn2, ByRef btn3)
        btn1.BackColor = Color.Green
        btn2.BackColor = Color.Green
        btn3.BackColor = Color.Green
        Player.Text = "Player " & btn3.Text & " won!"
        MsgBox("Player " & btn3.Text & " won!")
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
            EndGame(BtnTic1, BtnTic2, BtnTic3)
            Return True

        ElseIf (BtnTic4.Text = BtnTic5.Text And BtnTic5.Text = BtnTic6.Text And BtnTic6.Text.Length <> 0) Then
            EndGame(BtnTic4, BtnTic5, BtnTic6)
            Return True

        ElseIf (BtnTic7.Text = BtnTic8.Text And BtnTic8.Text = BtnTic9.Text And BtnTic9.Text.Length <> 0) Then
            EndGame(BtnTic7, BtnTic8, BtnTic9)
            Return True

            ' Win on columns
        ElseIf (BtnTic1.Text = BtnTic4.Text And BtnTic4.Text = BtnTic7.Text And BtnTic7.Text.Length <> 0) Then
            EndGame(BtnTic1, BtnTic4, BtnTic7)
            Return True

        ElseIf (BtnTic2.Text = BtnTic5.Text And BtnTic5.Text = BtnTic8.Text And BtnTic8.Text.Length <> 0) Then
            EndGame(BtnTic2, BtnTic5, BtnTic8)
            Return True

        ElseIf (BtnTic3.Text = BtnTic6.Text And BtnTic6.Text = BtnTic9.Text And BtnTic9.Text.Length <> 0) Then
            EndGame(BtnTic3, BtnTic6, BtnTic9)
            Return True

            ' Win on principal
        ElseIf (BtnTic1.Text = BtnTic5.Text And BtnTic5.Text = BtnTic9.Text And BtnTic9.Text.Length <> 0) Then
            EndGame(BtnTic1, BtnTic5, BtnTic9)
            Return True

            ' Win on secondary
        ElseIf (BtnTic3.Text = BtnTic5.Text And BtnTic5.Text = BtnTic7.Text And BtnTic7.Text.Length <> 0) Then
            EndGame(BtnTic3, BtnTic5, BtnTic7)
            Return True

        ElseIf (BtnTic1.Text.Length <> 0 And BtnTic2.Text.Length <> 0 And BtnTic3.Text.Length <> 0 And BtnTic4.Text.Length <> 0 And
               BtnTic5.Text.Length <> 0 And BtnTic6.Text.Length <> 0 And BtnTic7.Text.Length <> 0 And BtnTic8.Text.Length <> 0 And BtnTic9.Text.Length <> 0) Then
            Player.Text = "Equal!"
            MsgBox("Equal!")
            Return True
        End If

        Return False
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
        For Each button In Buttons
            button.Text = ""
        Next button

        ' Set buttons color to Ivory
        For Each button In Buttons
            button.BackColor = Color.Ivory
        Next button

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateCollection()
    End Sub


End Class
