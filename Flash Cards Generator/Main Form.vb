' Name:         Flashcards Project
' Purpose:      Creates, stores, and retrieves digital flashcards.
' Programmer:   Ali Elayni on 3.17.2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private BasePath As String = My.Application.Info.DirectoryPath
    Private FilePath As String = IO.Path.Combine(BasePath, "data.txt")
    Private WorkingFilePath As String = String.Empty
    Private HasUnsavedChanges As Boolean

    Public LibraryList As List(Of List(Of String))


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblTitle.Text = "Welcome"
        lblCaption.Text = "To start, create a new card library or open an existing one using the 'file' menu above."
    End Sub

    Private Sub lstCardTitles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCardTitles.SelectedIndexChanged
        UpdateCurrentCard()
    End Sub

    Private Sub btnSortListbox_Click(sender As Object, e As EventArgs) Handles btnSortListbox.Click
        Static ListboxIsInAscendingOrder As Boolean

        Dim LatestSelectedItem As String = lstCardTitles.SelectedItem.ToString

        If ListboxIsInAscendingOrder Then
            LibraryList.Reverse()
            btnSortListbox.BackgroundImage = My.Resources.sort_ascending_right
            ListboxIsInAscendingOrder = False
        Else
            LibraryList.Sort()
            btnSortListbox.BackgroundImage = My.Resources.sort_descending_right
            ListboxIsInAscendingOrder = True
        End If

        UpdateCardTitles()
        ClearCurrentCard()
        lstCardTitles.SelectedItem = LatestSelectedItem
    End Sub

    ' Click Events for ToolStripMenu -> File

    Private Sub tsmFileNew_Click(sender As Object, e As EventArgs) Handles tsmFileNew.Click
        If Not HasUnsavedChanges Then
            ClearCurrentCard()
            lstCardTitles.Items.Clear()
        End If
    End Sub

    Private Sub tsmFileOpen_Click(sender As Object, e As EventArgs) Handles tsmFileOpen.Click
        If WorkingFilePath = String.Empty Then
            Dim MyPrompt As OpenFileDialog = New OpenFileDialog With {
                .DefaultExt = "txt",
                .FileName = "my-library",
                .InitialDirectory = BasePath,
                .Filter = "All files|*.*|Text files|*.txt",
                .Title = "Open"
            }

            If MyPrompt.ShowDialog() <> DialogResult.Cancel Then
                WorkingFilePath = MyPrompt.FileName
                LibraryList = ParseFile(WorkingFilePath)

                UpdateCardTitles()

                If lstCardTitles.Items.Count > 0 Then
                    lstCardTitles.SelectedIndex = 0
                    UpdateCurrentCard()
                End If
            End If
        Else
            MessageBox.Show("There is already a file open.", "Error")
        End If
    End Sub

    Private Sub tsmFileSave_Click(sender As Object, e As EventArgs) Handles tsmFileSave.Click

    End Sub

    Private Sub tsmFileSaveAs_Click(sender As Object, e As EventArgs) Handles tsmFileSaveAs.Click

    End Sub

    ' Click Events for ToolStripMenu -> Card

    Private Sub tsmCardNew_Click(sender As Object, e As EventArgs) Handles tsmCardNew.Click
        Dim NewCard As List(Of String) = New List(Of String)

        Dim Title As String = InputBox("Enter a title for your flashcard.", "Create Card", "Title")
        If Title = "" Then
            Exit Sub
        End If
        Dim Caption As String = InputBox("Enter the text you want to appear in the body of the flashcard.", "Create Card", "Text")
        If Caption = "" Then
            Exit Sub
        End If

        NewCard.Add(Title)
        NewCard.Add(Caption)

        LibraryList.Add(NewCard)
        UpdateCardTitles()
        lstCardTitles.SelectedItem = Title
    End Sub

    Private Sub tsmCardEdit_Click(sender As Object, e As EventArgs) Handles tsmCardEdit.Click
        Dim Title As String = "Title"
        Dim Caption As String = "Caption"
        Dim Index As Integer = lstCardTitles.SelectedIndex
        Dim EditedCard As List(Of String) = New List(Of String)

        ' read original card from list
        Title = LibraryList(Index)(0)
        Caption = LibraryList(Index)(1)

        ' input new title
        Title = InputBox("Change the text of the title.", "Edit Card", Title)
        If Title = "" Then
            Exit Sub
        End If

        ' input new caption
        Caption = InputBox("Change the text of the caption, or body of the card.", "Edit Card", Caption)
        If Caption = "" Then
            Exit Sub
        End If

        ' replace card in list
        EditedCard.Add(Title)
        EditedCard.Add(Caption)
        LibraryList(Index) = EditedCard

        ' update interface
        UpdateCardTitles()
        UpdateCurrentCard()
        lstCardTitles.SelectedIndex = Index
    End Sub

    Private Sub tsmCardDelete_Click(sender As Object, e As EventArgs) Handles tsmCardDelete.Click
        ' remove selected card from list
        Dim Response As Integer = MessageBox.Show("Are you sure you want to delete this flashcard?", "Confirm Delete", MessageBoxButtons.OKCancel)
        Dim SelectedIndex As Integer = lstCardTitles.SelectedIndex

        If Response = DialogResult.OK Then
            LibraryList.RemoveAt(SelectedIndex)

            ' update interface
            UpdateCardTitles()
            ClearCurrentCard()

            Dim LargestIndex As Integer = lstCardTitles.Items.Count - 1
            If SelectedIndex > LargestIndex Then
                lstCardTitles.SelectedIndex = LargestIndex
            Else
                lstCardTitles.SelectedIndex = SelectedIndex
            End If
        End If
    End Sub

    Private Sub tsmCardMoveUp_Click(sender As Object, e As EventArgs) Handles tsmCardMoveUp.Click
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
    End Sub

    Private Sub tsmCardMoveDown_Click(sender As Object, e As EventArgs) Handles tsmCardMoveDown.Click
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

End Class