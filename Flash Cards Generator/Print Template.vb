Public Class Print_Template

    Private Sub Print_Template_Load(sender As Object, e As EventArgs) Handles Me.Load
        WriteNames()
    End Sub

    Private Sub Print_Template_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Dim pf As New PrintForm(Me)
        pf.Print(False, 1, frmMain.FileName())
        Me.Close()
    End Sub

    Private Sub WriteNames()
        Static NamesWritten As Integer = 0
        Dim NameLabels As List(Of Object) = New List(Of Object) From {lblName1, lblName2, lblName3, lblName4,
                                                                      lblName5, lblName6, lblName7, lblName8}

        For Each Label As Object In NameLabels
            Label.Text = frmMain.CurrentLibrary(NamesWritten)(0)
            NamesWritten += 1
        Next

    End Sub
End Class