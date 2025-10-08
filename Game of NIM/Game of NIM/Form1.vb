Public Class Form1
    'Global variable representing the number of stones
    Dim stones As Integer

    'Do not alter the lines below
    Dim g As Graphics
    Dim r As New Random

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets up the graphics
        g = Me.CreateGraphics

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'New Game button
        Label1.Hide() 'hides the Welcome label


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Player takes 1 stone
        If stones >= 1 Then
            stones = stones - 1
            updateStones()

            If stones = 0 Then
                'Game is over, player lost
                MsgBox("Player loses")
            End If
        Else
            MsgBox("Cannot take 1!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Player takes 2 stones
        If stones >= 2 Then
            stones = stones - 2
            updateStones()

            If stones = 0 Then
                'Game is over, player lost
                MsgBox("Player loses")
            End If
        Else
            MsgBox("Cannot take 2!")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Player takes 3 stones
        If stones >= 3 Then
            stones = stones - 3
            updateStones()

            If stones = 0 Then
                'Game is over, player lost
                MsgBox("Player loses")
            End If
        Else
            MsgBox("Cannot take 3!")
        End If

    End Sub

    Sub computerTurn()
        'Have computer pause to "think" before taking its turn
        System.Threading.Thread.Sleep(750) '750 = milliseconds to pause

        'Add your code below

    End Sub



    'Sub: updateStones
    'Parameters: none
    'Task: Draws circles on the screen representing the number
    '      of stones in the pile.
    Sub updateStones()
        'Do not alter this code
        g.Clear(Color.Black)
        Dim side As Integer = 40
        Dim x, y As Integer
        Dim max As Integer = 350
        Dim min As Integer = 10
        x = min
        y = Me.Height - 150
        For i = 1 To stones
            Dim greyValue As Integer = r.Next(100, 200)
            Dim c As Color = Color.FromArgb(greyValue, greyValue, greyValue)
            Dim b As Brush = New SolidBrush(c)

            g.FillEllipse(b, x, y, side, side)
            x += side
            If x > max Then
                max -= side / 2
                min += side / 2
                x = min
                y -= side - 6
            End If
        Next
    End Sub
End Class
