Imports System.Data.SqlClient
Public Class IlacEkle
    Dim Baglanti As New SqlClient.SqlConnection("Server=localhost;Database=FEeczane;Integrated Security=True")
    Dim Komut As New SqlClient.SqlCommand
    Dim Adaptor As New SqlClient.SqlDataAdapter("SELECT * FROM ilacbilgi", Baglanti)
    Dim Ds As New DataSet

    Public Sub Goster()
        Ds.Clear()
        Adaptor.Fill(Ds, "sanal")
        DataGridView1.DataSource = Ds.Tables("sanal")
    End Sub
    Private Sub İlaçKaydıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles İlaçKaydıToolStripMenuItem.Click
        HastaEkle.Show()
    End Sub

    Private Sub HastaKaydıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HastaKaydıToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub IlacEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Goster()
    End Sub

    Private Sub KaydetButton_Click(sender As Object, e As EventArgs) Handles KaydetButton.Click
        Dim connection As SqlConnection = New SqlConnection
        Dim dsv As New DataSet
        connection.ConnectionString = "Data Source=Localhost;Initial Catalog=FEeczane;User ID=sa;Password=mmyo"
        connection.Open()
        Dim SQLcommand As SqlCommand = New SqlCommand
        SQLcommand.CommandText = "insert into ilacbilgi(ilacadi,ilacfiyat,stoksayi,ilacbarkod)  values('" + AdiTextBox.Text + "','" + FiyatTextBox.Text + "','" + MiktarNUD.Text + "','" + BarkodTextBox.Text + "')"
        Dim sorgu = "Select * from ilacbilgi"
        Dim adaptor = New SqlDataAdapter(sorgu, connection)
        adaptor.Fill(dsv, "ilacbilgi")
        DataGridView1.DataSource = dsv.Tables("ilacbilgi")
        SQLcommand.Connection = connection
        SQLcommand.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub SilButton_Click(sender As Object, e As EventArgs) Handles SilButton.Click
        Sil.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ListeleButton.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=FEeczane;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        Dim sorgu = "Select * from ilacbilgi"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "ilacbilgi")
        DataGridView1.DataSource = dsv.Tables("ilacbilgi")
        Connection.Close()
    End Sub
End Class