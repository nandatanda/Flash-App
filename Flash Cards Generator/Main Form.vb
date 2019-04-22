' Name:         Flashcards Project
' Purpose:      Creates, stores, and retrieves digital flashcards.
' Programmer:   Ali Elayni on 3.17.2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private BasePath As String = My.Application.Info.DirectoryPath
    Private WorkingFilePath As String = String.Empty
    Private HasUnsavedChanges As Boolean

    Public LibraryList As List(Of List(Of String)) = New List(Of List(Of String))


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblTitle.Visible = False
        lblTitle.Text = "Welcome"
        lblCaption.Text = "To start, create a new card library or open an existing one using the 'file' menu above."
    End Sub

    Private Sub lstCardTitles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCardTitles.SelectedIndexChanged
        UpdateCurrentCard()
    End Sub

    Private Sub btnSortListbox_Click(sender As Object, e As EventArgs) Handles btnSortListbox.Click
        If LibraryList.Count > 0 Then
            Static ListboxIsInAscendingOrder As Boolean
            Dim LatestSelectedItem As String = lstCardTitles.SelectedItem.ToString

            If lstCardTitles.Items.Count > 0 Then
                If ListboxIsInAscendingOrder Then
                    LibraryList.Reverse()
                    btnSortListbox.BackgroundImage = My.Resources.sort_ascending_right
                    ListboxIsInAscendingOrder = False
                Else
                    LibraryList.Sort(Function(x, y) x(0).CompareTo(y(0)))
                    btnSortListbox.BackgroundImage = My.Resources.sort_descending_right
                    ListboxIsInAscendingOrder = True
                End If
            End If

            UpdateCardTitles()
            ClearCurrentCard()
            lstCardTitles.SelectedItem = LatestSelectedItem
        End If
    End Sub

    ' Click Events for ToolStripMenu -> File

    Private Sub tsmFileNew_Click(sender As Object, e As EventArgs) Handles tsmFileNew.Click
        If HasUnsavedChanges Then
            Dim Response As Integer = MessageBox.Show("The current library has unsaved changes. Creating a new one will result in loss of data. Save before continuing? ", "New", MessageBoxButtons.YesNoCancel)

            If Response = DialogResult.Cancel Then
                Exit Sub
            ElseIf Response = DialogResult.Yes Then
                If WorkingFilePath = String.Empty Then
                    Dim MyPrompt As SaveFileDialog = New SaveFileDialog With {
                    .DefaultExt = "txt",
                    .FileName = "my-flashcards",
                    .InitialDirectory = BasePath,
                    .Filter = "All files|*.*|Text files|*.txt",
                    .Title = "Open"
                    }
                    If MyPrompt.ShowDialog() <> DialogResult.Cancel Then
                        WorkingFilePath = MyPrompt.FileName
                        SaveToFile(WorkingFilePath)
                    Else
                        Exit Sub
                    End If
                Else
                    SaveToFile(WorkingFilePath)
                End If
            End If
        End If

        WorkingFilePath = String.Empty
        LibraryList = New List(Of List(Of String))
        HasUnsavedChanges = False

        ClearCurrentCard()
        lstCardTitles.Items.Clear()
        lblFilePath.Text = "New Library*"
        lblTitle.Text = "New Library"
        lblCaption.Text = "Create your first card with 'Ctrl + C' or by using the file menu above. The new card will be displayed here."
    End Sub

    Private Sub tsmFileOpen_Click(sender As Object, e As EventArgs) Handles tsmFileOpen.Click
        ' open a file from disk and load it into library list

        If HasUnsavedChanges Then
            ' prompt for emergency save
            Dim Response As Integer = MessageBox.Show("The current library has unsaved changes. Opening another one will result in loss of data. Save before continuing? ", "Open", MessageBoxButtons.YesNoCancel)
            If Response = DialogResult.Cancel Then
                Exit Sub

            ElseIf Response = DialogResult.Yes Then
                ' set up and confirm save

                If WorkingFilePath = String.Empty Then
                    ' define prompt for save location
                    Dim SavePrompt As SaveFileDialog = New SaveFileDialog With {
                    .DefaultExt = "txt",
                    .FileName = "my-flashcards",
                    .InitialDirectory = BasePath,
                    .Filter = "All files|*.*|Text files|*.txt",
                    .Title = "Save"}

                    ' assign filename to path or cancel operation
                    If SavePrompt.ShowDialog() <> DialogResult.Cancel Then
                        WorkingFilePath = SavePrompt.FileName
                    Else
                        Exit Sub
                    End If
                End If

                ' perform save
                SaveToFile(WorkingFilePath)
                HasUnsavedChanges = False
                lblFilePath.Text = ShortenPath(WorkingFilePath)
            End If
        End If

        ' define prompt for location of file to be opened
        Dim OpenPrompt As OpenFileDialog = New OpenFileDialog With {
                .DefaultExt = "txt",
                .FileName = "data",
                .InitialDirectory = BasePath,
                .Filter = "All files|*.*|Text files|*.txt",
                .Title = "Open"}

        ' open file or cancel operation
        If OpenPrompt.ShowDialog() <> DialogResult.Cancel Then
            WorkingFilePath = OpenPrompt.FileName
            LibraryList = ParseFile(WorkingFilePath)

            ' update interface
            UpdateCardTitles()
            lblFilePath.Text = ShortenPath(WorkingFilePath)
            If lstCardTitles.Items.Count > 0 Then
                lstCardTitles.SelectedIndex = 0
                UpdateCurrentCard()
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub tsmFileSave_Click(sender As Object, e As EventArgs) Handles tsmFileSave.Click
        If HasUnsavedChanges Then
            If WorkingFilePath = String.Empty Then
                ' define prompt for save location
                Dim MyPrompt As SaveFileDialog = New SaveFileDialog With {
                .DefaultExt = "txt",
                .FileName = "my-flashcards",
                .InitialDirectory = BasePath,
                .Filter = "All files|*.*|Text files|*.txt",
                .Title = "Open"}

                ' assign filename to path or cancel operation
                If MyPrompt.ShowDialog() <> DialogResult.Cancel Then
                    WorkingFilePath = MyPrompt.FileName
                Else
                    Exit Sub
                End If
            End If

            'perform save
            SaveToFile(WorkingFilePath)
            HasUnsavedChanges = False

            ' update interface
            lblFilePath.Text = ShortenPath(WorkingFilePath)
        End If
    End Sub

    Private Sub tsmFileSaveAs_Click(sender As Object, e As EventArgs) Handles tsmFileSaveAs.Click
        ' define prompt for save location
        Dim MyPrompt As SaveFileDialog = New SaveFileDialog With {
                .DefaultExt = "txt",
                .FileName = "my-flashcards",
                .InitialDirectory = BasePath,
                .Filter = "All files|*.*|Text files|*.txt",
                .Title = "Open"}

        ' assign filename to path or cancel operation
        If MyPrompt.ShowDialog() <> DialogResult.Cancel Then
            WorkingFilePath = MyPrompt.FileName
        Else
            Exit Sub
        End If

        'perform save
        SaveToFile(WorkingFilePath)
        HasUnsavedChanges = False

        ' update interface
        lblFilePath.Text = ShortenPath(WorkingFilePath)
    End Sub

    ' Click Events for ToolStripMenu -> Card

    Private Sub tsmCardNew_Click(sender As Object, e As EventArgs) Handles tsmCardNew.Click
        ' create a new card record and add it to library list

        ' input new card's title
        Dim Title As String = InputBox("Enter a title for your flashcard.", "Create Card", "Title")
        If Title = "" Then
            Exit Sub
        End If

        ' input new card's caption
        Dim Caption As String = InputBox("Enter the text you want to appear in the body of the flashcard.", "Create Card", "Text")
        If Caption = "" Then
            Exit Sub
        End If

        ' define new card and add to list
        Dim NewCard As List(Of String) = New List(Of String)
        NewCard.Add(Title)
        NewCard.Add(Caption)
        LibraryList.Add(NewCard)

        ' update interface
        UpdateCardTitles()
        lstCardTitles.SelectedItem = Title

        HasUnsavedChanges = True
        If WorkingFilePath = String.Empty Then
            lblFilePath.Text = "New Library*"
        Else
            lblFilePath.Text = ShortenPath(WorkingFilePath) + "*"
        End If
    End Sub

    Private Sub tsmCardEdit_Click(sender As Object, e As EventArgs) Handles tsmCardEdit.Click
        ' edit a card's title/caption and replace in library list

        If LibraryList.Count > 0 Then
            ' read original card from list
            Dim Index As Integer = lstCardTitles.SelectedIndex
            Dim Title As String = LibraryList(Index)(0)
            Dim Caption As String = LibraryList(Index)(1)

            ' input new title
            Title = InputBox("Change the text of the title.", "Edit", Title)
            If Title = "" Then
                Exit Sub
            End If

            ' input new caption
            Caption = InputBox("Change the text of the caption, or body of the card.", "Edit", Caption)
            If Caption = "" Then
                Exit Sub
            End If

            ' define edited card and replace in list
            Dim EditedCard As List(Of String) = New List(Of String)
            EditedCard.Add(Title)
            EditedCard.Add(Caption)
            If Not EditedCard.SequenceEqual(LibraryList(Index)) Then
                LibraryList(Index) = EditedCard
                HasUnsavedChanges = True
            End If

            ' update interface
            UpdateCardTitles()
            lstCardTitles.SelectedIndex = Index
            UpdateCurrentCard()
            lblFilePath.Text = ShortenPath(WorkingFilePath) + "*"
        Else
            MessageBox.Show("There are no cards to edit in the current library.", "Edit")
        End If
    End Sub

    Private Sub tsmCardDelete_Click(sender As Object, e As EventArgs) Handles tsmCardDelete.Click
        ' remove selected card from list

        If LibraryList.Count > 0 Then
            Dim Response As Integer = MessageBox.Show("Are you sure you want to delete this flashcard?", "Delete", MessageBoxButtons.OKCancel)
            If Response = DialogResult.OK Then
                Dim TargetIndex As Integer = lstCardTitles.SelectedIndex
                Dim LargestIndex As Integer = lstCardTitles.Items.Count - 2

                LibraryList.RemoveAt(TargetIndex)

                ' update interface
                UpdateCardTitles()
                ClearCurrentCard()

                ' choose new selected item
                If TargetIndex > LargestIndex Then
                    lstCardTitles.SelectedIndex = LargestIndex
                Else
                    lstCardTitles.SelectedIndex = TargetIndex
                End If

                HasUnsavedChanges = True
                lblFilePath.Text = ShortenPath(WorkingFilePath) + "*"
            End If
        Else
            MessageBox.Show("There are no cards to delete in the current library.", "Delete")
        End If
    End Sub

    Private Sub tsmCardMoveUp_Click(sender As Object, e As EventArgs) Handles tsmCardMoveUp.Click
        If LibraryList.Count > 1 Then
            Dim CurrentIndex As Integer = lstCardTitles.SelectedIndex
            Dim TargetIndex As Integer = lstCardTitles.SelectedIndex - 1
            Dim TemporaryValue As List(Of String)

            'swap positions in list
            If TargetIndex >= 0 Then
                TemporaryValue = LibraryList(TargetIndex)
                LibraryList(TargetIndex) = LibraryList(CurrentIndex)
                LibraryList(CurrentIndex) = TemporaryValue

                UpdateCardTitles()
                lstCardTitles.SelectedIndex = TargetIndex
            Else
                lstCardTitles.SelectedIndex = 0
            End If

            HasUnsavedChanges = True
            lblFilePath.Text = ShortenPath(WorkingFilePath) + "*"
        End If
    End Sub

    Private Sub tsmCardMoveDown_Click(sender As Object, e As EventArgs) Handles tsmCardMoveDown.Click
        If LibraryList.Count > 1 Then
            Dim CurrentIndex As Integer = lstCardTitles.SelectedIndex
            Dim TargetIndex As Integer = lstCardTitles.SelectedIndex + 1
            Dim LargestIndex As Integer = lstCardTitles.Items.Count - 1
            Dim TemporaryValue As List(Of String)

            'swap values and write to file
            If TargetIndex <= LargestIndex Then
                TemporaryValue = LibraryList(TargetIndex)
                LibraryList(TargetIndex) = LibraryList(CurrentIndex)
                LibraryList(CurrentIndex) = TemporaryValue

                UpdateCardTitles()
                lstCardTitles.SelectedIndex = TargetIndex
            Else
                lstCardTitles.SelectedIndex = LargestIndex
            End If

            HasUnsavedChanges = True
            lblFilePath.Text = ShortenPath(WorkingFilePath) + "*"
        End If
    End Sub

    ' Member Functions & Subs

    Private Function ParseFile(ByVal Path As String) As List(Of List(Of String))
        ' return a list of cards where each element is a list of that card's components
        Dim MyLibrary As List(Of List(Of String)) = New List(Of List(Of String))
        Try
            For Each Line As String In IO.File.ReadLines(Path)
                Dim Record As List(Of String) = New List(Of String) From {
                Split(Line, ";")(0),
                Split(Line, ";")(1)
            }
                MyLibrary.Add(Record)
            Next
        Catch
            MessageBox.Show("Unable to import library. The file may be corrupted or not of the appropriate type.", "Error")
        End Try
        Return MyLibrary
    End Function

    Private Function ShortenPath(ByVal Path As String) As String
        ' return a short path for display in interface

        Dim PathArray As String() = WorkingFilePath.Split("\"c)
        If PathArray.Count > 4 Then
            Dim RootPath As String = PathArray(0) + "\"
            Dim ThirdToLastPath As String = PathArray(PathArray.Count() - 3) + "\"
            Dim SecondToLastPath As String = PathArray(PathArray.Count() - 2) + "\"
            Dim LastPath As String = PathArray(PathArray.Count() - 1)

            Return RootPath + "...\" + ThirdToLastPath + SecondToLastPath + LastPath
        Else
            Return WorkingFilePath
        End If

    End Function

    Private Sub SaveToFile(ByVal Path As String)
        ' write the current list of cards to file
        Dim Lines As List(Of String) = New List(Of String)
        Try
            For Each Line As List(Of String) In LibraryList
                Lines.Add(Line(0) + ";" + Line(1))
            Next
            System.IO.File.WriteAllLines(Path, Lines)
        Catch
            MessageBox.Show("The file could not be saved.", "Error")
        End Try
    End Sub

    Private Sub UpdateCardTitles()
        ' copy all titles to the listbox
        lstCardTitles.Items.Clear()
        For Each Card As List(Of String) In LibraryList
            lstCardTitles.Items.Add(Card(0))
        Next
    End Sub

    Private Sub UpdateCurrentCard()
        ' display title and caption of selected item
        Dim Card As List(Of String) = LibraryList(lstCardTitles.SelectedIndex)
        lblTitle.Text = Card(0)
        lblCaption.Text = "'" + Card(1) + "'"
    End Sub

    Private Sub ClearCurrentCard()
        lblTitle.Text = String.Empty
        lblCaption.Text = String.Empty
    End Sub

    Private Sub FlipCard()
        If lblTitle.Visible Then
            lblTitle.Visible = False
            lblCaption.Visible = True
            picCardBackground.Image = Flash_Cards_Generator.My.Resources.Resources.flashcard_background_blue
        Else
            lblTitle.Visible = True
            lblCaption.Visible = False
            picCardBackground.Image = Flash_Cards_Generator.My.Resources.Resources.flashcard_background_blue_reversed
        End If
    End Sub

    Private Sub picCardBackground_Click(sender As Object, e As EventArgs) Handles picCardBackground.Click
        FlipCard()
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click
        FlipCard()
    End Sub

    Private Sub lblCaption_Click(sender As Object, e As EventArgs) Handles lblCaption.Click
        FlipCard()
    End Sub
End Class