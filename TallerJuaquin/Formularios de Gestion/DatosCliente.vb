Imports Masked
Imports DataBaseLib

Public Class DatosCliente
    Private binDatosCliente As New BindingSource
    Private binDatosTelefono As New BindingSource

#Region "FuncionesSecundarias"

    Private Sub EnlaceDatosCliente()

        cNumeroCliente.DataBindings.Add("Text", binDatosCliente, "IDCliente")
        cNombreCliente.DataBindings.Add("Text", binDatosCliente, "NombreCliente")
        cNombreComercial.DataBindings.Add("Text", binDatosCliente, "NombreComercial")
        cDireccion.DataBindings.Add("Text", binDatosCliente, "Direccion")
        cPoblacion.DataBindings.Add("Text", binDatosCliente, "Poblacion")
        cProvincia.DataBindings.Add("Text", binDatosCliente, "Provincia")
        cCodigoPostal.DataBindings.Add("Text", binDatosCliente, "CP")
        cDNI.DataBindings.Add("Text", binDatosCliente, "DNI")
        cEmail.DataBindings.Add("Text", binDatosCliente, "Email")
        cComentario.DataBindings.Add("Text", binDatosCliente, "Comentario")
        CheckBox1.DataBindings.Add("Checked", binDatosCliente, "Aseguradora")

        cTelefonos.AutoGenerateColumns = False
        cTelefonos.DataSource = binDatosTelefono

        If Not cNumeroCliente.Text = String.Empty Then
            binDatosTelefono.Filter = "IDCliente=" + cNumeroCliente.Text
        End If

        cTelefonos.Columns.Clear()

        Using TC As New DataGridViewTextBoxColumn()
            TC.HeaderText = "IDTelefonoCliente"
            TC.Name = "IDTelefonoCliente"
            TC.DataPropertyName = "IDTelefonoCliente"
            cTelefonos.Columns.Add(TC)
            TC.Visible = False
        End Using

        Using IDC As New DataGridViewTextBoxColumn
            IDC.HeaderText = "IDCliente"
            IDC.Name = "IDCliente"
            IDC.DataPropertyName = "IDCliente"
            IDC.Visible = False
            cTelefonos.Columns.Add(IDC)
        End Using

        Using Num As New MaskedTextColumn
            Num.Mascara = "(000)00-00-00"
            Num.HeaderText = "Numero"
            Num.DataPropertyName = "Numero"
            Num.Name = "Numero"
            cTelefonos.Columns.Add(Num)
        End Using

        If Not cNumeroCliente.Text = String.Empty Then
            dsDatos.TelefonoCliente.IDClienteColumn.DefaultValue = cNumeroCliente.Text
        End If

    End Sub

    Private Sub CrearCocheTab(ByVal Numero As Integer)

        If Numero = 0 Then

            TabControl1.TabPages.Add(Me.TabPage2)

        Else

            TabControl1.TabPages.Add("Coche" + Numero.ToString)
            TabControl1.TabPages(Numero + 1).UseVisualStyleBackColor = True

            '
            'cIDCoche
            '
            Dim cIDCoche As New TextBox
            cIDCoche.Location = TabControl1.TabPages(1).Controls("cIDCoche0").Location
            cIDCoche.Name = "cIDCoche" + Numero.ToString
            cIDCoche.Size = TabControl1.TabPages(1).Controls("cIDCoche0").Size
            cIDCoche.TabIndex = TabControl1.TabPages(1).Controls("cIDCoche0").TabIndex
            Me.TabControl1.TabPages(Numero + 1).Controls.Add(cIDCoche)

            '
            'Label11
            '
            Dim Label11 As New Label
            Label11.AutoSize = CType(TabControl1.TabPages(1).Controls("Label11"), Label).AutoSize
            Label11.Location = TabControl1.TabPages(1).Controls("Label11").Location
            Label11.Name = "Label11" + Numero.ToString
            Label11.Size = TabControl1.TabPages(1).Controls("Label11").Size
            Label11.TabIndex = TabControl1.TabPages(1).Controls("Label11").TabIndex
            Label11.Text = TabControl1.TabPages(1).Controls("Label11").Text
            Me.TabControl1.TabPages(Numero + 1).Controls.Add(Label11)

            '
            'cMatricula
            '
            Dim cMatricula As New TextBox
            cMatricula.Location = TabControl1.TabPages(1).Controls("cMatricula0").Location
            cMatricula.Name = "cMatricula" + Numero.ToString
            cMatricula.Size = TabControl1.TabPages(1).Controls("cMatricula0").Size
            cMatricula.TabIndex = TabControl1.TabPages(1).Controls("cMatricula0").TabIndex
            Me.TabControl1.TabPages(Numero + 1).Controls.Add(cMatricula)
            '
            'cColor
            '
            Dim cColor As New TextBox
            cColor.Location = TabControl1.TabPages(1).Controls("cColor0").Location
            cColor.Name = "cColor" + Numero.ToString
            cColor.Size = TabControl1.TabPages(1).Controls("cColor0").Size
            cColor.TabIndex = TabControl1.TabPages(1).Controls("cColor0").TabIndex
            Me.TabControl1.TabPages(Numero + 1).Controls.Add(cColor)
            '
            'cModelo
            '
            Dim cModelo As New TextBox
            cModelo.Location = TabControl1.TabPages(1).Controls("cModelo0").Location
            cModelo.Name = "cModelo" + Numero.ToString
            cModelo.Size = TabControl1.TabPages(1).Controls("cModelo0").Size
            cModelo.TabIndex = TabControl1.TabPages(1).Controls("cModelo0").TabIndex
            Me.TabControl1.TabPages(Numero + 1).Controls.Add(cModelo)
            '
            'cMarca
            '
            Dim cMarca As New TextBox
            cMarca.Location = TabControl1.TabPages(1).Controls("cMarca0").Location
            cMarca.Name = "cMarca" + Numero.ToString
            cMarca.Size = TabControl1.TabPages(1).Controls("cMarca0").Size
            cMarca.TabIndex = TabControl1.TabPages(1).Controls("cMarca0").TabIndex
            Me.TabControl1.TabPages(Numero + 1).Controls.Add(cMarca)
            '
            'Label15
            '
            Dim Label15 As New Label
            Label15.AutoSize = CType(TabControl1.TabPages(1).Controls("Label15"), Label).AutoSize
            Label15.Location = TabControl1.TabPages(1).Controls("Label15").Location
            Label15.Name = "Label15" + Numero.ToString
            Label15.Size = TabControl1.TabPages(1).Controls("Label15").Size
            Label15.TabIndex = TabControl1.TabPages(1).Controls("Label15").TabIndex
            Label15.Text = TabControl1.TabPages(1).Controls("Label15").Text
            Me.TabControl1.TabPages(Numero + 1).Controls.Add(Label15)
            '
            'Label12
            '
            Dim Label12 As New Label
            Label12.AutoSize = CType(TabControl1.TabPages(1).Controls("Label12"), Label).AutoSize
            Label12.Location = TabControl1.TabPages(1).Controls("Label12").Location
            Label12.Name = "Label12" + Numero.ToString
            Label12.Size = TabControl1.TabPages(1).Controls("Label12").Size
            Label12.TabIndex = TabControl1.TabPages(1).Controls("Label12").TabIndex
            Label12.Text = TabControl1.TabPages(1).Controls("Label12").Text
            Me.TabControl1.TabPages(Numero + 1).Controls.Add(Label12)
            '
            'Label14
            '
            Dim Label14 As New Label
            Label14.AutoSize = CType(TabControl1.TabPages(1).Controls("Label14"), Label).AutoSize
            Label14.Location = TabControl1.TabPages(1).Controls("Label14").Location
            Label14.Name = "Label14" + Numero.ToString
            Label14.Size = TabControl1.TabPages(1).Controls("Label14").Size
            Label14.TabIndex = TabControl1.TabPages(1).Controls("Label14").TabIndex
            Label14.Text = TabControl1.TabPages(1).Controls("Label14").Text
            Me.TabControl1.TabPages(Numero + 1).Controls.Add(Label14)
            '
            'Label13
            '
            Dim Label13 As New Label
            Label13.AutoSize = CType(TabControl1.TabPages(1).Controls("Label13"), Label).AutoSize
            Label13.Location = TabControl1.TabPages(1).Controls("Label13").Location
            Label13.Name = "Label13" + Numero.ToString
            Label13.Size = TabControl1.TabPages(1).Controls("Label13").Size
            Label13.TabIndex = TabControl1.TabPages(1).Controls("Label13").TabIndex
            Label13.Text = TabControl1.TabPages(1).Controls("Label13").Text
            Me.TabControl1.TabPages(Numero + 1).Controls.Add(Label13)
            '
            'Label16
            '
            Dim Label16 As New Label
            Label16.AutoSize = CType(TabControl1.TabPages(1).Controls("Label16"), Label).AutoSize
            Label16.Location = TabControl1.TabPages(1).Controls("Label16").Location
            Label16.Name = "Label16" + Numero.ToString
            Label16.Size = TabControl1.TabPages(1).Controls("Label16").Size
            Label16.TabIndex = TabControl1.TabPages(1).Controls("Label16").TabIndex
            Label16.Text = TabControl1.TabPages(1).Controls("Label16").Text
            Me.TabControl1.TabPages(Numero + 1).Controls.Add(Label16)
            '
            'cHistorial
            '
            Dim cHistorial As New DataGridView
            cHistorial.ColumnHeadersHeightSizeMode = cHistorial0.ColumnHeadersHeightSizeMode
            cHistorial.Location = cHistorial0.Location
            cHistorial.Name = "cHistorial" + Numero.ToString
            cHistorial.Size = cHistorial0.Size
            cHistorial.TabIndex = cHistorial0.TabIndex
            cHistorial.AllowUserToAddRows = cHistorial0.AllowUserToAddRows
            cHistorial.RowHeadersVisible = cHistorial0.RowHeadersVisible
            cHistorial.EditMode = cHistorial0.EditMode
            cHistorial.SelectionMode = cHistorial0.SelectionMode
            cHistorial.AutoSizeColumnsMode = cHistorial0.AutoSizeColumnsMode
            cHistorial.AllowUserToDeleteRows = cHistorial0.AllowUserToDeleteRows
            Me.TabControl1.TabPages(Numero + 1).Controls.Add(cHistorial)

            AddHandler cHistorial.CellDoubleClick, AddressOf cHistorial0_CellDoubleClick

        End If

    End Sub

    Private Sub EnlaceDatosCocheCliente(ByVal Num As Integer)
        With TabControl1.TabPages(Num + 1)
            Dim binDatosCoche As New BindingSource
            binDatosCoche.DataSource = dsDatos.Coche
            binDatosCoche.Filter = "IDCliente=" + cNumeroCliente.Text
            .DataBindings.Add("Text", binDatosCoche, "Matricula")
            .Controls("cIDCoche" + Num.ToString).DataBindings.Add("Text", binDatosCoche, "IDCoche")
            .Controls("cMatricula" + Num.ToString).DataBindings.Add("Text", binDatosCoche, "Matricula")
            .Controls("cMarca" + Num.ToString).DataBindings.Add("Text", binDatosCoche, "Marca")
            .Controls("cModelo" + Num.ToString).DataBindings.Add("Text", binDatosCoche, "Modelo")
            .Controls("cColor" + Num.ToString).DataBindings.Add("Text", binDatosCoche, "Color")

            If Num > 0 Then
                Dim bn As BindingSource = .Controls("cIDCoche" + Num.ToString).DataBindings(0).DataSource
                For i As Integer = 1 To Num
                    bn.MoveNext()
                Next
            End If

            Dim ID As Integer

            ID = CType(dsDatos.Coche.Select("IDCliente=" + cNumeroCliente.Text)(Num), DatosTallerDataSet.CocheRow).IDCoche

            CType(.Controls("cHistorial" + Num.ToString), DataGridView).DataSource = BuscarHistorialCoche(ID)
            CType(.Controls("CHistorial" + Num.ToString), DataGridView).Columns("IDCoche").Visible = False
            CType(.Controls("CHistorial" + Num.ToString), DataGridView).Columns("IDHistorial").Visible = False
            CType(.Controls("CHistorial" + Num.ToString), DataGridView).Columns("Observaciones").Visible = False

        End With

    End Sub

    Private Sub ActualizarVista()

        ActualizarEnlaceDatosTelefono()
        EnlaceDatosCoche()

        '  BorrarTelefonosVacios()
        ' EnlaceDatosCoche()
        'ActualizarEnlaceDatosCoche()
        'ActualizarEnlaceDatosTelefono()
        CambiarReadOnly(True)
    End Sub

    Private Sub DesenlazarDatosCoche()
        For i As Integer = 1 To TabControl1.TabPages.Count - 1
            For Each cnt As Control In TabControl1.TabPages(i).Controls
                cnt.DataBindings.Clear()
            Next
            TabControl1.TabPages(i).DataBindings.Clear()
        Next
    End Sub

