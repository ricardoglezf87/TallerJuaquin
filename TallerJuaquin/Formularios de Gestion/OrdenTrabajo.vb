Imports Masked
Imports DataBaseLib

Public Class OrdenTrabajo

    Private binCliente As New BindingSource
    Private binCoche As New BindingSource
    Private binTelefono As New BindingSource
    Private binHistorial As New BindingSource
    Private binArticuloPOF As New BindingSource
    Private binPOF As New BindingSource

    Private IDCliente As String
    Private IDCoche As String
    Private IDHistorial As String

    Private rutas() As String    

#Region "Funciones"

    Private Sub GuardarImagenes()

        Dim opendlg As New OpenFileDialog

        opendlg.InitialDirectory = GetRowOpciones.RutaPredeterminada

        opendlg.Multiselect = True

        If opendlg.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim img As New ImageList()
            img.ImageSize = New Size(128, 128)
            img.ColorDepth = ColorDepth.Depth32Bit
            cImagenes.View = View.LargeIcon

            If Not cImagenes.LargeImageList Is Nothing Then
                For Each i As Image In cImagenes.LargeImageList.Images
                    img.Images.Add(i)
                Next
            End If

            cImagenes.LargeImageList = img

            Dim frm As New Progreso(opendlg.FileNames.Length)

            Dim j As Integer = cImagenes.Items.Count
            frm.Show()
            For Each i As String In opendlg.FileNames
                img.Images.Add(Image.FromFile(i))
                cImagenes.Items.Add("", j)
                frm.StepProgress()
                j += 1

                If rutas Is Nothing Then
                    Array.Resize(rutas, 1)
                Else
                    Array.Resize(rutas, rutas.Length + 1)
                End If

                rutas(rutas.Length - 1) = i
            Next
            frm.Close()
        End If
    End Sub

    Private Sub EnlazarDatos()

        Inicializar("Cliente,Coche,Historial,POF")
        binCliente.DataSource = dsDatos.Cliente
        binCoche.DataSource = dsDatos.Coche
        binTelefono.DataSource = dsDatos.TelefonoCliente

        cNumeroCliente.DataBindings.Add("Text", binCliente, "IDCliente")
        cNombreCliente.DataBindings.Add("Text", binCliente, "NombreCliente")
        cDireccion.DataBindings.Add("Text", binCliente, "Direccion")
        cPoblacion.DataBindings.Add("Text", binCliente, "Poblacion")
        cProvincia.DataBindings.Add("Text", binCliente, "Provincia")
        cCodigoPostal.DataBindings.Add("Text", binCliente, "CP")
        cDNI.DataBindings.Add("Text", binCliente, "DNI")

        cIDCoche.DataBindings.Add("Text", binCoche, "IDCoche")
        cMatricula.DataBindings.Add("Text", binCoche, "Matricula")
        cMarca.DataBindings.Add("Text", binCoche, "Marca")
        cModelo.DataBindings.Add("Text", binCoche, "Modelo")
        cColor.DataBindings.Add("Text", binCoche, "Color")

        cTelefonos.AutoGenerateColumns = False
        cTelefonos.DataSource = binTelefono

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
            cTelefonos.Columns.Add(IDC)
            IDC.Visible = False
        End Using

        Using Num As New MaskedTextColumn
            Num.Mascara = "(000)00-00-00"
            Num.HeaderText = "Numero"
            Num.DataPropertyName = "Numero"
            Num.Name = "Numero"
            cTelefonos.Columns.Add(Num)
        End Using

        binPOF.DataSource = dsDatos.POF

        binArticuloPOF.DataSource = dsDatos.ArticuloPOF
        cReparacion.AutoGenerateColumns = False
        cReparacion.DataSource = binArticuloPOF

        Using Concepto As New DataGridViewTextBoxColumn
            Concepto.HeaderText = "Concepto"
            Concepto.Name = "Concepto"
            Concepto.DataPropertyName = "Concepto"
            cReparacion.Columns.Add(Concepto)
        End Using

        binHistorial.DataSource = dsDatos.Historial
        cIDHistorial.DataBindings.Add("Text", binHistorial, "IDHistorial")
        cKilometros.DataBindings.Add("Text", binHistorial, "Kilometros")
        cObservaciones.DataBindings.Add("Text", binHistorial, "Observaciones")
        cFechaEntrada.DataBindings.Add("Text", binHistorial, "FechaEntrada")


    End Sub

    Private Sub Guardar()
        cMatricula.Focus()

        Acceptbinding()        
        If Not rutas Is Nothing Then

            BorrarImagenbyHistorial(dsDatos.Historial.Rows(dsDatos.Historial.Rows.Count - 1).Item("IDHistorial"))

            If rutas.Length > 0 Then
                Dim frm As New Progreso(rutas.Length)
                frm.Show()
                For Each img As String In rutas
                    dsImg.ImagenHistorial.AddImagenHistorialRow(dsDatos.Historial.Rows(dsDatos.Historial.Rows.Count - 1).Item("IDHistorial"), GuardarImg(img).ToArray)
                    frm.StepProgress()
                Next
                frm.Close()
            End If
        End If

        RepairBinding()

    End Sub

    Private Sub RepairBinding()

        Dim rowCli As DatosTallerDataSet.ClienteRow = dsDatos.Cliente.FindByIDCliente(IDCliente)
        Dim rowCo As DatosTallerDataSet.CocheRow = dsDatos.Coche.FindByIDCoche(IDCoche)
        Dim rowHi As DatosTallerDataSet.HistorialRow = dsDatos.Historial.FindByIDHistorial(IDHistorial)

        ActualizarBaseDatos()

        For Each row As DatosTallerDataSet.TelefonoClienteRow In dsDatos.TelefonoCliente.Select("IDCliente=" + IDCliente)
            row.IDCliente = rowCli.IDCliente
        Next

        IDCliente = rowCli.IDCliente

        CType(dsDatos.Coche.Select("IDCoche=" + rowCo.IDCoche.ToString)(0), DatosTallerDataSet.CocheRow).IDCliente = IDCliente
        IDCoche = rowCo.IDCoche

        CType(dsDatos.Historial.Select("IDHistorial=" + rowHi.IDHistorial.ToString)(0), DatosTallerDataSet.HistorialRow).IDCoche = IDCoche
        CType(dsDatos.POF.Select("IDHistorial=" + IDHistorial)(0), DatosTallerDataSet.POFRow).IDHistorial = rowHi.IDHistorial

        For Each row As DatosTallerDataSet.ArticuloPOFRow In dsDatos.ArticuloPOF.Select("IDHistorial=" + IDHistorial)
            row.IDHistorial = rowHi.IDHistorial
        Next

        For Each row As ImgData.ImagenHistorialRow In dsImg.ImagenHistorial.Select("IDHistorial=" + IDHistorial)
            row.IDHistorial = rowHi.IDHistorial
        Next

        IDHistorial = rowHi.IDHistorial

        ActualizarBaseDatos()

        ActualizarBinding()

    End Sub

    Private Sub Acceptbinding()
        binCliente.EndEdit()
        binCoche.EndEdit()
        binTelefono.EndEdit()
        binHistorial.EndEdit()
        binPOF.EndEdit()
        binArticuloPOF.EndEdit()
    End Sub

    Private Sub CancelBinding()
        rutas = Nothing
        cImagenes.Clear()

        binTelefono.CancelEdit()
        binArticuloPOF.CancelEdit()
        binPOF.CancelEdit()
        binHistorial.CancelEdit()
        binCliente.CancelEdit()
        binCoche.CancelEdit()
    End Sub

    Private Sub IniciarBinding()

        IDCliente = -1
        IDCoche = -1
        IDHistorial = -1

        ActualizarBinding(True)

    End Sub

    Private Sub ActualizarBinding(Optional ByVal Reboot As Boolean = False)

        If Reboot Then
            CancelBinding()           
        End If

        binArticuloPOF.Filter = Nothing
        binPOF.Filter = Nothing
        binHistorial.Filter = Nothing
        binTelefono.Filter = Nothing
        binCoche.Filter = Nothing
        binCliente.Filter = Nothing

        If IDCliente = -1 Then
            binCliente.AddNew()
            IDCliente = cNumeroCliente.Text
        Else
            binCliente.Filter = "IDCliente=" + IDCliente
        End If

        dsDatos.Coche.Columns("IDCliente").DefaultValue = IDCliente

        If IDCoche = -1 Then
            binCoche.AddNew()
            IDCoche = cIDCoche.Text
        Else
            binCoche.Filter = "IDCoche=" + IDCoche
        End If

        dsDatos.TelefonoCliente.Columns("IDCliente").DefaultValue = IDCliente
        binTelefono.Filter = "IDCliente=" + IDCliente


        dsDatos.Historial.Columns("IDCoche").DefaultValue = IDCoche
        dsDatos.Historial.Columns("FechaEntrada").DefaultValue = Now.ToShortDateString

        If IDHistorial = -1 Then
            binHistorial.AddNew()
            IDHistorial = cIDHistorial.Text
            dsDatos.POF.Columns("IDHistorial").DefaultValue = IDHistorial
            binPOF.AddNew()
        Else
            binHistorial.Filter = "IDHistorial=" + IDHistorial
            dsDatos.POF.Columns("IDHistorial").DefaultValue = IDHistorial
            binPOF.Filter = "IDHistorial=" + IDHistorial
        End If

        dsDatos.ArticuloPOF.Columns("IDHistorial").DefaultValue = IDHistorial
        binArticuloPOF.Filter = "IDHistorial=" + IDHistorial
    End Sub

