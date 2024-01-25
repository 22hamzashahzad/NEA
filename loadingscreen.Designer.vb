<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loadingscreen
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Percentage = New System.Windows.Forms.Label()
        Me.MyProgress = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(195, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(406, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HOTEL MANGEMENT SYSTEM"
        '
        'Percentage
        '
        Me.Percentage.AutoSize = True
        Me.Percentage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Percentage.Location = New System.Drawing.Point(381, 127)
        Me.Percentage.Name = "Percentage"
        Me.Percentage.Size = New System.Drawing.Size(30, 25)
        Me.Percentage.TabIndex = 1
        Me.Percentage.Text = "%"
        '
        'MyProgress
        '
        Me.MyProgress.Location = New System.Drawing.Point(1, 417)
        Me.MyProgress.Name = "MyProgress"
        Me.MyProgress.Size = New System.Drawing.Size(799, 34)
        Me.MyProgress.TabIndex = 2
        '
        'loadingscreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MyProgress)
        Me.Controls.Add(Me.Percentage)
        Me.Controls.Add(Me.Label1)
        Me.Name = "loadingscreen"
        Me.Text = "loadingscreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Percentage As Label
    Friend WithEvents MyProgress As ProgressBar
    Friend WithEvents Timer1 As Timer
End Class
