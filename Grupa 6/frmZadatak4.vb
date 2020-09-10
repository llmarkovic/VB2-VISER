Public Class frmZadatak4
    Dim y As Integer = 50
    Private Sub frmZadatak4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim txt As New TextBox()
        txt.Width = Me.ClientSize.Width
        txt.Top = 30
        txt.Left = 10
        Me.Controls.Add(txt)
        AddHandler txt.TextChanged, AddressOf prikazi
    End Sub

    Private Sub prikazi(sender As TextBox, e As EventArgs)
        Dim lbl As New Label
        lbl.Left = 10
        lbl.Top = y
        y += 20
        lbl.Text = sender.Text
        AddHandler lbl.MouseEnter, AddressOf obrisi
        Me.Controls.Add(lbl)
    End Sub

    Private Sub obrisi(sender As Label, e As EventArgs)
        sender.Text = ""
    End Sub
End Class