<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe08_03
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
        Me.cmdClose = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(136, 279)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(100, 28)
        Me.cmdClose.TabIndex = 1
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Recipe08_03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 332)
        Me.Controls.Add(Me.cmdClose)
        Me.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Recipe08_03"
        Me.Text = "Irregular Form"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdClose As System.Windows.Forms.Button

End Class
