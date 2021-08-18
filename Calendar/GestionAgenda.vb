Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.Calendar
Imports System.Xml.Serialization
Imports System.IO

Public Class GestionAgenda

    Dim _items As List(Of CalendarItem) = New List(Of CalendarItem)()    
    Dim contextItem As CalendarItem = Nothing
    Dim IDAct As Integer

    Public Sub New()
        InitializeComponent()
        Calendar1.SetViewRange(New DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, 1), New DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, System.DateTime.DaysInMonth(System.DateTime.Now.Year, System.DateTime.Now.Month)))
    End Sub

    Public ReadOnly Property ItemsFile() As FileInfo
        Get
            Return New FileInfo(Path.Combine(Application.StartupPath, "items.xml"))
        End Get
    End Property

    Private Sub GestionAgenda_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        If ItemsFile.Exists Then

            Dim lst As List(Of ItemInfo) = New List(Of ItemInfo)()
            Dim xml As New XmlSerializer(lst.GetType())
            Using s As Stream = ItemsFile.OpenRead()
                lst = CType(xml.Deserialize(s), List(Of ItemInfo))
            End Using

            For Each item As ItemInfo In lst

                Dim cal As New CalendarItem(Calendar1, item.ID, item.StartTime, item.EndTime, item.Text, item.FechaAviso)
                If Not (item.R = 0 AndAlso item.G = 0 AndAlso item.B = 0) Then

                    cal.ApplyColor(Color.FromArgb(item.A, item.R, item.G, item.B))

                End If

                _items.Add(cal)
            Next

            PlaceItems()

        End If

    End Sub

    Private Sub calendar1_LoadItems(ByVal sender As Object, ByVal e As CalendarLoadEventArgs) Handles Calendar1.LoadItems
        PlaceItems()
    End Sub

    Private Sub GestionAgenda_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Dim lst As List(Of ItemInfo) = New List(Of ItemInfo)()

        For Each item As CalendarItem In _items
            lst.Add(New ItemInfo(item.IDItem, item.StartDate, item.EndDate, item.Text, item.BackgroundColor, item.FechaAviso))
        Next

        Dim xmls As New XmlSerializer(lst.GetType())
        If ItemsFile.Exists Then

            ItemsFile.Delete()

        End If

        Using s As Stream = ItemsFile.OpenWrite()
            xmls.Serialize(s, lst)
            s.Close()

        End Using

    End Sub

    Private Sub PlaceItems()
        For Each item As CalendarItem In _items

            If Calendar1.ViewIntersects(item) Then

                Calendar1.Items.Add(item)

            End If

        Next

    End Sub

    Private Sub calendar1_ItemCreated(ByVal sender As Object, ByVal e As CalendarItemCancelEventArgs) Handles Calendar1.ItemCreated

        Dim id As Integer = 0        
        If Calendar1.Items.Count > 1 Then
            id = Calendar1.Items(Calendar1.Items.Count - 2).IDItem + 1
        End If

        e.Item.IDItem = id
        e.Item.FechaAviso = DateTime.MinValue

        _items.Add(e.Item)

        Me.GroupBox1.Visible = False
    End Sub

    Private Sub calendar1_ItemDeleted(ByVal sender As Object, ByVal e As CalendarItemEventArgs) Handles Calendar1.ItemDeleted
        _items.Remove(e.Item)        
        Me.GroupBox1.Visible = False
    End Sub

    Private Sub monthCalendar1_DateChanged_1(ByVal sender As Object, ByVal e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Calendar1.SetViewRange(New DateTime(e.Start.Year, e.Start.Month, 1), New DateTime(e.Start.Year, e.Start.Month, System.DateTime.DaysInMonth(e.Start.Year, e.Start.Month)))
        Me.GroupBox1.Visible = False
    End Sub

    Private Sub contextMenuStrip1_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles ContextMenuStrip1.Opening
        contextItem = Calendar1.ItemAt(ContextMenuStrip1.Bounds.Location)
    End Sub

    Private Sub redTagToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RojoToolStripMenuItem.Click
        For Each item As CalendarItem In Calendar1.GetSelectedItems()

            item.ApplyColor(Color.Red)
            Calendar1.Invalidate(item)

        Next

    End Sub

    Private Sub yellowTagToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AmarilloToolStripMenuItem.Click
        For Each item As CalendarItem In Calendar1.GetSelectedItems()

            item.ApplyColor(Color.Gold)
            Calendar1.Invalidate(item)

        Next

    End Sub

    Private Sub greenTagToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles VerdeToolStripMenuItem.Click
        For Each item As CalendarItem In Calendar1.GetSelectedItems()
            item.ApplyColor(Color.Green)
            Calendar1.Invalidate(item)

        Next

    End Sub

    Private Sub blueTagToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AzulToolStripMenuItem.Click
        For Each item As CalendarItem In Calendar1.GetSelectedItems()
            item.ApplyColor(Color.DarkBlue)
            Calendar1.Invalidate(item)
        Next

    End Sub

    Private Sub otherColorTagToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OtroToolStripMenuItem.Click
        Using dlg As New ColorDialog()
            If dlg.ShowDialog() = DialogResult.OK Then
                For Each item As CalendarItem In Calendar1.GetSelectedItems()
                    item.ApplyColor(dlg.Color)
                    Calendar1.Invalidate(item)
                Next
            End If
        End Using

    End Sub

    Private Sub editItemToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditarToolStripMenuItem.Click
        Calendar1.ActivateEditMode()
    End Sub

    Private Sub NumericUpDown2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown2.ValueChanged
        If Me.NumericUpDown2.Value = 0 Or Me.NumericUpDown2.Value = 30 Or Me.NumericUpDown2.Value = 60 Then
            If Me.NumericUpDown2.Value = 60 Then
                Me.NumericUpDown2.Value = 0
                Me.NumericUpDown1.UpButton()
            End If
        Else
            Me.NumericUpDown2.Value = 0
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If Not CheckBox2.Checked Then
            NumericUpDown1.Enabled = False
            NumericUpDown2.Enabled = False
            DateTimePicker1.Enabled = False
        Else
            NumericUpDown1.Enabled = True
            NumericUpDown2.Enabled = True
            DateTimePicker1.Enabled = True
        End If
    End Sub

    Private Sub Calendar1_ItemDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.Calendar.CalendarItemEventArgs) Handles Calendar1.ItemDoubleClick, Calendar1.ItemClick        
        Me.GroupBox1.Visible = True
        IDAct = e.Item.IDItem

        If e.Item.FechaAviso <> DateTime.MinValue Then
            CheckBox2.Checked = True
            DateTimePicker1.Value = e.Item.FechaAviso
            NumericUpDown1.Value = e.Item.FechaAviso.Hour
            NumericUpDown2.Value = e.Item.FechaAviso.Minute
        Else
            Me.NumericUpDown1.Value = 1
            Me.NumericUpDown2.Value = 0
            Me.DateTimePicker1.Value = DateTime.Now
            CheckBox2.Checked = False
        End If

    End Sub

    Private Sub Calendar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calendar1.Click
        Me.GroupBox1.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each it As CalendarItem In Calendar1.Items
            If it.IDItem = IDAct Then
                If CheckBox2.Checked Then
                    it.FechaAviso = New DateTime(Me.DateTimePicker1.Value.Year, Me.DateTimePicker1.Value.Month, Me.DateTimePicker1.Value.Day, Me.NumericUpDown1.Value, Me.NumericUpDown2.Value, 0)
                Else
                    it.FechaAviso = DateTime.MinValue
                End If
            End If
        Next
    End Sub

End Class