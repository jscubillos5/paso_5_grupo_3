Public Class FormLevel1Assessment

#Region "Declaración de variables y constantes Globales al formulario"

    Private minutes As Integer
    Private seconds As Integer
    Private Const MAX_SECONDS = 59
    Private Const MAX_MINUTES = 2
    Private Const MIN_FORMAT_SECONDS = 10
    Private Const FORM_IDEN = 1
    Private studentAnswers() As Integer
    Private correctAnswers() As Integer
    Private resultsAssesment() As String
    Private setColorTime As Boolean
    Private showValidationMessage As Boolean

#End Region

#Region "Métodos y eventos para controlar el funcionamiento de la evaluación"

    ' Método principal del formulario, JSCG, UNAD, 20190518
    Private Sub FormLevel1Assessment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        minutes = MAX_MINUTES
        seconds = MAX_SECONDS
        studentAnswers = New Integer(9) {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        correctAnswers = New Integer(9) {3, 2, 1, 2, 4, 3, 1, 2, 3, 1}
        resultsAssesment = New String(9) {"Sin responder", "Sin responder", "Sin responder", "Sin responder", "Sin responder", "Sin responder", "Sin responder", "Sin responder", "Sin responder", "Sin responder"}
        setColorTime = True
        showValidationMessage = True
        SetTimeLabelTimer()
        TimerFormLevel1Assessment.Start()
    End Sub

    ' Evento ejecutado cada segundo, por el timer TimerFormLevel1Assessment, JSCG, UNAD, 20190518
    Private Sub TimerFormLevel1Assessment_Tick(sender As Object, e As EventArgs) Handles TimerFormLevel1Assessment.Tick
        seconds -= 1
        SetTimeLabelTimer()
        If (seconds = 0) And (minutes > 0) Then
            minutes -= 1
            seconds = MAX_SECONDS
        End If
        If minutes <= 0 And setColorTime Then
            LabelTimer.ForeColor = Color.Red
            setColorTime = False
        End If
        If minutes = 0 And seconds = 0 Then
            TimerFormLevel1Assessment.Stop()
            MessageBox.Show("Fin por tiempo", "El tiempo para realizar la evaluación se ha terminado.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            showValidationMessage = False
            Close()
            FormMenu.Show()
        End If
    End Sub

    ' Asignación del texto, que es mostrado al estudiante, para que este puede ver el tiempo restante, JSCG, UNAD, 20190518
    Private Sub SetTimeLabelTimer()
        LabelTimer.Text = String.Format("0" + minutes.ToString() + ":" + If(seconds < MIN_FORMAT_SECONDS, "0" + seconds.ToString(), seconds.ToString()))
    End Sub

    ' Permite asignar el valor de cada respuesta seleccionada por el estudiante, JSCG, UNAD, 20190518
    Private Sub SetAnswer(position As Integer, value As Integer)
        studentAnswers(position) = value
    End Sub

    ' Evento de pre-cierre del formulario, JSCG, UNAD, 20190518
    Private Sub FormLevel1Assessment_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If showValidationMessage Then
            Dim selection As DialogResult
            selection = MessageBox.Show("¿Está seguro?, esto cancelara el intento.", "Confirmar salir evaluación primer nivel", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If selection = vbYes Then
                FormMenu.Show()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    ' Botón de salida manual, del estudiante, JSCG, UNAD, 20190518
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Close()
    End Sub

    ' Boton finalizar evaluación y continuar, JSCG, UNAD, 20190518
    Private Sub ButtonCompleteEvaluation_Click(sender As Object, e As EventArgs) Handles ButtonCompleteEvaluation.Click
        Dim selection As DialogResult
        selection = MessageBox.Show("¿Está seguro?, esto finaliza el intento.", "Confirmar finalizar intento", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If selection = vbYes Then
            Dim notAnswer = studentAnswers.Where(Function(condition) condition = 0).Count
            If notAnswer >= 1 Then
                Dim validationAnswer As DialogResult
                validationAnswer = MessageBox.Show("Existen preguntas sin responder, ¿Desea continuar?", "Preguntas sin responder", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If validationAnswer = vbYes Then
                    ProcessAnswers()
                End If
            Else
                ProcessAnswers()
            End If
        End If
    End Sub

    ' Permite procesar las respuestas digitadas por el estudiante, JSCG, UNAD, 20190518
    Private Sub ProcessAnswers()
        TimerFormLevel1Assessment.Stop()
        Dim countCorrectAnswers As Integer = 0
        For i As Integer = 0 To studentAnswers.Length - 1
            Dim showResultAnswer = i + 1
            If studentAnswers(i) = correctAnswers(i) Then
                countCorrectAnswers += 1
                resultsAssesment(i) = String.Format("Respuesta correcta para la pregunta: " + showResultAnswer.ToString() + ", opción seleccionada: " + correctAnswers(i).ToString() + " felicidades")
            Else
                resultsAssesment(i) = String.Format("Respuesta incorrecta para la pregunta: " + showResultAnswer.ToString() + ", respuesta correcta opción: " + correctAnswers(i).ToString())
            End If
        Next
        showValidationMessage = False
        Hide()
        Close()
        Dim formShowResults = New FormShowResults(resultsAssesment, countCorrectAnswers, FORM_IDEN)
        formShowResults.ShowDialog()
    End Sub

#End Region

#Region "Asignación respuestas por parte del estudiante"

    Private Sub RadioButtonOptionAFirstQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionAFirstQuestion.Click
        SetAnswer(0, 1)
    End Sub

    Private Sub RadioButtonOptionBFirstQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionBFirstQuestion.Click
        SetAnswer(0, 2)
    End Sub

    Private Sub RadioButtonOptionCFirstQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionCFirstQuestion.Click
        SetAnswer(0, 3)
    End Sub

    Private Sub RadioButtonOptionDFirstQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionDFirstQuestion.Click
        SetAnswer(0, 4)
    End Sub

    Private Sub RadioButtonOptionASecondQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionASecondQuestion.Click
        SetAnswer(1, 1)
    End Sub

    Private Sub RadioButtonOptionBSecondQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionBSecondQuestion.Click
        SetAnswer(1, 2)
    End Sub

    Private Sub RadioButtonOptionCSecondQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionCSecondQuestion.Click
        SetAnswer(1, 3)
    End Sub

    Private Sub RadioButtonOptionDSecondQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionDSecondQuestion.Click
        SetAnswer(1, 4)
    End Sub

    Private Sub RadioButtonOptionAThirdQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionAThirdQuestion.Click
        SetAnswer(2, 1)
    End Sub

    Private Sub RadioButtonOptionBThirdQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionBThirdQuestion.Click
        SetAnswer(2, 2)
    End Sub

    Private Sub RadioButtonOptionCThirdQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionCThirdQuestion.Click
        SetAnswer(2, 3)
    End Sub

    Private Sub RadioButtonOptionDThirdQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionDThirdQuestion.Click
        SetAnswer(2, 4)
    End Sub

    Private Sub RadioButtonOptionAFourthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionAFourthQuestion.Click
        SetAnswer(3, 1)
    End Sub

    Private Sub RadioButtonOptionBFourthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionBFourthQuestion.Click
        SetAnswer(3, 2)
    End Sub

    Private Sub RadioButtonOptionCFourthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionCFourthQuestion.Click
        SetAnswer(3, 3)
    End Sub

    Private Sub RadioButtonOptionDFourthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionDFourthQuestion.Click
        SetAnswer(3, 4)
    End Sub

    Private Sub RadioButtonOptionAFifthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionAFifthQuestion.Click
        SetAnswer(4, 1)
    End Sub

    Private Sub RadioButtonOptionBFifthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionBFifthQuestion.Click
        SetAnswer(4, 2)
    End Sub

    Private Sub RadioButtonOptionCFifthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionCFifthQuestion.Click
        SetAnswer(4, 3)
    End Sub

    Private Sub RadioButtonOptionDFifthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionDFifthQuestion.Click
        SetAnswer(4, 4)
    End Sub

    Private Sub RadioButtonOptionASixthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionASixthQuestion.Click
        SetAnswer(5, 1)
    End Sub

    Private Sub RadioButtonOptionBSixthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionBSixthQuestion.Click
        SetAnswer(5, 2)
    End Sub

    Private Sub RadioButtonOptionCSixthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionCSixthQuestion.Click
        SetAnswer(5, 3)
    End Sub

    Private Sub RadioButtonOptionDSixthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionDSixthQuestion.Click
        SetAnswer(5, 4)
    End Sub

    Private Sub RadioButtonOptionASeventhQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionASeventhQuestion.Click
        SetAnswer(6, 1)
    End Sub

    Private Sub RadioButtonOptionBSeventhQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionBSeventhQuestion.Click
        SetAnswer(6, 2)
    End Sub

    Private Sub RadioButtonOptionCSeventhQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionCSeventhQuestion.Click
        SetAnswer(6, 3)
    End Sub

    Private Sub RadioButtonOptionDSeventhQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionDSeventhQuestion.Click
        SetAnswer(6, 4)
    End Sub

    Private Sub RadioButtonOptionAEighthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionANinthQuestion.Click
        SetAnswer(7, 1)
    End Sub

    Private Sub RadioButtonOptionBEighthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionBNinthQuestion.Click
        SetAnswer(7, 2)
    End Sub

    Private Sub RadioButtonOptionCEighthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionCNinthQuestion.Click
        SetAnswer(7, 3)
    End Sub

    Private Sub RadioButtonOptionDEighthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionDNinthQuestion.Click
        SetAnswer(7, 4)
    End Sub

    Private Sub RadioButtonOptionANinthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionAEighthQuestion.Click
        SetAnswer(8, 1)
    End Sub

    Private Sub RadioButtonOptionBNinthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionBEighthQuestion.Click
        SetAnswer(8, 2)
    End Sub

    Private Sub RadioButtonOptionCNinthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionCEighthQuestion.Click
        SetAnswer(8, 3)
    End Sub

    Private Sub RadioButtonOptionDNinthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionDEighthQuestion.Click
        SetAnswer(8, 4)
    End Sub

    Private Sub RadioButtonOptionATenthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionATenthQuestion.Click
        SetAnswer(9, 1)
    End Sub

    Private Sub RadioButtonOptionBTenthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionBTenthQuestion.Click
        SetAnswer(9, 2)
    End Sub

    Private Sub RadioButtonOptionCTenthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionCTenthQuestion.Click
        SetAnswer(9, 3)
    End Sub

    Private Sub RadioButtonOptionDTenthQuestion_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOptionDTenthQuestion.Click
        SetAnswer(9, 4)
    End Sub

#End Region

End Class