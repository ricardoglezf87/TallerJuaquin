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

Public Class MaskedTextEditControl
    Inherits MaskedTextBox
    Implements IDataGridViewEditingControl

    Private nNumeroFila As Integer
    Private oDGV As DataGridView
    Private bValorCambiado As Boolean = False


    Public Sub ApplyCellStyleToEditingControl(ByVal dataGridViewCellStyle As System.Windows.Forms.DataGridViewCellStyle) Implements System.Windows.Forms.IDataGridViewEditingControl.ApplyCellStyleToEditingControl
        Me.Font = dataGridViewCellStyle.Font
        Me.ForeColor = dataGridViewCellStyle.ForeColor
        Me.BackColor = dataGridViewCellStyle.BackColor
    End Sub

    Public Property EditingControlDataGridView() As System.Windows.Forms.DataGridView Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlDataGridView
        Get
            Return oDGV
        End Get
        Set(ByVal value As System.Windows.Forms.DataGridView)
            oDGV = value
        End Set
    End Property

    Public Property EditingControlFormattedValue() As Object Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlFormattedValue
        Get
            Return Me.Text
        End Get
        Set(ByVal value As Object)
            Me.Text = value
        End Set
    End Property

    Public Property EditingControlRowIndex() As Integer Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlRowIndex
        Get
            Return nNumeroFila
        End Get
        Set(ByVal value As Integer)
            nNumeroFila = value
        End Set
    End Property

    Public Property EditingControlValueChanged() As Boolean Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlValueChanged
        Get
            Return bValorCambiado
        End Get
        Set(ByVal value As Boolean)
            bValorCambiado = value
        End Set
    End Property

    Public Function EditingControlWantsInputKey(ByVal keyData As System.Windows.Forms.Keys, ByVal dataGridViewWantsInputKey As Boolean) As Boolean Implements System.Windows.Forms.IDataGridViewEditingControl.EditingControlWantsInputKey
        Select Case keyData And Keys.KeyCode
            Case Keys.Left, Keys.Up, Keys.Right, Keys.Down, Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp
                Return True
            Case Else
                Return False
        End Select
    End Function

    Public ReadOnly Property EditingPanelCursor() As System.Windows.Forms.Cursor Implements System.Windows.Forms.IDataGridViewEditingControl.EditingPanelCursor
        Get
            Return MyBase.Cursor
        End Get
    End Property

    Public Function GetEditingControlFormattedValue(ByVal context As System.Windows.Forms.DataGridViewDataErrorContexts) As Object Implements System.Windows.Forms.IDataGridViewEditingControl.GetEditingControlFormattedValue
        Return Me.Text
    End Function

    Public Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) Implements System.Windows.Forms.IDataGridViewEditingControl.PrepareEditingControlForEdit

    End Sub

    Public ReadOnly Property RepositionEditingControlOnValueChange() As Boolean Implements System.Windows.Forms.IDataGridViewEditingControl.RepositionEditingControlOnValueChange
        Get
            Return False
        End Get
    End Property

    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        bValorCambiado = True
        Me.EditingControlDataGridView.NotifyCurrentCellDirty(True)
        MyBase.OnTextChanged(e)
    End Sub


End Class



