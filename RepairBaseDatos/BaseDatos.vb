Imports DataBaseLib
Imports System.Xml.Serialization
Imports System.IO

Public Class BaseDatos

    Private lst As List(Of ItemInfo) = New List(Of ItemInfo)()

    Public ReadOnly Property ItemsFile() As FileInfo
        Get
            Return New FileInfo(Path.Combine(Environment.CurrentDirectory, "items.xml"))
        End Get
    End Property


    Private Sub BaseDatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        IniciarOpciones()
        Inicializar("cliente,coche,historial,pof,compras")

        DataGridView1.DataSource = dsDatos.Cliente
        DataGridView2.DataSource = dsDatos.TelefonoCliente
        DataGridView3.DataSource = dsDatos.Coche
        DataGridView4.DataSource = dsDatos.Historial
        DataGridView5.DataSource = dsDatos.POF
        DataGridView6.DataSource = dsDatos.ArticuloPOF
        DataGridView7.DataSource = dsImg.ImagenHistorial
        DataGridView8.DataSource = dsDatos.Opciones
        DataGridView9.DataSource = dsDatos.Compras

    End Sub

    Private Sub BaseDatos_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("¿Desea guardar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            ActualizarBaseDatos()
            GuardarOpciones()            
            MsgBox("Guardado con Exito")
        End If
    End Sub

End Class