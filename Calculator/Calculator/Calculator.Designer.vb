<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.resultsBox = New System.Windows.Forms.TextBox
        Me.clearButton = New System.Windows.Forms.Button
        Me.add7Button = New System.Windows.Forms.Button
        Me.add5Button = New System.Windows.Forms.Button
        Me.add8Button = New System.Windows.Forms.Button
        Me.add9Button = New System.Windows.Forms.Button
        Me.plusNegativeButton = New System.Windows.Forms.Button
        Me.zeroButton = New System.Windows.Forms.Button
        Me.add2Button = New System.Windows.Forms.Button
        Me.add1Button = New System.Windows.Forms.Button
        Me.add4Button = New System.Windows.Forms.Button
        Me.add6Button = New System.Windows.Forms.Button
        Me.multiplyButton = New System.Windows.Forms.Button
        Me.divideButton = New System.Windows.Forms.Button
        Me.add3Button = New System.Windows.Forms.Button
        Me.decimalButton = New System.Windows.Forms.Button
        Me.minusButton = New System.Windows.Forms.Button
        Me.plusButton = New System.Windows.Forms.Button
        Me.equalButton = New System.Windows.Forms.Button
        Me.StringBox = New System.Windows.Forms.TextBox
        Me.cosButton = New System.Windows.Forms.Button
        Me.sinButton = New System.Windows.Forms.Button
        Me.tanButton = New System.Windows.Forms.Button
        Me.backButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'resultsBox
        '
        Me.resultsBox.Location = New System.Drawing.Point(27, 41)
        Me.resultsBox.Name = "resultsBox"
        Me.resultsBox.Size = New System.Drawing.Size(452, 20)
        Me.resultsBox.TabIndex = 0
        Me.resultsBox.TabStop = False
        Me.resultsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Location = New System.Drawing.Point(27, 71)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(308, 45)
        Me.clearButton.TabIndex = 1
        Me.clearButton.Text = "C"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'add7Button
        '
        Me.add7Button.Location = New System.Drawing.Point(27, 135)
        Me.add7Button.Name = "add7Button"
        Me.add7Button.Size = New System.Drawing.Size(74, 61)
        Me.add7Button.TabIndex = 2
        Me.add7Button.Text = "&7"
        Me.add7Button.UseVisualStyleBackColor = True
        '
        'add5Button
        '
        Me.add5Button.Location = New System.Drawing.Point(124, 210)
        Me.add5Button.Name = "add5Button"
        Me.add5Button.Size = New System.Drawing.Size(74, 61)
        Me.add5Button.TabIndex = 3
        Me.add5Button.Text = "&5"
        Me.add5Button.UseVisualStyleBackColor = True
        '
        'add8Button
        '
        Me.add8Button.Location = New System.Drawing.Point(124, 135)
        Me.add8Button.Name = "add8Button"
        Me.add8Button.Size = New System.Drawing.Size(74, 61)
        Me.add8Button.TabIndex = 4
        Me.add8Button.Text = "&8"
        Me.add8Button.UseVisualStyleBackColor = True
        '
        'add9Button
        '
        Me.add9Button.Location = New System.Drawing.Point(221, 135)
        Me.add9Button.Name = "add9Button"
        Me.add9Button.Size = New System.Drawing.Size(74, 61)
        Me.add9Button.TabIndex = 5
        Me.add9Button.Text = "&9"
        Me.add9Button.UseVisualStyleBackColor = True
        '
        'plusNegativeButton
        '
        Me.plusNegativeButton.Location = New System.Drawing.Point(124, 360)
        Me.plusNegativeButton.Name = "plusNegativeButton"
        Me.plusNegativeButton.Size = New System.Drawing.Size(74, 61)
        Me.plusNegativeButton.TabIndex = 6
        Me.plusNegativeButton.Text = "+/-"
        Me.plusNegativeButton.UseVisualStyleBackColor = True
        '
        'zeroButton
        '
        Me.zeroButton.Location = New System.Drawing.Point(27, 360)
        Me.zeroButton.Name = "zeroButton"
        Me.zeroButton.Size = New System.Drawing.Size(74, 61)
        Me.zeroButton.TabIndex = 7
        Me.zeroButton.Text = "&0"
        Me.zeroButton.UseVisualStyleBackColor = True
        '
        'add2Button
        '
        Me.add2Button.Location = New System.Drawing.Point(124, 285)
        Me.add2Button.Name = "add2Button"
        Me.add2Button.Size = New System.Drawing.Size(74, 61)
        Me.add2Button.TabIndex = 8
        Me.add2Button.Text = "&2"
        Me.add2Button.UseVisualStyleBackColor = True
        '
        'add1Button
        '
        Me.add1Button.Location = New System.Drawing.Point(27, 285)
        Me.add1Button.Name = "add1Button"
        Me.add1Button.Size = New System.Drawing.Size(74, 61)
        Me.add1Button.TabIndex = 9
        Me.add1Button.Text = "&1"
        Me.add1Button.UseVisualStyleBackColor = True
        '
        'add4Button
        '
        Me.add4Button.Location = New System.Drawing.Point(27, 210)
        Me.add4Button.Name = "add4Button"
        Me.add4Button.Size = New System.Drawing.Size(74, 61)
        Me.add4Button.TabIndex = 10
        Me.add4Button.Text = "&4"
        Me.add4Button.UseVisualStyleBackColor = True
        '
        'add6Button
        '
        Me.add6Button.Location = New System.Drawing.Point(221, 210)
        Me.add6Button.Name = "add6Button"
        Me.add6Button.Size = New System.Drawing.Size(74, 61)
        Me.add6Button.TabIndex = 11
        Me.add6Button.Text = "&6"
        Me.add6Button.UseVisualStyleBackColor = True
        '
        'multiplyButton
        '
        Me.multiplyButton.Location = New System.Drawing.Point(404, 135)
        Me.multiplyButton.Name = "multiplyButton"
        Me.multiplyButton.Size = New System.Drawing.Size(74, 61)
        Me.multiplyButton.TabIndex = 12
        Me.multiplyButton.Text = "*"
        Me.multiplyButton.UseVisualStyleBackColor = True
        '
        'divideButton
        '
        Me.divideButton.Location = New System.Drawing.Point(403, 63)
        Me.divideButton.Name = "divideButton"
        Me.divideButton.Size = New System.Drawing.Size(74, 61)
        Me.divideButton.TabIndex = 13
        Me.divideButton.Text = "/"
        Me.divideButton.UseVisualStyleBackColor = True
        '
        'add3Button
        '
        Me.add3Button.Location = New System.Drawing.Point(221, 285)
        Me.add3Button.Name = "add3Button"
        Me.add3Button.Size = New System.Drawing.Size(74, 61)
        Me.add3Button.TabIndex = 14
        Me.add3Button.Text = "&3"
        Me.add3Button.UseVisualStyleBackColor = True
        '
        'decimalButton
        '
        Me.decimalButton.Location = New System.Drawing.Point(221, 360)
        Me.decimalButton.Name = "decimalButton"
        Me.decimalButton.Size = New System.Drawing.Size(74, 61)
        Me.decimalButton.TabIndex = 15
        Me.decimalButton.Text = "."
        Me.decimalButton.UseVisualStyleBackColor = True
        '
        'minusButton
        '
        Me.minusButton.Location = New System.Drawing.Point(404, 210)
        Me.minusButton.Name = "minusButton"
        Me.minusButton.Size = New System.Drawing.Size(74, 61)
        Me.minusButton.TabIndex = 16
        Me.minusButton.Text = "-"
        Me.minusButton.UseVisualStyleBackColor = True
        '
        'plusButton
        '
        Me.plusButton.Location = New System.Drawing.Point(403, 285)
        Me.plusButton.Name = "plusButton"
        Me.plusButton.Size = New System.Drawing.Size(74, 61)
        Me.plusButton.TabIndex = 17
        Me.plusButton.Text = "+"
        Me.plusButton.UseVisualStyleBackColor = True
        '
        'equalButton
        '
        Me.equalButton.Location = New System.Drawing.Point(403, 361)
        Me.equalButton.Name = "equalButton"
        Me.equalButton.Size = New System.Drawing.Size(74, 61)
        Me.equalButton.TabIndex = 19
        Me.equalButton.Text = "="
        Me.equalButton.UseVisualStyleBackColor = True
        '
        'StringBox
        '
        Me.StringBox.Location = New System.Drawing.Point(27, 15)
        Me.StringBox.Name = "StringBox"
        Me.StringBox.ReadOnly = True
        Me.StringBox.Size = New System.Drawing.Size(451, 20)
        Me.StringBox.TabIndex = 20
        Me.StringBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cosButton
        '
        Me.cosButton.Location = New System.Drawing.Point(315, 210)
        Me.cosButton.Name = "cosButton"
        Me.cosButton.Size = New System.Drawing.Size(74, 61)
        Me.cosButton.TabIndex = 21
        Me.cosButton.Text = "&Cos"
        Me.cosButton.UseVisualStyleBackColor = True
        '
        'sinButton
        '
        Me.sinButton.Location = New System.Drawing.Point(315, 135)
        Me.sinButton.Name = "sinButton"
        Me.sinButton.Size = New System.Drawing.Size(74, 61)
        Me.sinButton.TabIndex = 22
        Me.sinButton.Text = "&Sin"
        Me.sinButton.UseVisualStyleBackColor = True
        '
        'tanButton
        '
        Me.tanButton.Location = New System.Drawing.Point(315, 285)
        Me.tanButton.Name = "tanButton"
        Me.tanButton.Size = New System.Drawing.Size(74, 61)
        Me.tanButton.TabIndex = 23
        Me.tanButton.Text = "&Tan"
        Me.tanButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.Location = New System.Drawing.Point(315, 360)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(74, 61)
        Me.backButton.TabIndex = 24
        Me.backButton.Text = "&Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        Me.AcceptButton = Me.equalButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(513, 441)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.tanButton)
        Me.Controls.Add(Me.sinButton)
        Me.Controls.Add(Me.cosButton)
        Me.Controls.Add(Me.StringBox)
        Me.Controls.Add(Me.equalButton)
        Me.Controls.Add(Me.plusButton)
        Me.Controls.Add(Me.minusButton)
        Me.Controls.Add(Me.decimalButton)
        Me.Controls.Add(Me.add3Button)
        Me.Controls.Add(Me.divideButton)
        Me.Controls.Add(Me.multiplyButton)
        Me.Controls.Add(Me.add6Button)
        Me.Controls.Add(Me.add4Button)
        Me.Controls.Add(Me.add1Button)
        Me.Controls.Add(Me.add2Button)
        Me.Controls.Add(Me.zeroButton)
        Me.Controls.Add(Me.plusNegativeButton)
        Me.Controls.Add(Me.add9Button)
        Me.Controls.Add(Me.add8Button)
        Me.Controls.Add(Me.add5Button)
        Me.Controls.Add(Me.add7Button)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.resultsBox)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximizeBox = False
        Me.Name = "Calculator"
        Me.Text = "Carlos' Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents resultsBox As System.Windows.Forms.TextBox
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents add7Button As System.Windows.Forms.Button
    Friend WithEvents add5Button As System.Windows.Forms.Button
    Friend WithEvents add8Button As System.Windows.Forms.Button
    Friend WithEvents add9Button As System.Windows.Forms.Button
    Friend WithEvents plusNegativeButton As System.Windows.Forms.Button
    Friend WithEvents zeroButton As System.Windows.Forms.Button
    Friend WithEvents add2Button As System.Windows.Forms.Button
    Friend WithEvents add1Button As System.Windows.Forms.Button
    Friend WithEvents add4Button As System.Windows.Forms.Button
    Friend WithEvents add6Button As System.Windows.Forms.Button
    Friend WithEvents multiplyButton As System.Windows.Forms.Button
    Friend WithEvents divideButton As System.Windows.Forms.Button
    Friend WithEvents add3Button As System.Windows.Forms.Button
    Friend WithEvents decimalButton As System.Windows.Forms.Button
    Friend WithEvents minusButton As System.Windows.Forms.Button
    Friend WithEvents plusButton As System.Windows.Forms.Button
    Friend WithEvents equalButton As System.Windows.Forms.Button
    Friend WithEvents StringBox As System.Windows.Forms.TextBox
    Friend WithEvents cosButton As System.Windows.Forms.Button
    Friend WithEvents sinButton As System.Windows.Forms.Button
    Friend WithEvents tanButton As System.Windows.Forms.Button
    Friend WithEvents backButton As System.Windows.Forms.Button

End Class
