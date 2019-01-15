Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class Sil

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Try
            If ComboBox1.SelectedIndex = 0 Then
                Dim Connection As New SqlConnection
                Dim dsv As New DataSet
                Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=FEeczane;User ID=sa;Password='mmyo'"
                Connection.Open()
                Dim SQLcommand As New SqlCommand
                SQLcommand.CommandText = "DELETE FROM hastabilgi where hastano ='" + TextBox1.Text + "'"
                SQLcommand.Connection = Connection
                SQLcommand.ExecuteNonQuery()
                Connection.Close()
            ElseIf ComboBox1.SelectedIndex = 1 Then
                Dim Connection As New SqlConnection
                Dim dsv As New DataSet
                Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=FEeczane;User ID=sa;Password='mmyo'"
                Connection.Open()
                Dim SQLcommand As New SqlCommand
                SQLcommand.CommandText = "DELETE FROM ilacbilgi where ilacno ='" + TextBox1.Text + "'"
                SQLcommand.Connection = Connection
                SQLcommand.ExecuteNonQuery()
                Connection.Close()
            Else
                Dim Connection As New SqlConnection
                Dim dsv As New DataSet
                Connection.ConnectionString = "Data Source=Localhost;Initial Catalog=FEeczane;User ID=sa;Password='mmyo'"
                Connection.Open()
                Dim SQLcommand As New SqlCommand
                SQLcommand.CommandText = "DELETE FROM satisbilg where satisno ='" + TextBox1.Text + "'"
                SQLcommand.Connection = Connection
                SQLcommand.ExecuteNonQuery()
                Connection.Close()
            End If
            MsgBox("Silme İşlemi Başarılı :)")
        Catch ex As Exception
            MsgBox("hata")
        End Try


        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Label2.Text = "Silmek istediğiniz Hasta No'sunu Giriniz"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Label2.Text = "Silmek istediğiniz İlaç No'sunu Giriniz"
        Else
            Label2.Text = "Silmek istediğiniz Satış No'sunu Giriniz"
        End If

    End Sub
End Class
