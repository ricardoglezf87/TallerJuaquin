Imports System.Windows.Forms

Public Class DateTimeColumn
    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New DateTimeCell())
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