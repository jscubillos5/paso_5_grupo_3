<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataMiningImages
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataMiningImages))
        Me.ImageListFormDataMiningImages = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelButtons = New System.Windows.Forms.Panel()
        Me.PanelImage = New System.Windows.Forms.Panel()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.PictureBoxDataMinig = New System.Windows.Forms.PictureBox()
        Me.TimerDataMiningImages = New System.Windows.Forms.Timer(Me.components)
        Me.PanelButtons.SuspendLayout()
        Me.PanelImage.SuspendLayout()
        CType(Me.PictureBoxDataMinig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageListFormDataMiningImages
        '
        Me.ImageListFormDataMiningImages.ImageStream = CType(resources.GetObject("ImageListFormDataMiningImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListFormDataMiningImages.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListFormDataMiningImages.Images.SetKeyName(0, "1_DATA_MINING.png")
        Me.ImageListFormDataMiningImages.Images.SetKeyName(1, "2_DATA_MINING.png")
        Me.ImageListFormDataMiningImages.Images.SetKeyName(2, "3_DATA_MINING.jpg")
        Me.ImageListFormDataMiningImages.Images.SetKeyName(3, "4_DATA_MINING.jpg")
        Me.ImageListFormDataMiningImages.Images.SetKeyName(4, "5_DATA_MINING.jpg")
        '
        'PanelButtons
        '
        Me.PanelButtons.Controls.Add(Me.ButtonStop)
        Me.PanelButtons.Controls.Add(Me.ButtonStart)
        Me.PanelButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelButtons.Location = New System.Drawing.Point(0, 0)
        Me.PanelButtons.Name = "PanelButtons"
        Me.PanelButtons.Size = New System.Drawing.Size(477, 50)
        Me.PanelButtons.TabIndex = 0
        '
        'PanelImage
        '
        Me.PanelImage.Controls.Add(Me.PictureBoxDataMinig)
        Me.PanelImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelImage.Location = New System.Drawing.Point(0, 50)
        Me.PanelImage.Name = "PanelImage"
        Me.PanelImage.Size = New System.Drawing.Size(477, 408)
        Me.PanelImage.TabIndex = 1
        '
        'ButtonStart
        '
        Me.ButtonStart.Location = New System.Drawing.Point(12, 12)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(146, 32)
        Me.ButtonStart.TabIndex = 0
        Me.ButtonStart.Text = "Mostrar imágenes"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ButtonStop
        '
        Me.ButtonStop.Enabled = False
        Me.ButtonStop.Location = New System.Drawing.Point(180, 12)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(108, 32)
        Me.ButtonStop.TabIndex = 1
        Me.ButtonStop.Text = "Detener"
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'PictureBoxDataMinig
        '
        Me.PictureBoxDataMinig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxDataMinig.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxDataMinig.Name = "PictureBoxDataMinig"
        Me.PictureBoxDataMinig.Size = New System.Drawing.Size(477, 408)
        Me.PictureBoxDataMinig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxDataMinig.TabIndex = 0
        Me.PictureBoxDataMinig.TabStop = False
        '
        'TimerDataMiningImages
        '
        Me.TimerDataMiningImages.Interval = 1000
        '
        'FormDataMiningImages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 458)
        Me.Controls.Add(Me.PanelImage)
        Me.Controls.Add(Me.PanelButtons)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(495, 505)
        Me.MinimumSize = New System.Drawing.Size(495, 505)
        Me.Name = "FormDataMiningImages"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imágenes"
        Me.PanelButtons.ResumeLayout(False)
        Me.PanelImage.ResumeLayout(False)
        CType(Me.PictureBoxDataMinig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageListFormDataMiningImages As ImageList
    Friend WithEvents PanelButtons As Panel
    Friend WithEvents PanelImage As Panel
    Friend WithEvents ButtonStart As Button
    Friend WithEvents ButtonStop As Button
    Friend WithEvents PictureBoxDataMinig As PictureBox
    Friend WithEvents TimerDataMiningImages As Timer
End Class
