﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmCardEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCardDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmCardMoveUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmCardMoveDown = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmViewFlip = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmViewNextCard = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviousCardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SortAZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AscendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescendingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmViewHideCardNames = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmMain = New System.Windows.Forms.MenuStrip()
        Me.btnSortListbox = New System.Windows.Forms.Button()
        Me.picCardBackground = New System.Windows.Forms.PictureBox()
        Me.tsmMain.SuspendLayout()
        CType(Me.picCardBackground, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lstCardTitles.Name = "lstCardTitles"
        Me.lstCardTitles.Size = New System.Drawing.Size(584, 168)
        Me.lstCardTitles.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.BackColor = System.Drawing.SystemColors.Window
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(77, 234)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(431, 45)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCaption
        '
        Me.lblCaption.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCaption.BackColor = System.Drawing.SystemColors.Window
        Me.lblCaption.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaption.Location = New System.Drawing.Point(76, 145)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(431, 222)
        Me.lblCaption.TabIndex = 10
        Me.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.tsmFileNew.Size = New System.Drawing.Size(186, 22)
        Me.tsmFileNew.Text = "&New"
        '
        'tsmFileOpen
        '
        Me.tsmFileOpen.Image = CType(resources.GetObject("tsmFileOpen.Image"), System.Drawing.Image)
        Me.tsmFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmFileOpen.Name = "tsmFileOpen"
        Me.tsmFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.tsmFileOpen.Size = New System.Drawing.Size(186, 22)
        Me.tsmFileOpen.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(183, 6)
        '
        'tsmFileSave
        '
        Me.tsmFileSave.Image = CType(resources.GetObject("tsmFileSave.Image"), System.Drawing.Image)
        Me.tsmFileSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmFileSave.Name = "tsmFileSave"
        Me.tsmFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.tsmFileSave.Size = New System.Drawing.Size(186, 22)
        Me.tsmFileSave.Text = "&Save"
        '
        'tsmFileSaveAs
        '
        Me.tsmFileSaveAs.Name = "tsmFileSaveAs"
        Me.tsmFileSaveAs.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.tsmFileSaveAs.Size = New System.Drawing.Size(186, 22)
        Me.tsmFileSaveAs.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(183, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(183, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'CardToolStripMenuItem
        '
        Me.CardToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmCardNew, Me.ToolStripSeparator6, Me.tsmCardEdit, Me.tsmCardDelete, Me.ToolStripSeparator4, Me.tsmCardMoveUp, Me.tsmCardMoveDown})
        Me.CardToolStripMenuItem.Name = "CardToolStripMenuItem"
        Me.CardToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.CardToolStripMenuItem.Text = "&Card"
        '
        'tsmCardNew
        '
        Me.tsmCardNew.Image = Global.Flash_Cards_Generator.My.Resources.Resources.card_new_icon
        Me.tsmCardNew.Name = "tsmCardNew"
        Me.tsmCardNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.tsmCardNew.Size = New System.Drawing.Size(199, 22)
        Me.tsmCardNew.Text = "New"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(196, 6)
        '
        'tsmCardEdit
        '
        Me.tsmCardEdit.Image = Global.Flash_Cards_Generator.My.Resources.Resources.card_edit_icon
        Me.tsmCardEdit.Name = "tsmCardEdit"
        Me.tsmCardEdit.Size = New System.Drawing.Size(199, 22)
        Me.tsmCardEdit.Text = "Edit..."
        '
        'tsmCardDelete
        '
        Me.tsmCardDelete.Image = Global.Flash_Cards_Generator.My.Resources.Resources.card_delete_icon
        Me.tsmCardDelete.Name = "tsmCardDelete"
        Me.tsmCardDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.tsmCardDelete.Size = New System.Drawing.Size(199, 22)
        Me.tsmCardDelete.Text = "Delete"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(196, 6)
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
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.HowToToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'HowToToolStripMenuItem
        '
        Me.HowToToolStripMenuItem.Name = "HowToToolStripMenuItem"
        Me.HowToToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HowToToolStripMenuItem.Text = "User Manual"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(177, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmViewFlip, Me.tsmViewNextCard, Me.PreviousCardToolStripMenuItem, Me.ToolStripSeparator3, Me.SortAZToolStripMenuItem, Me.tsmViewHideCardNames})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'tsmViewFlip
        '
        Me.tsmViewFlip.Name = "tsmViewFlip"
        Me.tsmViewFlip.Size = New System.Drawing.Size(180, 22)
        Me.tsmViewFlip.Text = "Flip"
        '
        'tsmViewNextCard
        '
        Me.tsmViewNextCard.Name = "tsmViewNextCard"
        Me.tsmViewNextCard.Size = New System.Drawing.Size(180, 22)
        Me.tsmViewNextCard.Text = "Next Card"
        '
        'PreviousCardToolStripMenuItem
        '
        Me.PreviousCardToolStripMenuItem.Name = "PreviousCardToolStripMenuItem"
        Me.PreviousCardToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PreviousCardToolStripMenuItem.Text = "Previous Card"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'SortAZToolStripMenuItem
        '
        Me.SortAZToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AscendingToolStripMenuItem, Me.DescendingToolStripMenuItem})
        Me.SortAZToolStripMenuItem.Name = "SortAZToolStripMenuItem"
        Me.SortAZToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SortAZToolStripMenuItem.Text = "Sort"
        '
        'AscendingToolStripMenuItem
        '
        Me.AscendingToolStripMenuItem.Name = "AscendingToolStripMenuItem"
        Me.AscendingToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.AscendingToolStripMenuItem.Text = "Ascending"
        '
        'DescendingToolStripMenuItem
        '
        Me.DescendingToolStripMenuItem.Name = "DescendingToolStripMenuItem"
        Me.DescendingToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.DescendingToolStripMenuItem.Text = "Descending"
        '
        'tsmViewHideCardNames
        '
        Me.tsmViewHideCardNames.CheckOnClick = True
        Me.tsmViewHideCardNames.Name = "tsmViewHideCardNames"
        Me.tsmViewHideCardNames.Size = New System.Drawing.Size(180, 22)
        Me.tsmViewHideCardNames.Text = "Hide Card Names"
        '
        'tsmMain
        '
        Me.tsmMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.CardToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.tsmMain.Location = New System.Drawing.Point(0, 0)
        Me.tsmMain.Name = "tsmMain"
        Me.tsmMain.Size = New System.Drawing.Size(584, 24)
        Me.tsmMain.TabIndex = 33
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
        'picCardBackground
        '
        Me.picCardBackground.Image = Global.Flash_Cards_Generator.My.Resources.Resources.flashcard_background_blue
        Me.picCardBackground.Location = New System.Drawing.Point(41, 120)
        Me.picCardBackground.Name = "picCardBackground"
        Me.picCardBackground.Size = New System.Drawing.Size(503, 277)
        Me.picCardBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCardBackground.TabIndex = 36
        Me.picCardBackground.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(584, 688)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblFilePath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSortListbox)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.lstCardTitles)
        Me.Controls.Add(Me.tsmMain)
        Me.Controls.Add(Me.picCardBackground)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.tsmMain
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 727)
        Me.MinimumSize = New System.Drawing.Size(600, 726)
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FlashApp"
        Me.tsmMain.ResumeLayout(False)
        Me.tsmMain.PerformLayout()
        CType(Me.picCardBackground, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SortAZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AscendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescendingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HowToToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picCardBackground As PictureBox
    Friend WithEvents tsmViewHideCardNames As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsmViewFlip As ToolStripMenuItem
    Friend WithEvents tsmViewNextCard As ToolStripMenuItem
    Friend WithEvents PreviousCardToolStripMenuItem As ToolStripMenuItem
End Class
