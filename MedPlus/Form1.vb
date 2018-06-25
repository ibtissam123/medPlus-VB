Imports System.Data.DataTable
Imports MySql.Data.MySqlClient

Public Class Form1

    Public id As Integer
    Dim str As String = "server=localhost; uid=root; pwd=; database=medplus;SslMode=none"
    Dim con As New MySqlConnection(str)


    Private Sub btn_cnx_Click(sender As Object, e As EventArgs) Handles btn_cnx.Click
        con.Open()
        Dim mycommand As New MySqlCommand("select ndc,mdp,id from medecin", con)
        Dim Reader As MySqlDataReader
        Reader = mycommand.ExecuteReader
        While Reader.Read()
            If Strings.Equals(Reader(0), txt_ndc.Text) And Strings.Equals(Reader(1), txt_mdp.Text) Then
                id = Reader(2)
                Dim sv As New Form2()
                sv.Show()
                Me.Hide()

            ElseIf Strings.Equals(Reader(0), txt_ndc.Text) = False And Strings.Equals(Reader(1), txt_mdp.Text) = False Then
                MessageBox.Show("Nom de Compte ou Mot de Passe Incorrect !", "Erreur")
            End If
        End While
        con.Close()

    End Sub
End Class
