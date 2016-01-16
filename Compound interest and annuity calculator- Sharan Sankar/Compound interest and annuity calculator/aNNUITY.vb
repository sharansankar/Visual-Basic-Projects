Public Class aNNUITY
    Dim calcpayment As Boolean = False
    Dim calcfv As Boolean = True
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Me.Payment.Enabled = False
            Me.futureannuity.Enabled = True
            calcpayment = True
            calcfv = False
        ElseIf RadioButton1.Checked = True Then
            Me.Payment.Enabled = True
            Me.futureannuity.Enabled = False
            calcpayment = False
            calcfv = True
        End If


    End Sub


    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Me.futureannuity.Enabled = False
        Me.Payment.Enabled = True
    End Sub
    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Dim regularpayments As Double
        Dim interest As Double
        Dim years As Double
        Dim futurevalueofannuity As Double
        Dim rate As Double
        Dim comoundperiod As Double
        Dim paymentsperyear As Integer
        Dim numberofpayments As Double


        paymentsperyear = Val(paymentsperyears.Text)
        years = Val(Numberofyears.Text)
        rate = Val(interestrate.Text)
        comoundperiod = Val(compoundperiod.Text)
        regularpayments = Val(Payment.Text)
        futurevalueofannuity = Val(futureannuity.Text)

        numberofpayments = paymentsperyear * years
        interest = rate / 100 / comoundperiod
        If calcfv = True Then
            futurevalueofannuity = (regularpayments * (((1 + interest) ^ numberofpayments - 1))) / interest
        ElseIf calcpayment = True Then
            regularpayments = (futurevalueofannuity * interest) / (((1 + interest) ^ numberofpayments) - 1)
        End If

        If RadioButton1.Checked = True Then
            futurevalueofannuity = Math.Round(futurevalueofannuity, 2)
            futureannuity.Text = futurevalueofannuity

        End If
        If RadioButton2.Checked = True Then
            regularpayments = Math.Round(regularpayments, 2)
            Payment.Text = regularpayments

        End If

        If Not IsNumeric(Payment.Text) And RadioButton2.Checked = False Then
            Payment.Clear()
            MessageBox.Show("invaild input")
            Exit Sub
        ElseIf Payment.Text < 0 Then
            Payment.Clear()
            MessageBox.Show("invaild input")
            Exit Sub
        End If
        If Not IsNumeric(paymentsperyears.Text) Then
            paymentsperyears.Clear()
            MessageBox.Show("invaild input")
            Exit Sub
        ElseIf paymentsperyears.Text < 0 Then
            paymentsperyears.Clear()
            MessageBox.Show("invaild input")
            Exit Sub
        End If
        If Not IsNumeric(interestrate.Text) Then
            interestrate.Clear()
            MessageBox.Show("invaild input")
            Exit Sub
        ElseIf interestrate.Text < 0 Then
            interestrate.Clear()
            MessageBox.Show("invaild input")
            Exit Sub
        End If
        If Not IsNumeric(Numberofyears.Text) Then
            Numberofyears.Clear()
            MessageBox.Show("invaild input")
            Exit Sub
        ElseIf Numberofyears.Text < 0 Then
            Numberofyears.Clear()
            MessageBox.Show("invaild input")
            Exit Sub
        End If
        If Not IsNumeric(compoundperiod.Text) Then
            compoundperiod.Clear()
            MessageBox.Show("invaild input")
            Exit Sub
        ElseIf compoundperiod.Text < 0 Then
            compoundperiod.Clear()
            MessageBox.Show("invaild input")
            Exit Sub
        End If
        If Not IsNumeric(futureannuity.Text) Then
            futureannuity.Clear()
            MessageBox.Show("invaild input")
            Exit Sub
        ElseIf futureannuity.Text < 0 Then
            futureannuity.Text = ""
            MessageBox.Show("invaild input")
            Exit Sub
        End If
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class