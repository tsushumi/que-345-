<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Process
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GoButton = New System.Windows.Forms.Button()
        Me.TimerLabel1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(35, 77)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(529, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(306, 134)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(75, 23)
        Me.GoButton.TabIndex = 1
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'TimerLabel1
        '
        Me.TimerLabel1.AutoSize = True
        Me.TimerLabel1.Location = New System.Drawing.Point(621, 84)
        Me.TimerLabel1.Name = "TimerLabel1"
        Me.TimerLabel1.Size = New System.Drawing.Size(65, 15)
        Me.TimerLabel1.TabIndex = 2
        Me.TimerLabel1.Text = "TimerLabel"
        '
        'Process
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TimerLabel1)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "Process"
        Me.Text = "Process"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GoButton As Button
    Friend WithEvents TimerLabel1 As Label
End Class
