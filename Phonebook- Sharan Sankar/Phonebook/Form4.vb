Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Form1.ListBox1.Items.Remove(Me.ListBox1.SelectedItem)
        Me.Hide()
        Form1.Show()
    End Sub
End Class