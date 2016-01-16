Public Class Form1
    Dim y As PictureBox
    Dim x As PictureBox
    Dim array(15) As Integer
    Dim secondarray(15) As Integer
    Dim firstcompare As Integer = -1
    Dim secondcompare As Integer = -1
    Dim score As Integer = 0
    Dim z As Integer
    Dim firstclick As Boolean = False
    Dim secondclick As Boolean = False
    Dim firstchange As PictureBox
    Dim secondchange As PictureBox
    Dim firstplayer As Boolean = True
    Dim secondplayer As Boolean = False
    Dim player2 As String
    Dim player1 As String
    Dim score1 As Integer
    Dim score2 As Integer
    Dim number As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True

        number = Val(InputBox("insert number of cards. Must be odd between 3 and 15"))
        If number > 15 Then
            MessageBox.Show("value must be less than 15")
            Exit Sub
        End If
        If IsNumeric(number) = False Then
            MessageBox.Show("value must be an integer")
            Exit Sub
        End If
        Dim numberindex(number - 1) As Integer
        Dim secondnumberindex(number - 1) As Integer

        If number = 2 Or number = 4 Or number = 6 Or number = 8 Or number = 10 Or number = 12 Or number = 14 Then
            MessageBox.Show("only odd numbers")
            Exit Sub
        End If
        If number = 0 Then
            MessageBox.Show("please insert a number greater than 3")
            Exit Sub
        End If

        player1 = InputBox("enter player1 name")
        player2 = InputBox("enter player2 name")

        Me.playername1.Text = player1
        Me.playername2.Text = player2

        MessageBox.Show(player1 & "begins first")

        Randomize()

        numberindex(0) = Int((number + 1) * Rnd())
        Label1.Text = numberindex(0)

        array(0) = numberindex(0)

        For x As Integer = 1 To (number - 1)
            Do Until Label1.Text.Contains(numberindex(x)) = False
                numberindex(x) = Int((number + 1) * Rnd())
                array(x) = numberindex(x)
            Loop
            Label1.Text &= " " & numberindex(x)
        Next

        secondnumberindex(0) = Int((((number - 1)) * Rnd()))
        secondarray(0) = numberindex(secondnumberindex(0))

        Label2.Text = secondnumberindex(0)
        Label3.Text = numberindex(secondnumberindex(0))


        For y As Integer = 1 To (number - 1)
            Do Until Label2.Text.Contains(secondnumberindex(y)) = False
                secondnumberindex(y) = Int((number - 1)) * Rnd()

            Loop
            Label2.Text &= " " & secondnumberindex(y)
            Label3.Text &= " " & numberindex(secondnumberindex(y))
            secondarray(y) = numberindex(secondnumberindex(y))
        Next

        Dim xaxis As Integer = 0
        Dim picturebox As PictureBox
        For picture = 0 To number - 1
            picturebox = New PictureBox
            picturebox.Location = New Point(xaxis, 0)
            picturebox.Name = "picturebox" & picture

            picturebox.Visible = True
            picturebox.SizeMode = PictureBoxSizeMode.AutoSize
            picturebox.Image = My.resources.back
            Controls.Add(picturebox)
            AddHandler picturebox.Click, AddressOf picturebox_Click
            xaxis = xaxis + 80

        Next


        Dim secondpicturebox As PictureBox
        Dim second As Integer = 0

        xaxis = 0
        For second = 1 To number
            secondpicturebox = New PictureBox
            secondpicturebox.Location = New Point(xaxis, 120)
            secondpicturebox.Name = "secondpicturebox" & second
            Controls.Add(secondpicturebox)

            AddHandler secondpicturebox.Click, AddressOf secondpicturebox_Click

            secondpicturebox.SizeMode = PictureBoxSizeMode.AutoSize
            secondpicturebox.Image = My.Resources.back
            xaxis = xaxis + 80

        Next second

        My.Computer.Audio.Play(My.Resources.happy_instrmentalwav, AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub secondpicturebox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim image(14) As Image
        image(0) = My.Resources._1
        image(1) = My.Resources._13
        image(2) = My.Resources._17
        image(3) = My.Resources._21
        image(4) = My.Resources._25
        image(5) = My.Resources._29
        image(6) = My.Resources._33
        image(7) = My.Resources._37
        image(8) = My.Resources._41
        image(9) = My.Resources._45
        image(10) = My.Resources._49
        image(11) = My.Resources._5
        image(12) = My.Resources._53
        image(13) = My.Resources._9
        image(14) = My.Resources.penguin_ace_of_spades

        If firstclick = False And secondclick = False Then
            firstclick = True
        ElseIf firstclick = True And secondclick = False Then
            secondclick = True
        End If

        x = sender
        If x.Name = "secondpicturebox1" Then
            If secondcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")
                secondclick = False
            Else
                x.Image = image(secondarray(0))
            End If
            secondcompare = secondarray(0)
            z = 0
        End If

        If x.Name = "secondpicturebox2" Then
            If secondcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")
                secondclick = False
            Else
                x.Image = image(secondarray(1))
            End If
            secondcompare = secondarray(1)
            z = 1

        End If

        If x.Name = "secondpicturebox3" Then
            If secondcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                x.Image = image(secondarray(2))
            End If
            secondcompare = secondarray(2)

        End If

        If x.Name = "secondpicturebox4" Then
            If secondcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                x.Image = image(secondarray(3))
            End If
            secondcompare = secondarray(3)
            z = 3

        End If

        If x.Name = "secondpicturebox5" Then
            If secondcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                x.Image = image(secondarray(4))
            End If
            secondcompare = secondarray(4)
            z = 4

        End If

        If x.Name = "secondpicturebox6" Then
            If secondcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                x.Image = image(secondarray(5))
            End If
            secondcompare = secondarray(5)
            z = 5

        End If

        If x.Name = "secondpicturebox7" Then
            If secondcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                x.Image = image(secondarray(6))
            End If
            secondcompare = secondarray(6)
            z = 6

        End If

        If x.Name = "secondpicturebox8" Then
            If secondcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                x.Image = image(secondarray(7))
            End If
            secondcompare = secondarray(7)
            z = 7

        End If

        If x.Name = "secondpicturebox9" Then
            If secondcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                x.Image = image(secondarray(8))
            End If
            secondcompare = secondarray(8)
            z = 8

        End If

        If x.Name = "secondpicturebox10" Then
            If secondcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                x.Image = image(secondarray(9))
            End If
            secondcompare = secondarray(9)
            z = 9

        End If

        If x.Name = "secondpicturebox11" Then
            If secondcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                x.Image = image(secondarray(10))
            End If
            secondcompare = secondarray(10)
            z = 10
        End If

        If x.Name = "secondpicturebox12" Then
            If secondcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                x.Image = image(secondarray(11))
            End If
            secondcompare = secondarray(11)
            z = 11
        End If

        If x.Name = "secondpicturebox13" Then
            If secondcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")
                secondclick = False
            Else
                x.Image = image(secondarray(12))
            End If
            secondcompare = secondarray(12)
            z = 12

        End If

        If x.Name = "secondpicturebox14" Then
            If secondcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")
                secondclick = False
            Else
                x.Image = image(secondarray(13))
            End If
            secondcompare = secondarray(13)
            z = 13

        End If

        If x.Name = "secondpicturebox15" Then
            If secondcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")
                secondclick = False
            Else
                x.Image = image(secondarray(14))
            End If
            secondcompare = secondarray(14)
            z = 14

        End If


       

        If firstclick = True And secondclick = True Then
            If firstcompare = secondcompare Then
                MessageBox.Show("yay!")
                firstclick = False
                secondclick = False
                firstcompare = -1
                secondcompare = -1
                x.Hide()
                y.Hide()
                My.Computer.Audio.Play(My.Resources.winning_soundwav, AudioPlayMode.Background)
                If firstplayer = True Then
                    score1 += 1
                    firstplayer = True
                    secondplayer = False
                    If score1 + score1 <> number Then
                        MessageBox.Show(player1 & " can go again")
                    End If
                ElseIf secondplayer = True Then
                    score2 += 1
                    secondplayer = True
                    firstplayer = False
                    If score2 + score1 <> number Then
                        MessageBox.Show(player2 & " can go again")
                    End If
                End If
            End If

            If firstcompare <> secondcompare Then
                MessageBox.Show("too bad")
                x.Image = My.Resources.back
                y.Image = My.Resources.back
                firstclick = False
                secondclick = False
                firstcompare = -1
                secondcompare = -1
                My.Computer.Audio.Play(My.Resources.wrong1wav, AudioPlayMode.Background)
                If firstplayer = True Then
                    firstplayer = False
                    secondplayer = True
                    MessageBox.Show("it is " & player2 & "'s turn")
                ElseIf secondplayer = True Then
                    secondplayer = False
                    firstplayer = True
                    MessageBox.Show("it is " & player1 & "'s turn")
                End If

            End If
        End If
        Me.playerscore1.Text = score1
        Me.playerscore2.Text = score2
        If score1 + score2 = number Then
            If score1 > score2 Then
                MessageBox.Show(player1 & "is the winner!")
            End If
            If score2 > score1 Then
                MessageBox.Show(player2 & " is the winner!")
            End If
            If score1 = score2 Then
                MessageBox.Show("it is a tie!")
            End If
        End If

        My.Computer.Audio.Play(My.Resources.happy_instrmentalwav, AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub picturebox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim image(14) As Image
        image(0) = My.Resources._1
        image(1) = My.Resources._13
        image(2) = My.Resources._17
        image(3) = My.Resources._21
        image(4) = My.Resources._25
        image(5) = My.Resources._29
        image(6) = My.Resources._33
        image(7) = My.Resources._37
        image(8) = My.Resources._41
        image(9) = My.Resources._45
        image(10) = My.Resources._49
        image(11) = My.Resources._5
        image(12) = My.Resources._53
        image(13) = My.Resources._9
        image(14) = My.Resources.penguin_ace_of_spades

        If firstclick = False And secondclick = False Then
            firstclick = True
        ElseIf firstclick = True And secondclick = False Then
            secondclick = True
        End If

        y = sender
        If y.Name = "picturebox0" Then
            If firstcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                y.Image = image(array(0))
            End If
            firstcompare = array(0)

        End If

        If y.Name = "picturebox1" Then
            If firstcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                y.Image = image(array(1))
            End If
            firstcompare = array(1)

        End If

        If y.Name = "picturebox2" Then
            If firstcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                y.Image = image(array(2))
            End If
            firstcompare = array(2)

        End If

        If y.Name = "picturebox3" Then
            If firstcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                y.Image = image(array(3))
            End If
            firstcompare = array(3)

        End If

        If y.Name = "picturebox4" Then
            If firstcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                y.Image = image(array(4))
            End If
            firstcompare = array(4)

        End If

        If y.Name = "picturebox5" Then
            If firstcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                y.Image = image(array(5))
            End If
            firstcompare = array(5)

        End If

        If y.Name = "picturebox6" Then
            If firstcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                y.Image = image(array(6))
            End If
            firstcompare = array(6)

        End If

        If y.Name = "picturebox7" Then
            If firstcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                y.Image = image(array(7))
            End If
            firstcompare = array(7)

        End If

        If y.Name = "picturebox8" Then
            If firstcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                y.Image = image(array(8))
            End If
            firstcompare = array(8)

        End If

        If y.Name = "picturebox9" Then
            If firstcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                y.Image = image(array(9))
            End If
            firstcompare = array(9)

        End If

        If y.Name = "picturebox10" Then
            If firstcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                y.Image = image(array(10))
            End If
            firstcompare = array(10)

        End If

        If y.Name = "picturebox11" Then
            If firstcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                y.Image = image(array(11))
            End If
            firstcompare = array(11)

        End If

        If y.Name = "picturebox12" Then
            If firstcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                y.Image = image(array(12))
            End If
            firstcompare = array(12)

        End If

        If y.Name = "picturebox13" Then
            If firstcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                y.Image = image(array(13))
            End If
            firstcompare = array(13)

        End If

        If y.Name = "picturebox14" Then
            If firstcompare <> -1 Then
                MessageBox.Show("you can only pick one card on this row")

                secondclick = False
            Else
                y.Image = image(array(14))
            End If
            firstcompare = array(14)

        End If

        
        If firstclick = True And secondclick = True Then
            If firstcompare = secondcompare Then
                MessageBox.Show("yay!")
                firstclick = False
                secondclick = False
                firstcompare = -1
                secondcompare = -1
                x.Hide()
                y.Hide()
                My.Computer.Audio.Play(My.Resources.winning_soundwav, AudioPlayMode.Background)
                If firstplayer = True Then
                    score1 += 1
                    firstplayer = True
                    secondplayer = False
                    If score1 + score2 <> number Then
                        MessageBox.Show(player1 & " can go agin")
                    End If

                ElseIf secondplayer = True Then
                    score2 += 1
                    secondplayer = True
                    firstplayer = False
                    If score2 + score1 <> number Then
                        MessageBox.Show(player2 & " can go again")
                    End If
                End If
            End If
            If firstcompare <> secondcompare Then
                MessageBox.Show("too bad")
                firstclick = False
                secondclick = False
                firstcompare = -1
                secondcompare = -1
                y.Image = My.Resources.back
                x.Image = My.Resources.back
                My.Computer.Audio.Play(My.Resources.wrong1wav, AudioPlayMode.Background)
                If firstplayer = True Then
                    firstplayer = False
                    secondplayer = True
                    MessageBox.Show("it is " & player2 & "'s turn")
                ElseIf secondplayer = True Then
                    secondplayer = False
                    firstplayer = True
                    MessageBox.Show("it is " & player1 & "'s turn")
                End If
            End If
        End If

        Me.playerscore1.Text = score1
        Me.playerscore2.Text = score2

        If score1 + score2 = number Then
            If score1 > score2 Then
                MessageBox.Show(player1 & "is the winner!")
            End If
            If score2 > score1 Then
                MessageBox.Show(player2 & " is the winner!")
            End If
            If score1 = score2 Then
                MessageBox.Show("it is a tie!")
            End If
        End If
        My.Computer.Audio.Play(My.Resources.happy_instrmentalwav, AudioPlayMode.BackgroundLoop)
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        mouse.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        mouse.Refresh 
    End Sub
End Class
