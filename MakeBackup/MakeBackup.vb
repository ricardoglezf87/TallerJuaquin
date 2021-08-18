Public Class MakeBackup
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

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Procesos()
        DataBaseLib.Fuente(Me)
        Ruta.Text = Environment.CurrentDirectory
    End Sub

    Private Sub Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buscar.Click
        Dim dlg As New FolderBrowserDialog

        dlg.RootFolder = Environment.SpecialFolder.Desktop

        If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Ruta.Text = dlg.SelectedPath
        End If
    End Sub

    Private Sub Make_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Make.Click

        If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\TempBk") Then
            My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\TempBk")
        End If

        Dim zip As New ZipUtil(Me)
        Progreso.Value = 0

        zip.Comprimir(New String() {"BindingSource.mdf", "BindingSource_log.ldf", "DataImg.ryc", "opc.xml", "items.xml"}, Ruta.Text + "\Backup.rbk")
        zip.Comprimir(New String() {"BindingSource.mdf", "BindingSource_log.ldf", "DataImg.ryc", "opc.xml", "items.xml"}, Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\TempBk\Backup.rbk")

        Progreso.Value = 100
        MsgBox("Operación realizada con exito")
        Progreso.Value = 0
    End Sub

    Private Sub ImportBackup_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim startInfo As New ProcessStartInfo("GestionAvisos.exe")
        Process.Start(startInfo)
    End Sub

End Class
