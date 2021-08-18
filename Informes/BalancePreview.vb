Imports DataBaseLib

Public Class BalancePreview

    Private Filtro As String
    Private TipoGrafio As String
    Public Compras As Boolean = False
    Public debug As Boolean = False
    Private IDCliente As Integer

    Private Sub FiltrarID()        
        If IDCliente <> 0 Then
            If dsDatos.Coche.Count = 0 Then
                Inicializar("coche")
            End If

            If dsDatos.Historial.Count = 0 Then
                Inicializar("historial")
            End If

            If dsDatos.POF.Count = 0 Then
                Inicializar("pof")
            End If

            For Each i As DatosTallerDataSet.CocheRow In dsDatos.Coche.Select("IDCliente=" + IDCliente.ToString)
                For Each j As DatosTallerDataSet.HistorialRow In dsDatos.Historial.Select("IDCoche=" + i.IDCoche.ToString)
                    If dsDatos.POF.FindByIDHistorial(j.IDHistorial).TipoPOF = 2 Then
                        If Filtro.Contains("or") Then
                            Filtro += " or IDHistorial=" + j.IDHistorial.ToString
                        Else
                            Filtro += " and IDHistorial=" + j.IDHistorial.ToString
                        End If
                    End If
                Next
            Next
            If Not Filtro.Contains("IDHistorial") Then
                Filtro = "TipoPOF=100"
            End If
        End If
    End Sub

    Public Sub New(ByVal _filtro As String, ByVal _tipografio As String, ByVal _IDCliente As Integer)

        InitializeComponent()

        Filtro = _filtro
        TipoGrafio = _tipografio
        IDCliente = _IDCliente

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dsDatos.Balance.Clear()

        Dim ba As New DatosTallerDataSetTableAdapters.BalanceTableAdapter
        ba.Fill(dsDatos.Balance)

        For Each row As DatosTallerDataSet.BalanceRow In dsDatos.Balance.Rows

            If row.Costo <> 0 Then
                row.Costo = row.PVP - row.Costo
                row.PVP = 0
            Else
                row.PVP += row.PVP * (row.IVA / 100)
            End If
            row.Total = 0
        Next

        If Compras Then

            Inicializar("compras")

            For Each row As DatosTallerDataSet.ComprasRow In dsDatos.Compras.Rows

                dsDatos.Balance.AddBalanceRow(0, 2, row.Fecha, 0, 0, row.Precio, 1, 0, 0, 0, 0, 0)

            Next

        End If

        FiltrarID()
        Me.BalanceBindingSource.DataSource = dsDatos.Balance.Select(Filtro)

        Dim param As New Microsoft.Reporting.WinForms.ReportParameter("TipoGrafica", TipoGrafio, True)

        Dim resp As Boolean = False

        If Not Filtro.Contains("Costo") Then
            resp = True
        End If

        Dim param1 As New Microsoft.Reporting.WinForms.ReportParameter("Repuestos", resp, True)

        resp = False

        If Not Filtro.Contains("PVP") Then
            resp = True
        End If

        Dim param2 As New Microsoft.Reporting.WinForms.ReportParameter("ManoObra", resp, True)

        resp = False

        If Compras Then
            resp = True
        End If

        Dim param3 As New Microsoft.Reporting.WinForms.ReportParameter("Compras", resp, True)

        Me.ReportViewer1.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter() {param, param1, param2, param3})

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReportViewer1_RenderingComplete(ByVal sender As System.Object, ByVal e As Microsoft.Reporting.WinForms.RenderingCompleteEventArgs) Handles ReportViewer1.RenderingComplete
        Me.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent

        If debug Then
            Me.Close()
        End If
    End Sub
End Class