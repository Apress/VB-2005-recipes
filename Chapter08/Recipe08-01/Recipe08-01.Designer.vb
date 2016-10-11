<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe08_01
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
        Me.pnlFonts = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'pnlFonts
        '
        Me.pnlFonts.AutoScroll = True
        Me.pnlFonts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFonts.Location = New System.Drawing.Point(0, 0)
        Me.pnlFonts.Name = "pnlFonts"
        Me.pnlFonts.Size = New System.Drawing.Size(299, 276)
        Me.pnlFonts.TabIndex = 1
        '
        'Recipe08_01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 276)
        Me.Controls.Add(Me.pnlFonts)
        Me.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Recipe08_01"
        Me.Text = "List of Installed Fonts"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents pnlFonts As System.Windows.Forms.Panel

End Class
