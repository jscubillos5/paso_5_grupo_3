Public Class FormDataMiningImages

#Region "Variables privadas del formulario de Imagenes"

    Private i As Integer

#End Region

#Region "Métodos y eventos para controlar el formulario de Imagenes"

    Private Sub FormDataMiningImages_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Detener el TIMER del formulario, JSCG, UNAD, 20190629
        TimerDataMiningImages.Stop()
        Hide()
        ' Cerrar el formulario, JSCG, UNAD, 20190629
        FormMenu.Show()
    End Sub

    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        ' Iniciar el TIMER del formulario, JSCG, UNAD, 20190629
        TimerDataMiningImages.Start()
        ' Al pulsar el boton de inicio, deshabiitar el mismo y habilitar el de detener, JSCG, UNAD, 20190629
        ButtonStart.Enabled = False
        ButtonStop.Enabled = True
    End Sub

    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        ' Detener el TIMER del formulario, JSCG, UNAD, 20190629
        TimerDataMiningImages.Stop()
        ' Al pulsar el boton de detención, deshabiitar el mismo y habilitar el de iniciar, JSCG, UNAD, 20190629
        ButtonStart.Enabled = True
        ButtonStop.Enabled = False
    End Sub

    Private Sub FormDataMiningImages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializar la variable que recorre el ImageList, siempre al abrir el formulario en cero, JSCG, UNAD, 20190629
        i = 0
    End Sub

    Private Sub TimerDataMiningImages_Tick(sender As Object, e As EventArgs) Handles TimerDataMiningImages.Tick
        ' Al ejecutar el evento de conteo, cada segundo, recorrer el ImageList, JSCG, UNAD, 20190629 
        ' Cargar en el PictureBox la imagen correspondiente en el ImageList, JSCG, UNAD, 20190629
        PictureBoxDataMinig.Image = ImageListFormDataMiningImages.Images(i)
        If i < ImageListFormDataMiningImages.Images.Count - 1 Then
            ' Aumentar en uno la variable que recorre el ImageList, JSCG, UNAD, 20190629
            i += 1
        Else
            ' La variable que recorre el ImageList, llego al valor maximo del ImageList, vovler al punto de arranque orinal
            i = 0
        End If
    End Sub

#End Region

End Class