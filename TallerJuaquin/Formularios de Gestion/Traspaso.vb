Imports Masked
Imports DataBaseLib

Public Class Traspaso

    Private binCliente As New BindingSource
    Private binCoche As New BindingSource
    Private binTelefono As New BindingSource
    Private IDCoche As Integer

    Private Sub EnlazarDatos()
        Inicializar("Cliente,Coche,Historial,pof")
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

        cIDCoche.DataBindings.Add("Text", binCoche, "IDCliente")
        cMatricula.DataBindings.Add("Text", binCoche, "Matricula")
        cMarca.DataBindings.Add("Text", binCoche, "Marca")
        cModelo.DataBindings.Add("Text", binCoche, "Modelo")
        cColor.DataBindings.Add("Text", binCoche, "Color")

        binCoche.Filter = "IDCoche=" + IDCoche.ToString

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

    End Sub

    Private Sub ConectarEnlaces()
        binCliente.ResumeBinding()
        binTelefono.ResumeBinding()
        cTelefonos.DataSource = binTelefono
    End Sub

    Private Sub DesconectarEnlaces()
        binCliente.SuspendBinding()
        binTelefono.SuspendBinding()
        cTelefonos.DataSource = Nothing
    End Sub

    Public Sub New(ByVal IDCo As Integer)
        InitializeComponent()
        IDCoche = IDCo
    End Sub

    Private Sub Traspaso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataBaseLib.Fuente(Me)
        EnlazarDatos()
        DesconectarEnlaces()
    End Sub

    Private Sub cBuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBuscarCliente.Click
        Dim frm As New BuscarCliente()
        frm.ShowDialog()

        If frm.ID > 0 Then
            binCliente.ResumeBinding()
            binTelefono.ResumeBinding()

            binCliente.Filter = "IDCliente=" + frm.ID.ToString
            binTelefono.Filter = "IDCliente=" + frm.ID.ToString

            cTelefonos.DataSource = binTelefono
        End If
    End Sub

    Private Sub cGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cGuardar.Click

        cMatricula.Focus()

        If binCliente.IsBindingSuspended Then
            dsDatos.Cliente.AddClienteRow(cNombreCliente.Text, "", cDireccion.Text, cCodigoPostal.Text, cPoblacion.Text, cProvincia.Text, cDNI.Text, "", "", False)

            binCliente.ResumeBinding()
            binCliente.MoveLast()
            cIDCoche.Text = cNumeroCliente.Text


            For Each row As DataGridViewRow In cTelefonos.Rows
                dsDatos.TelefonoCliente.AddTelefonoClienteRow(cNumeroCliente.Text, row.Cells("Numero").Value)
            Next

        Else
            cIDCoche.Text = cNumeroCliente.Text
        End If

        binTelefono.EndEdit()
        binCoche.EndEdit()

        ActualizarBaseDatos()

        binCliente.Filter = ""
        binCoche.Filter = ""
        Me.Close()

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        binCliente.ResumeBinding()
        binCliente.SuspendBinding()
    End Sub


End Class