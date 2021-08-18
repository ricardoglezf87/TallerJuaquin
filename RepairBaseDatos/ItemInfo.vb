

Public Class ItemInfo
    Public StartTime As DateTime
    Public EndTime As DateTime
    Public Text As String
    Public A As Integer
    Public R As Integer
    Public G As Integer
    Public B As Integer    
    Public FechaAviso As DateTime
    Public ID As Integer


    Public Sub New()

    End Sub

    Public Sub setFecha(ByVal fec As DateTime, ByVal hora As Integer, ByVal min As Integer)

        FechaAviso = New DateTime(fec.Year, fec.Month, fec.Day, hora, min, 0)

    End Sub

    Public Sub New(ByVal _startTime As DateTime, ByVal _endTime As DateTime, ByVal _text As String, ByVal _color As Color, ByVal _FechaAviso As DateTime)
        StartTime = _startTime
        EndTime = _endTime
        Text = _text
        A = _color.A
        R = _color.R
        G = _color.G
        B = _color.B
        FechaAviso = _FechaAviso
    End Sub

    Public Sub New(ByVal _startTime As DateTime, ByVal _endTime As DateTime, ByVal _text As String, ByVal _color As Color)
        StartTime = _startTime
        EndTime = _endTime
        Text = _text
        A = _color.A
        R = _color.R
        G = _color.G
        B = _color.B
        FechaAviso = DateTime.MinValue
    End Sub

    Public Sub New(ByVal _ID As Integer, ByVal _startTime As DateTime, ByVal _endTime As DateTime, ByVal _text As String, ByVal _color As Color)
        ID = _ID
        StartTime = _startTime
        EndTime = _endTime
        Text = _text
        A = _color.A
        R = _color.R
        G = _color.G
        B = _color.B
        FechaAviso = DateTime.MinValue
    End Sub

    Public Sub New(ByVal _ID As Integer, ByVal _startTime As DateTime, ByVal _endTime As DateTime, ByVal _text As String, ByVal _color As Color, ByVal _fechaaviso As DateTime)
        ID = _ID
        StartTime = _startTime
        EndTime = _endTime
        Text = _text
        A = _color.A
        R = _color.R
        G = _color.G
        B = _color.B
        FechaAviso = _fechaaviso
    End Sub

End Class

