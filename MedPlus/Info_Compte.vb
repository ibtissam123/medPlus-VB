Imports System.Data.DataTable
Imports MySql.Data.MySqlClient

Public Class Info_Compte
    Dim str As String = "server=localhost; uid=root; pwd=; database=medplus;SslMode=none"
    Dim con As New MySqlConnection(str)
    Dim id As Integer = Form1.id
    Private Sub Info_Compte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim mycommand As New MySqlCommand("select * from medecin where id = " & id, con)
        Dim Reader As MySqlDataReader
        Reader = mycommand.ExecuteReader
        While Reader.Read()
            txt_nom_medecin.Text = Reader(1)
            txt_prenom_medecin.Text = Reader(2)
            txt_adresse_medecin.Text = Reader(3)
            txt_ndc_medecin.Text = Reader(4)
            txt_mdp_medecin.Text = Reader(5)
        End While
        Reader.Close()
        con.Close()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        con.Open()
        Dim mycommand As New MySqlCommand("Update medecin Set nom_medecin='" & txt_nom_medecin.Text & "', prenom_medecin ='" & txt_prenom_medecin.Text & "', adresse ='" & txt_adresse_medecin.Text & "', ndc ='" & txt_ndc_medecin.Text & "', mdp ='" & txt_mdp_medecin.Text & "' WHERE id_client=" & id, con)
        mycommand.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sv As New Form2()
        sv.Show()
        Me.Hide()
    End Sub
End Class