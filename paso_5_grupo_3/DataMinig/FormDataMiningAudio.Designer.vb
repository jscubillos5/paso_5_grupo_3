<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataMiningAudio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataMiningAudio))
        Me.AxWindowsMediaPlayerFormDataMiningAudio = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.AxWindowsMediaPlayerFormDataMiningAudio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayerFormDataMiningAudio
        '
        Me.AxWindowsMediaPlayerFormDataMiningAudio.Enabled = True
        Me.AxWindowsMediaPlayerFormDataMiningAudio.Location = New System.Drawing.Point(12, 20)
        Me.AxWindowsMediaPlayerFormDataMiningAudio.Name = "AxWindowsMediaPlayerFormDataMiningAudio"
        Me.AxWindowsMediaPlayerFormDataMiningAudio.OcxState = CType(resources.GetObject("AxWindowsMediaPlayerFormDataMiningAudio.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayerFormDataMiningAudio.Size = New System.Drawing.Size(753, 44)
        Me.AxWindowsMediaPlayerFormDataMiningAudio.TabIndex = 0
        '
        'FormDataMiningAudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 111)
        Me.Controls.Add(Me.AxWindowsMediaPlayerFormDataMiningAudio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1057, 158)
        Me.MinimumSize = New System.Drawing.Size(1057, 158)
        Me.Name = "FormDataMiningAudio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Audio"
        CType(Me.AxWindowsMediaPlayerFormDataMiningAudio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AxWindowsMediaPlayerFormDataMiningAudio As AxWMPLib.AxWindowsMediaPlayer
End Class
