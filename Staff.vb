Imports MySql.Data.MySqlClient

Public Class Staff
    Dim Con As New MySqlConnection("server=141.136.33.52;uid = u381396247_22HamzaShahzad;pwd=KlttJp8!;database=u381396247_22HamzaShahzad")

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Populate()







    End Sub



    Private Sub Populate()

        Con.Open()

        Dim sql = "select * from StaffTbl"

        Dim adapter As MySqlDataAdapter

        adapter = New MySqlDataAdapter(sql, Con)

        Dim builder As MySqlCommandBuilder

        builder = New MySqlCommandBuilder(adapter)

        Dim ds As DataSet

        ds = New DataSet

        adapter.Fill(ds)

        AgentDGV.DataSource = ds.Tables(0)

        Con.Close()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If StaffNameTb.Text = "" Or StaffGenderCb.SelectedIndex = -1 Or StaffPhoneTb.Text = "" Or StaffPasswordTb.Text = "" Then

            MsgBox("Missing Information")

        Else

            Try

                Con.Open()

                Dim query As String

                query = "insert into StaffTbl values('" & StaffNameTb.Text & "','" & StaffPhoneTb.Text & "', '" & StaffGenderCb.SelectedItem.ToString() & "', '" & StaffPasswordTb.Text & "')"

                Dim cmd As MySqlCommand

                cmd = New MySqlCommand(query, Con)

                cmd.ExecuteNonQuery()

                MsgBox("Staff Inserted Successfully")

                Con.Close()

                Populate()

                Clear()

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End If

    End Sub

    Private Sub Clear()

        StaffNameTb.Clear()

        StaffPhoneTb.Clear()

        StaffGenderCb.SelectedIndex = -1

        StaffPasswordTb.Clear()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Clear()

    End Sub



    Dim key = 0



    Private Sub AgentDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles AgentDGV.CellMouseClick

        Dim row As DataGridViewRow = AgentDGV.Rows(e.RowIndex)

        StaffNameTb.Text = row.Cells(1).Value.ToString

        StaffPhoneTb.Text = row.Cells(2).Value.ToString

        StaffGenderCb.SelectedItem = row.Cells(3).Value.ToString

        StaffPasswordTb.Text = row.Cells(4).Value.ToString

        If StaffNameTb.Text = "" Then

            key = 0

        Else

            key = Convert.ToInt32(row.Cells(0).Value.ToString)

        End If

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If key = 0 Then

            MsgBox("Missing Information")

        Else

            Try

                Con.Open()

                Dim query As String

                query = "Delete from StaffTbl where StaffID = " & key & ""

                Dim cmd As MySqlCommand

                cmd = New MySqlCommand(query, Con)

                cmd.ExecuteNonQuery()

                MsgBox("Staff Deleted Successfully")

                Con.Close()

                Populate()

                Clear()

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End If

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If StaffNameTb.Text = "" Or StaffPhoneTb.Text = "" Or StaffPasswordTb.Text = "" Or StaffGenderCb.SelectedItem = -1 Or key = 0 Then

            MsgBox("Missing Information")

        Else

            Try

                Con.Open()

                Dim query As String

                query = "update StaffTbl set StName = '" & StaffNameTb.Text & "', StGender='" & StaffGenderCb.SelectedItem.ToString() & "' where StPhone=" & StaffPhoneTb.Text & "' where StPass='" & StaffPasswordTb.Text & "' where StaffID = " & key & ""

                Dim cmd As MySqlCommand

                cmd = New MySqlCommand(query, Con)

                cmd.ExecuteNonQuery()

                Console.WriteLine("Agent Updated Successfully")

                Con.Close()

                Populate()

                Clear()

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End If

    End Sub



    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

        Dim log As New Login

        log.Show()

        Me.Hide()

    End Sub

End Class