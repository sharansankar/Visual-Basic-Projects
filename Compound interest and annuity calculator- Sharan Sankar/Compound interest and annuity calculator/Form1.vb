Public Class Form1
    Dim mode1 As Boolean = False
    Dim mode2 As Boolean = False
    Private Sub presentval_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles presentval.CheckedChanged
        Presentvalue.Enabled = False
        futurevalue.Enabled = True
        mode2 = True
        mode1 = False
    End Sub
    Private Sub Futureval_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Futureval.CheckedChanged
        futurevalue.Enabled = False
        Presentvalue.Enabled = True
        mode1 = True
        mode2 = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim futureval As Double
        Dim presentval As Double
        Dim interestrate As Double
        Dim interest As Double
        Dim compoundingperiod As Double
        Dim compoundingperiods As Double
        Dim years As Double


        interestrate = Val(Me.Interestratesbox.Text)
        compoundingperiod = Val(Me.Compoundperiod.Text)
        years = Val(Me.numberofyears.Text)
        presentval = Val(Me.Presentvalue.Text)
        futureval = Val(Me.futurevalue.Text)


        interest = interestrate / 100 / compoundingperiod
        compoundingperiods = compoundingperiod * years



        If Not IsNumeric(Presentvalue.Text) And Me.presentval.Checked = False Then
            Presentvalue.Clear()
            MessageBox.Show("invalid value")
            Exit Sub
        End If
        If Not IsNumeric(Interestratesbox.Text) Then
            Interestratesbox.Clear()
            MessageBox.Show("invalid value")
            Exit Sub
        ElseIf Interestratesbox.Text < 0 Then
            Interestratesbox.Clear()
            MessageBox.Show("invalid value")
            Exit Sub
        End If
        If Not IsNumeric(Compoundperiod.Text) Then
            Compoundperiod.Clear()
            MessageBox.Show("invalid value")
            Exit Sub
        ElseIf Compoundperiod.Text < 0 Then
            Compoundperiod.Clear()
            MessageBox.Show("invalid value")
            Exit Sub
        End If
        If Not IsNumeric(numberofyears.Text) Then
            numberofyears.Clear()
            MessageBox.Show("invalid value")
            Exit Sub
        ElseIf numberofyears.Text < 0 Then
            numberofyears.Clear()
            MessageBox.Show("invalid value")
            Exit Sub
        End If
        If Not IsNumeric(futurevalue.Text) And Me.Futureval.Checked = False Then
            futurevalue.Clear()
            MessageBox.Show("invalid value")
            Exit Sub
        ElseIf Val(futurevalue.Text) < 0 And Me.Futureval.Checked = False Then
            futurevalue.Clear()
            MessageBox.Show("invalid value")
            Exit Sub
        End If


        If mode1 = True Then
            futureval = presentval * (1 + interest) ^ compoundingperiods

        ElseIf mode2 = True Then
            presentval = futureval / (1 + interest) ^ compoundingperiods
        End If

        If Me.presentval.Checked = True And mode2 = True Then
            Presentvalue.Text = presentval
            Math.Round(presentval, 2)
        End If
        If Me.Futureval.Checked = True And mode1 = True Then
            futurevalue.Text = futureval
            Math.Round(futureval, 2)
        End If

    End Sub






    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class


