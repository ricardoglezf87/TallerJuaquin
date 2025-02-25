﻿Imports System.Windows.Forms

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

