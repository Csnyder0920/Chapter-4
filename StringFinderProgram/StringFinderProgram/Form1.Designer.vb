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
        Me.lblString = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtStartIndex = New System.Windows.Forms.TextBox()
        Me.txtToFind = New System.Windows.Forms.TextBox()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search this string:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Index Numbers:"
        '
        'lblString
        '
        Me.lblString.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblString.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblString.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblString.Location = New System.Drawing.Point(159, 28)
        Me.lblString.Name = "lblString"
        Me.lblString.Size = New System.Drawing.Size(315, 23)
        Me.lblString.TabIndex = 2
        Me.lblString.Text = "abcABC00123573@ 123 ABC 98ABC123"
        Me.lblString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(156, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(318, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "012345678901234567890123456789012"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGo)
        Me.GroupBox1.Controls.Add(Me.txtStartIndex)
        Me.GroupBox1.Controls.Add(Me.txtToFind)
        Me.GroupBox1.Controls.Add(Me.lblResults)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(441, 140)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(239, 60)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(48, 23)
        Me.btnGo.TabIndex = 5
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtStartIndex
        '
        Me.txtStartIndex.Location = New System.Drawing.Point(187, 62)
        Me.txtStartIndex.Name = "txtStartIndex"
        Me.txtStartIndex.Size = New System.Drawing.Size(30, 20)
        Me.txtStartIndex.TabIndex = 4
        '
        'txtToFind
        '
        Me.txtToFind.Location = New System.Drawing.Point(187, 31)
        Me.txtToFind.Name = "txtToFind"
        Me.txtToFind.Size = New System.Drawing.Size(100, 20)
        Me.txtToFind.TabIndex = 3
        '
        'lblResults
        '
        Me.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResults.Location = New System.Drawing.Point(6, 101)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(429, 23)
        Me.lblResults.TabIndex = 2
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Start searching for index:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Substring to find:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(269, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "10"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(324, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 22)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "20"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(385, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 30)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "30"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(216, 265)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 298)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblString)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "String Finder"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblString As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents txtStartIndex As System.Windows.Forms.TextBox
    Friend WithEvents txtToFind As System.Windows.Forms.TextBox
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button

End Class
