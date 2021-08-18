Imports DataBaseLib

Public Class HistorialCoche

    Private binHistorial As New BindingSource
    Private binPOF As New BindingSource
    Private IDHistorial As Integer
    Private IDs As Integer()

#Region "Funciones"

    Private Sub GuardarImagenes()
        Dim opendlg As New OpenFileDialog

        opendlg.InitialDirectory = GetRowOpciones.RutaPredeterminada

        opendlg.Multiselect = True
        If opendlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            If opendlg.FileNames.Length > 0 Then
                Dim frm As New Progreso(opendlg.FileNames.Length)
                frm.Show()
                For Each i As String In opendlg.FileNames
                    dsImg.ImagenHistorial.AddImagenHistorialRow(IDHistorial, GuardarImg(i).ToArray)
                    frm.Close()
                Next
                frm.Close()
            End If
        End If
    End Sub

    Private Sub CargarImagenes()

        cImagenes.Items.Clear()
        Array.Resize(IDs, 0)

        If BuscarImagenHistorial(IDHistorial).Length > 0 Then

            Dim img As New ImageList()
            cImagenes.LargeImageList = img

            img.ImageSize = New Size(128, 128)
            img.ColorDepth = ColorDepth.Depth32Bit
            cImagenes.View = View.LargeIcon
            Dim i As Integer = 0
            For Each row As ImgData.ImagenHistorialRow In BuscarImagenHistorial(IDHistorial)

                Dim men As New IO.MemoryStream(row.Imagen)
                Dim pictu As Image
                pictu = Image.FromStream(men)
                img.Images.Add(pictu)
                cImagenes.Items.Add("", i)

                Array.Resize(IDs, i + 1)

                IDs(i) = row.IDImagenHistorial

                i += 1

            Next

        End If
    End Sub

    Private Sub Guardar()
        Me.cKilometros.Focus()
        binHistorial.EndEdit()
        binPOF.EndEdit()
        ActualizarBaseDatos()
    End Sub

    Private Sub CambiarEnable(ByVal Ena As Boolean)
        cFechaEntrada.Enabled = Ena
        cFechaSalida.Enabled = Ena
        cRepuesto.Enabled = Ena
        cRepuesto.AllowUserToAddRows = Ena
        cObservaciones.Enabled = Ena
        cKilometros.Enabled = Ena
    End Sub

#End Region

#Region "Eventos"

    Public Sub New(ByVal _IDHistorial As Integer)
        InitializeComponent()

        IDHistorial = _IDHistorial

    End Sub

    Private Sub HistorialCoche_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataBaseLib.Fuente(Me)
        Inicializar("historial,pof,coche")

        binHistorial.DataSource = dsDatos.Historial
        binPOF.DataSource = dsDatos.ArticuloPOF

        binHistorial.Filter = "IDHistorial=" + IDHistorial.ToString

        cIDCoche.DataBindings.Add("Text", binHistorial, "IDCoche")        
        cFechaEntrada.DataBindings.Add("Text", binHistorial, "FechaEntrada")
        cFechaSalida.DataBindings.Add("Text", binHistorial, "FechaSalida")
        cObservaciones.DataBindings.Add("Text", binHistorial, "Observaciones")        
        cKilometros.DataBindings.Add("Text", binHistorial, "Kilometros")

        dsDatos.ArticuloPOF.Columns("IDHistorial").DefaultValue = IDHistorial
        cRepuesto.DataSource = binPOF
        binPOF.Filter = "IDHistorial=" + IDHistorial.ToString + " and Costo=0"                
        cRepuesto.Columns("IDHistorial").Visible = False
        cRepuesto.Columns("IDArticuloPOF").Visible = False
        cRepuesto.Columns("PVP").Visible = False
        cRepuesto.Columns("Costo").Visible = False
        cRepuesto.Columns("Cantidad").Visible = False
        cRepuesto.Columns("Horas").Visible = False

        CargarImagenes()

        CambiarEnable(False)

        If dsDatos.POF.FindByIDHistorial(IDHistorial).TipoPOF < 2 Then
            cFechaSalida.Value = Nothing
        End If

    End Sub

    Private Sub cImagenes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cImagenes.DoubleClick
        Dim frm As New ImagenPreview(IDs(cImagenes.SelectedItems(0).Index), IDHistorial)
        frm.ShowDialog()
    End Sub

    Private Sub cInsertarFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cInsertarFoto.Click
        GuardarImagenes()
        Guardar()
        CargarImagenes()
    End Sub

    Private Sub cBorrarFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBorrarFoto.Click
        If Me.cImagenes.SelectedItems.Count > 0 Then
            Dim ID As Integer = Me.cImagenes.SelectedItems(0).Index
            If MessageBox.Show("¿Esta seguro que desea borrar la foto seleccionada?", "Borrar Foto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                BorrarImagenHistorial(IDs(ID), IDHistorial)
                CargarImagenes()
            End If
        End If
    End Sub

    Private Sub cImagenes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cImagenes.KeyDown
        If e.KeyCode = Keys.Delete Then
            If Me.cImagenes.SelectedItems.Count > 0 Then
                Dim ID As Integer = Me.cImagenes.SelectedItems(0).Index
                If MessageBox.Show("¿Esta seguro que desea borrar la foto seleccionada?", "Borrar Foto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    BorrarImagenHistorial(IDs(ID), IDHistorial)
                    CargarImagenes()
                End If
            End If
        End If
    End Sub

    Private Sub cModificarAveria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cModificarAveria.Click
        CambiarEnable(True)
    End Sub

    Private Sub cGuardarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cGuardarDatos.Click
        binHistorial.EndEdit()
        Guardar()
        CargarImagenes()
        CambiarEnable(False)
        cFechaEntrada.Focus()
    End Sub

    Private Sub cBorrarAveria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBorrarAveria.Click
        If MessageBox.Show("¿Esta seguro que desea borrar la averia tambien se borrara la factura asociada a ella?", "Borrar Averia", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            BorrarHistorial(IDHistorial)
            Me.Close()
        End If
    End Sub

    Private Sub cVerFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cVerFactura.Click
        Dim frm As New Facturas(BuscarIDClientebyIDCoche(cIDCoche.Text), cIDCoche.Text, IDHistorial)
        frm.ShowDialog()
    End Sub

#End Region

End Class