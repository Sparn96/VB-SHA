<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PASS_tb = New System.Windows.Forms.TextBox()
        Me.SALT_tb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SHA_cb = New System.Windows.Forms.ComboBox()
        Me.Convert_b = New System.Windows.Forms.Button()
        Me.Result_tb = New System.Windows.Forms.TextBox()
        Me.CopyToClip = New System.Windows.Forms.Button()
        Me.Compare1 = New System.Windows.Forms.TextBox()
        Me.Compare2 = New System.Windows.Forms.TextBox()
        Me.toCompare = New System.Windows.Forms.CheckBox()
        Me.CompareButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PASS_tb
        '
        Me.PASS_tb.Location = New System.Drawing.Point(85, 80)
        Me.PASS_tb.Name = "PASS_tb"
        Me.PASS_tb.Size = New System.Drawing.Size(405, 20)
        Me.PASS_tb.TabIndex = 1
        '
        'SALT_tb
        '
        Me.SALT_tb.Location = New System.Drawing.Point(85, 45)
        Me.SALT_tb.Name = "SALT_tb"
        Me.SALT_tb.Size = New System.Drawing.Size(89, 20)
        Me.SALT_tb.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "SALT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'SHA_cb
        '
        Me.SHA_cb.FormattingEnabled = True
        Me.SHA_cb.Items.AddRange(New Object() {"SHA-256", "SHA-512", "SALT SHA-256", "SALT SHA-512"})
        Me.SHA_cb.Location = New System.Drawing.Point(601, 79)
        Me.SHA_cb.Name = "SHA_cb"
        Me.SHA_cb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SHA_cb.Size = New System.Drawing.Size(195, 21)
        Me.SHA_cb.TabIndex = 5
        '
        'Convert_b
        '
        Me.Convert_b.BackColor = System.Drawing.SystemColors.Control
        Me.Convert_b.Cursor = System.Windows.Forms.Cursors.Default
        Me.Convert_b.Location = New System.Drawing.Point(496, 80)
        Me.Convert_b.Name = "Convert_b"
        Me.Convert_b.Size = New System.Drawing.Size(89, 22)
        Me.Convert_b.TabIndex = 6
        Me.Convert_b.Text = "Create HASH"
        Me.Convert_b.UseVisualStyleBackColor = False
        '
        'Result_tb
        '
        Me.Result_tb.Location = New System.Drawing.Point(85, 178)
        Me.Result_tb.Name = "Result_tb"
        Me.Result_tb.Size = New System.Drawing.Size(405, 20)
        Me.Result_tb.TabIndex = 7
        '
        'CopyToClip
        '
        Me.CopyToClip.Location = New System.Drawing.Point(496, 173)
        Me.CopyToClip.Name = "CopyToClip"
        Me.CopyToClip.Size = New System.Drawing.Size(100, 28)
        Me.CopyToClip.TabIndex = 8
        Me.CopyToClip.Text = "Copy to Clipboard"
        Me.CopyToClip.UseVisualStyleBackColor = True
        '
        'Compare1
        '
        Me.Compare1.Location = New System.Drawing.Point(82, 251)
        Me.Compare1.Name = "Compare1"
        Me.Compare1.Size = New System.Drawing.Size(679, 20)
        Me.Compare1.TabIndex = 9
        '
        'Compare2
        '
        Me.Compare2.Location = New System.Drawing.Point(82, 277)
        Me.Compare2.Name = "Compare2"
        Me.Compare2.Size = New System.Drawing.Size(679, 20)
        Me.Compare2.TabIndex = 10
        '
        'toCompare
        '
        Me.toCompare.AutoSize = True
        Me.toCompare.Location = New System.Drawing.Point(608, 185)
        Me.toCompare.Name = "toCompare"
        Me.toCompare.Size = New System.Drawing.Size(68, 17)
        Me.toCompare.TabIndex = 11
        Me.toCompare.Text = "Compare"
        Me.toCompare.UseVisualStyleBackColor = True
        '
        'CompareButton
        '
        Me.CompareButton.Location = New System.Drawing.Point(365, 302)
        Me.CompareButton.Name = "CompareButton"
        Me.CompareButton.Size = New System.Drawing.Size(124, 31)
        Me.CompareButton.TabIndex = 12
        Me.CompareButton.Text = "Compare"
        Me.CompareButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 352)
        Me.Controls.Add(Me.CompareButton)
        Me.Controls.Add(Me.toCompare)
        Me.Controls.Add(Me.Compare2)
        Me.Controls.Add(Me.Compare1)
        Me.Controls.Add(Me.CopyToClip)
        Me.Controls.Add(Me.Result_tb)
        Me.Controls.Add(Me.Convert_b)
        Me.Controls.Add(Me.SHA_cb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SALT_tb)
        Me.Controls.Add(Me.PASS_tb)
        Me.Name = "Form1"
        Me.Text = "SHA-TEST"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PASS_tb As TextBox
    Friend WithEvents SALT_tb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SHA_cb As ComboBox
    Friend WithEvents Convert_b As Button
    Friend WithEvents Result_tb As TextBox
    Friend WithEvents CopyToClip As Button
    Friend WithEvents Compare1 As TextBox
    Friend WithEvents Compare2 As TextBox
    Friend WithEvents toCompare As CheckBox
    Friend WithEvents CompareButton As Button
End Class
