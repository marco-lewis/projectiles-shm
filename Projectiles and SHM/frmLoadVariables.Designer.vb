<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoadVariables
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
        Me.btnLoadBT = New System.Windows.Forms.Button()
        Me.btnDeleteData = New System.Windows.Forms.Button()
        Me.lstVariables = New System.Windows.Forms.ListBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLoadBT
        '
        Me.btnLoadBT.Location = New System.Drawing.Point(181, 140)
        Me.btnLoadBT.Name = "btnLoadBT"
        Me.btnLoadBT.Size = New System.Drawing.Size(117, 27)
        Me.btnLoadBT.TabIndex = 1
        Me.btnLoadBT.Text = "Load Variables"
        Me.btnLoadBT.UseVisualStyleBackColor = True
        '
        'btnDeleteData
        '
        Me.btnDeleteData.Location = New System.Drawing.Point(181, 81)
        Me.btnDeleteData.Name = "btnDeleteData"
        Me.btnDeleteData.Size = New System.Drawing.Size(117, 27)
        Me.btnDeleteData.TabIndex = 2
        Me.btnDeleteData.Text = "Delete Data"
        Me.btnDeleteData.UseVisualStyleBackColor = True
        '
        'lstVariables
        '
        Me.lstVariables.FormattingEnabled = True
        Me.lstVariables.Location = New System.Drawing.Point(22, 51)
        Me.lstVariables.Name = "lstVariables"
        Me.lstVariables.Size = New System.Drawing.Size(127, 147)
        Me.lstVariables.TabIndex = 5
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(19, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(39, 13)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Label1"
        '
        'frmLoadVariables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 216)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lstVariables)
        Me.Controls.Add(Me.btnDeleteData)
        Me.Controls.Add(Me.btnLoadBT)
        Me.Name = "frmLoadVariables"
        Me.Text = "frmLoadBallThrowVars"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoadBT As Button
    Friend WithEvents btnDeleteData As Button
    Friend WithEvents lstVariables As System.Windows.Forms.ListBox
    Friend WithEvents lblTitle As Label
End Class
