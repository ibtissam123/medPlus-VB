Imports System.Data.DataTable
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Products

    Dim str As String = "server=localhost; uid=root; pwd=; database=medplus;SslMode=none"
    Dim con As New MySqlConnection(str)
    Dim ext As String

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click

        Dim ImageDialogue As OpenFileDialog = New OpenFileDialog()

        ImageDialogue.Title = "Select your Image."
        ImageDialogue.InitialDirectory = "C:\"
        ImageDialogue.Filter = "Image Files|*.gif;*.jpg;*.png;*.bmp;"
        ext = ImageDialogue.SafeFileName
        ImageDialogue.RestoreDirectory = False

        If ImageDialogue.ShowDialog() = DialogResult.OK Then
            PictureBox.Image = Image.FromFile(ImageDialogue.FileName)
        End If

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim cmd = New MySqlCommand("Insert Into products(title,image,price) Values('" & txt_title.Text & "',@Picture," & txt_price.Text & ")", con)
        con.Open()



        Dim ms As New MemoryStream()
        PictureBox.Image.Save(ms, PictureBox.Image.RawFormat)
        Dim data As Byte() = ms.ToArray()
        Dim p As New MySqlParameter("@Picture", MySqlDbType.Blob)
        p.Value = data
        cmd.Parameters.Add(p)
        cmd.ExecuteNonQuery()

        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sv As New Form2()
        sv.Show()
        Me.Hide()
    End Sub
End Class