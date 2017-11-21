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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.radTorta = New System.Windows.Forms.RadioButton()
        Me.radBurrito = New System.Windows.Forms.RadioButton()
        Me.radEnchiladas = New System.Windows.Forms.RadioButton()
        Me.radTacos = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkGuac = New System.Windows.Forms.CheckBox()
        Me.chkSourCream = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radQueso = New System.Windows.Forms.RadioButton()
        Me.radChipsAndSalsa = New System.Windows.Forms.RadioButton()
        Me.radRiceAndBeans = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.radTorta)
        Me.GroupBox1.Controls.Add(Me.radBurrito)
        Me.GroupBox1.Controls.Add(Me.radEnchiladas)
        Me.GroupBox1.Controls.Add(Me.radTacos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 199)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Your Meal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "All Items Pollo, Carne de Vaca, or Chorizo"
        '
        'radTorta
        '
        Me.radTorta.AutoSize = True
        Me.radTorta.Location = New System.Drawing.Point(24, 156)
        Me.radTorta.Name = "radTorta"
        Me.radTorta.Size = New System.Drawing.Size(50, 17)
        Me.radTorta.TabIndex = 3
        Me.radTorta.TabStop = True
        Me.radTorta.Tag = ""
        Me.radTorta.Text = "Torta"
        Me.radTorta.UseVisualStyleBackColor = True
        '
        'radBurrito
        '
        Me.radBurrito.AutoSize = True
        Me.radBurrito.Location = New System.Drawing.Point(24, 116)
        Me.radBurrito.Name = "radBurrito"
        Me.radBurrito.Size = New System.Drawing.Size(86, 17)
        Me.radBurrito.TabIndex = 2
        Me.radBurrito.TabStop = True
        Me.radBurrito.Text = "Super Burrito"
        Me.radBurrito.UseVisualStyleBackColor = True
        '
        'radEnchiladas
        '
        Me.radEnchiladas.AutoSize = True
        Me.radEnchiladas.Location = New System.Drawing.Point(24, 78)
        Me.radEnchiladas.Name = "radEnchiladas"
        Me.radEnchiladas.Size = New System.Drawing.Size(86, 17)
        Me.radEnchiladas.TabIndex = 1
        Me.radEnchiladas.TabStop = True
        Me.radEnchiladas.Text = "3 Enchiladas"
        Me.radEnchiladas.UseVisualStyleBackColor = True
        '
        'radTacos
        '
        Me.radTacos.AutoSize = True
        Me.radTacos.Location = New System.Drawing.Point(24, 41)
        Me.radTacos.Name = "radTacos"
        Me.radTacos.Size = New System.Drawing.Size(64, 17)
        Me.radTacos.TabIndex = 0
        Me.radTacos.TabStop = True
        Me.radTacos.Text = "3 Tacos"
        Me.radTacos.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkGuac)
        Me.GroupBox2.Controls.Add(Me.chkSourCream)
        Me.GroupBox2.Controls.Add(Me.chkCheese)
        Me.GroupBox2.Controls.Add(Me.chkTomato)
        Me.GroupBox2.Location = New System.Drawing.Point(351, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(151, 199)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Your Toppings "
        '
        'chkGuac
        '
        Me.chkGuac.AutoSize = True
        Me.chkGuac.Location = New System.Drawing.Point(22, 156)
        Me.chkGuac.Name = "chkGuac"
        Me.chkGuac.Size = New System.Drawing.Size(80, 17)
        Me.chkGuac.TabIndex = 3
        Me.chkGuac.Text = "Guacamole"
        Me.chkGuac.UseVisualStyleBackColor = True
        '
        'chkSourCream
        '
        Me.chkSourCream.AutoSize = True
        Me.chkSourCream.Location = New System.Drawing.Point(22, 116)
        Me.chkSourCream.Name = "chkSourCream"
        Me.chkSourCream.Size = New System.Drawing.Size(81, 17)
        Me.chkSourCream.TabIndex = 2
        Me.chkSourCream.Text = "Sour Cream"
        Me.chkSourCream.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(22, 78)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(89, 17)
        Me.chkCheese.TabIndex = 1
        Me.chkCheese.Text = "Extra Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(22, 41)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(89, 17)
        Me.chkTomato.TabIndex = 0
        Me.chkTomato.Text = "Extra Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radQueso)
        Me.GroupBox3.Controls.Add(Me.radChipsAndSalsa)
        Me.GroupBox3.Controls.Add(Me.radRiceAndBeans)
        Me.GroupBox3.Location = New System.Drawing.Point(353, 231)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(149, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select a Side Order"
        '
        'radQueso
        '
        Me.radQueso.AutoSize = True
        Me.radQueso.Location = New System.Drawing.Point(11, 78)
        Me.radQueso.Name = "radQueso"
        Me.radQueso.Size = New System.Drawing.Size(75, 17)
        Me.radQueso.TabIndex = 2
        Me.radQueso.TabStop = True
        Me.radQueso.Text = "Queso Dip"
        Me.radQueso.UseVisualStyleBackColor = True
        '
        'radChipsAndSalsa
        '
        Me.radChipsAndSalsa.AutoSize = True
        Me.radChipsAndSalsa.Location = New System.Drawing.Point(11, 50)
        Me.radChipsAndSalsa.Name = "radChipsAndSalsa"
        Me.radChipsAndSalsa.Size = New System.Drawing.Size(101, 17)
        Me.radChipsAndSalsa.TabIndex = 1
        Me.radChipsAndSalsa.TabStop = True
        Me.radChipsAndSalsa.Text = "Chips and Salsa"
        Me.radChipsAndSalsa.UseVisualStyleBackColor = True
        '
        'radRiceAndBeans
        '
        Me.radRiceAndBeans.AutoSize = True
        Me.radRiceAndBeans.Location = New System.Drawing.Point(11, 19)
        Me.radRiceAndBeans.Name = "radRiceAndBeans"
        Me.radRiceAndBeans.Size = New System.Drawing.Size(101, 17)
        Me.radRiceAndBeans.TabIndex = 0
        Me.radRiceAndBeans.TabStop = True
        Me.radRiceAndBeans.Text = "Rice and Beans"
        Me.radRiceAndBeans.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(12, 231)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(314, 61)
        Me.lblResult.TabIndex = 3
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(18, 333)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(83, 27)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(224, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(15, 309)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 6
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(132, 333)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 27)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(241, 333)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 27)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 372)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents radTorta As System.Windows.Forms.RadioButton
    Friend WithEvents radBurrito As System.Windows.Forms.RadioButton
    Friend WithEvents radEnchiladas As System.Windows.Forms.RadioButton
    Friend WithEvents radTacos As System.Windows.Forms.RadioButton
    Friend WithEvents chkGuac As System.Windows.Forms.CheckBox
    Friend WithEvents chkSourCream As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
    Friend WithEvents chkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radQueso As System.Windows.Forms.RadioButton
    Friend WithEvents radChipsAndSalsa As System.Windows.Forms.RadioButton
    Friend WithEvents radRiceAndBeans As System.Windows.Forms.RadioButton
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
