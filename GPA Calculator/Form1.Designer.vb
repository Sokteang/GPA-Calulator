<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGPA
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
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblGPA = New System.Windows.Forms.Label()
        Me.txtGPA = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lstCourse = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'txtCredit
        '
        Me.txtCredit.Location = New System.Drawing.Point(186, 127)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(45, 20)
        Me.txtCredit.TabIndex = 3
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(70, 91)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(110, 13)
        Me.lblGrade.TabIndex = 2
        Me.lblGrade.Text = "Grade (A, B, C, D, F) :"
        '
        'lblCredit
        '
        Me.lblCredit.AutoSize = True
        Me.lblCredit.Location = New System.Drawing.Point(114, 127)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(66, 13)
        Me.lblCredit.TabIndex = 3
        Me.lblCredit.Text = "Credit hours:"
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(73, 190)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(158, 32)
        Me.btnRecord.TabIndex = 4
        Me.btnRecord.Text = "Record This Course"
        Me.btnRecord.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(73, 246)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(158, 32)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate GPA"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblGPA
        '
        Me.lblGPA.AutoSize = True
        Me.lblGPA.Location = New System.Drawing.Point(90, 311)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(32, 13)
        Me.lblGPA.TabIndex = 6
        Me.lblGPA.Text = "GPA:"
        '
        'txtGPA
        '
        Me.txtGPA.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtGPA.Location = New System.Drawing.Point(135, 308)
        Me.txtGPA.Name = "txtGPA"
        Me.txtGPA.Size = New System.Drawing.Size(96, 20)
        Me.txtGPA.TabIndex = 7
        '
        'txtGrade
        '
        Me.txtGrade.Location = New System.Drawing.Point(186, 88)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.Size = New System.Drawing.Size(45, 20)
        Me.txtGrade.TabIndex = 2
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(12, 18)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(74, 13)
        Me.lblCourse.TabIndex = 9
        Me.lblCourse.Text = "Course Name:"
        '
        'lstCourse
        '
        Me.lstCourse.FormattingEnabled = True
        Me.lstCourse.Items.AddRange(New Object() {"Programming", "Discovering Computer", "Khmer Study", "ACAD", "Economic", "Calculus", "Physic", "Physic Lab", "Math BUS", "IR", "Education"})
        Me.lstCourse.Location = New System.Drawing.Point(92, 12)
        Me.lstCourse.Name = "lstCourse"
        Me.lstCourse.Size = New System.Drawing.Size(139, 56)
        Me.lstCourse.TabIndex = 10
        '
        'frmGPA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 340)
        Me.Controls.Add(Me.lstCourse)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.txtGPA)
        Me.Controls.Add(Me.lblGPA)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.txtCredit)
        Me.Name = "frmGPA"
        Me.Text = "GPA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblGPA As System.Windows.Forms.Label
    Friend WithEvents txtGPA As System.Windows.Forms.TextBox
    Friend WithEvents txtGrade As System.Windows.Forms.TextBox
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents lstCourse As System.Windows.Forms.ListBox

End Class
