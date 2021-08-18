Imports DataBaseLib

Public Class Inicio

#Region "Eventos"

    Private Sub cBuscarHistorial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBuscarHistorial.Click
        Dim frm As New BuscarHistorial
        frm.ShowDialog()
        If frm.IDHistorial > 0 Then
            Dim f As New HistorialCoche(frm.IDHistorial)
            f.ShowDialog()
        End If
    End Sub

    Private Sub cNuevaOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cNuevaOrdenTrabajo.Click
        CerrarBase()
        Dim frm As New OrdenTrabajo
        frm.ShowDialog()
    End Sub

    Private Sub cBuscarFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBuscarFacturas.Click
        CerrarBase()
        Dim frm As New BuscarFactura
        frm.ShowDialog()
        If frm.IDHistorial > 0 Then
            Dim frm1 As New Facturas(frm.IDCliente, frm.IDCoche, frm.IDHistorial)
            frm1.ShowDialog()
        End If
    End Sub

    Private Sub cGestioncliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cClientes.Click
        CerrarBase()
        Dim frm As New DatosCliente
        frm.ShowDialog()
    End Sub

    Private Sub OpcionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cOpciones.Click
        CerrarBase()
        Dim frm As New Opcion
        frm.ShowDialog()
        ActualizarFoto()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cSalir.Click
        Environment.Exit(0)
    End Sub

    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            IniciarOpciones()
        Catch ex As Exception
            MsgBox("Error en opciones")
        End Try

        Try
            ActualizarFoto()
        Catch ex As Exception
            MsgBox("Error en imagenes")
        End Try
        DataBaseLib.Fuente(Me)
    End Sub

    Private Sub GenBalan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenBalan.Click
        Dim frm As New GenerarInforme
        frm.ShowDialog()
    End Sub

    Private Sub GenManRep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenManRep.Click
        Dim frm As New Agenda.GestionAgenda
        frm.ShowDialog()
    End Sub

    Private Sub cCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cCompras.Click
        Dim frm As New Compras
        frm.ShowDialog()
    End Sub

#End Region

#Region "Funciones"
    Private Sub ActualizarFoto()

        If My.Computer.FileSystem.FileExists(GetRowOpciones.RutaFondoPantalla) Then
            cFondo.Image = Image.FromFile(GetRowOpciones.RutaFondoPantalla)
        Else            
            cFondo.Image = Image.FromFile(Environment.CurrentDirectory + "\Img\car6.jpg")
        End If

        Select Case GetRowOpciones.TamañoFondoPantalla
            Case "Normal"
                cFondo.SizeMode = PictureBoxSizeMode.Normal
            Case "StretchImage"
                cFondo.SizeMode = PictureBoxSizeMode.StretchImage
            Case "AutoSize"
                cFondo.SizeMode = PictureBoxSizeMode.AutoSize
            Case "CenterImage"
                cFondo.SizeMode = PictureBoxSizeMode.CenterImage
            Case "Zoom"
                cFondo.SizeMode = PictureBoxSizeMode.Zoom
        End Select

    End Sub

#End Region

End Class