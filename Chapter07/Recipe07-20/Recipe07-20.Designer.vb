<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recipe07_20
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
        Me.forwardButton = New System.Windows.Forms.Button
        Me.homeButton = New System.Windows.Forms.Button
        Me.backButton = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.textURL = New System.Windows.Forms.TextBox
        Me.goButton = New System.Windows.Forms.Button
        Me.webBrowser1 = New System.Windows.Forms.WebBrowser
        Me.SuspendLayout()
        '
        'forwardButton
        '
        Me.forwardButton.Enabled = False
        Me.forwardButton.Location = New System.Drawing.Point(522, 324)
        Me.forwardButton.Margin = New System.Windows.Forms.Padding(4)
        Me.forwardButton.Name = "forwardButton"
        Me.forwardButton.Size = New System.Drawing.Size(100, 28)
        Me.forwardButton.TabIndex = 6
        Me.forwardButton.Text = "Forward >>"
        '
        'homeButton
        '
        Me.homeButton.Location = New System.Drawing.Point(414, 324)
        Me.homeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(100, 28)
        Me.homeButton.TabIndex = 7
        Me.homeButton.Text = "Home"
        '
        'backButton
        '
        Me.backButton.Enabled = False
        Me.backButton.Location = New System.Drawing.Point(306, 324)
        Me.backButton.Margin = New System.Windows.Forms.Padding(4)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(100, 28)
        Me.backButton.TabIndex = 4
        Me.backButton.Text = "<< Back"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(284, 288)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(31, 16)
        Me.label1.TabIndex = 5
        Me.label1.Text = "Go to:"
        '
        'textURL
        '
        Me.textURL.Location = New System.Drawing.Point(323, 285)
        Me.textURL.Margin = New System.Windows.Forms.Padding(4)
        Me.textURL.Name = "textURL"
        Me.textURL.Size = New System.Drawing.Size(251, 23)
        Me.textURL.TabIndex = 9
        Me.textURL.Text = "http://www.apress.com"
        '
        'goButton
        '
        Me.goButton.Location = New System.Drawing.Point(583, 284)
        Me.goButton.Margin = New System.Windows.Forms.Padding(4)
        Me.goButton.Name = "goButton"
        Me.goButton.Size = New System.Drawing.Size(64, 28)
        Me.goButton.TabIndex = 8
        Me.goButton.Text = "Go"
        '
        'webBrowser1
        '
        Me.webBrowser1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webBrowser1.Location = New System.Drawing.Point(0, -1)
        Me.webBrowser1.Margin = New System.Windows.Forms.Padding(4)
        Me.webBrowser1.Name = "webBrowser1"
        Me.webBrowser1.Size = New System.Drawing.Size(913, 255)
        Me.webBrowser1.TabIndex = 10
        '
        'Recipe07_20
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 373)
        Me.Controls.Add(Me.forwardButton)
        Me.Controls.Add(Me.homeButton)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textURL)
        Me.Controls.Add(Me.goButton)
        Me.Controls.Add(Me.webBrowser1)
        Me.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Recipe07_20"
        Me.Text = "Recipe07_20"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents forwardButton As System.Windows.Forms.Button
    Private WithEvents homeButton As System.Windows.Forms.Button
    Private WithEvents backButton As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents textURL As System.Windows.Forms.TextBox
    Private WithEvents goButton As System.Windows.Forms.Button
    Private WithEvents webBrowser1 As System.Windows.Forms.WebBrowser

End Class
