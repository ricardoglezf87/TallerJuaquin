Imports System.Windows.Forms
Imports System.Drawing

Public Class DateTimeCell
    Inherits DataGridViewTextBoxCell

    Public Sub New()

    End Sub

    Public Overrides Sub InitializeEditingControl(ByVal rowIndex As Integer, ByVal initialFormattedValue As Object, ByVal dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle)

        Dim datetime As DateTimeEditControl = CType(DataGridView.EditingControl, DateTimeEditControl)
        Dim colmaste As DateTimeColumn = CType(Me.OwningColumn, DateTimeColumn)

        datetime.Format = DateTimePickerFormat.Short
        datetime.Text = initialFormattedValue
        datetime.ForeColor = Color.Chocolate
        datetime.Value = Date.Now        

        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)

    End Sub

    Public Overrides ReadOnly Property EditType() As System.Type
        Get
            Return GetType(DateTimeEditControl)
        End Get
    End Property

    Public Overrides ReadOnly Property ValueType() As System.Type
        Get
            Return GetType(String)
        End Get
    End Property

End Class
