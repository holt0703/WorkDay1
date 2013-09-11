Option Strict On

Public Class Form1

    Private Sub btnCalcBMI_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcBMI.Click
        Dim hSt As String
        Dim wSt As String

        hSt = txtHeight.Text
        wSt = txtWeight.Text

        Dim w As Double
        Dim h As Double

        h = CDbl(hSt)
        w = CDbl(wSt)

        Dim BMI As Double
        BMI = (w * 703) / (h ^ 2)

        TextBox1.Text = CStr(BMI)
    End Sub
End Class
