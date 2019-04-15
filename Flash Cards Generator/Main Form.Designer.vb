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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lstCardTitles = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.btnSortListbox = New System.Windows.Forms.Button()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCardNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCardEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCardDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCardMoveUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCardMoveDown = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmMain = New System.Windows.Forms.MenuStrip()
        Me.tsmMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstCardTitles
        '
        Me.lstCardTitles.BackColor = System.Drawing.SystemColors.MenuBar
        Me.lstCardTitles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstCardTitles.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lstCardTitles.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCardTitles.FormattingEnabled = True
        Me.lstCardTitles.ItemHeight = 21
        Me.lstCardTitles.Location = New System.Drawing.Point(0, 520)
        Me.lstCardTitles.MultiColumn = True
        Me.lstCardTitles.Name = "lstCardTitles"
        Me.lstCardTitles.Size = New System.Drawing.Size(584, 168)
        Me.lstCardTitles.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(41, 119)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(503, 45)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCaption
        '
        Me.lblCaption.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCaption.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.Location = New System.Drawing.Point(41, 164)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(503, 249)
        Me.lblCaption.TabIndex = 10
        Me.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSortListbox
        '
        Me.btnSortListbox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSortListbox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSortListbox.BackgroundImage = Global.Flash_Cards_Generator.My.Resources.Resources.sort_ascending_right
        Me.btnSortListbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSortListbox.FlatAppearance.BorderSize = 0
        Me.btnSortListbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSortListbox.Location = New System.Drawing.Point(547, 486)
        Me.btnSortListbox.Name = "btnSortListbox"
        Me.btnSortListbox.Size = New System.Drawing.Size(25, 25)
        Me.btnSortListbox.TabIndex = 28
        Me.btnSortListbox.UseVisualStyleBackColor = False
        '
        'lblFilePath
        '
        Me.lblFilePath.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFilePath.AutoSize = True
        Me.lblFilePath.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilePath.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFilePath.Location = New System.Drawing.Point(12, 465)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(0, 20)
        Me.lblFilePath.TabIndex = 34
        Me.lblFilePath.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(0, 474)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(584, 3)
        Me.Label2.TabIndex = 35
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFileNew, Me.tsmFileOpen, Me.toolStripSeparator, Me.tsmFileSave, Me.tsmFileSaveAs, Me.toolStripSeparator1, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "&File"
        '
        'tsmFileNew
        '
        Me.tsmFileNew.Image = CType(resources.GetObject("tsmFileNew.Image"), System.Drawing.Image)
        Me.tsmFileNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmFileNew.Name = "tsmFileNew"
        Me.tsmFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.tsmFileNew.Size = New System.Drawing.Size(146, 22)
        Me.tsmFileNew.Text = "&New"
        '
        'tsmFileOpen
        '
        Me.tsmFileOpen.Image = CType(resources.GetObject("tsmFileOpen.Image"), System.Drawing.Image)
        Me.tsmFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmFileOpen.Name = "tsmFileOpen"
        Me.tsmFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.tsmFileOpen.Size = New System.Drawing.Size(146, 22)
        Me.tsmFileOpen.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(143, 6)
        '
        'tsmFileSave
        '
        Me.tsmFileSave.Image = CType(resources.GetObject("tsmFileSave.Image"), System.Drawing.Image)
        Me.tsmFileSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmFileSave.Name = "tsmFileSave"
        Me.tsmFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.tsmFileSave.Size = New System.Drawing.Size(146, 22)
        Me.tsmFileSave.Text = "&Save"
        '
        'tsmFileSaveAs
        '
        Me.tsmFileSaveAs.Name = "tsmFileSaveAs"
        Me.tsmFileSaveAs.Size = New System.Drawing.Size(146, 22)
        Me.tsmFileSaveAs.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(143, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'CardToolStripMenuItem
        '
        Me.CardToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmCardNew, Me.tsmCardEdit, Me.tsmCardDelete, Me.tsmCardMoveUp, Me.tsmCardMoveDown})
        Me.CardToolStripMenuItem.Name = "CardToolStripMenuItem"
        Me.CardToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.CardToolStripMenuItem.Text = "&Card"
        '
        'tsmCardNew
        '
        Me.tsmCardNew.Name = "tsmCardNew"
        Me.tsmCardNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.tsmCardNew.Size = New System.Drawing.Size(199, 22)
        Me.tsmCardNew.Text = "Create"
        '
        'tsmCardEdit
        '
        Me.tsmCardEdit.Name = "tsmCardEdit"
        Me.tsmCardEdit.Size = New System.Drawing.Size(199, 22)
        Me.tsmCardEdit.Text = "Edit..."
        '
        'tsmCardDelete
        '
        Me.tsmCardDelete.Name = "tsmCardDelete"
        Me.tsmCardDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.tsmCardDelete.Size = New System.Drawing.Size(199, 22)
        Me.tsmCardDelete.Text = "Delete"
        '
        'tsmCardMoveUp
        '
        Me.tsmCardMoveUp.Name = "tsmCardMoveUp"
        Me.tsmCardMoveUp.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.tsmCardMoveUp.Size = New System.Drawing.Size(199, 22)
        Me.tsmCardMoveUp.Text = "Move Up"
        '
        'tsmCardMoveDown
        '
        Me.tsmCardMoveDown.Name = "tsmCardMoveDown"
        Me.tsmCardMoveDown.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.tsmCardMoveDown.Size = New System.Drawing.Size(199, 22)
        Me.tsmCardMoveDown.Text = "Move Down"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(113, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'tsmMain
        '
        Me.tsmMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.CardToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.tsmMain.Location = New System.Drawing.Point(0, 0)
        Me.tsmMain.Name = "tsmMain"
        Me.tsmMain.Size = New System.Drawing.Size(584, 24)
        Me.tsmMain.TabIndex = 33
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(584, 688)
        Me.Controls.Add(Me.lblFilePath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSortListbox)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lstCardTitles)
        Me.Controls.Add(Me.tsmMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.tsmMain
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 727)
        Me.MinimumSize = New System.Drawing.Size(600, 727)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FlashApp"
        Me.tsmMain.ResumeLayout(False)
        Me.tsmMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstCardTitles As ListBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCaption As Label
    Friend WithEvents btnSortListbox As Button
    Friend WithEvents lblFilePath As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents tsmFileNew As ToolStripMenuItem
    Friend WithEvents tsmFileOpen As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents tsmFileSave As ToolStripMenuItem
    Friend WithEvents tsmFileSaveAs As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmCardNew As ToolStripMenuItem
    Friend WithEvents tsmCardEdit As ToolStripMenuItem
    Friend WithEvents tsmCardDelete As ToolStripMenuItem
    Friend WithEvents tsmCardMoveUp As ToolStripMenuItem
    Friend WithEvents tsmCardMoveDown As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmMain As MenuStrip
End Class
