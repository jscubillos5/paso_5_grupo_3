<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDataMiningPDFReader
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataMiningPDFReader))
        Me.WebBrowserDataMiningPDFReader = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'WebBrowserDataMiningPDFReader
        '
        Me.WebBrowserDataMiningPDFReader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowserDataMiningPDFReader.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowserDataMiningPDFReader.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserDataMiningPDFReader.Name = "WebBrowserDataMiningPDFReader"
        Me.WebBrowserDataMiningPDFReader.Size = New System.Drawing.Size(800, 450)
        Me.WebBrowserDataMiningPDFReader.TabIndex = 0
        '
        'FormDataMiningPDFReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.WebBrowserDataMiningPDFReader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDataMiningPDFReader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lector PDF"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowserDataMiningPDFReader As WebBrowser
End Class
