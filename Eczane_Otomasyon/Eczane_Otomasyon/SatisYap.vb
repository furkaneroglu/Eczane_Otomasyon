Imports System.Data.SqlClient
Public Class SatisYap
    Dim Baglanti As New SqlClient.SqlConnection("Server=localhost;Database=FEeczane;Integrated Security=True")
    Dim Komut As New SqlClient.SqlCommand
    Dim Adaptor As New SqlClient.SqlDataAdapter("SELECT * FROM satisbilg", Baglanti)
    Dim Ds As New DataSet
    Public Sub Goster()
        Ds.Clear()
        Adaptor.Fill(Ds, "sanal")
        DataGridView1.DataSource = Ds.Tables("sanal")
    End Sub
    Private Sub SatisYap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Goster()
    End Sub

    Private Sub HastaKaydıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HastaKaydıToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ListeleButton.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=FEeczane;User ID=sa;Password='mmyo'"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        Dim sorgu = "Select * from satisbilg"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "satisbilg")
        DataGridView1.DataSource = dsv.Tables("satisbilg")
        Connection.Close()
    End Sub

    Private Sub SatButton_Click(sender As Object, e As EventArgs) Handles SatButton.Click
        Dim connection As SqlConnection = New SqlConnection
        Dim dsv As New DataSet
        connection.ConnectionString = "Data Source=Localhost;Initial Catalog=FEeczane;User ID=sa;Password=mmyo"
        connection.Open()
        Dim SQLcommand As SqlCommand = New SqlCommand
        SQLcommand.CommandText = "insert into satisbilg(hastatc,ilacadi,miktar,sosyalguvenlik,satistarihi)  values('" + HastaTCTextBox.Text + "','" + IlacTextBox.Text + "','" + MiktarNUD.Text + "','" + ComboBox1.Text + "','" + IslemDateTimePicker.Value.ToString + "')"
        Dim sorgu = "Select * from satisbilg"
        Dim adaptor = New SqlDataAdapter(sorgu, connection)
        adaptor.Fill(dsv, "satisbilg")
        DataGridView1.DataSource = dsv.Tables("satisbilg")
        SQLcommand.Connection = connection
        SQLcommand.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub SilButton_Click(sender As Object, e As EventArgs) Handles SilButton.Click
        Sil.Show()
    End Sub


    Private Sub AnaEkranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnaEkranToolStripMenuItem.Click
        AnaForm.ShowDialog(Me)
    End Sub

    Private Sub HastalarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HastalarToolStripMenuItem.Click
        HastaEkle.ShowDialog(Me)
    End Sub

    Private Sub İlaçKaydıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles İlaçKaydıToolStripMenuItem.Click
        IlacEkle.ShowDialog(Me)
    End Sub
End Class