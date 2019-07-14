<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataMiningVideo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataMiningVideo))
        Me.AxWindowsMediaPlayerFormDataMiningVideo = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.AxWindowsMediaPlayerFormDataMiningVideo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayerFormDataMiningVideo
        '
        Me.AxWindowsMediaPlayerFormDataMiningVideo.Enabled = True
        Me.AxWindowsMediaPlayerFormDataMiningVideo.Location = New System.Drawing.Point(12, 23)
        Me.AxWindowsMediaPlayerFormDataMiningVideo.Name = "AxWindowsMediaPlayerFormDataMiningVideo"
        Me.AxWindowsMediaPlayerFormDataMiningVideo.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerFormDataMiningVideo.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerFormDataMiningVideo.Size = New System.Drawing.Size(776, 415)
        Me.AxWindowsMediaPlayerFormDataMiningVideo.TabIndex = 0
        '
        'FormDataMiningVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 556)
        Me.Controls.Add(Me.AxWindowsMediaPlayerFormDataMiningVideo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1079, 603)
        Me.MinimumSize = New System.Drawing.Size(1079, 603)
        Me.Name = "FormDataMiningVideo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vídeo"
        CType(Me.AxWindowsMediaPlayerFormDataMiningVideo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxWindowsMediaPlayerFormDataMiningVideo As AxWMPLib.AxWindowsMediaPlayer
End Class
