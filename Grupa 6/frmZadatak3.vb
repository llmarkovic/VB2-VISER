Public Class frmZadatak3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nizstr() = TextBox1.Text.Split(" ")
        For Each rec As String In nizstr
            If Len(rec) Mod 2 = 0 Then
                TextBox2.Text += $"* "
            Else
                TextBox2.Text += $"{rec} "
            End If
        Next
    End Sub
End Class