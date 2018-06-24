

Public Class Form2



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_clients_Click(sender As Object, e As EventArgs) Handles btn_clients.Click
        Dim sv = New Clients_Form()
        sv.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sv As New Form1()
        sv.Show()
        Me.Hide()
    End Sub

    Private Sub btn_produits_Click(sender As Object, e As EventArgs) Handles btn_produits.Click
        Dim sv As New Products()
        sv.Show()
        Me.Hide()
    End Sub
End Class