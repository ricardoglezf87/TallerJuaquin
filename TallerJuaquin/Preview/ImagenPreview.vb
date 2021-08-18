Imports SizableImg
Imports DataBaseLib

Public Class ImagenPreview

    Private Vista As ScalableImage

    Public Sub New(ByVal img As Image)
        InitializeComponent()


        Vista = New ScalableImage(Me.Panel1, img)
        Vista.MinZoom = 0.01
        Vista.MaxZoom = 40

        cEscalar.SelectedIndex = 2
        Vista.CurZoom = GetRowOpciones.Porcentaje / 100

    End Sub



    Public Sub New(ByVal IDImgHis As Integer, ByVal IDHist As Integer)
        InitializeComponent()

        IniciarImagenes()

        Dim men As New IO.MemoryStream(BuscarImagenHistorial(IDImgHis, IDHist).Imagen)

        Vista = New ScalableImage(Me.Panel1, Image.FromStream(men))
        Vista.MinZoom = 0.01
        Vista.MaxZoom = 40

        Vista.CurZoom = 10


        cEscalar.SelectedIndex = 2
        Vista.CurZoom = GetRowOpciones.Porcentaje / 100

    End Sub

    Private Sub cEscalar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cEscalar.SelectedIndexChanged
        If Not Vista Is Nothing Then
            Vista.CurZoom = Int(cEscalar.Text.Replace("%", "")) / 100
        End If
    End Sub

End Class