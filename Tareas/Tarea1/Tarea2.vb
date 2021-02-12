Public Class Tarea2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Alumno As String
        Dim nota1, nota2, promedio As Double
        Dim escuela, clase As String
        Dim cantidadAlumnos As String
        Dim i As Integer

        escuela = txtcentro.Text
        clase = txtclase.Text
        cantidadAlumnos = Val(txtCalumnos.Text)


        For i = 1 To cantidadAlumnos Step 1

            Alumno = InputBox("Ingrese el nombre y apellido del alumno" & i, "Alumno")
            nota1 = InputBox("Nota del I Parcial" & i, "Nota 1")
            nota2 = InputBox("Nota del II Parcial" & i, "Nota 2")

            promedio = (nota1 + nota2) / 2

            If (promedio > 91) Then
                lbExcelencia.Items.Add(Alumno & "  " & clase & "  " & escuela & "  " & nota1 & "  " & nota2 & "  " & promedio & "  " & "EXCELENCIA")
            ElseIf (promedio > 60 And promedio < 91) Then
                lbAprobados.Items.Add(Alumno & "  " & clase & "  " & escuela & "  " & nota1 & "  " & nota2 & "  " & promedio & "  " & "APROBADO")
            ElseIf (promedio < 60) Then
                lbReprobados.Items.Add(Alumno & "  " & clase & "  " & escuela & "  " & nota1 & "  " & nota2 & "  " & promedio & "  " & "REPROBADP")
            End If
        Next

    End Sub
End Class