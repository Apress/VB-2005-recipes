<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe12_09
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recipe12_09))
        Me.AxMaskEdBox1 = New AxMSMask.AxMaskEdBox
        CType(Me.AxMaskEdBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxMaskEdBox1
        '
        Me.AxMaskEdBox1.Location = New System.Drawing.Point(10, 15)
        Me.AxMaskEdBox1.Name = "AxMaskEdBox1"
        Me.AxMaskEdBox1.OcxState = CType(resources.GetObject("AxMaskEdBox1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMaskEdBox1.Size = New System.Drawing.Size(247, 43)
        Me.AxMaskEdBox1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.AxMaskEdBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxMaskEdBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxMaskEdBox1 As AxMSMask.AxMaskEdBox

End Class
