<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdenTrabajo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdenTrabajo))
        Me.Label17 = New System.Windows.Forms.Label
        Me.cTelefonos = New System.Windows.Forms.DataGridView
        Me.cDNI = New System.Windows.Forms.TextBox
        Me.cProvincia = New System.Windows.Forms.TextBox
        Me.cPoblacion = New System.Windows.Forms.TextBox
        Me.cCodigoPostal = New System.Windows.Forms.TextBox
        Me.cDireccion = New System.Windows.Forms.TextBox
        Me.cNombreCliente = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cNumeroCliente = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cMarca = New System.Windows.Forms.TextBox
        Me.cModelo = New System.Windows.Forms.TextBox
        Me.cColor = New System.Windows.Forms.TextBox
        Me.cIDCoche = New System.Windows.Forms.TextBox
        Me.cMatricula = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cObservaciones = New System.Windows.Forms.RichTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cFechaEntrada = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cIDHistorial = New System.Windows.Forms.TextBox
        Me.cReparacion = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.cKilometros = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cNueva = New System.Windows.Forms.ToolStripButton
        Me.cGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSeparator
        Me.cBuscarCliente = New System.Windows.Forms.ToolStripButton
        Me.cBuscarCoche = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cInsertarImagen = New System.Windows.Forms.ToolStripButton
        Me.cBorrarImagen = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cHacerPresupuesto = New System.Windows.Forms.ToolStripButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.cImagenes = New System.Windows.Forms.ListView
        CType(Me.cTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.cReparacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(233, 136)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 15)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Telefono:"
        '
        'cTelefonos
        '
        Me.cTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.cTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cTelefonos.ColumnHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Format = "(000)-00-00-00"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cTelefonos.DefaultCellStyle = DataGridViewCellStyle1
        Me.cTelefonos.Location = New System.Drawing.Point(301, 132)
        Me.cTelefonos.Margin = New System.Windows.Forms.Padding(4)
        Me.cTelefonos.Name = "cTelefonos"
        Me.cTelefonos.RowHeadersVisible = False
        Me.cTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cTelefonos.Size = New System.Drawing.Size(161, 54)
        Me.cTelefonos.TabIndex = 1
        '
        'cDNI
        '
        Me.cDNI.Location = New System.Drawing.Point(97, 161)
        Me.cDNI.Margin = New System.Windows.Forms.Padding(4)
        Me.cDNI.Name = "cDNI"
        Me.cDNI.Size = New System.Drawing.Size(188, 21)
        Me.cDNI.TabIndex = 9
        '
        'cProvincia
        '
        Me.cProvincia.Location = New System.Drawing.Point(300, 102)
        Me.cProvincia.Margin = New System.Windows.Forms.Padding(4)
        Me.cProvincia.Name = "cProvincia"
        Me.cProvincia.Size = New System.Drawing.Size(162, 21)
        Me.cProvincia.TabIndex = 8
        '
        'cPoblacion
        '
        Me.cPoblacion.Location = New System.Drawing.Point(97, 130)
        Me.cPoblacion.Margin = New System.Windows.Forms.Padding(4)
        Me.cPoblacion.Name = "cPoblacion"
        Me.cPoblacion.Size = New System.Drawing.Size(127, 21)
        Me.cPoblacion.TabIndex = 7
        '
        'cCodigoPostal
        '
        Me.cCodigoPostal.Location = New System.Drawing.Point(125, 100)
        Me.cCodigoPostal.Margin = New System.Windows.Forms.Padding(4)
        Me.cCodigoPostal.Name = "cCodigoPostal"
        Me.cCodigoPostal.Size = New System.Drawing.Size(100, 21)
        Me.cCodigoPostal.TabIndex = 6
        '
        'cDireccion
        '
        Me.cDireccion.Location = New System.Drawing.Point(97, 73)
        Me.cDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.cDireccion.Name = "cDireccion"
        Me.cDireccion.Size = New System.Drawing.Size(365, 21)
        Me.cDireccion.TabIndex = 5
        '
        'cNombreCliente
        '
        Me.cNombreCliente.Location = New System.Drawing.Point(145, 43)
        Me.cNombreCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cNombreCliente.Name = "cNombreCliente"
        Me.cNombreCliente.Size = New System.Drawing.Size(317, 21)
        Me.cNombreCliente.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 165)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 15)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "DNI:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(233, 106)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Provincia."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 134)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Poblacion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 106)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Codigo Postal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 76)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Direccion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre del Cliente:"
        '
        'cNumeroCliente
        '
        Me.cNumeroCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cNumeroCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cNumeroCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cNumeroCliente.Location = New System.Drawing.Point(389, 11)
        Me.cNumeroCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cNumeroCliente.Name = "cNumeroCliente"
        Me.cNumeroCliente.ReadOnly = True
        Me.cNumeroCliente.Size = New System.Drawing.Size(2, 14)
        Me.cNumeroCliente.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cTelefonos)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cDNI)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cProvincia)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cPoblacion)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cCodigoPostal)
        Me.GroupBox1.Controls.Add(Me.cNombreCliente)
        Me.GroupBox1.Controls.Add(Me.cDireccion)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 137)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(490, 205)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(292, 80)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Modelo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(292, 50)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Marca:"
        '
        'cMarca
        '
        Me.cMarca.Location = New System.Drawing.Point(353, 46)
        Me.cMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.cMarca.Name = "cMarca"
        Me.cMarca.Size = New System.Drawing.Size(116, 21)
        Me.cMarca.TabIndex = 7
        '
        'cModelo
        '
        Me.cModelo.Location = New System.Drawing.Point(353, 76)
        Me.cModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.cModelo.Name = "cModelo"
        Me.cModelo.Size = New System.Drawing.Size(116, 21)
        Me.cModelo.TabIndex = 8
        '
        'cColor
        '
        Me.cColor.Location = New System.Drawing.Point(95, 76)
        Me.cColor.Margin = New System.Windows.Forms.Padding(4)
        Me.cColor.Name = "cColor"
        Me.cColor.Size = New System.Drawing.Size(116, 21)
        Me.cColor.TabIndex = 5
        '
        'cIDCoche
        '
        Me.cIDCoche.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.cIDCoche.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cIDCoche.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cIDCoche.Location = New System.Drawing.Point(389, 11)
        Me.cIDCoche.Margin = New System.Windows.Forms.Padding(4)
        Me.cIDCoche.Name = "cIDCoche"
        Me.cIDCoche.ReadOnly = True
        Me.cIDCoche.Size = New System.Drawing.Size(2, 14)
        Me.cIDCoche.TabIndex = 1
        '
        'cMatricula
        '
        Me.cMatricula.Location = New System.Drawing.Point(95, 46)
        Me.cMatricula.Margin = New System.Windows.Forms.Padding(4)
        Me.cMatricula.Name = "cMatricula"
        Me.cMatricula.Size = New System.Drawing.Size(116, 21)
        Me.cMatricula.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(49, 80)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Color:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(26, 50)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 15)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Matricula:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cModelo)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.cIDCoche)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cNumeroCliente)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cMarca)
        Me.GroupBox2.Controls.Add(Me.cMatricula)
        Me.GroupBox2.Controls.Add(Me.cColor)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(490, 123)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Coche"
        '
        'cObservaciones
        '
        Me.cObservaciones.Location = New System.Drawing.Point(25, 228)
        Me.cObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.cObservaciones.Name = "cObservaciones"
        Me.cObservaciones.Size = New System.Drawing.Size(436, 95)
        Me.cObservaciones.TabIndex = 3
        Me.cObservaciones.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 208)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 15)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Observaciones"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 58)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 15)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Reparacion"
        '
        'cFechaEntrada
        '
        Me.cFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cFechaEntrada.Location = New System.Drawing.Point(122, 24)
        Me.cFechaEntrada.Margin = New System.Windows.Forms.Padding(4)
        Me.cFechaEntrada.Name = "cFechaEntrada"
        Me.cFechaEntrada.Size = New System.Drawing.Size(95, 21)
        Me.cFechaEntrada.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 28)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 15)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Fecha Entrada:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cIDHistorial)
        Me.GroupBox3.Controls.Add(Me.cReparacion)
        Me.GroupBox3.Controls.Add(Me.cObservaciones)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.cFechaEntrada)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cKilometros)
        Me.GroupBox3.Location = New System.Drawing.Point(510, 8)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(480, 335)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de la Averia"
        '
        'cIDHistorial
        '
        Me.cIDHistorial.Location = New System.Drawing.Point(122, 53)
        Me.cIDHistorial.Name = "cIDHistorial"
        Me.cIDHistorial.Size = New System.Drawing.Size(1, 21)
        Me.cIDHistorial.TabIndex = 52
        '
        'cReparacion
        '
        Me.cReparacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.cReparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cReparacion.ColumnHeadersVisible = False
        Me.cReparacion.Location = New System.Drawing.Point(25, 76)
        Me.cReparacion.Name = "cReparacion"
        Me.cReparacion.RowHeadersVisible = False
        Me.cReparacion.Size = New System.Drawing.Size(434, 110)
        Me.cReparacion.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Kilometros:"
        '
        'cKilometros
        '
        Me.cKilometros.Location = New System.Drawing.Point(334, 26)
        Me.cKilometros.Margin = New System.Windows.Forms.Padding(4)
        Me.cKilometros.Name = "cKilometros"
        Me.cKilometros.Size = New System.Drawing.Size(127, 21)
        Me.cKilometros.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cNueva, Me.cGuardar, Me.ToolStripButton1, Me.cBuscarCliente, Me.cBuscarCoche, Me.ToolStripSeparator1, Me.cInsertarImagen, Me.cBorrarImagen, Me.ToolStripSeparator2, Me.cHacerPresupuesto})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1004, 55)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cNueva
        '
        Me.cNueva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cNueva.Image = Global.TallerJoaquin.My.Resources.Resources._1271966523_edit_clear
        Me.cNueva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cNueva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cNueva.Name = "cNueva"
        Me.cNueva.Size = New System.Drawing.Size(52, 52)
        Me.cNueva.Text = "ToolStripButton2"
        Me.cNueva.ToolTipText = "Limpiar Campos"
        '
        'cGuardar
        '
        Me.cGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cGuardar.Image = Global.TallerJoaquin.My.Resources.Resources._1271966377_document_save_as
        Me.cGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cGuardar.Name = "cGuardar"
        Me.cGuardar.Size = New System.Drawing.Size(52, 52)
        Me.cGuardar.Text = "ToolStripButton1"
        Me.cGuardar.ToolTipText = "Guardar los Cambios"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(6, 55)
        '
        'cBuscarCliente
        '
        Me.cBuscarCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cBuscarCliente.Image = Global.TallerJoaquin.My.Resources.Resources._1269047330_network_search
        Me.cBuscarCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cBuscarCliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cBuscarCliente.Name = "cBuscarCliente"
        Me.cBuscarCliente.Size = New System.Drawing.Size(52, 52)
        Me.cBuscarCliente.ToolTipText = "Buscar un Cliente en la Base de Datos"
        '
        'cBuscarCoche
        '
        Me.cBuscarCoche.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cBuscarCoche.Image = Global.TallerJoaquin.My.Resources.Resources.BuscarCoche
        Me.cBuscarCoche.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cBuscarCoche.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cBuscarCoche.Name = "cBuscarCoche"
        Me.cBuscarCoche.Size = New System.Drawing.Size(52, 52)
        Me.cBuscarCoche.Text = "Buscar Coche"
        Me.cBuscarCoche.ToolTipText = "Busca un Coche en la Base de Datos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'cInsertarImagen
        '
        Me.cInsertarImagen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cInsertarImagen.Image = Global.TallerJoaquin.My.Resources.Resources.InsertarFoto
        Me.cInsertarImagen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cInsertarImagen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cInsertarImagen.Name = "cInsertarImagen"
        Me.cInsertarImagen.Size = New System.Drawing.Size(52, 52)
        Me.cInsertarImagen.Text = "InsertarFoto"
        Me.cInsertarImagen.ToolTipText = "Insertar Foto"
        '
        'cBorrarImagen
        '
        Me.cBorrarImagen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cBorrarImagen.Image = Global.TallerJoaquin.My.Resources.Resources.BorrarFoto
        Me.cBorrarImagen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cBorrarImagen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cBorrarImagen.Name = "cBorrarImagen"
        Me.cBorrarImagen.Size = New System.Drawing.Size(52, 52)
        Me.cBorrarImagen.Text = "Borrar Foto"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 55)
        '
        'cHacerPresupuesto
        '
        Me.cHacerPresupuesto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cHacerPresupuesto.Image = Global.TallerJoaquin.My.Resources.Resources.CrearFactura
        Me.cHacerPresupuesto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cHacerPresupuesto.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cHacerPresupuesto.Name = "cHacerPresupuesto"
        Me.cHacerPresupuesto.Size = New System.Drawing.Size(52, 52)
        Me.cHacerPresupuesto.Text = "Guardar y hacer presupuesto"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 55)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1004, 370)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(996, 342)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cImagenes)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(996, 342)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Imagenes"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cImagenes
        '
        Me.cImagenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cImagenes.ForeColor = System.Drawing.SystemColors.Window
        Me.cImagenes.Location = New System.Drawing.Point(4, 4)
        Me.cImagenes.Margin = New System.Windows.Forms.Padding(4)
        Me.cImagenes.Name = "cImagenes"
        Me.cImagenes.Size = New System.Drawing.Size(988, 334)
        Me.cImagenes.TabIndex = 1
        Me.cImagenes.UseCompatibleStateImageBehavior = False
        '
        'OrdenTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 425)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "OrdenTrabajo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Orden Trabajo"
        CType(Me.cTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.cReparacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cTelefonos As System.Windows.Forms.DataGridView
    Friend WithEvents cDNI As System.Windows.Forms.TextBox
    Friend WithEvents cProvincia As System.Windows.Forms.TextBox
    Friend WithEvents cPoblacion As System.Windows.Forms.TextBox
    Friend WithEvents cCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents cDireccion As System.Windows.Forms.TextBox
    Friend WithEvents cNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cNumeroCliente As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cMarca As System.Windows.Forms.TextBox
    Friend WithEvents cModelo As System.Windows.Forms.TextBox
    Friend WithEvents cColor As System.Windows.Forms.TextBox
    Friend WithEvents cIDCoche As System.Windows.Forms.TextBox
    Friend WithEvents cMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cObservaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cFechaEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cBuscarCliente As System.Windows.Forms.ToolStripButton
    Friend WithEvents cBuscarCoche As System.Windows.Forms.ToolStripButton
    Friend WithEvents cNueva As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cInsertarImagen As System.Windows.Forms.ToolStripButton
    Friend WithEvents cBorrarImagen As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cHacerPresupuesto As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cImagenes As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cKilometros As System.Windows.Forms.TextBox
    Friend WithEvents cReparacion As System.Windows.Forms.DataGridView
    Friend WithEvents cIDHistorial As System.Windows.Forms.TextBox
End Class
