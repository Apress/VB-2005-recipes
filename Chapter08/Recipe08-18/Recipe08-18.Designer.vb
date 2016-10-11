<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe08_18
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
        Me.label1 = New System.Windows.Forms.Label
        Me.txtJobInfo = New System.Windows.Forms.TextBox
        Me.lstJobs = New System.Windows.Forms.ListBox
        Me.cmdResume = New System.Windows.Forms.Button
        Me.cmdPause = New System.Windows.Forms.Button
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(19, 17)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(74, 17)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Job Name:"
        '
        'txtJobInfo
        '
        Me.txtJobInfo.Location = New System.Drawing.Point(19, 37)
        Me.txtJobInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJobInfo.Name = "txtJobInfo"
        Me.txtJobInfo.ReadOnly = True
        Me.txtJobInfo.Size = New System.Drawing.Size(356, 23)
        Me.txtJobInfo.TabIndex = 8
        '
        'lstJobs
        '
        Me.lstJobs.FormattingEnabled = True
        Me.lstJobs.ItemHeight = 16
        Me.lstJobs.Location = New System.Drawing.Point(127, 69)
        Me.lstJobs.Margin = New System.Windows.Forms.Padding(4)
        Me.lstJobs.Name = "lstJobs"
        Me.lstJobs.Size = New System.Drawing.Size(248, 244)
        Me.lstJobs.TabIndex = 7
        '
        'cmdResume
        '
        Me.cmdResume.Location = New System.Drawing.Point(19, 140)
        Me.cmdResume.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdResume.Name = "cmdResume"
        Me.cmdResume.Size = New System.Drawing.Size(100, 28)
        Me.cmdResume.TabIndex = 4
        Me.cmdResume.Text = "Resume"
        Me.cmdResume.UseVisualStyleBackColor = True
        '
        'cmdPause
        '
        Me.cmdPause.Location = New System.Drawing.Point(19, 104)
        Me.cmdPause.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(100, 28)
        Me.cmdPause.TabIndex = 5
        Me.cmdPause.Text = "Pause"
        Me.cmdPause.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(19, 69)
        Me.cmdRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(100, 28)
        Me.cmdRefresh.TabIndex = 6
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'Recipe08_18
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 331)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtJobInfo)
        Me.Controls.Add(Me.lstJobs)
        Me.Controls.Add(Me.cmdResume)
        Me.Controls.Add(Me.cmdPause)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Recipe08_18"
        Me.Text = "Print Queue Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtJobInfo As System.Windows.Forms.TextBox
    Private WithEvents lstJobs As System.Windows.Forms.ListBox
    Private WithEvents cmdResume As System.Windows.Forms.Button
    Private WithEvents cmdPause As System.Windows.Forms.Button
    Private WithEvents cmdRefresh As System.Windows.Forms.Button

End Class
