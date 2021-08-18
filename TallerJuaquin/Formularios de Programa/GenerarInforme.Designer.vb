<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarInforme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerarInforme))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cNumeroCliente = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cDNI = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cPoblacion = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cNombreCliente = New System.Windows.Forms.TextBox
        Me.cDireccion = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BuscarCliente = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.QuitarFiltroCliente = New System.Windows.Forms.ToolStripButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CheckBox2 = New RYCCheckBox.RYCCheckBox
        Me.CheckBox1 = New RYCCheckBox.RYCCheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.RycCheckBox3 = New RYCCheckBox.RYCCheckBox
        Me.RycCheckBox2 = New RYCCheckBox.RYCCheckBox
        Me.RycCheckBox1 = New RYCCheckBox.RYCCheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.RycCheckBox4 = New RYCCheckBox.RYCCheckBox
        Me.RycCheckBox5 = New RYCCheckBox.RYCCheckBox
        Me.RycCheckBox6 = New RYCCheckBox.RYCCheckBox
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cNumeroCliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cDNI)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cPoblacion)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cNombreCliente)
        Me.GroupBox1.Controls.Add(Me.cDireccion)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 232)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(681, 166)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
        '
        'cNumeroCliente
        '
        Me.cNumeroCliente.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cNumeroCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cNumeroCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cNumeroCliente.Location = New System.Drawing.Point(361, 124)
        Me.cNumeroCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cNumeroCliente.Name = "cNumeroCliente"
        Me.cNumeroCliente.ReadOnly = True
        Me.cNumeroCliente.Size = New System.Drawing.Size(2, 19)
        Me.cNumeroCliente.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(27, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre del Cliente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(27, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Direccion:"
        '
        'cDNI
        '
        Me.cDNI.Location = New System.Drawing.Point(409, 119)
        Me.cDNI.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cDNI.Name = "cDNI"
        Me.cDNI.ReadOnly = True
        Me.cDNI.Size = New System.Drawing.Size(250, 26)
        Me.cDNI.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(28, 122)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Poblacion:"
        '
        'cPoblacion
        '
        Me.cPoblacion.Location = New System.Drawing.Point(114, 117)
        Me.cPoblacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cPoblacion.Name = "cPoblacion"
        Me.cPoblacion.ReadOnly = True
        Me.cPoblacion.Size = New System.Drawing.Size(238, 26)
        Me.cPoblacion.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(360, 125)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "DNI:"
        '
        'cNombreCliente
        '
        Me.cNombreCliente.Location = New System.Drawing.Point(176, 42)
        Me.cNombreCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cNombreCliente.Name = "cNombreCliente"
        Me.cNombreCliente.ReadOnly = True
        Me.cNombreCliente.Size = New System.Drawing.Size(483, 26)
        Me.cNombreCliente.TabIndex = 12
        '
        'cDireccion
        '
        Me.cDireccion.Location = New System.Drawing.Point(114, 82)
        Me.cDireccion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cDireccion.Name = "cDireccion"
        Me.cDireccion.ReadOnly = True
        Me.cDireccion.Size = New System.Drawing.Size(545, 26)
        Me.cDireccion.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(315, 408)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Generar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarCliente, Me.ToolStripSeparator1, Me.QuitarFiltroCliente})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(742, 55)
        Me.ToolStrip1.TabIndex = 34
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BuscarCliente
        '
        Me.BuscarCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BuscarCliente.Image = Global.TallerJoaquin.My.Resources.Resources._1269047330_network_search
        Me.BuscarCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BuscarCliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BuscarCliente.Name = "BuscarCliente"
        Me.BuscarCliente.Size = New System.Drawing.Size(52, 52)
        Me.BuscarCliente.Text = "Buscar Cliente"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'QuitarFiltroCliente
        '
        Me.QuitarFiltroCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.QuitarFiltroCliente.Image = Global.TallerJoaquin.My.Resources.Resources._1271966523_edit_clear
        Me.QuitarFiltroCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.QuitarFiltroCliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.QuitarFiltroCliente.Name = "QuitarFiltroCliente"
        Me.QuitarFiltroCliente.Size = New System.Drawing.Size(52, 52)
        Me.QuitarFiltroCliente.Text = "Limpiar Todo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 60)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(466, 78)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar por Fechas"
        '
        'CheckBox2
        '
        Me.CheckBox2.ColorMarcado = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.CheckBox2.Location = New System.Drawing.Point(424, 26)
        Me.CheckBox2.Marcado = False
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(26, 26)
        Me.CheckBox2.TabIndex = 2
        Me.CheckBox2.TipoMarcado = RYCCheckBox.RYCCheckBox.eTipoMarcado.Tick
        '
        'CheckBox1
        '
        Me.CheckBox1.ColorMarcado = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(199, 29)
        Me.CheckBox1.Marcado = False
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(26, 26)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.TipoMarcado = RYCCheckBox.RYCCheckBox.eTipoMarcado.Tick
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(234, 29)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Hasta:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(300, 26)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(116, 26)
        Me.DateTimePicker2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Desde:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(79, 29)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(116, 26)
        Me.DateTimePicker1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.RycCheckBox3)
        Me.GroupBox3.Controls.Add(Me.RycCheckBox2)
        Me.GroupBox3.Controls.Add(Me.RycCheckBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(19, 146)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(467, 78)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones de Grafico"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(302, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 20)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Anual:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(82, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Diario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(182, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mensual:"
        '
        'RycCheckBox3
        '
        Me.RycCheckBox3.ColorMarcado = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RycCheckBox3.Location = New System.Drawing.Point(359, 32)
        Me.RycCheckBox3.Marcado = False
        Me.RycCheckBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.RycCheckBox3.Name = "RycCheckBox3"
        Me.RycCheckBox3.Size = New System.Drawing.Size(26, 26)
        Me.RycCheckBox3.TabIndex = 2
        Me.RycCheckBox3.TipoMarcado = RYCCheckBox.RYCCheckBox.eTipoMarcado.Tick
        '
        'RycCheckBox2
        '
        Me.RycCheckBox2.ColorMarcado = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RycCheckBox2.Location = New System.Drawing.Point(139, 32)
        Me.RycCheckBox2.Marcado = False
        Me.RycCheckBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.RycCheckBox2.Name = "RycCheckBox2"
        Me.RycCheckBox2.Size = New System.Drawing.Size(26, 26)
        Me.RycCheckBox2.TabIndex = 2
        Me.RycCheckBox2.TipoMarcado = RYCCheckBox.RYCCheckBox.eTipoMarcado.Tick
        '
        'RycCheckBox1
        '
        Me.RycCheckBox1.ColorMarcado = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RycCheckBox1.Location = New System.Drawing.Point(258, 32)
        Me.RycCheckBox1.Marcado = True
        Me.RycCheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.RycCheckBox1.Name = "RycCheckBox1"
        Me.RycCheckBox1.Size = New System.Drawing.Size(26, 26)
        Me.RycCheckBox1.TabIndex = 2
        Me.RycCheckBox1.TipoMarcado = RYCCheckBox.RYCCheckBox.eTipoMarcado.Tick
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.RycCheckBox4)
        Me.GroupBox4.Controls.Add(Me.RycCheckBox5)
        Me.GroupBox4.Controls.Add(Me.RycCheckBox6)
        Me.GroupBox4.Location = New System.Drawing.Point(492, 60)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(208, 164)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Opciones de Balance"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(147, 20)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Gastos de Material:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 20)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Mano de Obra:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 20)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Repuestos:"
        '
        'RycCheckBox4
        '
        Me.RycCheckBox4.ColorMarcado = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RycCheckBox4.Location = New System.Drawing.Point(160, 118)
        Me.RycCheckBox4.Marcado = False
        Me.RycCheckBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.RycCheckBox4.Name = "RycCheckBox4"
        Me.RycCheckBox4.Size = New System.Drawing.Size(26, 26)
        Me.RycCheckBox4.TabIndex = 2
        Me.RycCheckBox4.TipoMarcado = RYCCheckBox.RYCCheckBox.eTipoMarcado.Tick
        '
        'RycCheckBox5
        '
        Me.RycCheckBox5.ColorMarcado = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RycCheckBox5.Location = New System.Drawing.Point(160, 34)
        Me.RycCheckBox5.Marcado = True
        Me.RycCheckBox5.Margin = New System.Windows.Forms.Padding(0)
        Me.RycCheckBox5.Name = "RycCheckBox5"
        Me.RycCheckBox5.Size = New System.Drawing.Size(26, 26)
        Me.RycCheckBox5.TabIndex = 2
        Me.RycCheckBox5.TipoMarcado = RYCCheckBox.RYCCheckBox.eTipoMarcado.Tick
        '
        'RycCheckBox6
        '
        Me.RycCheckBox6.ColorMarcado = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.RycCheckBox6.Location = New System.Drawing.Point(160, 74)
        Me.RycCheckBox6.Marcado = True
        Me.RycCheckBox6.Margin = New System.Windows.Forms.Padding(0)
        Me.RycCheckBox6.Name = "RycCheckBox6"
        Me.RycCheckBox6.Size = New System.Drawing.Size(26, 26)
        Me.RycCheckBox6.TabIndex = 2
        Me.RycCheckBox6.TipoMarcado = RYCCheckBox.RYCCheckBox.eTipoMarcado.Tick
        '
        'GenerarInforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 462)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "GenerarInforme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generar Informe de Balances"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cPoblacion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents cDireccion As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BuscarCliente As System.Windows.Forms.ToolStripButton
    Friend WithEvents cNumeroCliente As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents QuitarFiltroCliente As System.Windows.Forms.ToolStripButton
    Friend WithEvents CheckBox2 As RYCCheckBox.RYCCheckBox
    Friend WithEvents CheckBox1 As RYCCheckBox.RYCCheckBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RycCheckBox3 As RYCCheckBox.RYCCheckBox
    Friend WithEvents RycCheckBox2 As RYCCheckBox.RYCCheckBox
    Friend WithEvents RycCheckBox1 As RYCCheckBox.RYCCheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents RycCheckBox4 As RYCCheckBox.RYCCheckBox
    Friend WithEvents RycCheckBox5 As RYCCheckBox.RYCCheckBox
    Friend WithEvents RycCheckBox6 As RYCCheckBox.RYCCheckBox
End Class
