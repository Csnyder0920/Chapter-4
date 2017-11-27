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
        Me.lstColor = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstEst = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstIntegerC = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstBodyPart = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstAnimal = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstNoun = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstPluralNoun = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstColor
        '
        Me.lstColor.FormattingEnabled = True
        Me.lstColor.Items.AddRange(New Object() {"Blue", "Yellow", "Red", "Orange", "Green", "Purple", "Pink ", "Brown", "Black", "White ", "Cyan "})
        Me.lstColor.Location = New System.Drawing.Point(24, 36)
        Me.lstColor.Name = "lstColor"
        Me.lstColor.Size = New System.Drawing.Size(120, 95)
        Me.lstColor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Color"
        '
        'lstEst
        '
        Me.lstEst.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstEst.FormattingEnabled = True
        Me.lstEst.Items.AddRange(New Object() {"biggest", "shortest", "tallest", "greatest", "roundest", "longest", "smallest", "biggest"})
        Me.lstEst.Location = New System.Drawing.Point(171, 36)
        Me.lstEst.Name = "lstEst"
        Me.lstEst.Size = New System.Drawing.Size(120, 95)
        Me.lstEst.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Word ending in Est"
        '
        'lstIntegerC
        '
        Me.lstIntegerC.FormattingEnabled = True
        Me.lstIntegerC.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "20", "23", "25", "27", "30", "35", "40", "45", "50", "55", "60", "65", "70", "80", "90", "100"})
        Me.lstIntegerC.Location = New System.Drawing.Point(323, 36)
        Me.lstIntegerC.Name = "lstIntegerC"
        Me.lstIntegerC.Size = New System.Drawing.Size(120, 95)
        Me.lstIntegerC.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(320, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Number"
        '
        'lstBodyPart
        '
        Me.lstBodyPart.FormattingEnabled = True
        Me.lstBodyPart.Location = New System.Drawing.Point(24, 167)
        Me.lstBodyPart.Name = "lstBodyPart"
        Me.lstBodyPart.Size = New System.Drawing.Size(120, 95)
        Me.lstBodyPart.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Body Part"
        '
        'lstAnimal
        '
        Me.lstAnimal.FormattingEnabled = True
        Me.lstAnimal.Location = New System.Drawing.Point(171, 167)
        Me.lstAnimal.Name = "lstAnimal"
        Me.lstAnimal.Size = New System.Drawing.Size(120, 95)
        Me.lstAnimal.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Animal"
        '
        'lstNoun
        '
        Me.lstNoun.FormattingEnabled = True
        Me.lstNoun.Location = New System.Drawing.Point(323, 167)
        Me.lstNoun.Name = "lstNoun"
        Me.lstNoun.Size = New System.Drawing.Size(120, 95)
        Me.lstNoun.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(320, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Noun"
        '
        'lstPluralNoun
        '
        Me.lstPluralNoun.FormattingEnabled = True
        Me.lstPluralNoun.Location = New System.Drawing.Point(24, 303)
        Me.lstPluralNoun.Name = "lstPluralNoun"
        Me.lstPluralNoun.Size = New System.Drawing.Size(120, 95)
        Me.lstPluralNoun.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 284)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Plural Noun"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(195, 303)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(96, 42)
        Me.btnSubmit.TabIndex = 14
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(195, 351)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 42)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(323, 303)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 42)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 410)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lstPluralNoun)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstNoun)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstAnimal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstBodyPart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstIntegerC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstEst)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstColor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstColor As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstEst As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstIntegerC As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstBodyPart As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstAnimal As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstNoun As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstPluralNoun As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
