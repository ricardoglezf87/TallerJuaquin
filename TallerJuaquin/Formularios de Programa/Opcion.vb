Imports System.Windows.Forms
Imports DataBaseLib

Public Class Opcion

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click, Button2.Click

        GetRowOpciones.RutaPredeterminada = Me.cPredeterminada.Text
        GetRowOpciones.RutaFondoPantalla = Me.cFondo.Text

        Select Case cTamaño.Text
            Case "Normal"
                GetRowOpciones.TamañoFondoPantalla = "Normal"
            Case "Alargar Imagen"
                GetRowOpciones.TamañoFondoPantalla = "StretchImage"
            Case "Tamaño Automatico"
                GetRowOpciones.TamañoFondoPantalla = "AutoSize"
            Case "Centrar Imagen"
                GetRowOpciones.TamañoFondoPantalla = "CenterImage"
            Case "Zoom"
                GetRowOpciones.TamañoFondoPantalla = "Zoom"
        End Select

        GetRowOpciones.Telefono = cTelefono.Text
        GetRowOpciones.Movil = cMovil.Text        
        GetRowOpciones.Email = cEmail.Text
        GetRowOpciones.WEB = cWEB.Text
        GetRowOpciones.Obervaciones = TextBox1.Text

        GuardarOpciones()

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click, Button3.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Opcion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataBaseLib.Fuente(Me)
        IniciarOpciones()

        Me.cPredeterminada.Text = GetRowOpciones.RutaPredeterminada
        Me.cFondo.Text = GetRowOpciones.RutaFondoPantalla

        Select Case GetRowOpciones.TamañoFondoPantalla
            Case "Normal"
                cTamaño.SelectedIndex = 0
            Case "StretchImage"
                cTamaño.SelectedIndex = 1
            Case "AutoSize"
                cTamaño.SelectedIndex = 2
            Case "CenterImage"
                cTamaño.SelectedIndex = 3
            Case "Zoom"
                cTamaño.SelectedIndex = 4
        End Select

        cTelefono.Text = GetRowOpciones.Telefono
        cMovil.Text = GetRowOpciones.Movil        
        cEmail.Text = GetRowOpciones.Email
        cWEB.Text = GetRowOpciones.WEB
        TextBox1.Text = GetRowOpciones.Obervaciones

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dlg As New FolderBrowserDialog

        dlg.RootFolder = Environment.SpecialFolder.Desktop

        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            cPredeterminada.Text = dlg.SelectedPath
        End If

    End Sub

    Private Sub cPredeterminada_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cPredeterminada.Validated

        If Not My.Computer.FileSystem.DirectoryExists(cPredeterminada.Text) Then
            MsgBox("La ruta no existe, elija otra")
            cPredeterminada.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        End If

    End Sub

    Private Sub cBuscarFondo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBuscarFondo.Click
        Dim dlg As New OpenFileDialog

        dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)

        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            cFondo.Text = dlg.FileNames(0)
        End If
    End Sub

    Private Sub cFondo_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cFondo.Validated
        If Not My.Computer.FileSystem.FileExists(cFondo.Text) Then
            MsgBox("La ruta no existe, elija otra")
            cFondo.Text = Environment.CurrentDirectory + "\Img\car6.jpg"
        End If
    End Sub

End Class
