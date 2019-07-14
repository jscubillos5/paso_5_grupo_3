Public Class FormShowResults

#Region "Declaración de variables y constantes Globales al formulario"

    Private ReadOnly totalCorrectAnswersEstudent As Integer
    Private Const MIN_CORRECT_ANSWERS_NEXT_LEVEL = 6
    Private Const MAX_NUM_QUESTIONS = 10
    Private Const MESSAGE_SUCCESS_LEVEL_1 = "Respetado estudiante, usted ha superado el primer nivel, por ende, sera enviado al segundo."
    Private Const MESSAGE_FAILURE_LEVEL_1 = "Respetado estudiante, usted no ha superado el primer nivel."
    Private Const MESSAGE_SUCCESS_LEVEL_2 = "Respetado estudiante, usted ha superado el segundo nivel, felicitaciones ha finalizado."
    Private Const MESSAGE_FAILURE_LEVEL_2 = "Respetado estudiante, usted no ha superado el segundo nivel."
    Private Const IDENT_FORM_LEVEL_1 = 1
    Private formIdentificationReceived As UInteger

    Public Property FormIdentificationReceived1 As UInteger
        Get
            Return formIdentificationReceived
        End Get
        Set(value As UInteger)
            formIdentificationReceived = value
        End Set
    End Property

#End Region

#Region "Métodos y eventos para controlar el funcionamiento de la pantalla de resultados"

    ' Método, que permite recibir variables; desde otros formularios, JSCG, UNAD, 20190521
    Public Sub New(ByVal resultsAssesment As String(), ByVal totalCorrectAnswers As Integer, ByVal formIdentification As UInteger)
        InitializeComponent()
        totalCorrectAnswersEstudent = totalCorrectAnswers
        FormIdentificationReceived1 = formIdentification
        DataGridViewResults.Rows.Clear()
        For resultAnswer As Integer = 0 To resultsAssesment.Length - 1
            DataGridViewResults.Rows.Add(resultsAssesment(resultAnswer))
        Next
        If totalCorrectAnswersEstudent >= MIN_CORRECT_ANSWERS_NEXT_LEVEL Then
            If FormIdentificationReceived1 = IDENT_FORM_LEVEL_1 Then
                LabelResult.Text = MESSAGE_SUCCESS_LEVEL_1
            Else
                LabelResult.Text = MESSAGE_SUCCESS_LEVEL_2
            End If
            LabelResult.ForeColor = Color.Green
            LabelPercentResult.ForeColor = Color.Green
        Else
            If FormIdentificationReceived1 = IDENT_FORM_LEVEL_1 Then
                LabelResult.Text = MESSAGE_FAILURE_LEVEL_1
            Else
                LabelResult.Text = MESSAGE_FAILURE_LEVEL_2
            End If
            LabelResult.ForeColor = Color.Red
            LabelPercentResult.ForeColor = Color.Red
        End If
        LabelPercentResult.Text = String.Format("Estimado estudiante de: {0} preguntas usted acerto {1}, su total es: {2}%", MAX_NUM_QUESTIONS, totalCorrectAnswers, totalCorrectAnswers / MAX_NUM_QUESTIONS * 100)
    End Sub

    ' Evento, de pre-cierre del formulario, JSCG, UNAD, 20190521
    Private Sub FormShowResults_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If totalCorrectAnswersEstudent >= MIN_CORRECT_ANSWERS_NEXT_LEVEL And FormIdentificationReceived1 = IDENT_FORM_LEVEL_1 Then
            Dim selection As DialogResult
            selection = MessageBox.Show(MESSAGE_SUCCESS_LEVEL_1 + vbCr + vbCr + "Al iniciar el examen solo contara con 3 minutos, por cada nivel." + "¿Desea continuar?", "Confirmar inicio evaluación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If selection = vbYes Then
                Hide()
                Dim formLevel2Assessment = New FormLevel2Assessment
                formLevel2Assessment.ShowDialog()
            Else
                MessageBox.Show("Usted ha cancelado el inicio de la evaluación.")
                e.Cancel = True
            End If
        Else
            Dim formMenu = New FormMenu(True)
            formMenu.Show()
        End If
    End Sub

    ' Boton, continuar, se envia al método close(), ya que este contiene la validación del segundo examen, JSCG, UNAD, 20190521
    Private Sub ButtonValidate_Click(sender As Object, e As EventArgs) Handles ButtonValidate.Click
        Close()
    End Sub

#End Region

End Class