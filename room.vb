Imports MySql.Data.MySqlClient

Public Class Room
    Dim Con As New MySqlConnection("server=141.136.33.52;uid = u381396247_22HamzaShahzad;pwd=KlttJp8!;database=u381396247_22HamzaShahzad")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RoomPhone.Text = "" Or RoomStatus.SelectedIndex = -1 Then

            MsgBox("Missing Information")

        Else

            Try

                Con.Open()

                Dim query As String

                query = "insert into RoomTbl values('" & RoomPhone.Text & "','" & RoomStatus.SelectedItem.ToString() & "')"

                Dim cmd As MySqlCommand

                cmd = New MySqlCommand(query, Con)

                cmd.ExecuteNonQuery()

                MsgBox("Client Inserted Successfully")

                Con.Close()

                Populate()

                Clear()

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End If

    End Sub

    Private Sub Populate()

        Con.Open()

        Dim sql = "select * from RoomTbl"

        Dim adapter As MySqlDataAdapter

        adapter = New MySqlDataAdapter(sql, Con)

        Dim builder As MySqlCommandBuilder

        builder = New MySqlCommandBuilder(adapter)

        Dim ds As DataSet

        ds = New DataSet

        adapter.Fill(ds)

        RoomDGV.DataSource = ds.Tables(0)

        Con.Close()

    End Sub

    Private Sub Clear()

        RoomPhone.Clear()

        RoomStatus.SelectedIndex = -1

    End Sub

    Private Sub Room_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Populate()

    End Sub



    Dim key = 0

    Private Sub RoomDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles RoomDGV.CellMouseClick

        Dim row As DataGridViewRow = RoomDGV.Rows(e.RowIndex)

        RoomPhone.Text = row.Cells(1).Value.ToString

        RoomStatus.SelectedItem = row.Cells(2).Value.ToString



        If RoomPhone.Text = "" Then

            key = 0

        Else

            key = Convert.ToInt32(row.Cells(0).Value.ToString)

        End If

    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Clear()

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If key = 0 Then

            MsgBox("Missing Information")

        Else

            Try

                Con.Open()

                Dim query As String

                query = "Delete from RoomTbl where RID = " & key & ""

                Dim cmd As MySqlCommand

                cmd = New MySqlCommand(query, Con)

                cmd.ExecuteNonQuery()

                MsgBox("Room Deleted Successfully")

                Con.Close()

                Populate()

                Clear()

            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End If

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If RoomPhone.Text = "" Or RoomStatus.Text = "" Then

            MsgBox("Missing Information")

        Else

            Try

                Con.Open()

                Dim query As String

                query = "update RoomTbl set RPhone = '" & RoomPhone.Text & "', RStatus='" & RoomStatus.SelectedItem.ToString() & "' where RID=" & key & ""

                Dim cmd As MySqlCommand

                cmd = New MySqlCommand(query, Con)

                cmd.ExecuteNonQuery()

                Console.WriteLine("Room Updated Successfully")

                Con.Close()

                Populate()

                Clear()

            Catch ex As Exception

                MsgBox(ex.Message)



            End Try

        End If

    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim res As New Reservation

        res.Show()

        Me.Hide()

    End Sub



    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click



    End Sub

End Class