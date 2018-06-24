Imports System.Data.DataTable
Imports MySql.Data.MySqlClient

Public Class dbc

    Dim str As String = "server=localhost; uid=root; pwd=; database=medplus;SslMode=none"
    Dim con As New MySqlConnection(str)

    Public Sub Login(ndc As String, mdp As String, check As Boolean)
        con.Open()
        Dim mycommand As New MySqlCommand("select ndc,mdp from medecin", con)
        Dim Reader As MySqlDataReader
        Reader = mycommand.ExecuteReader
        While Reader.Read()
            If Strings.Equals(Reader(0), ndc) And Strings.Equals(Reader(1), mdp) Then
                check = True

            Else
                check = False
            End If
        End While
        con.Close()
    End Sub

End Class
