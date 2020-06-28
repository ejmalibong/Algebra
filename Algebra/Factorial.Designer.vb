<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factorial
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing AndAlso components IsNot Nothing Then
         components.Dispose()
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.tclAlgebra = New System.Windows.Forms.TabControl()
      Me.tabFactorial = New System.Windows.Forms.TabPage()
      Me.btnCalcFactorial = New System.Windows.Forms.Button()
      Me.txtFactorial = New System.Windows.Forms.TextBox()
      Me.label8 = New System.Windows.Forms.Label()
      Me.txtFactNumber = New System.Windows.Forms.TextBox()
      Me.label1 = New System.Windows.Forms.Label()
      Me.tabPermutation = New System.Windows.Forms.TabPage()
      Me.btnCalcPermutation = New System.Windows.Forms.Button()
      Me.txtPermutation = New System.Windows.Forms.TextBox()
      Me.label4 = New System.Windows.Forms.Label()
      Me.txtPermutationR = New System.Windows.Forms.TextBox()
      Me.label3 = New System.Windows.Forms.Label()
      Me.txtPermutationN = New System.Windows.Forms.TextBox()
      Me.label2 = New System.Windows.Forms.Label()
      Me.tabCombination = New System.Windows.Forms.TabPage()
      Me.btnCalcCombination = New System.Windows.Forms.Button()
      Me.txtCombination = New System.Windows.Forms.TextBox()
      Me.label5 = New System.Windows.Forms.Label()
      Me.txtCombinationR = New System.Windows.Forms.TextBox()
      Me.label6 = New System.Windows.Forms.Label()
      Me.txtCombinationN = New System.Windows.Forms.TextBox()
      Me.label7 = New System.Windows.Forms.Label()
      Me.btnClose = New System.Windows.Forms.Button()
      Me.tclAlgebra.SuspendLayout()
      Me.tabFactorial.SuspendLayout()
      Me.tabPermutation.SuspendLayout()
      Me.tabCombination.SuspendLayout()
      Me.SuspendLayout()
      '
      'tclAlgebra
      '
      Me.tclAlgebra.Controls.Add(Me.tabFactorial)
      Me.tclAlgebra.Controls.Add(Me.tabPermutation)
      Me.tclAlgebra.Controls.Add(Me.tabCombination)
      Me.tclAlgebra.HotTrack = True
      Me.tclAlgebra.Location = New System.Drawing.Point(13, 10)
      Me.tclAlgebra.Name = "tclAlgebra"
      Me.tclAlgebra.SelectedIndex = 0
      Me.tclAlgebra.Size = New System.Drawing.Size(272, 158)
      Me.tclAlgebra.TabIndex = 3
      '
      'tabFactorial
      '
      Me.tabFactorial.Controls.Add(Me.btnCalcFactorial)
      Me.tabFactorial.Controls.Add(Me.txtFactorial)
      Me.tabFactorial.Controls.Add(Me.label8)
      Me.tabFactorial.Controls.Add(Me.txtFactNumber)
      Me.tabFactorial.Controls.Add(Me.label1)
      Me.tabFactorial.Location = New System.Drawing.Point(4, 22)
      Me.tabFactorial.Name = "tabFactorial"
      Me.tabFactorial.Padding = New System.Windows.Forms.Padding(3)
      Me.tabFactorial.Size = New System.Drawing.Size(264, 132)
      Me.tabFactorial.TabIndex = 0
      Me.tabFactorial.Text = "Factorial"
      Me.tabFactorial.UseVisualStyleBackColor = True
      '
      'btnCalcFactorial
      '
      Me.btnCalcFactorial.Location = New System.Drawing.Point(153, 17)
      Me.btnCalcFactorial.Name = "btnCalcFactorial"
      Me.btnCalcFactorial.Size = New System.Drawing.Size(75, 23)
      Me.btnCalcFactorial.TabIndex = 17
      Me.btnCalcFactorial.Text = "Calculate"
      Me.btnCalcFactorial.UseVisualStyleBackColor = True
      '
      'txtFactorial
      '
      Me.txtFactorial.Location = New System.Drawing.Point(88, 54)
      Me.txtFactorial.Name = "txtFactorial"
      Me.txtFactorial.Size = New System.Drawing.Size(140, 20)
      Me.txtFactorial.TabIndex = 7
      Me.txtFactorial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'label8
      '
      Me.label8.AutoSize = True
      Me.label8.Location = New System.Drawing.Point(22, 56)
      Me.label8.Name = "label8"
      Me.label8.Size = New System.Drawing.Size(40, 13)
      Me.label8.TabIndex = 6
      Me.label8.Text = "Result:"
      '
      'txtFactNumber
      '
      Me.txtFactNumber.Location = New System.Drawing.Point(88, 18)
      Me.txtFactNumber.Name = "txtFactNumber"
      Me.txtFactNumber.Size = New System.Drawing.Size(50, 20)
      Me.txtFactNumber.TabIndex = 5
      Me.txtFactNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'label1
      '
      Me.label1.AutoSize = True
      Me.label1.Location = New System.Drawing.Point(22, 21)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(47, 13)
      Me.label1.TabIndex = 4
      Me.label1.Text = "Number:"
      '
      'tabPermutation
      '
      Me.tabPermutation.Controls.Add(Me.btnCalcPermutation)
      Me.tabPermutation.Controls.Add(Me.txtPermutation)
      Me.tabPermutation.Controls.Add(Me.label4)
      Me.tabPermutation.Controls.Add(Me.txtPermutationR)
      Me.tabPermutation.Controls.Add(Me.label3)
      Me.tabPermutation.Controls.Add(Me.txtPermutationN)
      Me.tabPermutation.Controls.Add(Me.label2)
      Me.tabPermutation.Location = New System.Drawing.Point(4, 22)
      Me.tabPermutation.Name = "tabPermutation"
      Me.tabPermutation.Padding = New System.Windows.Forms.Padding(3)
      Me.tabPermutation.Size = New System.Drawing.Size(264, 132)
      Me.tabPermutation.TabIndex = 1
      Me.tabPermutation.Text = "Permutation"
      Me.tabPermutation.UseVisualStyleBackColor = True
      '
      'btnCalcPermutation
      '
      Me.btnCalcPermutation.Location = New System.Drawing.Point(152, 53)
      Me.btnCalcPermutation.Name = "btnCalcPermutation"
      Me.btnCalcPermutation.Size = New System.Drawing.Size(75, 23)
      Me.btnCalcPermutation.TabIndex = 14
      Me.btnCalcPermutation.Text = "Calculate"
      Me.btnCalcPermutation.UseVisualStyleBackColor = True
      '
      'txtPermutation
      '
      Me.txtPermutation.Location = New System.Drawing.Point(88, 90)
      Me.txtPermutation.Name = "txtPermutation"
      Me.txtPermutation.Size = New System.Drawing.Size(140, 20)
      Me.txtPermutation.TabIndex = 13
      Me.txtPermutation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'label4
      '
      Me.label4.AutoSize = True
      Me.label4.Location = New System.Drawing.Point(22, 92)
      Me.label4.Name = "label4"
      Me.label4.Size = New System.Drawing.Size(38, 13)
      Me.label4.TabIndex = 12
      Me.label4.Text = "P(n, r):"
      '
      'txtPermutationR
      '
      Me.txtPermutationR.Location = New System.Drawing.Point(88, 54)
      Me.txtPermutationR.Name = "txtPermutationR"
      Me.txtPermutationR.Size = New System.Drawing.Size(50, 20)
      Me.txtPermutationR.TabIndex = 11
      Me.txtPermutationR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'label3
      '
      Me.label3.AutoSize = True
      Me.label3.Location = New System.Drawing.Point(22, 56)
      Me.label3.Name = "label3"
      Me.label3.Size = New System.Drawing.Size(13, 13)
      Me.label3.TabIndex = 10
      Me.label3.Text = "r:"
      '
      'txtPermutationN
      '
      Me.txtPermutationN.Location = New System.Drawing.Point(88, 18)
      Me.txtPermutationN.Name = "txtPermutationN"
      Me.txtPermutationN.Size = New System.Drawing.Size(50, 20)
      Me.txtPermutationN.TabIndex = 9
      Me.txtPermutationN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'label2
      '
      Me.label2.AutoSize = True
      Me.label2.Location = New System.Drawing.Point(22, 21)
      Me.label2.Name = "label2"
      Me.label2.Size = New System.Drawing.Size(16, 13)
      Me.label2.TabIndex = 8
      Me.label2.Text = "n:"
      '
      'tabCombination
      '
      Me.tabCombination.Controls.Add(Me.btnCalcCombination)
      Me.tabCombination.Controls.Add(Me.txtCombination)
      Me.tabCombination.Controls.Add(Me.label5)
      Me.tabCombination.Controls.Add(Me.txtCombinationR)
      Me.tabCombination.Controls.Add(Me.label6)
      Me.tabCombination.Controls.Add(Me.txtCombinationN)
      Me.tabCombination.Controls.Add(Me.label7)
      Me.tabCombination.Location = New System.Drawing.Point(4, 22)
      Me.tabCombination.Name = "tabCombination"
      Me.tabCombination.Padding = New System.Windows.Forms.Padding(3)
      Me.tabCombination.Size = New System.Drawing.Size(264, 132)
      Me.tabCombination.TabIndex = 2
      Me.tabCombination.Text = "Combination"
      Me.tabCombination.UseVisualStyleBackColor = True
      '
      'btnCalcCombination
      '
      Me.btnCalcCombination.Location = New System.Drawing.Point(152, 53)
      Me.btnCalcCombination.Name = "btnCalcCombination"
      Me.btnCalcCombination.Size = New System.Drawing.Size(75, 23)
      Me.btnCalcCombination.TabIndex = 23
      Me.btnCalcCombination.Text = "Calculate"
      Me.btnCalcCombination.UseVisualStyleBackColor = True
      '
      'txtCombination
      '
      Me.txtCombination.Location = New System.Drawing.Point(88, 90)
      Me.txtCombination.Name = "txtCombination"
      Me.txtCombination.Size = New System.Drawing.Size(140, 20)
      Me.txtCombination.TabIndex = 22
      Me.txtCombination.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'label5
      '
      Me.label5.AutoSize = True
      Me.label5.Location = New System.Drawing.Point(22, 92)
      Me.label5.Name = "label5"
      Me.label5.Size = New System.Drawing.Size(38, 13)
      Me.label5.TabIndex = 21
      Me.label5.Text = "C(n, r):"
      '
      'txtCombinationR
      '
      Me.txtCombinationR.Location = New System.Drawing.Point(88, 54)
      Me.txtCombinationR.Name = "txtCombinationR"
      Me.txtCombinationR.Size = New System.Drawing.Size(50, 20)
      Me.txtCombinationR.TabIndex = 20
      Me.txtCombinationR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'label6
      '
      Me.label6.AutoSize = True
      Me.label6.Location = New System.Drawing.Point(22, 56)
      Me.label6.Name = "label6"
      Me.label6.Size = New System.Drawing.Size(13, 13)
      Me.label6.TabIndex = 19
      Me.label6.Text = "r:"
      '
      'txtCombinationN
      '
      Me.txtCombinationN.Location = New System.Drawing.Point(88, 18)
      Me.txtCombinationN.Name = "txtCombinationN"
      Me.txtCombinationN.Size = New System.Drawing.Size(50, 20)
      Me.txtCombinationN.TabIndex = 18
      Me.txtCombinationN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'label7
      '
      Me.label7.AutoSize = True
      Me.label7.Location = New System.Drawing.Point(22, 21)
      Me.label7.Name = "label7"
      Me.label7.Size = New System.Drawing.Size(16, 13)
      Me.label7.TabIndex = 17
      Me.label7.Text = "n:"
      '
      'btnClose
      '
      Me.btnClose.Location = New System.Drawing.Point(210, 178)
      Me.btnClose.Name = "btnClose"
      Me.btnClose.Size = New System.Drawing.Size(75, 23)
      Me.btnClose.TabIndex = 4
      Me.btnClose.Text = "Close"
      Me.btnClose.UseVisualStyleBackColor = True
      '
      'FPC
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(298, 210)
      Me.Controls.Add(Me.tclAlgebra)
      Me.Controls.Add(Me.btnClose)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "FPC"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Factorial, Permutation, and Combination"
      Me.tclAlgebra.ResumeLayout(False)
      Me.tabFactorial.ResumeLayout(False)
      Me.tabFactorial.PerformLayout()
      Me.tabPermutation.ResumeLayout(False)
      Me.tabPermutation.PerformLayout()
      Me.tabCombination.ResumeLayout(False)
      Me.tabCombination.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Private WithEvents tclAlgebra As System.Windows.Forms.TabControl
   Private WithEvents tabFactorial As System.Windows.Forms.TabPage
   Private WithEvents btnCalcFactorial As System.Windows.Forms.Button
   Private WithEvents txtFactorial As System.Windows.Forms.TextBox
   Private WithEvents label8 As System.Windows.Forms.Label
   Private WithEvents txtFactNumber As System.Windows.Forms.TextBox
   Private WithEvents label1 As System.Windows.Forms.Label
   Private WithEvents tabPermutation As System.Windows.Forms.TabPage
   Private WithEvents btnCalcPermutation As System.Windows.Forms.Button
   Private WithEvents txtPermutation As System.Windows.Forms.TextBox
   Private WithEvents label4 As System.Windows.Forms.Label
   Private WithEvents txtPermutationR As System.Windows.Forms.TextBox
   Private WithEvents label3 As System.Windows.Forms.Label
   Private WithEvents txtPermutationN As System.Windows.Forms.TextBox
   Private WithEvents label2 As System.Windows.Forms.Label
   Private WithEvents tabCombination As System.Windows.Forms.TabPage
   Private WithEvents btnCalcCombination As System.Windows.Forms.Button
   Private WithEvents txtCombination As System.Windows.Forms.TextBox
   Private WithEvents label5 As System.Windows.Forms.Label
   Private WithEvents txtCombinationR As System.Windows.Forms.TextBox
   Private WithEvents label6 As System.Windows.Forms.Label
   Private WithEvents txtCombinationN As System.Windows.Forms.TextBox
   Private WithEvents label7 As System.Windows.Forms.Label
   Private WithEvents btnClose As System.Windows.Forms.Button

End Class
