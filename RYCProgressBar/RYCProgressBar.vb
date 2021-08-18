Imports System.Drawing
Imports System.Windows.Forms

Public Class RYCProgressBar
    Inherits Control

#Region "Propiedades"

    Private _colorbarra As Color = Color.Blue
    Public Property ColorBarra() As Color
        Get
            Return _colorbarra
        End Get
        Set(ByVal Value As Color)
            _colorbarra = Value

            Me.Invalidate()
        End Set
    End Property

    Private _minimo As Integer = 0
    Public Property Minimo() As Integer
        Get
            Return _minimo
        End Get
        Set(ByVal Value As Integer)

            If (Value < 0) Then
                _minimo = 0
            End If

            If (Value > _maximo) Then
                _minimo = Value
                _maximo = Value
            End If

            If (_valor < _minimo) Then
                _valor = _minimo
            End If

            Me.Invalidate()
        End Set
    End Property

    Private _maximo As Integer = 100
    Public Property Maximo() As Integer
        Get
            Return _maximo
        End Get
        Set(ByVal Value As Integer)

            If (Value < _minimo) Then
                _minimo = Value
            End If
            _maximo = Value

            If (_valor > _maximo) Then
                _valor = _maximo
            End If

            Me.Invalidate()
        End Set
    End Property

    Private _valor As Integer = 0
    Public Property Valor() As Integer
        Get
            Return _valor
        End Get
        Set(ByVal Value As Integer)

            If (Value < _minimo) Then
                _valor = _minimo
            ElseIf (Value > _maximo) Then
                _valor = _maximo
            Else
                _valor = Value
            End If

            Porcentaje = (_valor - _minimo) / (_maximo - _minimo)

            Me.Invalidate()

        End Set
    End Property

    Private _stepby As Integer = 1
    Public Property Stepby() As Integer
        Get
            Return _stepby
        End Get
        Set(ByVal value As Integer)
            _stepby = value
        End Set
    End Property

    Private _porcentaje As Decimal=0
    Public Property Porcentaje() As Decimal
        Get
            Return _porcentaje
        End Get
        Set(ByVal value As Decimal)
            _porcentaje = value
        End Set
    End Property

#End Region

#Region "Funciones"

    Private Sub Draw3DBorder(ByVal g As Graphics)
        Dim PenWidth As Integer = Pens.White.Width
        g.DrawLine(Pens.DarkGray, New Point(Me.ClientRectangle.Left, Me.ClientRectangle.Top), New Point(Me.ClientRectangle.Width - PenWidth, Me.ClientRectangle.Top))
        g.DrawLine(Pens.DarkGray, New Point(Me.ClientRectangle.Left, Me.ClientRectangle.Top), New Point(Me.ClientRectangle.Left, Me.ClientRectangle.Height - PenWidth))
        g.DrawLine(Pens.White, New Point(Me.ClientRectangle.Left, Me.ClientRectangle.Height - PenWidth), New Point(Me.ClientRectangle.Width - PenWidth, Me.ClientRectangle.Height - PenWidth))
        g.DrawLine(Pens.White, New Point(Me.ClientRectangle.Width - PenWidth, Me.ClientRectangle.Top), New Point(Me.ClientRectangle.Width - PenWidth, Me.ClientRectangle.Height - PenWidth))
    End Sub

    Public Sub Avanzar()
        Valor += Stepby        
    End Sub

#End Region

#Region "Evento"

    Public Sub New()
        Porcentaje = 0
        Stepby = 1
        Valor = 0
        Minimo = 0
        Maximo = 100
        ColorBarra = Color.Blue
    End Sub

    Public Sub New(ByVal _Minimo_ As Integer, ByVal _Maximo_ As Integer)
        Porcentaje = 0
        Stepby = 1
        Valor = _Minimo_
        Minimo = _Minimo_
        Maximo = _Maximo_
        ColorBarra = Color.Blue
    End Sub

    Public Sub New(ByVal _Minimo_ As Integer, ByVal _Maximo_ As Integer, ByVal _StepBy_ As Integer)        
        Porcentaje = 0
        Stepby = _StepBy_
        Valor = _Minimo_
        Minimo = _Minimo_
        Maximo = _Maximo_
        ColorBarra = Color.Blue
    End Sub

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        Me.Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        Dim brush As SolidBrush = New SolidBrush(_colorbarra)

        Dim rect As Rectangle = Me.ClientRectangle
        rect.Width = rect.Width * Porcentaje

        g.FillRectangle(brush, rect)
        Draw3DBorder(g)
        brush.Dispose()
        g.Dispose()
    End Sub

#End Region

End Class
