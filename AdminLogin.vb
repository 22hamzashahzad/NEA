Imports MySql.Data.MySqlClient
Public Class AdminLogin
    Dim Con As New MySqlConnection("server=141.136.33.52;uid = 22HamzaShahzad;pwd=KlttJp8!;database=22HamzaShahzad_")
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

        Dim log As New Login

        log.Show()

        Me.Hide()



    End Sub



    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        Application.Exit()



    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If PasswordTb.Text = "Admin" Then

            Dim staff As New Staff

            staff.Show()

            Me.Hide()

        Else

            MsgBox("Wrong password, contact your admin")



        End If

    End Sub
End Class