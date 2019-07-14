Public Class FormDataMiningPDFReader

#Region "Métodos y eventos para controlar el formulario de PDF"

    Private Sub FormDataMiningPDFReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Al iniciar el formulario, solicitar el PDF a mostrar, JSCG, UNAD, 20190629
        Dim openFileDialog As OpenFileDialog = New OpenFileDialog
        With openFileDialog
            ' Solo permitir archivos PDF, JSCG, UNAD, 20190629
            .Filter = "PDF Files(*.pdf)|*.pdf"
            .Title = "Busque su archivo PDF"
        End With
        Dim result As DialogResult = openFileDialog.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            ' Si la busqueda es positiva, es decir el usuario encontro un archivo PDF, mostrar este en un navegador WEB embebido, JSCG, UNAD, 20190629
            WebBrowserDataMiningPDFReader.Navigate(openFileDialog.FileName)
            WindowState = FormWindowState.Maximized
        Else
            ' La busqueda fue incorrecta o el usuario la cancelo, por ende, cerrar el formulario, JSCG, UNAD, 20190629
            Close()
        End If
    End Sub

    Private Sub FormDataMiningPDFReader_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Cerrar el formulario, JSCG, UNAD, 20190629
        Hide()
        FormMenu.Show()
    End Sub

#End Region

End Class