#End Region

#Region "Funciones"

    Private Sub ActualizarEnlaceDatosTelefono()
        If cNumeroCliente.Text <> "" Then
            binDatosTelefono.Filter = "IDCliente=" + cNumeroCliente.Text
            dsDatos.TelefonoCliente.IDClienteColumn.DefaultValue = cNumeroCliente.Text
        End If
    End Sub

    Private Sub EnlaceDatosCoche()
        'BorrarTabs()
        DesenlazarDatosCoche()
        If cNumeroCliente.Text <> "" Then
            Dim i As Integer
            For i = 0 To CochesTieneUsuario(cNumeroCliente.Text)

                If i >= TabControl1.TabPages.Count - 1 Then
                    CrearCocheTab(i)
                End If

                EnlaceDatosCocheCliente(i)
                If TabControl1.TabPages(i + 1).Text = "" Then
                    TabControl1.TabPages(i + 1).Text = "Coche " + (i + 1).ToString
                End If
            Next

            Dim j As Integer = TabControl1.TabPages.Count - i - 2
            Dim c As Integer = 0
            While (c <= j)
                TabControl1.TabPages.RemoveAt(i + 1)
                c += 1
            End While

            Dim index As Integer = TabControl1.SelectedIndex
            TabControl1.SelectedIndex = 1
            TabControl1.SelectedIndex = index

        End If
    End Sub

    Private Sub ActualizarDatosCoche()
        If cNumeroCliente.Text <> "" Then
            For i As Integer = 1 To TabControl1.TabPages.Count - 1
                For Each j As Control In TabControl1.TabPages(i).Controls
                    If j.DataBindings.Count > 0 Then
                        CType(j.DataBindings(0).DataSource, BindingSource).EndEdit()
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub CargarCliente()

        Inicializar("cliente,coche,historial,pof")

        binDatosCliente.DataSource = dsDatos.Cliente
        binDatosTelefono.DataSource = dsDatos.TelefonoCliente

        If dsDatos.Tables(0).Rows.Count > 0 Then
            CambiarReadOnly(True)
        End If
    End Sub

    Private Sub Guardar()
        cNombreCliente.Focus()
        binDatosCliente.EndEdit()
        ActualizarDatosCoche()
        ActualizarBaseDatos()
        CambiarReadOnly(True)
    End Sub

    Private Sub CambiarReadOnly(ByVal Read As Boolean)
        cNombreCliente.ReadOnly = Read
        cNombreComercial.ReadOnly = Read
        cDireccion.ReadOnly = Read
        cPoblacion.ReadOnly = Read
        cProvincia.ReadOnly = Read
        cCodigoPostal.ReadOnly = Read
        cDNI.ReadOnly = Read
        cEmail.ReadOnly = Read
        cComentario.ReadOnly = Read

        If Read Then
            cComentario.BackColor = System.Drawing.SystemColors.Control
            cTelefonos.BackgroundColor = System.Drawing.SystemColors.Control
        Else
            cComentario.BackColor = System.Drawing.SystemColors.Window
            cTelefonos.BackgroundColor = System.Drawing.SystemColors.AppWorkspace
        End If


        cEsAseguradora.Enabled = Not Read

        cTelefonos.ReadOnly = Read

        For Each row As DataGridViewRow In cTelefonos.Rows
            row.Cells("Numero").ReadOnly = Read
            If Read Then
                row.Cells("Numero").Style.BackColor = System.Drawing.SystemColors.Control
            Else
                row.Cells("Numero").Style.BackColor = System.Drawing.SystemColors.Window
            End If
        Next

        cTelefonos.AllowUserToAddRows = Not Read

        cTelefonos.Update()

        For i As Integer = 1 To TabControl1.TabPages.Count - 1
            For Each j As Control In TabControl1.TabPages(i).Controls
                If j.Name.StartsWith("c") Then
                    If j.GetType().ToString = "System.Windows.Forms.TextBox" Then
                        If Not j.Name.StartsWith("cID") Then
                            CType(j, TextBox).ReadOnly = Read
                        Else
                            CType(j, TextBox).ReadOnly = True
                        End If
                    ElseIf j.GetType().ToString = "System.Windows.Forms.TDataGridView" Then
                        CType(j, DataGridView).ReadOnly = Read
                    End If
                End If
            Next
        Next

    End Sub

    Private Sub InsertarNuevo()
        dsDatos.Cliente.AddClienteRow("", "", "", "", "", "", "", "", "", False)
        binDatosCliente.MoveLast()
        ActualizarVista()
        CambiarReadOnly(False)
    End Sub

