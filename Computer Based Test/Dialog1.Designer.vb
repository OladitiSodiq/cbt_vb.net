<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog1
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.urclass = New System.Windows.Forms.Label()
        Me.jss1 = New System.Windows.Forms.RadioButton()
        Me.jss2 = New System.Windows.Forms.RadioButton()
        Me.jss3 = New System.Windows.Forms.RadioButton()
        Me.sss1 = New System.Windows.Forms.RadioButton()
        Me.sss2 = New System.Windows.Forms.RadioButton()
        Me.sss3 = New System.Windows.Forms.RadioButton()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(699, 307)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'urclass
        '
        Me.urclass.AutoSize = True
        Me.urclass.BackColor = System.Drawing.Color.Azure
        Me.urclass.ForeColor = System.Drawing.Color.DodgerBlue
        Me.urclass.Location = New System.Drawing.Point(26, 69)
        Me.urclass.Name = "urclass"
        Me.urclass.Size = New System.Drawing.Size(32, 13)
        Me.urclass.TabIndex = 1
        Me.urclass.Text = "Class"
        '
        'jss1
        '
        Me.jss1.AutoSize = True
        Me.jss1.BackColor = System.Drawing.Color.Azure
        Me.jss1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.jss1.Location = New System.Drawing.Point(103, 69)
        Me.jss1.Name = "jss1"
        Me.jss1.Size = New System.Drawing.Size(158, 17)
        Me.jss1.TabIndex = 2
        Me.jss1.TabStop = True
        Me.jss1.Text = "Junnior Secondary School 1"
        Me.jss1.UseVisualStyleBackColor = False
        '
        'jss2
        '
        Me.jss2.AutoSize = True
        Me.jss2.BackColor = System.Drawing.Color.Azure
        Me.jss2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.jss2.Location = New System.Drawing.Point(103, 113)
        Me.jss2.Name = "jss2"
        Me.jss2.Size = New System.Drawing.Size(158, 17)
        Me.jss2.TabIndex = 3
        Me.jss2.TabStop = True
        Me.jss2.Text = "Junnior Secondary School 2"
        Me.jss2.UseVisualStyleBackColor = False
        '
        'jss3
        '
        Me.jss3.AutoSize = True
        Me.jss3.BackColor = System.Drawing.Color.Azure
        Me.jss3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.jss3.Location = New System.Drawing.Point(103, 162)
        Me.jss3.Name = "jss3"
        Me.jss3.Size = New System.Drawing.Size(158, 17)
        Me.jss3.TabIndex = 4
        Me.jss3.TabStop = True
        Me.jss3.Text = "Junnior Secondary School 3"
        Me.jss3.UseVisualStyleBackColor = False
        '
        'sss1
        '
        Me.sss1.AutoSize = True
        Me.sss1.BackColor = System.Drawing.Color.Azure
        Me.sss1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.sss1.Location = New System.Drawing.Point(103, 219)
        Me.sss1.Name = "sss1"
        Me.sss1.Size = New System.Drawing.Size(160, 17)
        Me.sss1.TabIndex = 5
        Me.sss1.TabStop = True
        Me.sss1.Text = "Sennior Secondary School 1"
        Me.sss1.UseVisualStyleBackColor = False
        '
        'sss2
        '
        Me.sss2.AutoSize = True
        Me.sss2.BackColor = System.Drawing.Color.Azure
        Me.sss2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.sss2.Location = New System.Drawing.Point(103, 271)
        Me.sss2.Name = "sss2"
        Me.sss2.Size = New System.Drawing.Size(160, 17)
        Me.sss2.TabIndex = 6
        Me.sss2.TabStop = True
        Me.sss2.Text = "Sennior Secondary School 2"
        Me.sss2.UseVisualStyleBackColor = False
        '
        'sss3
        '
        Me.sss3.AutoSize = True
        Me.sss3.BackColor = System.Drawing.Color.Azure
        Me.sss3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.sss3.Location = New System.Drawing.Point(103, 312)
        Me.sss3.Name = "sss3"
        Me.sss3.Size = New System.Drawing.Size(160, 17)
        Me.sss3.TabIndex = 7
        Me.sss3.TabStop = True
        Me.sss3.Text = "Sennior Secondary School 3"
        Me.sss3.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(857, 348)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.LightBlue
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.RectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot
        Me.RectangleShape1.FillColor = System.Drawing.Color.DarkTurquoise
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.LightCyan
        Me.RectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.LargeConfetti
        Me.RectangleShape1.Location = New System.Drawing.Point(-1, 45)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(859, 293)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(846, 39)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "POSIT COLLEGE OF PURE AND APPLIED SCIENCE "
        '
        'Dialog1
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Computer_Based_Test.My.Resources.Resources.blueRule
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(857, 348)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sss3)
        Me.Controls.Add(Me.sss2)
        Me.Controls.Add(Me.sss1)
        Me.Controls.Add(Me.jss3)
        Me.Controls.Add(Me.jss2)
        Me.Controls.Add(Me.jss1)
        Me.Controls.Add(Me.urclass)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dialog1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents urclass As System.Windows.Forms.Label
    Friend WithEvents jss1 As System.Windows.Forms.RadioButton
    Friend WithEvents jss2 As System.Windows.Forms.RadioButton
    Friend WithEvents jss3 As System.Windows.Forms.RadioButton
    Friend WithEvents sss1 As System.Windows.Forms.RadioButton
    Friend WithEvents sss2 As System.Windows.Forms.RadioButton
    Friend WithEvents sss3 As System.Windows.Forms.RadioButton
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
