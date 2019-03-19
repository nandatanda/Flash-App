<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstCardTitles = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radShowTitle = New System.Windows.Forms.RadioButton()
        Me.radShowCaption = New System.Windows.Forms.RadioButton()
        Me.chkTimer = New System.Windows.Forms.CheckBox()
        Me.cmbTimer = New System.Windows.Forms.ComboBox()
        Me.btnBeginQuiz = New System.Windows.Forms.Button()
        Me.radSortDescending = New System.Windows.Forms.RadioButton()
        Me.radSortAscending = New System.Windows.Forms.RadioButton()
        Me.radSortRandomize = New System.Windows.Forms.RadioButton()
        Me.radShowBoth = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(242, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(2, 393)
        Me.Label1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(541, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(2, 393)
        Me.Label3.TabIndex = 4
        '
        'lstCardTitles
        '
        Me.lstCardTitles.FormattingEnabled = True
        Me.lstCardTitles.ItemHeight = 20
        Me.lstCardTitles.Location = New System.Drawing.Point(7, 89)
        Me.lstCardTitles.Name = "lstCardTitles"
        Me.lstCardTitles.Size = New System.Drawing.Size(227, 244)
        Me.lstCardTitles.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "My Flashcards"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(21, 357)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 30)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = "&New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(145, 357)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 30)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.Window
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitle.Location = New System.Drawing.Point(252, 89)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(281, 35)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCaption
        '
        Me.lblCaption.BackColor = System.Drawing.SystemColors.Window
        Me.lblCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCaption.Location = New System.Drawing.Point(252, 139)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(281, 194)
        Me.lblCaption.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(348, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Card Viewer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(617, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Study Helper"
        '
        'radShowTitle
        '
        Me.radShowTitle.AutoSize = True
        Me.radShowTitle.Checked = True
        Me.radShowTitle.Location = New System.Drawing.Point(89, 12)
        Me.radShowTitle.Name = "radShowTitle"
        Me.radShowTitle.Size = New System.Drawing.Size(56, 24)
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
        Me.radShowCaption.Size = New System.Drawing.Size(79, 24)
        Me.radShowCaption.TabIndex = 15
        Me.radShowCaption.Text = "Caption"
        Me.radShowCaption.UseVisualStyleBackColor = True
        '
        'chkTimer
        '
        Me.chkTimer.AutoSize = True
        Me.chkTimer.Location = New System.Drawing.Point(59, 33)
        Me.chkTimer.Name = "chkTimer"
        Me.chkTimer.Size = New System.Drawing.Size(15, 14)
        Me.chkTimer.TabIndex = 16
        Me.chkTimer.UseVisualStyleBackColor = True
        '
        'cmbTimer
        '
        Me.cmbTimer.Enabled = False
        Me.cmbTimer.FormattingEnabled = True
        Me.cmbTimer.Items.AddRange(New Object() {"10", "15", "20", "30", "45", "60"})
        Me.cmbTimer.Location = New System.Drawing.Point(89, 26)
        Me.cmbTimer.Name = "cmbTimer"
        Me.cmbTimer.Size = New System.Drawing.Size(56, 28)
        Me.cmbTimer.TabIndex = 17
        '
        'btnBeginQuiz
        '
        Me.btnBeginQuiz.Location = New System.Drawing.Point(612, 357)
        Me.btnBeginQuiz.Name = "btnBeginQuiz"
        Me.btnBeginQuiz.Size = New System.Drawing.Size(104, 30)
        Me.btnBeginQuiz.TabIndex = 19
        Me.btnBeginQuiz.Text = "Begin &Quiz"
        Me.btnBeginQuiz.UseVisualStyleBackColor = True
        '
        'radSortDescending
        '
        Me.radSortDescending.AutoSize = True
        Me.radSortDescending.Location = New System.Drawing.Point(89, 41)
        Me.radSortDescending.Name = "radSortDescending"
        Me.radSortDescending.Size = New System.Drawing.Size(105, 24)
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
        Me.radSortAscending.Size = New System.Drawing.Size(96, 24)
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
        Me.radSortRandomize.Size = New System.Drawing.Size(102, 24)
        Me.radSortRandomize.TabIndex = 23
        Me.radSortRandomize.Text = "Randomize"
        Me.radSortRandomize.UseVisualStyleBackColor = True
        '
        'radShowBoth
        '
        Me.radShowBoth.AutoSize = True
        Me.radShowBoth.Location = New System.Drawing.Point(89, 72)
        Me.radShowBoth.Name = "radShowBoth"
        Me.radShowBoth.Size = New System.Drawing.Size(58, 24)
        Me.radShowBoth.TabIndex = 24
        Me.radShowBoth.Text = "Both"
        Me.radShowBoth.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSortDescending)
        Me.GroupBox1.Controls.Add(Me.radSortAscending)
        Me.GroupBox1.Controls.Add(Me.radSortRandomize)
        Me.GroupBox1.Location = New System.Drawing.Point(553, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 100)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sort:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radShowTitle)
        Me.GroupBox2.Controls.Add(Me.radShowCaption)
        Me.GroupBox2.Controls.Add(Me.radShowBoth)
        Me.GroupBox2.Location = New System.Drawing.Point(553, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 100)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Show:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkTimer)
        Me.GroupBox3.Controls.Add(Me.cmbTimer)
        Me.GroupBox3.Location = New System.Drawing.Point(553, 265)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(223, 68)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Timer:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBeginQuiz)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstCardTitles)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.Text = "FlashApp"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstCardTitles As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCaption As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents radShowTitle As RadioButton
    Friend WithEvents radShowCaption As RadioButton
    Friend WithEvents chkTimer As CheckBox
    Friend WithEvents cmbTimer As ComboBox
    Friend WithEvents btnBeginQuiz As Button
    Friend WithEvents radSortDescending As RadioButton
    Friend WithEvents radSortAscending As RadioButton
    Friend WithEvents radSortRandomize As RadioButton
    Friend WithEvents radShowBoth As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