#End Region

#Region "Formulario"

    Private Sub DatosCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataBaseLib.Fuente(Me)
        'BorrarTelefonosVacios()
        'TabControl1.TabPages.RemoveAt(1)
        Me.binDatosCliente.Filter = ""
        CargarCliente()
        EnlaceDatosCliente()
        'ActualizarEnlaceDatosTelefono()
        EnlaceDatosCoche()
        CambiarReadOnly(True)

        If cNumeroCliente.Text = String.Empty Then
            InsertarNuevo()
        End If
    End Sub

    Private Sub cHistorial0_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles cHistorial0.CellDoubleClick
        Dim frm As New HistorialCoche(CType(sender, DataGridView).Rows(e.RowIndex).Cells("IDHistorial").Value)
        frm.ShowDialog()
        Dim index As Integer = TabControl1.SelectedIndex
        ActualizarVista()
        TabControl1.SelectedIndex = index
    End Sub

    Private Sub CheckBox_MarcadoChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        RemoveHandler cEsAseguradora.MarcadoChanged, AddressOf cEsAseguradora_MarcadoChanged
        cEsAseguradora.Marcado = CheckBox1.Checked
        AddHandler cEsAseguradora.MarcadoChanged, AddressOf cEsAseguradora_MarcadoChanged
    End Sub

    Private Sub cEsAseguradora_MarcadoChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cEsAseguradora.MarcadoChanged
        CheckBox1.Checked = cEsAseguradora.Marcado
    End Sub

