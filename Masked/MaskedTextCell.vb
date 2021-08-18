Imports System.Windows.Forms
Imports System.Drawing

Public Class MaskedTextCell
    Inherits DataGridViewTextBoxCell

    Public Sub New()

    End Sub

    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, ByVal initialFormattedValue As Object, ByVal dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle)

        Dim masked As MaskedTextEditControl = CType(DataGridView.EditingControl, MaskedTextEditControl)
        Dim colmaste As MaskedTextColumn = CType(Me.OwningColumn, MaskedTextColumn)


        masked.Text = initialFormattedValue
        masked.ForeColor = Color.Chocolate
        masked.Mask = colmaste.Mascara

        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)

    End Sub

    Public Overrides ReadOnly Property EditType() As System.Type
        Get
            Return GetType(MaskedTextEditControl)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType() As System.Type
        Get
            Return GetType(String)
        End Get
    End Property

End Class
