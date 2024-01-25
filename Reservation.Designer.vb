<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateOut = New System.Windows.Forms.DateTimePicker()
        Me.DateIn = New System.Windows.Forms.DateTimePicker()
        Me.ReservationDGV = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RoomNumberCb = New System.Windows.Forms.ComboBox()
        Me.ClIDCb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ClNameTb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.ReservationDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.DateOut)
        Me.Panel2.Controls.Add(Me.DateIn)
        Me.Panel2.Controls.Add(Me.ReservationDGV)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.RoomNumberCb)
        Me.Panel2.Controls.Add(Me.ClIDCb)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ClNameTb)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(91, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(709, 450)
        Me.Panel2.TabIndex = 2
        '
        'DateOut
        '
        Me.DateOut.Location = New System.Drawing.Point(538, 106)
        Me.DateOut.Name = "DateOut"
        Me.DateOut.Size = New System.Drawing.Size(92, 20)
        Me.DateOut.TabIndex = 19
        '
        'DateIn
        '
        Me.DateIn.Location = New System.Drawing.Point(411, 106)
        Me.DateIn.Name = "DateIn"
        Me.DateIn.Size = New System.Drawing.Size(84, 20)
        Me.DateIn.TabIndex = 18
        '
        'ReservationDGV
        '
        Me.ReservationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReservationDGV.Location = New System.Drawing.Point(67, 303)
        Me.ReservationDGV.Name = "ReservationDGV"
        Me.ReservationDGV.Size = New System.Drawing.Size(601, 122)
        Me.ReservationDGV.TabIndex = 17
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(511, 152)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 48)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(376, 152)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 48)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(257, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 48)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(137, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 48)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(411, 253)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(84, 20)
        Me.TextBox4.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label7.Location = New System.Drawing.Point(186, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 31)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Reservation List"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(554, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Date Out"
        '
        'RoomNumberCb
        '
        Me.RoomNumberCb.FormattingEnabled = True
        Me.RoomNumberCb.Location = New System.Drawing.Point(281, 104)
        Me.RoomNumberCb.Name = "RoomNumberCb"
        Me.RoomNumberCb.Size = New System.Drawing.Size(79, 21)
        Me.RoomNumberCb.TabIndex = 9
        '
        'ClIDCb
        '
        Me.ClIDCb.FormattingEnabled = True
        Me.ClIDCb.Location = New System.Drawing.Point(67, 105)
        Me.ClIDCb.Name = "ClIDCb"
        Me.ClIDCb.Size = New System.Drawing.Size(58, 21)
        Me.ClIDCb.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(419, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Date In"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(305, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Room Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(175, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Client Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Client ID"
        '
        'ClNameTb
        '
        Me.ClNameTb.Location = New System.Drawing.Point(152, 106)
        Me.ClNameTb.Name = "ClNameTb"
        Me.ClNameTb.Size = New System.Drawing.Size(84, 20)
        Me.ClNameTb.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(172, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DREAMNIGHTS HOTEL"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(-2, 239)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(87, 48)
        Me.Button7.TabIndex = 32
        Me.Button7.Text = "Clients"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(-2, 166)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(87, 48)
        Me.Button6.TabIndex = 31
        Me.Button6.Text = "Room"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(-2, 90)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 48)
        Me.Button5.TabIndex = 30
        Me.Button5.Text = "Staff"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(-2, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 18)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Reservation"
        '
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button5)
        Me.Name = "Reservation"
        Me.Text = "Reservation"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ReservationDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents ReservationDGV As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RoomNumberCb As ComboBox
    Friend WithEvents ClIDCb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ClNameTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateOut As DateTimePicker
    Friend WithEvents DateIn As DateTimePicker
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label8 As Label
End Class
