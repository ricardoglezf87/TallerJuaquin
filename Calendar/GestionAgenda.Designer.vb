<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionAgenda
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
        Me.components = New System.ComponentModel.Container
        Dim CalendarHighlightRange1 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange
        Dim CalendarHighlightRange2 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange
        Dim CalendarHighlightRange3 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange
        Dim CalendarHighlightRange4 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange
        Dim CalendarHighlightRange5 As System.Windows.Forms.Calendar.CalendarHighlightRange = New System.Windows.Forms.Calendar.CalendarHighlightRange
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GestionAgenda))
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Calendar1 = New System.Windows.Forms.Calendar.Calendar
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CambiarColorEventoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RojoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerdeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AmarilloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AzulToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OtroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.MonthCalendar1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(227, 476)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 127)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Propiedades del Evento"
        Me.GroupBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(72, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(12, 19)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "Activar Aviso"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hora del Aviso:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha del Aviso:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(151, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = ":"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Enabled = False
        Me.NumericUpDown2.Increment = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericUpDown2.Location = New System.Drawing.Point(167, 64)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(45, 20)
        Me.NumericUpDown2.TabIndex = 2
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.Location = New System.Drawing.Point(101, 64)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(43, 20)
        Me.NumericUpDown1.TabIndex = 2
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(101, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(111, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(0, 0)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Calendar1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(227, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(589, 476)
        Me.Panel1.TabIndex = 2
        '
        'Calendar1
        '
        Me.Calendar1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Calendar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Calendar1.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.Calendar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        CalendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday
        CalendarHighlightRange1.EndTime = System.TimeSpan.Parse("17:00:00")
        CalendarHighlightRange1.StartTime = System.TimeSpan.Parse("08:00:00")
        CalendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday
        CalendarHighlightRange2.EndTime = System.TimeSpan.Parse("17:00:00")
        CalendarHighlightRange2.StartTime = System.TimeSpan.Parse("08:00:00")
        CalendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday
        CalendarHighlightRange3.EndTime = System.TimeSpan.Parse("17:00:00")
        CalendarHighlightRange3.StartTime = System.TimeSpan.Parse("08:00:00")
        CalendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday
        CalendarHighlightRange4.EndTime = System.TimeSpan.Parse("17:00:00")
        CalendarHighlightRange4.StartTime = System.TimeSpan.Parse("08:00:00")
        CalendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday
        CalendarHighlightRange5.EndTime = System.TimeSpan.Parse("17:00:00")
        CalendarHighlightRange5.StartTime = System.TimeSpan.Parse("08:00:00")
        Me.Calendar1.HighlightRanges = New System.Windows.Forms.Calendar.CalendarHighlightRange() {CalendarHighlightRange1, CalendarHighlightRange2, CalendarHighlightRange3, CalendarHighlightRange4, CalendarHighlightRange5}
        Me.Calendar1.Location = New System.Drawing.Point(0, 0)
        Me.Calendar1.Name = "Calendar1"
        Me.Calendar1.Size = New System.Drawing.Size(589, 476)
        Me.Calendar1.TabIndex = 0
        Me.Calendar1.Text = "Calendar1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarColorEventoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.BorrarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(191, 70)
        '
        'CambiarColorEventoToolStripMenuItem
        '
        Me.CambiarColorEventoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RojoToolStripMenuItem, Me.VerdeToolStripMenuItem, Me.AmarilloToolStripMenuItem, Me.AzulToolStripMenuItem, Me.OtroToolStripMenuItem})
        Me.CambiarColorEventoToolStripMenuItem.Name = "CambiarColorEventoToolStripMenuItem"
        Me.CambiarColorEventoToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.CambiarColorEventoToolStripMenuItem.Text = "Cambiar Color evento"
        '
        'RojoToolStripMenuItem
        '
        Me.RojoToolStripMenuItem.Name = "RojoToolStripMenuItem"
        Me.RojoToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.RojoToolStripMenuItem.Text = "Rojo"
        '
        'VerdeToolStripMenuItem
        '
        Me.VerdeToolStripMenuItem.Name = "VerdeToolStripMenuItem"
        Me.VerdeToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.VerdeToolStripMenuItem.Text = "Verde"
        '
        'AmarilloToolStripMenuItem
        '
        Me.AmarilloToolStripMenuItem.Name = "AmarilloToolStripMenuItem"
        Me.AmarilloToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AmarilloToolStripMenuItem.Text = "Amarillo"
        '
        'AzulToolStripMenuItem
        '
        Me.AzulToolStripMenuItem.Name = "AzulToolStripMenuItem"
        Me.AzulToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AzulToolStripMenuItem.Text = "Azul"
        '
        'OtroToolStripMenuItem
        '
        Me.OtroToolStripMenuItem.Name = "OtroToolStripMenuItem"
        Me.OtroToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.OtroToolStripMenuItem.Text = "Otro"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.BorrarToolStripMenuItem.Text = "Borrar"
        '
        'GestionAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 476)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GestionAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GestionAgenda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Calendar1 As System.Windows.Forms.Calendar.Calendar
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CambiarColorEventoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RojoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerdeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AmarilloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AzulToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
