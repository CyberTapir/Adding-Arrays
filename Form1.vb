Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arrNum(13) As Integer
        Dim Total As Integer
        Total = 0
        arrNum = {0, 5, 1, 8, 5, 4, 76, 2, 8, 2, 9, 34, 67, 278}
        For i = 1 To 13
            Total = Total + arrNum(i)
        Next i
        MsgBox(Total)
    End Sub
End Class
