Public Class Factorial

   Private Function Factorial(ByVal x As Double) As Double
      If x <= 1 Then
         Return 1
      Else
         Factorial = x * Factorial(x - 1)
      End If
   End Function

   Private Function Permutation(ByVal n As Double, ByVal r As Double) As Double
      If r = 0 Then Permutation = 0
      If n = 0 Then Permutation = 0
      If (r >= 0) And (r <= n) Then
         Permutation = Factorial(n) / Factorial(n - r)
      Else
         Permutation = 0
      End If
   End Function

   Private Function Combinatorial(ByVal a As Long, ByVal b As Long) As Long
      If a <= 1 Then Combinatorial = 1

      Combinatorial = Factorial(a) / (Factorial(b) * Factorial(a - b))
   End Function

   Private Sub btnCalcFactorial_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalcFactorial.Click
      Dim number As Double
      Dim Result As Double

      Try
         number = txtFactNumber.Text
         Result = Factorial(number)
         txtFactorial.Text = Result.ToString()
      Catch ex As Exception
         MsgBox("Invalid Number")
      End Try
   End Sub

   Private Sub btnCalcPermutation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalcPermutation.Click
      Dim n As Double
      Dim r As Double
      Dim Result As Double

      Try
         n = txtPermutationN.Text
      Catch ex As Exception
         MsgBox("Invalid Number")
      End Try

      Try
         r = txtPermutationR.Text
         Result = Permutation(n, r)
         txtPermutation.Text = Result.ToString()
      Catch ex As Exception
         MsgBox("Invalid Number")
      End Try

   End Sub

   Private Sub btnCalcCombination_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalcCombination.Click
      Dim n As Long
      Dim r As Long
      Dim Result As Long

      Try
         n = txtCombinationN.Text
      Catch ex As Exception
         MsgBox("Invalid Number")
      End Try

      Try
         r = CLng(txtCombinationR.Text)
         Result = Combinatorial(n, r)
         txtCombination.Text = Result.ToString()
      Catch ex As Exception
         MsgBox("Invalid Number")
      End Try
   End Sub

   Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.Click
      End
   End Sub

End Class
