<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Facturas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cModelo = New System.Windows.Forms.TextBox
        Me.cTelefono2 = New System.Windows.Forms.TextBox
        Me.cTelefono = New System.Windows.Forms.TextBox
        Me.cProvincia = New System.Windows.Forms.TextBox
        Me.cNombreCliente = New System.Windows.Forms.TextBox
        Me.cPoblacion = New System.Windows.Forms.TextBox
        Me.cDireccion = New System.Windows.Forms.TextBox
        Me.cColor = New System.Windows.Forms.TextBox
        Me.cDNI = New System.Windows.Forms.TextBox
        Me.cMarca = New System.Windows.Forms.TextBox
        Me.cMatricula = New System.Windows.Forms.TextBox
        Me.cPOF = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cTipoPOF = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cCambiar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cOtraFecha = New System.Windows.Forms.DateTimePicker
        Me.cFecha = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.cIVA = New System.Windows.Forms.TextBox
        Me.cDescuento = New System.Windows.Forms.TextBox
        Me.cIDCoche = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cNumeroCliente = New System.Windows.Forms.TextBox
        Me.cSubTotal = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cTotalPVP = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cTotalCosto = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cTotalIVA = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RycCheckBox1 = New RYCCheckBox.RYCCheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cHoras = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cTotal = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cPrevisualizarInforme = New System.Windows.Forms.ToolStripButton
        Me.cImprimirInforme = New System.Windows.Forms.ToolStripButton
        Me.Label11 = New System.Windows.Forms.Label
        Me.RycCheckBox2 = New RYCCheckBox.RYCCheckBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.cPOF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RycCheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.RycCheckBox2)
        Me.GroupBox1.Controls.Add(Me.cModelo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cTelefono2)
        Me.GroupBox1.Controls.Add(Me.cTelefono)
        Me.GroupBox1.Controls.Add(Me.cProvincia)
        Me.GroupBox1.Controls.Add(Me.cNombreCliente)
        Me.GroupBox1.Controls.Add(Me.cPoblacion)
        Me.GroupBox1.Controls.Add(Me.cDireccion)
        Me.GroupBox1.Controls.Add(Me.cColor)
        Me.GroupBox1.Controls.Add(Me.cDNI)
        Me.GroupBox1.Controls.Add(Me.cMarca)
        Me.GroupBox1.Controls.Add(Me.cMatricula)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 52)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(403, 242)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
        '
        'cModelo
        '
        Me.cModelo.Location = New System.Drawing.Point(205, 183)
        Me.cModelo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cModelo.Name = "cModelo"
        Me.cModelo.ReadOnly = True
        Me.cModelo.Size = New System.Drawing.Size(178, 23)
        Me.cModelo.TabIndex = 38
        '
        'cTelefono2
        '
        Me.cTelefono2.Location = New System.Drawing.Point(265, 55)
        Me.cTelefono2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cTelefono2.Name = "cTelefono2"
        Me.cTelefono2.ReadOnly = True
        Me.cTelefono2.Size = New System.Drawing.Size(119, 23)
        Me.cTelefono2.TabIndex = 42
        '
        'cTelefono
        '
        Me.cTelefono.Location = New System.Drawing.Point(133, 55)
        Me.cTelefono.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cTelefono.Name = "cTelefono"
        Me.cTelefono.ReadOnly = True
        Me.cTelefono.Size = New System.Drawing.Size(127, 23)
        Me.cTelefono.TabIndex = 42
        '
        'cProvincia
        '
        Me.cProvincia.Location = New System.Drawing.Point(205, 119)
        Me.cProvincia.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cProvincia.Name = "cProvincia"
        Me.cProvincia.ReadOnly = True
        Me.cProvincia.Size = New System.Drawing.Size(178, 23)
        Me.cProvincia.TabIndex = 15
        '
        'cNombreCliente
        '
        Me.cNombreCliente.Location = New System.Drawing.Point(11, 23)
        Me.cNombreCliente.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cNombreCliente.Name = "cNombreCliente"
        Me.cNombreCliente.ReadOnly = True
        Me.cNombreCliente.Size = New System.Drawing.Size(372, 23)
        Me.cNombreCliente.TabIndex = 12
        '
        'cPoblacion
        '
        Me.cPoblacion.Location = New System.Drawing.Point(11, 119)
        Me.cPoblacion.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cPoblacion.Name = "cPoblacion"
        Me.cPoblacion.ReadOnly = True
        Me.cPoblacion.Size = New System.Drawing.Size(185, 23)
        Me.cPoblacion.TabIndex = 11
        '
        'cDireccion
        '
        Me.cDireccion.Location = New System.Drawing.Point(11, 87)
        Me.cDireccion.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cDireccion.Name = "cDireccion"
        Me.cDireccion.ReadOnly = True
        Me.cDireccion.Size = New System.Drawing.Size(372, 23)
        Me.cDireccion.TabIndex = 9
        '
        'cColor
        '
        Me.cColor.Location = New System.Drawing.Point(11, 183)
        Me.cColor.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cColor.Name = "cColor"
        Me.cColor.ReadOnly = True
        Me.cColor.Size = New System.Drawing.Size(185, 23)
        Me.cColor.TabIndex = 37
        '
        'cDNI
        '
        Me.cDNI.Location = New System.Drawing.Point(11, 55)
        Me.cDNI.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cDNI.Name = "cDNI"
        Me.cDNI.ReadOnly = True
        Me.cDNI.Size = New System.Drawing.Size(111, 23)
        Me.cDNI.TabIndex = 17
        '
        'cMarca
        '
        Me.cMarca.Location = New System.Drawing.Point(205, 151)
        Me.cMarca.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cMarca.Name = "cMarca"
        Me.cMarca.ReadOnly = True
        Me.cMarca.Size = New System.Drawing.Size(178, 23)
        Me.cMarca.TabIndex = 39
        '
        'cMatricula
        '
        Me.cMatricula.Location = New System.Drawing.Point(11, 151)
        Me.cMatricula.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cMatricula.Name = "cMatricula"
        Me.cMatricula.ReadOnly = True
        Me.cMatricula.Size = New System.Drawing.Size(185, 23)
        Me.cMatricula.TabIndex = 36
        '
        'cPOF
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cPOF.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.cPOF.Location = New System.Drawing.Point(11, 302)
        Me.cPOF.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cPOF.Name = "cPOF"
        Me.cPOF.Size = New System.Drawing.Size(941, 374)
        Me.cPOF.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cTipoPOF)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.cCambiar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cOtraFecha)
        Me.GroupBox2.Controls.Add(Me.cFecha)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cIVA)
        Me.GroupBox2.Controls.Add(Me.cDescuento)
        Me.GroupBox2.Controls.Add(Me.cIDCoche)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(422, 52)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(256, 242)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Facturacion"
        '
        'cTipoPOF
        '
        Me.cTipoPOF.Location = New System.Drawing.Point(8, 150)
        Me.cTipoPOF.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cTipoPOF.Name = "cTipoPOF"
        Me.cTipoPOF.ReadOnly = True
        Me.cTipoPOF.Size = New System.Drawing.Size(0, 23)
        Me.cTipoPOF.TabIndex = 47
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(62, 172)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 48)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Convertir en Orden de Trabajo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cCambiar
        '
        Me.cCambiar.Location = New System.Drawing.Point(62, 119)
        Me.cCambiar.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cCambiar.Name = "cCambiar"
        Me.cCambiar.Size = New System.Drawing.Size(139, 51)
        Me.cCambiar.TabIndex = 44
        Me.cCambiar.Text = "Convertir en Orden de Trabajo"
        Me.cCambiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Fecha:"
        '
        'cOtraFecha
        '
        Me.cOtraFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cOtraFecha.Location = New System.Drawing.Point(18, 131)
        Me.cOtraFecha.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cOtraFecha.Name = "cOtraFecha"
        Me.cOtraFecha.Size = New System.Drawing.Size(1, 23)
        Me.cOtraFecha.TabIndex = 0
        '
        'cFecha
        '
        Me.cFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cFecha.Location = New System.Drawing.Point(101, 27)
        Me.cFecha.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cFecha.Name = "cFecha"
        Me.cFecha.Size = New System.Drawing.Size(132, 23)
        Me.cFecha.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Fanquicia:"
        '
        'cIVA
        '
        Me.cIVA.Location = New System.Drawing.Point(101, 59)
        Me.cIVA.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cIVA.Name = "cIVA"
        Me.cIVA.Size = New System.Drawing.Size(132, 23)
        Me.cIVA.TabIndex = 1
        '
        'cDescuento
        '
        Me.cDescuento.Location = New System.Drawing.Point(101, 87)
        Me.cDescuento.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cDescuento.Name = "cDescuento"
        Me.cDescuento.Size = New System.Drawing.Size(132, 23)
        Me.cDescuento.TabIndex = 2
        '
        'cIDCoche
        '
        Me.cIDCoche.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cIDCoche.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cIDCoche.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cIDCoche.Location = New System.Drawing.Point(178, 18)
        Me.cIDCoche.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cIDCoche.Name = "cIDCoche"
        Me.cIDCoche.ReadOnly = True
        Me.cIDCoche.Size = New System.Drawing.Size(2, 16)
        Me.cIDCoche.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "% IVA:"
        '
        'cNumeroCliente
        '
        Me.cNumeroCliente.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cNumeroCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cNumeroCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.cNumeroCliente.Location = New System.Drawing.Point(850, 370)
        Me.cNumeroCliente.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cNumeroCliente.Name = "cNumeroCliente"
        Me.cNumeroCliente.ReadOnly = True
        Me.cNumeroCliente.Size = New System.Drawing.Size(2, 16)
        Me.cNumeroCliente.TabIndex = 14
        '
        'cSubTotal
        '
        Me.cSubTotal.Location = New System.Drawing.Point(110, 151)
        Me.cSubTotal.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cSubTotal.Name = "cSubTotal"
        Me.cSubTotal.ReadOnly = True
        Me.cSubTotal.Size = New System.Drawing.Size(132, 23)
        Me.cSubTotal.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 154)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "SubTotal:"
        '
        'cTotalPVP
        '
        Me.cTotalPVP.Location = New System.Drawing.Point(110, 91)
        Me.cTotalPVP.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cTotalPVP.Name = "cTotalPVP"
        Me.cTotalPVP.ReadOnly = True
        Me.cTotalPVP.Size = New System.Drawing.Size(132, 23)
        Me.cTotalPVP.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 94)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Total PVP:"
        '
        'cTotalCosto
        '
        Me.cTotalCosto.Location = New System.Drawing.Point(110, 59)
        Me.cTotalCosto.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cTotalCosto.Name = "cTotalCosto"
        Me.cTotalCosto.ReadOnly = True
        Me.cTotalCosto.Size = New System.Drawing.Size(132, 23)
        Me.cTotalCosto.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 62)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Total Costo:"
        '
        'cTotalIVA
        '
        Me.cTotalIVA.Location = New System.Drawing.Point(110, 119)
        Me.cTotalIVA.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cTotalIVA.Name = "cTotalIVA"
        Me.cTotalIVA.ReadOnly = True
        Me.cTotalIVA.Size = New System.Drawing.Size(132, 23)
        Me.cTotalIVA.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 123)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 17)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "IVA:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cTotalIVA)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cHoras)
        Me.GroupBox3.Controls.Add(Me.cTotalCosto)
        Me.GroupBox3.Controls.Add(Me.cTotalPVP)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cTotal)
        Me.GroupBox3.Controls.Add(Me.cSubTotal)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(686, 52)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(267, 242)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totales"
        '
        'RycCheckBox1
        '
        Me.RycCheckBox1.ColorMarcado = System.Drawing.Color.Blue
        Me.RycCheckBox1.Location = New System.Drawing.Point(360, 207)
        Me.RycCheckBox1.Marcado = False
        Me.RycCheckBox1.Name = "RycCheckBox1"
        Me.RycCheckBox1.Size = New System.Drawing.Size(23, 23)
        Me.RycCheckBox1.TabIndex = 45
        Me.RycCheckBox1.Text = "RycCheckBox1"
        Me.RycCheckBox1.TipoMarcado = RYCCheckBox.RYCCheckBox.eTipoMarcado.Tick
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(202, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 17)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Ocultar los Repuestos:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(40, 182)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 17)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Total:"
        '
        'cHoras
        '
        Me.cHoras.Location = New System.Drawing.Point(110, 27)
        Me.cHoras.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cHoras.Name = "cHoras"
        Me.cHoras.ReadOnly = True
        Me.cHoras.Size = New System.Drawing.Size(132, 23)
        Me.cHoras.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 30)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 17)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Total Horas:"
        '
        'cTotal
        '
        Me.cTotal.Location = New System.Drawing.Point(110, 180)
        Me.cTotal.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cTotal.Name = "cTotal"
        Me.cTotal.ReadOnly = True
        Me.cTotal.Size = New System.Drawing.Size(132, 23)
        Me.cTotal.TabIndex = 40
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cGuardar, Me.ToolStripSeparator1, Me.cPrevisualizarInforme, Me.cImprimirInforme})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(965, 55)
        Me.ToolStrip1.TabIndex = 45
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
        Me.cGuardar.Text = "ToolStripButton1"
        Me.cGuardar.ToolTipText = "Guardar Cambios Realizados"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'cPrevisualizarInforme
        '
        Me.cPrevisualizarInforme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cPrevisualizarInforme.Image = Global.TallerJoaquin.My.Resources.Resources.VerFactura
        Me.cPrevisualizarInforme.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cPrevisualizarInforme.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cPrevisualizarInforme.Name = "cPrevisualizarInforme"
        Me.cPrevisualizarInforme.Size = New System.Drawing.Size(52, 52)
        Me.cPrevisualizarInforme.Text = "ToolStripButton2"
        Me.cPrevisualizarInforme.ToolTipText = "Previsualizar Informe"
        '
        'cImprimirInforme
        '
        Me.cImprimirInforme.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cImprimirInforme.Image = Global.TallerJoaquin.My.Resources.Resources.ImprimirFactura
        Me.cImprimirInforme.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cImprimirInforme.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cImprimirInforme.Name = "cImprimirInforme"
        Me.cImprimirInforme.Size = New System.Drawing.Size(52, 52)
        Me.cImprimirInforme.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cImprimirInforme.ToolTipText = "Imprimir Informe"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 210)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 17)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "Ocultar la Mano Obra:"
        '
        'RycCheckBox2
        '
        Me.RycCheckBox2.ColorMarcado = System.Drawing.Color.Blue
        Me.RycCheckBox2.Location = New System.Drawing.Point(166, 207)
        Me.RycCheckBox2.Marcado = False
        Me.RycCheckBox2.Name = "RycCheckBox2"
        Me.RycCheckBox2.Size = New System.Drawing.Size(23, 23)
        Me.RycCheckBox2.TabIndex = 45
        Me.RycCheckBox2.Text = "RycCheckBox1"
        Me.RycCheckBox2.TipoMarcado = RYCCheckBox.RYCCheckBox.eTipoMarcado.Tick
        '
        'Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 689)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cPOF)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cNumeroCliente)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Facturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cPOF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cModelo As System.Windows.Forms.TextBox
    Friend WithEvents cMarca As System.Windows.Forms.TextBox
    Friend WithEvents cMatricula As System.Windows.Forms.TextBox
    Friend WithEvents cColor As System.Windows.Forms.TextBox
    Friend WithEvents cDNI As System.Windows.Forms.TextBox
    Friend WithEvents cProvincia As System.Windows.Forms.TextBox
    Friend WithEvents cPoblacion As System.Windows.Forms.TextBox
    Friend WithEvents cNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents cDireccion As System.Windows.Forms.TextBox
    Friend WithEvents cTelefono As System.Windows.Forms.TextBox
    Friend WithEvents cPOF As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cNumeroCliente As System.Windows.Forms.TextBox
    Friend WithEvents cIDCoche As System.Windows.Forms.TextBox
    Friend WithEvents cTelefono2 As System.Windows.Forms.TextBox
    Friend WithEvents cDescuento As System.Windows.Forms.TextBox
    Friend WithEvents cIVA As System.Windows.Forms.TextBox
    Friend WithEvents cFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cTotalCosto As System.Windows.Forms.TextBox
    Friend WithEvents cTotalPVP As System.Windows.Forms.TextBox
    Friend WithEvents cTotalIVA As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cCambiar As System.Windows.Forms.Button
    Friend WithEvents cHoras As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cTipoPOF As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents cGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cPrevisualizarInforme As System.Windows.Forms.ToolStripButton
    Friend WithEvents cImprimirInforme As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cTotal As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cOtraFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents RycCheckBox1 As RYCCheckBox.RYCCheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RycCheckBox2 As RYCCheckBox.RYCCheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
