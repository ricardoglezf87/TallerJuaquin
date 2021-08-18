<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compras))
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cGuardar = New System.Windows.Forms.ToolStripButton
        Me.RycCheckBox1 = New RYCCheckBox.RYCCheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.RycCheckBox2 = New RYCCheckBox.RYCCheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.RycCheckBox3 = New RYCCheckBox.RYCCheckBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.CheckBox1 = New RYCCheckBox.RYCCheckBox
        Me.cDesde = New System.Windows.Forms.DateTimePicker
        Me.cTrabajo = New System.Windows.Forms.DataGridView
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cTrabajo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Concep.: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Exacta:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(79, 110)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 23)
        Me.TextBox1.TabIndex = 4
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cGuardar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(955, 55)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cGuardar
        '
        Me.cGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cGuardar.Image = Global.TallerJoaquin.My.Resources.Resources._1271966377_document_save_as
        Me.cGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cGuardar.Name = "cGuardar"
        Me.cGuardar.Size = New System.Drawing.Size(52, 52)
        Me.cGuardar.Text = "Guardar Cambios"
        '
        'RycCheckBox1
        '
        Me.RycCheckBox1.ColorMarcado = System.Drawing.Color.Blue
        Me.RycCheckBox1.Location = New System.Drawing.Point(196, 27)
        Me.RycCheckBox1.Marcado = False
        Me.RycCheckBox1.Name = "RycCheckBox1"
        Me.RycCheckBox1.Size = New System.Drawing.Size(23, 20)
        Me.RycCheckBox1.TabIndex = 1
        Me.RycCheckBox1.TipoMarcado = RYCCheckBox.RYCCheckBox.eTipoMarcado.Tick
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasta:"
        '
        'RycCheckBox2
        '
        Me.RycCheckBox2.ColorMarcado = System.Drawing.Color.Blue
        Me.RycCheckBox2.Location = New System.Drawing.Point(196, 84)
        Me.RycCheckBox2.Marcado = False
        Me.RycCheckBox2.Name = "RycCheckBox2"
        Me.RycCheckBox2.Size = New System.Drawing.Size(23, 20)
        Me.RycCheckBox2.TabIndex = 1
        Me.RycCheckBox2.TipoMarcado = RYCCheckBox.RYCCheckBox.eTipoMarcado.Tick
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.RycCheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RycCheckBox3)
        Me.GroupBox1.Controls.Add(Me.RycCheckBox2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.cDesde)
        Me.GroupBox1.Location = New System.Drawing.Point(703, 50)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(239, 316)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrado"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(66, 136)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(124, 23)
        Me.NumericUpDown1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Precio: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde:"
        '
        'RycCheckBox3
        '
        Me.RycCheckBox3.ColorMarcado = System.Drawing.Color.Blue
        Me.RycCheckBox3.Location = New System.Drawing.Point(196, 136)
        Me.RycCheckBox3.Marcado = False
        Me.RycCheckBox3.Name = "RycCheckBox3"
        Me.RycCheckBox3.Size = New System.Drawing.Size(23, 20)
        Me.RycCheckBox3.TabIndex = 1
        Me.RycCheckBox3.TipoMarcado = RYCCheckBox.RYCCheckBox.eTipoMarcado.Tick
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(66, 27)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(125, 23)
        Me.DateTimePicker1.TabIndex = 0
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(66, 84)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(125, 23)
        Me.DateTimePicker2.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.ColorMarcado = System.Drawing.Color.Blue
        Me.CheckBox1.Location = New System.Drawing.Point(196, 54)
        Me.CheckBox1.Marcado = False
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(23, 20)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.TipoMarcado = RYCCheckBox.RYCCheckBox.eTipoMarcado.Tick
        '
        'cDesde
        '
        Me.cDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cDesde.Location = New System.Drawing.Point(66, 54)
        Me.cDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.cDesde.Name = "cDesde"
        Me.cDesde.Size = New System.Drawing.Size(125, 23)
        Me.cDesde.TabIndex = 0
        '
        'cTrabajo
        '
        Me.cTrabajo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.cTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cTrabajo.Location = New System.Drawing.Point(12, 50)
        Me.cTrabajo.Margin = New System.Windows.Forms.Padding(4)
        Me.cTrabajo.Name = "cTrabajo"
        Me.cTrabajo.Size = New System.Drawing.Size(684, 316)
        Me.cTrabajo.TabIndex = 5
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 366)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cTrabajo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Compras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Compras"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cTrabajo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents RycCheckBox1 As RYCCheckBox.RYCCheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RycCheckBox2 As RYCCheckBox.RYCCheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox1 As RYCCheckBox.RYCCheckBox
    Friend WithEvents cDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents cTrabajo As System.Windows.Forms.DataGridView
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RycCheckBox3 As RYCCheckBox.RYCCheckBox
End Class
