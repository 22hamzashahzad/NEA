<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ALPasswordTb = New System.Windows.Forms.Label()
        Me.Apasswordtb = New System.Windows.Forms.TextBox()
        Me.ALStaffIDTb = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.ALPasswordTb)
        Me.Panel1.Controls.Add(Me.Apasswordtb)
        Me.Panel1.Controls.Add(Me.ALStaffIDTb)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(481, 450)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(452, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "X"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(124, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Admin"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(54, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 48)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(40, 291)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ALPasswordTb
        '
        Me.ALPasswordTb.AutoSize = True
        Me.ALPasswordTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ALPasswordTb.Location = New System.Drawing.Point(35, 237)
        Me.ALPasswordTb.Name = "ALPasswordTb"
        Me.ALPasswordTb.Size = New System.Drawing.Size(98, 25)
        Me.ALPasswordTb.TabIndex = 5
        Me.ALPasswordTb.Text = "Password"
        '
        'Apasswordtb
        '
        Me.Apasswordtb.Location = New System.Drawing.Point(40, 265)
        Me.Apasswordtb.Name = "Apasswordtb"
        Me.Apasswordtb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Apasswordtb.Size = New System.Drawing.Size(159, 20)
        Me.Apasswordtb.TabIndex = 4
        '
        'ALStaffIDTb
        '
        Me.ALStaffIDTb.AutoSize = True
        Me.ALStaffIDTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.ALStaffIDTb.Location = New System.Drawing.Point(34, 133)
        Me.ALStaffIDTb.Name = "ALStaffIDTb"
        Me.ALStaffIDTb.Size = New System.Drawing.Size(76, 25)
        Me.ALStaffIDTb.TabIndex = 3
        Me.ALStaffIDTb.Text = "Staff ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(39, 161)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(33, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ACCOUNT LOGIN"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(522, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ALPasswordTb As Label
    Friend WithEvents Apasswordtb As TextBox
    Friend WithEvents ALStaffIDTb As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
