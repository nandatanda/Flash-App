<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstCardTitles = New System.Windows.Forms.ListBox()
        Me.btnNewCard = New System.Windows.Forms.Button()
        Me.btnDeleteCard = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.btnSortListbox = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnExportData = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnMoveCardUp = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMoveCardDown = New System.Windows.Forms.Button()
        Me.btnEditCard = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstCardTitles
        '
        Me.lstCardTitles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstCardTitles.FormattingEnabled = True
        Me.lstCardTitles.ItemHeight = 20
        Me.lstCardTitles.Location = New System.Drawing.Point(516, 22)
        Me.lstCardTitles.Name = "lstCardTitles"
        Me.lstCardTitles.Size = New System.Drawing.Size(235, 564)
        Me.lstCardTitles.TabIndex = 5
        '
        'btnNewCard
        '
        Me.btnNewCard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnNewCard.BackColor = System.Drawing.SystemColors.Control
        Me.btnNewCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewCard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNewCard.Location = New System.Drawing.Point(21, 26)
        Me.btnNewCard.Name = "btnNewCard"
        Me.btnNewCard.Size = New System.Drawing.Size(108, 30)
        Me.btnNewCard.TabIndex = 7
        Me.btnNewCard.Text = "&New"
        Me.btnNewCard.UseVisualStyleBackColor = False
        '
        'btnDeleteCard
        '
        Me.btnDeleteCard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDeleteCard.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeleteCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteCard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeleteCard.Location = New System.Drawing.Point(21, 98)
        Me.btnDeleteCard.Name = "btnDeleteCard"
        Me.btnDeleteCard.Size = New System.Drawing.Size(108, 30)
        Me.btnDeleteCard.TabIndex = 8
        Me.btnDeleteCard.Text = "&Delete"
        Me.btnDeleteCard.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.BackColor = System.Drawing.SystemColors.Window
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 274)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(486, 45)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCaption
        '
        Me.lblCaption.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCaption.BackColor = System.Drawing.SystemColors.Window
        Me.lblCaption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCaption.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.Location = New System.Drawing.Point(12, 335)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(486, 250)
        Me.lblCaption.TabIndex = 10
        Me.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSortListbox
        '
        Me.btnSortListbox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSortListbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnSortListbox.BackgroundImage = Global.Flash_Cards_Generator.My.Resources.Resources.sort_ascending_right
        Me.btnSortListbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSortListbox.FlatAppearance.BorderSize = 0
        Me.btnSortListbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSortListbox.Location = New System.Drawing.Point(62, 98)
        Me.btnSortListbox.Name = "btnSortListbox"
        Me.btnSortListbox.Size = New System.Drawing.Size(25, 25)
        Me.btnSortListbox.TabIndex = 28
        Me.btnSortListbox.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Flash_Cards_Generator.My.Resources.Resources._121494_minimalist_geometric_wallpaper
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(764, 606)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.btnExportData)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 246)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File"
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Location = New System.Drawing.Point(19, 170)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 30)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Print"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnExportData
        '
        Me.btnExportData.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExportData.BackColor = System.Drawing.SystemColors.Control
        Me.btnExportData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportData.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExportData.Location = New System.Drawing.Point(19, 98)
        Me.btnExportData.Name = "btnExportData"
        Me.btnExportData.Size = New System.Drawing.Size(108, 30)
        Me.btnExportData.TabIndex = 12
        Me.btnExportData.Text = "&Export"
        Me.btnExportData.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(19, 62)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 30)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Import"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button8.BackColor = System.Drawing.SystemColors.Control
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.ForeColor = System.Drawing.Color.DarkRed
        Me.Button8.Location = New System.Drawing.Point(19, 206)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(108, 30)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "&Delete"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button7.BackColor = System.Drawing.SystemColors.Control
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button7.Location = New System.Drawing.Point(19, 26)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(108, 30)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "&New"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(19, 134)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&Edit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnMoveCardUp
        '
        Me.btnMoveCardUp.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMoveCardUp.BackColor = System.Drawing.SystemColors.Control
        Me.btnMoveCardUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveCardUp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMoveCardUp.Location = New System.Drawing.Point(21, 134)
        Me.btnMoveCardUp.Name = "btnMoveCardUp"
        Me.btnMoveCardUp.Size = New System.Drawing.Size(108, 30)
        Me.btnMoveCardUp.TabIndex = 10
        Me.btnMoveCardUp.Text = "Move Up"
        Me.btnMoveCardUp.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btnMoveCardDown)
        Me.GroupBox2.Controls.Add(Me.btnEditCard)
        Me.GroupBox2.Controls.Add(Me.btnNewCard)
        Me.GroupBox2.Controls.Add(Me.btnMoveCardUp)
        Me.GroupBox2.Controls.Add(Me.btnDeleteCard)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(348, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(150, 217)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Card"
        '
        'btnMoveCardDown
        '
        Me.btnMoveCardDown.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnMoveCardDown.BackColor = System.Drawing.SystemColors.Control
        Me.btnMoveCardDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveCardDown.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMoveCardDown.Location = New System.Drawing.Point(21, 170)
        Me.btnMoveCardDown.Name = "btnMoveCardDown"
        Me.btnMoveCardDown.Size = New System.Drawing.Size(108, 30)
        Me.btnMoveCardDown.TabIndex = 32
        Me.btnMoveCardDown.Text = "Move D&own"
        Me.btnMoveCardDown.UseVisualStyleBackColor = False
        '
        'btnEditCard
        '
        Me.btnEditCard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEditCard.BackColor = System.Drawing.SystemColors.Control
        Me.btnEditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditCard.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEditCard.Location = New System.Drawing.Point(21, 62)
        Me.btnEditCard.Name = "btnEditCard"
        Me.btnEditCard.Size = New System.Drawing.Size(108, 30)
        Me.btnEditCard.TabIndex = 9
        Me.btnEditCard.Text = "&Edit"
        Me.btnEditCard.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.Button11)
        Me.GroupBox3.Controls.Add(Me.btnSortListbox)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(180, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(150, 138)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "View"
        '
        'Button9
        '
        Me.Button9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button9.BackColor = System.Drawing.SystemColors.Control
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button9.Location = New System.Drawing.Point(21, 62)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(108, 30)
        Me.Button9.TabIndex = 11
        Me.Button9.Text = "Sort"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button11.BackColor = System.Drawing.SystemColors.Control
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button11.Location = New System.Drawing.Point(21, 26)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(108, 30)
        Me.Button11.TabIndex = 7
        Me.Button11.Text = "Quiz"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 606)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lstCardTitles)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.Text = "FlashApp"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstCardTitles As ListBox
    Friend WithEvents btnNewCard As Button
    Friend WithEvents btnDeleteCard As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCaption As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSortListbox As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnMoveCardUp As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEditCard As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnExportData As Button
    Friend WithEvents btnMoveCardDown As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button11 As Button
End Class
