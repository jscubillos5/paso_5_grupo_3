Public Class FormMenu

#Region "Funcionalidades del ménu principal"


    Public Sub New(ByVal activeOptions As Boolean)
        InitializeComponent()
        DataMiningToolStripMenuItem.Enabled = activeOptions
        EvaluationStep2ToolStripMenuItem.Enabled = activeOptions
    End Sub

    Private Sub RegisterStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterStudentsToolStripMenuItem.Click
        Hide()
        ' Dar acceso al formulario seleciconado, JSCG, UNAD, 20190601
        Dim formRegisterStudent = New FormRegisterStudent
        formRegisterStudent.ShowDialog()
    End Sub

    Private Sub FormMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub ModifyStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyStudentsToolStripMenuItem.Click
        Hide()
        Dim formModifyStudent = New FormModifyStudent
        ' Mostrar el formulario seleciconado, JSCG, UNAD, 20190601
        formModifyStudent.ShowDialog()
    End Sub

    Private Sub DeleteStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteStudentsToolStripMenuItem.Click
        ' Ocultar el formulario actual, JSCG, UNAD, 20190601
        Hide()
        Dim formDeleteStudent = New FormDeleteStudent
        formDeleteStudent.ShowDialog()
    End Sub

    Private Sub SearchStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchStudentsToolStripMenuItem.Click
        Hide()
        Dim formSearchStudent = New FormSearchStudent
        formSearchStudent.ShowDialog()
    End Sub

    Private Sub DataMiningPDFReaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMiningPDFReaderToolStripMenuItem.Click
        Hide()
        Dim formDataMiningPDFReader = New FormDataMiningPDFReader
        formDataMiningPDFReader.ShowDialog()
    End Sub

    Private Sub DataMiningImagesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMiningImagesToolStripMenuItem.Click
        Hide()
        Dim formDataMiningImages = New FormDataMiningImages
        formDataMiningImages.ShowDialog()
    End Sub

    Private Sub DataMiningAudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMiningAudioToolStripMenuItem.Click
        Hide()
        Dim formDataMiningAudio = New FormDataMiningAudio
        formDataMiningAudio.ShowDialog()
    End Sub

    Private Sub DataMiningVideoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMiningVideoToolStripMenuItem.Click
        Hide()
        Dim formDataMiningVideo = New FormDataMiningVideo
        formDataMiningVideo.ShowDialog()
    End Sub

    Private Sub EvaluationStep2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EvaluationStep2ToolStripMenuItem.Click
        Dim selection As DialogResult
        selection = MessageBox.Show("Buen día respetado estudiante." + vbCr + vbCr + "Al iniciar el examen solo contara con 3 minutos, por cada nivel." + "¿Desea continuar?", "Confirmar inicio evaluación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If selection = vbYes Then
            Me.Hide()
            Dim formLevel1Assessment = New FormLevel1Assessment
            formLevel1Assessment.ShowDialog()
        Else
            MessageBox.Show("Usted ha cancelado el inicio de la evaluación.")
        End If
    End Sub

#End Region

End Class