Imports System.Windows.Forms
Imports DataBaseLib

Public Class BuscarCoche
    Public IDCliente As Integer = 0
    Public IDCoche As Integer = 0
    Private binCoche As New BindingSource
    Private ds As New DatosTallerDataSet

#Region "Funciones"

    Private Sub Filtrar()
        If cBuscar.Text <> String.Empty Then
            Dim filtro As String = String.Empty
            filtro += "[" + cBuscarEn.Text + "] LIKE '"

            Select Case cBuscarPor.Text
                Case "El Principio"
                    filtro += cBuscar.Text + "%"
                Case "El Final"
                    filtro += "%" + cBuscar.Text
                Case "Contenido"
                    filtro += "%" + cBuscar.Text + "%"
            End Select

            filtro += "'"

            binCoche.Filter = filtro
        Else
            binCoche.Filter = ""
        End If
    End Sub

    Private Sub AnchoColumna(Optional ByVal Inicio As Boolean = False)

        RemoveHandler cClientes.ColumnWidthChanged, AddressOf cClientes_ColumnWidthChanged

        If GetRowOpciones.anMarca = 0 And GetRowOpciones.anMatricula = 0 And GetRowOpciones.anModelo = 0 Then
            cClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            GetRowOpciones.anMatricula = cClientes.Columns("Matricula").Width
            GetRowOpciones.anModelo = cClientes.Columns("Modelo").Width
            GetRowOpciones.anMarca = cClientes.Columns("Marca").Width
            GetRowOpciones.anColor = cClientes.Columns("Color").Width
            GetRowOpciones.anObservaciones = 100
            GetRowOpciones.anComentario = 100
            GetRowOpciones.anTotal = 100
            GetRowOpciones.anFechaEntrada = 100
            GetRowOpciones.anFechaSalida = 100

            cClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

            GuardarOpciones()
        ElseIf Inicio Then
            cClientes.Columns("Matricula").Width = GetRowOpciones.anMatricula
            cClientes.Columns("Modelo").Width = GetRowOpciones.anModelo
            cClientes.Columns("Marca").Width = GetRowOpciones.anMarca
            cClientes.Columns("Color").Width = GetRowOpciones.anColor          
        Else

            GetRowOpciones.anMatricula = cClientes.Columns("Matricula").Width
            GetRowOpciones.anModelo = cClientes.Columns("Modelo").Width
            GetRowOpciones.anMarca = cClientes.Columns("Marca").Width
            GetRowOpciones.anColor = cClientes.Columns("Color").Width            

            GuardarOpciones()
        End If

        AddHandler cClientes.ColumnWidthChanged, AddressOf cClientes_ColumnWidthChanged

    End Sub

#End Region

#Region "Eventos"

    Private Sub BuscarCoche_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataBaseLib.Fuente(Me)
        Inicializar("Coche", ds)
        binCoche.DataSource = ds.Coche
        cClientes.DataSource = binCoche
        cClientes.Columns("IDCoche").Visible = False
        cClientes.Columns("IDCliente").Visible = False
        cBuscarPor.SelectedIndex = 0
        cBuscarEn.SelectedIndex = 0
        AnchoColumna(True)
    End Sub

    Private Sub cBuscarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBuscarPor.SelectedIndexChanged, cBuscarEn.SelectedIndexChanged, cBuscar.TextChanged
        Filtrar()
    End Sub

    Private Sub cCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cCancelar.Click
        IDCoche = -1
        IDCliente = -1
        Me.Close()
    End Sub

    Private Sub cAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cAceptar.Click, cClientes.DoubleClick
        If cClientes.SelectedRows.Count > 0 Then
            IDCoche = cClientes.SelectedRows(0).Cells("IDCoche").Value
            IDCliente = cClientes.SelectedRows(0).Cells("IDCliente").Value
            Me.Close()
        Else
            MsgBox("No ha seleccionado ningún coche")
        End If
    End Sub

    Private Sub cClientes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cClientes.KeyDown
        If cClientes.SelectedRows.Count > 0 Then
            If e.KeyValue = Keys.Enter Then
                IDCoche = cClientes.SelectedRows(0).Cells("IDCoche").Value
                IDCliente = cClientes.SelectedRows(0).Cells("IDCliente").Value
                Me.Close()
            End If
        Else
            MsgBox("No ha seleccionado ningún coche")
        End If
    End Sub

    Private Sub cClientes_ColumnWidthChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles cClientes.ColumnWidthChanged
        AnchoColumna()
    End Sub

#End Region

End Class
