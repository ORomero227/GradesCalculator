'Oscar Romero Barbosa
'Numero de estudiante: Y00592812
'Programa calculadora de notas

Public Class Form1
	Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

		Const PROMEDIO As Integer = 100
		Const CANTIDAD_NOTAS As Integer = 4
		Dim grade1, grade2, grade3, grade4, finalGrade As Double
		Dim sumaValorNotas, promedioFinal As Double
		Dim errorEnNotas As Boolean = False
		Dim mensajeError As String = "Una de las notas no es válida o no esta en el rango 0-100"

		'Validacion de valores ingresados para las notas
		Try
			grade1 = CDbl(txtGrade1.Text)
			grade2 = CDbl(txtGrade2.Text)
			grade3 = CDbl(txtGrade3.Text)
			grade4 = CDbl(txtGrade4.Text)

			If (grade1 < 0 Or grade1 > 100) Or
				(grade2 < 0 Or grade2 > 100) Or
				(grade3 < 0 Or grade3 > 100) Or
				(grade4 < 0 Or grade4 > 100) Then
				MessageBox.Show(mensajeError)
				errorEnNotas = True
			End If
		Catch ex As Exception
			MessageBox.Show(mensajeError)
			errorEnNotas = True
		End Try

		If errorEnNotas = False Then
			'Sumar todas las notas
			sumaValorNotas = grade1 + grade2 + grade3 + grade4
			'Cálculo para la nota final
			finalGrade = sumaValorNotas / CANTIDAD_NOTAS
			'Cálculo para el promedio
			promedioFinal = sumaValorNotas / PROMEDIO

			'Asignar la letra correspondiente al promedio
			Select Case finalGrade
				Case 90 To 100
					lblFinalGrade.Text = finalGrade.ToString("n2") + "% -  A"
				Case 80 To 89
					lblFinalGrade.Text = finalGrade.ToString("n2") + "% -  B"
				Case 70 To 79
					lblFinalGrade.Text = finalGrade.ToString("n2") + "% -  C"
				Case 60 To 69
					lblFinalGrade.Text = finalGrade.ToString("n2") + "% -  D"
				Case <= 59
					lblFinalGrade.Text = finalGrade.ToString("n2") + "% -  F"
			End Select

			'Asignar el promedio al label
			lblGPA.Text = promedioFinal.ToString("n2")

			'Mensaje de aprobacion
			Select Case finalGrade
				Case >= 95
					lblMessage.Text = "Course passed with success!"
				Case Else
					lblMessage.Text = "You'll need to take the course again"
			End Select

			'Informacion del estudiante
			lblStudentName.Text = txtStudentName.Text
			lblStudentLastname.Text = txtStudentLastname.Text
			lblStudentID.Text = txtStudentID.Text

			ClearInputs()
		End If

	End Sub

	Private Sub ClearInputs()
		txtStudentName.Text = ""
		txtStudentLastname.Text = ""
		txtStudentID.Text = ""
		txtGrade1.Text = ""
		txtGrade2.Text = ""
		txtGrade3.Text = ""
		txtGrade4.Text = ""
	End Sub


	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub
End Class
