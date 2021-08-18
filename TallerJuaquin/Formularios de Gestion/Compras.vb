Imports DataBaseLib
Imports DateTime
Imports OnlyNum

Public Class Compras

    Dim binCompras As New BindingSource

#Region "Funciones"

    Private Sub Filtrar()

        Dim cad As String = "1=1 "

        If CheckBox1.Marcado Then
            cad += " and Fecha>=" + " #" + cDesde.Value.ToString("MM-dd-yyyy") + "#"
        End If

        If RycCheckBox1.Marcado Then
            cad += " and Fecha=" + " #" + DateTimePicker1.Value.ToString("MM-dd-yyyy") + "#"
        End If

        If RycCheckBox2.Marcado Then
            cad += " and Fecha<=" + " #" + DateTimePicker2.Value.ToString("MM-dd-yyyy") + "#"
        End If

        If TextBox1.Text <> String.Empty Then
            cad += " and Nota like '%" + TextBox1.Text + "%'"
        End If

        If RycCheckBox3.Marcado Then
            cad += " and Precio = " + NumericUpDown1.Value.ToString
        End If

        binCompras.Filter = cad

    End Sub

    Private Sub CrearCol(ByVal Nombre As String, ByVal Tipo As Integer, Optional ByVal visible As Boolean = True)

        Dim col As New Object

        If Tipo = 1 Then
            col = New DataGridViewTextBoxColumn()
        ElseIf Tipo = 2 Then
            col = New DateTimeColumn
        Else
            col = New OnlyNumTextBoxColumn
        End If

        col.HeaderText = Nombre
        col.Name = Nombre
        col.DataPropertyName = Nombre
        col.Visible = visible
        cTrabajo.Columns.Add(col)

    End Sub

#End Region

#Region "Eventos"

    Private Sub Compras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataBaseLib.Fuente(Me)
        Inicializar("compras")
        binCompras.DataSource = dsDatos.Compras

        cTrabajo.AutoGenerateColumns = False
        cTrabajo.DataSource = binCompras

        CrearCol("Fecha", 2)
        CrearCol("Concepto", 1)
        CrearCol("Precio", 3)

        dsDatos.Compras.FechaColumn.DefaultValue = Date.Now.Date
        dsDatos.Compras.PrecioColumn.DefaultValue = 0
        cTrabajo.Columns(0).Width = 80
        cTrabajo.Columns(2).Width = 100
    End Sub

    Private Sub RycCheckBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RycCheckBox3.MarcadoChanged
        If RycCheckBox3.Marcado Then
            NumericUpDown1.Enabled = True
        Else
            NumericUpDown1.Enabled = False
        End If

        Filtrar()
    End Sub

    Private Sub cGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cGuardar.Click
        Me.CheckBox1.Focus()
        binCompras.EndEdit()

        For Each row As DataGridViewRow In cTrabajo.Rows
            If Not row.Cells(1).Value Is Nothing Then
                If row.Cells(1).Value.ToString.Length <= 1 Then
                    cTrabajo.Rows.Remove(row)
                End If
            End If
        Next

        ActualizarBaseDatos()

    End Sub

    Private Sub RycCheckBox1_MarcadoChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RycCheckBox1.MarcadoChanged
        If RycCheckBox1.Marcado Then
            DateTimePicker1.Enabled = True
            RycCheckBox2.Marcado = False
            CheckBox1.Marcado = False
        Else
            DateTimePicker1.Enabled = False
        End If

        Filtrar()
    End Sub

    Private Sub RycCheckBox2_MarcadoChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RycCheckBox2.MarcadoChanged, RycCheckBox3.MarcadoChanged
        If RycCheckBox2.Marcado Then
            DateTimePicker2.Enabled = True
            RycCheckBox1.Marcado = False
        Else
            DateTimePicker2.Enabled = False
        End If

        Filtrar()
    End Sub

    Private Sub RycCheckBox3_MarcadoChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.MarcadoChanged
        If CheckBox1.Marcado Then
            cDesde.Enabled = True
            RycCheckBox1.Marcado = False
        Else
            cDesde.Enabled = False
        End If

        Filtrar()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged, DateTimePicker2.ValueChanged, cDesde.ValueChanged, TextBox1.TextChanged, NumericUpDown1.ValueChanged
        Filtrar()
    End Sub

#End Region

End Class