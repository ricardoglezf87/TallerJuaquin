<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aviso
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Aviso))
        Me.Notificador = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MostrarAvisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.Ocultar_Avisos = New System.Windows.Forms.ToolStripSeparator
        Me.CerrarProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Notificador
        '
        Me.Notificador.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.Notificador.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Notificador.Icon = CType(resources.GetObject("Notificador.Icon"), System.Drawing.Icon)
        Me.Notificador.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MostrarAvisosToolStripMenuItem, Me.ToolStripMenuItem1, Me.Ocultar_Avisos, Me.CerrarProgramaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(162, 76)
        '
        'MostrarAvisosToolStripMenuItem
        '
        Me.MostrarAvisosToolStripMenuItem.Name = "MostrarAvisosToolStripMenuItem"
        Me.MostrarAvisosToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.MostrarAvisosToolStripMenuItem.Text = "Mostrar avisos"
        Me.MostrarAvisosToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.ToolStripMenuItem1.Text = "Ocultar Avisos"
        '
        'Ocultar_Avisos
        '
        Me.Ocultar_Avisos.Name = "Ocultar_Avisos"
        Me.Ocultar_Avisos.Size = New System.Drawing.Size(158, 6)
        '
        'CerrarProgramaToolStripMenuItem
        '
        Me.CerrarProgramaToolStripMenuItem.Name = "CerrarProgramaToolStripMenuItem"
        Me.CerrarProgramaToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.CerrarProgramaToolStripMenuItem.Text = "Cerrar Programa"
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(561, 434)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Avisos"
        '
        'Aviso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 462)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Aviso"
        Me.Text = "Aviso"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Notificador As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MostrarAvisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Ocultar_Avisos As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CerrarProgramaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
