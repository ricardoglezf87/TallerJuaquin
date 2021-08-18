<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Traspaso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Traspaso))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cIDCoche = New System.Windows.Forms.TextBox
        Me.cModelo = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cNumeroCliente = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cMarca = New System.Windows.Forms.TextBox
        Me.cMatricula = New System.Windows.Forms.TextBox
        Me.cColor = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cTelefonos = New System.Windows.Forms.DataGridView
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cDNI = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cProvincia = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cPoblacion = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cCodigoPostal = New System.Windows.Forms.TextBox
        Me.cNombreCliente = New System.Windows.Forms.TextBox
        Me.cDireccion = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cBuscarCliente = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cIDCoche)
        Me.GroupBox2.Controls.Add(Me.cModelo)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cNumeroCliente)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cMarca)
        Me.GroupBox2.Controls.Add(Me.cMatricula)
        Me.GroupBox2.Controls.Add(Me.cColor)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 60)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(630, 154)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Coche"
        '
        'cIDCoche
        '
        Me.cIDCoche.BackColor = System.Drawing.SystemColors.Control
        Me.cIDCoche.Location = New System.Drawing.Point(306, 83)
        Me.cIDCoche.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cIDCoche.Name = "cIDCoche"
        Me.cIDCoche.Size = New System.Drawing.Size(0, 26)
        Me.cIDCoche.TabIndex = 38
        '
        'cModelo
        '
        Me.cModelo.Location = New System.Drawing.Point(446, 89)
        Me.cModelo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cModelo.Name = "cModelo"
        Me.cModelo.ReadOnly = True
        Me.cModelo.Size = New System.Drawing.Size(148, 26)
        Me.cModelo.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(369, 94)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 20)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "Modelo:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(27, 54)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 20)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Matricula:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(369, 54)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 20)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Marca:"
        '
        'cNumeroCliente
        '
        Me.cNumeroCliente.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cNumeroCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cNumeroCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cNumeroCliente.Location = New System.Drawing.Point(501, 14)
        Me.cNumeroCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cNumeroCliente.Name = "cNumeroCliente"
        Me.cNumeroCliente.ReadOnly = True
        Me.cNumeroCliente.Size = New System.Drawing.Size(2, 19)
        Me.cNumeroCliente.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(56, 94)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 20)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Color:"
        '
        'cMarca
        '
        Me.cMarca.Location = New System.Drawing.Point(446, 49)
        Me.cMarca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cMarca.Name = "cMarca"
        Me.cMarca.ReadOnly = True
        Me.cMarca.Size = New System.Drawing.Size(148, 26)
        Me.cMarca.TabIndex = 39
        '
        'cMatricula
        '
        Me.cMatricula.Location = New System.Drawing.Point(116, 49)
        Me.cMatricula.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cMatricula.Name = "cMatricula"
        Me.cMatricula.ReadOnly = True
        Me.cMatricula.Size = New System.Drawing.Size(148, 26)
        Me.cMatricula.TabIndex = 36
        '
        'cColor
        '
        Me.cColor.Location = New System.Drawing.Point(116, 89)
        Me.cColor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cColor.Name = "cColor"
        Me.cColor.ReadOnly = True
        Me.cColor.Size = New System.Drawing.Size(148, 26)
        Me.cColor.TabIndex = 37
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
        Me.GroupBox1.Location = New System.Drawing.Point(13, 223)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(630, 265)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
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
        Me.cTelefonos.Location = New System.Drawing.Point(388, 158)
        Me.cTelefonos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cTelefonos.Name = "cTelefonos"
        Me.cTelefonos.RowHeadersVisible = False
        Me.cTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cTelefonos.Size = New System.Drawing.Size(207, 72)
        Me.cTelefonos.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(302, 163)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 20)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Telefono:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
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
        Me.Label3.Location = New System.Drawing.Point(27, 86)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Direccion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 126)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Codigo Postal:"
        '
        'cDNI
        '
        Me.cDNI.Location = New System.Drawing.Point(114, 200)
        Me.cDNI.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cDNI.Name = "cDNI"
        Me.cDNI.Size = New System.Drawing.Size(240, 26)
        Me.cDNI.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 163)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Poblacion:"
        '
        'cProvincia
        '
        Me.cProvincia.Location = New System.Drawing.Point(387, 118)
        Me.cProvincia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cProvincia.Name = "cProvincia"
        Me.cProvincia.Size = New System.Drawing.Size(206, 26)
        Me.cProvincia.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(302, 123)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Provincia."
        '
        'cPoblacion
        '
        Me.cPoblacion.Location = New System.Drawing.Point(114, 158)
        Me.cPoblacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cPoblacion.Name = "cPoblacion"
        Me.cPoblacion.Size = New System.Drawing.Size(163, 26)
        Me.cPoblacion.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 205)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 20)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "DNI:"
        '
        'cCodigoPostal
        '
        Me.cCodigoPostal.Location = New System.Drawing.Point(148, 118)
        Me.cCodigoPostal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cCodigoPostal.Name = "cCodigoPostal"
        Me.cCodigoPostal.Size = New System.Drawing.Size(128, 26)
        Me.cCodigoPostal.TabIndex = 2
        '
        'cNombreCliente
        '
        Me.cNombreCliente.Location = New System.Drawing.Point(176, 42)
        Me.cNombreCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cNombreCliente.Name = "cNombreCliente"
        Me.cNombreCliente.Size = New System.Drawing.Size(418, 26)
        Me.cNombreCliente.TabIndex = 0
        '
        'cDireccion
        '
        Me.cDireccion.Location = New System.Drawing.Point(114, 82)
        Me.cDireccion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cDireccion.Name = "cDireccion"
        Me.cDireccion.Size = New System.Drawing.Size(480, 26)
        Me.cDireccion.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cBuscarCliente, Me.ToolStripSeparator1, Me.cGuardar, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(663, 55)
        Me.ToolStrip1.TabIndex = 45
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'cGuardar
        '
        Me.cGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cGuardar.Image = Global.TallerJoaquin.My.Resources.Resources._1271966377_document_save_as
        Me.cGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cGuardar.Name = "cGuardar"
        Me.cGuardar.Size = New System.Drawing.Size(52, 52)
        Me.cGuardar.Text = "Guardar y Salir"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.TallerJoaquin.My.Resources.Resources._1271966523_edit_clear
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(52, 52)
        Me.ToolStripButton1.Text = "Limpiar Campos"
        '
        'Traspaso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 494)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Traspaso"
        Me.Text = "Traspaso"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cModelo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cNumeroCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cMarca As System.Windows.Forms.TextBox
    Friend WithEvents cMatricula As System.Windows.Forms.TextBox
    Friend WithEvents cColor As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cTelefonos As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cProvincia As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cPoblacion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents cNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents cDireccion As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cBuscarCliente As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents cIDCoche As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
