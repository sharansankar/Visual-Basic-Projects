Imports System.Text.RegularExpressions
Public Class Form1
    Dim original As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'replace word function 

        Dim replace As String
        Dim search As String
        Dim newtext As String


        original = Me.TextBox1.Text
        original = original.ToLower
        original = original.Insert(0, " ")
        original = original.Insert(original.Length, " ")

        search = InputBox("enter search word")
        replace = InputBox("enter replacing word")
        search = search.ToLower
        replace = replace.Insert(0, " ")
        replace = replace.Insert(replace.Length, " ")

        search = search.Insert(0, " ")
        search = search.Insert(search.Length, " ")

        newtext = original.Replace(search, replace)

        Me.answer.Text = newtext
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'vovel count

        Dim counta As Integer
        Dim counte As Integer
        Dim counti As Integer
        Dim counto As Integer
        Dim countu As Integer
        Dim county As Integer
        Dim finalcount As Integer

        Dim vovely1 As String = "\b[y]\w"


        Dim vovely6 As String = "[y][a]"
        Dim vovely7 As String = "[y][e]"
        Dim vovely8 As String = "[y][i]"
        Dim vovely9 As String = "[y][o]"
        Dim vovely10 As String = "[u][y]"
        Dim vovely11 As String = "[a][y]"
        Dim vovely12 As String = "[e][y]"
        Dim vovely13 As String = "[i][y]"
        Dim vovely14 As String = "[o][y]"
        Dim vovely15 As String = "[u][y]"


        Dim vovely As Integer = 0

        original = Me.TextBox1.Text

        For Each Match As Match In Regex.Matches(original, vovely1)
            vovely -= 1
        Next       
        For Each Match As Match In Regex.Matches(original, vovely6)
            vovely -= 1
        Next
        For Each Match As Match In Regex.Matches(original, vovely7)
            vovely -= 1
        Next
        For Each Match As Match In Regex.Matches(original, vovely8)
            vovely -= 1
        Next
        For Each Match As Match In Regex.Matches(original, vovely9)
            vovely -= 1
        Next
        For Each Match As Match In Regex.Matches(original, vovely10)
            vovely -= 1
        Next
        For Each Match As Match In Regex.Matches(original, vovely11)
            vovely -= 1
        Next
        For Each Match As Match In Regex.Matches(original, vovely12)
            vovely -= 1
        Next

        For Each Match As Match In Regex.Matches(original, vovely13)
            vovely -= 1
        Next
        For Each Match As Match In Regex.Matches(original, vovely14)
            vovely -= 1
        Next
        For Each Match As Match In Regex.Matches(original, vovely15)
            vovely -= 1
        Next
        counta = original.Split("a").Length - 1
        counte = original.Split("e").Length - 1
        counti = original.Split("i").Length - 1
        counto = original.Split("o").Length - 1
        countu = original.Split("u").Length - 1
        county = original.Split("y").Length - 1


        finalcount = counta + counte + counti + counto + countu + county + vovely
        Me.answer.Text = "The number of Vowels= " & finalcount
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        original = Me.TextBox1.Text
        Dim letternumber As Integer
        Dim grammer As Integer
        Dim grammer2 As Integer
        Dim grammer3 As Integer
        Dim grammer4 As Integer
        Dim newstring As String
        Dim pattern As String = "\w[!]"
        Dim pattern2 As String = "\w[?]"
        Dim pattern3 As String = "\w[@]"
        Dim pattern4 As String = "\w[#]"
        Dim pattern5 As String = "\w[$]"
        Dim pattern6 As String = "\w[%]"
        Dim pattern7 As String = "\w[&]"
        Dim pattern8 As String = "\w[^]"

        newstring = original.TrimEnd

        For Each Match As Match In Regex.Matches(newstring, pattern, RegexOptions.IgnoreCase)
            grammer += -1
        Next
        For Each Match As Match In Regex.Matches(newstring, pattern2, RegexOptions.IgnoreCase)
            grammer += -1
        Next
        For Each Match As Match In Regex.Matches(newstring, pattern3, RegexOptions.IgnoreCase)
            grammer += -1
        Next
        For Each Match As Match In Regex.Matches(newstring, pattern4, RegexOptions.IgnoreCase)
            grammer += -1
        Next
        For Each Match As Match In Regex.Matches(newstring, pattern5, RegexOptions.IgnoreCase)
            grammer += -1
        Next
        For Each Match As Match In Regex.Matches(newstring, pattern6, RegexOptions.IgnoreCase)
            grammer += -1
        Next
        For Each Match As Match In Regex.Matches(newstring, pattern7, RegexOptions.IgnoreCase)
            grammer += -1
        Next
        
        letternumber = newstring.Split(" ").Length
        grammer2 = newstring.Split("!").Length - 1
        grammer4 = newstring.Split("?").Length - 1
        grammer3 = grammer2 + grammer + grammer4
        letternumber = letternumber - grammer3

        Me.answer.Text = "The number of words are " & letternumber
    End Sub



    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress



        If TextBox1.Text = Nothing And e.KeyChar = " " Then
            e.KeyChar = Nothing
        End If

    End Sub



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim oneletterword As Integer = 0
        Dim twolet As Integer = 0
        Dim threelet As Integer = 0
        Dim foulet As Integer = 0
        Dim fivelet As Integer = 0
        Dim sixlet As Integer = 0
        Dim sevenlet As Integer = 0
        Dim eightet As Integer = 0

        Dim pattern As String = "\b\w\b"
        Dim pattern2 As String = "\b\w\w\b"
        Dim pattern3 As String = "\b\w\w\w\b"
        Dim pattern4 As String = "\b\w\w\w\w\b"
        Dim pattern5 As String = "\b\w\w\w\w\w\b"
        Dim pattern6 As String = "\b\w\w\w\w\w\w\b"
        Dim pattern7 As String = "\b\w\w\w\w\w\w\w\b"
        Dim pattern8 As String = "\b\w\w\w\w\w\w\w\w\b"
        Dim input As String
        input = Me.TextBox1.Text
        For Each Match As Match In Regex.Matches(input, pattern, RegexOptions.IgnoreCase)
            oneletterword += 1
        Next
        For Each Match As Match In Regex.Matches(input, pattern2, RegexOptions.IgnoreCase)
            twolet += 1
        Next
        For Each Match As Match In Regex.Matches(input, pattern3, RegexOptions.IgnoreCase)
            threelet += 1
        Next
        For Each Match As Match In Regex.Matches(input, pattern4, RegexOptions.IgnoreCase)
            foulet += 1
        Next
        For Each Match As Match In Regex.Matches(input, pattern5, RegexOptions.IgnoreCase)
            fivelet += 1
        Next
        For Each Match As Match In Regex.Matches(input, pattern6, RegexOptions.IgnoreCase)
            sixlet += 1
        Next
        For Each Match As Match In Regex.Matches(input, pattern7, RegexOptions.IgnoreCase)
            sevenlet += 1
        Next
        For Each Match As Match In Regex.Matches(input, pattern8, RegexOptions.IgnoreCase)
            eightet += 1
        Next

        Me.answer.Text = "the number of one letter words are " & oneletterword & vbNewLine & "the number of two letter words are " & twolet & vbNewLine & "the number of three letter words are " & threelet & vbNewLine & "the number of four letter words" & foulet & vbNewLine & "the number of five letter words: " & fivelet & vbNewLine & "the number of six letter words: " & sixlet & vbNewLine & "the number of seven letter words: " & sevenlet & vbNewLine & "the number of eight letter words" & eightet


    End Sub
End Class
