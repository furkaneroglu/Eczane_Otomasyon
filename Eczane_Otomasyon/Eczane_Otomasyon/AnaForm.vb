Imports System.Data.SqlClient
Public Class AnaForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles HastaEkleButton.Click
        HastaEkle.ShowDialog(Me)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles IlacEkleButton.Click
        IlacEkle.ShowDialog(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles HastaListeleButton.Click
        Try
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
            Connection.Close()
        Catch ex As Exception
            MsgBox("Veri tabanı hatası. Hata: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles IlacListeleButton.Click
        Try
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
        Catch ex As Exception
            MsgBox("Veri tabanı hatası. Hata: " & ex.Message)
        End Try
    End Sub

    Private Sub SatisYapButton_Click(sender As Object, e As EventArgs) Handles SatisYapButton.Click
        SatisYap.ShowDialog(Me)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Güle Güle :) ©Furkan EROĞLU")
        Application.Exit()
    End Sub
End Class
