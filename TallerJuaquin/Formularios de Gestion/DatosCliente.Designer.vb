<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatosCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatosCliente))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cNuevoCliente = New System.Windows.Forms.ToolStripButton
        Me.cNuevoCoche = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSeparator
        Me.cBuscarCliente = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSeparator
        Me.cPrimero = New System.Windows.Forms.ToolStripButton
        Me.cAtras = New System.Windows.Forms.ToolStripButton
        Me.cSiguiente = New System.Windows.Forms.ToolStripButton
        Me.cUltimo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cBorrarCliente = New System.Windows.Forms.ToolStripButton
        Me.cBorrarCoche = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cModificar = New System.Windows.Forms.ToolStripButton
        Me.cGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cTraspaso = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.GenerarBalance = New System.Windows.Forms.ToolStripButton
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.cTelefonos = New System.Windows.Forms.DataGridView
        Me.Label10 = New System.Windows.Forms.Label
        Me.cEsAseguradora = New RYCCheckBox.RYCCheckBox
        Me.cComentario = New System.Windows.Forms.RichTextBox
        Me.cEmail = New System.Windows.Forms.TextBox
        Me.cDNI = New System.Windows.Forms.TextBox
        Me.cProvincia = New System.Windows.Forms.TextBox
        Me.cPoblacion = New System.Windows.Forms.TextBox
        Me.cCodigoPostal = New System.Windows.Forms.TextBox
        Me.cDireccion = New System.Windows.Forms.TextBox
        Me.cNombreComercial = New System.Windows.Forms.TextBox
        Me.cNumeroCliente = New System.Windows.Forms.TextBox
        Me.cNombreCliente = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.cHistorial0 = New System.Windows.Forms.DataGridView
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cMarca0 = New System.Windows.Forms.TextBox
        Me.cModelo0 = New System.Windows.Forms.TextBox
        Me.cColor0 = New System.Windows.Forms.TextBox
        Me.cIDCoche0 = New System.Windows.Forms.TextBox
        Me.cMatricula0 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.ToolStrip1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.cTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.cHistorial0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cNuevoCliente, Me.cNuevoCoche, Me.ToolStripButton1, Me.cBuscarCliente, Me.ToolStripButton2, Me.cPrimero, Me.cAtras, Me.cSiguiente, Me.cUltimo, Me.ToolStripSeparator1, Me.cBorrarCliente, Me.cBorrarCoche, Me.ToolStripSeparator2, Me.cModificar, Me.cGuardar, Me.ToolStripSeparator3, Me.cTraspaso, Me.ToolStripSeparator4, Me.GenerarBalance})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(975, 55)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'cNuevoCliente
        '
        Me.cNuevoCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cNuevoCliente.Image = Global.TallerJoaquin.My.Resources.Resources._1269047085_network_add
        Me.cNuevoCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cNuevoCliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cNuevoCliente.Name = "cNuevoCliente"
        Me.cNuevoCliente.Size = New System.Drawing.Size(52, 52)
        Me.cNuevoCliente.Text = "Añadir Cliente"
        '
        'cNuevoCoche
        '
        Me.cNuevoCoche.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cNuevoCoche.Image = Global.TallerJoaquin.My.Resources.Resources._1269094692_CabrioletRed1
        Me.cNuevoCoche.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cNuevoCoche.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cNuevoCoche.Name = "cNuevoCoche"
        Me.cNuevoCoche.Size = New System.Drawing.Size(52, 52)
        Me.cNuevoCoche.Text = "Añadir Coche"
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
        Me.cBuscarCliente.Text = "Buscar Cliente"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(6, 55)
        '
        'cPrimero
        '
        Me.cPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cPrimero.Image = Global.TallerJoaquin.My.Resources.Resources._1269098499_button_blue_first
        Me.cPrimero.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cPrimero.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cPrimero.Name = "cPrimero"
        Me.cPrimero.Size = New System.Drawing.Size(28, 52)
        Me.cPrimero.Text = "Primero"
        '
        'cAtras
        '
        Me.cAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cAtras.Image = Global.TallerJoaquin.My.Resources.Resources._1269098461_Play1Pressed
        Me.cAtras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cAtras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cAtras.Name = "cAtras"
        Me.cAtras.Size = New System.Drawing.Size(40, 52)
        Me.cAtras.Text = "Anterior"
        '
        'cSiguiente
        '
        Me.cSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cSiguiente.Image = Global.TallerJoaquin.My.Resources.Resources._1269098461_Play1Pressed___copia
        Me.cSiguiente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cSiguiente.Name = "cSiguiente"
        Me.cSiguiente.Size = New System.Drawing.Size(40, 52)
        Me.cSiguiente.Text = "Siguiente"
        '
        'cUltimo
        '
        Me.cUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cUltimo.Image = Global.TallerJoaquin.My.Resources.Resources._1269098453_button_blue_last
        Me.cUltimo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cUltimo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cUltimo.Name = "cUltimo"
        Me.cUltimo.Size = New System.Drawing.Size(28, 52)
        Me.cUltimo.Text = "Ultimo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'cBorrarCliente
        '
        Me.cBorrarCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cBorrarCliente.Image = Global.TallerJoaquin.My.Resources.Resources._1269047232_network_close
        Me.cBorrarCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cBorrarCliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cBorrarCliente.Name = "cBorrarCliente"
        Me.cBorrarCliente.Size = New System.Drawing.Size(52, 52)
        Me.cBorrarCliente.Text = "Borrar Cliente Seleccionado"
        '
        'cBorrarCoche
        '
        Me.cBorrarCoche.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cBorrarCoche.Image = Global.TallerJoaquin.My.Resources.Resources._1269094692_CabrioletRed
        Me.cBorrarCoche.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cBorrarCoche.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cBorrarCoche.Name = "cBorrarCoche"
        Me.cBorrarCoche.Size = New System.Drawing.Size(52, 52)
        Me.cBorrarCoche.Text = "Borrar Coche Seleccionado"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 55)
        '
        'cModificar
        '
        Me.cModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cModificar.Image = Global.TallerJoaquin.My.Resources.Resources._1269047272_network_unlock
        Me.cModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cModificar.Name = "cModificar"
        Me.cModificar.Size = New System.Drawing.Size(52, 52)
        Me.cModificar.Text = "Modificar"
        '
        'cGuardar
        '
        Me.cGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cGuardar.Image = Global.TallerJoaquin.My.Resources.Resources._1269047212_network_save
        Me.cGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cGuardar.Name = "cGuardar"
        Me.cGuardar.Size = New System.Drawing.Size(52, 52)
        Me.cGuardar.Text = "Guardar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 55)
        '
        'cTraspaso
        '
        Me.cTraspaso.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cTraspaso.Image = Global.TallerJoaquin.My.Resources.Resources.Transpasar
        Me.cTraspaso.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cTraspaso.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cTraspaso.Name = "cTraspaso"
        Me.cTraspaso.Size = New System.Drawing.Size(52, 52)
        Me.cTraspaso.Text = "Traspaso de Coche Seleccionado"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 55)
        '
        'GenerarBalance
        '
        Me.GenerarBalance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GenerarBalance.Image = Global.TallerJoaquin.My.Resources.Resources.BalanceUser
        Me.GenerarBalance.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GenerarBalance.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GenerarBalance.Name = "GenerarBalance"
        Me.GenerarBalance.Size = New System.Drawing.Size(52, 52)
        Me.GenerarBalance.Text = "Generar Balance Cliente"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.cTelefonos)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.cEsAseguradora)
        Me.TabPage1.Controls.Add(Me.cComentario)
        Me.TabPage1.Controls.Add(Me.cEmail)
        Me.TabPage1.Controls.Add(Me.cDNI)
        Me.TabPage1.Controls.Add(Me.cProvincia)
        Me.TabPage1.Controls.Add(Me.cPoblacion)
        Me.TabPage1.Controls.Add(Me.cCodigoPostal)
        Me.TabPage1.Controls.Add(Me.cDireccion)
        Me.TabPage1.Controls.Add(Me.cNombreComercial)
        Me.TabPage1.Controls.Add(Me.cNumeroCliente)
        Me.TabPage1.Controls.Add(Me.cNombreCliente)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(967, 527)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos del Cliente"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(623, 50)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(124, 20)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Es Aseguradora"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(470, 251)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 20)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Telefono:"
        '
        'cTelefonos
        '
        Me.cTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.cTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cTelefonos.ColumnHeadersVisible = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Format = "(000)-00-00-00"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cTelefonos.DefaultCellStyle = DataGridViewCellStyle1
        Me.cTelefonos.Location = New System.Drawing.Point(557, 246)
        Me.cTelefonos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cTelefonos.Name = "cTelefonos"
        Me.cTelefonos.RowHeadersVisible = False
        Me.cTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cTelefonos.Size = New System.Drawing.Size(207, 112)
        Me.cTelefonos.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(196, 50)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 20)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Numero Cliente:"
        '
        'cEsAseguradora
        '
        Me.cEsAseguradora.ColorMarcado = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.cEsAseguradora.Location = New System.Drawing.Point(590, 47)
        Me.cEsAseguradora.Marcado = False
        Me.cEsAseguradora.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cEsAseguradora.Name = "cEsAseguradora"
        Me.cEsAseguradora.Size = New System.Drawing.Size(26, 26)
        Me.cEsAseguradora.TabIndex = 10
        Me.cEsAseguradora.TipoMarcado = RYCCheckBox.RYCCheckBox.eTipoMarcado.Tick
        '
        'cComentario
        '
        Me.cComentario.BackColor = System.Drawing.SystemColors.Window
        Me.cComentario.Location = New System.Drawing.Point(282, 368)
        Me.cComentario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cComentario.Name = "cComentario"
        Me.cComentario.Size = New System.Drawing.Size(500, 121)
        Me.cComentario.TabIndex = 10
        Me.cComentario.Text = ""
        '
        'cEmail
        '
        Me.cEmail.Location = New System.Drawing.Point(282, 328)
        Me.cEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cEmail.Name = "cEmail"
        Me.cEmail.Size = New System.Drawing.Size(240, 26)
        Me.cEmail.TabIndex = 8
        '
        'cDNI
        '
        Me.cDNI.Location = New System.Drawing.Point(282, 288)
        Me.cDNI.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cDNI.Name = "cDNI"
        Me.cDNI.Size = New System.Drawing.Size(240, 26)
        Me.cDNI.TabIndex = 7
        '
        'cProvincia
        '
        Me.cProvincia.Location = New System.Drawing.Point(556, 206)
        Me.cProvincia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cProvincia.Name = "cProvincia"
        Me.cProvincia.Size = New System.Drawing.Size(206, 26)
        Me.cProvincia.TabIndex = 5
        '
        'cPoblacion
        '
        Me.cPoblacion.Location = New System.Drawing.Point(282, 246)
        Me.cPoblacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cPoblacion.Name = "cPoblacion"
        Me.cPoblacion.Size = New System.Drawing.Size(163, 26)
        Me.cPoblacion.TabIndex = 6
        '
        'cCodigoPostal
        '
        Me.cCodigoPostal.Location = New System.Drawing.Point(317, 206)
        Me.cCodigoPostal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cCodigoPostal.Name = "cCodigoPostal"
        Me.cCodigoPostal.Size = New System.Drawing.Size(128, 26)
        Me.cCodigoPostal.TabIndex = 4
        '
        'cDireccion
        '
        Me.cDireccion.Location = New System.Drawing.Point(282, 170)
        Me.cDireccion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cDireccion.Name = "cDireccion"
        Me.cDireccion.Size = New System.Drawing.Size(480, 26)
        Me.cDireccion.TabIndex = 3
        '
        'cNombreComercial
        '
        Me.cNombreComercial.Location = New System.Drawing.Point(344, 130)
        Me.cNombreComercial.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cNombreComercial.Name = "cNombreComercial"
        Me.cNombreComercial.Size = New System.Drawing.Size(418, 26)
        Me.cNombreComercial.TabIndex = 2
        '
        'cNumeroCliente
        '
        Me.cNumeroCliente.Enabled = False
        Me.cNumeroCliente.Location = New System.Drawing.Point(328, 45)
        Me.cNumeroCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cNumeroCliente.Name = "cNumeroCliente"
        Me.cNumeroCliente.Size = New System.Drawing.Size(118, 26)
        Me.cNumeroCliente.TabIndex = 0
        '
        'cNombreCliente
        '
        Me.cNombreCliente.Location = New System.Drawing.Point(344, 90)
        Me.cNombreCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cNombreCliente.Name = "cNombreCliente"
        Me.cNombreCliente.Size = New System.Drawing.Size(418, 26)
        Me.cNombreCliente.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(184, 373)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Comentario:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(226, 330)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Email:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(234, 293)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "DNI:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(470, 211)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Provincia."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(197, 251)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Poblacion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 214)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Codigo Postal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 174)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Direccion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Comercial:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del Cliente:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 60)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(975, 560)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cHistorial0)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.cMarca0)
        Me.TabPage2.Controls.Add(Me.cModelo0)
        Me.TabPage2.Controls.Add(Me.cColor0)
        Me.TabPage2.Controls.Add(Me.cIDCoche0)
        Me.TabPage2.Controls.Add(Me.cMatricula0)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Size = New System.Drawing.Size(967, 527)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Coche 1"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cHistorial0
        '
        Me.cHistorial0.AllowUserToAddRows = False
        Me.cHistorial0.AllowUserToDeleteRows = False
        Me.cHistorial0.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.cHistorial0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cHistorial0.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.cHistorial0.Location = New System.Drawing.Point(117, 248)
        Me.cHistorial0.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cHistorial0.Name = "cHistorial0"
        Me.cHistorial0.RowHeadersVisible = False
        Me.cHistorial0.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cHistorial0.Size = New System.Drawing.Size(770, 231)
        Me.cHistorial0.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(113, 223)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 20)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Historial"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(520, 148)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 20)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Modelo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(520, 108)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 20)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Marca:"
        '
        'cMarca0
        '
        Me.cMarca0.Location = New System.Drawing.Point(597, 103)
        Me.cMarca0.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cMarca0.Name = "cMarca0"
        Me.cMarca0.Size = New System.Drawing.Size(148, 26)
        Me.cMarca0.TabIndex = 2
        '
        'cModelo0
        '
        Me.cModelo0.Location = New System.Drawing.Point(597, 143)
        Me.cModelo0.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cModelo0.Name = "cModelo0"
        Me.cModelo0.Size = New System.Drawing.Size(148, 26)
        Me.cModelo0.TabIndex = 3
        '
        'cColor0
        '
        Me.cColor0.Location = New System.Drawing.Point(326, 143)
        Me.cColor0.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cColor0.Name = "cColor0"
        Me.cColor0.Size = New System.Drawing.Size(148, 26)
        Me.cColor0.TabIndex = 4
        '
        'cIDCoche0
        '
        Me.cIDCoche0.Location = New System.Drawing.Point(326, 63)
        Me.cIDCoche0.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cIDCoche0.Name = "cIDCoche0"
        Me.cIDCoche0.Size = New System.Drawing.Size(148, 26)
        Me.cIDCoche0.TabIndex = 0
        '
        'cMatricula0
        '
        Me.cMatricula0.Location = New System.Drawing.Point(326, 103)
        Me.cMatricula0.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cMatricula0.Name = "cMatricula0"
        Me.cMatricula0.Size = New System.Drawing.Size(148, 26)
        Me.cMatricula0.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(266, 148)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 20)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Color:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(237, 108)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 20)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Matricula:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(218, 68)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Num Coche:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(590, 52)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DatosCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 627)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "DatosCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.cTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.cHistorial0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cNuevoCliente As System.Windows.Forms.ToolStripButton
    Friend WithEvents cPrimero As System.Windows.Forms.ToolStripButton
    Friend WithEvents cAtras As System.Windows.Forms.ToolStripButton
    Friend WithEvents cSiguiente As System.Windows.Forms.ToolStripButton
    Friend WithEvents cUltimo As System.Windows.Forms.ToolStripButton
    Friend WithEvents cBorrarCliente As System.Windows.Forms.ToolStripButton
    Friend WithEvents cBuscarCliente As System.Windows.Forms.ToolStripButton
    Friend WithEvents cNuevoCoche As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cBorrarCoche As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cModificar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cTelefonos As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cEsAseguradora As RYCCheckBox.RYCCheckBox
    Friend WithEvents cComentario As System.Windows.Forms.RichTextBox
    Friend WithEvents cEmail As System.Windows.Forms.TextBox
    Friend WithEvents cDNI As System.Windows.Forms.TextBox
    Friend WithEvents cProvincia As System.Windows.Forms.TextBox
    Friend WithEvents cPoblacion As System.Windows.Forms.TextBox
    Friend WithEvents cCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents cDireccion As System.Windows.Forms.TextBox
    Friend WithEvents cNombreComercial As System.Windows.Forms.TextBox
    Friend WithEvents cNumeroCliente As System.Windows.Forms.TextBox
    Friend WithEvents cNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cHistorial0 As System.Windows.Forms.DataGridView
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cMarca0 As System.Windows.Forms.TextBox
    Friend WithEvents cModelo0 As System.Windows.Forms.TextBox
    Friend WithEvents cColor0 As System.Windows.Forms.TextBox
    Friend WithEvents cIDCoche0 As System.Windows.Forms.TextBox
    Friend WithEvents cMatricula0 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cTraspaso As System.Windows.Forms.ToolStripButton
    Friend WithEvents GenerarBalance As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
