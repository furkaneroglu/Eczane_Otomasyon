Imports System.Data.SqlClient
Public Class HastaEkle
    Dim Baglanti As New SqlClient.SqlConnection("Server=localhost;Database=FEeczane;Integrated Security=True")
    Dim Komut As New SqlClient.SqlCommand
    Dim Adaptor As New SqlClient.SqlDataAdapter("SELECT * FROM hastabilgi", Baglanti)
    Dim Ds As New DataSet
    Public Sub Goster()
        Ds.Clear()
        Adaptor.Fill(Ds, "sanal")
        DataGridView1.DataSource = Ds.Tables("sanal")
    End Sub
    Private Sub HastaKaydıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HastaKaydıToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub İlaçKaydıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles İlaçKaydıToolStripMenuItem.Click
        IlacEkle.ShowDialog(Me)
    End Sub

    Private Sub HastaEkle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Goster()
    End Sub

    Private Sub KaydetButton_Click(sender As Object, e As EventArgs) Handles KaydetButton.Click
        Try
            Dim connection As SqlConnection = New SqlConnection
            Dim dsv As New DataSet
            connection.ConnectionString = "Data Source=Localhost;Initial Catalog=FEeczane;User ID=sa;Password=mmyo"
            connection.Open()
            Dim SQLcommand As SqlCommand = New SqlCommand
            SQLcommand.CommandText = "insert into hastabilgi(tcno,ad,soyad,cinsiyet,telno,dogumtarih)  values('" + TCTextBox.Text + "','" + AdiTextBox.Text + "','" + SoyadiTextBox.Text + "','" + CinsiyetComboBox.Text + "','" + CepTelTextBox.Text + "','" + DogumDateTimePicker.Value.ToString + "')"
            Dim sorgu = "Select * from hastabilgi"
            Dim adaptor = New SqlDataAdapter(sorgu, connection)
            adaptor.Fill(dsv, "hastabilgi")
            DataGridView1.DataSource = dsv.Tables("hastabilgi")
            SQLcommand.Connection = connection
            SQLcommand.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=FEeczane;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        Dim sorgu = "Select * from hastabilgi"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "hastabilgi")
        DataGridView1.DataSource = dsv.Tables("hastabilgi")
        Call Goster()
        Connection.Close()
    End Sub

    Private Sub SilButton_Click(sender As Object, e As EventArgs) Handles SilButton.Click
        Sil.Show()
    End Sub

    Private Sub DuzenleButton_Click(sender As Object, e As EventArgs) Handles DuzenleButton.Click
        Duzenle.Show()

    End Sub
End Class