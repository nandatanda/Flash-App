' Name:         Flashcards Project
' Purpose:      Creates, stores, and retrieves digital flashcards.
' Programmer:   Ali Elayni on 3.17.2019

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private BasePath As String = My.Application.Info.DirectoryPath
    Private FilePath As String = IO.Path.Combine(BasePath, "data.txt")

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        PopulateMyFlashcards()
        EmptyCardViewer()
    End Sub

    Private Sub lstCardTitles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCardTitles.SelectedIndexChanged
        PopulateCardViewer()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim Title As String = InputBox("Enter a title for your flashcard.", "Create Card", "Title")
        If Title = "" Then
            Exit Sub
        End If
        Dim Caption As String = InputBox("Enter the text you want to appear in the body of the flashcard.", "Create Card", "Text")
        If Caption = "" Then
            Exit Sub
        End If

        WriteRecord(Title, Caption)
        PopulateMyFlashcards()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Response As Integer = MessageBox.Show("Are you sure you want to delete this flashcard?", "Confirm Delete", MessageBoxButtons.OKCancel)
        If Response = DialogResult.OK Then
            DeleteRecord(lstCardTitles.SelectedIndex)
            PopulateMyFlashcards()
            EmptyCardViewer()
        End If

    End Sub

    Private Sub chkTimer_CheckedChanged(sender As Object, e As EventArgs) Handles chkTimer.CheckedChanged
        If cmbTimer.Enabled Then
            cmbTimer.Enabled = False
        Else
            cmbTimer.Enabled = True
        End If
    End Sub

    Private Sub btnSortListbox_Click(sender As Object, e As EventArgs) Handles btnSortListbox.Click
        Static ListboxIsInAscendingOrder As Boolean

        If ListboxIsInAscendingOrder Then
            SortRecordsAlphabetically(Reverse:=True)
            btnSortListbox.BackgroundImage = My.Resources.sort_ascending_right
            ListboxIsInAscendingOrder = False
        Else
            SortRecordsAlphabetically()
            btnSortListbox.BackgroundImage = My.Resources.sort_descending_right
            ListboxIsInAscendingOrder = True
        End If

        PopulateMyFlashcards()
        EmptyCardViewer()
    End Sub

    Private Sub btnSortDescending_Click(sender As Object, e As EventArgs)
        SortRecordsAlphabetically(Reverse:=True)
        PopulateMyFlashcards()
    End Sub

    Private Function ReadRecord(ByVal Title As String) As List(Of String)
        'read a record from data file
        Dim FilePath As String = IO.Path.Combine(BasePath, "data.txt")

        For Each Line As String In IO.File.ReadLines(FilePath)
            If Line.Contains(Title) Then
                Dim Record As New List(Of String)(Line.Split(";"c))
                Return Record
                Exit For
            End If
        Next
        Return Nothing
    End Function

    Private Sub WriteRecord(ByVal Title As String, Caption As String)
        ' write a record to data file
        Dim FilePath As String = IO.Path.Combine(BasePath, "data.txt")
        Dim Record As String = Title + ";" + Caption

        Try
            Dim File As IO.StreamWriter
            File = My.Computer.FileSystem.OpenTextFileWriter(FilePath, True)
            File.WriteLine(Record)
            File.Close()
        Catch
            MessageBox.Show("File access denied", "Error")
        End Try
    End Sub

    Private Function ReadRecordTitles() As List(Of String)
        'return a list of all titles in data file
        Dim FilePath As String = IO.Path.Combine(BasePath, "data.txt")
        Dim Titles As New List(Of String)

        For Each Line As String In IO.File.ReadLines(FilePath)
            Line = Split(Line, ";")(0)
            Titles.Add(Line)
        Next
        Return Titles
    End Function

    Private Sub DeleteRecord(ByVal Index As Integer)
        Try
            Dim Lines As List(Of String) = System.IO.File.ReadAllLines(FilePath).ToList
            Lines.RemoveAt(Index)
            System.IO.File.WriteAllLines(FilePath, Lines)
        Catch
            MessageBox.Show("No flashcard selected.", "Error")
        End Try
    End Sub

    Private Sub SortRecordsAlphabetically(Optional ByVal Reverse As Boolean = False)
        Try
            Dim Lines As List(Of String) = System.IO.File.ReadAllLines(FilePath).ToList
            Lines.Sort()
            If Reverse Then
                Lines.Reverse()
            End If
            System.IO.File.WriteAllLines(FilePath, Lines)
        Catch
            MessageBox.Show("File Access Denied", "Error")
        End Try
    End Sub

    Private Sub PopulateMyFlashcards()
        ' copy all titles to the listbox
        lstCardTitles.Items.Clear()
        Try
            Dim Title As String
            For Each Title In ReadRecordTitles()
                lstCardTitles.Items.Add(Title)
            Next
        Catch
            Dim File As IO.FileStream = IO.File.Create(FilePath)
            File.Close()
            MessageBox.Show("No data file was found. A new one has been created for you.", "New User")
        End Try
    End Sub

    Private Sub PopulateCardViewer()
        ' display title and caption of selected item
        Try
            Dim Record As List(Of String) = ReadRecord(lstCardTitles.Text)
            lblTitle.Text = Record(0)
            lblCaption.Text = Record(1)
        Catch
            lblTitle.Text = String.Empty
            lblCaption.Text = String.Empty
        End Try
    End Sub

    Private Sub EmptyCardViewer()
        lblTitle.Text = String.Empty
        lblCaption.Text = String.Empty
    End Sub

End Class