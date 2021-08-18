<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarHistorial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarHistorial))
        Me.cHasta = New System.Windows.Forms.DateTimePicker
        Me.cDesde = New System.Windows.Forms.DateTimePicker
        Me.cAceptar = New System.Windows.Forms.Button
        Me.cCancelar = New System.Windows.Forms.Button
        Me.cBuscarporfecha = New System.Windows.Forms.ComboBox
        Me.cBuscarEn = New System.Windows.Forms.ComboBox
        Me.cBuscarPor = New System.Windows.Forms.ComboBox
        Me.cBuscar = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cClientes = New System.Windows.Forms.DataGridView
        CType(Me.cClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cHasta
        '
        Me.cHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cHasta.Location = New System.Drawing.Point(174, 8)
        Me.cHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.cHasta.Name = "cHasta"
        Me.cHasta.Size = New System.Drawing.Size(92, 21)
        Me.cHasta.TabIndex = 26
        '
        'cDesde
        '
        Me.cDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cDesde.Location = New System.Drawing.Point(70, 8)
        Me.cDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.cDesde.Name = "cDesde"
        Me.cDesde.Size = New System.Drawing.Size(92, 21)
        Me.cDesde.TabIndex = 27
        '
        'cAceptar
        '
        Me.cAceptar.Location = New System.Drawing.Point(808, 6)
        Me.cAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cAceptar.Name = "cAceptar"
        Me.cAceptar.Size = New System.Drawing.Size(88, 26)
        Me.cAceptar.TabIndex = 25
        Me.cAceptar.Text = "Aceptar"
        Me.cAceptar.UseVisualStyleBackColor = True
        '
        'cCancelar
        '
        Me.cCancelar.Location = New System.Drawing.Point(712, 6)
        Me.cCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cCancelar.Name = "cCancelar"
        Me.cCancelar.Size = New System.Drawing.Size(88, 26)
        Me.cCancelar.TabIndex = 24
        Me.cCancelar.Text = "Cancelar"
        Me.cCancelar.UseVisualStyleBackColor = True
        '
        'cBuscarporfecha
        '
        Me.cBuscarporfecha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cBuscarporfecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBuscarporfecha.FormattingEnabled = True
        Me.cBuscarporfecha.Items.AddRange(New Object() {"Exacta", "Desde", "Hasta", "Entre"})
        Me.cBuscarporfecha.Location = New System.Drawing.Point(352, 8)
        Me.cBuscarporfecha.Margin = New System.Windows.Forms.Padding(4)
        Me.cBuscarporfecha.Name = "cBuscarporfecha"
        Me.cBuscarporfecha.Size = New System.Drawing.Size(140, 23)
        Me.cBuscarporfecha.TabIndex = 22
        '
        'cBuscarEn
        '
        Me.cBuscarEn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cBuscarEn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBuscarEn.FormattingEnabled = True
        Me.cBuscarEn.Items.AddRange(New Object() {"Matricula", "Numero Factura", "Marca", "Modelo", "Color", "Fecha Entrada", "Fecha Salida", "Estado", "Observaciones"})
        Me.cBuscarEn.Location = New System.Drawing.Point(578, 8)
        Me.cBuscarEn.Margin = New System.Windows.Forms.Padding(4)
        Me.cBuscarEn.Name = "cBuscarEn"
        Me.cBuscarEn.Size = New System.Drawing.Size(127, 23)
        Me.cBuscarEn.TabIndex = 21
        '
        'cBuscarPor
        '
        Me.cBuscarPor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cBuscarPor.FormattingEnabled = True
        Me.cBuscarPor.Items.AddRange(New Object() {"El Principio", "El Final", "Contenido"})
        Me.cBuscarPor.Location = New System.Drawing.Point(352, 8)
        Me.cBuscarPor.Margin = New System.Windows.Forms.Padding(4)
        Me.cBuscarPor.Name = "cBuscarPor"
        Me.cBuscarPor.Size = New System.Drawing.Size(140, 23)
        Me.cBuscarPor.TabIndex = 23
        '
        'cBuscar
        '
        Me.cBuscar.Location = New System.Drawing.Point(70, 8)
        Me.cBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cBuscar.Name = "cBuscar"
        Me.cBuscar.Size = New System.Drawing.Size(196, 21)
        Me.cBuscar.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(500, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Buscar en:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(273, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Buscar por:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Buscar:"
        '
        'cClientes
        '
        Me.cClientes.AllowUserToAddRows = False
        Me.cClientes.AllowUserToDeleteRows = False
        Me.cClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.cClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.cClientes.Location = New System.Drawing.Point(0, 39)
        Me.cClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.cClientes.Name = "cClientes"
        Me.cClientes.RowHeadersVisible = False
        Me.cClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cClientes.Size = New System.Drawing.Size(903, 319)
        Me.cClientes.TabIndex = 16
        '
        'BuscarHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 364)
        Me.Controls.Add(Me.cHasta)
        Me.Controls.Add(Me.cDesde)
        Me.Controls.Add(Me.cAceptar)
        Me.Controls.Add(Me.cCancelar)
        Me.Controls.Add(Me.cBuscarporfecha)
        Me.Controls.Add(Me.cBuscarEn)
        Me.Controls.Add(Me.cBuscarPor)
        Me.Controls.Add(Me.cBuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cClientes)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BuscarHistorial"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Historial"
        CType(Me.cClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents cDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents cAceptar As System.Windows.Forms.Button
    Friend WithEvents cCancelar As System.Windows.Forms.Button
    Friend WithEvents cBuscarporfecha As System.Windows.Forms.ComboBox
    Friend WithEvents cBuscarEn As System.Windows.Forms.ComboBox
    Friend WithEvents cBuscarPor As System.Windows.Forms.ComboBox
    Friend WithEvents cBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cClientes As System.Windows.Forms.DataGridView

End Class
