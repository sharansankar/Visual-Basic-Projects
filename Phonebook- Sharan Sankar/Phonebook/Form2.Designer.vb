<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Secondname = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.telephonenumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Find = New System.Windows.Forms.Button()
        Me.Remove = New System.Windows.Forms.Button()
        Me.Addbutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameTextBox1
        '
        Me.NameTextBox1.Location = New System.Drawing.Point(112, 40)
        Me.NameTextBox1.MaxLength = 10
        Me.NameTextBox1.Name = "NameTextBox1"
        Me.NameTextBox1.Size = New System.Drawing.Size(106, 20)
        Me.NameTextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Second Name"
        '
        'Secondname
        '
        Me.Secondname.Location = New System.Drawing.Point(356, 40)
        Me.Secondname.MaxLength = 10
        Me.Secondname.Name = "Secondname"
        Me.Secondname.Size = New System.Drawing.Size(106, 20)
        Me.Secondname.TabIndex = 3
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(179, 106)
        Me.Email.MaxLength = 20
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(228, 20)
        Me.Email.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email:"
        '
        'telephonenumber
        '
        Me.telephonenumber.Location = New System.Drawing.Point(179, 161)
        Me.telephonenumber.MaxLength = 10
        Me.telephonenumber.Name = "telephonenumber"
        Me.telephonenumber.Size = New System.Drawing.Size(228, 20)
        Me.telephonenumber.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Telephone Number:"
        '
        'Find
        '
        Me.Find.Location = New System.Drawing.Point(236, 251)
        Me.Find.Name = "Find"
        Me.Find.Size = New System.Drawing.Size(95, 30)
        Me.Find.TabIndex = 8
        Me.Find.Text = "Find"
        Me.Find.UseVisualStyleBackColor = True
        '
        'Remove
        '
        Me.Remove.Location = New System.Drawing.Point(337, 251)
        Me.Remove.Name = "Remove"
        Me.Remove.Size = New System.Drawing.Size(95, 30)
        Me.Remove.TabIndex = 9
        Me.Remove.Text = "Remove"
        Me.Remove.UseVisualStyleBackColor = True
        '
        'Addbutton
        '
        Me.Addbutton.Location = New System.Drawing.Point(444, 251)
        Me.Addbutton.Name = "Addbutton"
        Me.Addbutton.Size = New System.Drawing.Size(95, 30)
        Me.Addbutton.TabIndex = 10
        Me.Addbutton.Text = "Add"
        Me.Addbutton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 293)
        Me.Controls.Add(Me.Addbutton)
        Me.Controls.Add(Me.Remove)
        Me.Controls.Add(Me.Find)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.telephonenumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Secondname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NameTextBox1)
        Me.Name = "Form2"
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Secondname As System.Windows.Forms.TextBox
    Friend WithEvents Email As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents telephonenumber As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Find As System.Windows.Forms.Button
    Friend WithEvents Remove As System.Windows.Forms.Button
    Friend WithEvents Addbutton As System.Windows.Forms.Button
End Class
