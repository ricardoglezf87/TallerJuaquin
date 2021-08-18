Imports System.Windows.Forms
Imports System.Drawing

Public Class OnlyNumTextBox
    Inherits DataGridViewTextBoxCell

    Public Sub New()

    End Sub

    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, ByVal initialFormattedValue As Object, ByVal dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle)

        Dim Text As OnlyNumTextBoxEditControl = CType(DataGridView.EditingControl, OnlyNumTextBoxEditControl)
        Dim colText As OnlyNumTextBoxColumn = CType(Me.OwningColumn, OnlyNumTextBoxColumn)

        Text.Text = initialFormattedValue
        Text.ForeColor = Color.Chocolate        

        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)

    End Sub

    Public Overrides ReadOnly Property EditType() As System.Type
        Get
            Return GetType(OnlyNumTextBoxEditControl)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType() As System.Type
        Get
            Return GetType(String)
        End Get
    End Property

End Class




