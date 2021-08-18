Imports System.Windows.Forms
Imports DataBaseLib

Public Class FacturaPreview

    Private IDPOF As Integer
    Private TipoFactura As Integer
    Private IDCliente As Integer
    Private IDCoche As Integer
    Private Imprimir As Boolean
    Private Ocultar As Boolean
    Private Ocultar2 As Boolean

    Public Sub New(ByVal _IDPOF As Integer, ByVal _TipoFactura As Integer, ByVal _IDCliente As Integer, ByVal _IDCoche As Integer, ByVal _Ocultar As Boolean, ByVal _Ocultar2 As Boolean, Optional ByVal _Imprimir As Boolean = False)

        InitializeComponent()

        IDPOF = _IDPOF
        TipoFactura = _TipoFactura
        IDCliente = _IDCliente
        IDCoche = _IDCoche
        Imprimir = _Imprimir
        Ocultar = _Ocultar
        Ocultar2 = _Ocultar2

    End Sub

    Private Sub FacturaPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        IniciarOpciones()
        Me.OpcionesBindingSource.DataSource = dsDatos.Opciones

        dsDatos.Balance.Clear()
        Dim ba As New DatosTallerDataSetTableAdapters.BalanceTableAdapter
        ba.Fill(dsDatos.Balance)
        Me.BalanceBindingSource.DataSource = dsDatos.Balance

        dsDatos.ClienteCoche.Clear()
        Dim clicoc As New DatosTallerDataSetTableAdapters.ClienteCocheTableAdapter
        clicoc.Fill(dsDatos.ClienteCoche)
        Me.ClienteCocheBindingSource.DataSource = dsDatos.ClienteCoche

        Me.BlancoBindingSource.DataSource = dsDatos.Blanco

        Dim param1 As New Microsoft.Reporting.WinForms.ReportParameter("IDHistorial", IDPOF, True)
        Dim param2 As New Microsoft.Reporting.WinForms.ReportParameter("TipoFactura", TipoFactura, True)
        Dim param3 As New Microsoft.Reporting.WinForms.ReportParameter("IDCliente", IDCliente, True)
        Dim param4 As New Microsoft.Reporting.WinForms.ReportParameter("IDCoche", IDCoche, True)
        Dim param5 As New Microsoft.Reporting.WinForms.ReportParameter("TamTit", GetRowOpciones.TamTit, True)
        Dim param6 As New Microsoft.Reporting.WinForms.ReportParameter("TamFactPresu", GetRowOpciones.TamFactPresu, True)
        Dim param7 As New Microsoft.Reporting.WinForms.ReportParameter("TamCabecera", GetRowOpciones.TamCabecera, True)
        Dim param8 As New Microsoft.Reporting.WinForms.ReportParameter("TamCliDet", GetRowOpciones.TamCliDet, True)
        Dim param9 As New Microsoft.Reporting.WinForms.ReportParameter("TamCliTit", GetRowOpciones.TamCliTit, True)
        Dim param10 As New Microsoft.Reporting.WinForms.ReportParameter("TamDetDatos", GetRowOpciones.TamDetDatos, True)
        Dim param11 As New Microsoft.Reporting.WinForms.ReportParameter("TamTitDatos", GetRowOpciones.TamTitDatos, True)
        Dim param12 As New Microsoft.Reporting.WinForms.ReportParameter("TamBlanco", GetRowOpciones.TamBlanco, True)

        Dim param13 As Microsoft.Reporting.WinForms.ReportParameter = Nothing

        If TipoFactura = 2 Then
            If dsDatos.Historial.Count = 0 Then
                dsDatos.Historial.Clear()
                Dim his As New DatosTallerDataSetTableAdapters.HistorialTableAdapter
                his.Fill(dsDatos.Historial)
            End If
            param13 = New Microsoft.Reporting.WinForms.ReportParameter("FechaSalida", dsDatos.Historial.FindByIDHistorial(IDPOF).FechaSalida, True)
        Else
            param13 = New Microsoft.Reporting.WinForms.ReportParameter("FechaSalida", Now, True)
        End If

        Dim param14 As New Microsoft.Reporting.WinForms.ReportParameter("Ocultar", Ocultar, True)
        Dim param15 As New Microsoft.Reporting.WinForms.ReportParameter("Ocultar2", Ocultar2, True)

        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter() {param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15})

        Dim tot As Integer = dsDatos.Balance.Select("IDHistorial=" + IDPOF.ToString).Length
        dsDatos.Blanco.Clear()
        If tot < 31 Then
            If dsDatos.Balance.Select("Costo<>0 and IDHistorial=" + IDPOF.ToString).Length > 0 Then
                tot += 2
            End If
            For i As Integer = 0 To 30 - tot
                dsDatos.Blanco.AddBlancoRow(" ")
            Next
        ElseIf tot > 31 Then
            If dsDatos.Balance.Select("Costo<>0 and IDHistorial=" + IDPOF.ToString).Length > 0 Then
                tot += 2
            End If
            For i As Integer = 0 To 85 - tot
                dsDatos.Blanco.AddBlancoRow(" ")
            Next
        End If

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReportViewer1_RenderingComplete(ByVal sender As System.Object, ByVal e As Microsoft.Reporting.WinForms.RenderingCompleteEventArgs) Handles ReportViewer1.RenderingComplete
        If Imprimir Then
            Me.Hide()
            Me.ReportViewer1.PrintDialog()
            Me.Close()
        Else
            Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        End If
    End Sub

End Class
