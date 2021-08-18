<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarCliente))
        Me.cClientes = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cBuscar = New System.Windows.Forms.TextBox
        Me.cBuscarPor = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cBuscarEn = New System.Windows.Forms.ComboBox
        Me.cCancelar = New System.Windows.Forms.Button
        Me.cAceptar = New System.Windows.Forms.Button
        CType(Me.cClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.cClientes.Location = New System.Drawing.Point(2, 42)
        Me.cClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.cClientes.Name = "cClientes"
        Me.cClientes.RowHeadersVisible = False
        Me.cClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cClientes.Size = New System.Drawing.Size(903, 319)
        Me.cClientes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Buscar por:"
        '
        'cBuscar
        '
        Me.cBuscar.Location = New System.Drawing.Point(72, 11)
        Me.cBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.cBuscar.Name = "cBuscar"
        Me.cBuscar.Size = New System.Drawing.Size(196, 21)
        Me.cBuscar.TabIndex = 2
        '
        'cBuscarPor
        '
        Me.cBuscarPor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBuscarPor.FormattingEnabled = True
        Me.cBuscarPor.Items.AddRange(New Object() {"El Principio", "El Final", "Contenido"})
        Me.cBuscarPor.Location = New System.Drawing.Point(353, 11)
        Me.cBuscarPor.Margin = New System.Windows.Forms.Padding(4)
        Me.cBuscarPor.Name = "cBuscarPor"
        Me.cBuscarPor.Size = New System.Drawing.Size(140, 23)
        Me.cBuscarPor.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(500, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Buscar en:"
        '
        'cBuscarEn
        '
        Me.cBuscarEn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cBuscarEn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBuscarEn.FormattingEnabled = True
        Me.cBuscarEn.Items.AddRange(New Object() {"Nombre Cliente", "Nombre Comercial", "DNI", "Codigo Postal", "Poblacion", "Provincia", ""})
        Me.cBuscarEn.Location = New System.Drawing.Point(578, 11)
        Me.cBuscarEn.Margin = New System.Windows.Forms.Padding(4)
        Me.cBuscarEn.Name = "cBuscarEn"
        Me.cBuscarEn.Size = New System.Drawing.Size(127, 23)
        Me.cBuscarEn.TabIndex = 3
        '
        'cCancelar
        '
        Me.cCancelar.Location = New System.Drawing.Point(714, 9)
        Me.cCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.cCancelar.Name = "cCancelar"
        Me.cCancelar.Size = New System.Drawing.Size(88, 26)
        Me.cCancelar.TabIndex = 4
        Me.cCancelar.Text = "Cancelar"
        Me.cCancelar.UseVisualStyleBackColor = True
        '
        'cAceptar
        '
        Me.cAceptar.Location = New System.Drawing.Point(808, 9)
        Me.cAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.cAceptar.Name = "cAceptar"
        Me.cAceptar.Size = New System.Drawing.Size(88, 26)
        Me.cAceptar.TabIndex = 5
        Me.cAceptar.Text = "Aceptar"
        Me.cAceptar.UseVisualStyleBackColor = True
        '
        'BuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 364)
        Me.Controls.Add(Me.cAceptar)
        Me.Controls.Add(Me.cCancelar)
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
        Me.Name = "BuscarCliente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Cliente"
        CType(Me.cClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cClientes As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cBuscar As System.Windows.Forms.TextBox
    Friend WithEvents cBuscarPor As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cBuscarEn As System.Windows.Forms.ComboBox
    Friend WithEvents cCancelar As System.Windows.Forms.Button
    Friend WithEvents cAceptar As System.Windows.Forms.Button

End Class
