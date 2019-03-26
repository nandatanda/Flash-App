<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quiz_Form
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkTimer = New System.Windows.Forms.CheckBox()
        Me.cmbTimer = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radShowTitle = New System.Windows.Forms.RadioButton()
        Me.radShowCaption = New System.Windows.Forms.RadioButton()
        Me.radShowBoth = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radSortDescending = New System.Windows.Forms.RadioButton()
        Me.radSortAscending = New System.Windows.Forms.RadioButton()
        Me.radSortRandomize = New System.Windows.Forms.RadioButton()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.chkTimer)
        Me.GroupBox3.Controls.Add(Me.cmbTimer)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(289, 297)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(223, 68)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Timer:"
        '
        'chkTimer
        '
        Me.chkTimer.AutoSize = True
        Me.chkTimer.Location = New System.Drawing.Point(11, 30)
        Me.chkTimer.Name = "chkTimer"
        Me.chkTimer.Size = New System.Drawing.Size(103, 17)
        Me.chkTimer.TabIndex = 16
        Me.chkTimer.Text = "Show next after:"
        Me.chkTimer.UseVisualStyleBackColor = True
        '
        'cmbTimer
        '
        Me.cmbTimer.Enabled = False
        Me.cmbTimer.FormattingEnabled = True
        Me.cmbTimer.Items.AddRange(New Object() {"10 sec.", "15 sec.", "20 sec.", "30 sec.", "45 sec.", "60 sec."})
        Me.cmbTimer.Location = New System.Drawing.Point(151, 28)
        Me.cmbTimer.Name = "cmbTimer"
        Me.cmbTimer.Size = New System.Drawing.Size(66, 21)
        Me.cmbTimer.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.radShowTitle)
        Me.GroupBox2.Controls.Add(Me.radShowCaption)
        Me.GroupBox2.Controls.Add(Me.radShowBoth)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(289, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 100)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Show:"
        '
        'radShowTitle
        '
        Me.radShowTitle.AutoSize = True
        Me.radShowTitle.Checked = True
        Me.radShowTitle.Location = New System.Drawing.Point(89, 12)
        Me.radShowTitle.Name = "radShowTitle"
        Me.radShowTitle.Size = New System.Drawing.Size(45, 17)
        Me.radShowTitle.TabIndex = 14
        Me.radShowTitle.TabStop = True
        Me.radShowTitle.Text = "Title"
        Me.radShowTitle.UseVisualStyleBackColor = True
        '
        'radShowCaption
        '
        Me.radShowCaption.AutoSize = True
        Me.radShowCaption.Location = New System.Drawing.Point(89, 42)
        Me.radShowCaption.Name = "radShowCaption"
        Me.radShowCaption.Size = New System.Drawing.Size(61, 17)
        Me.radShowCaption.TabIndex = 15
        Me.radShowCaption.Text = "Caption"
        Me.radShowCaption.UseVisualStyleBackColor = True
        '
        'radShowBoth
        '
        Me.radShowBoth.AutoSize = True
        Me.radShowBoth.Location = New System.Drawing.Point(89, 72)
        Me.radShowBoth.Name = "radShowBoth"
        Me.radShowBoth.Size = New System.Drawing.Size(47, 17)
        Me.radShowBoth.TabIndex = 24
        Me.radShowBoth.Text = "Both"
        Me.radShowBoth.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.radSortDescending)
        Me.GroupBox1.Controls.Add(Me.radSortAscending)
        Me.GroupBox1.Controls.Add(Me.radSortRandomize)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(289, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 100)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sort:"
        '
        'radSortDescending
        '
        Me.radSortDescending.AutoSize = True
        Me.radSortDescending.Location = New System.Drawing.Point(89, 41)
        Me.radSortDescending.Name = "radSortDescending"
        Me.radSortDescending.Size = New System.Drawing.Size(82, 17)
        Me.radSortDescending.TabIndex = 22
        Me.radSortDescending.Text = "Descending"
        Me.radSortDescending.UseVisualStyleBackColor = True
        '
        'radSortAscending
        '
        Me.radSortAscending.AutoSize = True
        Me.radSortAscending.Checked = True
        Me.radSortAscending.Location = New System.Drawing.Point(89, 11)
        Me.radSortAscending.Name = "radSortAscending"
        Me.radSortAscending.Size = New System.Drawing.Size(75, 17)
        Me.radSortAscending.TabIndex = 21
        Me.radSortAscending.TabStop = True
        Me.radSortAscending.Text = "Ascending"
        Me.radSortAscending.UseVisualStyleBackColor = True
        '
        'radSortRandomize
        '
        Me.radSortRandomize.AutoSize = True
        Me.radSortRandomize.Location = New System.Drawing.Point(89, 71)
        Me.radSortRandomize.Name = "radSortRandomize"
        Me.radSortRandomize.Size = New System.Drawing.Size(78, 17)
        Me.radSortRandomize.TabIndex = 23
        Me.radSortRandomize.Text = "Randomize"
        Me.radSortRandomize.UseVisualStyleBackColor = True
        '
        'Quiz_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Quiz_Form"
        Me.Text = "Quiz_Form"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkTimer As CheckBox
    Friend WithEvents cmbTimer As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radShowTitle As RadioButton
    Friend WithEvents radShowCaption As RadioButton
    Friend WithEvents radShowBoth As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radSortDescending As RadioButton
    Friend WithEvents radSortAscending As RadioButton
    Friend WithEvents radSortRandomize As RadioButton
End Class
