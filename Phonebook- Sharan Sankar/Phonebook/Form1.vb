Public Class Form1




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()

        Form2.NameTextBox1.Text = ""
        Form2.Secondname.Text = ""
        Form2.Email.Text = ""
        Form2.telephonenumber.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.ListBox1.Items.Clear()
        FileOpen(1, "Contacts", OpenMode.Random, , OpenAccess.ReadWrite, 50)
       

        For y = 0 To z - 1
            FilePut(1, indexstring(y))
            
        Next
        FileClose(1)
       
        MessageBox.Show("contacts saved!")
       
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        FileOpen(1, "Contacts", OpenMode.Random, , OpenAccess.ReadWrite, 50)
        Dim length As Integer

        length = FileLen("Contacts") / 50

        For l = 0 To length
            FileGet(1, indexstring(l))
            Me.ListBox1.Items.Add(indexstring(l))
        Next

        FileClose(1)
        Kill("Contacts")
        FileOpen(1, "Contacts", OpenMode.Random, , OpenAccess.ReadWrite, 50)
        FileClose(1)
        x += 1
    End Sub

  
End Class
