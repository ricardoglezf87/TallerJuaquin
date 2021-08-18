Imports OnlyNum
Imports DataBaseLib
Imports Reports


Public Class Facturas

    Dim binPOF As New BindingSource
    Dim binItemPOF As New BindingSource
    Dim binHis As New BindingSource
    Dim IDCliente As Integer
    Dim IDCoche As Integer
    Dim IDHistorial As Integer

#Region "Funciones"

    Private Sub AnchoColumna(Optional ByVal Inicio As Boolean = False)

        RemoveHandler cPOF.ColumnWidthChanged, AddressOf cPOF_ColumnWidthChanged

        If GetRowOpciones.anConcepto = 0 And GetRowOpciones.anHoras = 0 And GetRowOpciones.anCosto = 0 Then
            cPOF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            GetRowOpciones.anConcepto = cPOF.Columns("Concepto").Width
            GetRowOpciones.anCantidad = cPOF.Columns("Cantidad").Width
            GetRowOpciones.anHoras = cPOF.Columns("Horas").Width
            GetRowOpciones.anCosto = cPOF.Columns("Costo").Width
            GetRowOpciones.anPVP = cPOF.Columns("PVP").Width

            cPOF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

            GuardarOpciones()
        ElseIf Inicio Then
            cPOF.Columns("Concepto").Width = GetRowOpciones.anConcepto
            cPOF.Columns("Cantidad").Width = GetRowOpciones.anCantidad
            cPOF.Columns("Horas").Width = GetRowOpciones.anHoras
            cPOF.Columns("Costo").Width = GetRowOpciones.anCosto
            cPOF.Columns("PVP").Width = GetRowOpciones.anPVP
        Else

            GetRowOpciones.anConcepto = cPOF.Columns("Concepto").Width
            GetRowOpciones.anCantidad = cPOF.Columns("Cantidad").Width
            GetRowOpciones.anHoras = cPOF.Columns("Horas").Width
            GetRowOpciones.anCosto = cPOF.Columns("Costo").Width
            GetRowOpciones.anPVP = cPOF.Columns("PVP").Width

            GuardarOpciones()
        End If

        AddHandler cPOF.ColumnWidthChanged, AddressOf cPOF_ColumnWidthChanged

    End Sub

    Private Sub CrearCol(ByVal Nombre As String, ByVal Tipo As Integer, ByVal visible As Boolean)

        Dim col As New Object

        If Tipo = 1 Then
            col = New DataGridViewTextBoxColumn()
        Else
            col = New OnlyNumTextBoxColumn
        End If

        col.HeaderText = Nombre
        col.Name = Nombre
        col.DataPropertyName = Nombre
        col.Visible = visible
        cPOF.Columns.Add(col)

    End Sub

    Private Sub FechaYGuarda()
        cNombreCliente.Focus()

        If cTipoPOF.Text = "2" Then
            If Not cFecha.Checked Then
                'cOtraFecha.Value = Now.ToShortDateString
                cFecha.Value = New Date(2000, 1, 1)
                cFecha.Value = Now
            End If
        End If

        binItemPOF.EndEdit()
        binPOF.EndEdit()
        binHis.EndEdit()

        ActualizarBaseDatos()
    End Sub

    Private Sub EnlazarDatos()

        Dim binCliente As New BindingSource
        Dim binCoche As New BindingSource
        Dim binTelefono As New BindingSource
        Dim binTelefono2 As New BindingSource

        Inicializar("Cliente,Coche,POF,historial")
        binHis.DataSource = dsDatos.Historial
        binCliente.DataSource = dsDatos.Cliente
        binCoche.DataSource = dsDatos.Coche
        binTelefono.DataSource = dsDatos.TelefonoCliente
        binTelefono2.DataSource = dsDatos.TelefonoCliente
        binPOF.DataSource = dsDatos.POF
        binItemPOF.DataSource = dsDatos.ArticuloPOF

        cNumeroCliente.DataBindings.Add("Text", binCliente, "IDCliente")
        cNombreCliente.DataBindings.Add("Text", binCliente, "NombreCliente")
        cDireccion.DataBindings.Add("Text", binCliente, "Direccion")
        cPoblacion.DataBindings.Add("Text", binCliente, "Poblacion")
        cProvincia.DataBindings.Add("Text", binCliente, "Provincia")
        cDNI.DataBindings.Add("Text", binCliente, "DNI")
        cTelefono.DataBindings.Add("Text", binTelefono, "Numero")
        cTelefono2.DataBindings.Add("Text", binTelefono2, "Numero")

        cIDCoche.DataBindings.Add("Text", binCoche, "IDCoche")
        cMatricula.DataBindings.Add("Text", binCoche, "Matricula")
        cMarca.DataBindings.Add("Text", binCoche, "Marca")
        cModelo.DataBindings.Add("Text", binCoche, "Modelo")
        cColor.DataBindings.Add("Text", binCoche, "Color")

        cFecha.DataBindings.Add("Text", binHis, "FechaSalida")
        cOtraFecha.DataBindings.Add("Text", binPOF, "Fecha")
        cIVA.DataBindings.Add("Text", binPOF, "IVA")
        cDescuento.DataBindings.Add("Text", binPOF, "Franquicia")
        cTotal.DataBindings.Add("Text", binPOF, "Total")
        cTipoPOF.DataBindings.Add("Text", binPOF, "TipoPOF")

        binCliente.Filter = "IDCliente=" + IDCliente.ToString
        binTelefono.Filter = "IDCliente=" + cNumeroCliente.Text
        If binTelefono.Count > 1 Then
            binTelefono2.Filter = "IDCliente=" + cNumeroCliente.Text
            binTelefono2.MoveNext()
        Else
            binTelefono2.SuspendBinding()
        End If
        binCoche.Filter = "IDCoche=" + IDCoche.ToString

        cPOF.AutoGenerateColumns = False
        cPOF.DataSource = binItemPOF

        RemoveHandler cPOF.ColumnWidthChanged, AddressOf cPOF_ColumnWidthChanged

        CrearCol("IDHistorial", 1, False)
        CrearCol("IDArticuloPOF", 1, False)

        CrearCol("Concepto", 1, True)
        CrearCol("Cantidad", 2, True)
        CrearCol("Horas", 2, True)
        CrearCol("Costo", 2, True)
        CrearCol("PVP", 2, True)

        AddHandler cPOF.ColumnWidthChanged, AddressOf cPOF_ColumnWidthChanged

    End Sub

    Private Sub CalcularTotales()

        binItemPOF.EndEdit()
        binPOF.EndEdit()

        Dim Total As Double = 0
        Dim Costo As Double = 0
        Dim Horas As Double = 0
        For Each row As DataGridViewRow In cPOF.Rows
            If Not row.Cells("PVP").Value Is Nothing Then
                If row.Cells("PVP").Value.ToString <> String.Empty Then
                    Total = Total + Double.Parse(row.Cells("PVP").Value.ToString) * Int(row.Cells("Cantidad").Value.ToString)
                End If
            End If
            If Not row.Cells("Costo").Value Is Nothing Then
                If row.Cells("Costo").Value.ToString <> String.Empty Then
                    Costo = Costo + Double.Parse(row.Cells("Costo").Value.ToString) * Int(row.Cells("Cantidad").Value.ToString)
                End If
            End If
            If Not row.Cells("Horas").Value Is Nothing Then
                If row.Cells("Horas").Value.ToString <> String.Empty Then
                    Horas = Horas + Double.Parse(row.Cells("Horas").Value.ToString)
                End If
            End If
        Next

        cTotalPVP.Text = Total.ToString
        cTotalCosto.Text = Costo.ToString
        cHoras.Text = Horas.ToString

        If cIVA.Text <> String.Empty Then
            cTotalIVA.Text = (Total * (Double.Parse(cIVA.Text) / 100)).ToString
            Total = Total + Double.Parse(cTotalIVA.Text)
        End If

        cSubTotal.Text = Total.ToString

        If cDescuento.Text <> String.Empty Then
            Total = Total - Double.Parse(cDescuento.Text)
        End If

        cTotal.Text = Total.ToString

        binItemPOF.EndEdit()
        binPOF.EndEdit()

        cPOF.Columns("IDHistorial").Visible = False

        'ActualizarBaseDatos()

    End Sub

    Private Sub Etiqueta()
        If cTipoPOF.Text = "0" Then
            GroupBox2.Text = "Presupuesto"
            cCambiar.Text = "Cambiar a Orden de Trabajo"
            cCambiar.Visible = True
            Button1.Visible = False
            cPrevisualizarInforme.ToolTipText = "Ver Infor. Presupuesto"
            cImprimirInforme.ToolTipText = "Imprimir Infor. Presupuesto"
        ElseIf cTipoPOF.Text = "1" Then
            GroupBox2.Text = "Orden de Trabajo"
            cCambiar.Text = "Cambiar a Factura"
            Me.Button1.Text = "Volver a Presupuesto"
            Button1.Visible = True
            cCambiar.Visible = True
            cPrevisualizarInforme.ToolTipText = "Ver Infor. Orden de Trabajo"
            cImprimirInforme.ToolTipText = "Imprimir Infor. Orden de Trabajo"
        ElseIf cTipoPOF.Text = "2" Then
            GroupBox2.Text = "Facturacion"
            Me.Button1.Text = "Volver a Orden de Trabajo"
            cCambiar.Visible = False
            Button1.Visible = True
            cPrevisualizarInforme.ToolTipText = "Ver Infor. Factura"
            cImprimirInforme.ToolTipText = "Imprimir Infor. Factura"
        End If
    End Sub

