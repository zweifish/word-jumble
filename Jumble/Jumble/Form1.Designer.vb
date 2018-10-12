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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.jumbleLBL = New System.Windows.Forms.Label()
        Me.inputTXT = New System.Windows.Forms.TextBox()
        Me.EnterBTN = New System.Windows.Forms.Button()
        Me.rescramBTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ResultLBL = New System.Windows.Forms.Label()
        Me.NewBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'jumbleLBL
        '
        Me.jumbleLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.jumbleLBL.Location = New System.Drawing.Point(20, 154)
        Me.jumbleLBL.Name = "jumbleLBL"
        Me.jumbleLBL.Size = New System.Drawing.Size(172, 23)
        Me.jumbleLBL.TabIndex = 0
        '
        'inputTXT
        '
        Me.inputTXT.Location = New System.Drawing.Point(20, 197)
        Me.inputTXT.Name = "inputTXT"
        Me.inputTXT.Size = New System.Drawing.Size(172, 20)
        Me.inputTXT.TabIndex = 2
        '
        'EnterBTN
        '
        Me.EnterBTN.Enabled = False
        Me.EnterBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EnterBTN.FlatAppearance.BorderSize = 3
        Me.EnterBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EnterBTN.Location = New System.Drawing.Point(198, 197)
        Me.EnterBTN.Name = "EnterBTN"
        Me.EnterBTN.Size = New System.Drawing.Size(77, 20)
        Me.EnterBTN.TabIndex = 3
        Me.EnterBTN.Text = "Go!"
        Me.EnterBTN.UseVisualStyleBackColor = True
        '
        'rescramBTN
        '
        Me.rescramBTN.Enabled = False
        Me.rescramBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rescramBTN.FlatAppearance.BorderSize = 3
        Me.rescramBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rescramBTN.Location = New System.Drawing.Point(198, 154)
        Me.rescramBTN.Name = "rescramBTN"
        Me.rescramBTN.Size = New System.Drawing.Size(77, 20)
        Me.rescramBTN.TabIndex = 4
        Me.rescramBTN.Text = "Rescramble"
        Me.rescramBTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Courier New", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(15, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(480, 84)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'ResultLBL
        '
        Me.ResultLBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ResultLBL.Location = New System.Drawing.Point(291, 154)
        Me.ResultLBL.Name = "ResultLBL"
        Me.ResultLBL.Size = New System.Drawing.Size(206, 63)
        Me.ResultLBL.TabIndex = 6
        '
        'NewBTN
        '
        Me.NewBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NewBTN.FlatAppearance.BorderSize = 0
        Me.NewBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.NewBTN.Location = New System.Drawing.Point(15, 9)
        Me.NewBTN.Name = "NewBTN"
        Me.NewBTN.Size = New System.Drawing.Size(77, 20)
        Me.NewBTN.TabIndex = 7
        Me.NewBTN.Text = "New Game"
        Me.NewBTN.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(522, 240)
        Me.Controls.Add(Me.NewBTN)
        Me.Controls.Add(Me.ResultLBL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rescramBTN)
        Me.Controls.Add(Me.EnterBTN)
        Me.Controls.Add(Me.inputTXT)
        Me.Controls.Add(Me.jumbleLBL)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Word Jumble"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents jumbleLBL As Label
    Friend WithEvents inputTXT As TextBox
    Friend WithEvents EnterBTN As Button
    Friend WithEvents rescramBTN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ResultLBL As Label
    Friend WithEvents NewBTN As Button
End Class
