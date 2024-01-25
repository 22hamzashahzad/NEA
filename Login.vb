Imports MySql.Data.MySqlClient
Public Class Login
    Dim Con As New MySqlConnection("server=141.136.33.52;uid = u381396247_22HamzaShahzad;pwd=KlttJp8!;database=u381396247_22HamzaShahzad")
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles ALStaffIDTb.Click



    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles ALStaffIDTb.TextChanged



    End Sub



    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        Dim Adm As New AdminLogin

        Adm.Show()

        Me.Hide()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ALStaffIDTb.Text = "" Or ALPasswordTb.Text = "" Then

            MsgBox("Enter the name and password")

        Else

            Con.Open()

            Dim Query = "select * from StaffTbl where StName='" & ALStaffIDTb.Text & "' And StPass='" & Apasswordtb.Text & "'"

            Dim cmd = New MySqlCommand(Query, Con)

            Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)

            Dim ds As DataSet = New DataSet()

            da.Fill(ds)

            Dim a As Integer

            a = ds.Tables(0).Rows.Count

            If a = 0 Then

                MsgBox("Wrong Username Or Password")

            Else


                Dim Res = New Reservation

                Res.Show()

                Me.Hide()



            End If

            Con.Close()



        End If

    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.CheckState = CheckState.Checked Then

            Apasswordtb.PasswordChar = ""

        Else

            Apasswordtb.PasswordChar = "*"

        End If

    End Sub



    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

        Application.Exit()


    End Sub

End Class