Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declaración de variables
        Dim acum1, acum2, acum3, acum4, exam1, exam2, exam3, exam4 As Integer
        Dim nota1, nota2, nota3, nota4, promedio As Integer
        Dim maximo, minimo As Integer
        Dim Nombre As String

        'Datos
        acum1 = Val(txtAcum1.Text)
        acum2 = Val(txtAcum2.Text)
        acum3 = Val(txtAcum3.Text)
        acum4 = Val(txtAcum4.Text)
        exam1 = Val(txtExam1.Text)
        exam2 = Val(txtExam2.Text)
        exam3 = Val(txtExam3.Text)
        exam4 = Val(txtExam4.Text)
        Nombre = txtNombre.Text

        nota1 = acum1 + exam1
        nota2 = acum2 + exam2
        nota3 = acum3 + exam3
        nota4 = acum4 + exam4

        promedio = (nota1 + nota2 + nota3 + nota4) / 4

        txtPromedio.Text = promedio

        If (nota1 > nota2 And nota1 > nota3 And nota1 > nota4) Then
            maximo = nota1
        ElseIf (nota2 > nota1 And nota2 > nota3 And nota2 > nota4) Then
            maximo = nota2
        ElseIf (nota3 > nota1 And nota3 > nota2 And nota3 > nota4) Then
            maximo = nota2
        Else
            maximo = nota4
        End If

        If (nota1 < nota2 And nota1 < nota3 And nota1 < nota4) Then
            minimo = nota1
        ElseIf (nota2 < nota1 And nota2 < nota3 And nota2 < nota4) Then
            minimo = nota2
        ElseIf (nota3 < nota1 And nota3 < nota2 And nota3 < nota4) Then
            minimo = nota2
        Else
            minimo = nota4
        End If

        txtmax.Text = maximo
        txtmin.Text = minimo

        lbMensaje.Visible = True

        If (promedio >= 91) Then
            lbMensaje.Text = "Avanzado"
        ElseIf (promedio >= 81) Then
            lbMensaje.Text = "Satisfactorio"
        ElseIf (promedio >= 70) Then
            lbMensaje.Text = "Bueno"
        ElseIf (promedio >= 60) Then
            lbMensaje.Text = "Aprobado"
        ElseIf (promedio >= 50) Then
            lbMensaje.Text = "Puedes mejorar, falta poco :)"
        Else
            lbMensaje.Text = "Debes mejorar"


        End If
        lstHistorial.Items.Add(Nombre & "  ............" & promedio)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtAcum1.Clear()
        txtAcum2.Clear()
        txtAcum3.Clear()
        txtAcum4.Clear()
        txtExam1.Clear()
        txtExam2.Clear()
        txtExam3.Clear()
        txtExam4.Clear()
        txtNombre.Clear()
        txtPromedio.Clear()
        txtmin.Clear()
        txtmax.Clear()

    End Sub
End Class
