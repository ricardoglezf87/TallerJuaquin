<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MakeBackup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MakeBackup))
        Me.Buscar = New System.Windows.Forms.Button
        Me.Ruta = New System.Windows.Forms.TextBox
        Me.Make = New System.Windows.Forms.Button
        Me.Progreso = New System.Windows.Forms.ProgressBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(905, 76)
        Me.Buscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(46, 31)
        Me.Buscar.TabIndex = 0
        Me.Buscar.Text = "..."
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Ruta
        '
        Me.Ruta.Location = New System.Drawing.Point(18, 78)
        Me.Ruta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ruta.Name = "Ruta"
        Me.Ruta.Size = New System.Drawing.Size(879, 26)
        Me.Ruta.TabIndex = 1
        '
        'Make
        '
        Me.Make.Location = New System.Drawing.Point(426, 132)
        Me.Make.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Make.Name = "Make"
        Me.Make.Size = New System.Drawing.Size(112, 75)
        Me.Make.TabIndex = 0
        Me.Make.Text = "Crear Copia de Seguridad"
        Me.Make.UseVisualStyleBackColor = True
        '
        'Progreso
        '
        Me.Progreso.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Progreso.Location = New System.Drawing.Point(0, 237)
        Me.Progreso.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Progreso.Name = "Progreso"
        Me.Progreso.Size = New System.Drawing.Size(964, 35)
        Me.Progreso.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ruta de la Copia de Seguridad"
        '
        'MakeBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 272)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Progreso)
        Me.Controls.Add(Me.Make)
        Me.Controls.Add(Me.Ruta)
        Me.Controls.Add(Me.Buscar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MakeBackup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Copia de Seguridad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Buscar As System.Windows.Forms.Button
    Friend WithEvents Ruta As System.Windows.Forms.TextBox
    Friend WithEvents Make As System.Windows.Forms.Button
    Friend WithEvents Progreso As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
