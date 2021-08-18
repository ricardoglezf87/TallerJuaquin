Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RYCCheckBox
    Inherits Control

#Region "Propiedades"

    Public Event MarcadoChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    Private _marcado As Boolean = False
    Public Property Marcado() As Boolean
        Get
            Return _marcado
        End Get
        Set(ByVal value As Boolean)
            _marcado = value
            Me.Invalidate()
            RaiseEvent MarcadoChanged(Me, New System.EventArgs())
        End Set
    End Property

    Public Enum eTipoMarcado
        Tick
        Equis
    End Enum
    Private _tipomarcado As eTipoMarcado = eTipoMarcado.Tick
    Public Property TipoMarcado() As eTipoMarcado
        Get
            Return _tipomarcado
        End Get
        Set(ByVal value As eTipoMarcado)
            _tipomarcado = value
        End Set
    End Property

    Private _colormarcado As Color = Color.Blue
    Public Property ColorMarcado() As Color
        Get
            Return _colormarcado
        End Get
        Set(ByVal value As Color)
            _colormarcado = value
        End Set
    End Property

#End Region


#Region "Funciones"

    Private Sub Draw3DBorder(ByVal g As Graphics)
        Dim PenWidth As Integer = Pens.White.Width
        g.DrawLine(Pens.DarkGray, Me.ClientRectangle.Left, Me.ClientRectangle.Top, Me.ClientRectangle.Width - PenWidth, Me.ClientRectangle.Top)
        g.DrawLine(Pens.DarkGray, Me.ClientRectangle.Left, Me.ClientRectangle.Top, Me.ClientRectangle.Left, Me.ClientRectangle.Height - PenWidth)
        g.DrawLine(Pens.White, Me.ClientRectangle.Left, Me.ClientRectangle.Height - PenWidth, Me.ClientRectangle.Width - PenWidth, Me.ClientRectangle.Height - PenWidth)
        g.DrawLine(Pens.White, Me.ClientRectangle.Width - PenWidth, Me.ClientRectangle.Top, Me.ClientRectangle.Width - PenWidth, Me.ClientRectangle.Height - PenWidth)

    End Sub

    Private Sub DrawBorder(ByVal g As Graphics)

        Dim x As Integer = Me.ClientRectangle.X
        Dim y As Integer = Me.ClientRectangle.Y
        Dim an As Integer = Me.ClientRectangle.Width
        Dim al As Integer = Me.ClientRectangle.Height

        Dim p As New Pen(Color.DarkGray, an * 0.05)

        Dim pan As Integer = p.Width

        Dim bru As New LinearGradientBrush(New PointF(x, y), New PointF(an, al), Color.LightGray, Color.White)

        g.FillRectangle(bru, x, y, an, al)

        g.DrawLine(p, x, y, an - pan, y)
        g.DrawLine(p, x, y, x, al - pan)
        g.DrawLine(p, x, al - pan, an - pan, al - pan)
        g.DrawLine(p, an - pan, y, an - pan, al - pan)

        p.Color = Color.White

        x += pan
        y += pan
        an -= pan
        al -= pan

        g.DrawLine(p, x, y, an - pan, y)
        g.DrawLine(p, x, y, x, al - pan)
        g.DrawLine(p, x, al - pan, an - pan, al - pan)
        g.DrawLine(p, an - pan, y, an - pan, al - pan)

        p.Color = Color.LightGray

        x += pan
        y += pan
        an -= pan
        al -= pan

        g.DrawLine(p, x, y, an - pan, y)
        g.DrawLine(p, x, y, x, al - pan)
        g.DrawLine(p, x, al - pan, an - pan * 2, al - pan)
        g.DrawLine(p, an - pan, y, an - pan, al - pan)

    End Sub

#End Region

#Region "Eventos"

    Protected Overrides Sub OnClick(ByVal e As System.EventArgs)

        If Marcado Then
            Marcado = False
        Else
            Marcado = True
        End If

    End Sub

    Protected Overrides Sub OnDoubleClick(ByVal e As System.EventArgs)
        If Marcado Then
            Marcado = False
        Else
            Marcado = True
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)

        Dim g As Graphics = e.Graphics

        DrawBorder(g)

        If Marcado Then

            Dim x As Integer = Me.ClientRectangle.Width * 0.15
            Dim y As Integer = Me.ClientRectangle.Height * 0.15
            Dim an As Integer = Me.ClientRectangle.Width * 0.65
            Dim al As Integer = Me.ClientRectangle.Height * 0.65

            Dim mipen As New Pen(ColorMarcado, an * 0.175)

            mipen.StartCap = LineCap.Triangle
            mipen.EndCap = LineCap.Triangle

            If TipoMarcado = eTipoMarcado.Equis Then

                g.DrawLine(mipen, x, y, x + an, y + al)
                g.DrawLine(mipen, x, y + al, x + an, y)

            Else

                Dim ean As Integer = (x + an) * 0.5
                Dim eal As Integer = (y + al) * 0.7

                g.DrawLine(mipen, x, eal, ean, y + al)

                mipen.Width = an * 0.2
                g.DrawLine(mipen, ean, y + al, x + an, y)

            End If

        End If


        g.Dispose()

    End Sub

#End Region

End Class
