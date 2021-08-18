Imports System.IO
Imports System.Xml.Serialization
Imports DataBaseLib
Imports Reports
Imports Microsoft.Win32

Public Class Aviso

    Private avi As List(Of Integer) = New List(Of Integer)()
    Private lst As List(Of ItemInfo) = New List(Of ItemInfo)()
    Private inicio As Boolean = True

#Region "Exit Windows"
    Const WM_QUERYENDSESSION As Integer = &H11

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        If (m.Msg = WM_QUERYENDSESSION) Then
            Environment.Exit(0)
        End If

        MyBase.WndProc(m)
    End Sub

#End Region

    Public Sub New()

        InitializeComponent()

        Notificador.ShowBalloonTip(1, "Agenda Joaquín", "Bienvenido a su Agenda", Windows.Forms.ToolTipIcon.None)

    End Sub

    Private Sub Aviso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Inicializar("compras")
        IniciarOpciones()
        Fuente(Me)
        Dim frm As New BalancePreview("1=1", "Dia", 0)
        frm.debug = True
        frm.WindowState = Windows.Forms.FormWindowState.Normal
        frm.Size = New System.Drawing.Size(1, 1)

        BuscarAvisos()

        Timer1.Interval = (60 - Now.Second) * 1000

        Timer1.Start()

        If lst.Count > 0 Then
            Notificador.ShowBalloonTip(1, "Agenda Joaquín", "Tiene avisos pendientes de revisar", Windows.Forms.ToolTipIcon.None)
        Else
            Notificador.ShowBalloonTip(1, "Agenda Joaquín", "No tiene avisos atrasados", Windows.Forms.ToolTipIcon.None)
        End If

    End Sub

    Private Sub guardar()
        Dim xmls As New XmlSerializer(lst.GetType())
        If ItemsFile.Exists Then

            ItemsFile.Delete()

        End If

        Using s As Stream = ItemsFile.OpenWrite()
            xmls.Serialize(s, lst)
            s.Close()

        End Using
    End Sub

    Private Sub Aviso_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        ToolStripMenuItem1.Visible = False
        MostrarAvisosToolStripMenuItem.Visible = True
        guardar()
        e.Cancel = True
    End Sub

    Private Function findbyID(ByVal ID As Integer) As Integer

        For i As Integer = 0 To lst.Count - 1
            If lst(i).ID = ID Then
                Return i
            End If
        Next

        Return -1

    End Function

    Private Sub RycCheckBox1_MarcadoChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lst(findbyID(CType(sender, RYCCheckBox.RYCCheckBox).Name)).FechaAviso = DateTime.MinValue
    End Sub

    Private Sub Cargar()

        For i As Integer = 0 To avi.Count - 1

            Dim chk As New RYCCheckBox.RYCCheckBox
            chk.Name = avi(i).ToString
            chk.Size = New Drawing.Size(23, 23)
            AddHandler chk.MarcadoChanged, AddressOf RycCheckBox1_MarcadoChanged

            Dim lbl As New Windows.Forms.Label
            lbl.AutoSize = True
            lbl.Text = "El " + lst(findbyID(avi(i))).StartTime.ToLongDateString + " tiene: " + lst(findbyID(avi(i))).Text
            lbl.Name = "l" + avi(i).ToString


            Me.GroupBox1.Controls.Add(chk)
            Me.GroupBox1.Controls.Add(lbl)

            If i = 0 Then
                Me.GroupBox1.Controls(avi(i).ToString).Location = New Drawing.Point(6, 33)
                Me.GroupBox1.Controls("l" + avi(i).ToString).Location = New Drawing.Point(35, 38)
            Else
                Me.GroupBox1.Controls(avi(i).ToString).Location = New Drawing.Point(Me.GroupBox1.Controls(avi(i - 1).ToString).Location.X, Me.GroupBox1.Controls(avi(i - 1).ToString).Bottom + 10)
                Me.GroupBox1.Controls("l" + avi(i).ToString).Location = New Drawing.Point(Me.GroupBox1.Controls("l" + avi(i - 1).ToString).Location.X, Me.GroupBox1.Controls("l" + avi(i - 1).ToString).Bottom + 16)
            End If
        Next

    End Sub

    Public ReadOnly Property ItemsFile() As FileInfo
        Get
            Return New FileInfo(Path.Combine(Environment.CurrentDirectory, "items.xml"))
        End Get
    End Property

    Private Function CompararFecha(ByVal fec1 As DateTime, ByVal fec2 As DateTime) As Integer
        If fec1 = DateTime.MinValue Or fec2 = DateTime.MinValue Then
            Return 100
        End If

        If fec1.Year = fec2.Year And fec1.Month = fec2.Month And fec1.Day = fec2.Day And fec1.Hour = fec2.Hour And fec1.Minute = fec2.Minute Then
            Return 0
        ElseIf fec1 < fec2 Then
            Return -1
        Else
            Return 1
        End If
    End Function

    Private Sub BuscarAvisos()

        If ItemsFile.Exists Then
            Dim xml As New XmlSerializer(lst.GetType())
            Using s As Stream = ItemsFile.OpenRead()
                lst = CType(xml.Deserialize(s), List(Of ItemInfo))
            End Using

            Dim ant As Integer = avi.Count
            avi.Clear()
            Me.GroupBox1.Controls.Clear()

            For Each item As ItemInfo In lst
                If CompararFecha(item.FechaAviso, Now) <= 0 Then
                    avi.Add(item.ID)
                End If
            Next

            If avi.Count <> 0 Then
                If avi.Count <> ant And Not inicio Then
                    Notificador.ShowBalloonTip(1, "Agenda Joaquín", "Tiene avisos pendientes de revisar", Windows.Forms.ToolTipIcon.None)
                End If

                Cargar()
            End If
        End If
    End Sub

    Private Sub Comprobar(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick

        If Now.Minute = 30 Or Now.Minute = 0 Then
            BuscarAvisos()
        End If

        Timer1.Interval = 60000
    End Sub

    Private Sub MostrarAvisosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MostrarAvisosToolStripMenuItem.Click
        ToolStripMenuItem1.Visible = True
        MostrarAvisosToolStripMenuItem.Visible = False
        Me.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        ToolStripMenuItem1.Visible = False
        MostrarAvisosToolStripMenuItem.Visible = True
        Me.Hide()
    End Sub

    Private Sub CerrarProgramaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarProgramaToolStripMenuItem.Click
        Environment.Exit(0)
        Notificador.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub Notificador_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Notificador.DoubleClick, Notificador.Click
        ToolStripMenuItem1.Visible = True
        MostrarAvisosToolStripMenuItem.Visible = False
        Me.Show()
    End Sub

    Private Sub Notificador_BalloonTipShown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Notificador.BalloonTipShown
        If inicio Or lst.Count = 0 Then
            Me.Hide()
            ToolStripMenuItem1.Visible = False
            MostrarAvisosToolStripMenuItem.Visible = True
        Else
            ToolStripMenuItem1.Visible = True
            MostrarAvisosToolStripMenuItem.Visible = False
            Me.Show()
        End If

        inicio = False

    End Sub

End Class