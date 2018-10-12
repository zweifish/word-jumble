Public Class Form1
    Dim random As New Random
    Dim jumbleWord As String
    Dim correct As String
    Private words =
        New List(Of String) From {"linux", "jumble", "basic", "java", "javascript", "python",
        "snake", "xylophone", "commas", "answer"}

    Private Sub NewBTN_Click(sender As Object, e As EventArgs) Handles NewBTN.Click
        ResultLBL.Text = ""
        inputTXT.Text = ""
        Dim randomNumber = random.Next(words.count)
        jumbleWord = words(randomNumber)
        correct = jumbleWord
        rescramBTN.Enabled = True
        EnterBTN.Enabled = True

        Dim j As Integer
        Dim chars() As Char = jumbleWord.ToCharArray
        For i As Integer = 0 To jumbleWord.Length - 1
            j = random.Next(jumbleWord.Length)
            Dim t As Char = chars(i)
            chars(i) = chars(j)
            chars(j) = t
            jumbleWord = chars
        Next

        jumbleLBL.Text = jumbleWord

    End Sub

    Private Sub rescramBTN_Click(sender As Object, e As EventArgs) Handles rescramBTN.Click
        'make disabled by default until new game is pressed
        Dim j As Integer
        Dim chars() As Char = jumbleWord.ToCharArray
        For i As Integer = 0 To jumbleWord.Length - 1
            j = random.Next(jumbleWord.Length)
            Dim t As Char = chars(i)
            chars(i) = chars(j)
            chars(j) = t
            jumbleWord = chars
        Next

        jumbleLBL.Text = jumbleWord
    End Sub

    Private Sub EnterBTN_Click(sender As Object, e As EventArgs) Handles EnterBTN.Click
        Dim userGuess As String = inputTXT.Text.ToLower

        If userGuess = correct Then
            ResultLBL.Text = "Correct!!!" & vbCrLf & "Click =New Game= to play again!"
            rescramBTN.Enabled = False
            EnterBTN.Enabled = False


        Else
            ResultLBL.Text = "Nope. That's not it." & vbCrLf & "Please try again."
        End If
    End Sub
End Class
