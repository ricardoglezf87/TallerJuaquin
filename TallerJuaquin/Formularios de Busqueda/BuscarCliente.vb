Imports System.Windows.Forms
Imports DataBaseLib


Public Class BuscarCliente

    Public ID As Integer = 0
    Private binCliente As New BindingSource
    Private ds As New DatosTallerDataSet

#Region "Funciones"

    Private Sub Filtrar()
        If cBuscar.Text <> String.Empty Then
            Dim filtro As String = String.Empty
            filtro += "["

            Select Case cBuscarEn.Text
                Case "Nombre Cliente"
                    filtro += "NombreCliente"
                Case "Nombre Comercial"
                    filtro += "NombreComercial"
                Case "Codigo Postal"
                    filtro += "CP"
                Case Else
                    filtro += cBuscarEn.Text
            End Select

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

            binCliente.Filter = filtro
        Else
            binCliente.Filter = ""
        End If
    End Sub

    Private Sub AnchoColumna(Optional ByVal Inicio As Boolean = False)

        RemoveHandler cClientes.ColumnWidthChanged, AddressOf cClientes_ColumnWidthChanged

        If GetRowOpciones.anNombreCliente = 0 And GetRowOpciones.anPoblacion = 0 And GetRowOpciones.anDNI = 0 Then
            cClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            GetRowOpciones.anNombreCliente = cClientes.Columns("NombreCliente").Width
            GetRowOpciones.anNombreComercial = cClientes.Columns("NombreComercial").Width
            GetRowOpciones.anCP = cClientes.Columns("CP").Width
            GetRowOpciones.anPoblacion = cClientes.Columns("Poblacion").Width
            GetRowOpciones.anProvincia = cClientes.Columns("Provincia").Width
            GetRowOpciones.anDNI = cClientes.Columns("DNI").Width
            GetRowOpciones.anEmail = cClientes.Columns("Email").Width
            GetRowOpciones.anComentario = cClientes.Columns("Comentario").Width
            GetRowOpciones.anAseguradora = cClientes.Columns("Aseguradora").Width

            cClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None

            GuardarOpciones()
        ElseIf Inicio Then
            cClientes.Columns("NombreCliente").Width = GetRowOpciones.anNombreCliente
            cClientes.Columns("NombreComercial").Width = GetRowOpciones.anNombreComercial
            cClientes.Columns("CP").Width = GetRowOpciones.anCP
            cClientes.Columns("Poblacion").Width = GetRowOpciones.anPoblacion
            cClientes.Columns("Provincia").Width = GetRowOpciones.anProvincia
            cClientes.Columns("DNI").Width = GetRowOpciones.anDNI
            cClientes.Columns("Email").Width = GetRowOpciones.anEmail
            cClientes.Columns("Comentario").Width = GetRowOpciones.anComentario
            cClientes.Columns("Aseguradora").Width = GetRowOpciones.anAseguradora
        Else

            GetRowOpciones.anNombreCliente = cClientes.Columns("NombreCliente").Width
            GetRowOpciones.anNombreComercial = cClientes.Columns("NombreComercial").Width
            GetRowOpciones.anCP = cClientes.Columns("CP").Width
            GetRowOpciones.anPoblacion = cClientes.Columns("Poblacion").Width
            GetRowOpciones.anProvincia = cClientes.Columns("Provincia").Width
            GetRowOpciones.anDNI = cClientes.Columns("DNI").Width
            GetRowOpciones.anEmail = cClientes.Columns("Email").Width
            GetRowOpciones.anComentario = cClientes.Columns("Comentario").Width
            GetRowOpciones.anAseguradora = cClientes.Columns("Aseguradora").Width

            GuardarOpciones()
        End If

        AddHandler cClientes.ColumnWidthChanged, AddressOf cClientes_ColumnWidthChanged

    End Sub

#End Region

#Region "Eventos"

    Private Sub BuscarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataBaseLib.Fuente(Me)
        Inicializar("Cliente", ds)
        binCliente.DataSource = ds.Cliente
        cClientes.DataSource = binCliente
        cClientes.Columns("IDCliente").Visible = False
        cBuscarPor.SelectedIndex = 0
        cBuscarEn.SelectedIndex = 0
        AnchoColumna(True)
    End Sub

    Private Sub cBuscarPor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBuscarPor.SelectedIndexChanged, cBuscarEn.SelectedIndexChanged, cBuscar.TextChanged
        Filtrar()
    End Sub

    Private Sub cCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cCancelar.Click
        ID = -1
        Me.Close()
    End Sub

    Private Sub cAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cAceptar.Click, cClientes.DoubleClick
        If cClientes.SelectedRows.Count > 0 Then
            ID = cClientes.SelectedRows(0).Cells("IDCliente").Value
            Me.Close()
        Else
            MsgBox("No ha seleccionado ningún cliente")
        End If
    End Sub

    Private Sub cClientes_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cClientes.KeyDown
        If cClientes.SelectedRows.Count > 0 Then
            If e.KeyValue = Keys.Enter Then
                ID = cClientes.SelectedRows(0).Cells("IDCliente").Value
                Me.Close()
            End If
        Else
            MsgBox("No ha seleccionado ningún cliente")
        End If
    End Sub

    Private Sub cClientes_ColumnWidthChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles cClientes.ColumnWidthChanged
        AnchoColumna()
    End Sub

#End Region

End Class
