Public Class Form2

    Public Structure contact
        <VBFixedString(10)> Public secondname As String
        <VBFixedString(10)> Public firstname As String
        <VBFixedString(15)> Public email As String
        <VBFixedString(10)> Public telephonenumber As String
    End Structure

   




    Private Sub Addbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Addbutton.Click

        If Me.telephonenumber.Text = "" Then

        ElseIf IsNumeric(Me.telephonenumber.Text) = False Then
            MessageBox.Show("please enter only integers for a telephone number")
            Me.telephonenumber.Text = ""
            Exit Sub
        End If

        fn(x) = NameTextBox1.Text
        sn(x) = Secondname.Text
        em(x) = Email.Text
        tn(x) = Me.telephonenumber.Text
        
        

        index(x) = fn(x) & sn(x) & em(x) & tn(x)



        Me.Hide()
        Form1.Show()
        Dim newcontact As contact
        newcontact.firstname = fn(x)
        newcontact.secondname = sn(x)
        newcontact.email = em(x)
        newcontact.telephonenumber = tn(x)

        Form1.ListBox1.Items.Add(newcontact.firstname & vbTab & newcontact.secondname & vbTab & newcontact.email & vbTab & newcontact.telephonenumber)
        indexstring(x) = newcontact.firstname & vbTab & newcontact.secondname & vbTab & newcontact.email & vbTab & newcontact.telephonenumber
        x += 1
        z = x

    End Sub

    Private Sub Find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find.Click
        Dim newfn As String = NameTextBox1.Text
        Dim newsn As String = Secondname.Text
        Dim newem As String = Email.Text
        Dim newtn As String = Me.telephonenumber.Text

        Form3.ListBox1.Items.Clear()

        For y As Integer = 0 To x - 1
            If Form1.ListBox1.Items(y).Contains(newfn) And newfn <> "" Then
                Form3.ListBox1.Items.Add(Form1.ListBox1.Items(y))
            End If

            If Form1.ListBox1.Items(y).Contains(newsn) And Form3.ListBox1.Items.Contains(fn(y) & vbTab & sn(y) & vbTab & em(y) & vbTab & tn(y)) = False And newsn <> Nothing Then
                Form3.ListBox1.Items.Add(fn(y) & vbTab & sn(y) & vbTab & em(y) & vbTab & tn(y))
            End If

            If Form1.ListBox1.Items(y).Contains(newem) And Form3.ListBox1.Items.Contains(fn(y) & vbTab & sn(y) & vbTab & em(y) & vbTab & tn(y)) = False And newem <> "" Then
                Form3.ListBox1.Items.Add(fn(y) & vbTab & sn(y) & vbTab & em(y) & vbTab & tn(y))
            End If

            If newtn = "" Then
            ElseIf Form1.ListBox1.Items(y).Contains(newtn) And Form3.ListBox1.Items.Contains(fn(y) & vbTab & sn(y) & vbTab & em(y) & vbTab & tn(y)) = False And newtn <> "" Then
                Form3.ListBox1.Items.Add(fn(y) & vbTab & sn(y) & vbTab & em(y) & vbTab & tn(y))
            End If

        Next

        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remove.Click
        Dim newfn As String = NameTextBox1.Text
        Dim newsn As String = Secondname.Text
        Dim newem As String = Email.Text
        Dim newtn As String = telephonenumber.Text
        'remove 
        If Me.telephonenumber.Text = "" Then
            newtn = Nothing
        End If

        If newfn = "" Or newsn = "" Or newem = "" Or newtn = "" Then
            For y As Integer = 0 To x - 1
                If Form1.ListBox1.Items(y).Contains(newfn) And newfn <> "" Then
                    Form4.ListBox1.Items.Add(Form1.ListBox1.Items(y))
                End If

                If Form1.ListBox1.Items(y).Contains(newsn) And Form3.ListBox1.Items.Contains(fn(y) & vbTab & sn(y) & vbTab & em(y) & vbTab & tn(y)) = False And newsn <> Nothing Then
                    Form4.ListBox1.Items.Add(Form1.ListBox1.Items(y))
                End If

                If Form1.ListBox1.Items(y).Contains(newem) And Form3.ListBox1.Items.Contains(fn(y) & vbTab & sn(y) & vbTab & em(y) & vbTab & tn(y)) = False And newem <> "" Then
                    Form4.ListBox1.Items.Add(Form1.ListBox1.Items(y))
                End If

                If newtn = Nothing Or newtn = "" Then

                ElseIf Form1.ListBox1.Items(y).Contains(newtn) And Form3.ListBox1.Items.Contains(fn(y) & vbTab & sn(y) & vbTab & em(y) & vbTab & tn(y)) = False And newtn <> Nothing Then
                    Form4.ListBox1.Items.Add(Form1.ListBox1.Items(y))
                End If
            Next
            Me.Hide()
            Form4.Show()
        Else
            For y As Integer = 0 To x - 1
                If Form1.ListBox1.Items.Contains(newfn & vbTab & newsn & vbTab & newem & vbTab & newtn) = True Then
                    Form1.ListBox1.Items.Remove(newfn & vbTab & newsn & vbTab & newem & vbTab & newtn)
                End If
            Next
            Me.Hide()
            Form1.Show()
        End If

            
    End Sub

End Class