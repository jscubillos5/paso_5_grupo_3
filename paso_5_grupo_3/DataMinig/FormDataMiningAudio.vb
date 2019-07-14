Public Class FormDataMiningAudio

#Region "Métodos y eventos para controlar el formulario de Audio"

    Private Sub FormDataMiningAudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Al iniciar el formulario, solicitar el audio a reproducir, JSCG, UNAD, 20190629
        Dim openFileDialog As OpenFileDialog = New OpenFileDialog
        With openFileDialog
            ' Solo permitir archivos de audio MP3, JSCG, UNAD, 20190629
            .Filter = "Music (.mp3)|*.mp3"
            .Title = "Busque su archivo de Audio MP3"
        End With
        Dim result As DialogResult = openFileDialog.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            ' Si la busqueda es positiva, es decir el usuario encontro un archivo MP3, reproducir este en el reproductor de Windows Media, JSCG, UNAD, 20190629
            AxWindowsMediaPlayerFormDataMiningAudio.URL = openFileDialog.FileName
        Else
            ' La busqueda fue incorrecta o el usuario la cancelo, por ende, cerrar el formulario, JSCG, UNAD, 20190629
            Close()
        End If
    End Sub

    Private Sub FormDataMiningAudio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Si hay algun contenido, que se esta reproduciendo detenerlo, JSCG, UNAD, 20190629
        AxWindowsMediaPlayerFormDataMiningAudio.Ctlcontrols.stop()
        ' Cerrar el formulario, JSCG, UNAD, 20190629
        Hide()
        Dim formMenu = New FormMenu(True)
        formMenu.Show()
    End Sub

#End Region

End Class