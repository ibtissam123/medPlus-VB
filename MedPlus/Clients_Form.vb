Imports System.Data.DataTable
Imports MySql.Data.MySqlClient

Public Class Clients_Form

    Dim str As String = "server=localhost; uid=root; pwd=; database=medplus;SslMode=none"
    Dim con As New MySqlConnection(str)
    Dim id As Integer = Form1.id

    Private Sub Clients_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.Open()
        Dim mycommand As New MySqlCommand("select id_client from client where id_pharmacien =" & id, con)
        Dim Reader As MySqlDataReader
        Reader = mycommand.ExecuteReader
        While Reader.Read()
            combo_client.Items.Add(Reader(0))
        End While

        con.Close()
    End Sub

    Private Sub combo_client_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_client.SelectedIndexChanged
        DataGridView1.Rows.Clear()
        con.Open()
        Dim Checked As Boolean = False
        Dim row As String() = New String() {"Product1", "1000", "1000", "1000000"}
        Dim mycommand As New MySqlCommand("select * from client where id_client = " & combo_client.Text, con)
        Dim Reader As MySqlDataReader
        Reader = mycommand.ExecuteReader
        While Reader.Read()
            txt_nom_client.Text = Reader(1)
            txt_prenom_client.Text = Reader(2)
            txt_age_client.Text = Reader(3)
            txt_adresse_client.Text = Reader(4)
            txt_ndc_client.Text = Reader(5)
            txt_mdp_client.Text = Reader(6)
        End While
        Reader.Close()

        Dim mycommand2 As New MySqlCommand("select pc.id_cmd, pc.id_product, title, price, quantity, price*quantity, checked from products p, products_cmd pc, cmd c where c.id_client = " & combo_client.Text & " and pc.id_cmd = c.id_cmd and p.id = pc.id_product", con)
        Reader = mycommand2.ExecuteReader
        While Reader.Read()
            row = New String() {Reader(2), Reader(3), Reader(4), Reader(5), Reader(6), Reader(1), Reader(0)}
            DataGridView1.Rows.Add(row)
        End While
        Reader.Close()
        con.Close()
    End Sub

    Private Sub btn_produits_Click(sender As Object, e As EventArgs) Handles btn_produits.Click
        con.Open()
        Dim mycommand As New MySqlCommand("Update client Set nom_client='" & txt_nom_client.Text & "', prenom_client ='" & txt_prenom_client.Text & "', age_client =" & txt_age_client.Text & ", adresse_client ='" & txt_adresse_client.Text & "', ndc ='" & txt_ndc_client.Text & "', mdp ='" & txt_mdp_client.Text & "' WHERE id_client=" & combo_client.Text, con)
        mycommand.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub btn_commandes_Click(sender As Object, e As EventArgs) Handles btn_commandes.Click
        con.Open()
        Dim quantity, id_product, id_cmd As Integer
        Dim Checked As Boolean
        Dim mycommand As MySqlCommand
        For Each row As DataGridViewRow In DataGridView1.Rows

            If (row.Cells("cmd_checked_product").Value = 1) Then
                Checked = True
                id_product = row.Cells("idproduct").Value
                quantity = row.Cells("cmd_quantity_product").Value
                id_cmd = row.Cells("idcommande").Value
            Else
                Checked = False
                id_product = row.Cells("idproduct").Value
                quantity = row.Cells("cmd_quantity_product").Value
                id_cmd = row.Cells("idcommande").Value
            End If

            If Checked = True Then
                mycommand = New MySqlCommand("update products_cmd  set checked = 1 where id_cmd=" & id_cmd & " and quantity =" & quantity & " and id_product=" & id_product, con)
            Else
                mycommand = New MySqlCommand("update products_cmd  set checked = 0 where id_cmd=" & id_cmd & " and quantity =" & quantity & " and id_product=" & id_product, con)

            End If
            mycommand.ExecuteNonQuery()
        Next
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sv As New Form2()
        sv.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mycommand As MySqlCommand
        con.Open()
        mycommand = New MySqlCommand("delete client where id_client=" & combo_client.Text, con)
        mycommand.ExecuteNonQuery()
        con.Close()
        combo_client.Refresh()
        txt_nom_client.Text = ""
        txt_prenom_client.Text = ""
        txt_age_client.Text = ""
        txt_adresse_client.Text = ""
        txt_ndc_client.Text = ""
        txt_mdp_client.Text = ""
    End Sub
End Class