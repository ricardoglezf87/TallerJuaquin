<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cBuscarFacturas = New System.Windows.Forms.Button()
        Me.cClientes = New System.Windows.Forms.Button()
        Me.cNuevaOrdenTrabajo = New System.Windows.Forms.Button()
        Me.cBuscarHistorial = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cFondo = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cSalir = New System.Windows.Forms.Button()
        Me.cCompras = New System.Windows.Forms.Button()
        Me.GenManRep = New System.Windows.Forms.Button()
        Me.GenBalan = New System.Windows.Forms.Button()
        Me.cOpciones = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.cFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cBuscarFacturas)
        Me.Panel1.Controls.Add(Me.cClientes)
        Me.Panel1.Controls.Add(Me.cNuevaOrdenTrabajo)
        Me.Panel1.Controls.Add(Me.cBuscarHistorial)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(205, 484)
        Me.Panel1.TabIndex = 5
        '
        'cBuscarFacturas
        '
        Me.cBuscarFacturas.Image = Global.TallerJoaquin.My.Resources.Resources.BuscarFactura
        Me.cBuscarFacturas.Location = New System.Drawing.Point(23, 349)
        Me.cBuscarFacturas.Margin = New System.Windows.Forms.Padding(4)
        Me.cBuscarFacturas.Name = "cBuscarFacturas"
        Me.cBuscarFacturas.Size = New System.Drawing.Size(160, 106)
        Me.cBuscarFacturas.TabIndex = 3
        Me.cBuscarFacturas.Text = "Buscar Factura"
        Me.cBuscarFacturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cBuscarFacturas.UseVisualStyleBackColor = True
        '
        'cClientes
        '
        Me.cClientes.Image = Global.TallerJoaquin.My.Resources.Resources._1269047479_userconfig
        Me.cClientes.Location = New System.Drawing.Point(23, 10)
        Me.cClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.cClientes.Name = "cClientes"
        Me.cClientes.Size = New System.Drawing.Size(160, 106)
        Me.cClientes.TabIndex = 0
        Me.cClientes.Text = "Gestion de Clientes"
        Me.cClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cClientes.UseVisualStyleBackColor = True
        '
        'cNuevaOrdenTrabajo
        '
        Me.cNuevaOrdenTrabajo.Image = Global.TallerJoaquin.My.Resources.Resources._1269094726_CarRepair
        Me.cNuevaOrdenTrabajo.Location = New System.Drawing.Point(23, 124)
        Me.cNuevaOrdenTrabajo.Margin = New System.Windows.Forms.Padding(4)
        Me.cNuevaOrdenTrabajo.Name = "cNuevaOrdenTrabajo"
        Me.cNuevaOrdenTrabajo.Size = New System.Drawing.Size(160, 106)
        Me.cNuevaOrdenTrabajo.TabIndex = 1
        Me.cNuevaOrdenTrabajo.Text = "Orden de Trabajo"
        Me.cNuevaOrdenTrabajo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cNuevaOrdenTrabajo.UseVisualStyleBackColor = True
        '
        'cBuscarHistorial
        '
        Me.cBuscarHistorial.Image = Global.TallerJoaquin.My.Resources.Resources.BuscarHistorial
        Me.cBuscarHistorial.Location = New System.Drawing.Point(23, 236)
        Me.cBuscarHistorial.Margin = New System.Windows.Forms.Padding(4)
        Me.cBuscarHistorial.Name = "cBuscarHistorial"
        Me.cBuscarHistorial.Size = New System.Drawing.Size(160, 106)
        Me.cBuscarHistorial.TabIndex = 2
        Me.cBuscarHistorial.Text = "Buscar Historial"
        Me.cBuscarHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cBuscarHistorial.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.cFondo)
        Me.Panel2.Location = New System.Drawing.Point(199, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(559, 484)
        Me.Panel2.TabIndex = 5
        '
        'cFondo
        '
        Me.cFondo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cFondo.Location = New System.Drawing.Point(4, 0)
        Me.cFondo.Margin = New System.Windows.Forms.Padding(4)
        Me.cFondo.Name = "cFondo"
        Me.cFondo.Size = New System.Drawing.Size(551, 484)
        Me.cFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cFondo.TabIndex = 0
        Me.cFondo.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cSalir)
        Me.Panel3.Controls.Add(Me.cCompras)
        Me.Panel3.Controls.Add(Me.GenManRep)
        Me.Panel3.Controls.Add(Me.GenBalan)
        Me.Panel3.Controls.Add(Me.cOpciones)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(753, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(201, 484)
        Me.Panel3.TabIndex = 6
        '
        'cSalir
        '
        Me.cSalir.Image = Global.TallerJoaquin.My.Resources.Resources._1269095448_exit
        Me.cSalir.Location = New System.Drawing.Point(26, 407)
        Me.cSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.cSalir.Name = "cSalir"
        Me.cSalir.Size = New System.Drawing.Size(160, 48)
        Me.cSalir.TabIndex = 9
        Me.cSalir.Text = "Salir"
        Me.cSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cSalir.UseVisualStyleBackColor = True
        '
        'cCompras
        '
        Me.cCompras.Image = Global.TallerJoaquin.My.Resources.Resources._1273320305_advancedsettings
        Me.cCompras.Location = New System.Drawing.Point(26, 124)
        Me.cCompras.Margin = New System.Windows.Forms.Padding(4)
        Me.cCompras.Name = "cCompras"
        Me.cCompras.Size = New System.Drawing.Size(160, 106)
        Me.cCompras.TabIndex = 11
        Me.cCompras.Text = "Gestion de Compra"
        Me.cCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cCompras.UseVisualStyleBackColor = True
        '
        'GenManRep
        '
        Me.GenManRep.Image = Global.TallerJoaquin.My.Resources.Resources._1273320343_Calendar
        Me.GenManRep.Location = New System.Drawing.Point(26, 236)
        Me.GenManRep.Margin = New System.Windows.Forms.Padding(4)
        Me.GenManRep.Name = "GenManRep"
        Me.GenManRep.Size = New System.Drawing.Size(160, 106)
        Me.GenManRep.TabIndex = 11
        Me.GenManRep.Text = "Agenda de Trabajo"
        Me.GenManRep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GenManRep.UseVisualStyleBackColor = True
        '
        'GenBalan
        '
        Me.GenBalan.Image = Global.TallerJoaquin.My.Resources.Resources._1272029747_bar_chart
        Me.GenBalan.Location = New System.Drawing.Point(26, 10)
        Me.GenBalan.Margin = New System.Windows.Forms.Padding(4)
        Me.GenBalan.Name = "GenBalan"
        Me.GenBalan.Size = New System.Drawing.Size(160, 106)
        Me.GenBalan.TabIndex = 10
        Me.GenBalan.Text = "Generar Balance"
        Me.GenBalan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GenBalan.UseVisualStyleBackColor = True
        '
        'cOpciones
        '
        Me.cOpciones.Image = Global.TallerJoaquin.My.Resources.Resources._1269095529_smserver
        Me.cOpciones.Location = New System.Drawing.Point(26, 349)
        Me.cOpciones.Margin = New System.Windows.Forms.Padding(4)
        Me.cOpciones.Name = "cOpciones"
        Me.cOpciones.Size = New System.Drawing.Size(160, 48)
        Me.cOpciones.TabIndex = 8
        Me.cOpciones.Text = "Opciones"
        Me.cOpciones.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cOpciones.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 484)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.cFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cClientes As System.Windows.Forms.Button
    Friend WithEvents cNuevaOrdenTrabajo As System.Windows.Forms.Button
    Friend WithEvents cBuscarHistorial As System.Windows.Forms.Button
    Friend WithEvents cBuscarFacturas As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cFondo As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cSalir As System.Windows.Forms.Button
    Friend WithEvents GenManRep As System.Windows.Forms.Button
    Friend WithEvents GenBalan As System.Windows.Forms.Button
    Friend WithEvents cOpciones As System.Windows.Forms.Button
    Friend WithEvents cCompras As System.Windows.Forms.Button
End Class
