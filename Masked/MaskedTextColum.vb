Imports System.Windows.Forms

Public Class MaskedTextColumn
    Inherits DataGridViewColumn

    Private _Mascara As String
    Public Property Mascara()
        Get
            Return _Mascara
        End Get
        Set(ByVal value)
            _Mascara = value
        End Set
    End Property

    Public Sub New()
        MyBase.New(New MaskedTextCell())
    End Sub

    Public Overrides Property CellTemplate() As System.Windows.Forms.DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As System.Windows.Forms.DataGridViewCell)
            MyBase.CellTemplate = value
        End Set
    End Property


End Class