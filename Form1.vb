'Oscar Romero Barbosa
'Numero de estudiante: Y00592812
'Programa calculadora de notas

Public Class Form1
	Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

		Const PROMEDIO As Integer = 100
		Const CANTIDAD_NOTAS As Integer = 4
		Dim nombreEstudiante, apellidosEstudiante, numeroEstudiante As String
		Dim nota1, nota2, nota3, nota4, notaFinal As Double
		Dim sumaValorNotas, promedioFinal As Double

		'Validacion de entrada Nombre, Apellido y Numero de Estudiante
		If inputNombre.Text <> "" And inputApellidos.Text <> "" And inputNumEstudiante.Text <> "" Then
			nombreEstudiante = inputNombre.Text
			apellidosEstudiante = inputApellidos.Text
			numeroEstudiante = inputNumEstudiante.Text
		Else
			MessageBox.Show("Ingrese la informacion completa del estudiante")
		End If

		'Validacion de entrada nota #1
		If Double.TryParse(inputNota1.Text, nota1) Then
			If nota1 <= 100 And nota1 >= 0 Then
				sumaValorNotas += nota1
			Else
				MessageBox.Show("La valor de la nota #1 no es valido!")
			End If
		Else
			MessageBox.Show("La valor de la nota #1 no es valido!")
		End If

		'Validacion de entrada nota #2 
		If Double.TryParse(inputNota2.Text, nota2) Then
			If nota2 <= 100 And nota2 >= 0 Then
				sumaValorNotas += nota2
			Else
				MessageBox.Show("La valor de la nota #2 no es valido!")
			End If
		Else
			MessageBox.Show("La valor de la nota #2 no es valido!")
		End If

		'Validacion de entrada nota #3
		If Double.TryParse(inputNota3.Text, nota3) Then
			If nota3 <= 100 And nota3 >= 0 Then
				sumaValorNotas += nota3
			Else
				MessageBox.Show("La valor de la nota #3 no es valido!")
			End If
		Else
			MessageBox.Show("La valor de la nota #3 no es valido!")
		End If

		'Validacion de entrada nota #4
		If Double.TryParse(inputNota4.Text, nota4) Then
			If nota4 <= 100 And nota4 >= 0 Then
				sumaValorNotas += nota4
			Else
				MessageBox.Show("La valor de la nota #4 no es valido!")
			End If
		Else
			MessageBox.Show("La valor de la nota #4 no es valido!")
		End If

		'Colocar la informacion del estudiante en el area de resultados
		lblNombreEstudiante.Text = inputNombre.Text
		lblApellidos.Text = inputApellidos.Text
		lblNumeroEstudiante.Text = inputNumEstudiante.Text

		'Dividir la cantidad total de notas con la suma de los valores
		notaFinal = sumaValorNotas / CANTIDAD_NOTAS

		'Verificacion para asignar la nota
		Select Case notaFinal
			Case 90 To 100
				lblNotaFinal.Text = notaFinal.ToString() + "% - A"
			Case 80 To 89
				lblNotaFinal.Text = notaFinal.ToString() + "% - B"
			Case 70 To 79
				lblNotaFinal.Text = notaFinal.ToString() + "% - C"
			Case 60 To 69
				lblNotaFinal.Text = notaFinal.ToString() + "% - D"
			Case <= 59
				lblNotaFinal.Text = notaFinal.ToString() + "% - F"
		End Select

		'Calculo para sacar el promedio final
		promedioFinal = sumaValorNotas / PROMEDIO
		lblPromedio.Text = promedioFinal.ToString("n")

		'Mensaje de aprobacion o rechazo
		Select Case notaFinal
			Case >= 95
				lblEstado.Text = "Estudiante de honor"
			Case Else
				lblEstado.Text = "Debe tomar un curso en verano"
		End Select

		ClearInputsText()

	End Sub

	Private Sub ClearInputsText()
		inputNombre.Text = ""
		inputApellidos.Text = ""
		inputNumEstudiante.Text = ""
		inputNota1.Text = ""
		inputNota2.Text = ""
		inputNota3.Text = ""
		inputNota4.Text = ""
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Me.Close()
	End Sub
End Class
