Public Class ImportBackup

    Private Sub Procesos()

        If Process.GetProcessesByName("GestionAvisos").Length > 0 Then
            Process.GetProcessesByName("GestionAvisos")(0).Kill()
        End If

        If Process.GetProcessesByName("Taller Joaquín").Length > 0 Then
            MessageBox.Show("Guarde los datos en el programas de Taller", "Programas abiertos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Process.GetProcessesByName("Taller Joaquín")(0).Kill()
        End If

        If Process.GetProcessesByName("Agenda").Length > 0 Then
            MessageBox.Show("Guarde los datos en el programas de Agenda", "Programas abiertos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Process.GetProcessesByName("Agenda")(0).Kill()
        End If

    End Sub

    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Dim dlg As New OpenFileDialog

        dlg.InitialDirectory = Environment.CurrentDirectory
        dlg.Filter = "Archivo de Copia de Seguridad (*.rbk)|*.rbk"
        dlg.FilterIndex = 0
        dlg.DefaultExt = "*.ryc"

        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Ruta.Text = dlg.FileNames(0)
        End If

    End Sub

    Private Sub Make_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Make.Click

        If My.Computer.FileSystem.FileExists(Ruta.Text) Then

            Dim zip As New ZipUtil(Me)
            Progreso.Value = 0

            If My.Computer.FileSystem.FileExists(Environment.CurrentDirectory + "\BindingSource.mdf") Then
                My.Computer.FileSystem.DeleteFile(Environment.CurrentDirectory + "\BindingSource.mdf", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            End If

            Progreso.Value += 10
            If My.Computer.FileSystem.FileExists(Environment.CurrentDirectory + "\BindingSource_log.ldf") Then
                My.Computer.FileSystem.DeleteFile(Environment.CurrentDirectory + "\BindingSource_log.ldf", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            End If

            Progreso.Value += 10
            If My.Computer.FileSystem.FileExists(Environment.CurrentDirectory + "\DataImg.ryc") Then
                My.Computer.FileSystem.DeleteFile(Environment.CurrentDirectory + "\DataImg.ryc", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            End If

            Progreso.Value += 10
            If My.Computer.FileSystem.FileExists(Environment.CurrentDirectory + "\opc.xml") Then
                My.Computer.FileSystem.DeleteFile(Environment.CurrentDirectory + "\opc.xml", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            End If

            Progreso.Value += 10
            If My.Computer.FileSystem.FileExists(Environment.CurrentDirectory + "\items.xml") Then
                My.Computer.FileSystem.DeleteFile(Environment.CurrentDirectory + "\items.xml", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            End If
            Progreso.Value += 10


            zip.Descomprimir(Environment.CurrentDirectory, Ruta.Text, False, False)

            Progreso.Value = 100
            MsgBox("Operación realizada con exito")
            Progreso.Value = 0

        Else
            MsgBox("Debe elegir un fichero existente")
        End If

    End Sub

    Private Sub ImportBackup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Procesos()
        DataBaseLib.Fuente(Me)
    End Sub

    Private Sub ImportBackup_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim startInfo As New ProcessStartInfo("GestionAvisos.exe")
        Process.Start(startInfo)
    End Sub
End Class
