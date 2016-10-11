<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe08_07
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
        Me.components = New System.ComponentModel.Container
        Me.chkUseDoubleBuffering = New System.Windows.Forms.CheckBox
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'chkUseDoubleBuffering
        '
        Me.chkUseDoubleBuffering.AutoSize = True
        Me.chkUseDoubleBuffering.Location = New System.Drawing.Point(13, 13)
        Me.chkUseDoubleBuffering.Margin = New System.Windows.Forms.Padding(4)
        Me.chkUseDoubleBuffering.Name = "chkUseDoubleBuffering"
        Me.chkUseDoubleBuffering.Size = New System.Drawing.Size(157, 21)
        Me.chkUseDoubleBuffering.TabIndex = 1
        Me.chkUseDoubleBuffering.Text = "Use Double Buffering"
        Me.chkUseDoubleBuffering.UseVisualStyleBackColor = True
        '
        'Recipe08_07
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 341)
        Me.Controls.Add(Me.chkUseDoubleBuffering)
        Me.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Recipe08_07"
        Me.Text = "Double Buffering"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents chkUseDoubleBuffering As System.Windows.Forms.CheckBox
    Private WithEvents tmrRefresh As System.Windows.Forms.Timer

End Class
