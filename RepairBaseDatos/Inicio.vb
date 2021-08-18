Public Class Inicio

    Private Sub Comprobar()
        '  If Me.MaskedTextBox1.Text = "SonyteC1511" Then
        Dim frm As New BaseDatos
        frm.Show()
        Me.Close()
        'Else
        'MsgBox("Contraseña Erronea")
        'End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Comprobar()
    End Sub

    Private Sub MaskedTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MaskedTextBox1.KeyDown
        If e.KeyValue = Keys.Enter Then
            Comprobar()
        End If
    End Sub

End Class
