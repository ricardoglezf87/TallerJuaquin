Imports DataBaseLib
Imports CrystalDecisions.CrystalReports.Engine

Public Class CRFacturaPreview

    Private IDPOF As Integer
    Private IDCliente As Integer
    Private IDCoche As Integer
    Private OcultaManoObra As Boolean
    Private OcultaRepuestos As Boolean
    Private imprimir As Boolean

    Public Sub New(ByVal _IDPOF As Integer, ByVal _IDCoche As Integer, ByVal _IDCliente As Integer, ByVal _OcultaManoObra As Boolean, ByVal _OcultaRepuestos As Boolean, ByVal _imprimir As Boolean)

        InitializeComponent()

        IDPOF = _IDPOF
        IDCliente = _IDCliente
        IDCoche = _IDCoche
        OcultaManoObra = _OcultaManoObra
        OcultaRepuestos = _OcultaRepuestos
        imprimir = _imprimir

    End Sub

    Private Sub CRFacturaPreview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        IniciarOpciones()

        dsDatos.POF.Clear()
        Dim ba As New DatosTallerDataSetTableAdapters.POFTableAdapter
        ba.FillByIDHistorial(dsDatos.POF, IDPOF)

        dsDatos.ArticuloPOF.Clear()
        Dim bb As New DatosTallerDataSetTableAdapters.ArticuloPOFTableAdapter
        bb.FillByIDHistorial(dsDatos.ArticuloPOF, IDPOF)

        dsDatos.ClienteCoche.Clear()
        Dim clicoc As New DatosTallerDataSetTableAdapters.ClienteCocheTableAdapter
        clicoc.FillByIDs(dsDatos.ClienteCoche, IDCoche, IDCliente)

        Dim existeMano As Boolean = False
        Dim existeRepu As Boolean = False

        For i As Integer = 0 To (dsDatos.ArticuloPOF.Rows.Count - 1) Or (existeMano And existeRepu)

            If dsDatos.ArticuloPOF.Rows(i).Item("Costo") > 0 Then
                existeRepu = True
            End If

            If dsDatos.ArticuloPOF.Rows(i).Item("Costo") = 0 Then
                existeMano = True
            End If
        Next

        If Not existeMano Then
            Factura1.GroupHeaderSection1.SectionFormat.EnableSuppress = True
        ElseIf Not existeRepu Then
            Factura1.GroupHeaderSection3.SectionFormat.EnableSuppress = True
        Else
            Factura1.GroupHeaderSection4.SectionFormat.EnableSuppress = False
        End If

        If dsDatos.POF.Rows(0).Item("TipoPOF").ToString <> "2" Then
            dsDatos.POF.Rows(0).Item("Fecha") = Now
        End If

            CType(Factura1.Subreports(0).ReportDefinition.ReportObjects("PVP2"), FieldObject).ObjectFormat.EnableSuppress = OcultaManoObra
            CType(Factura1.Subreports(0).ReportDefinition.ReportObjects("Total1"), FieldObject).ObjectFormat.EnableSuppress = OcultaManoObra

            CType(Factura1.Subreports(1).ReportDefinition.ReportObjects("PVP2"), FieldObject).ObjectFormat.EnableSuppress = OcultaRepuestos
            CType(Factura1.Subreports(1).ReportDefinition.ReportObjects("Total1"), FieldObject).ObjectFormat.EnableSuppress = OcultaRepuestos

            Factura1.SetDataSource(dsDatos)

            If imprimir Then
                CrystalReportViewer1.PrintReport()
            End If

    End Sub

End Class