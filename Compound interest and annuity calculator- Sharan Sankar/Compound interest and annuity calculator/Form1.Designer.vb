<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Presentvalue = New System.Windows.Forms.TextBox()
        Me.Interestratesbox = New System.Windows.Forms.TextBox()
        Me.Compoundperiod = New System.Windows.Forms.TextBox()
        Me.numberofyears = New System.Windows.Forms.TextBox()
        Me.futurevalue = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Futureval = New System.Windows.Forms.RadioButton()
        Me.presentval = New System.Windows.Forms.RadioButton()
        Me.Labelpv = New System.Windows.Forms.Label()
        Me.Labelfv = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Compound Interest Calculator "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Present Value "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Interest Rate "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Compounding Period"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Number of years "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(64, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Future Value "
        '
        'Presentvalue
        '
        Me.Presentvalue.BackColor = System.Drawing.SystemColors.Window
        Me.Presentvalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Presentvalue.Location = New System.Drawing.Point(239, 116)
        Me.Presentvalue.Name = "Presentvalue"
        Me.Presentvalue.Size = New System.Drawing.Size(144, 23)
        Me.Presentvalue.TabIndex = 6
        '
        'Interestratesbox
        '
        Me.Interestratesbox.BackColor = System.Drawing.SystemColors.Window
        Me.Interestratesbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Interestratesbox.Location = New System.Drawing.Point(239, 167)
        Me.Interestratesbox.Name = "Interestratesbox"
        Me.Interestratesbox.Size = New System.Drawing.Size(144, 23)
        Me.Interestratesbox.TabIndex = 7
        '
        'Compoundperiod
        '
        Me.Compoundperiod.BackColor = System.Drawing.SystemColors.Window
        Me.Compoundperiod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Compoundperiod.Location = New System.Drawing.Point(239, 211)
        Me.Compoundperiod.Name = "Compoundperiod"
        Me.Compoundperiod.Size = New System.Drawing.Size(144, 23)
        Me.Compoundperiod.TabIndex = 8
        '
        'numberofyears
        '
        Me.numberofyears.BackColor = System.Drawing.SystemColors.Window
        Me.numberofyears.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberofyears.Location = New System.Drawing.Point(239, 256)
        Me.numberofyears.Name = "numberofyears"
        Me.numberofyears.Size = New System.Drawing.Size(144, 23)
        Me.numberofyears.TabIndex = 9
        '
        'futurevalue
        '
        Me.futurevalue.BackColor = System.Drawing.SystemColors.Window
        Me.futurevalue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.futurevalue.Location = New System.Drawing.Point(239, 295)
        Me.futurevalue.Name = "futurevalue"
        Me.futurevalue.Size = New System.Drawing.Size(144, 23)
        Me.futurevalue.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button1.Location = New System.Drawing.Point(299, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 30)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Calculate "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button2.Location = New System.Drawing.Point(145, 357)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 30)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Futureval
        '
        Me.Futureval.AutoSize = True
        Me.Futureval.Checked = True
        Me.Futureval.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Futureval.Location = New System.Drawing.Point(58, 77)
        Me.Futureval.Name = "Futureval"
        Me.Futureval.Size = New System.Drawing.Size(107, 21)
        Me.Futureval.TabIndex = 13
        Me.Futureval.TabStop = True
        Me.Futureval.Text = "Future Value"
        Me.Futureval.UseVisualStyleBackColor = True
        '
        'presentval
        '
        Me.presentval.AutoSize = True
        Me.presentval.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.presentval.Location = New System.Drawing.Point(218, 77)
        Me.presentval.Name = "presentval"
        Me.presentval.Size = New System.Drawing.Size(115, 21)
        Me.presentval.TabIndex = 14
        Me.presentval.Text = "Present Value"
        Me.presentval.UseVisualStyleBackColor = True
        '
        'Labelpv
        '
        Me.Labelpv.AutoSize = True
        Me.Labelpv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelpv.Location = New System.Drawing.Point(236, 122)
        Me.Labelpv.Name = "Labelpv"
        Me.Labelpv.Size = New System.Drawing.Size(0, 17)
        Me.Labelpv.TabIndex = 15
        '
        'Labelfv
        '
        Me.Labelfv.AutoSize = True
        Me.Labelfv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelfv.Location = New System.Drawing.Point(241, 300)
        Me.Labelfv.Name = "Labelfv"
        Me.Labelfv.Size = New System.Drawing.Size(0, 17)
        Me.Labelfv.TabIndex = 16
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button3.Location = New System.Drawing.Point(24, 357)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 30)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 406)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Labelfv)
        Me.Controls.Add(Me.Labelpv)
        Me.Controls.Add(Me.presentval)
        Me.Controls.Add(Me.Futureval)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.futurevalue)
        Me.Controls.Add(Me.numberofyears)
        Me.Controls.Add(Me.Compoundperiod)
        Me.Controls.Add(Me.Interestratesbox)
        Me.Controls.Add(Me.Presentvalue)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Compound Interest Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Presentvalue As System.Windows.Forms.TextBox
    Friend WithEvents Interestratesbox As System.Windows.Forms.TextBox
    Friend WithEvents Compoundperiod As System.Windows.Forms.TextBox
    Friend WithEvents numberofyears As System.Windows.Forms.TextBox
    Friend WithEvents futurevalue As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Futureval As System.Windows.Forms.RadioButton
    Friend WithEvents presentval As System.Windows.Forms.RadioButton
    Friend WithEvents Labelpv As System.Windows.Forms.Label
    Friend WithEvents Labelfv As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
