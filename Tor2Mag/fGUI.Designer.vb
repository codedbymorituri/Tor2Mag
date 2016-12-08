<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fGUI
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
        Me.ButtonConvert = New System.Windows.Forms.Button()
        Me.LabelDragAndDrop = New System.Windows.Forms.Label()
        Me.CheckBoxTrackerInfo = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ButtonConvert
        '
        Me.ButtonConvert.Location = New System.Drawing.Point(169, 78)
        Me.ButtonConvert.Name = "ButtonConvert"
        Me.ButtonConvert.Size = New System.Drawing.Size(75, 23)
        Me.ButtonConvert.TabIndex = 0
        Me.ButtonConvert.Text = "Convert"
        Me.ButtonConvert.UseVisualStyleBackColor = True
        '
        'LabelDragAndDrop
        '
        Me.LabelDragAndDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelDragAndDrop.Location = New System.Drawing.Point(12, 9)
        Me.LabelDragAndDrop.Name = "LabelDragAndDrop"
        Me.LabelDragAndDrop.Size = New System.Drawing.Size(232, 62)
        Me.LabelDragAndDrop.TabIndex = 3
        Me.LabelDragAndDrop.Text = "Drag and Drop .torrent file here"
        Me.LabelDragAndDrop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBoxTrackerInfo
        '
        Me.CheckBoxTrackerInfo.AutoSize = True
        Me.CheckBoxTrackerInfo.Location = New System.Drawing.Point(12, 82)
        Me.CheckBoxTrackerInfo.Name = "CheckBoxTrackerInfo"
        Me.CheckBoxTrackerInfo.Size = New System.Drawing.Size(117, 17)
        Me.CheckBoxTrackerInfo.TabIndex = 4
        Me.CheckBoxTrackerInfo.Text = "Include tracker info"
        Me.CheckBoxTrackerInfo.UseVisualStyleBackColor = True
        '
        'fGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 112)
        Me.Controls.Add(Me.CheckBoxTrackerInfo)
        Me.Controls.Add(Me.LabelDragAndDrop)
        Me.Controls.Add(Me.ButtonConvert)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "fGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Torrent File to Magnet Link"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonConvert As Button
    Friend WithEvents LabelDragAndDrop As Label
    Friend WithEvents CheckBoxTrackerInfo As CheckBox
End Class
