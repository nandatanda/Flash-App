Public Class Print_Template

    Private Sub Print_Template_Load(sender As Object, e As EventArgs) Handles Me.Load
        'populate fields
    End Sub

    Private Sub Print_Template_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Dim pf As New PrintForm(Me)
        pf.Print(False, 1)
        Me.Close()
    End Sub

End Class