#End Region

#Region "Barra de Herramientas"

    Private Sub cNuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cNuevoCliente.Click
        If Not Me.cNombreCliente.Text = String.Empty Then
            InsertarNuevo()
        End If
    End Sub

    Private Sub cNuevoCoche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cNuevoCoche.Click
        ActualizarDatosCoche()
        dsDatos.Coche.AddCocheRow(cNumeroCliente.Text, "", "", "", "")
        EnlaceDatosCoche()
        TabControl1.SelectedTab = TabControl1.TabPages(TabControl1.TabPages.Count - 1)
        CambiarReadOnly(False)
    End Sub

    Private Sub cBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBuscarCliente.Click
        Dim frm As New BuscarCliente

        frm.ShowDialog()

        If frm.ID > 0 Then
            Dim encontrado As Boolean = False

            While Not encontrado
                If cNumeroCliente.Text = frm.ID.ToString Then
                    encontrado = True
                Else
                    binDatosCliente.MoveNext()
                End If
            End While
            binDatosCliente.Filter = String.Empty
            ActualizarVista()
        End If
    End Sub

    Private Sub cPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cPrimero.Click
        If binDatosCliente.Position <> 0 Then
            binDatosCliente.MoveFirst()
            ActualizarVista()
        End If
    End Sub

    Private Sub cAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cAtras.Click
        If binDatosCliente.Position <> 0 Then
            binDatosCliente.MovePrevious()
            ActualizarVista()
        End If
    End Sub

    Private Sub cSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cSiguiente.Click
        If binDatosCliente.Position <> binDatosCliente.Count - 1 Then
            binDatosCliente.MoveNext()
            ActualizarVista()
        End If
    End Sub

    Private Sub cUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cUltimo.Click
        If binDatosCliente.Position <> binDatosCliente.Count - 1 Then
            binDatosCliente.MoveLast()
            ActualizarVista()
        End If
    End Sub

    Private Sub cBorrarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBorrarCliente.Click

        Dim tex As String

        If cNombreCliente.Text <> "" Then
            tex = "¿Esta Seguro de borrar el cliente: " + cNombreCliente.Text + ", se borrar todos sus coches junto con sus facturas,ordenes de trabajo y presupuestos?"
        ElseIf cNombreComercial.Text <> "" Then
            tex = "¿Esta Seguro de borrar el cliente: " + cNombreComercial.Text + " ,se borrar todos sus coches junto con sus facturas,ordenes de trabajo y presupuestos?"
        Else
            tex = "¿Esta Seguro de borrar este cliente se borrar todos sus coches junto con sus facturas,ordenes de trabajo y presupuestos?"
        End If

        If MessageBox.Show(tex, "Borrar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            BorrarCliente(cNumeroCliente.Text)
            ActualizarBaseDatos()
            CargarCliente()
            ActualizarVista()
        End If

        If cNumeroCliente.Text = String.Empty Then
            InsertarNuevo()
        End If
    End Sub

    Private Sub cBorrarCoche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBorrarCoche.Click

        If TabControl1.SelectedIndex = 0 Then
            MessageBox.Show("Esto no es un coche por favor sitúese en la pestaña del coche a borrar", "Borrar Coche", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If MessageBox.Show("¿Esta Seguro de borrar Coche: " + TabControl1.TabPages(TabControl1.SelectedIndex).Text + ", se borrar todas sus facturas, ordenes de trabajo y presupuestos?", "Borrar Coche", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                BorrarCoche(TabControl1.TabPages(TabControl1.SelectedIndex).Controls("cIDCoche" + (TabControl1.SelectedIndex - 1).ToString).Text)
                CType(TabControl1.TabPages(TabControl1.SelectedIndex).Controls("cIDCoche" + (TabControl1.SelectedIndex - 1).ToString).DataBindings(0).DataSource, BindingSource).RemoveCurrent()
                'Guardar()
                ActualizarBaseDatos()
                ActualizarVista()
            End If
        End If
    End Sub

    Private Sub cModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cModificar.Click
        CambiarReadOnly(False)
    End Sub

    Private Sub cGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cGuardar.Click
        Guardar()
    End Sub

    Private Sub cTraspaso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cTraspaso.Click
        If TabControl1.SelectedIndex = 0 Then
            MessageBox.Show("esto no es un coche por favor situece en la pestaña del coche a traspasar", "Traspasar Coche", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim frm As New Traspaso(TabControl1.TabPages(TabControl1.SelectedIndex).Controls("cIDCoche" + (TabControl1.SelectedIndex - 1).ToString).Text)
            frm.ShowDialog()
        End If
        binDatosCliente.Filter = String.Empty
        ActualizarVista()
    End Sub

    Private Sub GenerarBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarBalance.Click
        Dim frm As New GenerarInforme(cNumeroCliente.Text)
        frm.ShowDialog()
        binDatosCliente.Filter = String.Empty
        ActualizarVista()
    End Sub

#End Region

End Class
