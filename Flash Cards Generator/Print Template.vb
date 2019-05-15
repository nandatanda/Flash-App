Public Class Print_Template
    Private Sub Print_Template_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Print_Template_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        'PrintDialog1.Document = PrintDocument1
        'PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        'PrintDialog1.AllowSomePages = True

        'If PrintDialog1.ShowDialog = DialogResult.OK Then
        '    PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        '    PrintDocument1.Print()
        'End If

        Me.PrintDocument1.Print()
    End Sub
End Class