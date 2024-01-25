Imports System.Threading

Public Class loadingscreen
    Private Sub loadingscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()



    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        MyProgress.Increment(1)

        Percentage.Text = Convert.ToString(MyProgress.Value) + "%"

        If MyProgress.Value = 100 Then

            Me.Hide()

            Dim log = New Login
            log.Show()

            Timer1.Enabled = False

        End If
    End Sub
End Class