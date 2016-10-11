<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XmlTreeDisplay
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
        Me.treeXml = New System.Windows.Forms.TreeView
        Me.label1 = New System.Windows.Forms.Label
        Me.cmdLoad = New System.Windows.Forms.Button
        Me.txtXmlFile = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'treeXml
        '
        Me.treeXml.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.treeXml.Location = New System.Drawing.Point(4, 38)
        Me.treeXml.Name = "treeXml"
        Me.treeXml.Size = New System.Drawing.Size(496, 264)
        Me.treeXml.TabIndex = 5
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(5, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(27, 18)
        Me.label1.TabIndex = 10
        Me.label1.Text = "File:"
        '
        'cmdLoad
        '
        Me.cmdLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdLoad.Location = New System.Drawing.Point(451, 8)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(49, 24)
        Me.cmdLoad.TabIndex = 9
        Me.cmdLoad.Text = "Load"
        '
        'txtXmlFile
        '
        Me.txtXmlFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtXmlFile.Location = New System.Drawing.Point(33, 10)
        Me.txtXmlFile.Name = "txtXmlFile"
        Me.txtXmlFile.Size = New System.Drawing.Size(410, 23)
        Me.txtXmlFile.TabIndex = 8
        '
        'XmlTreeDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 314)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.txtXmlFile)
        Me.Controls.Add(Me.treeXml)
        Me.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "XmlTreeDisplay"
        Me.Text = "XmlTreeDisplay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents treeXml As System.Windows.Forms.TreeView
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cmdLoad As System.Windows.Forms.Button
    Private WithEvents txtXmlFile As System.Windows.Forms.TextBox

End Class
