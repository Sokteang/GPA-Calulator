Public Class frmGPA
    Dim SubTotal, TotalCredit, Grade As Integer
    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click
        If txtGrade.Text = "A" Then
            Grade = 4
        ElseIf txtGrade.Text = "B" Then
            Grade = 3
        ElseIf txtGrade.Text = "C" Then
            Grade = 2
        ElseIf txtGrade.Text = "D" Then
            Grade = 1
        ElseIf txtGrade.Text = "F" Then
            Grade = 0
        End If
        SubTotal += GRecord()
        TotalCredit += CInt(txtCredit.Text)
        txtGrade.Clear()
        txtCredit.Clear()
        lstCourse.ClearSelected()
        txtGrade.Focus()
        'I created the lstcourse listbox just to make the user easy to assign the course to put their grade.
    End Sub
    Function GRecord() As Double
        Dim Credit As Integer = CInt(txtCredit.Text)
        SubTotal = Grade * Credit
        Return SubTotal
    End Function

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim GPA As Double
        GPA = SubTotal / TotalCredit
        txtGPA.Text = GPA
    End Sub
End Class
