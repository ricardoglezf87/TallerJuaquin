<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialCoche
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HistorialCoche))
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.cRepuesto = New System.Windows.Forms.DataGridView
        Me.cKilometros = New System.Windows.Forms.TextBox
        Me.cIDCliente = New System.Windows.Forms.TextBox
        Me.cIDCoche = New System.Windows.Forms.TextBox
        Me.cObservaciones = New System.Windows.Forms.RichTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cFechaEntrada = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.cImagenes = New System.Windows.Forms.ListView
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cInsertarFoto = New System.Windows.Forms.ToolStripButton
        Me.cBorrarFoto = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSeparator
        Me.cModificarAveria = New System.Windows.Forms.ToolStripButton
        Me.cGuardarDatos = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cBorrarAveria = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cVerFactura = New System.Windows.Forms.ToolStripButton
        Me.cFechaSalida = New ProjectMentor.Windows.Controls.NullableDateTimePicker
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.cRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(0, 62)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(662, 563)
        Me.TabControl2.TabIndex = 4
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.cRepuesto)
        Me.TabPage3.Controls.Add(Me.cKilometros)
        Me.TabPage3.Controls.Add(Me.cIDCliente)
        Me.TabPage3.Controls.Add(Me.cIDCoche)
        Me.TabPage3.Controls.Add(Me.cObservaciones)
        Me.TabPage3.Controls.Add(Me.cFechaSalida)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.cFechaEntrada)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage3.Size = New System.Drawing.Size(654, 530)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Datos de la Reparación"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'cRepuesto
        '
        Me.cRepuesto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.cRepuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cRepuesto.ColumnHeadersVisible = False
        Me.cRepuesto.Location = New System.Drawing.Point(43, 137)
        Me.cRepuesto.Name = "cRepuesto"
        Me.cRepuesto.RowHeadersVisible = False
        Me.cRepuesto.Size = New System.Drawing.Size(495, 146)
        Me.cRepuesto.TabIndex = 3
        '
        'cKilometros
        '
        Me.cKilometros.Location = New System.Drawing.Point(135, 68)
        Me.cKilometros.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cKilometros.Name = "cKilometros"
        Me.cKilometros.Size = New System.Drawing.Size(148, 26)
        Me.cKilometros.TabIndex = 2
        '
        'cIDCliente
        '
        Me.cIDCliente.Location = New System.Drawing.Point(444, 62)
        Me.cIDCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cIDCliente.Name = "cIDCliente"
        Me.cIDCliente.Size = New System.Drawing.Size(0, 26)
        Me.cIDCliente.TabIndex = 13
        '
        'cIDCoche
        '
        Me.cIDCoche.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cIDCoche.ForeColor = System.Drawing.SystemColors.Window
        Me.cIDCoche.Location = New System.Drawing.Point(15, 23)
        Me.cIDCoche.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cIDCoche.Name = "cIDCoche"
        Me.cIDCoche.Size = New System.Drawing.Size(15, 19)
        Me.cIDCoche.TabIndex = 12
        '
        'cObservaciones
        '
        Me.cObservaciones.Location = New System.Drawing.Point(44, 337)
        Me.cObservaciones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cObservaciones.Name = "cObservaciones"
        Me.cObservaciones.Size = New System.Drawing.Size(494, 155)
        Me.cObservaciones.TabIndex = 4
        Me.cObservaciones.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(300, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha Salida:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 312)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Observaciones"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Repuestos"
        '
        'cFechaEntrada
        '
        Me.cFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cFechaEntrada.Location = New System.Drawing.Point(168, 22)
        Me.cFechaEntrada.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cFechaEntrada.Name = "cFechaEntrada"
        Me.cFechaEntrada.Size = New System.Drawing.Size(121, 26)
        Me.cFechaEntrada.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 72)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Kilometros:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fecha Entrada:"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.cImagenes)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage4.Size = New System.Drawing.Size(654, 530)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Fotos de la Averia"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'cImagenes
        '
        Me.cImagenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cImagenes.ForeColor = System.Drawing.SystemColors.Window
        Me.cImagenes.Location = New System.Drawing.Point(4, 5)
        Me.cImagenes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cImagenes.Name = "cImagenes"
        Me.cImagenes.Size = New System.Drawing.Size(646, 520)
        Me.cImagenes.TabIndex = 0
        Me.cImagenes.UseCompatibleStateImageBehavior = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cInsertarFoto, Me.cBorrarFoto, Me.ToolStripButton1, Me.cModificarAveria, Me.cGuardarDatos, Me.ToolStripSeparator1, Me.cBorrarAveria, Me.ToolStripSeparator2, Me.cVerFactura})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(662, 55)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cInsertarFoto
        '
        Me.cInsertarFoto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cInsertarFoto.Image = Global.TallerJoaquin.My.Resources.Resources.InsertarFoto
        Me.cInsertarFoto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cInsertarFoto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cInsertarFoto.Name = "cInsertarFoto"
        Me.cInsertarFoto.Size = New System.Drawing.Size(52, 52)
        Me.cInsertarFoto.Text = "Añadir Fotos"
        '
        'cBorrarFoto
        '
        Me.cBorrarFoto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cBorrarFoto.Image = Global.TallerJoaquin.My.Resources.Resources.BorrarFoto
        Me.cBorrarFoto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cBorrarFoto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cBorrarFoto.Name = "cBorrarFoto"
        Me.cBorrarFoto.Size = New System.Drawing.Size(52, 52)
        Me.cBorrarFoto.Text = "Borrar Foto Seleccionada"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(6, 55)
        '
        'cModificarAveria
        '
        Me.cModificarAveria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cModificarAveria.Image = Global.TallerJoaquin.My.Resources.Resources.ModificarHistorial
        Me.cModificarAveria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cModificarAveria.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cModificarAveria.Name = "cModificarAveria"
        Me.cModificarAveria.Size = New System.Drawing.Size(52, 52)
        Me.cModificarAveria.Text = "Modificar Ficha"
        '
        'cGuardarDatos
        '
        Me.cGuardarDatos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cGuardarDatos.Image = Global.TallerJoaquin.My.Resources.Resources._1271966377_document_save_as
        Me.cGuardarDatos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cGuardarDatos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cGuardarDatos.Name = "cGuardarDatos"
        Me.cGuardarDatos.Size = New System.Drawing.Size(52, 52)
        Me.cGuardarDatos.Text = "Guardar Datos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'cBorrarAveria
        '
        Me.cBorrarAveria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cBorrarAveria.Image = Global.TallerJoaquin.My.Resources.Resources.BorrarHistorial
        Me.cBorrarAveria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cBorrarAveria.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cBorrarAveria.Name = "cBorrarAveria"
        Me.cBorrarAveria.Size = New System.Drawing.Size(52, 52)
        Me.cBorrarAveria.Text = "Borrar Historial Seleccionado"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 55)
        '
        'cVerFactura
        '
        Me.cVerFactura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cVerFactura.Image = Global.TallerJoaquin.My.Resources.Resources.VerFactura
        Me.cVerFactura.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cVerFactura.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cVerFactura.Name = "cVerFactura"
        Me.cVerFactura.Size = New System.Drawing.Size(52, 52)
        Me.cVerFactura.Text = "Ver El Presupuesto, Orden de Trabajo o Factura Asociado a este Historial"
        '
        'cFechaSalida
        '
        Me.cFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cFechaSalida.Location = New System.Drawing.Point(417, 22)
        Me.cFechaSalida.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cFechaSalida.Name = "cFechaSalida"
        Me.cFechaSalida.NullValue = "Sin Fecha"
        Me.cFechaSalida.Size = New System.Drawing.Size(121, 26)
        Me.cFechaSalida.TabIndex = 1
        Me.cFechaSalida.Value = New Date(2010, 6, 13, 21, 16, 48, 91)
        '
        'HistorialCoche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 635)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "HistorialCoche"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial del Coche"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.cRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents cObservaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents cFechaSalida As ProjectMentor.Windows.Controls.NullableDateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cFechaEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents cImagenes As System.Windows.Forms.ListView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cInsertarFoto As System.Windows.Forms.ToolStripButton
    Friend WithEvents cBorrarFoto As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cModificarAveria As System.Windows.Forms.ToolStripButton
    Friend WithEvents cGuardarDatos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cBorrarAveria As System.Windows.Forms.ToolStripButton
    Friend WithEvents cIDCoche As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cVerFactura As System.Windows.Forms.ToolStripButton
    Friend WithEvents cIDCliente As System.Windows.Forms.TextBox
    Friend WithEvents cKilometros As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cRepuesto As System.Windows.Forms.DataGridView
End Class
