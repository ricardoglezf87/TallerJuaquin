Imports System.Windows.Forms
Imports DataBaseLib

Public Class BuscarHistorial

    Public IDCoche As Integer = 0
    Public IDHistorial As Integer = 0

    Private binCocheHistorial As New BindingSource

#Region "Funciones"

    Private Sub Filtrar()
        If cBuscar.Text <> String.Empty Or cDesde.Visible Then
            Dim filtro As String = String.Empty
            Dim nombre As String = String.Empty

            nombre += "["

            If cBuscarEn.Text = "Fecha Entrada" Or cBuscarEn.Text = "Fecha Salida" Then

                If cBuscarEn.Text = "Fecha Entrada" Then
                    nombre += "FechaEntrada"
                ElseIf cBuscarEn.Text = "Fecha Salida" Then
                    nombre += "FechaSalida"                
                End If

                nombre += "] "

                If cBuscarporfecha.Text = "Exacta" Then
                    filtro += nombre + "= #" + cDesde.Value.ToString("MM-dd-yyyy") + "#"
                ElseIf cBuscarporfecha.Text = "Desde" Then
                    filtro += nombre + "> #" + cDesde.Value.ToString("MM-dd-yyyy") + "#"
                ElseIf cBuscarporfecha.Text = "Hasta" Then
                    filtro += nombre + "< #" + cDesde.Value.ToString("MM-dd-yyyy") + "#"
                ElseIf cBuscarporfecha.Text = "Entre" Then
                    filtro += nombre + "> #" + cDesde.Value.ToString("MM-dd-yyyy") + "# and " + nombre + " < #" + cHasta.Value.ToString("MM-dd-yyyy") + "#"
                End If

            Else

                If cBuscarEn.Text = "Numero Factura" Then
                    filtro += "[IDHistorial]=" + cBuscar.Text
                ElseIf cBuscarEn.Text = "Estado" Then
                    If cBuscar.Text.ToLower.StartsWith("p") Then
                        filtro += "[TipoPOF] = 0"
                    ElseIf cBuscar.Text.ToLower.StartsWith("o") Then
                        filtro += "[TipoPOF] = 1"
                    ElseIf cBuscar.Text.ToLower.StartsWith("f") Then
                        filtro += "[TipoPOF] = 2"
                    End If
                Else
                    filtro += "[" + cBuscarEn.Text

                    filtro += "] LIKE '"

                    Select Case cBuscarPor.Text
                        Case "El Principio"
                            filtro += cBuscar.Text + "%"
                        Case "El Final"
                            filtro += "%" + cBuscar.Text
                        Case "Contenido"
                            filtro += "%" + cBuscar.Text + "%"
                    End Select

                    filtro += "'"

                End If

            End If

            binCocheHistorial.Filter = filtro
        Else
            binCocheHistorial.Filter = ""
        End If

        If cClientes.Columns("Estado") Is Nothing Then
            Dim col As New DataGridViewTextBoxColumn
            col.HeaderText = "Estado"
            col.Name = "Estado"
            col.DataPropertyName = "Estado"
            col.Visible = Visible
            cClientes.Columns.Add(col)
            cClientes.Columns("Estado").DisplayIndex = 0
        End If

        For Each row As DataGridViewRow In cClientes.Rows
            Select Case row.Cells("TipoPOF").Value
                Case "0"
                    row.Cells("Estado").Value = "Presupuestado"
                Case "1"
                    row.Cells("Estado").Value = "Orden de Trabajo"
                Case "2"
                    row.Cells("Estado").Value = "Facturado"
            End Select
        Next
    End Sub

    Private Sub AnchoColumna(Optional ByVal Inicio As Boolean = False)

        RemoveHandler cClientes.ColumnWidthChanged, AddressOf cClientes_ColumnWidthChanged

        If GetRowOpciones.anMarca = 0 And GetRowOpciones.anMatricula = 0 And GetRowOpciones.anModelo = 0 Then
            cClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            GetRowOpciones.anMatricula = cClientes.Columns("Matricula").Width
            GetRowOpciones.anModelo = cClientes.Columns("Modelo").Width
            GetRowOpciones.anMarca = cClientes.Columns("Marca").Width
            GetRowOpciones.anColor = cClientes.Columns("Color").Width
            GetRowOpciones.anFechaEntrada = cClientes.Columns("FechaEntrada").Width
            GetRowOpciones.anFechaSalida = cClientes.Columns("FechaSalida").Width
            GetRowOpciones.anObservaciones = cClientes.Columns("Observaciones").Width
            GetRowOpciones.anTipoPOF = cClientes.Columns("Estado").Width
            GetRowOpciones.anIDHistorial = cClientes.Columns("IDHistorial").Width
            GetRowOpciones.anTotal = 100

            cClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

            GuardarOpciones()
        ElseIf Inicio Then
            cClientes.Columns("Matricula").Width = GetRowOpciones.anMatricula
            cClientes.Columns("Modelo").Width = GetRowOpciones.anModelo
            cClientes.Columns("Marca").Width = GetRowOpciones.anMarca
            cClientes.Columns("Color").Width = GetRowOpciones.anColor
            cClientes.Columns("FechaEntrada").Width = GetRowOpciones.anFechaEntrada
            cClientes.Columns("FechaSalida").Width = GetRowOpciones.anFechaSalida
            cClientes.Columns("Observaciones").Width = GetRowOpciones.anObservaciones
            cClientes.Columns("Estado").Width = GetRowOpciones.anTipoPOF
            cClientes.Columns("IDHistorial").Width = GetRowOpciones.anIDHistorial
        Else

            GetRowOpciones.anMatricula = cClientes.Columns("Matricula").Width
            GetRowOpciones.anModelo = cClientes.Columns("Modelo").Width
            GetRowOpciones.anMarca = cClientes.Columns("Marca").Width
            GetRowOpciones.anColor = cClientes.Columns("Color").Width
            GetRowOpciones.anFechaEntrada = cClientes.Columns("FechaEntrada").Width
            GetRowOpciones.anFechaSalida = cClientes.Columns("FechaSalida").Width
            GetRowOpciones.anObservaciones = cClientes.Columns("Observaciones").Width
            GetRowOpciones.anTipoPOF = cClientes.Columns("Estado").Width
            GetRowOpciones.anIDHistorial = cClientes.Columns("IDHistorial").Width

            GuardarOpciones()
        End If

        AddHandler cClientes.ColumnWidthChanged, AddressOf cClientes_ColumnWidthChanged

    End Sub

