Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class Duzenle

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            If ComboBox1.SelectedIndex = 0 Then
                Dim Connection As New SqlConnection
                Dim dsv As New DataSet
                Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=FEeczane;User ID=sa;Password='mmyo'"
                Connection.Open()
                Dim SQLcommand As New SqlCommand
                SQLcommand.CommandText = "UPDATE hastabilgi set ad ='" + TextBox2.Text + "' where ad ='" + TextBox1.Text + "'"
                SQLcommand.Connection = Connection
                SQLcommand.ExecuteNonQuery()
                Connection.Close()
            ElseIf ComboBox1.SelectedIndex = 1 Then

                Dim Connection As New SqlConnection
                Dim dsv As New DataSet
                Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=FEeczane;User ID=sa;Password='mmyo'"
                Connection.Open()
                Dim SQLcommand As New SqlCommand
                SQLcommand.CommandText = "UPDATE hastabilgi set soyad ='" + TextBox2.Text + "' where soyad ='" + TextBox1.Text + "'"
                SQLcommand.Connection = Connection
                SQLcommand.ExecuteNonQuery()
                Connection.Close()
            ElseIf ComboBox1.SelectedIndex = 2 Then

                Dim Connection As New SqlConnection
                Dim dsv As New DataSet
                Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=FEeczane;User ID=sa;Password='mmyo'"
                Connection.Open()
                Dim SQLcommand As New SqlCommand
                SQLcommand.CommandText = "UPDATE hastabilgi set cinsiyet ='" + TextBox2.Text + "' where cinsiyet ='" + TextBox1.Text + "'"
                SQLcommand.Connection = Connection
                SQLcommand.ExecuteNonQuery()
                Connection.Close()
            ElseIf ComboBox1.SelectedIndex = 3 Then

                Dim Connection As New SqlConnection
                Dim dsv As New DataSet
                Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=FEeczane;User ID=sa;Password='mmyo'"
                Connection.Open()
                Dim SQLcommand As New SqlCommand
                SQLcommand.CommandText = "UPDATE hastabilgi set telno ='" + TextBox2.Text + "' where telno ='" + TextBox1.Text + "'"
                SQLcommand.Connection = Connection
                SQLcommand.ExecuteNonQuery()
                Connection.Close()
            ElseIf ComboBox1.SelectedIndex = 4 Then

                Dim Connection As New SqlConnection
                Dim dsv As New DataSet
                Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=FEeczane;User ID=sa;Password='mmyo'"
                Connection.Open()
                Dim SQLcommand As New SqlCommand
                SQLcommand.CommandText = "UPDATE hastabilgi set tcno ='" + TextBox2.Text + "' where tcno ='" + TextBox1.Text + "'"
                SQLcommand.Connection = Connection
                SQLcommand.ExecuteNonQuery()
                Connection.Close()
            ElseIf ComboBox1.SelectedIndex = 5 Then

                Dim Connection As New SqlConnection
                Dim dsv As New DataSet
                Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=FEeczane;User ID=sa;Password='mmyo'"
                Connection.Open()
                Dim SQLcommand As New SqlCommand
                SQLcommand.CommandText = "UPDATE ilacbilgi set ilacadi ='" + TextBox2.Text + "' where ilacadi ='" + TextBox1.Text + "'"
                SQLcommand.Connection = Connection
                SQLcommand.ExecuteNonQuery()
                Connection.Close()
            ElseIf ComboBox1.SelectedIndex = 6 Then

                Dim Connection As New SqlConnection
                Dim dsv As New DataSet
                Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=FEeczane;User ID=sa;Password='mmyo'"
                Connection.Open()
                Dim SQLcommand As New SqlCommand
                SQLcommand.CommandText = "UPDATE ilacbilgi set ilacfiyat ='" + TextBox2.Text + "' where ilacfiyat ='" + TextBox1.Text + "'"
                SQLcommand.Connection = Connection
                SQLcommand.ExecuteNonQuery()
                Connection.Close()
            ElseIf ComboBox1.SelectedIndex = 7 Then

                Dim Connection As New SqlConnection
                Dim dsv As New DataSet
                Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=FEeczane;User ID=sa;Password='mmyo'"
                Connection.Open()
                Dim SQLcommand As New SqlCommand
                SQLcommand.CommandText = "UPDATE ilacbilgi set ilacbarkod ='" + TextBox2.Text + "' where ilacbarkod ='" + TextBox1.Text + "'"
                SQLcommand.Connection = Connection
                SQLcommand.ExecuteNonQuery()
                Connection.Close()
            End If

        Catch ex As Exception
            MsgBox("Veri tabanı hatası. Hata: " & ex.Message)
        End Try

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