#End Region

#Region "Eventos"

    Public Sub New(ByVal _IDCliente As Integer, ByVal _IDCoche As Integer, ByVal _IDHistorial As Integer)

        InitializeComponent()

        IDCliente = _IDCliente
        IDCoche = _IDCoche
        IDHistorial = _IDHistorial

    End Sub

    Private Sub Facturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataBaseLib.Fuente(Me)
        EnlazarDatos()

        binPOF.Filter = "IDHistorial=" + IDHistorial.ToString
        binItemPOF.Filter = "IDHistorial=" + IDHistorial.ToString
        binHis.Filter = "IDHistorial=" + IDHistorial.ToString
        dsDatos.ArticuloPOF.IDHistorialColumn.DefaultValue = IDHistorial

        CalcularTotales()

        Etiqueta()

        AnchoColumna(True)

    End Sub

    Private Sub cPOF_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles cPOF.CellEndEdit
        If e.ColumnIndex = cPOF.Columns("PVP").Index Or e.ColumnIndex = cPOF.Columns("Costo").Index Or e.ColumnIndex = cPOF.Columns("Cantidad").Index Then
            CalcularTotales()
        End If
    End Sub

    Private Sub Control_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFecha.Validated, cDescuento.Validated, cIVA.Validated, cOtraFecha.Validated
        CalcularTotales()
    End Sub

    Private Sub cCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cCambiar.Click
        If cTipoPOF.Text = "0" Then
            cTipoPOF.Text = "1"
        ElseIf cTipoPOF.Text = "1" Then
            cTipoPOF.Text = "2"
        End If
        Etiqueta()
        binItemPOF.EndEdit()
        binPOF.EndEdit()

        ActualizarBaseDatos()
    End Sub

    Private Sub cVerFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cPrevisualizarInforme.Click
        FechaYGuarda()

        Dim ocultar As Boolean = False
        If RycCheckBox1.Marcado Then
            ocultar = True
        End If

        Dim ocultar2 As Boolean = False
        If RycCheckBox2.Marcado Then
            ocultar2 = True
        End If

        Dim frm As New CRFacturaPreview(IDHistorial, IDCoche, IDCliente, ocultar2, ocultar, False)
        frm.ShowDialog()
    End Sub

    Private Sub cGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cGuardar.Click
        FechaYGuarda()
    End Sub

    Private Sub cImprimirInforme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cImprimirInforme.Click

        FechaYGuarda()

        Dim ocultar As Boolean = False
        If RycCheckBox1.Marcado Then
            ocultar = True
        End If

        Dim ocultar2 As Boolean = False
        If RycCheckBox2.Marcado Then
            ocultar2 = True
        End If

        Dim frm As New CRFacturaPreview(IDHistorial, IDCoche, IDCliente, ocultar2, ocultar, True)
        frm.ShowDialog()

    End Sub

    Private Sub Num_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cIVA.KeyPress, cDescuento.KeyPress, cSubTotal.KeyPress, cTotalCosto.KeyPress, cTotalIVA.KeyPress, cTotalPVP.KeyPress, cHoras.KeyPress, cTotal.KeyPress
        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cTipoPOF.Text = "2" Then
            cTipoPOF.Text = "1"
        ElseIf cTipoPOF.Text = "1" Then
            cTipoPOF.Text = "0"
        End If
        Etiqueta()
        binItemPOF.EndEdit()
        binPOF.EndEdit()
        binHis.EndEdit()

        ActualizarBaseDatos()
    End Sub

    Private Sub cPOF_ColumnWidthChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles cPOF.ColumnWidthChanged
        AnchoColumna()
    End Sub

    Private Sub cFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFecha.ValueChanged
        cOtraFecha.Value = cFecha.Value
    End Sub

#End Region

End Class