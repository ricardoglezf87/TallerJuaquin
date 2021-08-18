Public Class Progreso

    Public Sub New(ByVal Maximo As Integer)

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.ProgressBar1.Maximo = Maximo
        Me.ProgressBar1.ColorBarra = Color.LightGreen
        Me.Label1.Text = "0 de " + Maximo.ToString + " Imagenes Procesadas"
        Me.Label1.Update()

    End Sub

    Public Sub StepProgress()
        Me.ProgressBar1.Avanzar()
        Me.Focus()
        Me.Label1.Text = Me.ProgressBar1.Valor.ToString + " de " + Me.ProgressBar1.Maximo.ToString + " Imagenes Procesadas"
        Me.Label1.Update()
        Me.ProgressBar1.Update()
    End Sub


    Private Sub Progreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataBaseLib.Fuente(Me)
    End Sub

End Class