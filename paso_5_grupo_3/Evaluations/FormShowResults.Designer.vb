<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormShowResults
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormShowResults))
        Me.PanelResults = New System.Windows.Forms.Panel()
        Me.DataGridViewResults = New System.Windows.Forms.DataGridView()
        Me.ColumnResultAnswerQuestion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelOptions = New System.Windows.Forms.Panel()
        Me.LabelPercentResult = New System.Windows.Forms.Label()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.ButtonValidate = New System.Windows.Forms.Button()
        Me.PanelResults.SuspendLayout()
        CType(Me.DataGridViewResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelResults
        '
        Me.PanelResults.Controls.Add(Me.DataGridViewResults)
        Me.PanelResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelResults.Location = New System.Drawing.Point(0, 0)
        Me.PanelResults.Name = "PanelResults"
        Me.PanelResults.Size = New System.Drawing.Size(755, 369)
        Me.PanelResults.TabIndex = 0
        '
        'DataGridViewResults
        '
        Me.DataGridViewResults.AllowUserToAddRows = False
        Me.DataGridViewResults.AllowUserToDeleteRows = False
        Me.DataGridViewResults.AllowUserToOrderColumns = True
        Me.DataGridViewResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnResultAnswerQuestion})
        Me.DataGridViewResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewResults.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewResults.Name = "DataGridViewResults"
        Me.DataGridViewResults.ReadOnly = True
        Me.DataGridViewResults.RowTemplate.Height = 24
        Me.DataGridViewResults.Size = New System.Drawing.Size(755, 369)
        Me.DataGridViewResults.TabIndex = 0
        '
        'ColumnResultAnswerQuestion
        '
        Me.ColumnResultAnswerQuestion.HeaderText = "Resultados"
        Me.ColumnResultAnswerQuestion.Name = "ColumnResultAnswerQuestion"
        Me.ColumnResultAnswerQuestion.ReadOnly = True
        '
        'PanelOptions
        '
        Me.PanelOptions.Controls.Add(Me.LabelPercentResult)
        Me.PanelOptions.Controls.Add(Me.LabelResult)
        Me.PanelOptions.Controls.Add(Me.ButtonValidate)
        Me.PanelOptions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelOptions.Location = New System.Drawing.Point(0, 369)
        Me.PanelOptions.Name = "PanelOptions"
        Me.PanelOptions.Size = New System.Drawing.Size(755, 157)
        Me.PanelOptions.TabIndex = 1
        '
        'LabelPercentResult
        '
        Me.LabelPercentResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelPercentResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPercentResult.Location = New System.Drawing.Point(7, 70)
        Me.LabelPercentResult.Name = "LabelPercentResult"
        Me.LabelPercentResult.Size = New System.Drawing.Size(740, 17)
        Me.LabelPercentResult.TabIndex = 2
        Me.LabelPercentResult.Text = "Estimado estudiante de: 00 preguntas usted acerto 00, su total es: 000%"
        Me.LabelPercentResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelResult
        '
        Me.LabelResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelResult.Location = New System.Drawing.Point(7, 24)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(740, 17)
        Me.LabelResult.TabIndex = 1
        Me.LabelResult.Text = "Resultado"
        Me.LabelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonValidate
        '
        Me.ButtonValidate.Location = New System.Drawing.Point(330, 122)
        Me.ButtonValidate.Name = "ButtonValidate"
        Me.ButtonValidate.Size = New System.Drawing.Size(95, 23)
        Me.ButtonValidate.TabIndex = 0
        Me.ButtonValidate.Text = "Continuar"
        Me.ButtonValidate.UseVisualStyleBackColor = True
        '
        'FormShowResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 526)
        Me.Controls.Add(Me.PanelResults)
        Me.Controls.Add(Me.PanelOptions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormShowResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver resultados"
        Me.PanelResults.ResumeLayout(False)
        CType(Me.DataGridViewResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelResults As Panel
    Friend WithEvents PanelOptions As Panel
    Friend WithEvents DataGridViewResults As DataGridView
    Friend WithEvents ButtonValidate As Button
    Friend WithEvents ColumnResultAnswerQuestion As DataGridViewTextBoxColumn
    Friend WithEvents LabelResult As Label
    Friend WithEvents LabelPercentResult As Label
End Class