#End Region

#Region "Eventos"

    Private Sub BuscarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataBaseLib.Fuente(Me)
        Inicializar("Coche,Historial")

        Dim ds As New DataSet
        Dim cnn As New SqlClient.SqlConnection(My.MySettings.Default.DatosTallerConnectionString)
        cnn.Open()
        Dim cmd As New SqlClient.SqlCommand("select Historial.IDHistorial,Coche.IDCoche,POF.TipoPOF,Matricula,Marca,Modelo,Color,FechaEntrada,FechaSalida,Observaciones from Coche,Historial,POF where Coche.IDCoche=Historial.IDCoche and Historial.IDHistorial=POF.IDHistorial order by FechaEntrada Desc", cnn)
        Dim datab As New SqlClient.SqlDataAdapter(cmd)
        datab.Fill(ds)
        cnn.Close()
        RemoveHandler cClientes.ColumnWidthChanged, AddressOf cClientes_ColumnWidthChanged
        binCocheHistorial.DataSource = ds.Tables(0)

        cClientes.DataSource = binCocheHistorial

        cClientes.Columns("IDCoche").Visible = False
        cClientes.Columns("IDHistorial").HeaderText = "Num.Factura"

        cBuscarPor.SelectedIndex = 0
        cBuscarEn.SelectedIndex = 0
        cBuscarporfecha.SelectedIndex = 0

        cClientes.Columns("TipoPOF").Visible = False

        AddHandler cClientes.ColumnWidthChanged, AddressOf cClientes_ColumnWidthChanged

        AnchoColumna(True)

        For Each row As DataGridViewRow In cClientes.Rows
            Select Case row.Cells("TipoPOF").Value
                Case "0"
                    row.Cells("Estado").Value = "Presupuestado"
                Case "1"
                    row.Cells("Estado").Value = "Orden de Trabajo"
                Case "2"
                    row.Cells("Estado").Value = "Facturado"
            End Select
        Next

    End Sub

    Private Sub cBuscarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBuscarPor.SelectedIndexChanged, cBuscarEn.SelectedIndexChanged, cBuscar.TextChanged, cBuscarporfecha.SelectedIndexChanged, cDesde.ValueChanged, cHasta.ValueChanged

        If cBuscarEn.Text = "Fecha Entrada" Or cBuscarEn.Text = "Fecha Salida" Then
            cBuscar.Visible = False
            cBuscarporfecha.Visible = True
            cBuscarPor.Visible = False

            If cBuscarporfecha.Text = "Exacta" Then
                cDesde.Visible = True
                cHasta.Visible = False
            ElseIf cBuscarporfecha.Text = "Desde" Then
                cDesde.Visible = True
                cHasta.Visible = False
            ElseIf cBuscarporfecha.Text = "Hasta" Then
                cDesde.Visible = True
                cHasta.Visible = False
            ElseIf cBuscarporfecha.Text = "Entre" Then
                cDesde.Visible = True
                cHasta.Visible = True
            End If
        Else
            cDesde.Visible = False
            cHasta.Visible = False
            cBuscar.Visible = True
            cBuscarporfecha.Visible = False
            cBuscarPor.Visible = True
        End If

            Filtrar()
    End Sub

    Private Sub cCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cCancelar.Click
        IDCoche = -1
        IDHistorial = -1
        Me.Close()
    End Sub

    Private Sub cAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cAceptar.Click, cClientes.DoubleClick
        If cClientes.SelectedRows.Count > 0 Then
            IDCoche = cClientes.SelectedRows(0).Cells("IDCoche").Value
            IDHistorial = cClientes.SelectedRows(0).Cells("IDHistorial").Value
            Me.Close()
        Else
            MsgBox("No ha seleccionado ningun cliente")
        End If
    End Sub

    Private Sub cClientes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cClientes.KeyDown
        If cClientes.SelectedRows.Count > 0 Then
            If e.KeyValue = Keys.Enter Then
                IDCoche = cClientes.SelectedRows(0).Cells("IDCoche").Value
                IDHistorial = cClientes.SelectedRows(0).Cells("IDHistorial").Value
                Me.Close()
            End If
        Else
            MsgBox("No ha seleccionado ningún historial")
        End If
    End Sub

    Private Sub cClientes_ColumnWidthChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewColumnEventArgs)

        AnchoColumna()

    End Sub

    Private Sub cClientes_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cClientes.Sorted
        If cClientes.Columns("Estado") Is Nothing Then
            Dim col As New DataGridViewTextBoxColumn
            col.HeaderText = "Estado"
            col.Name = "Estado"
            col.DataPropertyName = "Estado"
            col.Visible = Visible
            cClientes.Columns.Add(col)
            cClientes.Columns("Estado").DisplayIndex = 0
        End If

        For Each row As DataGridViewRow In cClientes.Rows
            Select row.Cells("TipoPOF").Value
                Case "0"
                    row.Cells("Estado").Value = "Presupuestado"
                Case "1"
                    row.Cells("Estado").Value = "Orden de Trabajo"
                Case "2"
                    row.Cells("Estado").Value = "Facturado"
            End Select
        Next

    End Sub

#End Region

End Class