#End Region

#Region "Eventos"

    Private Sub CrearOrdenTrabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataBaseLib.Fuente(Me)
        EnlazarDatos()
        IniciarBinding()
    End Sub

    Private Sub cGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cGuardar.Click
        Guardar()
    End Sub

    Private Sub cBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBuscarCliente.Click
        cMatricula.Focus()
        Dim frm As New BuscarCliente()
        frm.ShowDialog()

        If frm.ID > 0 Then
            'CancelBinding()
            binCliente.CancelEdit()
            binTelefono.CancelEdit()

            IDCliente = frm.ID
        End If
        ActualizarBinding()

    End Sub

    Private Sub cBuscarCoche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBuscarCoche.Click
        cMatricula.Focus()
        Dim frm As New BuscarCoche()
        frm.ShowDialog()

        If frm.IDCoche > 0 Then
            CancelBinding()

            IDCliente = frm.IDCliente
            IDCoche = frm.IDCoche
            IDHistorial = -1
            cBuscarCliente.Enabled = False
        End If

        ActualizarBinding()

    End Sub

    Private Sub cNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cNueva.Click

        IniciarBinding()

        cBuscarCliente.Enabled = True

    End Sub

    Private Sub cInsertarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cInsertarImagen.Click
        GuardarImagenes()
    End Sub

    Private Sub cBorrarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBorrarImagen.Click
        If Me.cImagenes.SelectedItems.Count > 0 Then
            Dim ID As Integer = Me.cImagenes.SelectedItems(0).Index
            If MessageBox.Show("¿Esta seguro que desea borrar la foto seleccionada?", "Borrar Foto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                cImagenes.LargeImageList.Images.RemoveAt(cImagenes.Items(ID).ImageIndex)
                cImagenes.Items(cImagenes.Items.Count - 1).Remove()

            End If
        End If
    End Sub

    Private Sub cImagenes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cImagenes.KeyDown
        If e.KeyCode = Keys.Delete Then
            If Me.cImagenes.SelectedItems.Count > 0 Then
                Dim ID As Integer = Me.cImagenes.SelectedItems(0).Index
                If MessageBox.Show("¿Esta seguro que desea borrar la foto seleccionada?", "Borrar Foto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                    cImagenes.LargeImageList.Images.RemoveAt(cImagenes.Items(ID).ImageIndex)
                    cImagenes.Items(cImagenes.Items.Count - 1).Remove()

                End If
            End If
        End If
    End Sub

    Private Sub cHacerPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cHacerPresupuesto.Click
        Guardar()

        Dim frm As New Facturas(IDCliente, IDCoche, IDHistorial)
        frm.ShowDialog()

    End Sub

    Private Sub cImagenes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cImagenes.DoubleClick

        Dim frm As New ImagenPreview(Image.FromFile(rutas(cImagenes.SelectedItems(0).ImageIndex)))
        frm.ShowDialog()

    End Sub

#End Region


End Class