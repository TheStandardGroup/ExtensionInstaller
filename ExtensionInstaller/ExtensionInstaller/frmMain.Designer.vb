<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.chlbDeploys = New System.Windows.Forms.CheckedListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chlbDeploys
        '
        Me.chlbDeploys.FormattingEnabled = True
        Me.chlbDeploys.Location = New System.Drawing.Point(12, 12)
        Me.chlbDeploys.Name = "chlbDeploys"
        Me.chlbDeploys.Size = New System.Drawing.Size(242, 259)
        Me.chlbDeploys.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Location = New System.Drawing.Point(41, 295)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuit.Location = New System.Drawing.Point(137, 295)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 2
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 342)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.chlbDeploys)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TSG: Extension Installer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chlbDeploys As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button

End Class
