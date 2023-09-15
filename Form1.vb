'Oscar Romero Barbosa
'Numero de estudiante: Y00592812
'Programa calculadora de notas

Public Class Form1
	Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

		Const PROMEDIO As Integer = 100
		Const CANTIDAD_NOTAS As Integer = 4
		Dim nota1, nota2, nota3, nota4, notaFinal As Double
		Dim sumaValorNotas, promedioFinal As Double
		Dim errorEnNotas As Boolean = False
		Dim mensajeError As String = "Una de las notas no es válida o no esta en el rango 0-100"

		'Validacion de valores ingresados para las notas
		Try
			nota1 = CDbl(txtNota1.Text)
			nota2 = CDbl(txtNota2.Text)
			nota3 = CDbl(txtNota3.Text)
			nota4 = CDbl(txtNota4.Text)

			If (nota1 < 0 Or nota1 > 100) Or
				(nota2 < 0 Or nota2 > 100) Or
				(nota3 < 0 Or nota3 > 100) Or
				(nota4 < 0 Or nota4 > 100) Then
				MessageBox.Show(mensajeError)
				errorEnNotas = True
			End If
		Catch ex As Exception
			MessageBox.Show(mensajeError)
			errorEnNotas = True
		End Try

		If errorEnNotas = False Then
			'Sumar todas las notas
			sumaValorNotas = nota1 + nota2 + nota3 + nota4
			'Cálculo para la nota final
			notaFinal = sumaValorNotas / CANTIDAD_NOTAS
			'Cálculo para el promedio
			promedioFinal = sumaValorNotas / PROMEDIO

			'Asignar la letra correspondiente al promedio
			Select Case notaFinal
				Case 90 To 100
					lblNotaFinal.Text = notaFinal.ToString("n2") + "% -  A"
				Case 80 To 89
					lblNotaFinal.Text = notaFinal.ToString("n2") + "% -  B"
				Case 70 To 79
					lblNotaFinal.Text = notaFinal.ToString("n2") + "% -  C"
				Case 60 To 69
					lblNotaFinal.Text = notaFinal.ToString("n2") + "% -  D"
				Case <= 59
					lblNotaFinal.Text = notaFinal.ToString("n2") + "% -  F"
			End Select

			'Asignar el promedio al label
			lblPromedio.Text = promedioFinal.ToString("n2")

			'Mensaje de aprobacion
			Select Case notaFinal
				Case >= 95
					lblMensaje.Text = "Estudiante de honor"
				Case Else
					lblMensaje.Text = "Necesita tomar un curso en verano"
			End Select

			'Informacion del estudiante
			lblNombreEstudiante.Text = inputNombre.Text
			lblApellidos.Text = inputApellidos.Text
			lblNumeroEstudiante.Text = inputNumEstudiante.Text

			ClearInputs()
		End If

	End Sub

	Private Sub ClearInputs()
		inputNombre.Text = ""
		inputApellidos.Text = ""
		inputNumEstudiante.Text = ""
		txtNota1.Text = ""
		txtNota2.Text = ""
		txtNota3.Text = ""
		txtNota4.Text = ""
	End Sub


	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Me.Close()
	End Sub
End Class
