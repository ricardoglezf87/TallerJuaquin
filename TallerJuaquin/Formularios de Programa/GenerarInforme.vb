Imports DataBaseLib
Imports Reports

Public Class GenerarInforme

    Private _IDCliente As Integer
    Private binCliente As New BindingSource

    Public Sub New(ByVal IDCliente As Integer)

        InitializeComponent()

        _IDCliente = IDCliente

    End Sub

    Public Sub New()

        InitializeComponent()

        _IDCliente = -1

    End Sub

    Private Sub EnlazarDatos()
        Inicializar("Cliente")
        binCliente.DataSource = dsDatos.Cliente

        cNumeroCliente.DataBindings.Add("Text", binCliente, "IDCliente")
        cNombreCliente.DataBindings.Add("Text", binCliente, "NombreCliente")
        cDireccion.DataBindings.Add("Text", binCliente, "Direccion")
        cPoblacion.DataBindings.Add("Text", binCliente, "Poblacion")
        cDNI.DataBindings.Add("Text", binCliente, "DNI")

        If _IDCliente = -1 Then
            binCliente.SuspendBinding()
        Else
            binCliente.Filter = "IDCliente=" + _IDCliente.ToString
        End If

    End Sub


    Private Sub GenerarInforme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataBaseLib.Fuente(Me)
        EnlazarDatos()        
    End Sub

    Private Sub BuscarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarCliente.Click
        Dim frm As New BuscarCliente()
        frm.ShowDialog()

        If frm.ID > 0 Then
            binCliente.ResumeBinding()
            binCliente.Filter = "IDCliente=" + frm.ID.ToString
        End If
    End Sub

    Private Sub QuitarFiltroCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarFiltroCliente.Click
        binCliente.SuspendBinding()
        RycCheckBox4.Marcado = False
        RycCheckBox5.Marcado = True
        RycCheckBox6.Marcado = True
        CheckBox1.Marcado = False
        CheckBox2.Marcado = False

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.MarcadoChanged, RycCheckBox3.MarcadoChanged, RycCheckBox2.MarcadoChanged, RycCheckBox1.MarcadoChanged
        If Not CheckBox1.Marcado Then
            DateTimePicker1.Enabled = False
        Else
            DateTimePicker1.Enabled = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.MarcadoChanged
        If Not CheckBox2.Marcado Then
            DateTimePicker2.Enabled = False
        Else
            DateTimePicker2.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim filter As String = "TipoPOF=2 "

        If CheckBox1.Marcado And CheckBox2.Marcado Then
            filter += " and Fecha>= " + String.Format("{0:#MM\/dd\/yyyy#}", DateTimePicker1.Value)
            filter += " and  Fecha<= " + String.Format("{0:#MM\/dd\/yyyy#}", DateTimePicker2.Value)

        ElseIf CheckBox1.Marcado Then
            filter += " and Fecha> " + String.Format("{0:#MM\/dd\/yyyy#}", DateTimePicker1.Value)
        ElseIf CheckBox2.Marcado Then
            filter += " and Fecha< " + String.Format("{0:#MM\/dd\/yyyy#}", DateTimePicker2.Value)
        End If

        If RycCheckBox5.Marcado And Not RycCheckBox6.Marcado Then
            filter += " and Costo=0"
        End If

        If Not RycCheckBox5.Marcado And RycCheckBox6.Marcado Then
            filter += " and PVP=0"
        End If

        Dim tipografico As String = String.Empty

        If RycCheckBox2.Marcado Then
            tipografico = "Dia"
        End If

        If RycCheckBox1.Marcado Then
            tipografico = "Mes"
        End If

        If RycCheckBox3.Marcado Then
            tipografico = "Año"
        End If

        If RycCheckBox4.Marcado And Not RycCheckBox5.Marcado And Not RycCheckBox6.Marcado Then
            filter += " and Costo=0 and PVP=0"
        End If

        If Not RycCheckBox4.Marcado And Not RycCheckBox5.Marcado And Not RycCheckBox6.Marcado Then

            If MessageBox.Show("¿No ha marcado niguna opcion de balance dese incluirlas todas?", "Opciones de Balance", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else
                RycCheckBox4.Marcado = True
                RycCheckBox5.Marcado = True
                RycCheckBox6.Marcado = True
            End If

        End If

        Dim id As Integer = 0
        If Not binCliente.IsBindingSuspended Then
            id = cNumeroCliente.Text
        End If

        Dim frm As New BalancePreview(filter, tipografico, id)

        frm.Compras = RycCheckBox4.Marcado

        frm.ShowDialog()

    End Sub

    Private Sub RycCheckBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RycCheckBox2.MarcadoChanged
        If RycCheckBox2.Marcado Then
            RycCheckBox1.Marcado = False
            RycCheckBox3.Marcado = False
        End If
    End Sub

    Private Sub RycCheckBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RycCheckBox1.MarcadoChanged
        If RycCheckBox1.Marcado Then
            RycCheckBox2.Marcado = False
            RycCheckBox3.Marcado = False
        End If
    End Sub

    Private Sub RycCheckBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RycCheckBox3.MarcadoChanged
        If RycCheckBox3.Marcado Then
            RycCheckBox1.Marcado = False
            RycCheckBox2.Marcado = False
        End If
    End Sub

End Class