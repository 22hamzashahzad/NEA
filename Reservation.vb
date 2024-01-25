Imports MySql.Data.MySqlClient

Public Class Reservation
    Dim Con As New MySqlConnection("server=141.136.33.52;uid = u381396247_22HamzaShahzad;pwd=KlttJp8!;database=u381396247_22HamzaShahzad")


    Private Sub FillClient()

        Con.Open()

        Dim cmd As New MySqlCommand("select * from ClientTbl", Con)

        Dim adapter As New MySqlDataAdapter(cmd)

        Dim Tbl As New DataTable()

        adapter.Fill(Tbl)

        ClIDCb.DataSource = Tbl

        ClIDCb.DisplayMember = "ClID"

        ClIDCb.ValueMember = "ClID"

        Con.Close()



    End Sub

    Private Sub FillRoom()

        Dim status = "Free"

        Con.Open()

        Dim cmd As New MySqlCommand("select * from RoomTbl where RStatus='" & status & "'", Con)

        Dim adapter As New MySqlDataAdapter(cmd)

        Dim Tbl As New DataTable()

        adapter.Fill(Tbl)

        RoomNumberCb.DataSource = Tbl

        RoomNumberCb.DisplayMember = "RID"

        RoomNumberCb.ValueMember = "RID"

        Con.Close()



    End Sub

    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FillClient()

        FillRoom()

        Populate()

    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim Cl As New Client

        Cl.Show()

        Me.Hide()

    End Sub



    Private Sub GetName()

        Con.Open()

        Dim Query = "select * from ClientTbl where ClID=" & ClIDCb.SelectedValue.ToString() & ""

        Dim cmd As New MySqlCommand(Query, Con)

        Dim dt As New DataTable

        Dim reader As MySqlDataReader

        reader = cmd.ExecuteReader()

        While reader.Read

            ClNameTb.Text = "" + reader(1).ToString()

        End While

        Con.Close()

    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim room As New room

        room.Show()

        Me.Hide()

    End Sub



    Private Sub ClIDCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClIDCb.SelectedIndexChanged

        GetName()



    End Sub



    Private Sub Populate()

        Con.Open()

        Dim sql = "select * from ReservationTbl"

        Dim adapter As MySqlDataAdapter

        adapter = New MySqlDataAdapter(sql, Con)

        Dim builder As MySqlCommandBuilder

        builder = New MySqlCommandBuilder(adapter)

        Dim ds As DataSet

        ds = New DataSet

        adapter.Fill(ds)

        ReservationDGV.DataSource = ds.Tables(0)

        Con.Close()

    End Sub


    Private Sub UpdateRoom()

        Dim Status = "Booked"

        Try

            Con.Open()

            Dim query As String

            query = "update RoomTbl set RStatus = '" & Status & "' where RID=" & RoomNumberCb.SelectedValue.ToString() & ""

            Dim cmd As MySqlCommand

            cmd = New MySqlCommand(query, Con)

            cmd.ExecuteNonQuery()

            Console.WriteLine("Room Updated Successfully")

            Con.Close()

            Populate()


        Catch ex As Exception

            MsgBox(ex.Message)



        End Try

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ClIDCb.SelectedIndex = -1 Or RoomNumberCb.SelectedIndex = -1 Then

            MsgBox("Missing Information")

        Else

            Try

                Con.Open()

                Dim query As String

                query = "insert into ReservationTbl values(" & ClIDCb.SelectedValue.ToString() & ",'" & ClNameTb.Text & "', " & RoomNumberCb.SelectedValue.ToString() & "', '" & DateIn.Value & "', '" & DateOut.Value & "')"

                Dim cmd As MySqlCommand

                cmd = New MySqlCommand(query, Con)

                cmd.ExecuteNonQuery()

                MsgBox("Room Booked Successfully")

                Con.Close()

                Populate()

                UpdateRoom()


            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End If

    End Sub

    Dim key = 0

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If ClIDCb.SelectedIndex = -1 Or RoomNumberCb.SelectedIndex = -1 Then

            MsgBox("Missing Information")

        Else

            Try

                Con.Open()

                Dim query As String

                query = "update ReservationTbl set ClientID = " & ClIDCb.SelectedValue.ToString() & ", ClientName='" & ClNameTb.Text & "',RoomID=" & RoomNumberCb.SelectedValue.ToString() & ", DateIn='" & DateIn.Value & "', DateOut = '" & DateOut.Value & "' where ResID=" & key & ""

                Dim cmd As MySqlCommand

                cmd = New MySqlCommand(query, Con)

                cmd.ExecuteNonQuery()

                Console.WriteLine("Reservation Updated Successfully")

                Con.Close()

                Populate()


            Catch ex As Exception

                MsgBox(ex.Message)

            End Try

        End If

    End Sub



    Private Sub ReservationDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ReservationDGV.CellMouseClick

        Dim row As DataGridViewRow = ReservationDGV.Rows(e.RowIndex)

        ClIDCb.SelectedValue = row.Cells(1).Value.ToString

        ClNameTb.Text = row.Cells(2).Value.ToString

        RoomNumberCb.SelectedValue = row.Cells(3).Value.ToString

        DateIn.Value = row.Cells(4).Value.ToString

        DateOut.Value = row.Cells(5).Value.ToString

        If ClNameTb.Text = "" Then

            key = 0

        Else

            key = Convert.ToInt32(row.Cells(0).Value.ToString)

        End If

    End Sub

End Class